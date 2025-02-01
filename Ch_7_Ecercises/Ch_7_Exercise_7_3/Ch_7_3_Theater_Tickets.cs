using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ch_7_Exercise_7_3
{
    public partial class Ch_7_3_Theater_Tickets : Form
    {
        string[] shows = { "Matinee", "Evening", "Senior Citizen" };
        decimal[] prices = { 5.75m, 8.75m, 6.00m };
        decimal[] markups = { 0.0m, 2.0m, 1.0m }; // Markup amount for each show

        public Ch_7_3_Theater_Tickets()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < shows.Length; i++)
            {
                comboBoxShows.Items.Add(shows[i]);
            }
        }

        private void comboBoxShows_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = comboBoxShows.SelectedIndex;
            if (selectedIndex >= 0 && selectedIndex < shows.Length)
            {
                decimal price = prices[selectedIndex];
                decimal markup = markups[selectedIndex]; // Get the markup for the selected show
                decimal amountDue = price + markup;

                listResults.Items.Clear();
                listResults.Items.Add($"Amount Due: {amountDue:C}");
            }
        }
    }
}
