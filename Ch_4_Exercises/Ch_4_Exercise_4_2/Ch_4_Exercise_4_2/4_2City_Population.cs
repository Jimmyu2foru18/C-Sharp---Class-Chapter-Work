using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ch_4_Exercise_4_2
{
    public partial class fmCityPopulation : Form
    {
        public fmCityPopulation()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int currentPopulation, targetPopulation, year;
            double growthRate;

            if (!int.TryParse(txtCurrentPopulation.Text, out currentPopulation) ||
                !int.TryParse(txtTargetPopulation.Text, out targetPopulation) ||
                !double.TryParse(txtGrowthRate.Text, out growthRate))
            {
                MessageBox.Show("Invalid input");
                return;
            }

            if (currentPopulation >= targetPopulation || growthRate <= 0)
            {
                MessageBox.Show("Invalid input");
                return;
            }

            year = 1;
            int projectedPopulation = currentPopulation;

            lstResults.Items.Clear();

            while (projectedPopulation < targetPopulation)
            {
                lstResults.Items.Add($"Year: {year}, Population: {projectedPopulation}");
                projectedPopulation = (int)(projectedPopulation * (1 + growthRate));
                year++;
            }

            lstResults.Items.Add($"The population will exceed {targetPopulation} in {year - 1} years");
        }
    }
}
