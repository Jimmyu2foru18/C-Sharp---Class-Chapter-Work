using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ch_5_Methods_HR_
{
    public partial class Ch_5_Heart_Rate : Form
    {
        public Ch_5_Heart_Rate()
        {
            InitializeComponent();
        }

        private void btnCompute_Click(object sender, EventArgs e)

        {

            if (!string.IsNullOrEmpty(txtRestingHeartRate.Text) && !string.IsNullOrEmpty(txtAge.Text))
            
            {
                
                try
                {

                    int restingRate = int.Parse(txtRestingHeartRate.Text);
                    int age = int.Parse(txtAge.Text);

                    int maxHeartRate = 220-age;
                    int trainingRate = (int)(0.6F * (maxHeartRate - restingRate) + restingRate);

                    MessageBox.Show($"Your training heart rate is: {trainingRate} beats per minute", "Heart Rate");
                }

                
                catch (FormatException)
                
                {
                
                    MessageBox.Show("Please enter valid values for resting heart rate and age.", "Error");
                }

            
            }
        
        }

        private void btnAbout_Click(object sender, EventArgs e)
        
        {

            MessageBox.Show("Training Heart Rate \nBy: James M.", "About");
        }

    }
}
