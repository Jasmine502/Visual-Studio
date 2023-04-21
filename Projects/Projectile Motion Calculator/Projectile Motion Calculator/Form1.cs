using System;
using System.Windows.Forms;

namespace Projectile_Motion_Calculator
{
    public partial class Form1 : Form
    {
        private readonly string[] distanceUnits = { "mm", "cm", "m", "km", "mi" };
        private readonly string[] timeUnits = { "ms", "s", "min", "hr" };
        private int distanceUnitIndex = 2;
        private int timeUnitIndex = 1;
        private decimal dp = 2;

        public Form1()
        {
            InitializeComponent();
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
            distanceUnitIndex = (distanceUnitIndex + 1) % distanceUnits.Length;
            UpdateUnitLabels();
        }

        private void timeUnitLabel_MouseDown(object sender, MouseEventArgs e)
        {
            timeUnitIndex = (timeUnitIndex + 1) % timeUnits.Length;
            UpdateUnitLabels();
        }

        private void UpdateUnitLabels()
        {
            rangeUnitLabel.Text = distanceUnits[distanceUnitIndex];
            heightUnitLabel.Text = distanceUnits[distanceUnitIndex];
            velocityUnitLabel.Text = $"{rangeUnitLabel.Text}/{timeUnits[timeUnitIndex]}";
            gravityUnitLabel.Text = $"{heightUnitLabel.Text}/{timeUnits[timeUnitIndex]}²";
        }

        private void solveButton_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(rangeBox.Text, out double x)) x = 0;
            if (!double.TryParse(heightBox.Text, out double y)) y = 0;
            if (!double.TryParse(velocityBox.Text, out double u)) u = 0;
            if (!double.TryParse(gravityBox.Text, out double a)) a = 0;
            if (!double.TryParse(timeBox.Text, out double t)) t = 0;

            if (rangeRadio.Checked)
            {
                x = (u * Math.Sqrt(2 * a * y)) / a;
                t = x / u;
            }
            else if (heightRadio.Checked)
            {
                y = (a * Math.Pow(x, 2)) / (2 * Math.Pow(u, 2));
                t = Math.Sqrt(2 * y * a) / a;
            }
            else if (velocityRadio.Checked)
            {
                u = (x * Math.Sqrt(2 * a * y)) / (2 * y);
                t = Math.Sqrt(2 * y * a) / a;
            }
            else if (gravityRadio.Checked)
            {
                a = (2 * y * (Math.Pow(u, 2))) / Math.Pow(x, 2);
                t = Math.Sqrt(2 * y * a) / a;
            }

            rangeBox.Text = Math.Round(x, Convert.ToInt32(dp)).ToString();
            heightBox.Text = Math.Round(y, Convert.ToInt32(dp)).ToString();
            velocityBox.Text = Math.Round(u, Convert.ToInt32(dp)).ToString();
            gravityBox.Text = Math.Round(a, Convert.ToInt32(dp)).ToString();
            timeBox.Text = Math.Round(t, Convert.ToInt32(dp)).ToString();
        }

        private void dpUD_ValueChanged(object sender, EventArgs e)
        {
            dp = dpUD.Value;
        }
    }
}
