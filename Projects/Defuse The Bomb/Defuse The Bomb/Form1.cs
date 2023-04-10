using System;
using System.Windows.Forms;

namespace Defuse_The_Bomb
{
    public partial class Form1 : Form
    {
        private Random rnd = new Random();
        private int time = 60;
        private int[] digits = new int[4];

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
                CheckDigit(digit1, check1, digits[0]);
                CheckDigit(digit2, check2, digits[1]);
                CheckDigit(digit3, check3, digits[2]);
                CheckDigit(digit4, check4, digits[3]);

                if (digit1.Value == digits[0] && digit2.Value == digits[1] && digit3.Value == digits[2] && digit4.Value == digits[3])
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

        private void CheckDigit(NumericUpDown digit, Label check, int target)
        {
            if (digit.Value > target)
            {
                check.Text = "LOWER";
                time -= 1;
            }
            else if (digit.Value < target)
            {
                check.Text = "HIGHER";
                time -= 1;
            }
            else
            {
                check.Text = "CORRECT";
                digit.Enabled = false;
            }
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
            else if (time < 10)
            {
                progressLabel.Text = "00:0" + time;
            }
            else
            {
                progressLabel.Text = "00:" + time;
            }
        }
    }
}
