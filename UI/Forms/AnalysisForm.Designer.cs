namespace InsuranceAnalyzer.UI.Forms
{
partial class AnalysisForm
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
            components.Dispose();
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        groupBoxSettings = new GroupBox();
        labelGroupField = new Label();
        comboBoxGroupField = new ComboBox();
        labelValueField = new Label();
        comboBoxValueField = new ComboBox();
        dataGridViewResults = new DataGridView();
        groupBoxSettings.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dataGridViewResults).BeginInit();
        SuspendLayout();
        // 
        // groupBoxSettings
        // 
        groupBoxSettings.Controls.Add(labelGroupField);
        groupBoxSettings.Controls.Add(comboBoxGroupField);
        groupBoxSettings.Controls.Add(labelValueField);
        groupBoxSettings.Controls.Add(comboBoxValueField);
        groupBoxSettings.Font = new Font("Segoe UI", 10F);
        groupBoxSettings.Location = new Point(14, 13);
        groupBoxSettings.Name = "groupBoxSettings";
        groupBoxSettings.Size = new Size(792, 94);
        groupBoxSettings.TabIndex = 0;
        groupBoxSettings.TabStop = false;
        groupBoxSettings.Text = "Параметри аналізу";
        // 
        // labelGroupField
        // 
        labelGroupField.AutoSize = true;
        labelGroupField.Location = new Point(17, 27);
        labelGroupField.Name = "labelGroupField";
        labelGroupField.Size = new Size(112, 23);
        labelGroupField.TabIndex = 0;
        labelGroupField.Text = "Групувати за:";
        // 
        // comboBoxGroupField
        // 
        comboBoxGroupField.DropDownStyle = ComboBoxStyle.DropDownList;
        comboBoxGroupField.Font = new Font("Segoe UI", 10F);
        comboBoxGroupField.FormattingEnabled = true;
        comboBoxGroupField.Items.AddRange(new object[] { "Регіон", "Стать", "Куріння" });
        comboBoxGroupField.Location = new Point(17, 53);
        comboBoxGroupField.Name = "comboBoxGroupField";
        comboBoxGroupField.Size = new Size(360, 31);
        comboBoxGroupField.TabIndex = 1;
        comboBoxGroupField.SelectedIndexChanged += comboBoxSelectionChanged;
        // 
        // labelValueField
        // 
        labelValueField.AutoSize = true;
        labelValueField.Location = new Point(409, 27);
        labelValueField.Name = "labelValueField";
        labelValueField.Size = new Size(163, 23);
        labelValueField.TabIndex = 2;
        labelValueField.Text = "Поле для розрахунку:";
        // 
        // comboBoxValueField
        // 
        comboBoxValueField.DropDownStyle = ComboBoxStyle.DropDownList;
        comboBoxValueField.Font = new Font("Segoe UI", 10F);
        comboBoxValueField.FormattingEnabled = true;
        comboBoxValueField.Items.AddRange(new object[] { "Вік", "Кількість дітей", "Вартість страхування" });
        comboBoxValueField.Location = new Point(409, 53);
        comboBoxValueField.Name = "comboBoxValueField";
        comboBoxValueField.Size = new Size(360, 31);
        comboBoxValueField.TabIndex = 3;
        comboBoxValueField.SelectedIndexChanged += comboBoxSelectionChanged;
        // 
        // dataGridViewResults
        // 
        dataGridViewResults.AllowUserToAddRows = false;
        dataGridViewResults.AllowUserToDeleteRows = false;
        dataGridViewResults.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        dataGridViewResults.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dataGridViewResults.BackgroundColor = SystemColors.Window;
        dataGridViewResults.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridViewResults.Location = new Point(14, 122);
        dataGridViewResults.MultiSelect = false;
        dataGridViewResults.Name = "dataGridViewResults";
        dataGridViewResults.ReadOnly = true;
        dataGridViewResults.RowHeadersVisible = false;
        dataGridViewResults.RowHeadersWidth = 51;
        dataGridViewResults.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dataGridViewResults.Size = new Size(792, 230);
        dataGridViewResults.TabIndex = 1;
        // 
        // AnalysisForm
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(820, 368);
        Controls.Add(dataGridViewResults);
        Controls.Add(groupBoxSettings);
        Font = new Font("Segoe UI", 10F);
        MinimumSize = new Size(836, 415);
        Name = "AnalysisForm";
        StartPosition = FormStartPosition.CenterParent;
        Text = "Аналіз даних";
        groupBoxSettings.ResumeLayout(false);
        groupBoxSettings.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)dataGridViewResults).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private GroupBox groupBoxSettings;
    private Label labelGroupField;
    private ComboBox comboBoxGroupField;
    private Label labelValueField;
    private ComboBox comboBoxValueField;
    private DataGridView dataGridViewResults;
}
}
