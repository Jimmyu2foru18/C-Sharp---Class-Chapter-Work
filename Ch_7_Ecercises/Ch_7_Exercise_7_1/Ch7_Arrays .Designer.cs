namespace Ch_7_Exercise_7_1
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
            this.btnDisplayMonth = new System.Windows.Forms.Button();
            this.lbl = new System.Windows.Forms.Label();
            this.lblMonthName = new System.Windows.Forms.Label();
            this.txtMonthNumber = new System.Windows.Forms.TextBox();
            this.txtMonthName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnDisplayMonth
            // 
            this.btnDisplayMonth.Location = new System.Drawing.Point(67, 32);
            this.btnDisplayMonth.Name = "btnDisplayMonth";
            this.btnDisplayMonth.Size = new System.Drawing.Size(163, 52);
            this.btnDisplayMonth.TabIndex = 0;
            this.btnDisplayMonth.Text = "Display Month";
            this.btnDisplayMonth.UseVisualStyleBackColor = true;
            this.btnDisplayMonth.Click += new System.EventHandler(this.btnDisplayMonth_Click);
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(12, 9);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(47, 13);
            this.lbl.TabIndex = 1;
            this.lbl.Text = "Month#:";
            // 
            // lblMonthName
            // 
            this.lblMonthName.AutoSize = true;
            this.lblMonthName.Location = new System.Drawing.Point(-2, 93);
            this.lblMonthName.Name = "lblMonthName";
            this.lblMonthName.Size = new System.Drawing.Size(71, 13);
            this.lblMonthName.TabIndex = 2;
            this.lblMonthName.Text = "Month Name:";
            // 
            // txtMonthNumber
            // 
            this.txtMonthNumber.Location = new System.Drawing.Point(67, 6);
            this.txtMonthNumber.Name = "txtMonthNumber";
            this.txtMonthNumber.Size = new System.Drawing.Size(163, 20);
            this.txtMonthNumber.TabIndex = 3;
            // 
            // txtMonthName
            // 
            this.txtMonthName.Location = new System.Drawing.Point(67, 90);
            this.txtMonthName.Name = "txtMonthName";
            this.txtMonthName.Size = new System.Drawing.Size(163, 20);
            this.txtMonthName.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 131);
            this.Controls.Add(this.txtMonthName);
            this.Controls.Add(this.txtMonthNumber);
            this.Controls.Add(this.lblMonthName);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.btnDisplayMonth);
            this.Name = "Form1";
            this.Text = "ClassExercise_7_1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDisplayMonth;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label lblMonthName;
        private System.Windows.Forms.TextBox txtMonthNumber;
        private System.Windows.Forms.TextBox txtMonthName;
    }
}

