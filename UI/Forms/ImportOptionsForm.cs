using InsuranceAnalyzer.Data;
using InsuranceAnalyzer.Domain.Entities;
using InsuranceAnalyzer.Domain.Interfaces;

namespace InsuranceAnalyzer.UI.Forms;

public partial class ImportOptionsForm : Form
{
    private readonly string _path;
    private readonly DataFilePreviewService _previewService = new();
    private bool _optionsReady;

    public ImportOptions Options { get; } = new();

    public ImportOptionsForm(string path)
    {
        _path = path;
        InitializeComponent();
        labelFileName.Text = Path.GetFileName(path);
        comboBoxEncoding.SelectedIndex = 0;
        comboBoxDelimiter.SelectedIndex = 0;
        comboBoxDecimalSeparator.SelectedIndex = 0;
        _optionsReady = true;
        ShowPreview();
    }

    private void importOption_Changed(object? sender, EventArgs e)
    {
        if (_optionsReady) ShowPreview();
    }

    private void buttonImport_Click(object? sender, EventArgs e)
    {
        ReadOptions();
        DialogResult = DialogResult.OK;
    }

    private void ShowPreview()
    {
        try
        {
            ReadOptions();
            ShowPreview(_previewService.Create(_path, Options), false);
        }
        catch (Exception exception)
        {
            if (!TryDetectOptions(out var preview))
            {
                labelSummary.ForeColor = Color.Firebrick;
                labelSummary.Text = $"Не вдалося прочитати файл: {exception.Message}";
                labelTypes.Text = string.Empty;
                dataGridViewPreview.DataSource = null;
                return;
            }

            ShowPreview(preview, true);
        }
    }

    private void ShowPreview(DataPreviewResult preview, bool wasDetected)
    {
        dataGridViewPreview.DataSource = preview.Rows;
        labelSummary.ForeColor = SystemColors.ControlText;
        var detected = string.Empty;
        if (wasDetected)
            detected = " Параметри визначено автоматично.";
        labelSummary.Text = $"Рядків: {preview.RowCount}; стовпців: {preview.ColumnCount}; пропусків: {preview.MissingValues}.{detected}";
        labelTypes.Text = preview.FieldTypes;
    }

    private bool TryDetectOptions(out DataPreviewResult preview)
    {
        foreach (var encoding in new[] { "utf-8", "windows-1251" })
        {
            foreach (var delimiter in new[] { ',', ';' })
            {
                foreach (var decimalSeparator in new[] { '.', ',' })
                {
                    foreach (var hasHeader in new[] { true, false })
                    {
                        if (TryCreatePreview(encoding, delimiter, decimalSeparator, hasHeader, out preview))
                            return true;
                    }
                }
            }
        }

        preview = new DataPreviewResult();
        return false;
    }

    private bool TryCreatePreview(string encoding, char delimiter, char decimalSeparator, bool hasHeader, out DataPreviewResult preview)
    {
        var detected = new ImportOptions
        {
            EncodingName = encoding,
            Delimiter = delimiter,
            DecimalSeparator = decimalSeparator,
            HasHeader = hasHeader
        };

        try
        {
            preview = _previewService.Create(_path, detected);
            SetDetectedOptions(detected);
            return true;
        }
        catch (Exception)
        {
            preview = new DataPreviewResult();
            return false;
        }
    }

    private void SetDetectedOptions(ImportOptions options)
    {
        _optionsReady = false;
        comboBoxEncoding.SelectedItem = options.EncodingName;
        comboBoxDelimiter.SelectedItem = "Кома (,)";
        if (options.Delimiter == ';')
            comboBoxDelimiter.SelectedItem = "Крапка з комою (;)";

        comboBoxDecimalSeparator.SelectedItem = "Крапка (.)";
        if (options.DecimalSeparator == ',')
            comboBoxDecimalSeparator.SelectedItem = "Кома (,)";
        checkBoxHeader.Checked = options.HasHeader;
        _optionsReady = true;
        ReadOptions();
    }

    private void ReadOptions()
    {
        Options.EncodingName = comboBoxEncoding.Text;
        Options.Delimiter = ',';
        if (comboBoxDelimiter.Text == "Крапка з комою (;)")
            Options.Delimiter = ';';

        Options.DecimalSeparator = '.';
        if (comboBoxDecimalSeparator.Text == "Кома (,)")
            Options.DecimalSeparator = ',';
        Options.HasHeader = checkBoxHeader.Checked;
    }
}
