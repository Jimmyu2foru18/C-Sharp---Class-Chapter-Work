using System;
using System.Windows.Forms;

namespace DataTypes2_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            DateTime dateRented = dateTimePickerRented.Value.Date;
            DateTime dateReturned = dateTimePickerReturned.Value.Date;
            double chargePerDay = Convert.ToDouble(txtChargePerDay.Text);
            DateTime timeRented = dateTimePickerRentedTime.Value;
            DateTime timeReturned = dateTimePickerReturnedTime.Value;

            TimeSpan rentalDuration = dateReturned - dateRented;
            double daysRented = rentalDuration.TotalDays;
            double hoursRented = (timeReturned - timeRented).TotalHours;

            double totalRentalCost = CalculateTotalRentalCost(daysRented, chargePerDay, hoursRented);

            listBoxResults.Items.Clear();
            listBoxResults.Items.Add($"Days Rented: {daysRented}");
            listBoxResults.Items.Add($"Total Rental Cost: {totalRentalCost.ToString("0.00")}");
        }

        private double CalculateTotalRentalCost(double daysRented, double chargePerDay, double hoursRented)
        {
            double totalRentalCost = daysRented * chargePerDay;

            if (hoursRented > 0 && hoursRented < 24)
            {
                double fractionalDays = hoursRented / 24;
                totalRentalCost += fractionalDays * chargePerDay;
            }

            return totalRentalCost;
        }
    }
}
