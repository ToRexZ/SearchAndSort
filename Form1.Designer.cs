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
            this.cmbMethod.Location = new System.Drawing.Point(314, 93);
            this.cmbMethod.Name = "cmbMethod";
            this.cmbMethod.Size = new System.Drawing.Size(162, 24);
            this.cmbMethod.TabIndex = 4;
            // 
            // btnSort
            // 
            this.btnSort.Location = new System.Drawing.Point(297, 175);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(204, 86);
            this.btnSort.TabIndex = 5;
            this.btnSort.Text = "Sort";
            this.btnSort.UseVisualStyleBackColor = true;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(294, 285);
            this.lblTime.MinimumSize = new System.Drawing.Size(200, 40);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(200, 40);
            this.lblTime.TabIndex = 6;
            this.lblTime.Text = "label1";
            // 
            // lblCycles
            // 
            this.lblCycles.AutoSize = true;
            this.lblCycles.Location = new System.Drawing.Point(294, 351);
            this.lblCycles.MinimumSize = new System.Drawing.Size(200, 40);
            this.lblCycles.Name = "lblCycles";
            this.lblCycles.Size = new System.Drawing.Size(200, 40);
            this.lblCycles.TabIndex = 7;
            this.lblCycles.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}

