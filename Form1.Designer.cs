﻿namespace SøgningOgSortering
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
            this.SuspendLayout();
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(12, 11);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(173, 98);
            this.btnGenerate.TabIndex = 0;
            this.btnGenerate.Text = "Generer";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(599, 13);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(188, 95);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lsbInput
            // 
            this.lsbInput.FormattingEnabled = true;
            this.lsbInput.ItemHeight = 16;
            this.lsbInput.Location = new System.Drawing.Point(15, 124);
            this.lsbInput.Name = "lsbInput";
            this.lsbInput.Size = new System.Drawing.Size(169, 308);
            this.lsbInput.TabIndex = 2;
            // 
            // lsbOutput
            // 
            this.lsbOutput.FormattingEnabled = true;
            this.lsbOutput.ItemHeight = 16;
            this.lsbOutput.Location = new System.Drawing.Point(602, 129);
            this.lsbOutput.Name = "lsbOutput";
            this.lsbOutput.Size = new System.Drawing.Size(184, 292);
            this.lsbOutput.TabIndex = 3;
            // 
            // cmbMethod
            // 
            this.cmbMethod.FormattingEnabled = true;
            this.cmbMethod.Items.AddRange(new object[] {
            "Bubble",
            "Merge"});
            this.cmbMethod.Location = new System.Drawing.Point(314, 93);
            this.cmbMethod.Name = "cmbMethod";
            this.cmbMethod.Size = new System.Drawing.Size(162, 24);
            this.cmbMethod.TabIndex = 4;
            this.cmbMethod.Text = "Choose algorithm";
            // 
            // btnSort
            // 
            this.btnSort.Location = new System.Drawing.Point(297, 175);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(204, 86);
            this.btnSort.TabIndex = 5;
            this.btnSort.Text = "Sort";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(294, 285);
            this.lblTime.MinimumSize = new System.Drawing.Size(200, 40);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(200, 40);
            this.lblTime.TabIndex = 6;
            this.lblTime.Text = "Time:";
            // 
            // lblCycles
            // 
            this.lblCycles.AutoSize = true;
            this.lblCycles.Location = new System.Drawing.Point(294, 351);
            this.lblCycles.MinimumSize = new System.Drawing.Size(200, 40);
            this.lblCycles.Name = "lblCycles";
            this.lblCycles.Size = new System.Drawing.Size(200, 40);
            this.lblCycles.TabIndex = 7;
            this.lblCycles.Text = "Cycles: ";
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(191, 33);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(100, 22);
            this.txtInput.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(188, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Numbers:";
            // 
            // txtRange
            // 
            this.txtRange.Location = new System.Drawing.Point(191, 78);
            this.txtRange.Name = "txtRange";
            this.txtRange.Size = new System.Drawing.Size(100, 22);
            this.txtRange.TabIndex = 10;
            // 
            // lblRange
            // 
            this.lblRange.AutoSize = true;
            this.lblRange.Location = new System.Drawing.Point(188, 58);
            this.lblRange.Name = "lblRange";
            this.lblRange.Size = new System.Drawing.Size(54, 17);
            this.lblRange.TabIndex = 11;
            this.lblRange.Text = "Range:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}

