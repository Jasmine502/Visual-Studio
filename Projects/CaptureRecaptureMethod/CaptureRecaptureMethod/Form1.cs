using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaptureRecaptureMethod
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double firstCaptureCaptured;
        double secondCaptureCaptured;
        double secondCaptureMarked;
        double total;
        double totalEstimate;
        private void Form1_Load(object sender, EventArgs e)
        {
            firstCaptureCapturedBox.Clear();
            secondCaptureMarkedBox.Clear();
            secondCaptureCapturedBox.Clear();
            totalEstimateLabel.Text = "";
        }
        private void calculateButton_Click(object sender, EventArgs e)
        {
            if (firstCaptureCapturedBox.Text != "" && secondCaptureMarkedBox.Text != "" && secondCaptureMarkedBox.Text != "")
            {
                firstCaptureCaptured = double.Parse(firstCaptureCapturedBox.Text);
                secondCaptureCaptured = double.Parse(secondCaptureCapturedBox.Text);
                secondCaptureMarked = double.Parse(secondCaptureMarkedBox.Text);
                total = (firstCaptureCaptured * secondCaptureCaptured) / secondCaptureMarked;
                totalEstimate = Math.Round(total);
                totalEstimateLabel.Text = totalEstimate.ToString();
            }
            else
            {
                MessageBox.Show("Please Fill In All The Boxes","Error");
            }
        }
    }
}
