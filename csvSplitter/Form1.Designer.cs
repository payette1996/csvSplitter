namespace csvSplitter
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            filePathTextBox = new TextBox();
            fileBtn = new Button();
            headerCheckBox = new CheckBox();
            label2 = new Label();
            splitBtn = new Button();
            groupBox1 = new GroupBox();
            rowNumeric = new NumericUpDown();
            colNumeric = new NumericUpDown();
            label5 = new Label();
            fileNameTextBox = new TextBox();
            label4 = new Label();
            label3 = new Label();
            outputLocationTextBox = new TextBox();
            label6 = new Label();
            groupBox2 = new GroupBox();
            filesGeneratedNumeric = new NumericUpDown();
            maxRowsNumeric = new NumericUpDown();
            label7 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)rowNumeric).BeginInit();
            ((System.ComponentModel.ISupportInitialize)colNumeric).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)filesGeneratedNumeric).BeginInit();
            ((System.ComponentModel.ISupportInitialize)maxRowsNumeric).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 0;
            label1.Text = "File Path";
            // 
            // filePathTextBox
            // 
            filePathTextBox.Location = new Point(12, 32);
            filePathTextBox.Name = "filePathTextBox";
            filePathTextBox.Size = new Size(465, 27);
            filePathTextBox.TabIndex = 1;
            // 
            // fileBtn
            // 
            fileBtn.Location = new Point(489, 30);
            fileBtn.Name = "fileBtn";
            fileBtn.Size = new Size(94, 29);
            fileBtn.TabIndex = 2;
            fileBtn.Text = "Browse";
            fileBtn.UseVisualStyleBackColor = true;
            fileBtn.Click += fileBtn_Click;
            // 
            // headerCheckBox
            // 
            headerCheckBox.AutoSize = true;
            headerCheckBox.Checked = true;
            headerCheckBox.CheckState = CheckState.Checked;
            headerCheckBox.Location = new Point(12, 65);
            headerCheckBox.Name = "headerCheckBox";
            headerCheckBox.Size = new Size(348, 24);
            headerCheckBox.TabIndex = 3;
            headerCheckBox.Text = "Maintain the first row as the header for each file";
            headerCheckBox.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 62);
            label2.Name = "label2";
            label2.Size = new Size(161, 20);
            label2.TabIndex = 4;
            label2.Text = "Maximum rows per file";
            // 
            // splitBtn
            // 
            splitBtn.Location = new Point(489, 104);
            splitBtn.Name = "splitBtn";
            splitBtn.Size = new Size(94, 268);
            splitBtn.TabIndex = 6;
            splitBtn.Text = "Split";
            splitBtn.UseVisualStyleBackColor = true;
            splitBtn.Click += splitBtn_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rowNumeric);
            groupBox1.Controls.Add(colNumeric);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(fileNameTextBox);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(12, 95);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(471, 132);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Selected File Information";
            // 
            // rowNumeric
            // 
            rowNumeric.Location = new Point(88, 95);
            rowNumeric.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            rowNumeric.Name = "rowNumeric";
            rowNumeric.ReadOnly = true;
            rowNumeric.Size = new Size(377, 27);
            rowNumeric.TabIndex = 6;
            // 
            // colNumeric
            // 
            colNumeric.Location = new Point(88, 62);
            colNumeric.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            colNumeric.Name = "colNumeric";
            colNumeric.ReadOnly = true;
            colNumeric.Size = new Size(377, 27);
            colNumeric.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 62);
            label5.Name = "label5";
            label5.Size = new Size(66, 20);
            label5.TabIndex = 4;
            label5.Text = "Columns";
            // 
            // fileNameTextBox
            // 
            fileNameTextBox.Location = new Point(88, 26);
            fileNameTextBox.Name = "fileNameTextBox";
            fileNameTextBox.ReadOnly = true;
            fileNameTextBox.Size = new Size(377, 27);
            fileNameTextBox.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 95);
            label4.Name = "label4";
            label4.Size = new Size(44, 20);
            label4.TabIndex = 1;
            label4.Text = "Rows";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 29);
            label3.Name = "label3";
            label3.Size = new Size(76, 20);
            label3.TabIndex = 0;
            label3.Text = "File Name";
            // 
            // outputLocationTextBox
            // 
            outputLocationTextBox.Location = new Point(183, 26);
            outputLocationTextBox.Name = "outputLocationTextBox";
            outputLocationTextBox.Size = new Size(282, 27);
            outputLocationTextBox.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(10, 29);
            label6.Name = "label6";
            label6.Size = new Size(113, 20);
            label6.TabIndex = 9;
            label6.Text = "Output location";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(filesGeneratedNumeric);
            groupBox2.Controls.Add(maxRowsNumeric);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(outputLocationTextBox);
            groupBox2.Location = new Point(12, 233);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(471, 139);
            groupBox2.TabIndex = 10;
            groupBox2.TabStop = false;
            groupBox2.Text = "Output Information";
            // 
            // filesGeneratedNumeric
            // 
            filesGeneratedNumeric.Location = new Point(183, 92);
            filesGeneratedNumeric.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            filesGeneratedNumeric.Name = "filesGeneratedNumeric";
            filesGeneratedNumeric.ReadOnly = true;
            filesGeneratedNumeric.Size = new Size(282, 27);
            filesGeneratedNumeric.TabIndex = 13;
            // 
            // maxRowsNumeric
            // 
            maxRowsNumeric.Location = new Point(183, 59);
            maxRowsNumeric.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            maxRowsNumeric.Name = "maxRowsNumeric";
            maxRowsNumeric.Size = new Size(282, 27);
            maxRowsNumeric.TabIndex = 12;
            maxRowsNumeric.Value = new decimal(new int[] { 1000, 0, 0, 0 });
            maxRowsNumeric.ValueChanged += maxRowsNumeric_ValueChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(8, 95);
            label7.Name = "label7";
            label7.Size = new Size(149, 20);
            label7.TabIndex = 10;
            label7.Text = "Files to be generated";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(596, 381);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(splitBtn);
            Controls.Add(headerCheckBox);
            Controls.Add(fileBtn);
            Controls.Add(filePathTextBox);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "csvSplitter";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)rowNumeric).EndInit();
            ((System.ComponentModel.ISupportInitialize)colNumeric).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)filesGeneratedNumeric).EndInit();
            ((System.ComponentModel.ISupportInitialize)maxRowsNumeric).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox filePathTextBox;
        private Button fileBtn;
        private CheckBox headerCheckBox;
        private Label label2;
        private Button splitBtn;
        private GroupBox groupBox1;
        private Label label3;
        private TextBox fileNameTextBox;
        private Label label4;
        private Label label5;
        private TextBox outputLocationTextBox;
        private Label label6;
        private GroupBox groupBox2;
        private Label label7;
        private NumericUpDown maxRowsNumeric;
        private NumericUpDown rowNumeric;
        private NumericUpDown colNumeric;
        private NumericUpDown filesGeneratedNumeric;
    }
}