namespace DataTypes2_3
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DateTimePicker dateTimePickerRented;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePickerReturned;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtChargePerDay;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.ListBox listBoxResults;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePickerRentedTime;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePickerReturnedTime;

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
            this.dateTimePickerRented = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePickerReturned = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txtChargePerDay = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.listBoxResults = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePickerRentedTime = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePickerReturnedTime = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // dateTimePickerRented
            // 
            this.dateTimePickerRented.Location = new System.Drawing.Point(89, 19);
            this.dateTimePickerRented.Name = "dateTimePickerRented";
            this.dateTimePickerRented.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerRented.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Date Rented:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Date Returned:";
            // 
            // dateTimePickerReturned
            // 
            this.dateTimePickerReturned.Location = new System.Drawing.Point(89, 47);
            this.dateTimePickerReturned.Name = "dateTimePickerReturned";
            this.dateTimePickerReturned.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerReturned.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Charge Per Day:";
            // 
            // txtChargePerDay
            // 
            this.txtChargePerDay.Location = new System.Drawing.Point(89, 74);
            this.txtChargePerDay.Name = "txtChargePerDay";
            this.txtChargePerDay.Size = new System.Drawing.Size(100, 20);
            this.txtChargePerDay.TabIndex = 5;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(172, 106);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 6;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // listBoxResults
            // 
            this.listBoxResults.FormattingEnabled = true;
            this.listBoxResults.Location = new System.Drawing.Point(101, 135);
            this.listBoxResults.Name = "listBoxResults";
            this.listBoxResults.Size = new System.Drawing.Size(297, 43);
            this.listBoxResults.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Days Rented:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Total Rental Cost:";
            // 
            // dateTimePickerRentedTime
            // 
            this.dateTimePickerRentedTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickerRentedTime.Location = new System.Drawing.Point(295, 18);
            this.dateTimePickerRentedTime.Name = "dateTimePickerRentedTime";
            this.dateTimePickerRentedTime.Size = new System.Drawing.Size(103, 20);
            this.dateTimePickerRentedTime.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(292, 2);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Time Rented:";
            // 
            // dateTimePickerReturnedTime
            // 
            this.dateTimePickerReturnedTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickerReturnedTime.Location = new System.Drawing.Point(295, 44);
            this.dateTimePickerReturnedTime.Name = "dateTimePickerReturnedTime";
            this.dateTimePickerReturnedTime.Size = new System.Drawing.Size(103, 20);
            this.dateTimePickerReturnedTime.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 194);
            this.Controls.Add(this.dateTimePickerReturnedTime);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dateTimePickerRentedTime);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listBoxResults);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtChargePerDay);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePickerReturned);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePickerRented);
            this.Name = "Form1";
            this.Text = "AutoRentalCharge";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}
