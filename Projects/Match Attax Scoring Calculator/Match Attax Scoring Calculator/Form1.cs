using System;
using System.Windows.Forms;
using System.Drawing;
namespace Match_Attax_Scoring_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int c1Score;
        int c2Score;
        Control[] labels = new Control[15];
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void UpdateScore(string label1, string label2, ref int c1Score, ref int c2Score)
        {
            int value1 = int.Parse(label1);
            int value2 = int.Parse(label2);

            if (value1 > value2)
            {
                c1Score++;
            }
            else if (value1 < value2)
            {
                c2Score++;
            }
            else
            {
                c1Score++;
                c2Score++;
            }
        }

        private void battleSubmitButton_Click(object sender, EventArgs e)
        {
            if (battleSubmitButton.Text == "SUBMIT")
            {
                battleSubmitButton.Text = "BATTLE";
                //hiding
                    //input boxes
                valueBox.Visible = false;
                valueBox2.Visible = false;
                speedBox.Visible = false;
                speedBox2.Visible = false;
                tackleBox.Visible = false;
                tackleBox2.Visible = false;
                powerBox.Visible = false;
                powerBox2.Visible = false;
                shootBox.Visible = false;
                shootBox2.Visible = false;
                skillBox.Visible = false;
                skillBox2.Visible = false;
                passBox.Visible = false;
                passBox2.Visible = false;
                defenceBox.Visible = false;
                defenceBox2.Visible = false;
                attackBox.Visible = false;
                attackBox2.Visible = false;

                //showing
                    //card labels
                valueLabel.Visible = true;
                valueLabel2.Visible = true;
                speedLabel.Visible = true;
                speedLabel2.Visible = true;
                tackleLabel.Visible = true;
                tackleLabel2.Visible = true;
                powerLabel.Visible = true;
                powerLabel2.Visible = true;
                shootLabel.Visible = true;
                shootLabel2.Visible = true;
                skillLabel.Visible = true;
                skillLabel2.Visible = true;
                passLabel.Visible = true;
                passLabel2.Visible = true;
                defenceLabel.Visible = true;
                defenceLabel2.Visible = true;
                attackLabel.Visible = true;
                attackLabel2.Visible = true;
                //value changing
                valueLabel.Text = valueBox.Text + "m";
                valueLabel2.Text = valueBox2.Text + "m";
                speedLabel.Text = speedBox.Text;
                speedLabel2.Text = speedBox2.Text;
                tackleLabel.Text = tackleBox.Text;
                tackleLabel2.Text = tackleBox2.Text;
                powerLabel.Text = powerBox.Text;
                powerLabel2.Text = powerBox2.Text;
                shootLabel.Text = shootBox.Text;
                shootLabel2.Text = shootBox2.Text;
                skillLabel.Text = skillBox.Text;
                skillLabel2.Text = skillBox2.Text;
                passLabel.Text = passBox.Text;
                passLabel2.Text = passBox2.Text;
                defenceLabel.Text = defenceBox.Text;
                defenceLabel2.Text = defenceBox2.Text;
                attackLabel.Text = attackBox.Text;
                attackLabel2.Text = attackBox2.Text;
            }else if (battleSubmitButton.Text == "BATTLE")
            {
                battleSubmitButton.Text = "RETURN";
                UpdateScore(speedLabel.Text, speedLabel2.Text, ref c1Score, ref c2Score);
                UpdateScore(tackleLabel.Text, tackleLabel2.Text, ref c1Score, ref c2Score);
                UpdateScore(powerLabel.Text, powerLabel2.Text, ref c1Score, ref c2Score);
                UpdateScore(shootLabel.Text, shootLabel2.Text, ref c1Score, ref c2Score);
                UpdateScore(skillLabel.Text, skillLabel2.Text, ref c1Score, ref c2Score);
                UpdateScore(passLabel.Text, passLabel2.Text, ref c1Score, ref c2Score);
                UpdateScore(defenceLabel.Text, defenceLabel2.Text, ref c1Score, ref c2Score);
                UpdateScore(attackLabel.Text, attackLabel2.Text, ref c1Score, ref c2Score);
                if (c1Score >= c2Score) //card 1 wins
                {
                    card1.Image = Properties.Resources.Red_Match_Attax_Card_Win;
                    valueLabel.BackColor = Color.FromArgb(221, 80, 80);
                }
                if (c2Score >= c1Score) //card 2 wins
                {
                    card2.Image = Properties.Resources.Blue_Match_Attax_Card_Win;
                    valueLabel2.BackColor = Color.FromArgb(107, 154, 215);
                }

            }
            else if (battleSubmitButton.Text == "RETURN")
            {
                card1.Image = Properties.Resources.Red_Match_Attax_Card;
                card2.Image = Properties.Resources.Blue_Match_Attax_Card;
                c1Score = 0;
                c2Score = 0;
                valueLabel.BackColor = Color.FromArgb(250, 160, 160);
                valueLabel2.BackColor = Color.FromArgb(165, 204, 219);
                battleSubmitButton.Text = "SUBMIT";
                //resetting
                valueBox.Clear();
                valueBox2.Clear();
                speedBox.Clear();
                speedBox2.Clear();
                tackleBox.Clear();
                tackleBox2.Clear();
                powerBox.Clear();
                powerBox2.Clear();
                shootBox.Clear();
                shootBox2.Clear();
                skillBox.Clear();
                skillBox2.Clear();
                passBox.Clear();
                passBox2.Clear();
                defenceBox.Clear();
                defenceBox2.Clear();
                attackBox.Clear();
                attackBox2.Clear();
                //input boxes
                valueBox.Visible = true;
                valueBox2.Visible = true;
                speedBox.Visible = true;
                speedBox2.Visible = true;
                tackleBox.Visible = true;
                tackleBox2.Visible = true;
                powerBox.Visible = true;
                powerBox2.Visible = true;
                shootBox.Visible = true;
                shootBox2.Visible = true;
                skillBox.Visible = true;
                skillBox2.Visible = true;
                passBox.Visible = true;
                passBox2.Visible = true;
                defenceBox.Visible = true;
                defenceBox2.Visible = true;
                attackBox.Visible = true;
                attackBox2.Visible = true;

                //hiding
                //card labels
                valueLabel.Visible = false;
                valueLabel2.Visible = false;
                speedLabel.Visible = false;
                speedLabel2.Visible = false;
                tackleLabel.Visible = false;
                tackleLabel2.Visible = false;
                powerLabel.Visible = false;
                powerLabel2.Visible = false;
                shootLabel.Visible = false;
                shootLabel2.Visible = false;
                skillLabel.Visible = false;
                skillLabel2.Visible = false;
                passLabel.Visible = false;
                passLabel2.Visible = false;
                defenceLabel.Visible = false;
                defenceLabel2.Visible = false;
                attackLabel.Visible = false;
                attackLabel2.Visible = false;
                //value changing
                valueLabel.Text = "";
                valueLabel2.Text = "";
                speedLabel.Text = "";
                speedLabel2.Text = "";
                tackleLabel.Text = "";
                tackleLabel2.Text = "";
                powerLabel.Text = "";
                powerLabel2.Text = "";
                shootLabel.Text = "";
                shootLabel2.Text = "";
                skillLabel.Text = "";
                skillLabel2.Text = "";
                passLabel.Text = "";
                passLabel2.Text = "";
                defenceLabel.Text = "";
                defenceLabel2.Text = "";
                attackLabel.Text = "";
                attackLabel2.Text = "";

            }

        }
    }
}
