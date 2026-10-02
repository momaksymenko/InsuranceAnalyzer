namespace InsuranceAnalyzer.UI.Forms
{
partial class MainForm
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
            components.Dispose();
        base.Dispose(disposing);
    }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStripMain = new MenuStrip();
            menuFile = new ToolStripMenuItem();
            menuOpen = new ToolStripMenuItem();
            menuSave = new ToolStripMenuItem();
            menuSaveAs = new ToolStripMenuItem();
            menuRecentFiles = new ToolStripMenuItem();
            menuExit = new ToolStripMenuItem();
            menuReports = new ToolStripMenuItem();
            menuAnalysis = new ToolStripMenuItem();
            menuXlsxReport = new ToolStripMenuItem();
            menuDocxReport = new ToolStripMenuItem();
            tabControlMain = new TabControl();
            tabPageData = new TabPage();
            groupBoxRecords = new GroupBox();
            buttonAdd = new Button();
            buttonEdit = new Button();
            buttonDelete = new Button();
            labelTotalRecords = new Label();
            dataGridViewRecords = new DataGridView();
            buttonPreviousPage = new Button();
            labelPage = new Label();
            buttonNextPage = new Button();
            groupBoxFilter = new GroupBox();
            labelAgeRange = new Label();
            labelAgeFrom = new Label();
            labelAgeTo = new Label();
            numericAgeFrom = new NumericUpDown();
            numericAgeTo = new NumericUpDown();
            labelBmiRange = new Label();
            labelBmiFrom = new Label();
            labelBmiTo = new Label();
            numericBmiFrom = new NumericUpDown();
            numericBmiTo = new NumericUpDown();
            labelChildrenRange = new Label();
            labelChildrenFrom = new Label();
            labelChildrenTo = new Label();
            numericChildrenFrom = new NumericUpDown();
            numericChildrenTo = new NumericUpDown();
            labelChargesRange = new Label();
            labelChargesFrom = new Label();
            labelChargesTo = new Label();
            numericChargesFrom = new NumericUpDown();
            numericChargesTo = new NumericUpDown();
            labelSex = new Label();
            comboBoxSex = new ComboBox();
            labelSmoker = new Label();
            comboBoxSmoker = new ComboBox();
            labelRegion = new Label();
            comboBoxRegion = new ComboBox();
            buttonResetFilter = new Button();
            textBoxSearch = new TextBox();
            labelSearch = new Label();
            comboBoxSearchField = new ComboBox();
            groupBoxSorting = new GroupBox();
            labelSortField = new Label();
            comboBoxSortField = new ComboBox();
            labelSortOrder = new Label();
            comboBoxSortOrder = new ComboBox();
            buttonSort = new Button();
            tabPageCharts = new TabPage();
            formsPlotChart = new ScottPlot.WinForms.FormsPlot();
            groupBoxChartSettings = new GroupBox();
            comboBoxChartType = new ComboBox();
            labelChartType = new Label();
            labelChartX = new Label();
            comboBoxChartX = new ComboBox();
            labelChartY = new Label();
            comboBoxChartY = new ComboBox();
            buttonBuildChart = new Button();
            buttonExportChart = new Button();
            statusStripMain = new StatusStrip();
            toolStripStatusLabelPath = new ToolStripStatusLabel();
            toolStripStatusLabelCount = new ToolStripStatusLabel();
            toolStripStatusLabelTime = new ToolStripStatusLabel();
            openFileDialogData = new OpenFileDialog();
            saveFileDialogData = new SaveFileDialog();
            menuStripMain.SuspendLayout();
            tabControlMain.SuspendLayout();
            tabPageData.SuspendLayout();
            groupBoxRecords.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRecords).BeginInit();
            groupBoxFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericAgeFrom).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericAgeTo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericBmiFrom).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericBmiTo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericChildrenFrom).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericChildrenTo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericChargesFrom).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericChargesTo).BeginInit();
            groupBoxSorting.SuspendLayout();
            tabPageCharts.SuspendLayout();
            groupBoxChartSettings.SuspendLayout();
            statusStripMain.SuspendLayout();
            SuspendLayout();
            // 
            // menuStripMain
            // 
            menuStripMain.ImageScalingSize = new Size(20, 20);
            menuStripMain.Items.AddRange(new ToolStripItem[] { menuFile, menuReports });
            menuStripMain.Location = new Point(0, 0);
            menuStripMain.Name = "menuStripMain";
            menuStripMain.Size = new Size(1320, 28);
            menuStripMain.TabIndex = 0;
            // 
            // menuFile
            // 
            menuFile.DropDownItems.AddRange(new ToolStripItem[] { menuOpen, menuSave, menuSaveAs, menuRecentFiles, menuExit });
            menuFile.Name = "menuFile";
            menuFile.Size = new Size(59, 24);
            menuFile.Text = "Файл";
            // 
            // menuOpen
            // 
            menuOpen.Name = "menuOpen";
            menuOpen.Size = new Size(194, 26);
            menuOpen.Text = "Відкрити...";
            menuOpen.Click += menuOpen_Click;
            // 
            // menuSave
            // 
            menuSave.Name = "menuSave";
            menuSave.Size = new Size(194, 26);
            menuSave.Text = "Зберегти";
            menuSave.Click += menuSave_Click;
            // 
            // menuSaveAs
            // 
            menuSaveAs.Name = "menuSaveAs";
            menuSaveAs.Size = new Size(194, 26);
            menuSaveAs.Text = "Зберегти як...";
            menuSaveAs.Click += menuSaveAs_Click;
            // 
            // menuRecentFiles
            // 
            menuRecentFiles.Name = "menuRecentFiles";
            menuRecentFiles.Size = new Size(194, 26);
            menuRecentFiles.Text = "Останні файли";
            menuRecentFiles.DropDownOpening += menuRecentFiles_DropDownOpening;
            // 
            // menuExit
            // 
            menuExit.Name = "menuExit";
            menuExit.Size = new Size(194, 26);
            menuExit.Text = "Вихід";
            menuExit.Click += menuExit_Click;
            // 
            // menuReports
            // 
            menuReports.DropDownItems.AddRange(new ToolStripItem[] { menuAnalysis, menuXlsxReport, menuDocxReport });
            menuReports.Name = "menuReports";
            menuReports.Size = new Size(150, 24);
            menuReports.Text = "Аналіз та звітність";
            // 
            // menuAnalysis
            // 
            menuAnalysis.Name = "menuAnalysis";
            menuAnalysis.Size = new Size(253, 26);
            menuAnalysis.Text = "Аналіз даних";
            menuAnalysis.Click += menuAnalysis_Click;
            // 
            // menuXlsxReport
            // 
            menuXlsxReport.Name = "menuXlsxReport";
            menuXlsxReport.Size = new Size(253, 26);
            menuXlsxReport.Text = "Згенерувати XLSX-звіт";
            menuXlsxReport.Click += menuXlsxReport_Click;
            // 
            // menuDocxReport
            // 
            menuDocxReport.Name = "menuDocxReport";
            menuDocxReport.Size = new Size(253, 26);
            menuDocxReport.Text = "Згенерувати DOCX-звіт";
            menuDocxReport.Click += menuDocxReport_Click;
            // 
            // tabControlMain
            // 
            tabControlMain.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControlMain.Controls.Add(tabPageData);
            tabControlMain.Controls.Add(tabPageCharts);
            tabControlMain.Location = new Point(14, 40);
            tabControlMain.Name = "tabControlMain";
            tabControlMain.SelectedIndex = 0;
            tabControlMain.Size = new Size(1292, 802);
            tabControlMain.TabIndex = 1;
            // 
            // tabPageData
            // 
            tabPageData.Controls.Add(groupBoxRecords);
            tabPageData.Controls.Add(groupBoxFilter);
            tabPageData.Location = new Point(4, 29);
            tabPageData.Name = "tabPageData";
            tabPageData.Padding = new Padding(3);
            tabPageData.Size = new Size(1284, 769);
            tabPageData.TabIndex = 0;
            tabPageData.Text = "Дані";
            tabPageData.UseVisualStyleBackColor = true;
            // 
            // groupBoxRecords
            // 
            groupBoxRecords.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBoxRecords.Controls.Add(buttonAdd);
            groupBoxRecords.Controls.Add(buttonEdit);
            groupBoxRecords.Controls.Add(buttonDelete);
            groupBoxRecords.Controls.Add(labelTotalRecords);
            groupBoxRecords.Controls.Add(dataGridViewRecords);
            groupBoxRecords.Controls.Add(buttonPreviousPage);
            groupBoxRecords.Controls.Add(labelPage);
            groupBoxRecords.Controls.Add(buttonNextPage);
            groupBoxRecords.Font = new Font("Segoe UI", 9.5F);
            groupBoxRecords.Location = new Point(12, 330);
            groupBoxRecords.Name = "groupBoxRecords";
            groupBoxRecords.Size = new Size(1260, 433);
            groupBoxRecords.TabIndex = 0;
            groupBoxRecords.TabStop = false;
            groupBoxRecords.Text = "Записи";
            groupBoxRecords.Resize += groupBoxRecords_Resize;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(14, 30);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(125, 32);
            buttonAdd.TabIndex = 1;
            buttonAdd.Text = "Додати";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonEdit
            // 
            buttonEdit.Location = new Point(149, 30);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(125, 32);
            buttonEdit.TabIndex = 2;
            buttonEdit.Text = "Редагувати";
            buttonEdit.UseVisualStyleBackColor = true;
            buttonEdit.Click += buttonEdit_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(284, 30);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(185, 32);
            buttonDelete.TabIndex = 1;
            buttonDelete.Text = "Видалити вибраний";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // labelTotalRecords
            // 
            labelTotalRecords.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelTotalRecords.Location = new Point(1010, 36);
            labelTotalRecords.Name = "labelTotalRecords";
            labelTotalRecords.Size = new Size(220, 23);
            labelTotalRecords.TabIndex = 3;
            labelTotalRecords.Text = "Всього записів: 0";
            labelTotalRecords.TextAlign = ContentAlignment.MiddleRight;
            // 
            // dataGridViewRecords
            // 
            dataGridViewRecords.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewRecords.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewRecords.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewRecords.Location = new Point(14, 73);
            dataGridViewRecords.Name = "dataGridViewRecords";
            dataGridViewRecords.RowHeadersWidth = 51;
            dataGridViewRecords.Size = new Size(1230, 305);
            dataGridViewRecords.TabIndex = 0;
            // 
            // buttonPreviousPage
            // 
            buttonPreviousPage.Anchor = AnchorStyles.Bottom;
            buttonPreviousPage.Location = new Point(462, 384);
            buttonPreviousPage.Name = "buttonPreviousPage";
            buttonPreviousPage.Size = new Size(120, 32);
            buttonPreviousPage.TabIndex = 3;
            buttonPreviousPage.Text = "Попередня";
            buttonPreviousPage.UseVisualStyleBackColor = true;
            buttonPreviousPage.Click += buttonPreviousPage_Click;
            // 
            // labelPage
            // 
            labelPage.Anchor = AnchorStyles.Bottom;
            labelPage.Location = new Point(588, 389);
            labelPage.Name = "labelPage";
            labelPage.Size = new Size(150, 23);
            labelPage.TabIndex = 4;
            labelPage.Text = "Сторінка 1 з 1";
            labelPage.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // buttonNextPage
            // 
            buttonNextPage.Anchor = AnchorStyles.Bottom;
            buttonNextPage.Location = new Point(744, 384);
            buttonNextPage.Name = "buttonNextPage";
            buttonNextPage.Size = new Size(90, 32);
            buttonNextPage.TabIndex = 5;
            buttonNextPage.Text = "Далі";
            buttonNextPage.UseVisualStyleBackColor = true;
            buttonNextPage.Click += buttonNextPage_Click;
            // 
            // groupBoxFilter
            // 
            groupBoxFilter.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBoxFilter.Controls.Add(labelAgeRange);
            groupBoxFilter.Controls.Add(labelAgeFrom);
            groupBoxFilter.Controls.Add(labelAgeTo);
            groupBoxFilter.Controls.Add(numericAgeFrom);
            groupBoxFilter.Controls.Add(numericAgeTo);
            groupBoxFilter.Controls.Add(labelBmiRange);
            groupBoxFilter.Controls.Add(labelBmiFrom);
            groupBoxFilter.Controls.Add(labelBmiTo);
            groupBoxFilter.Controls.Add(numericBmiFrom);
            groupBoxFilter.Controls.Add(numericBmiTo);
            groupBoxFilter.Controls.Add(labelChildrenRange);
            groupBoxFilter.Controls.Add(labelChildrenFrom);
            groupBoxFilter.Controls.Add(labelChildrenTo);
            groupBoxFilter.Controls.Add(numericChildrenFrom);
            groupBoxFilter.Controls.Add(numericChildrenTo);
            groupBoxFilter.Controls.Add(labelChargesRange);
            groupBoxFilter.Controls.Add(labelChargesFrom);
            groupBoxFilter.Controls.Add(labelChargesTo);
            groupBoxFilter.Controls.Add(numericChargesFrom);
            groupBoxFilter.Controls.Add(numericChargesTo);
            groupBoxFilter.Controls.Add(labelSex);
            groupBoxFilter.Controls.Add(comboBoxSex);
            groupBoxFilter.Controls.Add(labelSmoker);
            groupBoxFilter.Controls.Add(comboBoxSmoker);
            groupBoxFilter.Controls.Add(labelRegion);
            groupBoxFilter.Controls.Add(comboBoxRegion);
            groupBoxFilter.Controls.Add(buttonResetFilter);
            groupBoxFilter.Controls.Add(textBoxSearch);
            groupBoxFilter.Controls.Add(labelSearch);
            groupBoxFilter.Controls.Add(comboBoxSearchField);
            groupBoxFilter.Controls.Add(groupBoxSorting);
            groupBoxFilter.Font = new Font("Segoe UI", 9.5F);
            groupBoxFilter.Location = new Point(12, 10);
            groupBoxFilter.Name = "groupBoxFilter";
            groupBoxFilter.Size = new Size(1260, 310);
            groupBoxFilter.TabIndex = 1;
            groupBoxFilter.TabStop = false;
            groupBoxFilter.Text = "Пошук, фільтрація та сортування";
            // 
            // labelAgeRange
            // 
            labelAgeRange.AutoSize = true;
            labelAgeRange.Font = new Font("Segoe UI", 10F);
            labelAgeRange.Location = new Point(22, 75);
            labelAgeRange.Name = "labelAgeRange";
            labelAgeRange.Size = new Size(36, 23);
            labelAgeRange.TabIndex = 1;
            labelAgeRange.Text = "Вік:";
            // 
            // labelAgeFrom
            // 
            labelAgeFrom.AutoSize = true;
            labelAgeFrom.Location = new Point(22, 104);
            labelAgeFrom.Name = "labelAgeFrom";
            labelAgeFrom.Size = new Size(32, 21);
            labelAgeFrom.TabIndex = 2;
            labelAgeFrom.Text = "Від";
            // 
            // labelAgeTo
            // 
            labelAgeTo.AutoSize = true;
            labelAgeTo.Location = new Point(131, 104);
            labelAgeTo.Name = "labelAgeTo";
            labelAgeTo.Size = new Size(28, 21);
            labelAgeTo.TabIndex = 3;
            labelAgeTo.Text = "до";
            // 
            // numericAgeFrom
            // 
            numericAgeFrom.Location = new Point(55, 100);
            numericAgeFrom.Maximum = new decimal(new int[] { 120, 0, 0, 0 });
            numericAgeFrom.Name = "numericAgeFrom";
            numericAgeFrom.Size = new Size(70, 29);
            numericAgeFrom.TabIndex = 2;
            numericAgeFrom.ValueChanged += filterControl_ValueChanged;
            // 
            // numericAgeTo
            // 
            numericAgeTo.Location = new Point(163, 100);
            numericAgeTo.Maximum = new decimal(new int[] { 120, 0, 0, 0 });
            numericAgeTo.Name = "numericAgeTo";
            numericAgeTo.Size = new Size(70, 29);
            numericAgeTo.TabIndex = 3;
            numericAgeTo.Value = new decimal(new int[] { 120, 0, 0, 0 });
            numericAgeTo.ValueChanged += filterControl_ValueChanged;
            // 
            // labelBmiRange
            // 
            labelBmiRange.AutoSize = true;
            labelBmiRange.Font = new Font("Segoe UI", 10F);
            labelBmiRange.Location = new Point(19, 151);
            labelBmiRange.Name = "labelBmiRange";
            labelBmiRange.Size = new Size(44, 23);
            labelBmiRange.TabIndex = 4;
            labelBmiRange.Text = "BMI:";
            // 
            // labelBmiFrom
            // 
            labelBmiFrom.AutoSize = true;
            labelBmiFrom.Location = new Point(19, 181);
            labelBmiFrom.Name = "labelBmiFrom";
            labelBmiFrom.Size = new Size(32, 21);
            labelBmiFrom.TabIndex = 5;
            labelBmiFrom.Text = "Від";
            // 
            // labelBmiTo
            // 
            labelBmiTo.AutoSize = true;
            labelBmiTo.Location = new Point(136, 181);
            labelBmiTo.Name = "labelBmiTo";
            labelBmiTo.Size = new Size(28, 21);
            labelBmiTo.TabIndex = 6;
            labelBmiTo.Text = "до";
            // 
            // numericBmiFrom
            // 
            numericBmiFrom.DecimalPlaces = 2;
            numericBmiFrom.Location = new Point(55, 177);
            numericBmiFrom.Name = "numericBmiFrom";
            numericBmiFrom.Size = new Size(75, 29);
            numericBmiFrom.TabIndex = 5;
            numericBmiFrom.ValueChanged += filterControl_ValueChanged;
            // 
            // numericBmiTo
            // 
            numericBmiTo.DecimalPlaces = 2;
            numericBmiTo.Location = new Point(168, 177);
            numericBmiTo.Name = "numericBmiTo";
            numericBmiTo.Size = new Size(75, 29);
            numericBmiTo.TabIndex = 6;
            numericBmiTo.Value = new decimal(new int[] { 100, 0, 0, 0 });
            numericBmiTo.ValueChanged += filterControl_ValueChanged;
            // 
            // labelChildrenRange
            // 
            labelChildrenRange.AutoSize = true;
            labelChildrenRange.Font = new Font("Segoe UI", 10F);
            labelChildrenRange.Location = new Point(336, 77);
            labelChildrenRange.Name = "labelChildrenRange";
            labelChildrenRange.Size = new Size(47, 23);
            labelChildrenRange.TabIndex = 7;
            labelChildrenRange.Text = "Діти:";
            // 
            // labelChildrenFrom
            // 
            labelChildrenFrom.AutoSize = true;
            labelChildrenFrom.Location = new Point(336, 106);
            labelChildrenFrom.Name = "labelChildrenFrom";
            labelChildrenFrom.Size = new Size(32, 21);
            labelChildrenFrom.TabIndex = 8;
            labelChildrenFrom.Text = "Від";
            // 
            // labelChildrenTo
            // 
            labelChildrenTo.AutoSize = true;
            labelChildrenTo.Location = new Point(448, 106);
            labelChildrenTo.Name = "labelChildrenTo";
            labelChildrenTo.Size = new Size(28, 21);
            labelChildrenTo.TabIndex = 9;
            labelChildrenTo.Text = "до";
            // 
            // numericChildrenFrom
            // 
            numericChildrenFrom.Location = new Point(372, 102);
            numericChildrenFrom.Maximum = new decimal(new int[] { 50, 0, 0, 0 });
            numericChildrenFrom.Name = "numericChildrenFrom";
            numericChildrenFrom.Size = new Size(70, 29);
            numericChildrenFrom.TabIndex = 8;
            numericChildrenFrom.ValueChanged += filterControl_ValueChanged;
            // 
            // numericChildrenTo
            // 
            numericChildrenTo.Location = new Point(482, 102);
            numericChildrenTo.Maximum = new decimal(new int[] { 50, 0, 0, 0 });
            numericChildrenTo.Name = "numericChildrenTo";
            numericChildrenTo.Size = new Size(70, 29);
            numericChildrenTo.TabIndex = 9;
            numericChildrenTo.Value = new decimal(new int[] { 50, 0, 0, 0 });
            numericChildrenTo.ValueChanged += filterControl_ValueChanged;
            // 
            // labelChargesRange
            // 
            labelChargesRange.AutoSize = true;
            labelChargesRange.Font = new Font("Segoe UI", 10F);
            labelChargesRange.Location = new Point(334, 154);
            labelChargesRange.Name = "labelChargesRange";
            labelChargesRange.Size = new Size(78, 23);
            labelChargesRange.TabIndex = 10;
            labelChargesRange.Text = "Вартість:";
            // 
            // labelChargesFrom
            // 
            labelChargesFrom.AutoSize = true;
            labelChargesFrom.Location = new Point(334, 183);
            labelChargesFrom.Name = "labelChargesFrom";
            labelChargesFrom.Size = new Size(32, 21);
            labelChargesFrom.TabIndex = 11;
            labelChargesFrom.Text = "Від";
            // 
            // labelChargesTo
            // 
            labelChargesTo.AutoSize = true;
            labelChargesTo.Location = new Point(481, 183);
            labelChargesTo.Name = "labelChargesTo";
            labelChargesTo.Size = new Size(28, 21);
            labelChargesTo.TabIndex = 12;
            labelChargesTo.Text = "до";
            // 
            // numericChargesFrom
            // 
            numericChargesFrom.DecimalPlaces = 2;
            numericChargesFrom.Location = new Point(370, 179);
            numericChargesFrom.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numericChargesFrom.Name = "numericChargesFrom";
            numericChargesFrom.Size = new Size(105, 29);
            numericChargesFrom.TabIndex = 11;
            numericChargesFrom.ValueChanged += filterControl_ValueChanged;
            // 
            // numericChargesTo
            // 
            numericChargesTo.DecimalPlaces = 2;
            numericChargesTo.Location = new Point(515, 179);
            numericChargesTo.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numericChargesTo.Name = "numericChargesTo";
            numericChargesTo.Size = new Size(111, 29);
            numericChargesTo.TabIndex = 12;
            numericChargesTo.Value = new decimal(new int[] { 1000000, 0, 0, 0 });
            numericChargesTo.ValueChanged += filterControl_ValueChanged;
            // 
            // labelSex
            // 
            labelSex.AutoSize = true;
            labelSex.Font = new Font("Segoe UI", 10F);
            labelSex.Location = new Point(874, 77);
            labelSex.Name = "labelSex";
            labelSex.Size = new Size(57, 23);
            labelSex.TabIndex = 13;
            labelSex.Text = "Стать:";
            // 
            // comboBoxSex
            // 
            comboBoxSex.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxSex.Location = new Point(874, 102);
            comboBoxSex.Name = "comboBoxSex";
            comboBoxSex.Size = new Size(125, 29);
            comboBoxSex.TabIndex = 14;
            comboBoxSex.SelectedIndexChanged += filterControl_ValueChanged;
            // 
            // labelSmoker
            // 
            labelSmoker.AutoSize = true;
            labelSmoker.Font = new Font("Segoe UI", 10F);
            labelSmoker.Location = new Point(697, 76);
            labelSmoker.Name = "labelSmoker";
            labelSmoker.Size = new Size(75, 23);
            labelSmoker.TabIndex = 15;
            labelSmoker.Text = "Куріння:";
            // 
            // comboBoxSmoker
            // 
            comboBoxSmoker.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxSmoker.Location = new Point(697, 101);
            comboBoxSmoker.Name = "comboBoxSmoker";
            comboBoxSmoker.Size = new Size(125, 29);
            comboBoxSmoker.TabIndex = 16;
            comboBoxSmoker.SelectedIndexChanged += filterControl_ValueChanged;
            // 
            // labelRegion
            // 
            labelRegion.AutoSize = true;
            labelRegion.Font = new Font("Segoe UI", 10F);
            labelRegion.Location = new Point(697, 152);
            labelRegion.Name = "labelRegion";
            labelRegion.Size = new Size(64, 23);
            labelRegion.TabIndex = 17;
            labelRegion.Text = "Регіон:";
            // 
            // comboBoxRegion
            // 
            comboBoxRegion.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxRegion.Location = new Point(697, 177);
            comboBoxRegion.Name = "comboBoxRegion";
            comboBoxRegion.Size = new Size(160, 29);
            comboBoxRegion.TabIndex = 18;
            comboBoxRegion.SelectedIndexChanged += filterControl_ValueChanged;
            // 
            // buttonResetFilter
            // 
            buttonResetFilter.Location = new Point(1074, 32);
            buttonResetFilter.Name = "buttonResetFilter";
            buttonResetFilter.Size = new Size(170, 34);
            buttonResetFilter.TabIndex = 7;
            buttonResetFilter.Text = "Скинути фільтри";
            buttonResetFilter.UseVisualStyleBackColor = true;
            buttonResetFilter.Click += buttonResetFilter_Click;
            // 
            // textBoxSearch
            // 
            textBoxSearch.Location = new Point(333, 36);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(285, 29);
            textBoxSearch.TabIndex = 0;
            textBoxSearch.TextChanged += textBoxSearch_TextChanged;
            // 
            // labelSearch
            // 
            labelSearch.AutoSize = true;
            labelSearch.Font = new Font("Segoe UI", 10F);
            labelSearch.Location = new Point(21, 39);
            labelSearch.Name = "labelSearch";
            labelSearch.Size = new Size(143, 23);
            labelSearch.TabIndex = 8;
            labelSearch.Text = "Пошук у таблиці:";
            // 
            // comboBoxSearchField
            // 
            comboBoxSearchField.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxSearchField.Location = new Point(168, 38);
            comboBoxSearchField.Name = "comboBoxSearchField";
            comboBoxSearchField.Size = new Size(155, 29);
            comboBoxSearchField.TabIndex = 1;
            comboBoxSearchField.SelectedIndexChanged += textBoxSearch_TextChanged;
            // 
            // groupBoxSorting
            // 
            groupBoxSorting.Controls.Add(labelSortField);
            groupBoxSorting.Controls.Add(comboBoxSortField);
            groupBoxSorting.Controls.Add(labelSortOrder);
            groupBoxSorting.Controls.Add(comboBoxSortOrder);
            groupBoxSorting.Controls.Add(buttonSort);
            groupBoxSorting.Location = new Point(12, 230);
            groupBoxSorting.Name = "groupBoxSorting";
            groupBoxSorting.Size = new Size(648, 74);
            groupBoxSorting.TabIndex = 0;
            groupBoxSorting.TabStop = false;
            groupBoxSorting.Text = "Сортування результату";
            // 
            // labelSortField
            // 
            labelSortField.AutoSize = true;
            labelSortField.Location = new Point(16, 33);
            labelSortField.Name = "labelSortField";
            labelSortField.Size = new Size(107, 21);
            labelSortField.TabIndex = 0;
            labelSortField.Text = "Сортувати за:";
            // 
            // comboBoxSortField
            // 
            comboBoxSortField.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxSortField.Items.AddRange(new object[] { "Age", "Bmi", "Children", "Charges", "Region" });
            comboBoxSortField.Location = new Point(124, 30);
            comboBoxSortField.Name = "comboBoxSortField";
            comboBoxSortField.Size = new Size(125, 29);
            comboBoxSortField.TabIndex = 1;
            // 
            // labelSortOrder
            // 
            labelSortOrder.AutoSize = true;
            labelSortOrder.Location = new Point(268, 33);
            labelSortOrder.Name = "labelSortOrder";
            labelSortOrder.Size = new Size(86, 21);
            labelSortOrder.TabIndex = 2;
            labelSortOrder.Text = "Напрямок:";
            // 
            // comboBoxSortOrder
            // 
            comboBoxSortOrder.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxSortOrder.Items.AddRange(new object[] { "За зростанням", "За спаданням" });
            comboBoxSortOrder.Location = new Point(358, 30);
            comboBoxSortOrder.Name = "comboBoxSortOrder";
            comboBoxSortOrder.Size = new Size(145, 29);
            comboBoxSortOrder.TabIndex = 3;
            // 
            // buttonSort
            // 
            buttonSort.Location = new Point(523, 28);
            buttonSort.Name = "buttonSort";
            buttonSort.Size = new Size(110, 31);
            buttonSort.TabIndex = 4;
            buttonSort.Text = "Сортувати";
            buttonSort.UseVisualStyleBackColor = true;
            buttonSort.Click += buttonSort_Click;
            // 
            // tabPageCharts
            // 
            tabPageCharts.Controls.Add(formsPlotChart);
            tabPageCharts.Controls.Add(groupBoxChartSettings);
            tabPageCharts.Location = new Point(4, 29);
            tabPageCharts.Name = "tabPageCharts";
            tabPageCharts.Size = new Size(1284, 769);
            tabPageCharts.TabIndex = 1;
            tabPageCharts.Text = "Графіки";
            tabPageCharts.UseVisualStyleBackColor = true;
            // 
            // formsPlotChart
            // 
            formsPlotChart.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            formsPlotChart.Location = new Point(12, 117);
            formsPlotChart.Name = "formsPlotChart";
            formsPlotChart.Size = new Size(1251, 580);
            formsPlotChart.TabIndex = 1;
            // 
            // groupBoxChartSettings
            // 
            groupBoxChartSettings.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBoxChartSettings.Controls.Add(comboBoxChartType);
            groupBoxChartSettings.Controls.Add(labelChartType);
            groupBoxChartSettings.Controls.Add(labelChartX);
            groupBoxChartSettings.Controls.Add(comboBoxChartX);
            groupBoxChartSettings.Controls.Add(labelChartY);
            groupBoxChartSettings.Controls.Add(comboBoxChartY);
            groupBoxChartSettings.Controls.Add(buttonBuildChart);
            groupBoxChartSettings.Controls.Add(buttonExportChart);
            groupBoxChartSettings.Font = new Font("Segoe UI", 10F);
            groupBoxChartSettings.Location = new Point(12, 10);
            groupBoxChartSettings.Name = "groupBoxChartSettings";
            groupBoxChartSettings.Size = new Size(1119, 106);
            groupBoxChartSettings.TabIndex = 2;
            groupBoxChartSettings.TabStop = false;
            groupBoxChartSettings.Text = "Налаштування графіка";
            // 
            // comboBoxChartType
            // 
            comboBoxChartType.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxChartType.Items.AddRange(new object[] { "Лінійний", "Стовпчиковий", "Круговий" });
            comboBoxChartType.Location = new Point(120, 38);
            comboBoxChartType.Name = "comboBoxChartType";
            comboBoxChartType.Size = new Size(160, 31);
            comboBoxChartType.TabIndex = 1;
            comboBoxChartType.SelectedIndexChanged += comboBoxChartType_SelectedIndexChanged;
            // 
            // labelChartType
            // 
            labelChartType.AutoSize = true;
            labelChartType.Location = new Point(14, 42);
            labelChartType.Name = "labelChartType";
            labelChartType.Size = new Size(107, 23);
            labelChartType.TabIndex = 0;
            labelChartType.Text = "Тип графіка:";
            // 
            // labelChartX
            // 
            labelChartX.AutoSize = true;
            labelChartX.Location = new Point(300, 42);
            labelChartX.Name = "labelChartX";
            labelChartX.Size = new Size(69, 23);
            labelChartX.TabIndex = 2;
            labelChartX.Text = "Поле X:";
            // 
            // comboBoxChartX
            // 
            comboBoxChartX.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxChartX.Items.AddRange(new object[] { "Age", "Bmi", "Children", "Region", "Sex", "Smoker" });
            comboBoxChartX.Location = new Point(370, 38);
            comboBoxChartX.Name = "comboBoxChartX";
            comboBoxChartX.Size = new Size(135, 31);
            comboBoxChartX.TabIndex = 3;
            comboBoxChartX.SelectedIndexChanged += comboBoxChartX_SelectedIndexChanged;
            // 
            // labelChartY
            // 
            labelChartY.AutoSize = true;
            labelChartY.Location = new Point(530, 42);
            labelChartY.Name = "labelChartY";
            labelChartY.Size = new Size(68, 23);
            labelChartY.TabIndex = 4;
            labelChartY.Text = "Поле Y:";
            // 
            // comboBoxChartY
            // 
            comboBoxChartY.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxChartY.Items.AddRange(new object[] { "Charges", "Bmi", "Children", "Age" });
            comboBoxChartY.Location = new Point(600, 38);
            comboBoxChartY.Name = "comboBoxChartY";
            comboBoxChartY.Size = new Size(135, 31);
            comboBoxChartY.TabIndex = 5;
            // 
            // buttonBuildChart
            // 
            buttonBuildChart.Location = new Point(760, 36);
            buttonBuildChart.Name = "buttonBuildChart";
            buttonBuildChart.Size = new Size(135, 35);
            buttonBuildChart.TabIndex = 2;
            buttonBuildChart.Text = "Побудувати";
            buttonBuildChart.UseVisualStyleBackColor = true;
            buttonBuildChart.Click += buttonBuildChart_Click;
            // 
            // buttonExportChart
            // 
            buttonExportChart.Location = new Point(910, 36);
            buttonExportChart.Name = "buttonExportChart";
            buttonExportChart.Size = new Size(150, 35);
            buttonExportChart.TabIndex = 3;
            buttonExportChart.Text = "Експорт PNG";
            buttonExportChart.UseVisualStyleBackColor = true;
            buttonExportChart.Click += buttonExportChart_Click;
            // 
            // statusStripMain
            // 
            statusStripMain.ImageScalingSize = new Size(20, 20);
            statusStripMain.Items.AddRange(new ToolStripItem[] { toolStripStatusLabelPath, toolStripStatusLabelCount, toolStripStatusLabelTime });
            statusStripMain.Location = new Point(0, 856);
            statusStripMain.Name = "statusStripMain";
            statusStripMain.Size = new Size(1320, 26);
            statusStripMain.TabIndex = 0;
            // 
            // toolStripStatusLabelPath
            // 
            toolStripStatusLabelPath.Name = "toolStripStatusLabelPath";
            toolStripStatusLabelPath.Size = new Size(1150, 20);
            toolStripStatusLabelPath.Spring = true;
            toolStripStatusLabelPath.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // toolStripStatusLabelCount
            // 
            toolStripStatusLabelCount.Name = "toolStripStatusLabelCount";
            toolStripStatusLabelCount.Size = new Size(77, 20);
            toolStripStatusLabelCount.Text = "Записів: 0";
            // 
            // toolStripStatusLabelTime
            // 
            toolStripStatusLabelTime.Name = "toolStripStatusLabelTime";
            toolStripStatusLabelTime.Size = new Size(78, 20);
            toolStripStatusLabelTime.Text = "Операція:";
            // 
            // openFileDialogData
            // 
            openFileDialogData.Filter = "Файли даних|*.csv;*.json;*.xml;*.xlsx";
            // 
            // saveFileDialogData
            // 
            saveFileDialogData.Filter = "CSV|*.csv|JSON|*.json|XML|*.xml|XLSX|*.xlsx";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1320, 882);
            Controls.Add(statusStripMain);
            Controls.Add(tabControlMain);
            Controls.Add(menuStripMain);
            MainMenuStrip = menuStripMain;
            MinimumSize = new Size(1180, 752);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Аналіз медичного страхування";
            menuStripMain.ResumeLayout(false);
            menuStripMain.PerformLayout();
            tabControlMain.ResumeLayout(false);
            tabPageData.ResumeLayout(false);
            groupBoxRecords.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewRecords).EndInit();
            groupBoxFilter.ResumeLayout(false);
            groupBoxFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericAgeFrom).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericAgeTo).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericBmiFrom).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericBmiTo).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericChildrenFrom).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericChildrenTo).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericChargesFrom).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericChargesTo).EndInit();
            groupBoxSorting.ResumeLayout(false);
            groupBoxSorting.PerformLayout();
            tabPageCharts.ResumeLayout(false);
            groupBoxChartSettings.ResumeLayout(false);
            groupBoxChartSettings.PerformLayout();
            statusStripMain.ResumeLayout(false);
            statusStripMain.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripMain;
    private System.Windows.Forms.ToolStripMenuItem menuFile;
    private System.Windows.Forms.ToolStripMenuItem menuOpen;
    private System.Windows.Forms.ToolStripMenuItem menuSave;
    private System.Windows.Forms.ToolStripMenuItem menuSaveAs;
    private System.Windows.Forms.ToolStripMenuItem menuRecentFiles;
    private System.Windows.Forms.ToolStripMenuItem menuExit;
    private System.Windows.Forms.ToolStripMenuItem menuReports;
    private System.Windows.Forms.ToolStripMenuItem menuAnalysis;
    private System.Windows.Forms.ToolStripMenuItem menuXlsxReport;
    private System.Windows.Forms.ToolStripMenuItem menuDocxReport;
    private System.Windows.Forms.TabControl tabControlMain;
    private System.Windows.Forms.TabPage tabPageData;
    private System.Windows.Forms.TabPage tabPageCharts;
    private System.Windows.Forms.GroupBox groupBoxFilter;
    private System.Windows.Forms.Button buttonResetFilter;
    private System.Windows.Forms.Label labelSearch;
    private System.Windows.Forms.TextBox textBoxSearch;
    private System.Windows.Forms.ComboBox comboBoxSearchField;
    private System.Windows.Forms.Label labelAgeRange;
    private System.Windows.Forms.Label labelAgeFrom;
    private System.Windows.Forms.Label labelAgeTo;
    private System.Windows.Forms.NumericUpDown numericAgeFrom;
    private System.Windows.Forms.NumericUpDown numericAgeTo;
    private System.Windows.Forms.Label labelBmiRange;
    private System.Windows.Forms.Label labelBmiFrom;
    private System.Windows.Forms.Label labelBmiTo;
    private System.Windows.Forms.NumericUpDown numericBmiFrom;
    private System.Windows.Forms.NumericUpDown numericBmiTo;
    private System.Windows.Forms.Label labelChildrenRange;
    private System.Windows.Forms.Label labelChildrenFrom;
    private System.Windows.Forms.Label labelChildrenTo;
    private System.Windows.Forms.NumericUpDown numericChildrenFrom;
    private System.Windows.Forms.NumericUpDown numericChildrenTo;
    private System.Windows.Forms.Label labelChargesRange;
    private System.Windows.Forms.Label labelChargesFrom;
    private System.Windows.Forms.Label labelChargesTo;
    private System.Windows.Forms.NumericUpDown numericChargesFrom;
    private System.Windows.Forms.NumericUpDown numericChargesTo;
    private System.Windows.Forms.Label labelSex;
    private System.Windows.Forms.ComboBox comboBoxSex;
    private System.Windows.Forms.Label labelSmoker;
    private System.Windows.Forms.ComboBox comboBoxSmoker;
    private System.Windows.Forms.Label labelRegion;
    private System.Windows.Forms.ComboBox comboBoxRegion;
    private System.Windows.Forms.Label labelTotalRecords;
    private System.Windows.Forms.GroupBox groupBoxRecords;
    private System.Windows.Forms.DataGridView dataGridViewRecords;
    private System.Windows.Forms.Button buttonDelete;
    private System.Windows.Forms.Button buttonAdd;
    private System.Windows.Forms.Button buttonEdit;
    private System.Windows.Forms.Button buttonPreviousPage;
    private System.Windows.Forms.Label labelPage;
    private System.Windows.Forms.Button buttonNextPage;
    private System.Windows.Forms.GroupBox groupBoxSorting;
    private System.Windows.Forms.Label labelSortField;
    private System.Windows.Forms.ComboBox comboBoxSortField;
    private System.Windows.Forms.Label labelSortOrder;
    private System.Windows.Forms.ComboBox comboBoxSortOrder;
    private System.Windows.Forms.Button buttonSort;
    private System.Windows.Forms.GroupBox groupBoxChartSettings;
    private System.Windows.Forms.ComboBox comboBoxChartType;
    private System.Windows.Forms.Label labelChartType;
    private System.Windows.Forms.Label labelChartX;
    private System.Windows.Forms.ComboBox comboBoxChartX;
    private System.Windows.Forms.Label labelChartY;
    private System.Windows.Forms.ComboBox comboBoxChartY;
    private System.Windows.Forms.Button buttonBuildChart;
    private System.Windows.Forms.Button buttonExportChart;
    private ScottPlot.WinForms.FormsPlot formsPlotChart;
    private System.Windows.Forms.StatusStrip statusStripMain;
    private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelPath;
    private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelCount;
    private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelTime;
    private System.Windows.Forms.OpenFileDialog openFileDialogData;
    private System.Windows.Forms.SaveFileDialog saveFileDialogData;
}
}
