using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
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
        private readonly string[] pokemonNames = new string[6];
        private readonly string[][] pokemonMoves = new string[6][];

        // Type list
        private readonly string[] types = { "NORMAL", "FIRE", "WATER", "ELECTRIC", "GRASS", "ICE", "FIGHTING", "POISON", "GROUND", "FLYING", "PSYCHIC", "BUG", "ROCK", "GHOST", "DRAGON", "DARK", "STEEL", "FAIRY" };

        // Controls arrays for easier access
        private TextBox[] pokemonBoxes;
        private GroupBox[] pokemonGroupBoxes;
        private TextBox[][] moveBoxes;

        private void Form1_Load(object sender, EventArgs e)
        {
            // Initialize Pokemon names
            for (var i = 0; i < 6; i++)
            {
                pokemonNames[i] = $"Pokemon {i + 1}";
            }

            // Initialize control arrays
            pokemonBoxes = new[] { pokemon1Box, pokemon2Box, pokemon3Box, pokemon4Box, pokemon5Box, pokemon6Box };
            pokemonGroupBoxes = new[] { pokemon1GroupBox, pokemon2GroupBox, pokemon3GroupBox, pokemon4GroupBox, pokemon5GroupBox, pokemon6GroupBox };
            moveBoxes = new[]
            {
                new[] { pokemon1Move1Box, pokemon1Move2Box, pokemon1Move3Box, pokemon1Move4Box },
                new[] { pokemon2Move1Box, pokemon2Move2Box, pokemon2Move3Box, pokemon2Move4Box },
                new[] { pokemon3Move1Box, pokemon3Move2Box, pokemon3Move3Box, pokemon3Move4Box },
                new[] { pokemon4Move1Box, pokemon4Move2Box, pokemon4Move3Box, pokemon4Move4Box },
                new[] { pokemon5Move1Box, pokemon5Move2Box, pokemon5Move3Box, pokemon5Move4Box },
                new[] { pokemon6Move1Box, pokemon6Move2Box, pokemon6Move3Box, pokemon6Move4Box }
            };
        }

        private void submitTeamButton_Click(object sender, EventArgs e)
        {
            ResetColors();

            // Store Pokemon names and moves
            for (var i = 0; i < 6; i++)
            {
                if (!string.IsNullOrEmpty(pokemonBoxes[i].Text))
                {
                    pokemonNames[i] = pokemonBoxes[i].Text;
                }
                pokemonMoves[i] = moveBoxes[i].Select(box => box.Text.ToUpper()).ToArray();
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
            foreach (var box in pokemonBoxes)
            {
                box.Clear();
            }

            foreach (var moves in moveBoxes)
            {
                foreach (var moveBox in moves)
                {
                    moveBox.Clear();
                }
            }

            ResetColors();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://bulbapedia.bulbagarden.net/wiki/" + typeBox.Text.ToLower());
            typeBox.Clear();
        }

        private void submitTypeButton_Click(object sender, EventArgs e)
        {
            ResetColors();

            // Validate type input
            typeBox.Text = typeBox.Text.ToUpper();
            if (types.Contains(typeBox.Text, StringComparer.OrdinalIgnoreCase))
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
            for (var i = 0; i < 6; i++)
            {
                if (pokemonMoves[i].Any(move => move != null && move.IndexOf(type, StringComparison.OrdinalIgnoreCase) >= 0))
                {
                    pokemonGroupBoxes[i].BackColor = Color.LightGreen;
                    foreach (var moveBox in moveBoxes[i])
                    {
                        if (moveBox.Text.IndexOf(type, StringComparison.OrdinalIgnoreCase) >= 0)
                        {
                            moveBox.BackColor = Color.Yellow;
                        }
                    }
                }
            }
        }

        private void ResetColors()
        {
            foreach (var groupBox in pokemonGroupBoxes)
            {
                groupBox.BackColor = Color.Empty;
            }

            foreach (var moves in moveBoxes)
            {
                foreach (var moveBox in moves)
                {
                    moveBox.BackColor = Color.Empty;
                }
            }
        }

        private string[] GetVulnerableTypes(string type)
        {
            return typeEffectiveness.TryGetValue(type, out var vulnerableTypes) ? vulnerableTypes : Array.Empty<string>();
        }

        // Type effectiveness dictionary
        private readonly Dictionary<string, string[]> typeEffectiveness = new Dictionary<string, string[]>
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
    }
}
