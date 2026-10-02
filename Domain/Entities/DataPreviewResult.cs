namespace InsuranceAnalyzer.Domain.Entities;

public class DataPreviewResult
{
    public List<InsuranceRow> Rows { get; set; } = new();
    public int RowCount { get; set; }
    public int ColumnCount { get; set; }
    public int MissingValues { get; set; }
    public string FieldTypes { get; set; } = "";
}
