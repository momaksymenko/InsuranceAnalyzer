namespace InsuranceAnalyzer.Domain.Entities;

public class InsuranceRow
{
    public int Id { get; set; }
    public int Age { get; set; }
    public string Sex { get; set; } = "";
    public decimal Bmi { get; set; }
    public int Children { get; set; }
    public string Smoker { get; set; } = "";
    public string Region { get; set; } = "";
    public decimal Charges { get; set; }
}
