using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TotalCost
{
    public partial class TotalCost : Form
    {
        private const double SalesTaxRate = 0.06;
        public TotalCost()
        {
            InitializeComponent();
        }

        private void ComputeCost_Click(object sender, EventArgs e)
        {
                try
                {
                    if (!double.TryParse(CostOfLaborAmmount.Text, out double laborCost) || laborCost < 0)
                    {
                        MessageBox.Show("Invalid Labor Cost");
                        return;
                    }
                    if (!double.TryParse(MaterialsAmmount.Text, out double materialCost) || materialCost < 0)
                    {
                        MessageBox.Show("Invalid Material Cost");
                        return;
                    }
                    //Subtotal Sales Tax and Total
                    double subtotal = laborCost + materialCost;
                    double salesTax = subtotal * SalesTaxRate;
                    double total = subtotal + salesTax;
                    //ListBox
                    TotalListBox.Items.Clear();
                    TotalListBox.Items.Add($"Subtotal:   {subtotal:C}");
                    TotalListBox.Items.Add($"Sales Tax:  {salesTax:C}");
                    TotalListBox.Items.Add($"Total Cost: {total:C}");
                }
                catch (Exception ex)
                {
                MessageBox.Show($"An unexpected error occurred: {ex.Message}","Error");
            }
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            CostOfLaborAmmount.Clear();
            MaterialsAmmount.Clear();
            TotalListBox.Items.Clear();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TotalListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
