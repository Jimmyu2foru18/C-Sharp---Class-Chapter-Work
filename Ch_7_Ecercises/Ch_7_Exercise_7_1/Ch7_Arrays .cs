using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ch_7_Exercise_7_1
{
    public partial class Form1 : Form
    {
        string[] monthNames = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
        public Form1()
        {
            

            InitializeComponent();
        }

        private void btnDisplayMonth_Click(object sender, EventArgs e)

        {
            // user input
            int monthNumber;

            // Validate user input
            if (int.TryParse(txtMonthNumber.Text, out monthNumber))
            {
                // Convert the number to an index
                int index = monthNumber - 1;

                // Check if the index is within the valid range
                if (index >= 0 && index < monthNames.Length)
                {
                    // Display the month name in the text box
                    txtMonthName.Text = monthNames[index];
                }
                else
                {
                    // Handle out of range input
                    MessageBox.Show("Enter a number between 1 and 12.", "Invalid Input");
                }
            }
            else
            {
                // Handle invalid input
                MessageBox.Show("Enter a valid number.", "Invalid Input");
            }
        }
    }
}
