using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ch_4_Exercise_4_4
{
    public partial class fmProjectThePopulation : Form
    {
        public fmProjectThePopulation()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            lstResults.Items.Clear();

            int currentPopulation = int.Parse(txtCurrentPopulation.Text);
            int numberOfYears = int.Parse(txtNumberOfYears.Text);
            double growthRate = double.Parse(txtGrowthRate.Text) / 100;

            lstResults.Items.Add($"Year 1: {currentPopulation}");

            for (int year = 2; year <= numberOfYears; year++)
            {
                currentPopulation = (int)(currentPopulation * (1 + growthRate));
                lstResults.Items.Add($"Year {year}: {currentPopulation}");
            }
        }
    }
}
