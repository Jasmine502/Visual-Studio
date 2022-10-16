using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pokemon_Contestant_Suggester
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        String pokemon1;
        String pokemon2;
        String pokemon3;
        String pokemon4;
        String pokemon5;
        String pokemon6;
        String pokemon1Moves;
        String pokemon2Moves;
        String pokemon3Moves;
        String pokemon4Moves;
        String pokemon5Moves;
        String pokemon6Moves;
        String[] types = { "NORMAL", "FIRE", "WATER", "ELECTRIC", "GRASS", "ICE", "FIGHTING", "POISON", "GROUND", "FLYING", "PSYCHIC", "BUG", "ROCK", "GHOST", "DRAGON", "DARK", "STEEL", "FAIRY" };
        private void Form1_Load(object sender, EventArgs e)
        {
            pokemon1 = "Pokemon 1";
            pokemon2 = "Pokemon 2";
            pokemon3 = "Pokemon 3";
            pokemon4 = "Pokemon 4";
            pokemon5 = "Pokemon 5";
            pokemon6 = "Pokemon 6";
        }

        private void submitTeamButton_Click(object sender, EventArgs e)
        {
            pokemon1Move1Box.BackColor = default(Color);
            pokemon1Move2Box.BackColor = default(Color);
            pokemon1Move3Box.BackColor = default(Color);
            pokemon1Move4Box.BackColor = default(Color);

            pokemon2Move1Box.BackColor = default(Color);
            pokemon2Move2Box.BackColor = default(Color);
            pokemon2Move3Box.BackColor = default(Color);
            pokemon2Move4Box.BackColor = default(Color);

            pokemon3Move1Box.BackColor = default(Color);
            pokemon3Move2Box.BackColor = default(Color);
            pokemon3Move3Box.BackColor = default(Color);
            pokemon3Move4Box.BackColor = default(Color);

            pokemon4Move1Box.BackColor = default(Color);
            pokemon4Move2Box.BackColor = default(Color);
            pokemon4Move3Box.BackColor = default(Color);
            pokemon4Move4Box.BackColor = default(Color);

            pokemon5Move1Box.BackColor = default(Color);
            pokemon5Move2Box.BackColor = default(Color);
            pokemon5Move3Box.BackColor = default(Color);
            pokemon5Move4Box.BackColor = default(Color);

            pokemon6Move1Box.BackColor = default(Color);
            pokemon6Move2Box.BackColor = default(Color);
            pokemon6Move3Box.BackColor = default(Color);
            pokemon6Move4Box.BackColor = default(Color);


            pokemon1GroupBox.BackColor = default(Color);
            pokemon2GroupBox.BackColor = default(Color);
            pokemon3GroupBox.BackColor = default(Color);
            pokemon4GroupBox.BackColor = default(Color);
            pokemon5GroupBox.BackColor = default(Color);
            pokemon6GroupBox.BackColor = default(Color);
            pokemon1Moves = pokemon1Move1Box.Text + pokemon1Move2Box.Text + pokemon1Move3Box.Text + pokemon1Move4Box.Text;
            pokemon2Moves = pokemon2Move1Box.Text + pokemon2Move2Box.Text + pokemon2Move3Box.Text + pokemon2Move4Box.Text;
            pokemon3Moves = pokemon3Move1Box.Text + pokemon3Move2Box.Text + pokemon3Move1Box.Text + pokemon3Move4Box.Text;
            pokemon4Moves = pokemon4Move1Box.Text + pokemon4Move2Box.Text + pokemon4Move3Box.Text + pokemon4Move4Box.Text;
            pokemon5Moves = pokemon5Move1Box.Text + pokemon5Move2Box.Text + pokemon5Move3Box.Text + pokemon5Move4Box.Text;
            pokemon6Moves = pokemon6Move1Box.Text + pokemon6Move2Box.Text + pokemon6Move3Box.Text + pokemon6Move4Box.Text;
            typeBox.Enabled = true;
            typeBox.Clear();
            submitTypeButton.Enabled = true;
            searchButton.Enabled = true;
            if (pokemon1Box.Text != "")
            {
                pokemon1 = pokemon1Box.Text;
            }
            if (pokemon2Box.Text != "")
            {
                pokemon2 = pokemon2Box.Text;
            }
            if (pokemon3Box.Text != "")
            {
                pokemon3 = pokemon3Box.Text;
            }
            if (pokemon4Box.Text != "")
            {
                pokemon4 = pokemon4Box.Text;
            }
            if (pokemon5Box.Text != "")
            {
                pokemon5 = pokemon5Box.Text;
            }
            if (pokemon6Box.Text != "")
            {
                pokemon6 = pokemon6Box.Text;
            }
            pokemon1Move1Box.Text = pokemon1Move1Box.Text.ToUpper();
            pokemon1Move2Box.Text = pokemon1Move2Box.Text.ToUpper();
            pokemon1Move3Box.Text = pokemon1Move3Box.Text.ToUpper();
            pokemon1Move4Box.Text = pokemon1Move4Box.Text.ToUpper();

            pokemon2Move1Box.Text = pokemon2Move1Box.Text.ToUpper();
            pokemon2Move2Box.Text = pokemon2Move2Box.Text.ToUpper();
            pokemon2Move3Box.Text = pokemon2Move3Box.Text.ToUpper();
            pokemon2Move4Box.Text = pokemon2Move4Box.Text.ToUpper();

            pokemon3Move1Box.Text = pokemon3Move1Box.Text.ToUpper();
            pokemon3Move2Box.Text = pokemon3Move2Box.Text.ToUpper();
            pokemon3Move3Box.Text = pokemon3Move3Box.Text.ToUpper();
            pokemon3Move4Box.Text = pokemon3Move4Box.Text.ToUpper();

            pokemon4Move1Box.Text = pokemon4Move1Box.Text.ToUpper();
            pokemon4Move2Box.Text = pokemon4Move2Box.Text.ToUpper();
            pokemon4Move3Box.Text = pokemon4Move3Box.Text.ToUpper();
            pokemon4Move4Box.Text = pokemon4Move4Box.Text.ToUpper();

            pokemon5Move1Box.Text = pokemon5Move1Box.Text.ToUpper();
            pokemon5Move2Box.Text = pokemon5Move2Box.Text.ToUpper();
            pokemon5Move3Box.Text = pokemon5Move3Box.Text.ToUpper();
            pokemon5Move4Box.Text = pokemon5Move4Box.Text.ToUpper();

            pokemon6Move1Box.Text = pokemon6Move1Box.Text.ToUpper();
            pokemon6Move2Box.Text = pokemon6Move2Box.Text.ToUpper();
            pokemon6Move3Box.Text = pokemon6Move3Box.Text.ToUpper();
            pokemon6Move4Box.Text = pokemon6Move4Box.Text.ToUpper();

        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            //TYPE
            typeBox.Enabled = false;
            typeBox.Clear();
            submitTypeButton.Enabled = false;
            searchButton.Enabled = false;
            //POKEMON NAMES
            pokemon1Box.Clear();
            pokemon2Box.Clear();
            pokemon3Box.Clear();
            pokemon4Box.Clear();
            pokemon5Box.Clear();
            pokemon6Box.Clear();
            //GROUP BOXES
            pokemon1GroupBox.BackColor = default(Color);
            pokemon2GroupBox.BackColor = default(Color);
            pokemon3GroupBox.BackColor = default(Color);
            pokemon4GroupBox.BackColor = default(Color);
            pokemon5GroupBox.BackColor = default(Color);
            pokemon6GroupBox.BackColor = default(Color);
            //MOVE TEXTBOXES
            pokemon1Move1Box.Clear();
            pokemon1Move2Box.Clear();
            pokemon1Move3Box.Clear();
            pokemon1Move4Box.Clear();

            pokemon2Move1Box.Clear();
            pokemon2Move2Box.Clear();
            pokemon2Move3Box.Clear();
            pokemon2Move4Box.Clear();

            pokemon3Move1Box.Clear();
            pokemon3Move2Box.Clear();
            pokemon3Move3Box.Clear();
            pokemon3Move4Box.Clear();

            pokemon4Move1Box.Clear();
            pokemon4Move2Box.Clear();
            pokemon4Move3Box.Clear();
            pokemon4Move4Box.Clear();

            pokemon5Move1Box.Clear();
            pokemon5Move2Box.Clear();
            pokemon5Move3Box.Clear();
            pokemon5Move4Box.Clear();

            pokemon6Move1Box.Clear();
            pokemon6Move2Box.Clear();
            pokemon6Move3Box.Clear();
            pokemon6Move4Box.Clear();

            pokemon1Move1Box.BackColor = default(Color);
            pokemon1Move2Box.BackColor = default(Color);
            pokemon1Move3Box.BackColor = default(Color);
            pokemon1Move4Box.BackColor = default(Color);

            pokemon2Move1Box.BackColor = default(Color);
            pokemon2Move2Box.BackColor = default(Color);
            pokemon2Move3Box.BackColor = default(Color);
            pokemon2Move4Box.BackColor = default(Color);

            pokemon3Move1Box.BackColor = default(Color);
            pokemon3Move2Box.BackColor = default(Color);
            pokemon3Move3Box.BackColor = default(Color);
            pokemon3Move4Box.BackColor = default(Color);

            pokemon4Move1Box.BackColor = default(Color);
            pokemon4Move2Box.BackColor = default(Color);
            pokemon4Move3Box.BackColor = default(Color);
            pokemon4Move4Box.BackColor = default(Color);

            pokemon5Move1Box.BackColor = default(Color);
            pokemon5Move2Box.BackColor = default(Color);
            pokemon5Move3Box.BackColor = default(Color);
            pokemon5Move4Box.BackColor = default(Color);

            pokemon6Move1Box.BackColor = default(Color);
            pokemon6Move2Box.BackColor = default(Color);
            pokemon6Move3Box.BackColor = default(Color);
            pokemon6Move4Box.BackColor = default(Color);
        }
        private void searchButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://bulbapedia.bulbagarden.net/wiki/" + typeBox.Text.ToLower());
            typeBox.Clear();
        }
        private void submitTypeButton_Click(object sender, EventArgs e)
        {
            pokemon1Move1Box.BackColor = default(Color);
            pokemon1Move2Box.BackColor = default(Color);
            pokemon1Move3Box.BackColor = default(Color);
            pokemon1Move4Box.BackColor = default(Color);

            pokemon2Move1Box.BackColor = default(Color);
            pokemon2Move2Box.BackColor = default(Color);
            pokemon2Move3Box.BackColor = default(Color);
            pokemon2Move4Box.BackColor = default(Color);

            pokemon3Move1Box.BackColor = default(Color);
            pokemon3Move2Box.BackColor = default(Color);
            pokemon3Move3Box.BackColor = default(Color);
            pokemon3Move4Box.BackColor = default(Color);

            pokemon4Move1Box.BackColor = default(Color);
            pokemon4Move2Box.BackColor = default(Color);
            pokemon4Move3Box.BackColor = default(Color);
            pokemon4Move4Box.BackColor = default(Color);

            pokemon5Move1Box.BackColor = default(Color);
            pokemon5Move2Box.BackColor = default(Color);
            pokemon5Move3Box.BackColor = default(Color);
            pokemon5Move4Box.BackColor = default(Color);

            pokemon6Move1Box.BackColor = default(Color);
            pokemon6Move2Box.BackColor = default(Color);
            pokemon6Move3Box.BackColor = default(Color);
            pokemon6Move4Box.BackColor = default(Color);
            pokemon1GroupBox.BackColor = default(Color);
            pokemon2GroupBox.BackColor = default(Color);
            pokemon3GroupBox.BackColor = default(Color);
            pokemon4GroupBox.BackColor = default(Color);
            pokemon5GroupBox.BackColor = default(Color);
            pokemon6GroupBox.BackColor = default(Color);
            typeBox.Text = typeBox.Text.ToUpper();
            if (types.Contains(typeBox.Text))
            {
                if (typeBox.Text == "NORMAL")
                {
                    changeBoxColor("FIGHTING");
                }
                if (typeBox.Text == "FIRE")
                {
                    changeBoxColor("WATER");
                    changeBoxColor("GROUND");
                    changeBoxColor("ROCK");
                }
                if (typeBox.Text == "WATER")
                {
                    changeBoxColor("ELECTRIC");
                    changeBoxColor("GRASS");
                }

                if (typeBox.Text == "ELECTRIC")
                {
                    changeBoxColor("GROUND");
                }

                if (typeBox.Text == "GRASS")
                {
                    changeBoxColor("FIRE");
                    changeBoxColor("ICE");
                    changeBoxColor("POISON");
                    changeBoxColor("FLYING");
                    changeBoxColor("BUG");
                }

                if (typeBox.Text == "ICE")
                {
                    changeBoxColor("FIRE");
                    changeBoxColor("FIGHTING");
                    changeBoxColor("ROCK");
                    changeBoxColor("STEEL");
                }

                if (typeBox.Text == "FIGHTING")
                {
                    changeBoxColor("FLYING");
                    changeBoxColor("PSYCHIC");
                    changeBoxColor("FAIRY");
                }

                if (typeBox.Text == "POISON")
                {
                    changeBoxColor("GROUND");
                    changeBoxColor("PSYCHIC");
                }

                if (typeBox.Text == "GROUND")
                {
                    changeBoxColor("WATER");
                    changeBoxColor("GRASS");
                    changeBoxColor("ICE");
                }

                if (typeBox.Text == "FLYING")
                {
                    changeBoxColor("ELECTRIC");
                    changeBoxColor("ICE");
                    changeBoxColor("ROCK");
                }

                if (typeBox.Text == "PSYCHIC")
                {
                    changeBoxColor("BUG");
                    changeBoxColor("GHOST");
                    changeBoxColor("DARK");
                }

                if (typeBox.Text == "BUG")
                {
                    changeBoxColor("FIRE");
                    changeBoxColor("FLYING");
                    changeBoxColor("ROCK");
                }

                if (typeBox.Text == "ROCK")
                {
                    changeBoxColor("WATER");
                    changeBoxColor("GRASS");
                    changeBoxColor("FIGHTING");
                    changeBoxColor("GROUND");
                    changeBoxColor("STEEL");
                }

                if (typeBox.Text == "GHOST")
                {
                    changeBoxColor("GHOST");
                    changeBoxColor("DARK");
                }

                if (typeBox.Text == "DRAGON")
                {
                    changeBoxColor("ICE");
                    changeBoxColor("DRAGON");
                    changeBoxColor("FAIRY");
                }

                if (typeBox.Text == "DARK")
                {
                    changeBoxColor("FIGHTING");
                    changeBoxColor("BUG");
                    changeBoxColor("FAIRY");
                }

                if (typeBox.Text == "STEEL")
                {
                    changeBoxColor("FIRE");
                    changeBoxColor("FIGHTING");
                    changeBoxColor("GROUND");
                }

                if (typeBox.Text == "FAIRY")
                {
                    changeBoxColor("POISON");
                    changeBoxColor("STEEL");
                }

            }

            else
            {
                MessageBox.Show("Please Enter an Existing Type", "Type Not Found");
            }
        }
        public void changeBoxColor(String type)
        {
            if (pokemon1Moves.Contains(type))
            {
                pokemon1GroupBox.BackColor = Color.LightGreen;
                if (pokemon1Move1Box.Text.Contains(type))
                {
                    pokemon1Move1Box.BackColor = Color.Yellow;
                }
                if (pokemon1Move2Box.Text.Contains(type))
                {
                    pokemon1Move2Box.BackColor = Color.Yellow;
                }
                if (pokemon1Move3Box.Text.Contains(type))
                {
                    pokemon1Move3Box.BackColor = Color.Yellow;
                }
                if (pokemon1Move4Box.Text.Contains(type))
                {
                    pokemon1Move4Box.BackColor = Color.Yellow;
                }
            }
            if (pokemon2Moves.Contains(type))
            {
                pokemon2GroupBox.BackColor = Color.LightGreen;
                if (pokemon2Move1Box.Text.Contains(type))
                {
                    pokemon2Move1Box.BackColor = Color.Yellow;
                }
                if (pokemon2Move2Box.Text.Contains(type))
                {
                    pokemon2Move2Box.BackColor = Color.Yellow;
                }
                if (pokemon2Move3Box.Text.Contains(type))
                {
                    pokemon2Move3Box.BackColor = Color.Yellow;
                }
                if (pokemon2Move4Box.Text.Contains(type))
                {
                    pokemon2Move4Box.BackColor = Color.Yellow;
                }
            }
            if (pokemon3Moves.Contains(type))
            {
                pokemon3GroupBox.BackColor = Color.LightGreen;
                if (pokemon3Move1Box.Text.Contains(type))
                {
                    pokemon3Move1Box.BackColor = Color.Yellow;
                }
                if (pokemon3Move2Box.Text.Contains(type))
                {
                    pokemon3Move2Box.BackColor = Color.Yellow;
                }
                if (pokemon3Move3Box.Text.Contains(type))
                {
                    pokemon3Move3Box.BackColor = Color.Yellow;
                }
                if (pokemon3Move4Box.Text.Contains(type))
                {
                    pokemon3Move4Box.BackColor = Color.Yellow;
                }
            }
            if (pokemon4Moves.Contains(type))
            {
                pokemon4GroupBox.BackColor = Color.LightGreen;
                if (pokemon4Move1Box.Text.Contains(type))
                {
                    pokemon4Move1Box.BackColor = Color.Yellow;
                }
                if (pokemon4Move2Box.Text.Contains(type))
                {
                    pokemon4Move2Box.BackColor = Color.Yellow;
                }
                if (pokemon4Move3Box.Text.Contains(type))
                {
                    pokemon4Move3Box.BackColor = Color.Yellow;
                }
                if (pokemon4Move4Box.Text.Contains(type))
                {
                    pokemon4Move4Box.BackColor = Color.Yellow;
                }
            }
            if (pokemon5Moves.Contains(type))
            {
                pokemon5GroupBox.BackColor = Color.LightGreen;
                if (pokemon5Move1Box.Text.Contains(type))
                {
                    pokemon5Move1Box.BackColor = Color.Yellow;
                }
                if (pokemon5Move2Box.Text.Contains(type))
                {
                    pokemon5Move2Box.BackColor = Color.Yellow;
                }
                if (pokemon5Move3Box.Text.Contains(type))
                {
                    pokemon5Move3Box.BackColor = Color.Yellow;
                }
                if (pokemon5Move4Box.Text.Contains(type))
                {
                    pokemon5Move4Box.BackColor = Color.Yellow;
                }
            }
            if (pokemon6Moves.Contains(type))
            {
                pokemon6GroupBox.BackColor = Color.LightGreen;
                if (pokemon6Move1Box.Text.Contains(type))
                {
                    pokemon6Move1Box.BackColor = Color.Yellow;
                }
                if (pokemon6Move2Box.Text.Contains(type))
                {
                    pokemon6Move2Box.BackColor = Color.Yellow;
                }
                if (pokemon6Move3Box.Text.Contains(type))
                {
                    pokemon6Move3Box.BackColor = Color.Yellow;
                }
                if (pokemon6Move4Box.Text.Contains(type))
                {
                    pokemon6Move4Box.BackColor = Color.Yellow;
                }
            }
        }
    }
}
