using System;
using System.IO;
using System.Windows.Forms;

partial class ReadTextFile : Form
{
    private int currentIndex = 0; // Index to keep track of the current line being processed
    private string[] lines; // Array to store all lines read from the file

    private System.Windows.Forms.Button ComputePercent;
    private System.Windows.Forms.ListBox lstResults;

    private void InitializeComponent()
    {
        this.ComputePercent = new System.Windows.Forms.Button();
        this.lstResults = new System.Windows.Forms.ListBox();
        this.SuspendLayout();
        // 
        // ComputePercent
        // 
        this.ComputePercent.Location = new System.Drawing.Point(12, 183);
        this.ComputePercent.Name = "ComputePercent";
        this.ComputePercent.Size = new System.Drawing.Size(120, 40);
        this.ComputePercent.TabIndex = 0;
        this.ComputePercent.Text = "Compute Percent";
        this.ComputePercent.Click += new System.EventHandler(this.ComputePercent_Click);
        // 
        // lstResults
        // 
        this.lstResults.FormattingEnabled = true;
        this.lstResults.Location = new System.Drawing.Point(12, 12);
        this.lstResults.Name = "lstResults";
        this.lstResults.Size = new System.Drawing.Size(260, 160);
        this.lstResults.TabIndex = 1;
        // 
        // ReadTextFile
        // 
        this.ClientSize = new System.Drawing.Size(284, 261);
        this.Controls.Add(this.lstResults);
        this.Controls.Add(this.ComputePercent);
        this.Name = "ReadTextFile";
        this.Text = "Read Text";
        this.ResumeLayout(false);
    }
}
