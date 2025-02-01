using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ch3_Exercise3_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // Step 1: Parse the input values
            int numberOfDays = int.Parse(txtNumberOfDays.Text);
            string customerStatus = txtCustomerStatus.Text.ToUpper(); // Convert to uppercase to handle case sensitivity
            double roomRate = double.Parse(txtRoomRate.Text);

            // Step 2: Determine the discount percentage
            double discountPercentage = 0;
            if (customerStatus == "GOLD")
            {
                discountPercentage = numberOfDays >= 5 ? 0.30 : 0.20;
            }
            else if (customerStatus == "PLATINUM")
            {
                discountPercentage = numberOfDays >= 5 ? 0.40 : 0.30;
            }
            else
            {
                MessageBox.Show("Invalid customer status. Please enter 'Gold' or 'Platinum'.", "Input Error");
                return;
            }

            // Step 3: Calculate the total cost, discount, and net amount
            double totalCost = roomRate * numberOfDays;
            double discount = totalCost * discountPercentage;
            double netAmount = totalCost - discount;

            // Step 4: Display the results
            lblTotalCost.Text = "  Total Cost: " + totalCost.ToString("C");
            lblDiscount.Text = "  Discount: " + discount.ToString("C");
            lblNetAmount.Text = "  Net Amount: " + netAmount.ToString("C");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lblTotalCost.Text = string.Empty;
            lblDiscount.Text = string.Empty;
            lblNetAmount.Text = string.Empty;
        }
    }
}
