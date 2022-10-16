using System;
using System.Windows.Forms;

namespace Guess_The_Number
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        int randomNum;
        private void Form1_Load(object sender, EventArgs e)
        {
            Random rnd = new Random();
            randomNum = rnd.Next(0, rnd.Next(100, 1001));
        }
        private void submitButton_Click(object sender, EventArgs e)
        {
            if (submitButton.Text == "SUBMIT")
            {
                if (guess.Text == "")
                {
                    MessageBox.Show("Please enter an integer between 0 and 500", "Input Error");
                }
                else
                {
                    if (Convert.ToInt32(guess.Text) < randomNum)
                    {
                        result.Text = "HIGHER";
                        BackColor = System.Drawing.Color.Blue;
                    }
                    else if (Convert.ToInt32(guess.Text) > randomNum)
                    {
                        result.Text = "LOWER";
                        BackColor = System.Drawing.Color.Red;
                    }
                    else
                    {
                        result.Text = "CORRECT";
                        BackColor = System.Drawing.Color.Green;
                        submitButton.Text = "RESET";

                    }
                }
            }
            else if (submitButton.Text == "RESET")
            {
                Random rnd = new Random();
                randomNum = rnd.Next(0, rnd.Next(100, 1001));
                submitButton.Text = "SUBMIT";
                BackColor = DefaultBackColor;
                guess.Text = "";
                result.Text = "";

            }
        }

        private void guess_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                submitButton_Click((object)sender, (EventArgs)e);
            }
        }
    }


}
