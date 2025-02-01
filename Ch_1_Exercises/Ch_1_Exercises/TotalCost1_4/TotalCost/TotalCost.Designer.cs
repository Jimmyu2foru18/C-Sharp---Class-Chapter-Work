namespace TotalCost
{
    partial class TotalCost
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
            this.CostOfLaborAmmount = new System.Windows.Forms.TextBox();
            this.MaterialsAmmount = new System.Windows.Forms.TextBox();
            this.TotalListBox = new System.Windows.Forms.ListBox();
            this.ComputeCost = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CostOfLabor
            // 
            this.CostOfLabor.AutoSize = true;
            this.CostOfLabor.Location = new System.Drawing.Point(12, 26);
            this.CostOfLabor.Name = "CostOfLabor";
            this.CostOfLabor.Size = new System.Drawing.Size(73, 13);
            this.CostOfLabor.TabIndex = 0;
            this.CostOfLabor.Text = "Cost of Labor:";
            // 
            // Material
            // 
            this.Material.AutoSize = true;
            this.Material.Location = new System.Drawing.Point(12, 54);
            this.Material.Name = "Material";
            this.Material.Size = new System.Drawing.Size(47, 13);
            this.Material.TabIndex = 1;
            this.Material.Text = "Material:";
            // 
            // CostOfLaborAmmount
            // 
            this.CostOfLaborAmmount.Location = new System.Drawing.Point(101, 21);
            this.CostOfLaborAmmount.Name = "CostOfLaborAmmount";
            this.CostOfLaborAmmount.Size = new System.Drawing.Size(77, 20);
            this.CostOfLaborAmmount.TabIndex = 2;
            // 
            // MaterialsAmmount
            // 
            this.MaterialsAmmount.Location = new System.Drawing.Point(101, 54);
            this.MaterialsAmmount.Name = "MaterialsAmmount";
            this.MaterialsAmmount.Size = new System.Drawing.Size(77, 20);
            this.MaterialsAmmount.TabIndex = 3;
            // 
            // TotalListBox
            // 
            this.TotalListBox.FormattingEnabled = true;
            this.TotalListBox.Location = new System.Drawing.Point(195, 18);
            this.TotalListBox.Name = "TotalListBox";
            this.TotalListBox.Size = new System.Drawing.Size(196, 56);
            this.TotalListBox.TabIndex = 4;
            this.TotalListBox.SelectedIndexChanged += new System.EventHandler(this.TotalListBox_SelectedIndexChanged);
            // 
            // ComputeCost
            // 
            this.ComputeCost.Location = new System.Drawing.Point(98, 91);
            this.ComputeCost.Name = "ComputeCost";
            this.ComputeCost.Size = new System.Drawing.Size(97, 21);
            this.ComputeCost.TabIndex = 5;
            this.ComputeCost.Text = "Compute Cost";
            this.ComputeCost.UseVisualStyleBackColor = true;
            this.ComputeCost.Click += new System.EventHandler(this.ComputeCost_Click);
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(215, 91);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(80, 21);
            this.Clear.TabIndex = 6;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(301, 91);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(80, 21);
            this.Exit.TabIndex = 7;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // TotalCost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 141);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.ComputeCost);
            this.Controls.Add(this.TotalListBox);
            this.Controls.Add(this.MaterialsAmmount);
            this.Controls.Add(this.CostOfLaborAmmount);
            this.Controls.Add(this.Material);
            this.Controls.Add(this.CostOfLabor);
            this.Name = "TotalCost";
            this.Text = "TotalCost";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CostOfLabor;
        private System.Windows.Forms.Label Material;
        private System.Windows.Forms.TextBox CostOfLaborAmmount;
        private System.Windows.Forms.TextBox MaterialsAmmount;
        private System.Windows.Forms.ListBox TotalListBox;
        private System.Windows.Forms.Button ComputeCost;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button Exit;
    }
}

