using System;
using System.Drawing;
using System.Windows.Forms;

namespace Mental_Maths_Quiz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random rnd = new Random();

        int addend1;
        int addend2;
        int minuend;
        int subtrahend;
        int dividend;
        int divisor;
        int multiplicand;
        int multiplier;

        int time;
        public void StartQuiz()
        {
            timeLeftLabel.BackColor = Color.WhiteSmoke;
            additionCheck.Image = null;
            subtractionCheck.Image = null;
            divisionCheck.Image = null;
            multiplicationCheck.Image = null;

            time = 60;
            timeLeftLabel.Text = time + " seconds";

            addend1 = rnd.Next(1, 25);
            addend2 = rnd.Next(1, 25);
            plusLeftLabel.Text = addend1.ToString();
            plusRightLabel.Text = addend2.ToString();
            sum.Value = 0;

            minuend = rnd.Next(1, 51);
            subtrahend = rnd.Next(1, minuend);
            minusLeftLabel.Text = minuend.ToString();
            minusRightLabel.Text = subtrahend.ToString();
            difference.Value = 0;

            divisor = rnd.Next(2, 11);
            int temporaryQuotient = rnd.Next(2, 11);
            dividend = divisor * temporaryQuotient;
            dividedLeftLabel.Text = dividend.ToString();
            dividedRightLabel.Text = divisor.ToString();
            quotient.Value = 0;

            multiplicand = rnd.Next(1, 13);
            multiplier = rnd.Next(1, 13);
            timesLeftLabel.Text = multiplicand.ToString();
            timesRightLabel.Text = multiplier.ToString();
            product.Value = 0;

            countDownTimer.Start();
        }
        public void CheckAnswers()
        {
            countDownTimer.Stop();

            startFinishButton.Text = "START";
            if (addend1 + addend2 == sum.Value)
            {
                additionCheck.Image = Properties.Resources.Tick;
            }
            else
            {
                sum.Value = addend1 + addend2;
                additionCheck.Image = Properties.Resources.Cross;
            }

            if (minuend - subtrahend == difference.Value)
            {
                subtractionCheck.Image = Properties.Resources.Tick;
            }
            else
            {
                difference.Value = minuend - subtrahend;
                subtractionCheck.Image = Properties.Resources.Cross;
            }

            if (dividend / divisor == quotient.Value)
            {
                divisionCheck.Image = Properties.Resources.Tick;
            }
            else
            {
                quotient.Value = dividend / divisor;
                divisionCheck.Image = Properties.Resources.Cross;
            }

            if (multiplicand * multiplier == product.Value)
            {
                multiplicationCheck.Image = Properties.Resources.Tick;
            }
            else
            {
                product.Value = multiplicand * multiplier;
                multiplicationCheck.Image = Properties.Resources.Cross;
            }
        }
        private void startFinishButton_Click(object sender, EventArgs e)
        {
            if (startFinishButton.Text == "START")
            {
                StartQuiz();
                startFinishButton.Text = "FINISH";
            }
            else if (startFinishButton.Text == "FINISH")
            {
                CheckAnswers();
                startFinishButton.Text = "CLEAR";
            }
            else if (startFinishButton.Text == "CLEAR")
            {
                sum.Value = 0;
                difference.Value = 0;
                quotient.Value = 0;
                product.Value = 0;

                plusLeftLabel.Text = "?";
                plusRightLabel.Text = "?";
                minusLeftLabel.Text = "?";
                minusRightLabel.Text = "?";
                dividedLeftLabel.Text = "?";
                dividedRightLabel.Text = "?";
                timesLeftLabel.Text = "?";
                timesRightLabel.Text = "?";

                additionCheck.Image = null;
                subtractionCheck.Image = null;
                divisionCheck.Image = null;
                multiplicationCheck.Image = null;

                startFinishButton.Text = "START";
            }
        }

        private void countDownTimer_Tick(object sender, EventArgs e)
        {
            if (time > 0)
            {
                time--;
                if (time == 1)
                {
                    timeLeftLabel.Text = time + " second";
                }
                else
                {
                    timeLeftLabel.Text = time + " seconds";
                }
            }
            else
            {
                countDownTimer.Stop();
                CheckAnswers();
            }

            if (time <= 5)
            {
                timeLeftLabel.BackColor = Color.Red;
            }
        }
    }
}
