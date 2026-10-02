using System.ComponentModel;
using InsuranceAnalyzer.Data;
using InsuranceAnalyzer.Data.Logging;
using InsuranceAnalyzer.Data.Reports;
using InsuranceAnalyzer.Domain.Entities;
using InsuranceAnalyzer.Domain.Interfaces;

namespace InsuranceAnalyzer.UI.Forms;

public partial class MainForm : Form
{
    private const int PageSize = 100;
    private readonly InsuranceDataService _dataService = new();
    private readonly BindingList<InsuranceRecord> _rows = new();
    private readonly List<string> _recentFiles;
    private readonly RecentFilesService _recentFilesService = new();
    private readonly FileLogger _logger;
    private List<InsuranceRecord> _allRows = new();
    private List<InsuranceRecord> _displayRows = new();
    private FilterOptions _filterOptions = new();
    private string _sortField = "";
    private bool _sortAscending = true;
    private string _currentPath = "";
    private ExportOptions _currentExportOptions = new();
    private int _currentPage;
    private bool _controlsReady;
    private bool _updatingChartFields;

    public MainForm()
    {
        InitializeComponent();
        _logger = new FileLogger(Path.Combine(AppContext.BaseDirectory, "Outputs"));
        _recentFiles = _recentFilesService.Load();
        dataGridViewRecords.DataSource = _rows;
        dataGridViewRecords.ReadOnly = true;
        dataGridViewRecords.AllowUserToAddRows = false;
        dataGridViewRecords.AllowUserToDeleteRows = false;
        dataGridViewRecords.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dataGridViewRecords.MultiSelect = false;
        dataGridViewRecords.SelectionChanged += dataGridViewRecords_SelectionChanged;
        comboBoxSearchField.Items.AddRange(new object[] { "Age", "Sex", "Bmi", "Children", "Smoker", "Region", "Charges" });
        comboBoxSearchField.SelectedIndex = 0;
        comboBoxChartType.SelectedIndex = 0;
        UpdateChartFields();
        comboBoxSortField.SelectedIndex = 0;
        comboBoxSortOrder.SelectedIndex = 0;
        buttonEdit.Enabled = false;
        _controlsReady = true;
        LoadDefaultDataset();
        UpdateStatus();
    }

    private void menuOpen_Click(object? sender, EventArgs e) 
    { 
        OpenFile(); 
    }
    private void menuSave_Click(object? sender, EventArgs e) 
    { 
        SaveCurrentFile(); 
    }
    private void menuSaveAs_Click(object? sender, EventArgs e) 
    { 
        SaveFile(); 
    }
    private void buttonResetFilter_Click(object? sender, EventArgs e) 
    { 
        ResetFilters(); 
    }
    private void buttonDelete_Click(object? sender, EventArgs e) 
    { 
        DeleteSelected(); 
    }
    private void buttonAdd_Click(object? sender, EventArgs e) 
    { 
        AddRecord(); 
    }
    private void buttonEdit_Click(object? sender, EventArgs e) 
    { 
        EditSelected(); 
    }
    private void textBoxSearch_TextChanged(object? sender, EventArgs e)
    {
        if (_controlsReady) 
            RefreshView();
    }

