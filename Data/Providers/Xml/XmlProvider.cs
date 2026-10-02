using System.Xml.Serialization;
using System.Text;
using InsuranceAnalyzer.Domain.Entities;
using InsuranceAnalyzer.Domain.Interfaces;

namespace InsuranceAnalyzer.Data.Providers.Xml;

public class XmlProvider : IDataProvider
{
    public List<InsuranceRow> Import(string path, ImportOptions options)
    {
        var serializer = new XmlSerializer(typeof(List<InsuranceRow>));
        Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
        using var reader = new StreamReader(path, Encoding.GetEncoding(options.EncodingName));
        var rows = serializer.Deserialize(reader) as List<InsuranceRow>;
        if (rows == null)
            return new List<InsuranceRow>();

        return rows;
    }
    public void Export(string path, List<InsuranceRow> rows, ExportOptions options)
    {
        var serializer = new XmlSerializer(typeof(List<InsuranceRow>));
        Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
        using var writer = new StreamWriter(path, false, Encoding.GetEncoding(options.EncodingName));
        serializer.Serialize(writer, rows);
    }
}
