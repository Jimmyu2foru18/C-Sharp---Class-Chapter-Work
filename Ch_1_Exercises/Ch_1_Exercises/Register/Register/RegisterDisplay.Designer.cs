namespace Register
{
    partial class RegisterDisplay
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
            this.Price = new System.Windows.Forms.Label();
            this.Subtotal = new System.Windows.Forms.Label();
            this.AddItem = new System.Windows.Forms.Button();
            this.CompleteTransaction = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.RegisterScreen = new System.Windows.Forms.ListBox();
            this.PriceEntry = new System.Windows.Forms.TextBox();
            this.SubtotalEntry = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Price
            // 
            this.Price.AutoSize = true;
            this.Price.Location = new System.Drawing.Point(9, 12);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(34, 13);
            this.Price.TabIndex = 0;
            this.Price.Text = "Price:";
            // 
            // Subtotal
            // 
            this.Subtotal.AutoSize = true;
            this.Subtotal.Location = new System.Drawing.Point(9, 44);
            this.Subtotal.Name = "Subtotal";
            this.Subtotal.Size = new System.Drawing.Size(49, 13);
            this.Subtotal.TabIndex = 1;
            this.Subtotal.Text = "Subtotal:";
            // 
            // AddItem
            // 
            this.AddItem.Location = new System.Drawing.Point(12, 70);
            this.AddItem.Name = "AddItem";
            this.AddItem.Size = new System.Drawing.Size(106, 41);
            this.AddItem.TabIndex = 2;
            this.AddItem.Text = "Add Item";
            this.AddItem.UseVisualStyleBackColor = true;
            this.AddItem.Click += new System.EventHandler(this.AddItem_Click);
            // 
            // CompleteTransaction
            // 
            this.CompleteTransaction.Location = new System.Drawing.Point(12, 117);
            this.CompleteTransaction.Name = "CompleteTransaction";
            this.CompleteTransaction.Size = new System.Drawing.Size(106, 41);
            this.CompleteTransaction.TabIndex = 3;
            this.CompleteTransaction.Text = "Complete Transaction";
            this.CompleteTransaction.UseVisualStyleBackColor = true;
            this.CompleteTransaction.Click += new System.EventHandler(this.CompleteTransaction_Click);
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(12, 164);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(106, 41);
            this.Clear.TabIndex = 4;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(12, 211);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(106, 41);
            this.Exit.TabIndex = 5;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // RegisterScreen
            // 
            this.RegisterScreen.FormattingEnabled = true;
            this.RegisterScreen.Location = new System.Drawing.Point(156, 12);
            this.RegisterScreen.Name = "RegisterScreen";
            this.RegisterScreen.Size = new System.Drawing.Size(323, 238);
            this.RegisterScreen.TabIndex = 6;
            this.RegisterScreen.SelectedIndexChanged += new System.EventHandler(this.RegisterScreen_SelectedIndexChanged);
            // 
            // PriceEntry
            // 
            this.PriceEntry.Location = new System.Drawing.Point(64, 9);
            this.PriceEntry.Name = "PriceEntry";
            this.PriceEntry.Size = new System.Drawing.Size(86, 20);
            this.PriceEntry.TabIndex = 7;
            // 
            // SubtotalEntry
            // 
            this.SubtotalEntry.Location = new System.Drawing.Point(64, 44);
            this.SubtotalEntry.Name = "SubtotalEntry";
            this.SubtotalEntry.Size = new System.Drawing.Size(86, 20);
            this.SubtotalEntry.TabIndex = 8;
            // 
            // RegisterDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 271);
            this.Controls.Add(this.SubtotalEntry);
            this.Controls.Add(this.PriceEntry);
            this.Controls.Add(this.RegisterScreen);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.CompleteTransaction);
            this.Controls.Add(this.AddItem);
            this.Controls.Add(this.Subtotal);
            this.Controls.Add(this.Price);
            this.Name = "RegisterDisplay";
            this.Text = "Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Price;
        private System.Windows.Forms.Label Subtotal;
        private System.Windows.Forms.Button AddItem;
        private System.Windows.Forms.Button CompleteTransaction;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.ListBox RegisterScreen;
        private System.Windows.Forms.TextBox PriceEntry;
        private System.Windows.Forms.TextBox SubtotalEntry;
    }
}

