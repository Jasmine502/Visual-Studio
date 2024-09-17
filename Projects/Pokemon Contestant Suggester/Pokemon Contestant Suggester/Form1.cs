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

        // Store Pokemon names and moves
        private string[] pokemonNames = new string[6];
        private string[][] pokemonMoves = new string[6][];

        // Type list
        private string[] types = { "NORMAL", "FIRE", "WATER", "ELECTRIC", "GRASS", "ICE", "FIGHTING", "POISON", "GROUND", "FLYING", "PSYCHIC", "BUG", "ROCK", "GHOST", "DRAGON", "DARK", "STEEL", "FAIRY" };

        private void Form1_Load(object sender, EventArgs e)
        {
            // Initialize Pokemon names
            for (int i = 0; i < 6; i++)
            {
                pokemonNames[i] = $"Pokemon {i + 1}";
            }
        }

        private void submitTeamButton_Click(object sender, EventArgs e)
        {
            // Reset colors
            ResetColors();

            // Store Pokemon names and moves
            for (int i = 0; i < 6; i++)
            {
                if (!string.IsNullOrEmpty(GetPokemonBox(i).Text))
                {
                    pokemonNames[i] = GetPokemonBox(i).Text;
                }
                pokemonMoves[i] = GetMoveBoxes(i).Select(box => box.Text.ToUpper()).ToArray();
            }

            // Enable type selection and search
            typeBox.Enabled = true;
            typeBox.Clear();
            submitTypeButton.Enabled = true;
            searchButton.Enabled = true;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            // Disable type selection and search
            typeBox.Enabled = false;
            typeBox.Clear();
            submitTypeButton.Enabled = false;
            searchButton.Enabled = false;

            // Clear Pokemon names and moves
            for (int i = 0; i < 6; i++)
            {
                GetPokemonBox(i).Clear();
                foreach (var moveBox in GetMoveBoxes(i))
                {
                    moveBox.Clear();
                }
            }

            // Reset colors
            ResetColors();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://bulbapedia.bulbagarden.net/wiki/" + typeBox.Text.ToLower());
            typeBox.Clear();
        }

        private void submitTypeButton_Click(object sender, EventArgs e)
        {
            // Reset colors
            ResetColors();

            // Validate type input
            typeBox.Text = typeBox.Text.ToUpper();
            if (types.Contains(typeBox.Text))
            {
                // Highlight vulnerable Pokemon and moves
                foreach (var type in GetVulnerableTypes(typeBox.Text))
                {
                    ChangeBoxColor(type);
                }
            }
            else
            {
                MessageBox.Show("Please Enter an Existing Type", "Type Not Found");
            }
        }

        private void ChangeBoxColor(string type)
        {
            for (int i = 0; i < 6; i++)
            {
                if (pokemonMoves[i].Any(move => move.Contains(type)))
                {
                    GetPokemonGroupBox(i).BackColor = Color.LightGreen;
                    foreach (var moveBox in GetMoveBoxes(i))
                    {
                        if (moveBox.Text.Contains(type))
                        {
                            moveBox.BackColor = Color.Yellow;
                        }
                    }
                }
            }
        }

        private void ResetColors()
        {
            for (int i = 0; i < 6; i++)
            {
                GetPokemonGroupBox(i).BackColor = default(Color);
                foreach (var moveBox in GetMoveBoxes(i))
                {
                    moveBox.BackColor = default(Color);
                }
            }
        }

        // Helper methods to access controls
        private TextBox GetPokemonBox(int index)
        {
            switch (index)
            {
                case 0: return pokemon1Box;
                case 1: return pokemon2Box;
                case 2: return pokemon3Box;
                case 3: return pokemon4Box;
                case 4: return pokemon5Box;
                case 5: return pokemon6Box;
                default: throw new ArgumentOutOfRangeException(nameof(index));
            }
        }

        private GroupBox GetPokemonGroupBox(int index)
        {
            switch (index)
            {
                case 0: return pokemon1GroupBox;
                case 1: return pokemon2GroupBox;
                case 2: return pokemon3GroupBox;
                case 3: return pokemon4GroupBox;
                case 4: return pokemon5GroupBox;
                case 5: return pokemon6GroupBox;
                default: throw new ArgumentOutOfRangeException(nameof(index));
            }
        }

        private TextBox[] GetMoveBoxes(int index)
        {
            switch (index)
            {
                case 0: return new[] { pokemon1Move1Box, pokemon1Move2Box, pokemon1Move3Box, pokemon1Move4Box };
                case 1: return new[] { pokemon2Move1Box, pokemon2Move2Box, pokemon2Move3Box, pokemon2Move4Box };
                case 2: return new[] { pokemon3Move1Box, pokemon3Move2Box, pokemon3Move3Box, pokemon3Move4Box };
                case 3: return new[] { pokemon4Move1Box, pokemon4Move2Box, pokemon4Move3Box, pokemon4Move4Box };
                case 4: return new[] { pokemon5Move1Box, pokemon5Move2Box, pokemon5Move3Box, pokemon5Move4Box };
                case 5: return new[] { pokemon6Move1Box, pokemon6Move2Box, pokemon6Move3Box, pokemon6Move4Box };
                default: throw new ArgumentOutOfRangeException(nameof(index));
            }
        }

        // Type effectiveness dictionary
        private Dictionary<string, string[]> typeEffectiveness = new Dictionary<string, string[]>
        {
            { "NORMAL", new[] { "FIGHTING" } },
            { "FIRE", new[] { "WATER", "GROUND", "ROCK" } },
            { "WATER", new[] { "ELECTRIC", "GRASS" } },
            { "ELECTRIC", new[] { "GROUND" } },
            { "GRASS", new[] { "FIRE", "ICE", "POISON", "FLYING", "BUG" } },
            { "ICE", new[] { "FIRE", "FIGHTING", "ROCK", "STEEL" } },
            { "FIGHTING", new[] { "FLYING", "PSYCHIC", "FAIRY" } },
            { "POISON", new[] { "GROUND", "PSYCHIC" } },
            { "GROUND", new[] { "WATER", "GRASS", "ICE" } },
            { "FLYING", new[] { "ELECTRIC", "ICE", "ROCK" } },
            { "PSYCHIC", new[] { "BUG", "GHOST", "DARK" } },
            { "BUG", new[] { "FIRE", "FLYING", "ROCK" } },
            { "ROCK", new[] { "WATER", "GRASS", "FIGHTING", "GROUND", "STEEL" } },
            { "GHOST", new[] { "GHOST", "DARK" } },
            { "DRAGON", new[] { "ICE", "DRAGON", "FAIRY" } },
            { "DARK", new[] { "FIGHTING", "BUG", "FAIRY" } },
            { "STEEL", new[] { "FIRE", "FIGHTING", "GROUND" } },
            { "FAIRY", new[] { "POISON", "STEEL" } }
        };

        private string[] GetVulnerableTypes(string type)
        {
            // Replace GetValueOrDefault with TryGetValue
            string[] vulnerableTypes;
            typeEffectiveness.TryGetValue(type, out vulnerableTypes);
            return vulnerableTypes; // Return the result
        }
    }
}
