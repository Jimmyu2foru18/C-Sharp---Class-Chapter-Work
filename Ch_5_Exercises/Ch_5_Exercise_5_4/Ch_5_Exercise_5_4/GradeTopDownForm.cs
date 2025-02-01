using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ch_5_Exercise_5_4
{
    public partial class GradeTopDownForm : Form
    {
        public GradeTopDownForm()
        {
            InitializeComponent();
        }

        private void btnComputeGrade_Click(object sender, EventArgs e)
        {
            ValidScore();
        }

        private void ValidScore()
        {
            string name = txtName.Text;
            if (int.TryParse(txtScore.Text, out int score))
            {
                if (score >= 0 && score <= 100)
                {
                    string grade = Grade(score);
                    Display(name, grade);
                }
                else
                {
                    MessageBox.Show("Score must be between 0 - 100.");
                }
            }
        }

        private string Grade(int score)
        {
            string grade = "";
            if (score >= 90)
            {
                grade = "A";
            }
            else if (score >= 80)
            {
                grade = "B";
            }
            else if (score >= 70)
            {
                grade = "C";
            }
            else
            {
                grade = "Below C";
            }
            return grade;
        }

        private void Display(string name, string grade)
        {
            MessageBox.Show($"Name: {name} \nGrade: {grade}");
        }
    }
}
