namespace Ch_8_Exercise_8_1
{
        partial class ProcessOrderForm
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
            this.ListBoxOrders = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // ListBoxOrders
            // 
            this.ListBoxOrders.FormattingEnabled = true;
            this.ListBoxOrders.HorizontalScrollbar = true;
            this.ListBoxOrders.Location = new System.Drawing.Point(11, 15);
            this.ListBoxOrders.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ListBoxOrders.Name = "ListBoxOrders";
            this.ListBoxOrders.Size = new System.Drawing.Size(341, 186);
            this.ListBoxOrders.TabIndex = 0;
            // 
            // ProcessOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 216);
            this.Controls.Add(this.ListBoxOrders);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ProcessOrderForm";
            this.Text = "Process Order Form";
            this.Load += new System.EventHandler(this.ProcessOrderForm_Load);
            this.ResumeLayout(false);

            }

            #endregion

            private System.Windows.Forms.ListBox ListBoxOrders;
        }
    }