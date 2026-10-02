using InsuranceAnalyzer.Domain.Entities;

namespace InsuranceAnalyzer.Domain.Interfaces;

public interface IDataProvider
{
    List<InsuranceRow> Import(string path, ImportOptions options);
    void Export(string path, List<InsuranceRow> rows, ExportOptions options);
}

public sealed class ImportOptions
{
    public string EncodingName { get; set; } = "utf-8";
    public char Delimiter { get; set; } = ',';
    public char DecimalSeparator { get; set; } = '.';
    public bool HasHeader { get; set; } = true;
}

public sealed class ExportOptions
{
    public string EncodingName { get; set; } = "utf-8";
    public char Delimiter { get; set; } = ',';
    public string SheetName { get; set; } = "Insurance";
}
