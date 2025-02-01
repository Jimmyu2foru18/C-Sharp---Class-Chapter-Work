namespace Ch_6_Exercise_6_1
{
    partial class Icecream
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
            this.lblNumScoops = new System.Windows.Forms.Label();
            this.scrollBarScoops = new System.Windows.Forms.HScrollBar();
            this.comboBoxDesert = new System.Windows.Forms.ComboBox();
            this.checkBoxNuts = new System.Windows.Forms.CheckBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.lblScoops = new System.Windows.Forms.Label();
            this.lstResults = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblNumScoops
            // 
            this.lblNumScoops.AutoSize = true;
            this.lblNumScoops.Location = new System.Drawing.Point(9, 16);
            this.lblNumScoops.Name = "lblNumScoops";
            this.lblNumScoops.Size = new System.Drawing.Size(98, 13);
            this.lblNumScoops.TabIndex = 0;
            this.lblNumScoops.Text = "Number of Scoops:";
            // 
            // scrollBarScoops
            // 
            this.scrollBarScoops.LargeChange = 1;
            this.scrollBarScoops.Location = new System.Drawing.Point(12, 38);
            this.scrollBarScoops.Maximum = 10;
            this.scrollBarScoops.Minimum = 1;
            this.scrollBarScoops.Name = "scrollBarScoops";
            this.scrollBarScoops.Size = new System.Drawing.Size(158, 37);
            this.scrollBarScoops.TabIndex = 1;
            this.scrollBarScoops.Value = 1;
            // 
            // comboBoxDesert
            // 
            this.comboBoxDesert.FormattingEnabled = true;
            this.comboBoxDesert.Location = new System.Drawing.Point(12, 117);
            this.comboBoxDesert.Name = "comboBoxDesert";
            this.comboBoxDesert.Size = new System.Drawing.Size(130, 21);
            this.comboBoxDesert.TabIndex = 3;
            // 
            // checkBoxNuts
            // 
            this.checkBoxNuts.AutoSize = true;
            this.checkBoxNuts.Location = new System.Drawing.Point(148, 121);
            this.checkBoxNuts.Name = "checkBoxNuts";
            this.checkBoxNuts.Size = new System.Drawing.Size(54, 17);
            this.checkBoxNuts.TabIndex = 4;
            this.checkBoxNuts.Text = "Nuts?";
            this.checkBoxNuts.UseVisualStyleBackColor = true;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(12, 144);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(130, 42);
            this.btnCalculate.TabIndex = 5;
            this.btnCalculate.Text = "Compute Amt";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(12, 192);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(80, 29);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click_1);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(98, 192);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(85, 29);
            this.Exit.TabIndex = 7;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // lblScoops
            // 
            this.lblScoops.AutoSize = true;
            this.lblScoops.Location = new System.Drawing.Point(12, 89);
            this.lblScoops.Name = "lblScoops";
            this.lblScoops.Size = new System.Drawing.Size(0, 13);
            this.lblScoops.TabIndex = 9;
            // 
            // lstResults
            // 
            this.lstResults.FormattingEnabled = true;
            this.lstResults.Location = new System.Drawing.Point(9, 229);
            this.lstResults.Name = "lstResults";
            this.lstResults.Size = new System.Drawing.Size(193, 82);
            this.lstResults.TabIndex = 10;
            // 
            // Icecream
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(217, 321);
            this.Controls.Add(this.lstResults);
            this.Controls.Add(this.lblScoops);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.checkBoxNuts);
            this.Controls.Add(this.comboBoxDesert);
            this.Controls.Add(this.scrollBarScoops);
            this.Controls.Add(this.lblNumScoops);
            this.Name = "Icecream";
            this.Text = "Ice Cream";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumScoops;
        private System.Windows.Forms.HScrollBar scrollBarScoops;
        private System.Windows.Forms.ComboBox comboBoxDesert;
        private System.Windows.Forms.CheckBox checkBoxNuts;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Label lblScoops;
        private System.Windows.Forms.ListBox lstResults;
    }
}

