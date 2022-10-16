using System;
using System.Windows.Forms;

namespace Defuse_The_Bomb
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random rnd = new Random();
        int time;
        int digitOne;
        int digitTwo;
        int digitThree;
        int digitFour;
        private void Form1_Load(object sender, EventArgs e)
        {
            time = 60;
            progressLabel.Text = "01:00";
            timer1.Start();
            digitOne = rnd.Next(0, 10);
            digitTwo = rnd.Next(0, 10);
            digitThree = rnd.Next(0, 10);
            digitFour = rnd.Next(0, 10);
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            if (submitButton.Text == "SUBMIT")
            {
                if (digit1.Value > digitOne)
                {
                    check1.Text = "LOWER";
                    time -= 1;
                }
                else if (digit1.Value < digitOne)
                {
                    check1.Text = "HIGHER";
                    time -= 1;
                }
                else
                {
                    check1.Text = "CORRECT";
                    digit1.Enabled = false;
                }

                if (digit2.Value > digitTwo)
                {
                    check2.Text = "LOWER";
                    time -= 1;
                }
                else if (digit2.Value < digitTwo)
                {
                    check2.Text = "HIGHER";
                    time -= 1;
                }
                else
                {
                    check2.Text = "CORRECT";
                    digit2.Enabled = false;
                }

                if (digit3.Value > digitThree)
                {
                    check3.Text = "LOWER";
                    time -= 1;
                }
                else if (digit3.Value < digitThree)
                {
                    check3.Text = "HIGHER";
                    time -= 1;
                }
                else
                {
                    check3.Text = "CORRECT";
                    digit3.Enabled = false;
                }

                if (digit4.Value > digitFour)
                {
                    check4.Text = "LOWER";
                    time -= 1;
                }
                else if (digit4.Value < digitFour)
                {
                    check4.Text = "HIGHER";
                    time -= 1;
                }
                else
                {
                    check4.Text = "CORRECT";
                    digit4.Enabled = false;
                }

                if (digit1.Value == digitOne && digit2.Value == digitTwo && digit3.Value == digitThree && digit4.Value == digitFour)
                {
                    timer1.Stop();
                    progressLabel.Text = "BOMB DEFUSED";
                    submitButton.Text = "RESTART";
                }
            } else
            {
                Application.Restart();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (time >= -1)
            {
                time--;
                if (time < 60)
                {
                    if (time > 9)
                    {
                        progressLabel.Text = "00:" + time.ToString();
                    }
                    else
                    {
                        progressLabel.Text = "00:0" + time.ToString();
                    }
                }
            }
            if (time == -1)
            {
                timer1.Stop();
                Close();
                submitButton.Enabled = false;
            }
        }
    }
}
