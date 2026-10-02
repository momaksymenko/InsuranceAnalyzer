using System.Globalization;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using A = DocumentFormat.OpenXml.Drawing;
using PIC = DocumentFormat.OpenXml.Drawing.Pictures;
using WP = DocumentFormat.OpenXml.Drawing.Wordprocessing;
using InsuranceAnalyzer.Domain.Entities;
using InsuranceAnalyzer.Domain.Interfaces;

namespace InsuranceAnalyzer.Data.Reports;

public class DocxReportService : IReportService
{
    private static readonly CultureInfo UkrainianCulture = CultureInfo.GetCultureInfo("uk-UA");

    public void Create(string path, List<InsuranceRecord> rows, List<string> chartPaths)
    {
        using var document = WordprocessingDocument.Create(path, WordprocessingDocumentType.Document);
        var main = document.AddMainDocumentPart();
        main.Document = new Document(new Body());
        var body = main.Document.Body!;

        AddTitlePage(body);
        body.Append(Paragraph("Звіт з аналізу медичного страхування", true, 32));
        body.Append(Paragraph("Ключові показники", true, 26));
        body.Append(MetricsTable(rows));
        body.Append(Paragraph("Висновок", true, 26));
        body.Append(Paragraph(CreateConclusion(rows)));

        var images = chartPaths.Where(File.Exists).Take(2).ToList();
        if (images.Count > 0)
        {
            body.Append(Paragraph("Графіки", true, 26));
            uint imageId = 1;
            foreach (var image in images) 
                AddImage(main, body, image, imageId++);
        }

        body.Append(new SectionProperties(
            new PageSize { Width = 11906, Height = 16838 },
            new PageMargin { Top = 1134, Right = 1134, Bottom = 1134, Left = 1134 }));
        main.Document.Save();
    }

    private static void AddTitlePage(Body body)
    {
        body.Append(CenteredParagraph("ЗВІТ", true, 32));
        body.Append(CenteredParagraph("з лабораторної роботи № 1.2", false, 24));
        body.Append(CenteredParagraph("Аналіз даних медичного страхування", true, 28));
        body.Append(EmptyParagraph(8));
        body.Append(AlignedParagraph("Виконала: Максименко Марія", JustificationValues.Right, 22));
        body.Append(AlignedParagraph("Група: КН-22", JustificationValues.Right, 22));
        body.Append(AlignedParagraph("Варіант: 21", JustificationValues.Right, 22));
        body.Append(EmptyParagraph(6));
        body.Append(Paragraph("Короткий опис датасету", true, 24));
        body.Append(Paragraph("Набір Medical Cost Personal Datasets містить 1338 записів про витрати на медичне страхування. " +
            "Для кожної особи подано вік, стать, BMI, кількість дітей, статус куріння, регіон проживання та суму страхових витрат."));
        body.Append(Paragraph("Джерело: Kaggle, Medical Cost Personal Datasets (https://www.kaggle.com/mirichoi0218/insurance/home).", false, 18));
        body.Append(EmptyParagraph(5));
        body.Append(CenteredParagraph("2026", false, 20));
        body.Append(new Paragraph(new Run(new Break { Type = BreakValues.Page })));
    }

    private static Table MetricsTable(List<InsuranceRecord> rows)
    {
        var table = new Table(new TableProperties(
            new TableWidth { Width = "5000", Type = TableWidthUnitValues.Pct },
            new TableBorders(
                new TopBorder { Val = BorderValues.Single, Size = 6 }, new LeftBorder { Val = BorderValues.Single, Size = 6 },
                new BottomBorder { Val = BorderValues.Single, Size = 6 }, new RightBorder { Val = BorderValues.Single, Size = 6 },
                new InsideHorizontalBorder { Val = BorderValues.Single, Size = 6 }, new InsideVerticalBorder { Val = BorderValues.Single, Size = 6 })));

        table.Append(new TableGrid(new GridColumn(), new GridColumn()));

        table.Append(Row("Показник", "Значення", true));
        table.Append(Row("Кількість записів", rows.Count.ToString(UkrainianCulture)));
        table.Append(Row("Середній вік", Average(rows, row => row.Age).ToString("N2", UkrainianCulture)));
        table.Append(Row("Середня вартість страхування", Average(rows, row => row.Charges).ToString("N2", UkrainianCulture)));
        table.Append(Row("Середній BMI", Average(rows, row => row.Bmi).ToString("N2", UkrainianCulture)));
        table.Append(Row("Середня кількість дітей", Average(rows, row => row.Children).ToString("N2", UkrainianCulture)));
        return table;
    }

