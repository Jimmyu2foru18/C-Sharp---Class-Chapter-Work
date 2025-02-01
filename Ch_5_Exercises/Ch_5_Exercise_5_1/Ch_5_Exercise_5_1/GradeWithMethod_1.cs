using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ch_5_Exercise_5_1
{
    public partial class GradeWithMethod_1 : Form
    {
        public GradeWithMethod_1()
        {
            InitializeComponent();
        }

        private void btnComputeGrade_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtScore.Text))
            {
                int score = int.Parse(txtScore.Text);
                string grade = ComputeGrade(score);
                MessageBox.Show("The grade is: " + grade, "Final Grade");
            }
            else
            {
                MessageBox.Show("Please enter a score first.");
            }
        }

        private string ComputeGrade(int score)
        {
            if (score >= 90)
            {
                return "A";
            }
            else if (score >= 80)
            {
                return "B";
            }
            else if (score >= 70)
            {
                return "C";
            }
            else if (score >= 60)
            {
                return "D";
            }
            else
            {
                return "F";
            }
        }
    }
}
