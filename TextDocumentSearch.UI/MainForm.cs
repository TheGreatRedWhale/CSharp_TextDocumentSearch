using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TextDocumentSearch;
using System.IO;
using System.Media;

namespace TextDocumentSearch.UI
{
    public partial class MainForm : Form
    {
        string lastFilePath = Directory.GetCurrentDirectory() + "\\Test.txt";
        string[] lines = new string[] { };

        public MainForm()
        {
            InitializeComponent();
            // Set filepathTextBox.Text and openFileDialog.FileName to the default value.
            filepathTextBox.Text = lastFilePath;
            openFileDialog.FileName = lastFilePath;
        }

        // CUSTOM METHODS -----------------------------------------------------
        private void UpdateResultsListBox()
        {
            resultsListBox.Items.Clear();
            try
            {
                lines = Logic.TextFileConverter.GetLines(filepathTextBox.Text);
                foreach (string line in lines)
                {
                    if (line.ToUpper().Contains(keywordTextBox.Text.ToUpper()))
                    {
                        resultsListBox.Items.Add(line);
                    }
                }
            }
            catch (FileNotFoundException e)
            {
                MessageBox.Show(e.Message, "File Not Found",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void CheckValidFile()
        {
            try
            {
                if (!(Path.GetExtension(filepathTextBox.Text).EndsWith(".txt") || Path.GetExtension(filepathTextBox.Text).EndsWith(".csv")))
                {
                    throw new NotSupportedException("Only \'.txt\' and \'.csv\' filetypes are supported.");
                }
                else
                {
                    lastFilePath = filepathTextBox.Text;
                }
            }
            catch (FileNotFoundException e)
            {
                SystemSounds.Exclamation.Play();
                MessageBox.Show(e.Message, "File Not Found",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                filepathTextBox.Text = lastFilePath;
            }
            catch (NotSupportedException e)
            {
                SystemSounds.Exclamation.Play();
                MessageBox.Show(e.Message, "File Type Not Supported",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                filepathTextBox.Text = lastFilePath;
            }
        }

        // GENERATED METHODS --------------------------------------------------

        private void browseButton_Click(object sender, EventArgs e)
        {
            openFileDialog.FileName = filepathTextBox.Text;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Set filepathTextBox.Text to the selected filepath. 
                filepathTextBox.Text = openFileDialog.FileName;
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            UpdateResultsListBox();
        }

        private void keywordTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                UpdateResultsListBox();
                e.Handled = e.SuppressKeyPress = true;
            }
        }

        private void filepathTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //CheckValidFile();
                e.Handled = e.SuppressKeyPress = true;
            }
        }
    }
}
