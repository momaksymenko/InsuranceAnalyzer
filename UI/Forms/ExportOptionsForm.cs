using InsuranceAnalyzer.Domain.Interfaces;

namespace InsuranceAnalyzer.UI.Forms;

public partial class ExportOptionsForm : Form
{
    public ExportOptions Options { get; } = new();

    public ExportOptionsForm(string extension)
    {
        InitializeComponent();
        var isCsv = extension.Equals(".csv", StringComparison.OrdinalIgnoreCase);
        comboBoxEncoding.Enabled = isCsv;
        comboBoxDelimiter.Enabled = isCsv;
        textBoxSheetName.Enabled = extension.Equals(".xlsx", StringComparison.OrdinalIgnoreCase);
        comboBoxEncoding.SelectedIndex = 0;
        comboBoxDelimiter.SelectedIndex = 0;
    }

    private void buttonSave_Click(object? sender, EventArgs e)
    {
        Options.EncodingName = comboBoxEncoding.Text;
        Options.Delimiter = ',';
        if (comboBoxDelimiter.Text == "Крапка з комою (;)")
            Options.Delimiter = ';';

        Options.SheetName = textBoxSheetName.Text.Trim();
        if (string.IsNullOrWhiteSpace(Options.SheetName))
            Options.SheetName = "Insurance";
        DialogResult = DialogResult.OK;
    }
}
