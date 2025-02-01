using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Ch_6_Ecercises_6_2
{
    partial class Ch_6_Event_Registration
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.grpEvents = new System.Windows.Forms.GroupBox();
            this.checkBoxBratFry = new System.Windows.Forms.CheckBox();
            this.checkBoxWalkathon = new System.Windows.Forms.CheckBox();
            this.checkBoxBakeSale = new System.Windows.Forms.CheckBox();
            this.checkBoxGolfing = new System.Windows.Forms.CheckBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblEvents = new System.Windows.Forms.Label();
            this.grpHours = new System.Windows.Forms.GroupBox();
            this.rhours1 = new System.Windows.Forms.RadioButton();
            this.rhours2 = new System.Windows.Forms.RadioButton();
            this.rhours3 = new System.Windows.Forms.RadioButton();
            this.rhours4 = new System.Windows.Forms.RadioButton();
            this.lblWorkHours = new System.Windows.Forms.Label();
            this.grpStatus = new System.Windows.Forms.GroupBox();
            this.rNew = new System.Windows.Forms.RadioButton();
            this.rExperienced = new System.Windows.Forms.RadioButton();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lstResults = new System.Windows.Forms.ListBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.grpEvents.SuspendLayout();
            this.grpHours.SuspendLayout();
            this.grpStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(56, 12);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(169, 20);
            this.txtName.TabIndex = 0;
            // 
            // grpEvents
            // 
            this.grpEvents.Controls.Add(this.checkBoxBratFry);
            this.grpEvents.Controls.Add(this.checkBoxWalkathon);
            this.grpEvents.Controls.Add(this.checkBoxBakeSale);
            this.grpEvents.Controls.Add(this.checkBoxGolfing);
            this.grpEvents.Location = new System.Drawing.Point(61, 38);
            this.grpEvents.Name = "grpEvents";
            this.grpEvents.Size = new System.Drawing.Size(164, 61);
            this.grpEvents.TabIndex = 1;
            this.grpEvents.TabStop = false;
            // 
            // checkBoxBratFry
            // 
            this.checkBoxBratFry.AutoSize = true;
            this.checkBoxBratFry.Location = new System.Drawing.Point(6, 10);
            this.checkBoxBratFry.Name = "checkBoxBratFry";
            this.checkBoxBratFry.Size = new System.Drawing.Size(62, 17);
            this.checkBoxBratFry.TabIndex = 0;
            this.checkBoxBratFry.Text = "Brat Fry";
            this.checkBoxBratFry.UseVisualStyleBackColor = true;
            // 
            // checkBoxWalkathon
            // 
            this.checkBoxWalkathon.AutoSize = true;
            this.checkBoxWalkathon.Location = new System.Drawing.Point(86, 10);
            this.checkBoxWalkathon.Name = "checkBoxWalkathon";
            this.checkBoxWalkathon.Size = new System.Drawing.Size(78, 17);
            this.checkBoxWalkathon.TabIndex = 1;
            this.checkBoxWalkathon.Text = "Walkathon";
            this.checkBoxWalkathon.UseVisualStyleBackColor = true;
            // 
            // checkBoxBakeSale
            // 
            this.checkBoxBakeSale.AutoSize = true;
            this.checkBoxBakeSale.Location = new System.Drawing.Point(6, 33);
            this.checkBoxBakeSale.Name = "checkBoxBakeSale";
            this.checkBoxBakeSale.Size = new System.Drawing.Size(75, 17);
            this.checkBoxBakeSale.TabIndex = 2;
            this.checkBoxBakeSale.Text = "Bake Sale";
            this.checkBoxBakeSale.UseVisualStyleBackColor = true;
            // 
            // checkBoxGolfing
            // 
            this.checkBoxGolfing.AutoSize = true;
            this.checkBoxGolfing.Location = new System.Drawing.Point(87, 33);
            this.checkBoxGolfing.Name = "checkBoxGolfing";
            this.checkBoxGolfing.Size = new System.Drawing.Size(59, 17);
            this.checkBoxGolfing.TabIndex = 3;
            this.checkBoxGolfing.Text = "Golfing";
            this.checkBoxGolfing.UseVisualStyleBackColor = true;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(12, 19);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 13);
            this.lblName.TabIndex = 5;
            this.lblName.Text = "Name:";
            // 
            // lblEvents
            // 
            this.lblEvents.AutoSize = true;
            this.lblEvents.Location = new System.Drawing.Point(12, 52);
            this.lblEvents.Name = "lblEvents";
            this.lblEvents.Size = new System.Drawing.Size(43, 13);
            this.lblEvents.TabIndex = 6;
            this.lblEvents.Text = "Events:";
            // 
            // grpHours
            // 
            this.grpHours.Controls.Add(this.rhours1);
            this.grpHours.Controls.Add(this.rhours2);
            this.grpHours.Controls.Add(this.rhours3);
            this.grpHours.Controls.Add(this.rhours4);
            this.grpHours.Location = new System.Drawing.Point(90, 97);
            this.grpHours.Name = "grpHours";
            this.grpHours.Size = new System.Drawing.Size(135, 49);
            this.grpHours.TabIndex = 7;
            this.grpHours.TabStop = false;
            // 
            // rhours1
            // 
            this.rhours1.AutoSize = true;
            this.rhours1.Location = new System.Drawing.Point(6, 9);
            this.rhours1.Name = "rhours1";
            this.rhours1.Size = new System.Drawing.Size(46, 17);
            this.rhours1.TabIndex = 0;
            this.rhours1.TabStop = true;
            this.rhours1.Text = "5-10";
            this.rhours1.UseVisualStyleBackColor = true;
            // 
            // rhours2
            // 
            this.rhours2.AutoSize = true;
            this.rhours2.Location = new System.Drawing.Point(65, 9);
            this.rhours2.Name = "rhours2";
            this.rhours2.Size = new System.Drawing.Size(52, 17);
            this.rhours2.TabIndex = 1;
            this.rhours2.TabStop = true;
            this.rhours2.Text = "11-20";
            this.rhours2.UseVisualStyleBackColor = true;
            // 
            // rhours3
            // 
            this.rhours3.AutoSize = true;
            this.rhours3.Location = new System.Drawing.Point(6, 32);
            this.rhours3.Name = "rhours3";
            this.rhours3.Size = new System.Drawing.Size(52, 17);
            this.rhours3.TabIndex = 2;
            this.rhours3.TabStop = true;
            this.rhours3.Text = "21-30";
            this.rhours3.UseVisualStyleBackColor = true;
            // 
            // rhours4
            // 
            this.rhours4.AutoSize = true;
            this.rhours4.Location = new System.Drawing.Point(65, 32);
            this.rhours4.Name = "rhours4";
            this.rhours4.Size = new System.Drawing.Size(52, 17);
            this.rhours4.TabIndex = 3;
            this.rhours4.TabStop = true;
            this.rhours4.Text = "31-40";
            this.rhours4.UseVisualStyleBackColor = true;
            // 
            // lblWorkHours
            // 
            this.lblWorkHours.AutoSize = true;
            this.lblWorkHours.Location = new System.Drawing.Point(12, 111);
            this.lblWorkHours.Name = "lblWorkHours";
            this.lblWorkHours.Size = new System.Drawing.Size(72, 13);
            this.lblWorkHours.TabIndex = 8;
            this.lblWorkHours.Text = "Hours/Week:";
            // 
            // grpStatus
            // 
            this.grpStatus.Controls.Add(this.rNew);
            this.grpStatus.Controls.Add(this.rExperienced);
            this.grpStatus.Location = new System.Drawing.Point(58, 152);
            this.grpStatus.Name = "grpStatus";
            this.grpStatus.Size = new System.Drawing.Size(145, 29);
            this.grpStatus.TabIndex = 9;
            this.grpStatus.TabStop = false;
            // 
            // rNew
            // 
            this.rNew.AutoSize = true;
            this.rNew.Location = new System.Drawing.Point(0, 9);
            this.rNew.Name = "rNew";
            this.rNew.Size = new System.Drawing.Size(47, 17);
            this.rNew.TabIndex = 0;
            this.rNew.TabStop = true;
            this.rNew.Text = "New";
            this.rNew.UseVisualStyleBackColor = true;
            // 
            // rExperienced
            // 
            this.rExperienced.AutoSize = true;
            this.rExperienced.Location = new System.Drawing.Point(53, 9);
            this.rExperienced.Name = "rExperienced";
            this.rExperienced.Size = new System.Drawing.Size(84, 17);
            this.rExperienced.TabIndex = 1;
            this.rExperienced.TabStop = true;
            this.rExperienced.Text = "Experienced";
            this.rExperienced.UseVisualStyleBackColor = true;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(12, 161);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(40, 13);
            this.lblStatus.TabIndex = 10;
            this.lblStatus.Text = "Status:";
            // 
            // lstResults
            // 
            this.lstResults.FormattingEnabled = true;
            this.lstResults.Location = new System.Drawing.Point(15, 244);
            this.lstResults.Name = "lstResults";
            this.lstResults.Size = new System.Drawing.Size(210, 121);
            this.lstResults.TabIndex = 11;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(58, 184);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(145, 51);
            this.btnSubmit.TabIndex = 12;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(255, 387);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lstResults);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.grpStatus);
            this.Controls.Add(this.lblWorkHours);
            this.Controls.Add(this.grpHours);
            this.Controls.Add(this.lblEvents);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.grpEvents);
            this.Controls.Add(this.txtName);
            this.Name = "Form1";
            this.Text = "Event Form";
            this.grpEvents.ResumeLayout(false);
            this.grpEvents.PerformLayout();
            this.grpHours.ResumeLayout(false);
            this.grpHours.PerformLayout();
            this.grpStatus.ResumeLayout(false);
            this.grpStatus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.GroupBox grpEvents;
        private System.Windows.Forms.CheckBox checkBoxBratFry;
        private System.Windows.Forms.CheckBox checkBoxWalkathon;
        private System.Windows.Forms.CheckBox checkBoxBakeSale;
        private System.Windows.Forms.CheckBox checkBoxGolfing;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblEvents;
        private System.Windows.Forms.GroupBox grpHours;
        private System.Windows.Forms.RadioButton rhours1;
        private System.Windows.Forms.RadioButton rhours2;
        private System.Windows.Forms.RadioButton rhours3;
        private System.Windows.Forms.RadioButton rhours4;
        private System.Windows.Forms.Label lblWorkHours;
        private System.Windows.Forms.GroupBox grpStatus;
        private System.Windows.Forms.RadioButton rNew;
        private System.Windows.Forms.RadioButton rExperienced;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ListBox lstResults;
        private System.Windows.Forms.Button btnSubmit;
    }
}
