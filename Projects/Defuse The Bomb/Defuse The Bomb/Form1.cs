using System;
using System.Windows.Forms;

namespace Defuse_The_Bomb
{
    public partial class Form1 : Form
    {
        private readonly Random rnd = new Random();
        private int time = 60;
        private readonly int[] digits = new int[4];

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            progressLabel.Text = "01:00";
            timer1.Start();
            for (int i = 0; i < digits.Length; i++)
            {
                digits[i] = rnd.Next(0, 10);
            }
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            if (submitButton.Text == "SUBMIT")
            {
                bool allCorrect = true;

                allCorrect &= CheckDigit(digit1, check1, digits[0]);
                allCorrect &= CheckDigit(digit2, check2, digits[1]);
                allCorrect &= CheckDigit(digit3, check3, digits[2]);
                allCorrect &= CheckDigit(digit4, check4, digits[3]);

                if (allCorrect)
                {
                    timer1.Stop();
                    progressLabel.Text = "BOMB DEFUSED";
                    submitButton.Text = "RESTART";
                }
            }
            else
            {
                Application.Restart();
            }
        }

        private bool CheckDigit(NumericUpDown digit, Label check, int target)
        {
            if (digit.Value > target)
            {
                check.Text = "LOWER";
            }
            else if (digit.Value < target)
            {
                check.Text = "HIGHER";
            }
            else
            {
                check.Text = "CORRECT";
                digit.Enabled = false;
                return true;
            }

            time--;
            return false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time--;
            if (time < 0)
            {
                timer1.Stop();
                progressLabel.Text = "TIME'S UP";
                submitButton.Enabled = false;
            }
            else
            {
                progressLabel.Text = string.Format("00:{0:D2}", time);
            }
        }
    }
}
