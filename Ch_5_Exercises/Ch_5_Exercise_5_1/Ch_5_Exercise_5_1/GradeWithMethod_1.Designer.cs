namespace Ch_5_Exercise_5_1
{
    partial class GradeWithMethod_1
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
            this.txtScore = new System.Windows.Forms.TextBox();
            this.lblScore = new System.Windows.Forms.Label();
            this.btnComputeGrade = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtScore
            // 
            this.txtScore.Location = new System.Drawing.Point(56, 34);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(133, 20);
            this.txtScore.TabIndex = 0;
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Location = new System.Drawing.Point(12, 37);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(38, 13);
            this.lblScore.TabIndex = 1;
            this.lblScore.Text = "Score:";
            // 
            // btnComputeGrade
            // 
            this.btnComputeGrade.Location = new System.Drawing.Point(56, 60);
            this.btnComputeGrade.Name = "btnComputeGrade";
            this.btnComputeGrade.Size = new System.Drawing.Size(133, 57);
            this.btnComputeGrade.TabIndex = 2;
            this.btnComputeGrade.Text = "Compute Grade";
            this.btnComputeGrade.UseVisualStyleBackColor = true;
            this.btnComputeGrade.Click += new System.EventHandler(this.btnComputeGrade_Click);
            // 
            // GradeWithMethod_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(208, 132);
            this.Controls.Add(this.btnComputeGrade);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.txtScore);
            this.Name = "GradeWithMethod_1";
            this.Text = "Grades";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtScore;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Button btnComputeGrade;
    }
}

