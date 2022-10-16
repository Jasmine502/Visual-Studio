using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Citation_Formatting
{
    public partial class Form1 : Form
    {
        //DEVELOPER (YEAR) TITLE [Video game]. PUBLISHER. Available at: LINK (Accessed: DD/MM/YY)
        public Form1()
        {
            InitializeComponent();
        }
        string dev, year, title, pub, link, date, citation = "";

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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void formatBtn_Click(object sender, EventArgs e)
        {
            dev = devTB.Text;
            year = yearTB.Text;
            title = titleTB.Text;
            pub = pubTB.Text;
            link = linkTB.Text;
            date = datePkr.Text;

            citation = dev + " (" + year + ") " + title + " [Video game]. " + pub + ". Available at: " + link + " (Accessed: " + date + ").";
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
