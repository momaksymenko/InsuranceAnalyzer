using InsuranceAnalyzer.Domain.Entities;

namespace InsuranceAnalyzer.Data.Mappers;

public static class InsuranceMapper
{
    public static InsuranceRow FromValues(List<string> values, int id, char decimalSeparator = '.')
    {
        if (values.Count < 7) 
            throw new FormatException("Очікується 7 стовпців: age, sex, bmi, children, smoker, region, charges.");
        return new InsuranceRow
        {
            Id = id,
            Age = int.Parse(values[0]), Sex = values[1],
            Bmi = ReadDecimal(values[2], decimalSeparator),
            Children = int.Parse(values[3]), Smoker = values[4], Region = values[5],
            Charges = ReadDecimal(values[6], decimalSeparator)
        };
    }

    public static InsuranceRecord ToInsuranceRecord(InsuranceRow row)
    {
        var patient = new Patient
        {
            Id = row.Id,
            Age = row.Age,
            Sex = row.Sex,
            Bmi = row.Bmi,
            Children = row.Children,
            Smoker = row.Smoker.Equals("yes", StringComparison.OrdinalIgnoreCase),
            Region = row.Region
        };
        var record = new InsuranceRecord
        {
            Id = row.Id,
            Patient = patient,
            Smoker = row.Smoker,
            Charges = row.Charges
        };
        patient.InsuranceRecords.Add(record);
        return record;
    }

    public static InsuranceRow ToRow(InsuranceRecord record)
    {
        return new InsuranceRow
        {
            Id = record.Id,
            Age = record.Age,
            Sex = record.Sex,
            Bmi = record.Bmi,
            Children = record.Children,
            Smoker = record.Smoker,
            Region = record.Region,
            Charges = record.Charges
        };
    }

    private static decimal ReadDecimal(string value, char decimalSeparator)
    {
        var normalizedValue = value.Trim();
        if (decimalSeparator == ',')
            normalizedValue = normalizedValue.Replace(',', '.');
        else if (normalizedValue.Contains(',') && !normalizedValue.Contains('.'))
            normalizedValue = normalizedValue.Replace(',', '.');

        return decimal.Parse(normalizedValue, System.Globalization.CultureInfo.InvariantCulture);
    }
}
