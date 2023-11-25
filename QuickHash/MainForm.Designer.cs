namespace QuickHash
{
    partial class MainForm
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
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textLabel = new System.Windows.Forms.Label();
            this.textTextBox = new System.Windows.Forms.TextBox();
            this.hashLabel = new System.Windows.Forms.Label();
            this.hashTextBox = new System.Windows.Forms.TextBox();
            this.processButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.hashTypeComboBox = new System.Windows.Forms.ComboBox();
            this.hashTypeLabel = new System.Windows.Forms.Label();
            this.littleEndianCheckBox = new System.Windows.Forms.CheckBox();
            this.decimalCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // textLabel
            // 
            this.textLabel.AutoSize = true;
            this.textLabel.Location = new System.Drawing.Point(13, 13);
            this.textLabel.Name = "textLabel";
            this.textLabel.Size = new System.Drawing.Size(37, 13);
            this.textLabel.TabIndex = 0;
            this.textLabel.Text = "String:";
            // 
            // textTextBox
            // 
            this.textTextBox.Location = new System.Drawing.Point(13, 30);
            this.textTextBox.Name = "textTextBox";
            this.textTextBox.Size = new System.Drawing.Size(259, 20);
            this.textTextBox.TabIndex = 1;
            // 
            // hashLabel
            // 
            this.hashLabel.AutoSize = true;
            this.hashLabel.Location = new System.Drawing.Point(13, 97);
            this.hashLabel.Name = "hashLabel";
            this.hashLabel.Size = new System.Drawing.Size(35, 13);
            this.hashLabel.TabIndex = 2;
            this.hashLabel.Text = "Hash:";
            // 
            // hashTextBox
            // 
            this.hashTextBox.Location = new System.Drawing.Point(13, 114);
            this.hashTextBox.Name = "hashTextBox";
            this.hashTextBox.ReadOnly = true;
            this.hashTextBox.Size = new System.Drawing.Size(259, 20);
            this.hashTextBox.TabIndex = 3;
            // 
            // processButton
            // 
            this.processButton.Location = new System.Drawing.Point(13, 141);
            this.processButton.Name = "processButton";
            this.processButton.Size = new System.Drawing.Size(75, 23);
            this.processButton.TabIndex = 4;
            this.processButton.Text = "Process";
            this.processButton.UseVisualStyleBackColor = true;
            this.processButton.Click += new System.EventHandler(this.processButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(134, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Created by BobDoleOwndU";
            // 
            // hashTypeComboBox
            // 
            this.hashTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.hashTypeComboBox.FormattingEnabled = true;
            this.hashTypeComboBox.Items.AddRange(new object[] {
            "PathCode64",
            "PathCode64 with Extension",
            "StrCode64",
            "PathCode32",
            "StrCode32",
            "Extension Bytes",
            "FNV132 (Wwise)",
            "GeoNameHash",});
            this.hashTypeComboBox.Location = new System.Drawing.Point(13, 73);
            this.hashTypeComboBox.Name = "hashTypeComboBox";
            this.hashTypeComboBox.Size = new System.Drawing.Size(121, 21);
            this.hashTypeComboBox.TabIndex = 6;
            // 
            // hashTypeLabel
            // 
            this.hashTypeLabel.AutoSize = true;
            this.hashTypeLabel.Location = new System.Drawing.Point(13, 57);
            this.hashTypeLabel.Name = "hashTypeLabel";
            this.hashTypeLabel.Size = new System.Drawing.Size(62, 13);
            this.hashTypeLabel.TabIndex = 7;
            this.hashTypeLabel.Text = "Hash Type:";
            // 
            // littleEndianCheckBox
            // 
            this.littleEndianCheckBox.AutoSize = true;
            this.littleEndianCheckBox.Location = new System.Drawing.Point(141, 66);
            this.littleEndianCheckBox.Name = "littleEndianCheckBox";
            this.littleEndianCheckBox.Size = new System.Drawing.Size(84, 17);
            this.littleEndianCheckBox.TabIndex = 8;
            this.littleEndianCheckBox.Text = "Little-Endian";
            this.littleEndianCheckBox.UseVisualStyleBackColor = true;
            // 
            // decimalCheckBox
            // 
            this.decimalCheckBox.AutoSize = true;
            this.decimalCheckBox.Location = new System.Drawing.Point(141, 86);
            this.decimalCheckBox.Name = "decimalCheckBox";
            this.decimalCheckBox.Size = new System.Drawing.Size(84, 17);
            this.decimalCheckBox.TabIndex = 9;
            this.decimalCheckBox.Text = "Decimal";
            this.decimalCheckBox.UseVisualStyleBackColor = true;
            this.decimalCheckBox.Click += new System.EventHandler(this.decimalCheckBox_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 183);
            this.Controls.Add(this.littleEndianCheckBox);
            this.Controls.Add(this.decimalCheckBox);
            this.Controls.Add(this.hashTypeLabel);
            this.Controls.Add(this.hashTypeComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.processButton);
            this.Controls.Add(this.hashTextBox);
            this.Controls.Add(this.hashLabel);
            this.Controls.Add(this.textTextBox);
            this.Controls.Add(this.textLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QuickHash";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label textLabel;
        private System.Windows.Forms.TextBox textTextBox;
        private System.Windows.Forms.Label hashLabel;
        private System.Windows.Forms.TextBox hashTextBox;
        private System.Windows.Forms.Button processButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox hashTypeComboBox;
        private System.Windows.Forms.Label hashTypeLabel;
        private System.Windows.Forms.CheckBox littleEndianCheckBox;
        private System.Windows.Forms.CheckBox decimalCheckBox;
    }
}

