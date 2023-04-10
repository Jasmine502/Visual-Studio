using System;
using System.Windows.Forms;

namespace CaptureRecaptureMethod
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            double firstCapture, secondCapture, marked, estimate;

            if (double.TryParse(firstCaptureBox.Text, out firstCapture) &&
                double.TryParse(secondCaptureBox.Text, out secondCapture) &&
                double.TryParse(markedBox.Text, out marked))
            {
                estimate = Math.Round((firstCapture * secondCapture) / marked);
                totalEstimateLabel.Text = estimate.ToString();
            }
            else
            {
                MessageBox.Show("Please enter valid numbers in all fields.", "Error");
            }
        }
    }
}