    private static string CreateConclusion(List<InsuranceRecord> rows)
    {
        if (rows.Count == 0) 
            return "Для формування висновку немає записів.";

        var count = rows.Count;
        var metrics = $"Усього проаналізовано {count} записів. Середній вік становить {Average(rows, row => row.Age):N2}, " +
            $"середня вартість страхування - {Average(rows, row => row.Charges):N2}, середній BMI - {Average(rows, row => row.Bmi):N2}, " +
            $"а середня кількість дітей - {Average(rows, row => row.Children):N2}.";
        var regionText = " Розподіл за регіонами: " + Percentages(rows, row => row.Region) + ".";
        var smokerText = " Куріння: " + Percentages(rows, row => row.Smoker) + ".";
        var sexText = " Стать: " + Percentages(rows, row => row.Sex) + ".";
        return metrics + regionText + smokerText + sexText;
    }

    private static decimal Average<T>(List<InsuranceRecord> rows, Func<InsuranceRecord, T> selector) where T : struct, IConvertible
    {
        if (rows.Count == 0)
            return 0;

        return rows.Average(row => Convert.ToDecimal(selector(row)));
    }

    private static string Percentages(List<InsuranceRecord> rows, Func<InsuranceRecord, string> selector)
    {
        return string.Join(", ", rows
            .GroupBy(selector)
            .OrderBy(group => group.Key)
            .Select(group => $"{group.Key} - {(decimal)group.Count() / rows.Count:P1}"));
    }

    private static Paragraph Paragraph(string text, bool heading = false, int fontSize = 22)
    {
        var properties = new RunProperties();
        if (heading)
            properties.Append(new Bold());

        properties.Append(new FontSize { Val = fontSize.ToString() });
        return new Paragraph(new Run(properties, new Text(text)));
    }

    private static Paragraph CenteredParagraph(string text, bool heading, int fontSize)
    {
        return AlignedParagraph(text, JustificationValues.Center, fontSize, heading);
    }

    private static Paragraph AlignedParagraph(string text, JustificationValues alignment, int fontSize, bool heading = false)
    {
        var paragraph = Paragraph(text, heading, fontSize);
        paragraph.ParagraphProperties = new ParagraphProperties(new Justification { Val = alignment });
        return paragraph;
    }

    private static Paragraph EmptyParagraph(int fontSize)
    {
        return new Paragraph(new Run(new RunProperties(new FontSize { Val = fontSize.ToString() }), new Text(" ")));
    }

    private static TableRow Row(string firstValue, string secondValue, bool header = false)
    {
        var firstCell = new TableCell(Paragraph(firstValue, header));
        var secondCell = new TableCell(Paragraph(secondValue, header));
        if (header)
        {
            firstCell.TableCellProperties = new TableCellProperties(new Shading { Val = ShadingPatternValues.Clear, Fill = "D9EAF7" });
            secondCell.TableCellProperties = new TableCellProperties(new Shading { Val = ShadingPatternValues.Clear, Fill = "D9EAF7" });
        }
        return new TableRow(firstCell, secondCell);
    }

    private static void AddImage(MainDocumentPart main, Body body, string path, uint imageId)
    {
        var part = main.AddImagePart(ImagePartType.Png);
        using (var stream = File.OpenRead(path)) part.FeedData(stream);
        var relationship = main.GetIdOfPart(part);
        var drawing = new Drawing(new WP.Inline(
            new WP.Extent { Cx = 5486400L, Cy = 3200400L },
            new WP.EffectExtent { LeftEdge = 0L, TopEdge = 0L, RightEdge = 0L, BottomEdge = 0L },
            new WP.DocProperties { Id = imageId, Name = Path.GetFileName(path) },
            new WP.NonVisualGraphicFrameDrawingProperties(new A.GraphicFrameLocks { NoChangeAspect = true }),
            new A.Graphic(new A.GraphicData(new PIC.Picture(
                new PIC.NonVisualPictureProperties(new PIC.NonVisualDrawingProperties { Id = imageId, Name = Path.GetFileName(path) }, new PIC.NonVisualPictureDrawingProperties()),
                new PIC.BlipFill(new A.Blip { Embed = relationship }, new A.Stretch(new A.FillRectangle())),
                new PIC.ShapeProperties(new A.Transform2D(new A.Offset { X = 0L, Y = 0L }, new A.Extents { Cx = 5486400L, Cy = 3200400L }), new A.PresetGeometry(new A.AdjustValueList()) { Preset = A.ShapeTypeValues.Rectangle })))
            { Uri = "http://schemas.openxmlformats.org/drawingml/2006/picture" }))
            { DistanceFromTop = 0U, DistanceFromBottom = 0U, DistanceFromLeft = 0U, DistanceFromRight = 0U });
        body.Append(new Paragraph(new Run(drawing)));
    }
}
