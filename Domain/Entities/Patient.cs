namespace InsuranceAnalyzer.Domain.Entities;

public class Patient
{
    public int Id { get; set; }
    public int Age { get; set; }
    public string Sex { get; set; } = "";
    public decimal Bmi { get; set; }
    public int Children { get; set; }
    public bool Smoker { get; set; }
    public string Region { get; set; } = "";
    public List<InsuranceRecord> InsuranceRecords { get; set; } = new();
}
