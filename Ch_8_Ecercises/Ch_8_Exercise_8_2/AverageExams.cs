using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Ch_8_Exercise_8_2
{
    public partial class AverageExams : Form
    {
        private ListView listView;

        public AverageExams()
        {
            InitializeComponent();
        }

        private void InitializeUI()
        {
            // Create a ListView control
            listView = new ListView();
            listView.Dock = DockStyle.Fill;
            listView.View = View.Details;
            listView.Columns.Add("Name", 120);
            listView.Columns.Add("Exam Score", 100);
            listView.Columns.Add("Class Average", 100);

            // Add ListView to the form
            this.Controls.Add(listView);

            // Add button to trigger data display
            Button btnAboveAvgForExam1 = new Button();
            btnAboveAvgForExam1.Text = "Show Above Avg for Exam 1";
            btnAboveAvgForExam1.Click += BtnAboveAvgForExam1_Click;
            btnAboveAvgForExam1.Dock = DockStyle.Top;
            this.Controls.Add(btnAboveAvgForExam1);
        }

        private void BtnAboveAvgForExam1_Click(object sender, EventArgs e)
        {
            // Step 1: Read the file containing student names and their exam 1 scores.
            // Assuming you have a file named "exam_scores.txt" in the same directory as your application.
            string filePath = "exam_scores.txt";

            // Step 2: Store the exam 1 scores in an array.
            List<Tuple<string, int>> examScores = ReadExamScores(filePath);

            // Step 3: Calculate the average score for exam 1.
            double averageExam1Score = examScores.Select(tuple => tuple.Item2).Average();

            // Step 4: Display the data in the ListView
            DisplayDataInListView(examScores, averageExam1Score);
        }

        private List<Tuple<string, int>> ReadExamScores(string filePath)
        {
            List<Tuple<string, int>> examScores = new List<Tuple<string, int>>();

            try
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    while (!reader.EndOfStream)
                    {
                        string line = reader.ReadLine();
                        string[] parts = line.Split(',').Select(part => part.Trim()).ToArray();
                        string name = parts[0];
                        int score = int.Parse(parts[1]);
                        examScores.Add(Tuple.Create(name, score));
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error reading file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return examScores;
        }

        private void DisplayDataInListView(List<Tuple<string, int>> examScores, double averageExam1Score)
        {
            // Clear previous data
            listView.Items.Clear();

            // Display data in ListView
            foreach (var tuple in examScores)
            {
                ListViewItem item = new ListViewItem(tuple.Item1);
                item.SubItems.Add(tuple.Item2.ToString());
                item.SubItems.Add(averageExam1Score.ToString());
                listView.Items.Add(item);
            }
        }
    }
}
