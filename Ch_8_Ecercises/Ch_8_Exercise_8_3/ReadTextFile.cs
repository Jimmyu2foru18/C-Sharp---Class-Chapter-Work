using System;
using System.IO;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;

partial class ReadTextFile : Form
{
    private int score1;
    private int score2;
    private string name;

    public ReadTextFile()
    {
        InitializeComponent();

        // Read the text file and store lines
        lines = File.ReadAllLines("PercentScores.txt");

        // Display the first line
        ProcessLine();
    }

    private void ProcessLine()
    {
        if (currentIndex < lines.Length)
        {
            // Split the line by comma to get name, score1, and score2
            string[] parts = lines[currentIndex].Split(',');
            string name = parts[0].Trim();
            int score1 = int.Parse(parts[1].Trim());
            int score2 = int.Parse(parts[2].Trim());

            // Calculate percent score
            double percentScore = (score1 + score2) / 2.0;

            // Add the information to lstResults
            lstResults.Items.Add($"Name: {name}");
            lstResults.Items.Add($"Score 1: {score1}");
            lstResults.Items.Add($"Score 2: {score2}");
            lstResults.Items.Add("");
            lstResults.Items.Add($"Percent: {percentScore}%\n\n");
            lstResults.Items.Add("");

            // Move to the next line
            currentIndex++;
        }
        else
        {
            // If all lines are processed, disable the button
            ComputePercent.Enabled = false;
        }
    }

    private void ComputePercent_Click(object sender, EventArgs e)
    {
        // Process the next line
        ProcessLine();
    }
}