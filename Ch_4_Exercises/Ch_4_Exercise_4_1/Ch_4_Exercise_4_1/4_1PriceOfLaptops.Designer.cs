namespace Ch_4_Exercise_4_1
{
    partial class txtTargetPrice
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
            this.txtCurrentPrice = new System.Windows.Forms.TextBox();
            this.txtTargetPrice1 = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lstResults = new System.Windows.Forms.ListBox();
            this.lblCurrentPrice = new System.Windows.Forms.Label();
            this.lblTargetPrice = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtCurrentPrice
            // 
            this.txtCurrentPrice.Location = new System.Drawing.Point(90, 11);
            this.txtCurrentPrice.Name = "txtCurrentPrice";
            this.txtCurrentPrice.Size = new System.Drawing.Size(87, 20);
            this.txtCurrentPrice.TabIndex = 0;
            // 
            // txtTargetPrice1
            // 
            this.txtTargetPrice1.Location = new System.Drawing.Point(90, 38);
            this.txtTargetPrice1.Name = "txtTargetPrice1";
            this.txtTargetPrice1.Size = new System.Drawing.Size(87, 20);
            this.txtTargetPrice1.TabIndex = 1;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(48, 104);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(82, 41);
            this.btnCalculate.TabIndex = 2;
            this.btnCalculate.Text = "Caculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lstResults
            // 
            this.lstResults.FormattingEnabled = true;
            this.lstResults.Location = new System.Drawing.Point(183, 12);
            this.lstResults.Name = "lstResults";
            this.lstResults.Size = new System.Drawing.Size(267, 173);
            this.lstResults.TabIndex = 3;
            // 
            // lblCurrentPrice
            // 
            this.lblCurrentPrice.AutoSize = true;
            this.lblCurrentPrice.Location = new System.Drawing.Point(13, 18);
            this.lblCurrentPrice.Name = "lblCurrentPrice";
            this.lblCurrentPrice.Size = new System.Drawing.Size(71, 13);
            this.lblCurrentPrice.TabIndex = 4;
            this.lblCurrentPrice.Text = "Current Price:";
            // 
            // lblTargetPrice
            // 
            this.lblTargetPrice.AutoSize = true;
            this.lblTargetPrice.Location = new System.Drawing.Point(12, 45);
            this.lblTargetPrice.Name = "lblTargetPrice";
            this.lblTargetPrice.Size = new System.Drawing.Size(68, 13);
            this.lblTargetPrice.TabIndex = 5;
            this.lblTargetPrice.Text = "Target Price:";
            // 
            // txtTargetPrice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 206);
            this.Controls.Add(this.lblTargetPrice);
            this.Controls.Add(this.lblCurrentPrice);
            this.Controls.Add(this.lstResults);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtTargetPrice1);
            this.Controls.Add(this.txtCurrentPrice);
            this.Name = "txtTargetPrice";
            this.Text = "PriceOfLaptops";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCurrentPrice;
        private System.Windows.Forms.TextBox txtTargetPrice1;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.ListBox lstResults;
        private System.Windows.Forms.Label lblCurrentPrice;
        private System.Windows.Forms.Label lblTargetPrice;
    }
}

