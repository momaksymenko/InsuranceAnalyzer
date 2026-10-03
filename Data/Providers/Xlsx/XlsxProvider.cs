using ClosedXML.Excel;
using InsuranceAnalyzer.Data.Mappers;
using InsuranceAnalyzer.Domain.Entities;
using InsuranceAnalyzer.Domain.Interfaces;

namespace InsuranceAnalyzer.Data.Providers.Xlsx;

public class XlsxProvider : IDataProvider
{
    public List<InsuranceRow> Import(string path, ImportOptions options)
    {
        using var book = new XLWorkbook(path); 
        var sheet = book.Worksheets.First();
        if (options.HasHeader) 
            ValidateHeader(sheet.Row(1));
        var start = 0;
        if (options.HasHeader)
            start = 1;

        return sheet.RowsUsed().Skip(start).Select((r, i) =>
            InsuranceMapper.FromValues(Enumerable.Range(1, 7).Select(c => r.Cell(c).GetString()).ToList(), i + 1, options.DecimalSeparator)).ToList();
    }
    public void Export(string path, List<InsuranceRow> rows, ExportOptions options)
    {
        using var book = new XLWorkbook(); 
        var sheet = book.Worksheets.Add(options.SheetName);
        sheet.Cell(1, 1).InsertTable(rows.Select(r => new { r.Age, r.Sex, r.Bmi, r.Children, r.Smoker, r.Region, r.Charges }), "Insurance", true);
        sheet.Columns().AdjustToContents(); 
        book.SaveAs(path);
    }

    private static void ValidateHeader(IXLRow row)
    {
        var expected = new[] { "age", "sex", "bmi", "children", "smoker", "region", "charges" };
        var actual = Enumerable.Range(1, expected.Length).Select(column => row.Cell(column).GetString());
        if (!expected.SequenceEqual(actual, StringComparer.OrdinalIgnoreCase))
            throw new FormatException("Для XLSX очікуються стовпці: age, sex, bmi, children, smoker, region, charges.");
    }
}
