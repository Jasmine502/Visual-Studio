using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arm_Wrestle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void mashButton_Click(object sender, EventArgs e)
        {
            timer1.Start();
            if (powerBar.Value <= 98)
            {
                powerBar.Value += 2;
            }
            else
            {
                timer1.Stop();
                powerBar.Value = 100;
                MessageBox.Show("You Won!", "Congratulations!");
                powerBar.Value = 50;
                boardBox.Image = Properties.Resources.Neutral;
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (powerBar.Value == 0)
            {
                boardBox.Image = Properties.Resources.Lost;
            }
            if (powerBar.Value > 0 && powerBar.Value <= 25)
            {
                boardBox.Image = Properties.Resources.Losing2;
            }
            if (powerBar.Value > 25 && powerBar.Value < 50)
            {
                boardBox.Image = Properties.Resources.Losing1;
            }
            if (powerBar.Value == 50)
            {
                boardBox.Image = Properties.Resources.Neutral;
            }
            if (powerBar.Value > 50 && powerBar.Value <= 67)
            {
                boardBox.Image = Properties.Resources.Winning1;
            }
            if (powerBar.Value > 67 && powerBar.Value <= 84)
            {
                boardBox.Image = Properties.Resources.Winning2;
            }
            if (powerBar.Value > 84 && powerBar.Value < 100)
            {
                boardBox.Image = Properties.Resources.Winning3;
            }
            if (powerBar.Value == 100)
            {
                boardBox.Image = Properties.Resources.Won;
            }

            if (powerBar.Value > 0)
            {
                powerBar.Value--;
            }
            else
            {
                timer1.Stop();
                MessageBox.Show("You Lost!", "Sorry!");
                powerBar.Value = 50;
                boardBox.Image = Properties.Resources.Neutral;
            }
        }
    }
}