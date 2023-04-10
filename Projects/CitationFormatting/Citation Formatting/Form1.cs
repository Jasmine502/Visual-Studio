using System;
using System.Diagnostics;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;

namespace Citation_Formatting
{
    public partial class Form1 : Form
    {
        private string dev, year, title, pub, link, date, citation;

        public Form1()
        {
            InitializeComponent();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.google.com/search?q=" + titleTB.Text + " video game");
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            dev = "";
            devTB.Clear();
            year = "";
            yearTB.Clear();
            title = "";
            titleTB.Clear();
            pub = "";
            pubTB.Clear();
            link = "";
            linkTB.Clear();
            date = "";
            datePkr.Value = DateTime.Today;
        }

        private void formatBtn_Click(object sender, EventArgs e)
        {
            dev = devTB.Text;
            year = yearTB.Text;
            title = titleTB.Text;
            pub = pubTB.Text;
            link = linkTB.Text;
            date = datePkr.Text;

            citation = $"{dev} ({year}) {title} [Video game]. {pub}. Available at: {link} (Accessed: {date}).";
            citationTB.Text = citation;
        }

        private void copyBtn_Click(object sender, EventArgs e)
        {
            if (citationTB.Text != "")
            {
                Clipboard.SetText(citation);
                MessageBox.Show("Citation Copied!");
            }
        }
    }
}
