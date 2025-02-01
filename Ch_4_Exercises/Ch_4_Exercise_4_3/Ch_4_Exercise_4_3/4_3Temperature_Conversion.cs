using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ch_4_Exercise_4_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            lstResults.Items.Clear();
            lstResults.Items.Add("---Temperature Conversion Results---");

            for (int fahrenheit = -40; fahrenheit <= 40; fahrenheit += 10)
            {
                double celsius = (fahrenheit - 32) * 5.0 / 9.0;
                string formattedFahrenheit = fahrenheit >= 0 ? $"{fahrenheit:00}" : $"{fahrenheit:00}";
                lstResults.Items.Add($"Fahrenheit: {formattedFahrenheit}            Celsius: {celsius:F2}");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lstResults.Items.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
