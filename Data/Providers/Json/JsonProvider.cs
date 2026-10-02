using System.Text.Json;
using System.Text;
using InsuranceAnalyzer.Domain.Entities;
using InsuranceAnalyzer.Domain.Interfaces;

namespace InsuranceAnalyzer.Data.Providers.Json;

public class JsonProvider : IDataProvider
{
    private static readonly JsonSerializerOptions Options = new() { PropertyNameCaseInsensitive = true, WriteIndented = true };
    public List<InsuranceRow> Import(string path, ImportOptions options)
    {
        Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
        var encoding = Encoding.GetEncoding(options.EncodingName);
        var rows = JsonSerializer.Deserialize<List<InsuranceRow>>(File.ReadAllText(path, encoding), Options);
        if (rows == null)
            return new List<InsuranceRow>();

        return rows;
    }
    public void Export(string path, List<InsuranceRow> rows, ExportOptions options)
    {
        Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
        File.WriteAllText(path, JsonSerializer.Serialize(rows, Options), Encoding.GetEncoding(options.EncodingName));
    }
}
