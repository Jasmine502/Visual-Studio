using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace Citation_Formatting
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(titleTB.Text))
            {
                Process.Start("https://www.google.com/search?q=" + Uri.EscapeDataString(titleTB.Text + " video game"));
            }
            else
            {
                MessageBox.Show("Please enter a title to search.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            foreach (Control control in Controls)
            {
                if (control is TextBox textBox)
                {
                    textBox.Clear();
                }
                else if (control is DateTimePicker dateTimePicker)
                {
                    dateTimePicker.Value = DateTime.Today;
                }
            }
        }

        private void formatBtn_Click(object sender, EventArgs e)
        {
            string dev = devTB.Text.Trim();
            string year = yearTB.Text.Trim();
            string title = titleTB.Text.Trim();
            string pub = pubTB.Text.Trim();
            string link = linkTB.Text.Trim();
            string date = datePkr.Text;

            if (string.IsNullOrWhiteSpace(dev) || string.IsNullOrWhiteSpace(year) || string.IsNullOrWhiteSpace(title) || string.IsNullOrWhiteSpace(pub) || string.IsNullOrWhiteSpace(link))
            {
                MessageBox.Show("All fields must be filled to format the citation.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string citation = $"{dev} ({year}) {title} [Video game]. {pub}. Available at: {link} (Accessed: {date}).";
            citationTB.Text = citation;
        }

        private void copyBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(citationTB.Text))
            {
                Clipboard.SetText(citationTB.Text);
                MessageBox.Show("Citation copied to clipboard!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No citation to copy. Please format a citation first.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
