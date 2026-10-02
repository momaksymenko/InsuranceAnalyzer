using System.ComponentModel;
using InsuranceAnalyzer.Data;
using InsuranceAnalyzer.Domain.Entities;

namespace InsuranceAnalyzer.UI.Forms;

public partial class AnalysisForm : Form
{
    private readonly InsuranceDataService _dataService = new();
    private readonly List<InsuranceRecord> _rows;
    private readonly BindingList<AggregationResult> _results = new();

    public AnalysisForm(List<InsuranceRecord> rows)
    {
        _rows = rows;
        InitializeComponent();
        dataGridViewResults.DataSource = _results;
        comboBoxGroupField.SelectedIndex = 0;
        comboBoxValueField.SelectedIndex = 0;
        UpdateResults();
    }

    private void comboBoxSelectionChanged(object? sender, EventArgs e)
    {
        UpdateResults();
    }

    private void UpdateResults()
    {
        if (string.IsNullOrWhiteSpace(comboBoxGroupField.Text) || string.IsNullOrWhiteSpace(comboBoxValueField.Text))
            return;

        _results.Clear();
        foreach (var result in _dataService.Analyze(_rows, GetGroupField(), GetValueField()))
            _results.Add(result);

        SetColumnHeader(nameof(AggregationResult.Group), "Група: " + comboBoxGroupField.Text);
        SetColumnHeader(nameof(AggregationResult.Count), "Кількість");
        SetColumnHeader(nameof(AggregationResult.Average), "Середнє");
        SetColumnHeader(nameof(AggregationResult.Minimum), "Мінімум");
        SetColumnHeader(nameof(AggregationResult.Maximum), "Максимум");
    }

    private void SetColumnHeader(string columnName, string headerText)
    {
        var column = dataGridViewResults.Columns[columnName];
        if (column != null)
            column.HeaderText = headerText;
    }

    private string GetGroupField()
    {
        switch (comboBoxGroupField.Text)
        {
            case "Регіон": return "Region";
            case "Стать": return "Sex";
            default: return "Smoker";
        }
    }

    private string GetValueField()
    {
        switch (comboBoxValueField.Text)
        {
            case "Вік": 
                return "Age";
            case "Кількість дітей": 
                return "Children";
            default: 
                return "Charges";
        }
    }
}
