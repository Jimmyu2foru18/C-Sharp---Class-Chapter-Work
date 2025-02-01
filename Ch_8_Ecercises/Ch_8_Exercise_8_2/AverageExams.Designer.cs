using System.ComponentModel;
using System.Drawing;
using System;

namespace Ch_8_Exercise_8_2
{
    partial class AverageExams
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        // Other variables and controls declarations can go here

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
            this.SuspendLayout();
            // 
            // AverageExams
            // 
            this.ClientSize = new System.Drawing.Size(513, 419);
            this.Name = "AverageExams";
            this.Text = "Average Exam Score";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        // You can add methods for event handlers here

        private void Form1_Load(object sender, EventArgs e)
        {
            // Initialize UI
            InitializeUI();
        }
    }
}
