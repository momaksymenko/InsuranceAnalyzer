namespace InsuranceAnalyzer.UI.Forms
{
    partial class ImportOptionsForm
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
            labelFile = new Label(); labelFileName = new Label();
            labelEncoding = new Label(); comboBoxEncoding = new ComboBox();
            labelDelimiter = new Label(); comboBoxDelimiter = new ComboBox();
            labelDecimalSeparator = new Label(); comboBoxDecimalSeparator = new ComboBox();
            checkBoxHeader = new CheckBox(); labelTypesTitle = new Label(); labelTypes = new Label();
            dataGridViewPreview = new DataGridView(); labelSummary = new Label();
            buttonImport = new Button(); buttonCancel = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPreview).BeginInit();
            SuspendLayout();
            // 
            // labelFile
            // 
            labelFile.AutoSize = true;
            labelFile.Font = new Font("Segoe UI", 10F);
            labelFile.Location = new Point(20, 17);
            labelFile.Name = "labelFile";
            labelFile.Size = new Size(53, 23);
            labelFile.TabIndex = 0;
            labelFile.Text = "Файл:";
            // 
            // labelFileName
            // 
            labelFileName.AutoSize = true;
            labelFileName.Font = new Font("Segoe UI", 10F);
            labelFileName.Location = new Point(82, 17);
            labelFileName.Name = "labelFileName";
            labelFileName.Size = new Size(0, 23);
            labelFileName.TabIndex = 1;
            // 
            // labelEncoding
            // 
            labelEncoding.AutoSize = true;
            labelEncoding.Font = new Font("Segoe UI", 10F);
            labelEncoding.Location = new Point(20, 55);
            labelEncoding.Name = "labelEncoding";
            labelEncoding.Size = new Size(99, 23);
            labelEncoding.TabIndex = 2;
            labelEncoding.Text = "Кодування:";
            // 
            // comboBoxEncoding
            // 
            comboBoxEncoding.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxEncoding.Font = new Font("Segoe UI", 10F);
            comboBoxEncoding.FormattingEnabled = true;
            comboBoxEncoding.Items.AddRange(new object[] { "utf-8", "windows-1251" });
            comboBoxEncoding.Location = new Point(20, 81);
            comboBoxEncoding.Name = "comboBoxEncoding";
            comboBoxEncoding.Size = new Size(220, 31);
            comboBoxEncoding.TabIndex = 3;
            comboBoxEncoding.SelectedIndexChanged += importOption_Changed;
            // 
            // labelDelimiter
            // 
            labelDelimiter.AutoSize = true;
            labelDelimiter.Font = new Font("Segoe UI", 10F);
            labelDelimiter.Location = new Point(280, 55);
            labelDelimiter.Name = "labelDelimiter";
            labelDelimiter.Size = new Size(107, 23);
            labelDelimiter.TabIndex = 4;
            labelDelimiter.Text = "Роздільник:";
            // 
            // comboBoxDelimiter
            // 
            comboBoxDelimiter.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxDelimiter.Font = new Font("Segoe UI", 10F);
            comboBoxDelimiter.FormattingEnabled = true;
            comboBoxDelimiter.Items.AddRange(new object[] { "Кома (,)", "Крапка з комою (;)" });
            comboBoxDelimiter.Location = new Point(280, 81);
            comboBoxDelimiter.Name = "comboBoxDelimiter";
            comboBoxDelimiter.Size = new Size(230, 31);
            comboBoxDelimiter.TabIndex = 5;
            comboBoxDelimiter.SelectedIndexChanged += importOption_Changed;
            // 
            // labelDecimalSeparator
            // 
            labelDecimalSeparator.AutoSize = true;
            labelDecimalSeparator.Font = new Font("Segoe UI", 10F);
            labelDecimalSeparator.Location = new Point(550, 55);
            labelDecimalSeparator.Name = "labelDecimalSeparator";
            labelDecimalSeparator.Size = new Size(199, 23);
            labelDecimalSeparator.TabIndex = 6;
            labelDecimalSeparator.Text = "Десятковий роздільник:";
            // 
            // comboBoxDecimalSeparator
            // 
            comboBoxDecimalSeparator.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxDecimalSeparator.Font = new Font("Segoe UI", 10F);
            comboBoxDecimalSeparator.FormattingEnabled = true;
            comboBoxDecimalSeparator.Items.AddRange(new object[] { "Крапка (.)", "Кома (,)" });
            comboBoxDecimalSeparator.Location = new Point(550, 81);
            comboBoxDecimalSeparator.Name = "comboBoxDecimalSeparator";
            comboBoxDecimalSeparator.Size = new Size(250, 31);
            comboBoxDecimalSeparator.TabIndex = 7;
            comboBoxDecimalSeparator.SelectedIndexChanged += importOption_Changed;
            // 
            // checkBoxHeader
            // 
            checkBoxHeader.AutoSize = true;
            checkBoxHeader.Checked = true;
            checkBoxHeader.CheckState = CheckState.Checked;
            checkBoxHeader.Location = new Point(20, 130);
            checkBoxHeader.Name = "checkBoxHeader";
            checkBoxHeader.Size = new Size(280, 24);
            checkBoxHeader.TabIndex = 8;
            checkBoxHeader.Text = "Перший рядок містить назви стовпців";
            checkBoxHeader.UseVisualStyleBackColor = true;
            checkBoxHeader.CheckedChanged += importOption_Changed;
            // 
            // labelTypesTitle
            // 
            labelTypesTitle.AutoSize = true;
            labelTypesTitle.Font = new Font("Segoe UI", 10F);
            labelTypesTitle.Location = new Point(20, 171);
            labelTypesTitle.Name = "labelTypesTitle";
            labelTypesTitle.Size = new Size(97, 23);
            labelTypesTitle.TabIndex = 9;
            labelTypesTitle.Text = "Типи полів:";
            // 
            // labelTypes
            // 
            labelTypes.AutoSize = false;
            labelTypes.Location = new Point(20, 199);
            labelTypes.Name = "labelTypes";
            labelTypes.Size = new Size(360, 63);
            labelTypes.TabIndex = 10;
            // 
            // dataGridViewPreview
            // 
            dataGridViewPreview.AllowUserToAddRows = false;
            dataGridViewPreview.AllowUserToDeleteRows = false;
            dataGridViewPreview.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewPreview.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewPreview.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPreview.Location = new Point(20, 275);
            dataGridViewPreview.Name = "dataGridViewPreview";
            dataGridViewPreview.ReadOnly = true;
            dataGridViewPreview.RowHeadersVisible = false;
            dataGridViewPreview.RowHeadersWidth = 51;
            dataGridViewPreview.Size = new Size(780, 205);
            dataGridViewPreview.TabIndex = 11;
            // 
            // labelSummary
            // 
            labelSummary.AutoSize = false;
            labelSummary.Location = new Point(20, 492);
            labelSummary.Name = "labelSummary";
            labelSummary.Size = new Size(780, 43);
            labelSummary.TabIndex = 12;
            // 
            // buttonImport
            // 
            buttonImport.Anchor = AnchorStyles.Bottom;
            buttonImport.Location = new Point(286, 548);
            buttonImport.Name = "buttonImport";
            buttonImport.Size = new Size(120, 34);
            buttonImport.TabIndex = 13;
            buttonImport.Text = "Імпортувати";
            buttonImport.UseVisualStyleBackColor = true;
            buttonImport.Click += buttonImport_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Anchor = AnchorStyles.Bottom;
            buttonCancel.DialogResult = DialogResult.Cancel;
            buttonCancel.Location = new Point(420, 548);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(120, 34);
            buttonCancel.TabIndex = 14;
            buttonCancel.Text = "Скасувати";
            buttonCancel.UseVisualStyleBackColor = true;
            // 
            // ImportOptionsForm
            // 
            AcceptButton = buttonImport;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = buttonCancel;
            ClientSize = new Size(820, 599);
            Controls.Add(buttonCancel);
            Controls.Add(buttonImport);
            Controls.Add(labelSummary);
            Controls.Add(dataGridViewPreview);
            Controls.Add(labelTypes);
            Controls.Add(labelTypesTitle);
            Controls.Add(checkBoxHeader);
            Controls.Add(comboBoxDecimalSeparator);
            Controls.Add(labelDecimalSeparator);
            Controls.Add(comboBoxDelimiter);
            Controls.Add(labelDelimiter);
            Controls.Add(comboBoxEncoding);
            Controls.Add(labelEncoding);
            Controls.Add(labelFileName);
            Controls.Add(labelFile);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ImportOptionsForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Параметри імпорту";
            ((System.ComponentModel.ISupportInitialize)dataGridViewPreview).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelFile;
        private Label labelFileName;
        private Label labelEncoding;
        private ComboBox comboBoxEncoding;
        private Label labelDelimiter;
        private ComboBox comboBoxDelimiter;
        private Label labelDecimalSeparator;
        private ComboBox comboBoxDecimalSeparator;
        private CheckBox checkBoxHeader;
        private Label labelTypesTitle;
        private Label labelTypes;
        private DataGridView dataGridViewPreview;
        private Label labelSummary;
        private Button buttonImport;
        private Button buttonCancel;
    }
}
