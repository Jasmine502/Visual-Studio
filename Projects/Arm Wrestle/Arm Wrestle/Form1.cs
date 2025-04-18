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
        // Constants for power bar thresholds
        private const int MaxPower = 100;
        private const int NeutralPower = 50;
        private const int PowerIncrement = 2;
        private const int PowerDecrement = 1;

        public Form1()
        {
            InitializeComponent();
        }

        private void mashButton_Click(object sender, EventArgs e)
        {
            timer1.Start();

            if (powerBar.Value <= MaxPower - PowerIncrement)
            {
                powerBar.Value += PowerIncrement;
            }
            else
            {
                timer1.Stop();
                powerBar.Value = MaxPower;
                ShowMessage("You Won!", "Congratulations!");
                ResetGame();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            UpdateBoardImage();

            if (powerBar.Value > 0)
            {
                powerBar.Value -= PowerDecrement;
            }
            else
            {
                timer1.Stop();
                ShowMessage("You Lost!", "Sorry!");
                ResetGame();
            }
        }

        private void UpdateBoardImage()
        {
            if (powerBar.Value == 0)
            {
                boardBox.Image = Properties.Resources.Lost;
            }
            else if (powerBar.Value <= 25)
            {
                boardBox.Image = Properties.Resources.Losing2;
            }
            else if (powerBar.Value <= 50)
            {
                boardBox.Image = powerBar.Value == NeutralPower
                    ? Properties.Resources.Neutral
                    : Properties.Resources.Losing1;
            }
            else if (powerBar.Value <= 67)
            {
                boardBox.Image = Properties.Resources.Winning1;
            }
            else if (powerBar.Value <= 84)
            {
                boardBox.Image = Properties.Resources.Winning2;
            }
            else if (powerBar.Value < MaxPower)
            {
                boardBox.Image = Properties.Resources.Winning3;
            }
            else
            {
                boardBox.Image = Properties.Resources.Won;
            }
        }

        private void ShowMessage(string message, string title)
        {
            MessageBox.Show(message, title);
        }

        private void ResetGame()
        {
            powerBar.Value = NeutralPower;
            boardBox.Image = Properties.Resources.Neutral;
        }
    }
}