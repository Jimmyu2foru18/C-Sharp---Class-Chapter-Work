using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ch_7_Exercise_7_2
{
    public partial class Ch_7_Monthly_Sales : Form
    {

        int[] unitsSold = { 572, 645, 693, 564, 580, 756, 859, 756, 663, 678, 745, 958 };
        string[] monthNames = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
        string[] months = { "January", "February", "March", "April", "May", "June", "July",
                            "August", "September", "October", "November", "December" };
        public Ch_7_Monthly_Sales()
        {
            InitializeComponent();
        }

        private void btnTopMonths_Click(object sender, EventArgs e)
        {
            // Declare variables
            int highestSale = unitsSold[0];
            int highestSalePosition = 0;

            // Loop through unitsSold array to find the highest sale
            for (int i = 1; i < unitsSold.Length; i++)
            {
                if (unitsSold[i] > highestSale)
                {
                    highestSale = unitsSold[i];
                    highestSalePosition = i;
                }
            }

            // Display the results in the ListBox
            lstResults.Items.Clear(); // Clear previous results
            lstResults.Items.Add($"Highest Sale: {highestSale}");
            lstResults.Items.Add($"Month(s) with Highest Sales: {monthNames[highestSalePosition]}");
        }

        private void btnDisplayUnitsSold_Click(object sender, EventArgs e)
        {
            // Validate user input for month
            if (!int.TryParse(txtMonthName.Text, out int monthNumber) || monthNumber < 1 || monthNumber > 12)
            {
                MessageBox.Show("Please enter a valid month number (1-12).");
                return;
            }

            // Convert month number to month name
            string monthName = months[monthNumber - 1]; // Adjust for zero-based indexing

            // Find the index of the month. Use the index to find units sold
            int monthIndex = Array.IndexOf(months, monthName);

            if (monthIndex >= 0) // if month is not found, index would be -1
            {
                int unitsSoldInMonth = unitsSold[monthIndex]; // find units sold
                lblUnitsSold.Text = unitsSoldInMonth.ToString();
            }
            else
            {
                MessageBox.Show("Month not found");
            }
        }

        private void btnBottomMonths_Click(object sender, EventArgs e)
        {
            // Declare variables
            int lowestSale = unitsSold[0];
            int lowestSalePosition = 0;

            // Loop through unitsSold array to find the lowest sale
            for (int i = 1; i < unitsSold.Length; i++)
            {
                if (unitsSold[i] < lowestSale)
                {
                    lowestSale = unitsSold[i];
                    lowestSalePosition = i;
                }
            }

            // Display the results in the ListBox
            lstResults.Items.Clear(); // Clear previous results
            lstResults.Items.Add($"Lowest Sale: {lowestSale}");
            lstResults.Items.Add($"Month(s) with Lowest Sales: {monthNames[lowestSalePosition]}");
        }
    }

}
