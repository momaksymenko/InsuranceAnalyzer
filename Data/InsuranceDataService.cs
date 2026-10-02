using InsuranceAnalyzer.Data.Mappers;
using InsuranceAnalyzer.Data.Providers.Csv;
using InsuranceAnalyzer.Data.Providers.Json;
using InsuranceAnalyzer.Data.Providers.Xlsx;
using InsuranceAnalyzer.Data.Providers.Xml;
using InsuranceAnalyzer.Domain.Entities;
using InsuranceAnalyzer.Domain.Interfaces;
using InsuranceAnalyzer.Domain.Validation;

namespace InsuranceAnalyzer.Data;

public class InsuranceDataService
{
    public List<InsuranceRecord> Import(string path, ImportOptions options)
    {
        var rows = Provider(path).Import(path, options);
        var records = new List<InsuranceRecord>();

        foreach (var row in rows)
        {
            var record = InsuranceMapper.ToInsuranceRecord(row);
            var error = Validate(record);
            if (error != null)
                throw new FormatException("Структура або дані файлу не відповідають набору медичного страхування: " + error);

            records.Add(record);
        }

        if (records.Count == 0)
            throw new FormatException("Файл не містить записів медичного страхування.");

        return records;
    }

    public void Export(string path, List<InsuranceRecord> records, ExportOptions options)
    {
        var rows = new List<InsuranceRow>();
        foreach (var record in records)
            rows.Add(InsuranceMapper.ToRow(record));

        Provider(path).Export(path, rows, options);
    }

    public List<InsuranceRecord> Filter(List<InsuranceRecord> records, FilterOptions options)
    {
        var result = new List<InsuranceRecord>();
        foreach (var record in records)
        {
            if (!IsInRange(record.Age, options.AgeFrom, options.AgeTo)) 
                continue;
            if (!IsInRange(record.Bmi, options.BmiFrom, options.BmiTo)) 
                continue;
            if (!IsInRange(record.Children, options.ChildrenFrom, options.ChildrenTo)) 
                continue;
            if (!IsInRange(record.Charges, options.ChargesFrom, options.ChargesTo)) 
                continue;
            if (!MatchesChoice(record.Sex, options.Sex)) 
                continue;
            if (!MatchesChoice(record.Smoker, options.Smoker)) 
                continue;
            if (!MatchesChoice(record.Region, options.Region)) 
                continue;
            result.Add(record);
        }

        return result;
    }

    public List<InsuranceRecord> Search(List<InsuranceRecord> records, string field, string text)
    {
        if (string.IsNullOrWhiteSpace(text))
            return records.ToList();

        var result = new List<InsuranceRecord>();
        foreach (var record in records)
        {
            var value = GetTextValue(record, field);
            if (value.Contains(text, StringComparison.OrdinalIgnoreCase))
                result.Add(record);
        }

        return result;
    }

    public List<InsuranceRecord> Sort(List<InsuranceRecord> records, string field, bool ascending)
    {
        if (ascending)
        {
            switch (field)
            {
                case "Id": 
                    return records.OrderBy(record => record.Id).ToList();
                case "Age": 
                    return records.OrderBy(record => record.Age).ToList();
                case "Sex": 
                    return records.OrderBy(record => record.Sex).ToList();
                case "Bmi": 
                    return records.OrderBy(record => record.Bmi).ToList();
                case "Children": 
                    return records.OrderBy(record => record.Children).ToList();
                case "Smoker": 
                    return records.OrderBy(record => record.Smoker).ToList();
                case "Region": 
                    return records.OrderBy(record => record.Region).ToList();
                case "Charges": 
                    return records.OrderBy(record => record.Charges).ToList();
                default: 
                    throw new ArgumentException("Поле сортування не знайдено.");
            }
        }

        switch (field)
        {
            case "Id": 
                return records.OrderByDescending(record => record.Id).ToList();
            case "Age": 
                return records.OrderByDescending(record => record.Age).ToList();
            case "Sex": 
                return records.OrderByDescending(record => record.Sex).ToList();
            case "Bmi": 
                return records.OrderByDescending(record => record.Bmi).ToList();
            case "Children": 
                return records.OrderByDescending(record => record.Children).ToList();
            case "Smoker": 
                return records.OrderByDescending(record => record.Smoker).ToList();
            case "Region": 
                return records.OrderByDescending(record => record.Region).ToList();
            case "Charges": 
                return records.OrderByDescending(record => record.Charges).ToList();
            default: 
                throw new ArgumentException("Поле сортування не знайдено.");
        }
    }

    public List<AggregationResult> Analyze(List<InsuranceRecord> records, string groupField, string valueField)
    {
        var groups = records.GroupBy(record => GetTextValue(record, groupField));
        var result = new List<AggregationResult>();

        foreach (var group in groups.OrderBy(group => group.Key))
        {
            var values = group.Select(record => GetNumberValue(record, valueField)).ToList();
            result.Add(new AggregationResult
            {
                Group = group.Key,
                Count = values.Count,
                Average = Math.Round(values.Average(), 4, MidpointRounding.AwayFromZero),
                Minimum = values.Min(),
                Maximum = values.Max()
            });
        }

        return result;
    }

    public string? Validate(InsuranceRecord record)
    {
        return InsuranceRowValidator.Validate(record);
    }

    private static IDataProvider Provider(string path)
    {
        var extension = Path.GetExtension(path).ToLowerInvariant();
        switch (extension)
        {
            case ".csv": 
                return new CsvProvider();
            case ".json": 
                return new JsonProvider();
            case ".xml": 
                return new XmlProvider();
            case ".xlsx": 
                return new XlsxProvider();
            default: 
                throw new NotSupportedException("Підтримуються лише CSV, JSON, XML та XLSX.");
        }
    }

    private static string GetTextValue(InsuranceRecord record, string field)
    {
        switch (field)
        {
            case "Id": 
                return record.Id.ToString();
            case "Age": 
                return record.Age.ToString();
            case "Sex": 
                return record.Sex;
            case "Bmi": 
                return record.Bmi.ToString();
            case "Children": 
                return record.Children.ToString();
            case "Smoker": 
                return record.Smoker;
            case "Region": 
                return record.Region;
            case "Charges": 
                return record.Charges.ToString();
            default: 
                throw new ArgumentException("Поле не знайдено.");
        }
    }

    private static decimal GetNumberValue(InsuranceRecord record, string field)
    {
        switch (field)
        {
            case "Age": 
                return record.Age;
            case "Bmi": 
                return record.Bmi;
            case "Children": 
                return record.Children;
            case "Charges": 
                return record.Charges;
            default: 
                throw new ArgumentException("Поле значення не знайдено.");
        }
    }

    private static bool IsInRange<T>(T value, T? from, T? to) where T : struct, IComparable<T>
    {
        if (from.HasValue && value.CompareTo(from.Value) < 0) 
            return false;
        if (to.HasValue && value.CompareTo(to.Value) > 0) 
            return false;
        return true;
    }

    private static bool MatchesChoice(string value, string selected)
    {
        return selected == "УСІ" || value.Equals(selected, StringComparison.OrdinalIgnoreCase);
    }
}
