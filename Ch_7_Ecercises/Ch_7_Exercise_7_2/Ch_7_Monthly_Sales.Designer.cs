namespace Ch_7_Exercise_7_2
{
    partial class Ch_7_Monthly_Sales
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
            this.btnTopMonths = new System.Windows.Forms.Button();
            this.lstResults = new System.Windows.Forms.ListBox();
            this.btnDisplayUnitsSold = new System.Windows.Forms.Button();
            this.lblUnitsSold = new System.Windows.Forms.Label();
            this.txtMonthName = new System.Windows.Forms.TextBox();
            this.lblMonth = new System.Windows.Forms.Label();
            this.btnBottomMonths = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTopMonths
            // 
            this.btnTopMonths.Location = new System.Drawing.Point(168, 94);
            this.btnTopMonths.Name = "btnTopMonths";
            this.btnTopMonths.Size = new System.Drawing.Size(110, 28);
            this.btnTopMonths.TabIndex = 0;
            this.btnTopMonths.Text = "Top Months";
            this.btnTopMonths.UseVisualStyleBackColor = true;
            this.btnTopMonths.Click += new System.EventHandler(this.btnTopMonths_Click);
            // 
            // lstResults
            // 
            this.lstResults.FormattingEnabled = true;
            this.lstResults.Location = new System.Drawing.Point(15, 140);
            this.lstResults.Name = "lstResults";
            this.lstResults.Size = new System.Drawing.Size(263, 108);
            this.lstResults.TabIndex = 1;
            // 
            // btnDisplayUnitsSold
            // 
            this.btnDisplayUnitsSold.Location = new System.Drawing.Point(168, 12);
            this.btnDisplayUnitsSold.Name = "btnDisplayUnitsSold";
            this.btnDisplayUnitsSold.Size = new System.Drawing.Size(110, 52);
            this.btnDisplayUnitsSold.TabIndex = 2;
            this.btnDisplayUnitsSold.Text = "Display Units Sold";
            this.btnDisplayUnitsSold.UseVisualStyleBackColor = true;
            this.btnDisplayUnitsSold.Click += new System.EventHandler(this.btnDisplayUnitsSold_Click);
            // 
            // lblUnitsSold
            // 
            this.lblUnitsSold.AutoSize = true;
            this.lblUnitsSold.Location = new System.Drawing.Point(49, 51);
            this.lblUnitsSold.Name = "lblUnitsSold";
            this.lblUnitsSold.Size = new System.Drawing.Size(58, 13);
            this.lblUnitsSold.TabIndex = 3;
            this.lblUnitsSold.Text = "Units Sold:";
            // 
            // txtMonthName
            // 
            this.txtMonthName.Location = new System.Drawing.Point(52, 13);
            this.txtMonthName.Name = "txtMonthName";
            this.txtMonthName.Size = new System.Drawing.Size(110, 20);
            this.txtMonthName.TabIndex = 4;
            // 
            // lblMonth
            // 
            this.lblMonth.AutoSize = true;
            this.lblMonth.Location = new System.Drawing.Point(9, 20);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(37, 13);
            this.lblMonth.TabIndex = 5;
            this.lblMonth.Text = "Month";
            // 
            // btnBottomMonths
            // 
            this.btnBottomMonths.Location = new System.Drawing.Point(12, 94);
            this.btnBottomMonths.Name = "btnBottomMonths";
            this.btnBottomMonths.Size = new System.Drawing.Size(110, 28);
            this.btnBottomMonths.TabIndex = 6;
            this.btnBottomMonths.Text = "Bottom Months";
            this.btnBottomMonths.UseVisualStyleBackColor = true;
            this.btnBottomMonths.Click += new System.EventHandler(this.btnBottomMonths_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 275);
            this.Controls.Add(this.btnBottomMonths);
            this.Controls.Add(this.lblMonth);
            this.Controls.Add(this.txtMonthName);
            this.Controls.Add(this.lblUnitsSold);
            this.Controls.Add(this.btnDisplayUnitsSold);
            this.Controls.Add(this.lstResults);
            this.Controls.Add(this.btnTopMonths);
            this.Name = "Form1";
            this.Text = "MonthlySales";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTopMonths;
        private System.Windows.Forms.ListBox lstResults;
        private System.Windows.Forms.Button btnDisplayUnitsSold;
        private System.Windows.Forms.Label lblUnitsSold;
        private System.Windows.Forms.TextBox txtMonthName;
        private System.Windows.Forms.Label lblMonth;
        private System.Windows.Forms.Button btnBottomMonths;
    }
}

