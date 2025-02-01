namespace Ch_5_Methods_HR_
{
    partial class Ch_5_Heart_Rate
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
            this.btnAbout = new System.Windows.Forms.Button();
            this.lblRestingHeartRate = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.txtRestingHeartRate = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.btnCompute = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAbout
            // 
            this.btnAbout.Location = new System.Drawing.Point(110, 12);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(108, 31);
            this.btnAbout.TabIndex = 0;
            this.btnAbout.Text = "About";
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // lblRestingHeartRate
            // 
            this.lblRestingHeartRate.AutoSize = true;
            this.lblRestingHeartRate.Location = new System.Drawing.Point(8, 65);
            this.lblRestingHeartRate.Name = "lblRestingHeartRate";
            this.lblRestingHeartRate.Size = new System.Drawing.Size(101, 13);
            this.lblRestingHeartRate.TabIndex = 1;
            this.lblRestingHeartRate.Text = "Resting Heart Rate:";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(75, 93);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(29, 13);
            this.lblAge.TabIndex = 2;
            this.lblAge.Text = "Age:";
            // 
            // txtRestingHeartRate
            // 
            this.txtRestingHeartRate.Location = new System.Drawing.Point(110, 58);
            this.txtRestingHeartRate.Name = "txtRestingHeartRate";
            this.txtRestingHeartRate.Size = new System.Drawing.Size(108, 20);
            this.txtRestingHeartRate.TabIndex = 3;
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(110, 86);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(108, 20);
            this.txtAge.TabIndex = 4;
            // 
            // btnCompute
            // 
            this.btnCompute.Location = new System.Drawing.Point(110, 122);
            this.btnCompute.Name = "btnCompute";
            this.btnCompute.Size = new System.Drawing.Size(107, 42);
            this.btnCompute.TabIndex = 5;
            this.btnCompute.Text = "Compute Training Rate";
            this.btnCompute.UseVisualStyleBackColor = true;
            this.btnCompute.Click += new System.EventHandler(this.btnCompute_Click);
            // 
            // Ch_5_Heart_Rate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(261, 183);
            this.Controls.Add(this.btnCompute);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.txtRestingHeartRate);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.lblRestingHeartRate);
            this.Controls.Add(this.btnAbout);
            this.Name = "Ch_5_Heart_Rate";
            this.Text = "Heart Rate";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Label lblRestingHeartRate;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.TextBox txtRestingHeartRate;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Button btnCompute;
    }
}

