using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Digital_Clock
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool time12 = false;
        bool time24 = true;
        bool date = false;
        bool time24AndDate = false;
        bool time12AndDate = false;
        String format;
        private void timeLabel_Click(object sender, EventArgs e)
        {
            if (time12)
            {
                format = "HH:mm:ss";
                time12 = false;
                time24 = true;
                date = false;
                time24AndDate = false;
                time12AndDate = false;
            }
            else if (time24)
            {
                format = "dd/MM/yyyy";
                time12 = false;
                time24 = false;
                date = true;
                time24AndDate = false;
                time12AndDate = false;
            }
            else if (date)
            {
                format = "dd/MM/yyyy HH:mm:ss";
                time12 = false;
                time24 = false;
                date = false;
                time24AndDate = true;
                time12AndDate = false;
            }
            else if (time24AndDate)
            {
                format = "dd/MM/yyyy hh:mm:ss tt";
                time12 = false;
                time24 = false;
                date = false;
                time24AndDate = false;
                time12AndDate = true;
            }
            else if (time12AndDate)
            {
                format = "hh:mm:ss tt";
                time12 = true;
                time24 = false;
                date = false;
                time24AndDate = false;
                time12AndDate = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            format = "HH:mm:ss";
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timeLabel.Text = DateTime.Now.ToString(format);
        }
    }
}
