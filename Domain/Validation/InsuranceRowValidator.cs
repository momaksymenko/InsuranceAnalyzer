using InsuranceAnalyzer.Domain.Entities;

namespace InsuranceAnalyzer.Domain.Validation;

public static class InsuranceRowValidator
{
    public static string? Validate(InsuranceRecord record)
    {
        if (record.Patient == null)
            return "Не знайдено дані пацієнта.";
        if (record.Age < 1 || record.Age > 120)
            return "Вік має бути від 1 до 120.";
        if (record.Bmi < 10 || record.Bmi > 70)
            return "BMI має бути від 10 до 70.";
        if (record.Children < 0 || record.Children > 50)
            return "Кількість дітей має бути від 0 до 50.";
        if (record.Charges < 0)
            return "Вартість страхування не може бути від'ємною.";
        if (string.IsNullOrWhiteSpace(record.Region)) 
            return "Оберіть регіон.";
        if (string.IsNullOrWhiteSpace(record.Sex)) 
            return "Укажіть стать.";
        if (!record.Smoker.Equals("yes", StringComparison.OrdinalIgnoreCase) &&
            !record.Smoker.Equals("no", StringComparison.OrdinalIgnoreCase))
            return "Статус куріння має бути yes або no.";
        return null;
    }
}
