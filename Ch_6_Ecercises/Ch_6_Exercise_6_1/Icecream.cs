using System;
using System.IO;
using System.Windows.Forms;

namespace Ch_6_Exercise_6_1
{
    public partial class Icecream : Form
    {
        //Cost each In decimal form 
        private const decimal IceCreamCost = 3.50m;
        private const decimal CustardCost = 3.75m;
        private const decimal YogurtCost = 4.00m;
        private const decimal NutsCost = 0.50m;

        private string[] employees; // Array to store employees

        public Icecream()
        {
            InitializeComponent();

            //ComboBox For What desert
            comboBoxDesert.Items.AddRange(new object[] { "Custard", "Ice Cream", "Yogurt" });

            scrollBarScoops.Scroll += scrollBar_Scroll;

            // Load employees from file
            LoadEmployees();
        }

        private void scrollBar_Scroll(object sender, ScrollEventArgs e)
        {
            lblScoops.Text = "Number of Scoops: " + scrollBarScoops.Value.ToString();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            decimal desertCost = 0m;
            // Determine the cost of the sundae
            switch (comboBoxDesert.SelectedItem.ToString())
            {
                case "Ice Cream":
                    desertCost = IceCreamCost;
                    break;
                case "Custard":
                    desertCost = CustardCost;
                    break;
                case "Yogurt":
                    desertCost = YogurtCost;
                    break;

            }

            // Calculate the amount due 
            decimal amountDue = (desertCost * scrollBarScoops.Value) + (checkBoxNuts.Checked ? NutsCost : 0m);

            // Select a random employee
            Random rnd = new Random();
            int index = rnd.Next(0, employees.Length);
            string employeeName = employees[index];

            // Add employee name and amount due to list box
            lstResults.Items.Add(employeeName);
            lstResults.Items.Add("$" + amountDue.ToString("0.00"));
        }

        private void LoadEmployees()
        {

            employees = File.ReadAllLines("Employees.txt");
        // remember click on txt file and click Copy always or wont work
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click_1(object sender, EventArgs e)
        {
            lstResults.Items.Clear();
        }
    }
}
