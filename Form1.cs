using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace FileSearchEngine
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ResultsRichText.Text = "Enter a search term and directory path; then click <Search> to begin.";
            try
            {
                PathTextBox.Text = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            }
            catch
            {
                PathTextBox.Text = "";
            }
        }

        private void BrowseButton_Click(object sender, EventArgs e)
        {

            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                PathTextBox.Text = fbd.SelectedPath;
            }

        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            // check for valid search term
            if (TermTextBox.TextLength == 0)
            {
                MessageBox.Show("Please enter a valid search term.", "", MessageBoxButtons.OK);
                return;
            }

            // Check for valid directory
            bool directoryExists = Directory.Exists(PathTextBox.Text);

            if (!directoryExists)
            {
                MessageBox.Show("Please select a valid directory.", "", MessageBoxButtons.OK);
                return;
            }

            // Perform search
            string searchTerm = TermTextBox.Text;
            ResultsRichText.Clear();
            if (ContainsRadioButton.Checked)
            {
                searchTerm = $"*{searchTerm}*";
            }
            else if (EndsWithRadioButton.Checked)
            {
                searchTerm = $"*{searchTerm}";
            }
            else
            {
                searchTerm = $"{searchTerm}*";
            }
            string directory = PathTextBox.Text;
            List<string> validDirs = GetSearchableDirs(directory);
            List<string> results = GetAllFiles(validDirs, searchTerm);

            foreach (string r in results)
            {
                ResultsRichText.AppendText(r + "\n");
            }

            ResultsRichText.AppendText($"\nTOTAL RESULTS: {results.Count}");
            ResultsRichText.ScrollToCaret();


        }

        public static List<string> GetAllFiles(List<string> dirList, string searchTerm)
        {
            List<string> fileList = new List<string>();

            foreach (string d in dirList)
            {

                try
                {
                    string[] results = Directory.GetFiles(d, searchTerm);
                    if (results.Length > 0)
                    {
                        fileList.AddRange(results);
                    }
                }
                catch (System.UnauthorizedAccessException)
                {
                    continue;
                }
            }
            return fileList;
        }

        public static List<string> GetSearchableDirs(string dirPath)
        {
            List<string> directoryList = new List<string>();
            try
            {
                string[] directories = Directory.GetDirectories(dirPath);
                if (directories.Length > 0)
                {
                    directoryList.AddRange(directories);
                    foreach (string d in directories)
                    {
                        directoryList.AddRange(GetSearchableDirs(d));
                    }
                }
            }
            catch (System.UnauthorizedAccessException)
            {
                return new List<string>();
            }
            return directoryList;
        }

        }
    }
}
