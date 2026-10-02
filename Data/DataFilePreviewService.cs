using InsuranceAnalyzer.Domain.Entities;
using InsuranceAnalyzer.Domain.Interfaces;
using InsuranceAnalyzer.Data.Mappers;

namespace InsuranceAnalyzer.Data;

public class DataFilePreviewService
{
    private readonly InsuranceDataService _dataService = new();

    public DataPreviewResult Create(string path, ImportOptions options, int rowLimit = 10)
    {
        var records = _dataService.Import(path, options);
        return new DataPreviewResult
        {
            Rows = records.Take(rowLimit).Select(InsuranceMapper.ToRow).ToList(),
            RowCount = records.Count,
            ColumnCount = 7,
            MissingValues = CountMissingValues(records),
            FieldTypes = "Цілі числа: Age, Children\nЧисла: Bmi, Charges\nТекст: Sex, Smoker, Region"
        };
    }

    private static int CountMissingValues(List<InsuranceRecord> records)
    {
        var count = 0;
        foreach (var record in records)
        {
            if (string.IsNullOrWhiteSpace(record.Sex))
                count++;

            if (string.IsNullOrWhiteSpace(record.Smoker))
                count++;

            if (string.IsNullOrWhiteSpace(record.Region))
                count++;
        }

        return count;
    }
}
