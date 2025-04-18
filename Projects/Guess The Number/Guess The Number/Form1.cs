using System;
using System.Windows.Forms;

namespace Guess_The_Number
{
    public partial class Form1 : Form
    {
        private readonly Random _random = new Random();
        private int _targetNumber;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ResetGame();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            if (submitButton.Text == "SUBMIT")
            {
                ProcessGuess();
            }
            else
            {
                ResetGame();
            }
        }

        private void guess_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ProcessGuess();
            }
        }

        private void ResetGame()
        {
            _targetNumber = _random.Next(0, 1001);
            submitButton.Text = "SUBMIT";
            BackColor = DefaultBackColor;
            guess.Clear();
            result.Text = "I'm thinking of a number between 0 and 1000. Can you guess it?";
        }

        private void ProcessGuess()
        {
            if (!int.TryParse(guess.Text, out int userGuess) || userGuess < 0 || userGuess > 1000)
            {
                MessageBox.Show("Oops! Please enter a valid number between 0 and 1000.", "Input Error");
                return;
            }

            int difference = Math.Abs(userGuess - _targetNumber);
            int colorIntensity = Math.Max(0, 255 - (difference * 255 / 1000)); // Scale difference to 0-255

            if (userGuess < _targetNumber)
            {
                UpdateResult("Too low! Try guessing higher.", System.Drawing.Color.FromArgb(255, colorIntensity, colorIntensity, 255));
            }
            else if (userGuess > _targetNumber)
            {
                UpdateResult("Too high! Try guessing lower.", System.Drawing.Color.FromArgb(255, 255, colorIntensity, colorIntensity));
            }
            else
            {
                UpdateResult("You got it! 🎉", System.Drawing.Color.LightGreen);
                MessageBox.Show("Congratulations! You guessed the number!", "Winner");
                submitButton.Text = "RESET";
            }
        }



        private void UpdateResult(string message, System.Drawing.Color backgroundColor)
        {
            result.Text = message;
            BackColor = backgroundColor;
        }
    }
}
