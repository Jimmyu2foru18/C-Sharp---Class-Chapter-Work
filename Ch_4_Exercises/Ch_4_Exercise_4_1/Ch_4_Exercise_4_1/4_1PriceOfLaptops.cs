using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ch_4_Exercise_4_1
{
    public partial class txtTargetPrice : Form
    {
        public txtTargetPrice()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // Initialize variables
            double currentPrice = Convert.ToDouble(txtCurrentPrice.Text);
            double targetPrice = Convert.ToDouble(txtTargetPrice1.Text);
            double depreciationRate = 0.10; // 10% rate
            int year = 1;

            // Clear
            lstResults.Items.Clear();

            // Loop
            while (currentPrice >= targetPrice)
            {
                // Year and price
                lstResults.Items.Add($"Year: {year}, Price: ${currentPrice:F2}");

                // Calculate new price
                currentPrice *= (1 - depreciationRate);

                // Increment the year
                year++;
            }

            // Display List
            lstResults.Items.Add($"The price will be under ${targetPrice:F2} in {year} years");
        }
    }
}
