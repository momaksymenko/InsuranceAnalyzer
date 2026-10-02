using System.Text;
using InsuranceAnalyzer.Data.Mappers;
using InsuranceAnalyzer.Domain.Entities;
using InsuranceAnalyzer.Domain.Interfaces;

namespace InsuranceAnalyzer.Data.Providers.Csv;

public class CsvProvider : IDataProvider
{
    public List<InsuranceRow> Import(string path, ImportOptions options)
    {
        Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
        var lines = File.ReadAllLines(path, Encoding.GetEncoding(options.EncodingName));
        if (options.HasHeader && lines.Length > 0) 
            ValidateHeader(Parse(lines[0], options.Delimiter));
        var start = 0;
        if (options.HasHeader)
            start = 1;
        return lines.Skip(start).Where(x => !string.IsNullOrWhiteSpace(x))
            .Select((line, index) => InsuranceMapper.FromValues(Parse(line, options.Delimiter), index + 1, options.DecimalSeparator)).ToList();
    }

    public void Export(string path, List<InsuranceRow> rows, ExportOptions options)
    {
        Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
        using var writer = new StreamWriter(path, false, Encoding.GetEncoding(options.EncodingName));
        writer.WriteLine(string.Join(options.Delimiter, "age", "sex", "bmi", "children", "smoker", "region", "charges"));
        foreach (var r in rows)
            writer.WriteLine(string.Join(options.Delimiter, r.Age, Quote(r.Sex, options.Delimiter), r.Bmi.ToString(System.Globalization.CultureInfo.InvariantCulture), r.Children, Quote(r.Smoker, options.Delimiter), Quote(r.Region, options.Delimiter), r.Charges.ToString(System.Globalization.CultureInfo.InvariantCulture)));
    }

    private static List<string> Parse(string line, char delimiter)
    {
        var result = new List<string>(); var value = new StringBuilder(); var quoted = false;
        foreach (var c in line)
        {
            if (c == '"') 
                quoted = !quoted;
            else if (c == delimiter && !quoted) 
            { 
                result.Add(value.ToString().Trim()); 
                value.Clear(); 
            }
            else 
                value.Append(c);
        }
        result.Add(value.ToString().Trim()); 
        return result;
    }

    private static string Quote(string text, char delimiter)
    {
        if (text.Contains(delimiter))
            return $"\"{text}\"";

        return text;
    }

    private static void ValidateHeader(List<string> header)
    {
        var expected = new[] { "age", "sex", "bmi", "children", "smoker", "region", "charges" };
        if (header.Count < expected.Length || !expected.SequenceEqual(header.Take(expected.Length), StringComparer.OrdinalIgnoreCase))
            throw new FormatException("Для CSV очікуються стовпці: age, sex, bmi, children, smoker, region, charges.");
    }
}
