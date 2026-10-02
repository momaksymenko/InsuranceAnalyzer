using InsuranceAnalyzer.Domain.Entities;
using InsuranceAnalyzer.Domain.Interfaces;
using OfficeOpenXml;
using OfficeOpenXml.Drawing.Chart;
using OfficeOpenXml.Style;

namespace InsuranceAnalyzer.Data.Reports;

public class XlsxReportService : IReportService
{
    public void Create(string path, List<InsuranceRecord> rows, List<string> chartPaths)
    {
        ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
        using var package = new ExcelPackage();
        CreateWorksheet(package, "Region", "Регіон", rows.GroupBy(row => row.Region));
        CreateWorksheet(package, "Sex", "Стать", rows.GroupBy(row => row.Sex));
        CreateWorksheet(package, "Smoker", "Куріння", rows.GroupBy(row => row.Smoker));
        package.SaveAs(new FileInfo(path));
    }

    private static void CreateWorksheet(ExcelPackage package, string sheetName, string groupTitle, IEnumerable<IGrouping<string, InsuranceRecord>> source)
    {
        var groups = source.OrderBy(group => group.Key).Select(CreateSummary).ToList();
        var sheet = package.Workbook.Worksheets.Add(sheetName);
        WriteTable(sheet, groupTitle, groups);
        AddChart(sheet, groupTitle, groups.Count);
    }

    private static RegionSummary CreateSummary(IGrouping<string, InsuranceRecord> group)
    {
        return new RegionSummary(
            group.Key, group.Count(), group.Average(row => row.Charges), group.Average(row => row.Age),
            group.Average(row => row.Children), group.Average(row => row.Bmi));
    }

    private static void WriteTable(ExcelWorksheet sheet, string groupTitle, List<RegionSummary> groups)
    {
        var headers = new[] { groupTitle, "Кількість", "Середня вартість", "Середній вік", "Середня к-сть дітей", "Середній BMI" };
        for (var column = 0; column < headers.Length; column++) 
            sheet.Cells[1, column + 1].Value = headers[column];

        for (var index = 0; index < groups.Count; index++)
        {
            var row = index + 2;
            var summary = groups[index];
            sheet.Cells[row, 1].Value = summary.Group;
            sheet.Cells[row, 2].Value = summary.Count;
            sheet.Cells[row, 3].Value = summary.AverageCharges;
            sheet.Cells[row, 4].Value = summary.AverageAge;
            sheet.Cells[row, 5].Value = summary.AverageChildren;
            sheet.Cells[row, 6].Value = summary.AverageBmi;
        }

        sheet.Cells[1, 1, 1, 6].Style.Font.Bold = true;
        sheet.Cells[1, 1, 1, 6].Style.Fill.PatternType = ExcelFillStyle.Solid;
        sheet.Cells[1, 1, 1, 6].Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.LightSteelBlue);
        sheet.Cells[1, 1, groups.Count + 1, 6].Style.Border.BorderAround(ExcelBorderStyle.Thin);
        sheet.Cells[2, 3, groups.Count + 1, 3].Style.Numberformat.Format = "#,##0.00";
        sheet.Cells[2, 4, groups.Count + 1, 6].Style.Numberformat.Format = "#,##0.0000";
        sheet.Cells[sheet.Dimension.Address].AutoFitColumns();
        sheet.Column(1).Width = Math.Max(sheet.Column(1).Width, 16);
        sheet.Column(3).Width = Math.Max(sheet.Column(3).Width, 19);

        if (groups.Count == 0) 
            return;
        sheet.ConditionalFormatting.AddTop(sheet.Cells[2, 3, groups.Count + 1, 3]).Rank = (ushort)Math.Min(3, groups.Count);
        sheet.ConditionalFormatting.AddBottom(sheet.Cells[2, 3, groups.Count + 1, 3]).Rank = 1;
    }

    private static void AddChart(ExcelWorksheet sheet, string groupTitle, int groupCount)
    {
        if (groupCount == 0) 
            return;
        var chart = sheet.Drawings.AddChart("AverageChargesChart", eChartType.ColumnClustered);
        chart.Title.Text = $"Середня вартість страхування за: {groupTitle}";
        chart.XAxis.Title.Text = groupTitle;
        chart.YAxis.Title.Text = "Вартість";
        chart.Series.Add(sheet.Cells[2, 3, groupCount + 1, 3], sheet.Cells[2, 1, groupCount + 1, 1]);
        chart.SetPosition(7, 0, 0, 0);
        chart.SetSize(760, 360);
    }

    private sealed record RegionSummary(string Group, int Count, decimal AverageCharges, double AverageAge, double AverageChildren, decimal AverageBmi);
}
