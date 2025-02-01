using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TotalCost1_3
{
    public partial class TotalCost1_3 : Form
    {
        private const double SalesTaxRate = 0.06;
        public TotalCost1_3()
        {
            InitializeComponent();
        }

        private void ComputeCost_Click(object sender, EventArgs e)
        {
            try
            {
                if (!double.TryParse(costOfLabor1.Text, out double costOfLabor) || costOfLabor < 0)
                {
                    MessageBox.Show("Please enter a valid positive cost of labor.", "Invalid Cost of Labor", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!double.TryParse(Material1.Text, out double materialCost) || materialCost < 0)
                {
                    MessageBox.Show("Please enter a valid positive material cost.", "Invalid Material Cost", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                double subtotal = costOfLabor + materialCost;
                double salesTax = subtotal * SalesTaxRate;
                double totalCost = subtotal + salesTax;

                Subtotal1.Text = subtotal.ToString("C");
                SalesTax1.Text = salesTax.ToString("C");
                TotalCost1.Text = totalCost.ToString("C");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An unexpected error occurred: {ex.Message}", "Error");
            }
        }
        private void Clear_Click(object sender, EventArgs e)
        {
            costOfLabor1.Clear();
            Material1.Clear();
            Subtotal1.Clear();
            SalesTax1.Clear();
            TotalCost1.Clear();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
