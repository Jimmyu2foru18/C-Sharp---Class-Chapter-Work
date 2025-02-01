using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ch_6_Ecercises_6_2
{
    public partial class Ch_6_Event_Registration : Form
    {
        public Ch_6_Event_Registration()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // user inputs
            string name = txtName.Text;
            List<string> events = new List<string>();
            if (checkBoxBratFry.Checked) events.Add("Brat Fry");
            if (checkBoxWalkathon.Checked) events.Add("Walkathon");
            if (checkBoxBakeSale.Checked) events.Add("Bake Sale");
            if (checkBoxGolfing.Checked) events.Add("Golfing");

            string hours = "";
            if (rhours1.Checked) hours = "5-10";
            else if (rhours2.Checked) hours = "11-20";
            else if (rhours3.Checked) hours = "21-30";
            else if (rhours4.Checked) hours = "31-40";

            string status = rNew.Checked ? "New" : "Experienced";

            // results
            lstResults.Items.Clear();
            lstResults.Items.Add($"Name:              - {name}");
            lstResults.Items.Add("Events:");
            foreach (var ev in events)
            {
                lstResults.Items.Add($"                        - {ev}");
            }
            lstResults.Items.Add($"Hours/Week: \n - {hours}");
            lstResults.Items.Add($"Status:             - {status}");
        }
    }
}
