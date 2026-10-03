using InsuranceAnalyzer.Domain.Entities;

namespace InsuranceAnalyzer.UI.Forms
{
public partial class InsuranceRecordForm : Form
{
    private readonly int _recordId;
    public InsuranceRecord ResultRecord { get; private set; } = new();

    public InsuranceRecordForm(InsuranceRecord? record = null)
    {
        InitializeComponent();
        comboBoxSex.Items.AddRange(new object[] { "female", "male" });
        comboBoxSmoker.Items.AddRange(new object[] { "yes", "no" });
        comboBoxRegion.Items.AddRange(new object[] { "northeast", "northwest", "southeast", "southwest" });
        _recordId = 0;
        if (record != null)
        {
            _recordId = record.Id;
            FillControls(record);
        }
    }

    private void buttonSave_Click(object? sender, EventArgs e)
    {
        if (!TryReadValues(out var age, out var bmi, out var children, out var charges))
        {
            return;
        }

        ResultRecord = new InsuranceRecord { Id = _recordId, Age = age, Sex = comboBoxSex.Text, Bmi = bmi, Children = children, Smoker = comboBoxSmoker.Text, Region = comboBoxRegion.Text, Charges = charges };
        ResultRecord.Patient.Id = _recordId;
        ResultRecord.Patient.InsuranceRecords.Add(ResultRecord);
    }

    private bool TryReadValues(out int age, out decimal bmi, out int children, out decimal charges)
    {
        age = 0;
        bmi = 0;
        children = 0;
        charges = 0;
        ClearErrors();
        var isValid = true;

        age = Decimal.ToInt32(numericAge.Value);
        if (age < 1 || age > 120)
        {
            labelErrorAge.Text = "Вкажіть вік від 1 до 120.";
            isValid = false;
        }

        if (comboBoxSex.SelectedItem == null)
        {
            labelErrorSex.Text = "Оберіть стать.";
            isValid = false;
        }

        bmi = numericBmi.Value;
        if (bmi < 10 || bmi > 70)
        {
            labelErrorBmi.Text = "BMI має бути від 10 до 70.";
            isValid = false;
        }

        children = Decimal.ToInt32(numericChildren.Value);
        if (children < 0 || children > 50)
        {
            labelErrorChildren.Text = "Вкажіть кількість дітей від 0 до 50.";
            isValid = false;
        }

        if (comboBoxSmoker.SelectedItem == null)
        {
            labelErrorSmoker.Text = "Оберіть статус куріння.";
            isValid = false;
        }

        if (comboBoxRegion.SelectedItem == null)
        {
            labelErrorRegion.Text = "Оберіть регіон.";
            isValid = false;
        }

        charges = numericCharges.Value;
        if (charges < 0)
        {
            labelErrorCharges.Text = "Вкажіть невід'ємну вартість.";
            isValid = false;
        }

        if (isValid)     
            return true;
        

        DialogResult = DialogResult.None;
        return false;
    }

    private void ClearErrors()
    {
        labelErrorAge.Text = "";
        labelErrorSex.Text = "";
        labelErrorBmi.Text = "";
        labelErrorChildren.Text = "";
        labelErrorSmoker.Text = "";
        labelErrorRegion.Text = "";
        labelErrorCharges.Text = "";
    }

    private void FillControls(InsuranceRecord record)
    {
        numericAge.Value = Math.Clamp(record.Age, 0, 120);
        numericBmi.Value = Math.Clamp(record.Bmi, 0, 70);
        numericChildren.Value = Math.Clamp(record.Children, 0, 50);
        numericCharges.Value = Math.Clamp(record.Charges, 0, 1000000);
        comboBoxSex.SelectedItem = record.Sex; comboBoxSmoker.SelectedItem = record.Smoker; comboBoxRegion.SelectedItem = record.Region;
    }

}
}