    private void filterControl_ValueChanged(object? sender, EventArgs e)
    {
        if (!_controlsReady) 
            return;
        _filterOptions = ReadFilterOptions();
        RefreshView();
    }
    private void buttonSort_Click(object? sender, EventArgs e) 
    { 
        SortRecords(); 
    }
    private void buttonPreviousPage_Click(object? sender, EventArgs e) 
    { 
        ChangePage(-1); 
    }
    private void buttonNextPage_Click(object? sender, EventArgs e) 
    { 
        ChangePage(1); 
    }
    private void buttonBuildChart_Click(object? sender, EventArgs e) 
    { 
        DrawChart(); 
    }
    private void buttonExportChart_Click(object? sender, EventArgs e) 
    { 
        ExportChart(); 
    }
    private void comboBoxChartType_SelectedIndexChanged(object? sender, EventArgs e) 
    { 
        UpdateChartFields(); 
    }
    private void comboBoxChartX_SelectedIndexChanged(object? sender, EventArgs e)
    {
        if (!_updatingChartFields && comboBoxChartType.Text == "Лінійний") 
            UpdateChartYFields(true);
    }
    private void menuXlsxReport_Click(object? sender, EventArgs e) 
    { 
        GenerateReport(new XlsxReportService(), "xlsx"); 
    }
    private void menuDocxReport_Click(object? sender, EventArgs e) 
    { 
        GenerateReport(new DocxReportService(), "docx"); 
    }
    private void menuAnalysis_Click(object? sender, EventArgs e)
    {
        using var form = new AnalysisForm(_displayRows);
        form.ShowDialog(this);
    }
    private void menuRecentFiles_DropDownOpening(object? sender, EventArgs e) 
    { 
        FillRecentFilesMenu(); 
    }
    private void menuExit_Click(object? sender, EventArgs e) 
    { 
        Close(); 
    }

    private void OpenFile()
    {
        if (openFileDialogData.ShowDialog() != DialogResult.OK) 
            return;
        OpenFile(openFileDialogData.FileName);
    }

    private void OpenFile(string path)
    {
        try
        {
            if (IsLocked(path)) 
                throw new IOException("Файл відкрито іншою програмою.");
            using var form = new ImportOptionsForm(path);
            if (form.ShowDialog(this) != DialogResult.OK) 
                return;

            var imported = _dataService.Import(path, form.Options);
            LoadData(imported);
            _currentPath = Path.GetFullPath(path);
            _currentExportOptions = new ExportOptions { EncodingName = form.Options.EncodingName, Delimiter = form.Options.Delimiter };
            AddRecent(_currentPath); _logger.Write("Імпорт", _currentPath);
            UpdateStatus();
        }
        catch (Exception exception) 
        { 
            HandleError(exception); 
        }
    }

    private void SaveFile()
    {
        if (saveFileDialogData.ShowDialog() != DialogResult.OK) 
            return;
        try
        {
            using var form = new ExportOptionsForm(Path.GetExtension(saveFileDialogData.FileName));
            if (form.ShowDialog(this) != DialogResult.OK) 
                return;

            _dataService.Export(saveFileDialogData.FileName, _allRows, form.Options);
            _currentPath = Path.GetFullPath(saveFileDialogData.FileName);
            _currentExportOptions = form.Options;
            AddRecent(_currentPath);
            _logger.Write("Експорт", _currentPath);
            UpdateStatus();
            ShowSaveSuccess(_currentPath);
        }
        catch (Exception exception) 
        { 
            HandleError(exception); 
        }
    }

    private void SaveCurrentFile()
    {
        if (string.IsNullOrWhiteSpace(_currentPath))
        {
            SaveFile();
            return;
        }

        try
        {
            if (IsLocked(_currentPath)) 
                throw new IOException("Файл відкрито іншою програмою.");

            _dataService.Export(_currentPath, _allRows, _currentExportOptions);
            _logger.Write("Збереження", _currentPath);
            UpdateStatus();
            ShowSaveSuccess(_currentPath);
        }
        catch (Exception exception) 
        { 
            HandleError(exception); 
        }
    }

