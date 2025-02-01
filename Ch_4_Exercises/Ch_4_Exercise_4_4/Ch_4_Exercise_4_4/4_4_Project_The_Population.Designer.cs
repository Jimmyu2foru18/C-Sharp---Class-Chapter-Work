namespace Ch_4_Exercise_4_4
{
    partial class fmProjectThePopulation
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
            this.btnCalculate = new System.Windows.Forms.Button();
            this.txtCurrentPopulation = new System.Windows.Forms.TextBox();
            this.txtNumberOfYears = new System.Windows.Forms.TextBox();
            this.txtGrowthRate = new System.Windows.Forms.TextBox();
            this.lstResults = new System.Windows.Forms.ListBox();
            this.lblCurrentPopulation = new System.Windows.Forms.Label();
            this.lblNumberOfYears = new System.Windows.Forms.Label();
            this.lblGrowthRate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(12, 129);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(104, 43);
            this.btnCalculate.TabIndex = 0;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // txtCurrentPopulation
            // 
            this.txtCurrentPopulation.Location = new System.Drawing.Point(130, 36);
            this.txtCurrentPopulation.Name = "txtCurrentPopulation";
            this.txtCurrentPopulation.Size = new System.Drawing.Size(93, 20);
            this.txtCurrentPopulation.TabIndex = 1;
            // 
            // txtNumberOfYears
            // 
            this.txtNumberOfYears.Location = new System.Drawing.Point(130, 62);
            this.txtNumberOfYears.Name = "txtNumberOfYears";
            this.txtNumberOfYears.Size = new System.Drawing.Size(93, 20);
            this.txtNumberOfYears.TabIndex = 2;
            // 
            // txtGrowthRate
            // 
            this.txtGrowthRate.Location = new System.Drawing.Point(130, 88);
            this.txtGrowthRate.Name = "txtGrowthRate";
            this.txtGrowthRate.Size = new System.Drawing.Size(93, 20);
            this.txtGrowthRate.TabIndex = 3;
            // 
            // lstResults
            // 
            this.lstResults.FormattingEnabled = true;
            this.lstResults.Location = new System.Drawing.Point(127, 131);
            this.lstResults.Name = "lstResults";
            this.lstResults.Size = new System.Drawing.Size(294, 173);
            this.lstResults.TabIndex = 4;
            // 
            // lblCurrentPopulation
            // 
            this.lblCurrentPopulation.AutoSize = true;
            this.lblCurrentPopulation.Location = new System.Drawing.Point(28, 43);
            this.lblCurrentPopulation.Name = "lblCurrentPopulation";
            this.lblCurrentPopulation.Size = new System.Drawing.Size(97, 13);
            this.lblCurrentPopulation.TabIndex = 5;
            this.lblCurrentPopulation.Text = "Current Population:";
            // 
            // lblNumberOfYears
            // 
            this.lblNumberOfYears.AutoSize = true;
            this.lblNumberOfYears.Location = new System.Drawing.Point(28, 69);
            this.lblNumberOfYears.Name = "lblNumberOfYears";
            this.lblNumberOfYears.Size = new System.Drawing.Size(91, 13);
            this.lblNumberOfYears.TabIndex = 6;
            this.lblNumberOfYears.Text = "Number Of Years:";
            // 
            // lblGrowthRate
            // 
            this.lblGrowthRate.AutoSize = true;
            this.lblGrowthRate.Location = new System.Drawing.Point(28, 95);
            this.lblGrowthRate.Name = "lblGrowthRate";
            this.lblGrowthRate.Size = new System.Drawing.Size(70, 13);
            this.lblGrowthRate.TabIndex = 7;
            this.lblGrowthRate.Text = "Growth Rate:";
            // 
            // fmProjectThePopulation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 328);
            this.Controls.Add(this.lblGrowthRate);
            this.Controls.Add(this.lblNumberOfYears);
            this.Controls.Add(this.lblCurrentPopulation);
            this.Controls.Add(this.lstResults);
            this.Controls.Add(this.txtGrowthRate);
            this.Controls.Add(this.txtNumberOfYears);
            this.Controls.Add(this.txtCurrentPopulation);
            this.Controls.Add(this.btnCalculate);
            this.Name = "fmProjectThePopulation";
            this.Text = "ProjectThePopulation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox txtCurrentPopulation;
        private System.Windows.Forms.TextBox txtNumberOfYears;
        private System.Windows.Forms.TextBox txtGrowthRate;
        private System.Windows.Forms.ListBox lstResults;
        private System.Windows.Forms.Label lblCurrentPopulation;
        private System.Windows.Forms.Label lblNumberOfYears;
        private System.Windows.Forms.Label lblGrowthRate;
    }
}

