namespace InsuranceAnalyzer.Domain.Entities;

public class AggregationResult
{
    public string Group { get; set; } = "";
    public int Count { get; set; }
    public decimal Average { get; set; }
    public decimal Minimum { get; set; }
    public decimal Maximum { get; set; }
}
