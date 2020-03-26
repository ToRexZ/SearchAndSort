namespace SøgningOgSortering
{
    partial class Form1
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
            this.btnGenerate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lsbInput = new System.Windows.Forms.ListBox();
            this.lsbOutput = new System.Windows.Forms.ListBox();
            this.cmbMethod = new System.Windows.Forms.ComboBox();
            this.btnSort = new System.Windows.Forms.Button();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblCycles = new System.Windows.Forms.Label();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRange = new System.Windows.Forms.TextBox();
            this.lblRange = new System.Windows.Forms.Label();
            this.btnInput = new System.Windows.Forms.Button();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.FirstIndex = new System.Windows.Forms.Label();
            this.lblFirst = new System.Windows.Forms.Label();
            this.LastIndex = new System.Windows.Forms.Label();
            this.lblLast = new System.Windows.Forms.Label();
            this.Count = new System.Windows.Forms.Label();
            this.lblCount = new System.Windows.Forms.Label();
            this.BtnOutput = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(9, 9);
            this.btnGenerate.Margin = new System.Windows.Forms.Padding(2);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(130, 80);
            this.btnGenerate.TabIndex = 0;
            this.btnGenerate.Text = "Generer";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(449, 11);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(141, 77);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lsbInput
            // 
            this.lsbInput.FormattingEnabled = true;
            this.lsbInput.Location = new System.Drawing.Point(11, 101);
            this.lsbInput.Margin = new System.Windows.Forms.Padding(2);
            this.lsbInput.Name = "lsbInput";
            this.lsbInput.Size = new System.Drawing.Size(128, 186);
            this.lsbInput.TabIndex = 2;
            // 
            // lsbOutput
            // 
            this.lsbOutput.FormattingEnabled = true;
            this.lsbOutput.Location = new System.Drawing.Point(452, 105);
            this.lsbOutput.Margin = new System.Windows.Forms.Padding(2);
            this.lsbOutput.Name = "lsbOutput";
            this.lsbOutput.Size = new System.Drawing.Size(139, 186);
            this.lsbOutput.TabIndex = 3;
            // 
            // cmbMethod
            // 
            this.cmbMethod.FormattingEnabled = true;
            this.cmbMethod.Items.AddRange(new object[] {
            "Bubble",
            "Merge",
            "Quick"});
            this.cmbMethod.Location = new System.Drawing.Point(236, 76);
            this.cmbMethod.Margin = new System.Windows.Forms.Padding(2);
            this.cmbMethod.Name = "cmbMethod";
            this.cmbMethod.Size = new System.Drawing.Size(122, 21);
            this.cmbMethod.TabIndex = 4;
            this.cmbMethod.Text = "Choose algorithm";
            // 
            // btnSort
            // 
            this.btnSort.Location = new System.Drawing.Point(223, 142);
            this.btnSort.Margin = new System.Windows.Forms.Padding(2);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(153, 70);
            this.btnSort.TabIndex = 5;
            this.btnSort.Text = "Sort";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(220, 232);
            this.lblTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTime.MinimumSize = new System.Drawing.Size(150, 32);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(150, 32);
            this.lblTime.TabIndex = 6;
            this.lblTime.Text = "Time:";
            // 
            // lblCycles
            // 
            this.lblCycles.AutoSize = true;
            this.lblCycles.Location = new System.Drawing.Point(220, 285);
            this.lblCycles.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCycles.MinimumSize = new System.Drawing.Size(150, 32);
            this.lblCycles.Name = "lblCycles";
            this.lblCycles.Size = new System.Drawing.Size(150, 32);
            this.lblCycles.TabIndex = 7;
            this.lblCycles.Text = "Cycles: ";
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(143, 27);
            this.txtInput.Margin = new System.Windows.Forms.Padding(2);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(76, 20);
            this.txtInput.TabIndex = 8;
            this.txtInput.Text = "100";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(141, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Numbers:";
            // 
            // txtRange
            // 
            this.txtRange.Location = new System.Drawing.Point(143, 63);
            this.txtRange.Margin = new System.Windows.Forms.Padding(2);
            this.txtRange.Name = "txtRange";
            this.txtRange.Size = new System.Drawing.Size(76, 20);
            this.txtRange.TabIndex = 10;
            this.txtRange.Text = "0-100";
            // 
            // lblRange
            // 
            this.lblRange.AutoSize = true;
            this.lblRange.Location = new System.Drawing.Point(141, 47);
            this.lblRange.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRange.Name = "lblRange";
            this.lblRange.Size = new System.Drawing.Size(42, 13);
            this.lblRange.TabIndex = 11;
            this.lblRange.Text = "Range:";
            // 
            // btnInput
            // 
            this.btnInput.Location = new System.Drawing.Point(11, 296);
            this.btnInput.Name = "btnInput";
            this.btnInput.Size = new System.Drawing.Size(127, 60);
            this.btnInput.TabIndex = 12;
            this.btnInput.Text = "Input file";
            this.btnInput.UseVisualStyleBackColor = true;
            this.btnInput.Click += new System.EventHandler(this.btnInput_Click);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(608, 9);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(97, 13);
            this.lblSearch.TabIndex = 13;
            this.lblSearch.Text = "Search for number:";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(611, 25);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(86, 20);
            this.txtSearch.TabIndex = 14;
            this.txtSearch.TextChanged += new System.EventHandler(this.TxtSearch_TextChanged);
            // 
            // FirstIndex
            // 
            this.FirstIndex.AutoSize = true;
            this.FirstIndex.Location = new System.Drawing.Point(608, 49);
            this.FirstIndex.Name = "FirstIndex";
            this.FirstIndex.Size = new System.Drawing.Size(58, 13);
            this.FirstIndex.TabIndex = 15;
            this.FirstIndex.Text = "First Index:";
            // 
            // lblFirst
            // 
            this.lblFirst.AutoSize = true;
            this.lblFirst.Location = new System.Drawing.Point(672, 49);
            this.lblFirst.Name = "lblFirst";
            this.lblFirst.Size = new System.Drawing.Size(10, 13);
            this.lblFirst.TabIndex = 16;
            this.lblFirst.Text = "-";
            // 
            // LastIndex
            // 
            this.LastIndex.AutoSize = true;
            this.LastIndex.Location = new System.Drawing.Point(608, 68);
            this.LastIndex.Name = "LastIndex";
            this.LastIndex.Size = new System.Drawing.Size(59, 13);
            this.LastIndex.TabIndex = 17;
            this.LastIndex.Text = "Last Index:";
            // 
            // lblLast
            // 
            this.lblLast.AutoSize = true;
            this.lblLast.Location = new System.Drawing.Point(672, 68);
            this.lblLast.Name = "lblLast";
            this.lblLast.Size = new System.Drawing.Size(10, 13);
            this.lblLast.TabIndex = 18;
            this.lblLast.Text = "-";
            // 
            // Count
            // 
            this.Count.AutoSize = true;
            this.Count.Location = new System.Drawing.Point(608, 86);
            this.Count.Name = "Count";
            this.Count.Size = new System.Drawing.Size(38, 13);
            this.Count.TabIndex = 19;
            this.Count.Text = "Count:";
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Location = new System.Drawing.Point(672, 86);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(10, 13);
            this.lblCount.TabIndex = 20;
            this.lblCount.Text = "-";
            // 
            // BtnOutput
            // 
            this.BtnOutput.Location = new System.Drawing.Point(452, 297);
            this.BtnOutput.Name = "BtnOutput";
            this.BtnOutput.Size = new System.Drawing.Size(138, 59);
            this.BtnOutput.TabIndex = 21;
            this.BtnOutput.Text = "Output to file";
            this.BtnOutput.Click += new System.EventHandler(this.BtnOutput_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 366);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.Count);
            this.Controls.Add(this.lblLast);
            this.Controls.Add(this.LastIndex);
            this.Controls.Add(this.lblFirst);
            this.Controls.Add(this.FirstIndex);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.BtnOutput);
            this.Controls.Add(this.btnInput);
            this.Controls.Add(this.lblRange);
            this.Controls.Add(this.txtRange);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.lblCycles);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.cmbMethod);
            this.Controls.Add(this.lsbOutput);
            this.Controls.Add(this.lsbInput);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnGenerate);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ListBox lsbInput;
        private System.Windows.Forms.ListBox lsbOutput;
        private System.Windows.Forms.ComboBox cmbMethod;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblCycles;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRange;
        private System.Windows.Forms.Label lblRange;
        private System.Windows.Forms.Button btnInput;
        private System.Windows.Forms.Button BtnOutput;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label FirstIndex;
        private System.Windows.Forms.Label lblFirst;
        private System.Windows.Forms.Label LastIndex;
        private System.Windows.Forms.Label lblLast;
        private System.Windows.Forms.Label Count;
        private System.Windows.Forms.Label lblCount;
    }
}

