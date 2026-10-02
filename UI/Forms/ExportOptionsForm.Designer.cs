namespace InsuranceAnalyzer.UI.Forms
{
    partial class ExportOptionsForm
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
            labelEncoding = new Label();
            comboBoxEncoding = new ComboBox();
            labelDelimiter = new Label();
            comboBoxDelimiter = new ComboBox();
            labelSheetName = new Label();
            textBoxSheetName = new TextBox();
            buttonSave = new Button();
            buttonCancel = new Button();
            SuspendLayout();
            // 
            // labelEncoding
            // 
            labelEncoding.AutoSize = true;
            labelEncoding.Location = new Point(18, 20);
            labelEncoding.Name = "labelEncoding";
            labelEncoding.Size = new Size(121, 20);
            labelEncoding.TabIndex = 0;
            labelEncoding.Text = "Кодування CSV:";
            // 
            // comboBoxEncoding
            // 
            comboBoxEncoding.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxEncoding.FormattingEnabled = true;
            comboBoxEncoding.Items.AddRange(new object[] { "utf-8", "windows-1251" });
            comboBoxEncoding.Location = new Point(160, 17);
            comboBoxEncoding.Name = "comboBoxEncoding";
            comboBoxEncoding.Size = new Size(150, 28);
            comboBoxEncoding.TabIndex = 1;
            // 
            // labelDelimiter
            // 
            labelDelimiter.AutoSize = true;
            labelDelimiter.Location = new Point(18, 60);
            labelDelimiter.Name = "labelDelimiter";
            labelDelimiter.Size = new Size(133, 20);
            labelDelimiter.TabIndex = 2;
            labelDelimiter.Text = "Роздільник CSV:";
            // 
            // comboBoxDelimiter
            // 
            comboBoxDelimiter.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxDelimiter.FormattingEnabled = true;
            comboBoxDelimiter.Items.AddRange(new object[] { "Кома (,)", "Крапка з комою (;)" });
            comboBoxDelimiter.Location = new Point(160, 57);
            comboBoxDelimiter.Name = "comboBoxDelimiter";
            comboBoxDelimiter.Size = new Size(180, 28);
            comboBoxDelimiter.TabIndex = 3;
            // 
            // labelSheetName
            // 
            labelSheetName.AutoSize = true;
            labelSheetName.Location = new Point(18, 100);
            labelSheetName.Name = "labelSheetName";
            labelSheetName.Size = new Size(161, 20);
            labelSheetName.TabIndex = 4;
            labelSheetName.Text = "Назва аркуша XLSX:";
            // 
            // textBoxSheetName
            // 
            textBoxSheetName.Location = new Point(160, 97);
            textBoxSheetName.Name = "textBoxSheetName";
            textBoxSheetName.Size = new Size(180, 27);
            textBoxSheetName.TabIndex = 5;
            textBoxSheetName.Text = "Insurance";
            // 
            // buttonSave
            // 
            buttonSave.DialogResult = DialogResult.OK;
            buttonSave.Location = new Point(113, 148);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(105, 31);
            buttonSave.TabIndex = 6;
            buttonSave.Text = "Зберегти";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.DialogResult = DialogResult.Cancel;
            buttonCancel.Location = new Point(235, 148);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(105, 31);
            buttonCancel.TabIndex = 7;
            buttonCancel.Text = "Скасувати";
            buttonCancel.UseVisualStyleBackColor = true;
            // 
            // ExportOptionsForm
            // 
            AcceptButton = buttonSave;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = buttonCancel;
            ClientSize = new Size(365, 198);
            Controls.Add(buttonCancel);
            Controls.Add(buttonSave);
            Controls.Add(textBoxSheetName);
            Controls.Add(labelSheetName);
            Controls.Add(comboBoxDelimiter);
            Controls.Add(labelDelimiter);
            Controls.Add(comboBoxEncoding);
            Controls.Add(labelEncoding);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ExportOptionsForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Параметри експорту";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelEncoding;
        private ComboBox comboBoxEncoding;
        private Label labelDelimiter;
        private ComboBox comboBoxDelimiter;
        private Label labelSheetName;
        private TextBox textBoxSheetName;
        private Button buttonSave;
        private Button buttonCancel;
    }
}
