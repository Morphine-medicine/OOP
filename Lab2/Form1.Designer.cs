namespace Lab2
{
    partial class XmlAnalizator
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.NameCheckBox = new System.Windows.Forms.CheckBox();
            this.NameComboBox = new System.Windows.Forms.ComboBox();
            this.SexComboBox = new System.Windows.Forms.ComboBox();
            this.SexCheckBox = new System.Windows.Forms.CheckBox();
            this.OfficeComboBox = new System.Windows.Forms.ComboBox();
            this.OfficeCheckBox = new System.Windows.Forms.CheckBox();
            this.ExperienceComboBox = new System.Windows.Forms.ComboBox();
            this.ExperienceCheckBox = new System.Windows.Forms.CheckBox();
            this.PositionComboBox = new System.Windows.Forms.ComboBox();
            this.PositionCheckBox = new System.Windows.Forms.CheckBox();
            this.StatusComboBox = new System.Windows.Forms.ComboBox();
            this.StatusCheckBox = new System.Windows.Forms.CheckBox();
            this.DOM = new System.Windows.Forms.RadioButton();
            this.SAX = new System.Windows.Forms.RadioButton();
            this.LINQtoXML = new System.Windows.Forms.RadioButton();
            this.Filter = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.EmployeesList = new System.Windows.Forms.RichTextBox();
            this.Transform = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NameCheckBox
            // 
            this.NameCheckBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.NameCheckBox.AutoSize = true;
            this.NameCheckBox.Location = new System.Drawing.Point(16, 98);
            this.NameCheckBox.Name = "NameCheckBox";
            this.NameCheckBox.Size = new System.Drawing.Size(131, 21);
            this.NameCheckBox.TabIndex = 0;
            this.NameCheckBox.Text = "Employee name";
            this.NameCheckBox.UseVisualStyleBackColor = true;
            // 
            // NameComboBox
            // 
            this.NameComboBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.NameComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.NameComboBox.FormattingEnabled = true;
            this.NameComboBox.Location = new System.Drawing.Point(176, 98);
            this.NameComboBox.Name = "NameComboBox";
            this.NameComboBox.Size = new System.Drawing.Size(105, 24);
            this.NameComboBox.TabIndex = 1;
            // 
            // SexComboBox
            // 
            this.SexComboBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.SexComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SexComboBox.FormattingEnabled = true;
            this.SexComboBox.Location = new System.Drawing.Point(176, 128);
            this.SexComboBox.Name = "SexComboBox";
            this.SexComboBox.Size = new System.Drawing.Size(105, 24);
            this.SexComboBox.TabIndex = 3;
            // 
            // SexCheckBox
            // 
            this.SexCheckBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.SexCheckBox.AutoSize = true;
            this.SexCheckBox.Location = new System.Drawing.Point(16, 128);
            this.SexCheckBox.Name = "SexCheckBox";
            this.SexCheckBox.Size = new System.Drawing.Size(53, 21);
            this.SexCheckBox.TabIndex = 2;
            this.SexCheckBox.Text = "Sex";
            this.SexCheckBox.UseVisualStyleBackColor = true;
            // 
            // OfficeComboBox
            // 
            this.OfficeComboBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.OfficeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.OfficeComboBox.FormattingEnabled = true;
            this.OfficeComboBox.Location = new System.Drawing.Point(176, 188);
            this.OfficeComboBox.Name = "OfficeComboBox";
            this.OfficeComboBox.Size = new System.Drawing.Size(105, 24);
            this.OfficeComboBox.TabIndex = 7;
            // 
            // OfficeCheckBox
            // 
            this.OfficeCheckBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.OfficeCheckBox.AutoSize = true;
            this.OfficeCheckBox.Location = new System.Drawing.Point(16, 188);
            this.OfficeCheckBox.Name = "OfficeCheckBox";
            this.OfficeCheckBox.Size = new System.Drawing.Size(67, 21);
            this.OfficeCheckBox.TabIndex = 6;
            this.OfficeCheckBox.Text = "Office";
            this.OfficeCheckBox.UseVisualStyleBackColor = true;
            // 
            // ExperienceComboBox
            // 
            this.ExperienceComboBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ExperienceComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ExperienceComboBox.FormattingEnabled = true;
            this.ExperienceComboBox.Location = new System.Drawing.Point(176, 158);
            this.ExperienceComboBox.Name = "ExperienceComboBox";
            this.ExperienceComboBox.Size = new System.Drawing.Size(105, 24);
            this.ExperienceComboBox.TabIndex = 5;
            // 
            // ExperienceCheckBox
            // 
            this.ExperienceCheckBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ExperienceCheckBox.AutoSize = true;
            this.ExperienceCheckBox.Location = new System.Drawing.Point(16, 158);
            this.ExperienceCheckBox.Name = "ExperienceCheckBox";
            this.ExperienceCheckBox.Size = new System.Drawing.Size(154, 21);
            this.ExperienceCheckBox.TabIndex = 4;
            this.ExperienceCheckBox.Text = "Experience in years";
            this.ExperienceCheckBox.UseVisualStyleBackColor = true;
            // 
            // PositionComboBox
            // 
            this.PositionComboBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.PositionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PositionComboBox.FormattingEnabled = true;
            this.PositionComboBox.Location = new System.Drawing.Point(176, 248);
            this.PositionComboBox.Name = "PositionComboBox";
            this.PositionComboBox.Size = new System.Drawing.Size(105, 24);
            this.PositionComboBox.TabIndex = 11;
            // 
            // PositionCheckBox
            // 
            this.PositionCheckBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.PositionCheckBox.AutoSize = true;
            this.PositionCheckBox.Location = new System.Drawing.Point(16, 248);
            this.PositionCheckBox.Name = "PositionCheckBox";
            this.PositionCheckBox.Size = new System.Drawing.Size(80, 21);
            this.PositionCheckBox.TabIndex = 10;
            this.PositionCheckBox.Text = "Position";
            this.PositionCheckBox.UseVisualStyleBackColor = true;
            // 
            // StatusComboBox
            // 
            this.StatusComboBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.StatusComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StatusComboBox.FormattingEnabled = true;
            this.StatusComboBox.Location = new System.Drawing.Point(176, 218);
            this.StatusComboBox.Name = "StatusComboBox";
            this.StatusComboBox.Size = new System.Drawing.Size(105, 24);
            this.StatusComboBox.TabIndex = 9;
            // 
            // StatusCheckBox
            // 
            this.StatusCheckBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.StatusCheckBox.AutoSize = true;
            this.StatusCheckBox.Location = new System.Drawing.Point(16, 218);
            this.StatusCheckBox.Name = "StatusCheckBox";
            this.StatusCheckBox.Size = new System.Drawing.Size(70, 21);
            this.StatusCheckBox.TabIndex = 8;
            this.StatusCheckBox.Text = "Status";
            this.StatusCheckBox.UseVisualStyleBackColor = true;
            // 
            // DOM
            // 
            this.DOM.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.DOM.AutoSize = true;
            this.DOM.Checked = true;
            this.DOM.Location = new System.Drawing.Point(10, 304);
            this.DOM.Name = "DOM";
            this.DOM.Size = new System.Drawing.Size(61, 21);
            this.DOM.TabIndex = 12;
            this.DOM.TabStop = true;
            this.DOM.Text = "DOM";
            this.DOM.UseVisualStyleBackColor = true;
            // 
            // SAX
            // 
            this.SAX.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.SAX.AutoSize = true;
            this.SAX.Location = new System.Drawing.Point(77, 304);
            this.SAX.Name = "SAX";
            this.SAX.Size = new System.Drawing.Size(56, 21);
            this.SAX.TabIndex = 13;
            this.SAX.Text = "SAX";
            this.SAX.UseVisualStyleBackColor = true;
            // 
            // LINQtoXML
            // 
            this.LINQtoXML.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LINQtoXML.AutoSize = true;
            this.LINQtoXML.Location = new System.Drawing.Point(139, 304);
            this.LINQtoXML.Name = "LINQtoXML";
            this.LINQtoXML.Size = new System.Drawing.Size(109, 21);
            this.LINQtoXML.TabIndex = 14;
            this.LINQtoXML.Text = "LINQ to XML";
            this.LINQtoXML.UseVisualStyleBackColor = true;
            // 
            // Filter
            // 
            this.Filter.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Filter.Location = new System.Drawing.Point(16, 356);
            this.Filter.Name = "Filter";
            this.Filter.Size = new System.Drawing.Size(212, 32);
            this.Filter.TabIndex = 15;
            this.Filter.Text = "Filter";
            this.Filter.UseVisualStyleBackColor = true;
            this.Filter.Click += new System.EventHandler(this.Filter_Click);
            // 
            // Clear
            // 
            this.Clear.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Clear.Location = new System.Drawing.Point(125, 395);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(103, 32);
            this.Clear.TabIndex = 16;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // EmployeesList
            // 
            this.EmployeesList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EmployeesList.Location = new System.Drawing.Point(335, 88);
            this.EmployeesList.Name = "EmployeesList";
            this.EmployeesList.Size = new System.Drawing.Size(436, 339);
            this.EmployeesList.TabIndex = 17;
            this.EmployeesList.Text = "";
            // 
            // Transform
            // 
            this.Transform.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Transform.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Transform.Location = new System.Drawing.Point(16, 394);
            this.Transform.Name = "Transform";
            this.Transform.Size = new System.Drawing.Size(103, 32);
            this.Transform.TabIndex = 18;
            this.Transform.Text = "Transform";
            this.Transform.UseVisualStyleBackColor = true;
            this.Transform.Click += new System.EventHandler(this.Transform_Click);
            // 
            // XmlAnalizator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Transform);
            this.Controls.Add(this.EmployeesList);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.Filter);
            this.Controls.Add(this.LINQtoXML);
            this.Controls.Add(this.SAX);
            this.Controls.Add(this.DOM);
            this.Controls.Add(this.PositionComboBox);
            this.Controls.Add(this.PositionCheckBox);
            this.Controls.Add(this.StatusComboBox);
            this.Controls.Add(this.StatusCheckBox);
            this.Controls.Add(this.OfficeComboBox);
            this.Controls.Add(this.OfficeCheckBox);
            this.Controls.Add(this.ExperienceComboBox);
            this.Controls.Add(this.ExperienceCheckBox);
            this.Controls.Add(this.SexComboBox);
            this.Controls.Add(this.SexCheckBox);
            this.Controls.Add(this.NameComboBox);
            this.Controls.Add(this.NameCheckBox);
            this.Name = "XmlAnalizator";
            this.Text = "XmlAnalizator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox NameCheckBox;
        private System.Windows.Forms.ComboBox NameComboBox;
        private System.Windows.Forms.ComboBox SexComboBox;
        private System.Windows.Forms.CheckBox SexCheckBox;
        private System.Windows.Forms.ComboBox OfficeComboBox;
        private System.Windows.Forms.CheckBox OfficeCheckBox;
        private System.Windows.Forms.ComboBox ExperienceComboBox;
        private System.Windows.Forms.CheckBox ExperienceCheckBox;
        private System.Windows.Forms.ComboBox PositionComboBox;
        private System.Windows.Forms.CheckBox PositionCheckBox;
        private System.Windows.Forms.ComboBox StatusComboBox;
        private System.Windows.Forms.CheckBox StatusCheckBox;
        private System.Windows.Forms.RadioButton DOM;
        private System.Windows.Forms.RadioButton SAX;
        private System.Windows.Forms.RadioButton LINQtoXML;
        private System.Windows.Forms.Button Filter;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.RichTextBox EmployeesList;
        private System.Windows.Forms.Button Transform;
    }
}

