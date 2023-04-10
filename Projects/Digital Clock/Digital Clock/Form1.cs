using System;
using System.Windows.Forms;

namespace Digital_Clock
{
    public partial class Form1 : Form
    {
        private string format;

        public Form1()
        {
            InitializeComponent();
            format = "HH:mm:ss";
        }

        private void timeLabel_Click(object sender, EventArgs e)
        {
            switch (format)
            {
                case "HH:mm:ss":
                    format = "dd/MM/yyyy";
                    break;
                case "dd/MM/yyyy":
                    format = "dd/MM/yyyy HH:mm:ss";
                    break;
                case "dd/MM/yyyy HH:mm:ss":
                    format = "dd/MM/yyyy hh:mm:ss tt";
                    break;
                case "dd/MM/yyyy hh:mm:ss tt":
                    format = "hh:mm:ss tt";
                    break;
                default:
                    format = "HH:mm:ss";
                    break;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timeLabel.Text = DateTime.Now.ToString(format);
        }
    }
}