    private static void ShowSaveSuccess(string path)
    {
        MessageBox.Show($"Файл успішно збережено:\n{path}", "Збереження", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private void ResetFilters()
    {
        numericAgeFrom.Value = 0;
        numericAgeTo.Value = 120;
        numericBmiFrom.Value = 0;
        numericBmiTo.Value = 100;
        numericChildrenFrom.Value = 0;
        numericChildrenTo.Value = 50;
        numericChargesFrom.Value = 0;
        numericChargesTo.Value = 1000000;
        comboBoxSex.SelectedIndex = 0;
        comboBoxSmoker.SelectedIndex = 0;
        comboBoxRegion.SelectedIndex = 0;
        textBoxSearch.Clear();
        _filterOptions = new FilterOptions();
        _sortField = "";
        RefreshView();
    }

    private FilterOptions ReadFilterOptions()
    {
        return new FilterOptions
        {
            AgeFrom = (int)numericAgeFrom.Value,
            AgeTo = (int)numericAgeTo.Value,
            BmiFrom = numericBmiFrom.Value,
            BmiTo = numericBmiTo.Value,
            ChildrenFrom = (int)numericChildrenFrom.Value,
            ChildrenTo = (int)numericChildrenTo.Value,
            ChargesFrom = numericChargesFrom.Value,
            ChargesTo = numericChargesTo.Value,
            Sex = comboBoxSex.Text,
            Smoker = comboBoxSmoker.Text,
            Region = comboBoxRegion.Text
        };
    }

    private void RefreshView()
    {
        try
        {
            var rows = _dataService.Filter(_allRows, _filterOptions);
            rows = _dataService.Search(rows, comboBoxSearchField.Text, textBoxSearch.Text);
            if (!string.IsNullOrEmpty(_sortField)) 
                rows = _dataService.Sort(rows, _sortField, _sortAscending);
            ShowRows(rows);
        }
        catch (Exception exception) 
        { 
            HandleError(exception); 
        }
    }

    private void DeleteSelected()
    {
        var currentRow = dataGridViewRecords.CurrentRow;
        if (currentRow == null) 
            return;

        var row = currentRow.DataBoundItem as InsuranceRecord;
        if (row == null) 
            return;

        if (MessageBox.Show("Видалити вибраний запис?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) 
            return;

        for (var index = _allRows.Count - 1; index >= 0; index--)
            if (_allRows[index].Id == row.Id) 
                _allRows.RemoveAt(index);
        RefreshView();
    }

    private void AddRecord()
    {
        using var form = new InsuranceRecordForm();
        if (form.ShowDialog(this) != DialogResult.OK) 
            return;
        var record = form.ResultRecord;
        record.Id = 1;
        if (_allRows.Count > 0)
            record.Id = _allRows.Max(row => row.Id) + 1;
        record.PatientId = record.Id;
        record.Patient.Id = record.PatientId;
        SaveRecord(record, null);
    }

    private void EditSelected()
    {
        var currentRow = dataGridViewRecords.CurrentRow;
        if (currentRow == null) 
            return;
        var selected = currentRow.DataBoundItem as InsuranceRecord;
        if (selected == null) 
            return;
        using var form = new InsuranceRecordForm(selected);
        if (form.ShowDialog(this) != DialogResult.OK) 
            return;
        SaveRecord(form.ResultRecord, selected);
    }

    private void SaveRecord(InsuranceRecord record, InsuranceRecord? previous)
    {
        var error = _dataService.Validate(record);
        if (error != null)
        {
            MessageBox.Show(error, "Некоректні дані", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }
        if (previous == null)
            _allRows.Add(record);
        else
        {
            for (var index = 0; index < _allRows.Count; index++)
            {
                if (_allRows[index].Id == previous.Id)
                {
                    _allRows[index] = record;
                    break;
                }
            }
        }
        RefreshView();
    }

    private void SortRecords()
    {
        _sortField = comboBoxSortField.Text;
        _sortAscending = comboBoxSortOrder.Text == "За зростанням";
        RefreshView();
    }

    private void DrawChart()
    {
        if (_displayRows.Count == 0) 
            return;
        if (comboBoxChartType.Text == "Лінійний" && comboBoxChartX.Text == comboBoxChartY.Text)
        {
            MessageBox.Show("Для лінійного графіка оберіть різні поля X і Y.", "Налаштування графіка", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }
        formsPlotChart.Reset(new ScottPlot.Plot());
        switch (comboBoxChartType.Text)
        {
            case "Стовпчиковий": 
                DrawBarChart(); break;
            case "Круговий": 
                DrawPieChart(); break;
            default: 
                DrawLineChart(); break;
        }
        formsPlotChart.Plot.Axes.AutoScale();
        formsPlotChart.Refresh();
    }

    private void UpdateChartFields()
    {
        var numericFields = new object[] { "Age", "Bmi", "Children", "Charges" };
        var categoryFields = new object[] { "Region", "Sex", "Smoker" };
        _updatingChartFields = true;
        comboBoxChartX.Items.Clear();

        if (comboBoxChartType.Text == "Лінійний")
            comboBoxChartX.Items.AddRange(numericFields);
        else
            comboBoxChartX.Items.AddRange(categoryFields);

        comboBoxChartX.SelectedIndex = 0;
        comboBoxChartY.Enabled = comboBoxChartType.Text != "Круговий";
        labelChartY.Enabled = comboBoxChartY.Enabled;
        UpdateChartYFields(comboBoxChartType.Text == "Лінійний");
        _updatingChartFields = false;
    }

    private void UpdateChartYFields(bool excludeXField)
    {
        var numericFields = new object[] { "Age", "Bmi", "Children", "Charges" };
        comboBoxChartY.Items.Clear();
        if (excludeXField)
            comboBoxChartY.Items.AddRange(numericFields.Where(field => !Equals(field, comboBoxChartX.Text)).ToArray());
        else
            comboBoxChartY.Items.AddRange(numericFields);

        if (comboBoxChartY.Items.Count > 0)
            comboBoxChartY.SelectedIndex = 0;
    }

    private void ExportChart()
    {
        try
        {
            var folder = GetOutputFolder("Charts");
            Directory.CreateDirectory(folder);
            var path = Path.Combine(folder, $"chart_{DateTime.Now:yyyyMMdd_HHmmss}.png");
            formsPlotChart.Plot.SavePng(path, 1000, 600);
            _logger.Write("Графік", path);
            MessageBox.Show($"Графік збережено:\n{path}", "Експорт PNG");
        }
        catch (Exception exception)
        {
            HandleError(exception);
        }
    }

    private void GenerateReport(IReportService service, string extension)
    {
        try
        {
            var folder = GetOutputFolder("Reports");
            var chartFolder = GetOutputFolder("Charts");
            Directory.CreateDirectory(folder);
            Directory.CreateDirectory(chartFolder);
            var charts = Directory.GetFiles(chartFolder, "*.png").ToList();
            var path = Path.Combine(folder, $"report_{DateTime.Now:yyyyMMdd_HHmmss}.{extension}");
            service.Create(path, _allRows, charts);
            _logger.Write("Звіт", path);
            MessageBox.Show($"Звіт збережено:\n{path}", "Створення звіту");
        }
        catch (Exception exception)
        {
            HandleError(exception);
        }
    }

    private void dataGridViewRecords_SelectionChanged(object? sender, EventArgs e)
    {
        var currentRow = dataGridViewRecords.CurrentRow;
        buttonEdit.Enabled = currentRow != null && currentRow.DataBoundItem is InsuranceRecord;
    }

    private void LoadData(List<InsuranceRecord> rows)
    {
        _allRows = rows;
        PopulateFilterChoices();
        _filterOptions = new FilterOptions();
        RefreshView();
    }

    private void ShowRows(List<InsuranceRecord> rows, bool resetPage = true)
    {
        _displayRows = rows;
        if (resetPage)
            _currentPage = 0;
        FillCurrentPage();
        UpdateStatus();
    }

    private void ChangePage(int direction)
    {
        var pageCount = Math.Max(1, (int)Math.Ceiling(_displayRows.Count / (double)PageSize));
        _currentPage = Math.Clamp(_currentPage + direction, 0, pageCount - 1);
        FillCurrentPage();
    }

    private void FillCurrentPage()
    {
        _rows.RaiseListChangedEvents = false;
        _rows.Clear();
        foreach (var row in _displayRows.Skip(_currentPage * PageSize).Take(PageSize)) 
            _rows.Add(row);

        _rows.RaiseListChangedEvents = true;
        _rows.ResetBindings();
        ResizeGridColumns();

        var pageCount = Math.Max(1, (int)Math.Ceiling(_displayRows.Count / (double)PageSize));
        labelPage.Text = $"Сторінка {_currentPage + 1} з {pageCount}";
        labelTotalRecords.Text = $"Всього записів: {_displayRows.Count}";
        buttonPreviousPage.Enabled = _currentPage > 0;
        buttonNextPage.Enabled = _currentPage + 1 < pageCount;
    }

    private void PopulateFilterChoices()
    {
        FillChoice(comboBoxSex, _allRows.Select(row => row.Sex));
        FillChoice(comboBoxSmoker, _allRows.Select(row => row.Smoker));
        FillChoice(comboBoxRegion, _allRows.Select(row => row.Region));
    }

    private static void FillChoice(ComboBox comboBox, IEnumerable<string> values)
    {
        comboBox.Items.Clear();
        comboBox.Items.Add("УСІ");
        comboBox.Items.AddRange(values.Where(value => !string.IsNullOrWhiteSpace(value))
            .Distinct(StringComparer.OrdinalIgnoreCase).OrderBy(value => value).Cast<object>().ToArray());
        comboBox.SelectedIndex = 0;
    }


    private void groupBoxRecords_Resize(object? sender, EventArgs e)
    {
        var width = buttonPreviousPage.Width + labelPage.Width + buttonNextPage.Width + 22;
        var left = (groupBoxRecords.ClientSize.Width - width) / 2;
        buttonPreviousPage.Left = left;
        labelPage.Left = buttonPreviousPage.Right + 10;
        buttonNextPage.Left = labelPage.Right + 10;
    }

    private void AddRecent(string path)
    {
        _recentFilesService.Add(path, _recentFiles);
    }
    private void FillRecentFilesMenu()
    {
        menuRecentFiles.DropDownItems.Clear();
        if (_recentFiles.Count == 0) 
            menuRecentFiles.DropDownItems.Add("Список порожній").Enabled = false;
        foreach (var path in _recentFiles)
        {
            var item = new ToolStripMenuItem(Path.GetFileName(path)) { ToolTipText = path, Tag = path };
            item.Click += recentFile_Click;
            menuRecentFiles.DropDownItems.Add(item);
        }
    }

    private void recentFile_Click(object? sender, EventArgs e)
    {
        var item = sender as ToolStripMenuItem;
        if (item == null) 
            return;
        var path = item.Tag as string;
        if (string.IsNullOrWhiteSpace(path)) 
            return;
        OpenFile(path);
    }

    private void UpdateStatus()
    {
        toolStripStatusLabelPath.Text = $"Файл: {_currentPath}";
        toolStripStatusLabelCount.Text = $"Записів: {_displayRows.Count}";
        toolStripStatusLabelTime.Text = $"Операція: {DateTime.Now:HH:mm:ss}";
    }

    private static bool IsLocked(string path)
    {
        try
        {
            using var stream = File.Open(path, FileMode.Open, FileAccess.Read, FileShare.None);
            return false;
        }
        catch (IOException)
        {
            return true;
        }
    }

    private void HandleError(Exception exception)
    {
        _logger.Write("Помилка", exception.Message);
        MessageBox.Show(exception.Message, "Не вдалося виконати операцію", MessageBoxButtons.OK, MessageBoxIcon.Warning);
    }

    private static string GetOutputFolder(string folderName)
    {
        var directory = new DirectoryInfo(AppContext.BaseDirectory);
        while (directory != null && !File.Exists(Path.Combine(directory.FullName, "Laba_1_2.sln")))
            directory = directory.Parent;

        var rootFolder = AppContext.BaseDirectory;
        if (directory != null) 
            rootFolder = directory.FullName;
        return Path.Combine(rootFolder, "Outputs", folderName);
    }

    private void LoadDefaultDataset()
    {
        var path = GetDefaultDatasetPath();
        if (!File.Exists(path)) 
            return;
        try 
        { 
            LoadData(_dataService.Import(path, new ImportOptions())); 
            _currentPath = Path.GetFullPath(path); 
            AddRecent(_currentPath); 
        }
        catch (Exception exception) 
        { 
            HandleError(exception); 
        }
    }

    private static string GetDefaultDatasetPath()
    {
        var directory = new DirectoryInfo(AppContext.BaseDirectory);
        while (directory is not null)
        {
            var projectDataset = Path.Combine(directory.FullName, "UI", "Datasets", "insurance.csv");
            if (File.Exists(projectDataset)) 
                return projectDataset;
            directory = directory.Parent;
        }

        return Path.Combine(AppContext.BaseDirectory, "Datasets", "insurance.csv");
    }

    private void ResizeGridColumns()
    {
        dataGridViewRecords.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        if (dataGridViewRecords.Columns["Id"] is { } idColumn) 
            idColumn.FillWeight = 45;
        if (dataGridViewRecords.Columns["Age"] is { } ageColumn) 
            ageColumn.FillWeight = 55;
        if (dataGridViewRecords.Columns["Children"] is { } childrenColumn) 
            childrenColumn.FillWeight = 75;
    }

    private void DrawLineChart()
    {
        var xField = comboBoxChartX.Text; 
        var yField = comboBoxChartY.Text;
        var points = _displayRows.GroupBy(row => ReadNumber(row, xField)).OrderBy(group => group.Key).ToList();
        formsPlotChart.Plot.Add.Scatter(points.Select(group => (double)group.Key).ToArray(), points.Select(group => (double)group.Average(row => ReadNumber(row, yField))).ToArray());
        formsPlotChart.Plot.Title($"Середнє значення {yField} за {xField}"); formsPlotChart.Plot.XLabel(xField); formsPlotChart.Plot.YLabel($"Середнє {yField}");
    }

    private void DrawBarChart()
    {
        var xField = comboBoxChartX.Text; 
        var yField = comboBoxChartY.Text;
        var groups = _displayRows.GroupBy(row => ReadText(row, xField)).OrderBy(group => group.Key).ToList();
        formsPlotChart.Plot.Add.Bars(groups.Select(group => (double)group.Average(row => ReadNumber(row, yField))).ToArray());
        formsPlotChart.Plot.Axes.Bottom.TickGenerator = new ScottPlot.TickGenerators.NumericManual(groups.Select((x, i) => new ScottPlot.Tick(i, x.Key)).ToArray());
        formsPlotChart.Plot.Axes.Bottom.MajorTickStyle.Length = 0; formsPlotChart.Plot.Axes.Margins(bottom: 0); formsPlotChart.Plot.HideGrid(); formsPlotChart.Plot.Title($"Середнє значення {yField} за {xField}"); formsPlotChart.Plot.YLabel($"Середнє {yField}");
    }

    private void DrawPieChart()
    {
        var xField = comboBoxChartX.Text;
        var groups = _displayRows.GroupBy(row => ReadText(row, xField)).OrderBy(group => group.Key).ToList();
        var pie = formsPlotChart.Plot.Add.Pie(groups.Select(x => (double)x.Count()).ToArray());
        for (var i = 0; i < pie.Slices.Count; i++) pie.Slices[i].Label = $"{groups[i].Key}: {pie.Slices[i].Value / _displayRows.Count:P0}";
        pie.ExplodeFraction = .05; pie.SliceLabelDistance = 1.25; formsPlotChart.Plot.Axes.Frameless(); formsPlotChart.Plot.HideGrid(); formsPlotChart.Plot.Title($"Розподіл записів за {xField}");
    }

    private static decimal ReadNumber(InsuranceRecord record, string field)
    {
        switch (field)
        {
            case "Age": 
                return record.Age;
            case "Bmi": 
                return record.Bmi;
            case "Children": 
                return record.Children;
            case "Charges": 
                return record.Charges;
            default: 
                return 0;
        }
    }

    private static string ReadText(InsuranceRecord record, string field)
    {
        switch (field)
        {
            case "Sex": 
                return record.Sex;
            case "Smoker": 
                return record.Smoker;
            case "Region": 
                return record.Region;
            default: 
                return "Не вказано";
        }
    }
}
