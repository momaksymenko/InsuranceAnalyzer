namespace InsuranceAnalyzer.Domain.Entities;

public class FilterOptions
{
    public int? AgeFrom { get; set; }
    public int? AgeTo { get; set; }
    public decimal? BmiFrom { get; set; }
    public decimal? BmiTo { get; set; }
    public int? ChildrenFrom { get; set; }
    public int? ChildrenTo { get; set; }
    public decimal? ChargesFrom { get; set; }
    public decimal? ChargesTo { get; set; }
    public string Sex { get; set; } = "УСІ";
    public string Smoker { get; set; } = "УСІ";
    public string Region { get; set; } = "УСІ";
}
