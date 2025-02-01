namespace Ch_7_Exercise_7_3
{
    partial class Ch_7_3_Theater_Tickets
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
            this.comboBoxShows = new System.Windows.Forms.ComboBox();
            this.listResults = new System.Windows.Forms.ListBox();
            this.lblSelect = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBoxShows
            // 
            this.comboBoxShows.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxShows.FormattingEnabled = true;
            this.comboBoxShows.Location = new System.Drawing.Point(34, 40);
            this.comboBoxShows.Name = "comboBoxShows";
            this.comboBoxShows.Size = new System.Drawing.Size(157, 21);
            this.comboBoxShows.TabIndex = 0;
            this.comboBoxShows.SelectedIndexChanged += new System.EventHandler(this.comboBoxShows_SelectedIndexChanged);
            // 
            // listResults
            // 
            this.listResults.FormattingEnabled = true;
            this.listResults.Location = new System.Drawing.Point(34, 95);
            this.listResults.Name = "listResults";
            this.listResults.Size = new System.Drawing.Size(157, 56);
            this.listResults.TabIndex = 1;
            // 
            // lblSelect
            // 
            this.lblSelect.AutoSize = true;
            this.lblSelect.Location = new System.Drawing.Point(31, 9);
            this.lblSelect.Name = "lblSelect";
            this.lblSelect.Size = new System.Drawing.Size(40, 13);
            this.lblSelect.TabIndex = 2;
            this.lblSelect.Text = "Select:";
            // 
            // Ch_7_3_Theater_Tickets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(228, 180);
            this.Controls.Add(this.lblSelect);
            this.Controls.Add(this.listResults);
            this.Controls.Add(this.comboBoxShows);
            this.Name = "Ch_7_3_Theater_Tickets";
            this.Text = "Theater Tickets";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxShows;
        private System.Windows.Forms.ListBox listResults;
        private System.Windows.Forms.Label lblSelect;
    }
}
