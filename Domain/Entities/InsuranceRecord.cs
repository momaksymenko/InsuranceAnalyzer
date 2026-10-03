using System.ComponentModel;

namespace InsuranceAnalyzer.Domain.Entities;

public class InsuranceRecord
{
    private string _smoker = string.Empty;

    public int Id { get; set; }

    [Browsable(false)]
    public Patient Patient { get; set; } = new();

    public int Age { get { return Patient.Age; } set { Patient.Age = value; } }
    public string Sex { get { return Patient.Sex; } set { Patient.Sex = value; } }
    public decimal Bmi { get { return Patient.Bmi; } set { Patient.Bmi = value; } }
    public int Children { get { return Patient.Children; } set { Patient.Children = value; } }
    public string Smoker
    {
        get { return _smoker; }
        set
        {
            if (value == null)
                _smoker = string.Empty;
            else
                _smoker = value.Trim();

            if (_smoker.Equals("yes", StringComparison.OrdinalIgnoreCase))
                Patient.Smoker = true;
            else if (_smoker.Equals("no", StringComparison.OrdinalIgnoreCase))
                Patient.Smoker = false;
        }
    }
    public string Region { get { return Patient.Region; } set { Patient.Region = value; } }
    public decimal Charges { get; set; }
}
