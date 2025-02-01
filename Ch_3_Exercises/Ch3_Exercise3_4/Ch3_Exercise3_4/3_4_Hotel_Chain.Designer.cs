namespace Ch3_Exercise3_4
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
            this.txtNumberOfDays = new System.Windows.Forms.TextBox();
            this.txtCustomerStatus = new System.Windows.Forms.TextBox();
            this.txtRoomRate = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblNumberOfDays = new System.Windows.Forms.Label();
            this.lblCustomerStatus = new System.Windows.Forms.Label();
            this.lblRoomRate = new System.Windows.Forms.Label();
            this.lblTotalCost = new System.Windows.Forms.Label();
            this.lblNetAmount = new System.Windows.Forms.Label();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNumberOfDays
            // 
            this.txtNumberOfDays.Location = new System.Drawing.Point(104, 40);
            this.txtNumberOfDays.Name = "txtNumberOfDays";
            this.txtNumberOfDays.Size = new System.Drawing.Size(95, 20);
            this.txtNumberOfDays.TabIndex = 0;
            // 
            // txtCustomerStatus
            // 
            this.txtCustomerStatus.Location = new System.Drawing.Point(104, 67);
            this.txtCustomerStatus.Name = "txtCustomerStatus";
            this.txtCustomerStatus.Size = new System.Drawing.Size(95, 20);
            this.txtCustomerStatus.TabIndex = 1;
            // 
            // txtRoomRate
            // 
            this.txtRoomRate.Location = new System.Drawing.Point(104, 93);
            this.txtRoomRate.Name = "txtRoomRate";
            this.txtRoomRate.Size = new System.Drawing.Size(95, 20);
            this.txtRoomRate.TabIndex = 2;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(17, 133);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(103, 42);
            this.btnCalculate.TabIndex = 3;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(133, 133);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(103, 42);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(242, 133);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(103, 42);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblNumberOfDays
            // 
            this.lblNumberOfDays.AutoSize = true;
            this.lblNumberOfDays.Location = new System.Drawing.Point(14, 47);
            this.lblNumberOfDays.Name = "lblNumberOfDays";
            this.lblNumberOfDays.Size = new System.Drawing.Size(85, 13);
            this.lblNumberOfDays.TabIndex = 6;
            this.lblNumberOfDays.Text = "Number Of Days";
            // 
            // lblCustomerStatus
            // 
            this.lblCustomerStatus.AutoSize = true;
            this.lblCustomerStatus.Location = new System.Drawing.Point(14, 74);
            this.lblCustomerStatus.Name = "lblCustomerStatus";
            this.lblCustomerStatus.Size = new System.Drawing.Size(84, 13);
            this.lblCustomerStatus.TabIndex = 7;
            this.lblCustomerStatus.Text = "Customer Status";
            // 
            // lblRoomRate
            // 
            this.lblRoomRate.AutoSize = true;
            this.lblRoomRate.Location = new System.Drawing.Point(37, 100);
            this.lblRoomRate.Name = "lblRoomRate";
            this.lblRoomRate.Size = new System.Drawing.Size(61, 13);
            this.lblRoomRate.TabIndex = 8;
            this.lblRoomRate.Text = "Room Rate";
            // 
            // lblTotalCost
            // 
            this.lblTotalCost.AutoSize = true;
            this.lblTotalCost.Location = new System.Drawing.Point(226, 47);
            this.lblTotalCost.Name = "lblTotalCost";
            this.lblTotalCost.Size = new System.Drawing.Size(10, 13);
            this.lblTotalCost.TabIndex = 9;
            this.lblTotalCost.Text = "-";
            // 
            // lblNetAmount
            // 
            this.lblNetAmount.AutoSize = true;
            this.lblNetAmount.Location = new System.Drawing.Point(226, 96);
            this.lblNetAmount.Name = "lblNetAmount";
            this.lblNetAmount.Size = new System.Drawing.Size(10, 13);
            this.lblNetAmount.TabIndex = 10;
            this.lblNetAmount.Text = "-";
            // 
            // lblDiscount
            // 
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Location = new System.Drawing.Point(226, 71);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(10, 13);
            this.lblDiscount.TabIndex = 11;
            this.lblDiscount.Text = "-";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 202);
            this.Controls.Add(this.lblDiscount);
            this.Controls.Add(this.lblNetAmount);
            this.Controls.Add(this.lblTotalCost);
            this.Controls.Add(this.lblRoomRate);
            this.Controls.Add(this.lblCustomerStatus);
            this.Controls.Add(this.lblNumberOfDays);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtRoomRate);
            this.Controls.Add(this.txtCustomerStatus);
            this.Controls.Add(this.txtNumberOfDays);
            this.Name = "Form1";
            this.Text = "HotelChain";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNumberOfDays;
        private System.Windows.Forms.TextBox txtCustomerStatus;
        private System.Windows.Forms.TextBox txtRoomRate;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblNumberOfDays;
        private System.Windows.Forms.Label lblCustomerStatus;
        private System.Windows.Forms.Label lblRoomRate;
        private System.Windows.Forms.Label lblTotalCost;
        private System.Windows.Forms.Label lblNetAmount;
        private System.Windows.Forms.Label lblDiscount;
    }
}

