using System;
using System.Windows.Forms;

namespace Guess_The_Number
{
    public partial class Form1 : Form
    {
        private readonly Random rnd = new Random();
        private int randomNum;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Reset();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            if (submitButton.Text == "SUBMIT")
            {
                SubmitGuess();
            }
            else if (submitButton.Text == "RESET")
            {
                Reset();
            }
        }

        private void guess_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SubmitGuess();
            }
        }

        private void Reset()
        {
            randomNum = rnd.Next(0, 1001);
            submitButton.Text = "SUBMIT";
            BackColor = DefaultBackColor;
            guess.Text = "";
            result.Text = "";
        }

        private void SubmitGuess()
        {
            if (!int.TryParse(guess.Text, out int guessNum) || guessNum < 0 || guessNum > 1000)
            {
                MessageBox.Show("Please enter an integer between 0 and 1000", "Input Error");
                return;
            }

            if (guessNum < randomNum)
            {
                result.Text = "HIGHER";
                BackColor = System.Drawing.Color.Blue;
            }
            else if (guessNum > randomNum)
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
}
