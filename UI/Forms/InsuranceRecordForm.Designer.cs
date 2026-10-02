namespace InsuranceAnalyzer.UI.Forms
{
    partial class InsuranceRecordForm
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
            labelAge = new Label();
            numericAge = new NumericUpDown();
            labelErrorAge = new Label();
            labelSex = new Label();
            comboBoxSex = new ComboBox();
            labelErrorSex = new Label();
            labelBmi = new Label();
            numericBmi = new NumericUpDown();
            labelErrorBmi = new Label();
            labelChildren = new Label();
            numericChildren = new NumericUpDown();
            labelErrorChildren = new Label();
            labelSmoker = new Label();
            comboBoxSmoker = new ComboBox();
            labelErrorSmoker = new Label();
            labelRegion = new Label();
            comboBoxRegion = new ComboBox();
            labelErrorRegion = new Label();
            labelCharges = new Label();
            numericCharges = new NumericUpDown();
            labelErrorCharges = new Label();
            buttonSave = new Button();
            buttonCancel = new Button();
            ((System.ComponentModel.ISupportInitialize)numericAge).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericBmi).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericChildren).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericCharges).BeginInit();
            SuspendLayout();
            // 
            // labelAge
            // 
            labelAge.AutoSize = true;
            labelAge.Font = new Font("Segoe UI", 11F);
            labelAge.Location = new Point(25, 18);
            labelAge.Name = "labelAge";
            labelAge.Size = new Size(37, 25);
            labelAge.TabIndex = 0;
            labelAge.Text = "Вік:";
            // 
            // numericAge
            // 
            numericAge.Font = new Font("Segoe UI", 11F);
            numericAge.Location = new Point(25, 46);
            numericAge.Maximum = new decimal(new int[] { 120, 0, 0, 0 });
            numericAge.Name = "numericAge";
            numericAge.Size = new Size(420, 32);
            numericAge.TabIndex = 0;
            // 
            // labelErrorAge
            // 
            labelErrorAge.AutoSize = true;
            labelErrorAge.Font = new Font("Segoe UI", 8.5F);
            labelErrorAge.ForeColor = Color.Firebrick;
            labelErrorAge.Location = new Point(25, 82);
            labelErrorAge.Name = "labelErrorAge";
            labelErrorAge.Size = new Size(0, 19);
            labelErrorAge.TabIndex = 1;
            // 
            // labelSex
            // 
            labelSex.AutoSize = true;
            labelSex.Font = new Font("Segoe UI", 11F);
            labelSex.Location = new Point(25, 105);
            labelSex.Name = "labelSex";
            labelSex.Size = new Size(61, 25);
            labelSex.TabIndex = 2;
            labelSex.Text = "Стать:";
            // 
            // comboBoxSex
            // 
            comboBoxSex.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxSex.Font = new Font("Segoe UI", 11F);
            comboBoxSex.FormattingEnabled = true;
            comboBoxSex.Location = new Point(25, 133);
            comboBoxSex.Name = "comboBoxSex";
            comboBoxSex.Size = new Size(420, 33);
            comboBoxSex.TabIndex = 1;
            // 
            // labelErrorSex
            // 
            labelErrorSex.AutoSize = true;
            labelErrorSex.Font = new Font("Segoe UI", 8.5F);
            labelErrorSex.ForeColor = Color.Firebrick;
            labelErrorSex.Location = new Point(25, 170);
            labelErrorSex.Name = "labelErrorSex";
            labelErrorSex.Size = new Size(0, 19);
            labelErrorSex.TabIndex = 3;
            // 
            // labelBmi
            // 
            labelBmi.AutoSize = true;
            labelBmi.Font = new Font("Segoe UI", 11F);
            labelBmi.Location = new Point(25, 193);
            labelBmi.Name = "labelBmi";
            labelBmi.Size = new Size(46, 25);
            labelBmi.TabIndex = 4;
            labelBmi.Text = "BMI:";
            // 
            // numericBmi
            // 
            numericBmi.DecimalPlaces = 2;
            numericBmi.Font = new Font("Segoe UI", 11F);
            numericBmi.Location = new Point(25, 221);
            numericBmi.Maximum = new decimal(new int[] { 70, 0, 0, 0 });
            numericBmi.Name = "numericBmi";
            numericBmi.Size = new Size(420, 32);
            numericBmi.TabIndex = 2;
            // 
            // labelErrorBmi
            // 
            labelErrorBmi.AutoSize = true;
            labelErrorBmi.Font = new Font("Segoe UI", 8.5F);
            labelErrorBmi.ForeColor = Color.Firebrick;
            labelErrorBmi.Location = new Point(25, 257);
            labelErrorBmi.Name = "labelErrorBmi";
            labelErrorBmi.Size = new Size(0, 19);
            labelErrorBmi.TabIndex = 5;
            // 
            // labelChildren
            // 
            labelChildren.AutoSize = true;
            labelChildren.Font = new Font("Segoe UI", 11F);
            labelChildren.Location = new Point(25, 280);
            labelChildren.Name = "labelChildren";
            labelChildren.Size = new Size(139, 25);
            labelChildren.TabIndex = 6;
            labelChildren.Text = "Кількість дітей:";
            // 
            // numericChildren
            // 
            numericChildren.Font = new Font("Segoe UI", 11F);
            numericChildren.Location = new Point(25, 308);
            numericChildren.Maximum = new decimal(new int[] { 50, 0, 0, 0 });
            numericChildren.Name = "numericChildren";
            numericChildren.Size = new Size(420, 32);
            numericChildren.TabIndex = 3;
            // 
            // labelErrorChildren
            // 
            labelErrorChildren.AutoSize = true;
            labelErrorChildren.Font = new Font("Segoe UI", 8.5F);
            labelErrorChildren.ForeColor = Color.Firebrick;
            labelErrorChildren.Location = new Point(25, 344);
            labelErrorChildren.Name = "labelErrorChildren";
            labelErrorChildren.Size = new Size(0, 19);
            labelErrorChildren.TabIndex = 7;
            // 
            // labelSmoker
            // 
            labelSmoker.AutoSize = true;
            labelSmoker.Font = new Font("Segoe UI", 11F);
            labelSmoker.Location = new Point(25, 367);
            labelSmoker.Name = "labelSmoker";
            labelSmoker.Size = new Size(84, 25);
            labelSmoker.TabIndex = 8;
            labelSmoker.Text = "Куріння:";
            // 
            // comboBoxSmoker
            // 
            comboBoxSmoker.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxSmoker.Font = new Font("Segoe UI", 11F);
            comboBoxSmoker.FormattingEnabled = true;
            comboBoxSmoker.Location = new Point(25, 395);
            comboBoxSmoker.Name = "comboBoxSmoker";
            comboBoxSmoker.Size = new Size(420, 33);
            comboBoxSmoker.TabIndex = 4;
            // 
            // labelErrorSmoker
            // 
            labelErrorSmoker.AutoSize = true;
            labelErrorSmoker.Font = new Font("Segoe UI", 8.5F);
            labelErrorSmoker.ForeColor = Color.Firebrick;
            labelErrorSmoker.Location = new Point(25, 432);
            labelErrorSmoker.Name = "labelErrorSmoker";
            labelErrorSmoker.Size = new Size(0, 19);
            labelErrorSmoker.TabIndex = 9;
            // 
            // labelRegion
            // 
            labelRegion.AutoSize = true;
            labelRegion.Font = new Font("Segoe UI", 11F);
            labelRegion.Location = new Point(25, 455);
            labelRegion.Name = "labelRegion";
            labelRegion.Size = new Size(75, 25);
            labelRegion.TabIndex = 10;
            labelRegion.Text = "Регіон:";
            // 
            // comboBoxRegion
            // 
            comboBoxRegion.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxRegion.Font = new Font("Segoe UI", 11F);
            comboBoxRegion.FormattingEnabled = true;
            comboBoxRegion.Location = new Point(25, 483);
            comboBoxRegion.Name = "comboBoxRegion";
            comboBoxRegion.Size = new Size(420, 33);
            comboBoxRegion.TabIndex = 5;
            // 
            // labelErrorRegion
            // 
            labelErrorRegion.AutoSize = true;
            labelErrorRegion.Font = new Font("Segoe UI", 8.5F);
            labelErrorRegion.ForeColor = Color.Firebrick;
            labelErrorRegion.Location = new Point(25, 520);
            labelErrorRegion.Name = "labelErrorRegion";
            labelErrorRegion.Size = new Size(0, 19);
            labelErrorRegion.TabIndex = 11;
            // 
            // labelCharges
            // 
            labelCharges.AutoSize = true;
            labelCharges.Font = new Font("Segoe UI", 11F);
            labelCharges.Location = new Point(25, 543);
            labelCharges.Name = "labelCharges";
            labelCharges.Size = new Size(193, 25);
            labelCharges.TabIndex = 12;
            labelCharges.Text = "Вартість страхування:";
            // 
            // numericCharges
            // 
            numericCharges.DecimalPlaces = 2;
            numericCharges.Font = new Font("Segoe UI", 11F);
            numericCharges.Location = new Point(25, 571);
            numericCharges.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numericCharges.Name = "numericCharges";
            numericCharges.Size = new Size(420, 32);
            numericCharges.TabIndex = 6;
            numericCharges.ThousandsSeparator = true;
            // 
            // labelErrorCharges
            // 
            labelErrorCharges.AutoSize = true;
            labelErrorCharges.Font = new Font("Segoe UI", 8.5F);
            labelErrorCharges.ForeColor = Color.Firebrick;
            labelErrorCharges.Location = new Point(25, 607);
            labelErrorCharges.Name = "labelErrorCharges";
            labelErrorCharges.Size = new Size(0, 19);
            labelErrorCharges.TabIndex = 13;
            // 
            // buttonSave
            // 
            buttonSave.DialogResult = DialogResult.OK;
            buttonSave.Font = new Font("Segoe UI", 10F);
            buttonSave.Location = new Point(25, 638);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(150, 38);
            buttonSave.TabIndex = 7;
            buttonSave.Text = "Зберегти";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.DialogResult = DialogResult.Cancel;
            buttonCancel.Font = new Font("Segoe UI", 10F);
            buttonCancel.Location = new Point(295, 638);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(150, 38);
            buttonCancel.TabIndex = 8;
            buttonCancel.Text = "Скасувати";
            buttonCancel.UseVisualStyleBackColor = true;
            // 
            // InsuranceRecordForm
            // 
            AcceptButton = buttonSave;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = buttonCancel;
            ClientSize = new Size(470, 693);
            Controls.Add(buttonCancel);
            Controls.Add(buttonSave);
            Controls.Add(labelErrorCharges);
            Controls.Add(numericCharges);
            Controls.Add(labelCharges);
            Controls.Add(labelErrorRegion);
            Controls.Add(comboBoxRegion);
            Controls.Add(labelRegion);
            Controls.Add(labelErrorSmoker);
            Controls.Add(comboBoxSmoker);
            Controls.Add(labelSmoker);
            Controls.Add(labelErrorChildren);
            Controls.Add(numericChildren);
            Controls.Add(labelChildren);
            Controls.Add(labelErrorBmi);
            Controls.Add(numericBmi);
            Controls.Add(labelBmi);
            Controls.Add(labelErrorSex);
            Controls.Add(comboBoxSex);
            Controls.Add(labelSex);
            Controls.Add(labelErrorAge);
            Controls.Add(numericAge);
            Controls.Add(labelAge);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "InsuranceRecordForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Запис страхування";
            ((System.ComponentModel.ISupportInitialize)numericAge).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericBmi).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericChildren).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericCharges).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelAge;
        private NumericUpDown numericAge;
        private Label labelErrorAge;
        private Label labelSex;
        private ComboBox comboBoxSex;
        private Label labelErrorSex;
        private Label labelBmi;
        private NumericUpDown numericBmi;
        private Label labelErrorBmi;
        private Label labelChildren;
        private NumericUpDown numericChildren;
        private Label labelErrorChildren;
        private Label labelSmoker;
        private ComboBox comboBoxSmoker;
        private Label labelErrorSmoker;
        private Label labelRegion;
        private ComboBox comboBoxRegion;
        private Label labelErrorRegion;
        private Label labelCharges;
        private NumericUpDown numericCharges;
        private Label labelErrorCharges;
        private Button buttonSave;
        private Button buttonCancel;
    }
}
