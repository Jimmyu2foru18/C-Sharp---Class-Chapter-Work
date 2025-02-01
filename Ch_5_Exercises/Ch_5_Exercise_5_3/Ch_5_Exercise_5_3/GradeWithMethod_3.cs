using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ch_5_Exercise_5_3
{
    public partial class GradeWithMethod_3 : Form
    {
        public GradeWithMethod_3()
        {
            InitializeComponent();
        }


        private void ComputeGrade(int score, out string grade)
        {
            if (score >= 90)
                grade = "\nYour Final Grade is: A";
            else if (score >= 80)
                grade = "\nYour Final Grade is: B";
            else if (score >= 70)
                grade = "\nYour Final Grade is: C";
            else if (score >= 60)
                grade = "\nYour Final Grade is: D";
            else
                grade = "\nYour Final Grade is: F";
        }

        private void btnComputeGrade_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtScore.Text, out int score))
            {
                string grade;
                ComputeGrade(score, out grade);
                lblLetterGrade.Text = grade;
            }
            else
            {
                MessageBox.Show("Please enter a valid score 0-100", "Error");
            }
        }
    }
}
