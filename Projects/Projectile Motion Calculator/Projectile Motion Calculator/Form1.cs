using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projectile_Motion_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int indexD = 2;
        int indexT = 1;
        decimal dp = 2;
        String[] distanceUnits = { "mm", "cm", "m", "km", "mi" };
        String[] timeUnits = { "ms", "s", "min", "hr" };
        private void distanceLabel_Click(object sender, EventArgs e)
        {
        }

        private void timeUnitLabel_Click(object sender, EventArgs e)
        {

        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            rangeBox.Clear();
            heightBox.Clear();
            timeBox.Clear();
            velocityBox.Clear();
            gravityBox.Clear();
        }

        private void distanceLabel_MouseDown(object sender, MouseEventArgs e)
        {
            indexD += 1;
            if (indexD == 4)
            {
                indexD = 0;
            }
            rangeUnitLabel.Text = distanceUnits[indexD];
            heightUnitLabel.Text = distanceUnits[indexD];
            velocityUnitLabel.Text = rangeUnitLabel.Text + "/" + timeUnitLabel.Text;
            gravityUnitLabel.Text = heightUnitLabel.Text + "/" + timeUnitLabel.Text + "2";
        }
        private void timeUnitLabel_MouseDown(object sender, MouseEventArgs e)
        {
            indexT += 1;
            if (indexT == 4)
            {
                indexT = 0;
            }
            timeUnitLabel.Text = timeUnits[indexT];
            velocityUnitLabel.Text = rangeUnitLabel.Text + "/" + timeUnitLabel.Text;
            gravityUnitLabel.Text = heightUnitLabel.Text + "/" + timeUnitLabel.Text + "2";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void solveButton_Click(object sender, EventArgs e)
        {
            if (rangeBox.Text == String.Empty)
            {
                rangeBox.Text = "0";
            }
            if (heightBox.Text == String.Empty)
            {
                heightBox.Text = "0";
            }
            if (timeBox.Text == String.Empty)
            {
                timeBox.Text = "0";
            }
            if (velocityBox.Text == String.Empty)
            {
                velocityBox.Text = "0";
            }
            if (gravityBox.Text == String.Empty)
            {
                gravityBox.Text = "0";
            }

            double x = double.Parse(rangeBox.Text);
            double y = double.Parse(heightBox.Text);
            double u = double.Parse(velocityBox.Text);
            double a = double.Parse(gravityBox.Text);
            double t = double.Parse(timeBox.Text);

            if (rangeRadio.Checked == true)
            {
                x = (u * Math.Sqrt(2 * a * y)) / a;
                t = x / u;
            }
            if (heightRadio.Checked == true)
            {
                y = (a * Math.Pow(x, 2)) / (2 * Math.Pow(u, 2));
                t = Math.Sqrt(2 * y * a) / a;
            }
            if (velocityRadio.Checked == true)
            {
                u = (x * Math.Sqrt(2 * a * y)) / (2 * y);
                t = Math.Sqrt(2 * y * a) / a;
            }
            if (gravityRadio.Checked == true)
            {
                a = (2 * y * (Math.Pow(u, 2))) / Math.Pow(x, 2);
                t = Math.Sqrt(2 * y * a) / a;
            }
            rangeBox.Text = Math.Round(x,Convert.ToInt32(dp)).ToString();
            heightBox.Text = Math.Round(y,Convert.ToInt32(dp)).ToString();
            velocityBox.Text = Math.Round(u,Convert.ToInt32(dp)).ToString();
            gravityBox.Text = Math.Round(a,Convert.ToInt32(dp)).ToString();
            timeBox.Text = Math.Round(t,Convert.ToInt32(dp)).ToString();
        }

        private void dpUD_ValueChanged(object sender, EventArgs e)
        {
            dp = dpUD.Value;
        }
    }
}
