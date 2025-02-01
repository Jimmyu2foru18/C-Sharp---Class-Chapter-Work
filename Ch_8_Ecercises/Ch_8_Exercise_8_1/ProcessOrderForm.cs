using System;
using System.IO;
using System.Windows.Forms;

namespace Ch_8_Exercise_8_1
{
    public partial class ProcessOrderForm : Form
    {
        public ProcessOrderForm()
        {
            InitializeComponent();
        }

        private void ProcessOrderForm_Load(object sender, EventArgs e)
        {
            // Call this method when the form loads
            LoadOrderData();
        }

        private void LoadOrderData()
        {
            // Specify the file path
            string filePath = "Order.txt";

            try
            {
                // Add header line with increased spacing
                string header = $"{"Cust#",-10} {"Order#",-12} {"OrderQty",-15} {"UnitPrice",-15}       {"ExtendedCost",-15}";
                ListBoxOrders.Items.Add(header);

                // Read all lines from the file
                string[] lines = File.ReadAllLines(filePath);

                // Process each line
                foreach (string line in lines)
                {
                    // Split the line by commas
                    string[] data = line.Split(',');

                    // Parse data
                    string custNumber = data[0];
                    string orderNumber = data[1];
                    int orderQty = int.Parse(data[2]);
                    double unitPrice = double.Parse(data[3]);

                    // Calculate ExtendedCost
                    double extendedCost = orderQty * unitPrice;

                    // Format the output string with increased spacing
                    string formattedOutput = $"{custNumber,-10} {orderNumber,-12} {orderQty,-15}         {unitPrice,-22:C} {extendedCost,-28:C}";

                    // Add the formatted string to the ListBox
                    ListBoxOrders.Items.Add(formattedOutput);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}