using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace OOP1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.TextBox = new System.Windows.Forms.TextBox();
            this.Data = new System.Windows.Forms.DataGridView();
            this.Current = new System.Windows.Forms.TextBox();
            this.Reset = new System.Windows.Forms.Button();
            this.DeleteRow = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.DeleteRowTextBox = new System.Windows.Forms.TextBox();
            this.DeleteColumnTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DeleteColumn = new System.Windows.Forms.Button();
            this.AddRowButton = new System.Windows.Forms.Button();
            this.AddColumnButton = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.Save = new System.Windows.Forms.ToolStripButton();
            this.saveFileDialog3 = new System.Windows.Forms.SaveFileDialog();
            this.Open = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.Data)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TextBox
            // 
            this.TextBox.Enabled = false;
            this.TextBox.Location = new System.Drawing.Point(71, 48);
            this.TextBox.Name = "TextBox";
            this.TextBox.Size = new System.Drawing.Size(166, 22);
            this.TextBox.TabIndex = 1;
            this.TextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            // 
            // Data
            // 
            this.Data.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Data.Location = new System.Drawing.Point(0, 110);
            this.Data.Name = "Data";
            this.Data.RowHeadersWidth = 51;
            this.Data.RowTemplate.Height = 24;
            this.Data.Size = new System.Drawing.Size(798, 336);
            this.Data.TabIndex = 0;
            this.Data.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Data_CellClick);
            // 
            // Current
            // 
            this.Current.Enabled = false;
            this.Current.Location = new System.Drawing.Point(16, 47);
            this.Current.Name = "Current";
            this.Current.Size = new System.Drawing.Size(49, 22);
            this.Current.TabIndex = 3;
            // 
            // Reset
            // 
            this.Reset.Location = new System.Drawing.Point(16, 12);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(53, 29);
            this.Reset.TabIndex = 4;
            this.Reset.Text = "Reset";
            this.Reset.UseVisualStyleBackColor = true;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // DeleteRow
            // 
            this.DeleteRow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DeleteRow.Location = new System.Drawing.Point(338, 12);
            this.DeleteRow.Name = "DeleteRow";
            this.DeleteRow.Size = new System.Drawing.Size(60, 29);
            this.DeleteRow.TabIndex = 5;
            this.DeleteRow.Text = "Delete";
            this.DeleteRow.UseVisualStyleBackColor = true;
            this.DeleteRow.Click += new System.EventHandler(this.DeleteRow_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(295, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Row:";
            // 
            // DeleteRowTextBox
            // 
            this.DeleteRowTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DeleteRowTextBox.Location = new System.Drawing.Point(338, 47);
            this.DeleteRowTextBox.Name = "DeleteRowTextBox";
            this.DeleteRowTextBox.Size = new System.Drawing.Size(60, 22);
            this.DeleteRowTextBox.TabIndex = 7;
            // 
            // DeleteColumnTextBox
            // 
            this.DeleteColumnTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DeleteColumnTextBox.Location = new System.Drawing.Point(471, 47);
            this.DeleteColumnTextBox.Name = "DeleteColumnTextBox";
            this.DeleteColumnTextBox.Size = new System.Drawing.Size(60, 22);
            this.DeleteColumnTextBox.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(410, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Column";
            // 
            // DeleteColumn
            // 
            this.DeleteColumn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DeleteColumn.Location = new System.Drawing.Point(471, 12);
            this.DeleteColumn.Name = "DeleteColumn";
            this.DeleteColumn.Size = new System.Drawing.Size(60, 29);
            this.DeleteColumn.TabIndex = 8;
            this.DeleteColumn.Text = "Delete";
            this.DeleteColumn.UseVisualStyleBackColor = true;
            this.DeleteColumn.Click += new System.EventHandler(this.DeleteColumn_Click);
            // 
            // AddRowButton
            // 
            this.AddRowButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddRowButton.Location = new System.Drawing.Point(338, 75);
            this.AddRowButton.Name = "AddRowButton";
            this.AddRowButton.Size = new System.Drawing.Size(60, 23);
            this.AddRowButton.TabIndex = 11;
            this.AddRowButton.Text = "Add";
            this.AddRowButton.UseVisualStyleBackColor = true;
            this.AddRowButton.Click += new System.EventHandler(this.AddRowButton_Click);
            // 
            // AddColumnButton
            // 
            this.AddColumnButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddColumnButton.Location = new System.Drawing.Point(471, 75);
            this.AddColumnButton.Name = "AddColumnButton";
            this.AddColumnButton.Size = new System.Drawing.Size(60, 23);
            this.AddColumnButton.TabIndex = 12;
            this.AddColumnButton.Text = "Add";
            this.AddColumnButton.UseVisualStyleBackColor = true;
            this.AddColumnButton.Click += new System.EventHandler(this.AddColumnButton_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Save,
            this.Open});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 27);
            this.toolStrip1.TabIndex = 13;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // Save
            // 
            this.Save.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Save.Image = ((System.Drawing.Image)(resources.GetObject("Save.Image")));
            this.Save.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(29, 24);
            this.Save.Text = "Save";
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // saveFileDialog3
            // 
            this.saveFileDialog3.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog3_FileOk);
            // 
            // Open
            // 
            this.Open.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Open.Image = ((System.Drawing.Image)(resources.GetObject("Open.Image")));
            this.Open.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Open.Name = "Open";
            this.Open.Size = new System.Drawing.Size(29, 24);
            this.Open.Text = "toolStripButton1";
            this.Open.Click += new System.EventHandler(this.Open_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.AddColumnButton);
            this.Controls.Add(this.AddRowButton);
            this.Controls.Add(this.DeleteColumnTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DeleteColumn);
            this.Controls.Add(this.DeleteRowTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DeleteRow);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.Current);
            this.Controls.Add(this.TextBox);
            this.Controls.Add(this.Data);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Data)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        
        #endregion
        private System.Windows.Forms.TextBox TextBox;

        Dictionary<string, Cell> Choosed;
        public DataGridView Data;
        private TextBox Current;
        private Button Reset;
        private Button DeleteRow;
        private Label label1;
        private TextBox DeleteRowTextBox;
        private TextBox DeleteColumnTextBox;
        private Label label2;
        private Button DeleteColumn;
        private Button AddRowButton;
        private Button AddColumnButton;
        private ToolStrip toolStrip1;
        private ToolStripButton Save;
        private SaveFileDialog saveFileDialog3;
        private ToolStripButton Open;
    }
}

