namespace TotalCost1_3
{
    partial class TotalCost1_3
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
            this.CostOfLabor = new System.Windows.Forms.Label();
            this.Material = new System.Windows.Forms.Label();
            this.Subtotal = new System.Windows.Forms.Label();
            this.SalesTax = new System.Windows.Forms.Label();
            this.TotalCost = new System.Windows.Forms.Label();
            this.ComputeCost = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.costOfLabor1 = new System.Windows.Forms.TextBox();
            this.Material1 = new System.Windows.Forms.TextBox();
            this.TotalCost1 = new System.Windows.Forms.TextBox();
            this.SalesTax1 = new System.Windows.Forms.TextBox();
            this.Subtotal1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CostOfLabor
            // 
            this.CostOfLabor.AutoSize = true;
            this.CostOfLabor.Location = new System.Drawing.Point(-2, 24);
            this.CostOfLabor.Name = "CostOfLabor";
            this.CostOfLabor.Size = new System.Drawing.Size(75, 13);
            this.CostOfLabor.TabIndex = 0;
            this.CostOfLabor.Text = "Cost Of Labor:";
            // 
            // Material
            // 
            this.Material.AutoSize = true;
            this.Material.Location = new System.Drawing.Point(9, 70);
            this.Material.Name = "Material";
            this.Material.Size = new System.Drawing.Size(47, 13);
            this.Material.TabIndex = 1;
            this.Material.Text = "Material:";
            // 
            // Subtotal
            // 
            this.Subtotal.AutoSize = true;
            this.Subtotal.Location = new System.Drawing.Point(197, 18);
            this.Subtotal.Name = "Subtotal";
            this.Subtotal.Size = new System.Drawing.Size(49, 13);
            this.Subtotal.TabIndex = 2;
            this.Subtotal.Text = "Subtotal:";
            // 
            // SalesTax
            // 
            this.SalesTax.AutoSize = true;
            this.SalesTax.Location = new System.Drawing.Point(197, 52);
            this.SalesTax.Name = "SalesTax";
            this.SalesTax.Size = new System.Drawing.Size(57, 13);
            this.SalesTax.TabIndex = 3;
            this.SalesTax.Text = "Sales Tax:";
            // 
            // TotalCost
            // 
            this.TotalCost.AutoSize = true;
            this.TotalCost.Location = new System.Drawing.Point(197, 83);
            this.TotalCost.Name = "TotalCost";
            this.TotalCost.Size = new System.Drawing.Size(58, 13);
            this.TotalCost.TabIndex = 4;
            this.TotalCost.Text = "Total Cost:";
            // 
            // ComputeCost
            // 
            this.ComputeCost.Location = new System.Drawing.Point(12, 128);
            this.ComputeCost.Name = "ComputeCost";
            this.ComputeCost.Size = new System.Drawing.Size(100, 22);
            this.ComputeCost.TabIndex = 5;
            this.ComputeCost.Text = "Compute Cost";
            this.ComputeCost.UseVisualStyleBackColor = true;
            this.ComputeCost.Click += new System.EventHandler(this.ComputeCost_Click);
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(180, 125);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(66, 22);
            this.Clear.TabIndex = 6;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(252, 125);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(66, 22);
            this.Exit.TabIndex = 7;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // costOfLabor1
            // 
            this.costOfLabor1.Location = new System.Drawing.Point(76, 21);
            this.costOfLabor1.Name = "costOfLabor1";
            this.costOfLabor1.Size = new System.Drawing.Size(67, 20);
            this.costOfLabor1.TabIndex = 8;
            // 
            // Material1
            // 
            this.Material1.Location = new System.Drawing.Point(76, 70);
            this.Material1.Name = "Material1";
            this.Material1.Size = new System.Drawing.Size(67, 20);
            this.Material1.TabIndex = 9;
            // 
            // TotalCost1
            // 
            this.TotalCost1.Location = new System.Drawing.Point(257, 76);
            this.TotalCost1.Name = "TotalCost1";
            this.TotalCost1.Size = new System.Drawing.Size(67, 20);
            this.TotalCost1.TabIndex = 10;
            // 
            // SalesTax1
            // 
            this.SalesTax1.Location = new System.Drawing.Point(257, 45);
            this.SalesTax1.Name = "SalesTax1";
            this.SalesTax1.Size = new System.Drawing.Size(67, 20);
            this.SalesTax1.TabIndex = 11;
            // 
            // Subtotal1
            // 
            this.Subtotal1.Location = new System.Drawing.Point(257, 15);
            this.Subtotal1.Name = "Subtotal1";
            this.Subtotal1.Size = new System.Drawing.Size(67, 20);
            this.Subtotal1.TabIndex = 12;
            // 
            // TotalCost1_3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 159);
            this.Controls.Add(this.Subtotal1);
            this.Controls.Add(this.SalesTax1);
            this.Controls.Add(this.TotalCost1);
            this.Controls.Add(this.Material1);
            this.Controls.Add(this.costOfLabor1);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.ComputeCost);
            this.Controls.Add(this.TotalCost);
            this.Controls.Add(this.SalesTax);
            this.Controls.Add(this.Subtotal);
            this.Controls.Add(this.Material);
            this.Controls.Add(this.CostOfLabor);
            this.Name = "TotalCost1_3";
            this.Text = "TotalCost1.3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CostOfLabor;
        private System.Windows.Forms.Label Material;
        private System.Windows.Forms.Label Subtotal;
        private System.Windows.Forms.Label SalesTax;
        private System.Windows.Forms.Label TotalCost;
        private System.Windows.Forms.Button ComputeCost;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.TextBox costOfLabor1;
        private System.Windows.Forms.TextBox Material1;
        private System.Windows.Forms.TextBox TotalCost1;
        private System.Windows.Forms.TextBox SalesTax1;
        private System.Windows.Forms.TextBox Subtotal1;
    }
}

