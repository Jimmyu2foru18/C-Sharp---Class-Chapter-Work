using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ch1_introProgramming
{
    public partial class IceCreamCost : Form
    {
        double price;
        double scoops;
        double discount;

        public IceCreamCost()
        {
            InitializeComponent();
        }

        private void btnComputeCost_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox1.Text, out price) && double.TryParse(textBox2.Text, out scoops))
            {
                double cost = price * scoops;
                textBox3.Text = cost.ToString("$0.00");
            }
            else
            {
                textBox3.Text = "Invalid input";
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            btnComputeCost_Click(sender, e);
        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            

            if (double.TryParse(textBox1.Text, out price) && double.TryParse(textBox2.Text, out scoops))
            {
                discount = (.25 * price * scoops);
                textBox3.Text = discount.ToString("$0.00");
            }
            else
            {
                textBox3.Text = "Invalid input";
            }

        }
    }
}
