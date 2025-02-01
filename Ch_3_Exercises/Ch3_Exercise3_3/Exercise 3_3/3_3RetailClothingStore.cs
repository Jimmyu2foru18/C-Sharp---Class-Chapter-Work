using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise_3_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // Get the total sales 
            double totalSales = double.Parse(txtTotalSales.Text);

            // Check if the customer has coupon
            bool hasCoupon = chkCoupon.Checked;

            // Calculate the coupon
            double couponDiscount = hasCoupon ? 10 : 0;

            // Apply the coupon
            double salesAfterCoupon = totalSales - couponDiscount;

            // Calculate the sales discount 
            double salesDiscount = 0;
            if (salesAfterCoupon >= 100)
            {
                salesDiscount = salesAfterCoupon * 0.2;
            }
            else if (salesAfterCoupon >= 50)
            {
                salesDiscount = salesAfterCoupon * 0.1;
            }
            //Get the subtotal
            double subtotal = salesAfterCoupon - salesDiscount;
            // Display results
            lblTotalSales.Text = "Total Sales: " + totalSales.ToString("C");
            lblCouponAmount.Text = "Coupon Amount: " + couponDiscount.ToString("C");
            lblDiscount.Text = "Discount: " + salesDiscount.ToString("C");
            lblSubtotal.Text = "Subtotal:" + subtotal.ToString("C");
            //or in a list box
            listBox1.Items.Add("Total Sales: $" + totalSales.ToString());
            listBox1.Items.Add("Coupon Amount: $" + couponDiscount.ToString());
            listBox1.Items.Add("Discount: $" + salesDiscount.ToString());
            listBox1.Items.Add("Subtotal: $" + subtotal.ToString());
            listBox1.Items.Add("");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            //clear labels
            lblTotalSales.Text = string.Empty;
            lblCouponAmount.Text = string.Empty;
            lblDiscount.Text = string.Empty;
            lblSubtotal.Text = string.Empty;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
