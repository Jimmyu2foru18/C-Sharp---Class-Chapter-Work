namespace Ch_4_Exercise_4_2
{
    partial class fmCityPopulation
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
            this.txtCurrentPopulation = new System.Windows.Forms.TextBox();
            this.txtTargetPopulation = new System.Windows.Forms.TextBox();
            this.txtGrowthRate = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lstResults = new System.Windows.Forms.ListBox();
            this.lblCurrentPopulation = new System.Windows.Forms.Label();
            this.lblTargetPopulation = new System.Windows.Forms.Label();
            this.lblGrowthRate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtCurrentPopulation
            // 
            this.txtCurrentPopulation.Location = new System.Drawing.Point(209, 26);
            this.txtCurrentPopulation.Name = "txtCurrentPopulation";
            this.txtCurrentPopulation.Size = new System.Drawing.Size(91, 20);
            this.txtCurrentPopulation.TabIndex = 0;
            // 
            // txtTargetPopulation
            // 
            this.txtTargetPopulation.Location = new System.Drawing.Point(209, 52);
            this.txtTargetPopulation.Name = "txtTargetPopulation";
            this.txtTargetPopulation.Size = new System.Drawing.Size(91, 20);
            this.txtTargetPopulation.TabIndex = 1;
            // 
            // txtGrowthRate
            // 
            this.txtGrowthRate.Location = new System.Drawing.Point(209, 78);
            this.txtGrowthRate.Name = "txtGrowthRate";
            this.txtGrowthRate.Size = new System.Drawing.Size(91, 20);
            this.txtGrowthRate.TabIndex = 2;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(12, 118);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(87, 28);
            this.btnCalculate.TabIndex = 3;
            this.btnCalculate.Text = "Caculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lstResults
            // 
            this.lstResults.FormattingEnabled = true;
            this.lstResults.Location = new System.Drawing.Point(142, 118);
            this.lstResults.Name = "lstResults";
            this.lstResults.Size = new System.Drawing.Size(317, 108);
            this.lstResults.TabIndex = 4;
            // 
            // lblCurrentPopulation
            // 
            this.lblCurrentPopulation.AutoSize = true;
            this.lblCurrentPopulation.Location = new System.Drawing.Point(85, 33);
            this.lblCurrentPopulation.Name = "lblCurrentPopulation";
            this.lblCurrentPopulation.Size = new System.Drawing.Size(97, 13);
            this.lblCurrentPopulation.TabIndex = 5;
            this.lblCurrentPopulation.Text = "Current Population:";
            // 
            // lblTargetPopulation
            // 
            this.lblTargetPopulation.AutoSize = true;
            this.lblTargetPopulation.Location = new System.Drawing.Point(88, 59);
            this.lblTargetPopulation.Name = "lblTargetPopulation";
            this.lblTargetPopulation.Size = new System.Drawing.Size(94, 13);
            this.lblTargetPopulation.TabIndex = 6;
            this.lblTargetPopulation.Text = "Target Population:";
            // 
            // lblGrowthRate
            // 
            this.lblGrowthRate.AutoSize = true;
            this.lblGrowthRate.Location = new System.Drawing.Point(112, 85);
            this.lblGrowthRate.Name = "lblGrowthRate";
            this.lblGrowthRate.Size = new System.Drawing.Size(70, 13);
            this.lblGrowthRate.TabIndex = 7;
            this.lblGrowthRate.Text = "Growth Rate:";
            // 
            // fmCityPopulation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 238);
            this.Controls.Add(this.lblGrowthRate);
            this.Controls.Add(this.lblTargetPopulation);
            this.Controls.Add(this.lblCurrentPopulation);
            this.Controls.Add(this.lstResults);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtGrowthRate);
            this.Controls.Add(this.txtTargetPopulation);
            this.Controls.Add(this.txtCurrentPopulation);
            this.Name = "fmCityPopulation";
            this.Text = "CityPopulation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCurrentPopulation;
        private System.Windows.Forms.TextBox txtTargetPopulation;
        private System.Windows.Forms.TextBox txtGrowthRate;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.ListBox lstResults;
        private System.Windows.Forms.Label lblCurrentPopulation;
        private System.Windows.Forms.Label lblTargetPopulation;
        private System.Windows.Forms.Label lblGrowthRate;
    }
}

