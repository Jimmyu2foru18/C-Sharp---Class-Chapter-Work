using System;
using System.IO;
using System.Windows.Forms;

namespace VendorLookupApp
{
    public partial class MainForm : Form
    {
        private string[] vendorNames;
        private string[] phoneNumbers;
        private const int DefaultArraySize = 10; // Default initial size of arrays

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadDataFromFile("Vendor.txt");
        }

        private void LoadDataFromFile(string filename)
        {
            // Arrays for vendor names and phone numbers
            vendorNames = new string[DefaultArraySize];
            phoneNumbers = new string[DefaultArraySize];
            int currentIndex = 0;

            // Vendor.txt file
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Vendor.txt");

            try
            {
                // Read all lines from the Vendor.txt file
                string[] lines = File.ReadAllLines(filePath);

                // To get information from each line
                foreach (string line in lines)
                {
                    // Split the line by commas to get the field's
                    string[] fields = line.Split(',');

                    // If the current index is longer than the arrays it resize them
                    if (currentIndex >= vendorNames.Length)
                    {
                        Array.Resize(ref vendorNames, vendorNames.Length * 2);
                        Array.Resize(ref phoneNumbers, phoneNumbers.Length * 2);
                    }

                    // Store the name and phone number as 2 seperate arrays
                    vendorNames[currentIndex] = fields[1];
                    phoneNumbers[currentIndex] = fields[6];

                    // Output Results
                    Console.WriteLine($"Loaded vendor: {vendorNames[currentIndex]}, Phone: {phoneNumbers[currentIndex]}");

                    //next index
                    currentIndex++;
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine($"File {filePath} not found.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error occurred: {ex.Message}");
            }
        }

        private void btnLookup_Click(object sender, EventArgs e)
        {
            string searchVendor = txtVendorName.Text;
            int index = Array.IndexOf(vendorNames, searchVendor);
            if (index != -1)
            {
                string phoneNumber = phoneNumbers[index];
                MessageBox.Show($"Phone number for {searchVendor} :  {phoneNumber} ","Phone Number");
            }
            else
            {
                MessageBox.Show($"Vendor '{searchVendor}' not found.");
            }
        }
    }
}

