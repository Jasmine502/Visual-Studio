using System;
using System.Windows.Forms;

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
        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void tackleBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void battleSubmitButton_Click(object sender, EventArgs e)
        {
            if (battleSubmitButton.Text == "SUBMIT")
            {
                battleSubmitButton.Text = "BATTLE";
                //hiding
                    //info labels
                valLabel.Visible = false;
                valLabel2.Visible = false;
                spdLabel.Visible = false;
                spdLabel2.Visible = false;
                tackLabel.Visible = false;
                tackLabel2.Visible = false;
                pwrLabel.Visible = false;
                pwrLabel2.Visible = false;
                shtLabel.Visible = false;
                shtLabel2.Visible = false;
                sklLabel.Visible = false;
                sklLabel2.Visible = false;
                psLabel.Visible = false;
                psLabel2.Visible = false;
                defLabel.Visible = false;
                defLabel2.Visible = false;
                atkLabel.Visible = false;
                atkLabel2.Visible = false;
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
                card1.Visible = true;
                card2.Visible = true;
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
                tackLabel2.Text = tackleBox2.Text;
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
                if (int.Parse(speedLabel.Text) > int.Parse(speedLabel2.Text))
                {
                    c1Score++;
                }
                else if (int.Parse(speedLabel.Text) < int.Parse(speedLabel2.Text))
                {
                    c2Score++;
                }
                else
                {
                    c1Score++;
                    c2Score++;
                }
                if (int.Parse(tackleLabel.Text) > int.Parse(tackleLabel2.Text))
                {
                    c1Score++;
                }
                else if (int.Parse(tackleLabel.Text) < int.Parse(tackleLabel2.Text))
                {
                    c2Score++;
                }
                else
                {
                    c1Score++;
                    c2Score++;
                }
                if (int.Parse(powerLabel.Text) > int.Parse(powerLabel2.Text))
                {
                    c1Score++;
                }
                else if (int.Parse(powerLabel.Text) < int.Parse(powerLabel2.Text))
                {
                    c2Score++;
                }
                else
                {
                    c1Score++;
                    c2Score++;
                }
                if (int.Parse(shootLabel.Text) > int.Parse(shootLabel2.Text))
                {
                    c1Score++;
                }
                else if (int.Parse(shootLabel.Text) < int.Parse(shootLabel2.Text))
                {
                    c2Score++;
                }
                else
                {
                    c1Score++;
                    c2Score++;
                }
                if (int.Parse(skillLabel.Text) > int.Parse(skillLabel2.Text))
                {
                    c1Score++;
                }
                else if (int.Parse(skillLabel.Text) < int.Parse(skillLabel2.Text))
                {
                    c2Score++;
                }
                else
                {
                    c1Score++;
                    c2Score++;
                }
                if (int.Parse(passLabel.Text) > int.Parse(passLabel2.Text))
                {
                    c1Score++;
                }
                else if (int.Parse(passLabel.Text) < int.Parse(passLabel2.Text))
                {
                    c2Score++;
                }
                else
                {
                    c1Score++;
                    c2Score++;
                }
                if (int.Parse(defenceLabel.Text) > int.Parse(defenceLabel2.Text))
                {
                    c1Score++;
                }
                else if (int.Parse(defenceLabel.Text) < int.Parse(defenceLabel2.Text))
                {
                    c2Score++;
                }
                else
                {
                    c1Score++;
                    c2Score++;
                }
                if (int.Parse(attackLabel.Text) > int.Parse(attackLabel2.Text))
                {
                    c1Score++;
                }
                else if (int.Parse(attackLabel.Text) < int.Parse(attackLabel2.Text))
                {
                    c2Score++;
                }
                else
                {
                    c1Score++;
                    c2Score++;
                }
                card1Label.Text += c1Score;
                card2Label.Text += c2Score;
                if (c1Score > c2Score)
                {
                    card1.Image = Properties.Resources.Red_Match_Attax_Card_Win;
                }
                else if (c1Score < c2Score)
                {
                    card2.Image = Properties.Resources.Blue_Match_Attax_Card_Win;
                }
                else
                {
                    card1.Image = Properties.Resources.Red_Match_Attax_Card_Win;
                    card2.Image = Properties.Resources.Blue_Match_Attax_Card_Win;
                }
            }else if (battleSubmitButton.Text == "RETURN")
            {
                card1Label.Text = "CARD 1: ";
                card2Label.Text = "CARD 2: ";
                card1.Image = Properties.Resources.Red_Match_Attax_Card;
                card2.Image = Properties.Resources.Blue_Match_Attax_Card;
                c1Score = 0;
                c2Score = 0;
                battleSubmitButton.Text = "SUBMIT";
                //showing
                //info labels
                valLabel.Visible = true;
                valLabel2.Visible = true;
                spdLabel.Visible = true;
                spdLabel2.Visible = true;
                tackLabel.Visible = true;
                tackLabel2.Visible = true;
                pwrLabel.Visible = true;
                pwrLabel2.Visible = true;
                shtLabel.Visible = true;
                shtLabel2.Visible = true;
                sklLabel.Visible = true;
                sklLabel2.Visible = true;
                psLabel.Visible = true;
                psLabel2.Visible = true;
                defLabel.Visible = true;
                defLabel2.Visible = true;
                atkLabel.Visible = true;
                atkLabel2.Visible = true;
                valueBox.Text = "";
                valueBox2.Text = "";
                speedBox.Text = "";
                speedBox2.Text = "";
                tackleBox.Text = "";
                tackleBox2.Text = "";
                powerBox.Text = "";
                powerBox2.Text = "";
                shootBox.Text = "";
                shootBox2.Text = "";
                skillBox.Text = "";
                skillBox2.Text = "";
                passBox.Text = "";
                passBox2.Text = "";
                defenceBox.Text = "";
                defenceBox2.Text = "";
                attackBox.Text = "";
                attackBox2.Text = "";
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
                card1.Visible = false;
                card2.Visible = false;
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
                tackLabel2.Text = "";
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
