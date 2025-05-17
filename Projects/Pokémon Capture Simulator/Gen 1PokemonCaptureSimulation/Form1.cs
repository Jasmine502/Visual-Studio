using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using System.Media;
using System.Collections.Generic;

namespace Gen_1PokemonCaptureSimulation
{
    public partial class Form1 : Form
    {
        // Constants
        private const int DEFAULT_MONEY = 500;
        private const int DEFAULT_POKEBALLS = 10;
        private const int DEFAULT_GREATBALLS = 5;
        private const int DEFAULT_ULTRABALLS = 3;
        private const int DEFAULT_SAFARIBALLS = 3;
        private const int DEFAULT_MASTERBALLS = 1;
        private const int DEFAULT_MEGASTONES = 0;
        private const long MAX_MONEY = 9999999999;
        private const int MIN_MONEY = 0;
        private const int MAX_HP = 255;
        private const int POKEBALL_COST = 200;
        private const int GREATBALL_COST = 600;
        private const int ULTRABALL_COST = 1200;
        private const int SAFARIBALL_COST = 1700;
        private const int MASTERBALL_COST = 3400;
        private const int MEGASTONE_COST = 10000;
        private const int MIN_CATCH_MONEY = 200;
        private const int MAX_CATCH_MONEY = 1001;
        private const int MAX_BALL_SHAKES = 400;
        private const int FREE_BALL_SHAKES = 250;
        private const int SHAKE_INCREMENT = 6;

        // File paths
        private readonly string filePath = Path.Combine(
            Directory.GetParent(Directory.GetParent(Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).FullName).FullName).FullName,
            "Resources",
            "Pokemon Sprites" + Path.DirectorySeparatorChar);

        // Game state
        private readonly Random rnd = new Random();
        private bool hintShown;
        private int MegaStone, PB, GB, UB, SB, MB;
        private float money, N, statVal, currentBallShakes;
        private Bitmap normalBall, rightBall, leftBall, caughtBall;

        // Game data
        private readonly string[] balls = { "PokeBall", "Master Ball", "Great Ball", "Ultra Ball", "Safari Ball" };
        private readonly string[] megaNames = PokemonData.MegaNames;
        private readonly string[] megas = PokemonData.Megas;
        private readonly string[] pokemon = PokemonData.Pokemon;
        private readonly string[] catchRate3 = PokemonData.CatchRate3;
        private readonly string[] catchRate25 = PokemonData.CatchRate25;
        private readonly string[] catchRate30 = PokemonData.CatchRate30;
        private readonly string[] catchRate45 = PokemonData.CatchRate45;
        private readonly string[] catchRate50 = PokemonData.CatchRate50;
        private readonly string[] catchRate55 = PokemonData.CatchRate55;
        private readonly string[] catchRate60 = PokemonData.CatchRate60;
        private readonly string[] catchRate65 = PokemonData.CatchRate65;
        private readonly string[] catchRate75 = PokemonData.CatchRate75;
        private readonly string[] catchRate90 = PokemonData.CatchRate90;
        private readonly string[] catchRate100 = PokemonData.CatchRate100;
        private readonly string[] catchRate120 = PokemonData.CatchRate120;
        private readonly string[] catchRate125 = PokemonData.CatchRate125;
        private readonly string[] catchRate127 = PokemonData.CatchRate127;
        private readonly string[] catchRate130 = PokemonData.CatchRate130;
        private readonly string[] catchRate140 = PokemonData.CatchRate140;
        private readonly string[] catchRate150 = PokemonData.CatchRate150;
        private readonly string[] catchRate170 = PokemonData.CatchRate170;
        private readonly string[] catchRate180 = PokemonData.CatchRate180;
        private readonly string[] catchRate190 = PokemonData.CatchRate190;
        private readonly string[] catchRate200 = PokemonData.CatchRate200;
        private readonly string[] catchRate220 = PokemonData.CatchRate220;
        private readonly string[] catchRate225 = PokemonData.CatchRate225;
        private readonly string[] catchRate235 = PokemonData.CatchRate235;
        private readonly string[] catchRate255 = PokemonData.CatchRate255;

        // Sound effects
        private readonly SoundPlayer ballToss = new SoundPlayer(Properties.Resources.BALL_TOSS);
        private readonly SoundPlayer ballPoof = new SoundPlayer(Properties.Resources.BALL_POOF);
        private readonly SoundPlayer tink = new SoundPlayer(Properties.Resources.TINK);
        private readonly SoundPlayer denied = new SoundPlayer(Properties.Resources.DENIED);
        private readonly SoundPlayer caughtMon = new SoundPlayer(Properties.Resources.CAUGHT_MON);
        private readonly SoundPlayer purchase = new SoundPlayer(Properties.Resources.PURCHASE);
        private readonly SoundPlayer megaEvolve = new SoundPlayer(Properties.Resources.MEGA_EVOLVE);
        private readonly SoundPlayer withdrawDeposit = new SoundPlayer(Properties.Resources.WITHDRAW_DEPOSIT);
        private readonly SoundPlayer run = new SoundPlayer(Properties.Resources.RUN);

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitializeGameState();
        }

        private void InitializeGameState()
        {
            MegaStone = DEFAULT_MEGASTONES;
            PB = DEFAULT_POKEBALLS;
            GB = DEFAULT_GREATBALLS;
            SB = DEFAULT_SAFARIBALLS;
            UB = DEFAULT_ULTRABALLS;
            MB = DEFAULT_MASTERBALLS;
            money = DEFAULT_MONEY;
            moneyLabel.Text = money.ToString();
        }

        private void throwBallButton_Click(object sender, EventArgs e)
        {
            if (!ValidateThrowBallInput())
            {
                return;
            }

            SetStatusValue();
            if (!SelectBallAndResources())
            {
                return;
            }

            DetermineCatch();
            DisableControls(true);
            ballToss.Play();
        }

        private bool ValidateThrowBallInput()
        {
            if (string.IsNullOrEmpty(pokemonBox.Text))
            {
                denied.Play();
                MessageBox.Show("Please enter an existing Pokémon into the textbox.", "Battle Error");
                return false;
            }

            if (string.IsNullOrEmpty(ballChosenBox.Text))
            {
                denied.Play();
                MessageBox.Show("Please enter the type of ball you are using to attempt to catch the Pokémon.");
                return false;
            }

            if (!ValidateHPInput())
            {
                return false;
            }

            return true;
        }

        private bool ValidateHPInput()
        {
            if (string.IsNullOrEmpty(pokMaxHPBox.Text) || float.Parse(pokMaxHPBox.Text) > MAX_HP)
            {
                denied.Play();
                MessageBox.Show("Please enter a valid maximum HP for the Pokémon.");
                return false;
            }

            if (string.IsNullOrEmpty(pokCurrentHPBox.Text) || float.Parse(pokCurrentHPBox.Text) > float.Parse(pokMaxHPBox.Text))
            {
                denied.Play();
                MessageBox.Show("Please enter a valid current HP for the Pokémon that does not exceed the maximum HP.");
                return false;
            }

            return true;
        }

        private void SetStatusValue()
        {
            string status = pokStatusBox.Text.ToUpper();
            statVal = status switch
            {
                "SLP" or "FRZ" => 25,
                "PAR" or "BRN" or "PSN" => 12,
                _ => 0
            };
        }

        private bool SelectBallAndResources()
        {
            string ballType = ballChosenBox.Text.ToUpper();
            
            if (ballType.Contains("POK") && PB > 0)
            {
                PB--;
                N = rnd.Next(0, 255);
                SetBallImages(Properties.Resources.PokeBall_normal, Properties.Resources.PokeBall_right,
                            Properties.Resources.PokeBall_left, Properties.Resources.PokeBall_caught);
            }
            else if (ballType.Contains("GRE") && GB > 0)
            {
                GB--;
                N = rnd.Next(0, 200);
                SetBallImages(Properties.Resources.Great_Ball_normal, Properties.Resources.Great_Ball_right,
                            Properties.Resources.Great_Ball_left, Properties.Resources.Great_Ball_caught);
            }
            else if (ballType.Contains("ULT") && UB > 0)
            {
                UB--;
                N = rnd.Next(0, 150);
                SetBallImages(Properties.Resources.Ultra_Ball_normal, Properties.Resources.Ultra_Ball_right,
                            Properties.Resources.Ultra_Ball_left, Properties.Resources.Ultra_Ball_caught);
            }
            else if (ballType.Contains("SAF") && SB > 0)
            {
                SB--;
                N = rnd.Next(0, 150);
                SetBallImages(Properties.Resources.Safari_Ball, Properties.Resources.Safari_Ball_right,
                            Properties.Resources.Safari_Ball_left, Properties.Resources.Safari_Ball_caught);
            }
            else if (ballType.Contains("MAS") && MB > 0)
            {
                MB--;
                caughtTimer.Start();
                currentBallShakes = 0;
                SetBallImages(Properties.Resources.Master_Ball_normal, Properties.Resources.Master_Ball_right,
                            Properties.Resources.Master_Ball_left, Properties.Resources.Master_Ball_caught);
            }
            else
            {
                MessageBox.Show("You don't have enough of the chosen ball type.");
                return false;
            }

            return true;
        }

        private void SetBallImages(Bitmap normal, Bitmap right, Bitmap left, Bitmap caught)
        {
            normalBall = normal;
            rightBall = right;
            leftBall = left;
            caughtBall = caught;
        }

        private void DetermineCatch()
        {
            float maxHP = float.Parse(pokMaxHPBox.Text);
            float currentHP = float.Parse(pokCurrentHPBox.Text);
            float catchRate = float.Parse(catchRateBox.Text);

            bool willCatch = N < (3 * maxHP - 2 * currentHP) * catchRate * statVal / (3 * maxHP);
            
            if (willCatch || ballChosenBox.Text.ToUpper().Contains("MAS"))
            {
                caughtTimer.Start();
            }
            else
            {
                freeTimer.Start();
            }
            
            currentBallShakes = 0;
        }

        private void caughtTimer_Tick(object sender, EventArgs e)
        {
            currentBallShakes += SHAKE_INCREMENT;

            if (currentBallShakes >= MAX_BALL_SHAKES)
            {
                HandleSuccessfulCatch();
            }
            else
            {
                UpdateBallAnimation();
            }
        }

        private void HandleSuccessfulCatch()
        {
            caughtTimer.Stop();
            
            int moneyToAdd = CalculateCatchReward();
            money += moneyToAdd;
            UpdateMoneyDisplay();

            caughtLabel.Text = pokemonBox.Text.ToUpper() + " Caught!";
            caughtMon.Play();
            pokeBallBox.Image = caughtBall;

            AddPokemonToTeam();
            ResetInputFields();
            EnableControls();
        }

        private int CalculateCatchReward()
        {
            int moneyToAdd = rnd.Next(MIN_CATCH_MONEY, MAX_CATCH_MONEY);
            moneyToAdd *= (int)(255 / float.Parse(catchRateBox.Text));

            if (ballChosenBox.Text.ToUpper().Contains("MAS"))
            {
                moneyToAdd /= 10;
            }

            return moneyToAdd;
        }

        private void UpdateMoneyDisplay()
        {
            moneyLabel.Text = money.ToString();
        }

        private void AddPokemonToTeam()
        {
            if (pokemonTeamBox.Items.Count < 6)
            {
                pokemonTeamBox.Items.Add(pokemonBox.Text.ToUpper());
            }
            else
            {
                pcBox.Items.Add(pokemonBox.Text.ToUpper());
            }
        }

        private void ResetInputFields()
        {
            ballChosenBox.Clear();
            pokStatusBox.Clear();
            catchRateBox.Clear();
            pokMaxHPBox.Clear();
            pokCurrentHPBox.Clear();
            pokemonBox.Clear();
        }

        private void EnableControls()
        {
            battleButton.Enabled = true;
            battleButton.Text = "Battle";
            randomPokemonButton.Enabled = true;
            pokemonBox.Enabled = true;
            pokemonTeamBox.Enabled = true;
            pcBox.Enabled = true;
        }

        private void UpdateBallAnimation()
        {
            if (currentBallShakes < 50)
            {
                caughtLabel.Text = "Good aim!";
                pokeBallBox.Image = normalBall;
            }
            else if (currentBallShakes < 100)
            {
                caughtLabel.Text = "";
                pokeBallBox.Image = rightBall;
            }
            else if (currentBallShakes < 150 || (currentBallShakes >= 200 && currentBallShakes < 250) || (currentBallShakes >= 300 && currentBallShakes < 350))
            {
                pokeBallBox.Image = normalBall;
            }
            else if (currentBallShakes < 200)
            {
                pokeBallBox.Image = leftBall;
            }
            else if (currentBallShakes < 250)
            {
                caughtLabel.Text = "Almost there!";
                pokeBallBox.Image = normalBall;
            }
            else if (currentBallShakes < 300)
            {
                caughtLabel.Text = "";
                pokeBallBox.Image = rightBall;
            }
            else if (currentBallShakes < 350)
            {
                pokeBallBox.Image = normalBall;
            }
        }

        private void freeTimer_Tick(object sender, EventArgs e)
        {
            currentBallShakes += SHAKE_INCREMENT;

            if (currentBallShakes >= FREE_BALL_SHAKES)
            {
                HandleFailedCatch();
            }
            else
            {
                UpdateFreeBallAnimation();
            }
        }

        private void HandleFailedCatch()
        {
            ballPoof.Play();
            freeTimer.Stop();
            caughtLabel.Text = pokemonBox.Text.ToUpper() + " Broke Free!";
            pokeBallBox.Image = Image.FromFile(filePath + pokemonBox.Text.ToLower() + ".gif");
            
            battleButton.Enabled = true;
            battleButton.Text = "Run";
            DisableControls(false);
            pokemonTeamBox.Enabled = true;
            pcBox.Enabled = true;
        }

        private void UpdateFreeBallAnimation()
        {
            if (currentBallShakes < 50)
            {
                caughtLabel.Text = "Good aim!";
                pokeBallBox.Image = normalBall;
            }
            else if (currentBallShakes < 100)
            {
                pokeBallBox.Image = rightBall;
            }
            else if (currentBallShakes < 150)
            {
                pokeBallBox.Image = normalBall;
            }
            else if (currentBallShakes < 200)
            {
                pokeBallBox.Image = leftBall;
            }
            else if (currentBallShakes < 250)
            {
                caughtLabel.Text = "Almost there!";
                pokeBallBox.Image = normalBall;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"PokeBall ({PB}), Great Ball ({GB}), Ultra Ball ({UB}), Safari Ball ({SB}), Master Ball ({MB}).", "Write either:");

            if (!hintShown)
            {
                MessageBox.Show("Master Balls catch Pokémon with no chance of failure!", "Master Ball Help");
                hintShown = true;
            }
        }

        private void label2_Click(object sender, EventArgs e) //Pokemon Status Label
        {
            MessageBox.Show("Asleep (SLP), Frozen (FRZ), Paralyzed (PAR), Burnt (BRN), Poisoned (PSN), Leave Blank If None", "Write either:");
        }

        private void label3_Click(object sender, EventArgs e) //Catch Rate Label
        {
            MessageBox.Show("A high catch rate makes the Pokémon easier to catch!", "Catch Rate Help");
        }

        private void label4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Number between (1-255)", "Write a:");
        }

        private void currentHPLabel_Click(object sender, EventArgs e)
        {
            string maxHP = pokMaxHPBox.Text;

            if (string.IsNullOrEmpty(maxHP))
            {
                MessageBox.Show("Number between (1-255)", "Write a:");
            }
            else
            {
                MessageBox.Show($"Number between (1-{maxHP})", "Write a:");
            }
        }

        //function that disables/enables the controls for the random buttons and the textboxes
        private void DisableControls(bool disable)
        {
            if (disable)
            {
                randomBallButton.Enabled = false;
                randomStatusButton.Enabled = false;
                randomMaxHPButton.Enabled = false;
                randomCurrentHPButton.Enabled = false;
                ballChosenBox.Enabled = false;
                pokStatusBox.Enabled = false;
                pokMaxHPBox.Enabled = false;
                pokCurrentHPBox.Enabled = false;
                throwBallButton.Enabled = false;
            }
            else
            {
                randomBallButton.Enabled = true;
                randomStatusButton.Enabled = true;
                randomMaxHPButton.Enabled = true;
                randomCurrentHPButton.Enabled = true;
                ballChosenBox.Enabled = true;
                pokStatusBox.Enabled = true;
                pokMaxHPBox.Enabled = true;
                pokCurrentHPBox.Enabled = true;
                throwBallButton.Enabled = true;
            }
        }

        //function that plays the cry of the pokemon
        private void playCry(string pokemonName)
        {
            // remove any spaces from the name or periods
            pokemonName = pokemonName.Replace(" ", "").Replace(".", "");

            // play the cry
            SoundPlayer crySound = new SoundPlayer(Properties.Resources.ResourceManager.GetStream(pokemonName.ToLower()));
            crySound.Play();
        }

        // Function for the Battle Button
        private void Search_Click(object sender, EventArgs e)
        {
            caughtLabel.Text = "";
            throwBallButton.Enabled = true;

            string enteredPokemon = pokemonBox.Text.ToUpper();

            if (string.IsNullOrEmpty(enteredPokemon))
            {
                denied.Play();
                MessageBox.Show("Please enter a Pokémon into the textbox.", "Registry Error");
                
            }
            else if (!pokemon.Contains(enteredPokemon))
            {
                denied.Play();
                MessageBox.Show("Please enter an existing Pokémon into the textbox.", "Registry Error");
            }
            else if (battleButton.Text == "Battle")
            {
                ballChosenBox.Clear();
                pokStatusBox.Clear();
                pokMaxHPBox.Clear();
                pokCurrentHPBox.Clear();
                battleButton.Text = "Run";
                randomPokemonButton.Enabled = false;
                pokemonBox.Enabled = false;
                pokemonTeamBox.Enabled = false;
                pcBox.Enabled = false;
                DisableControls(false);

                
                pokeBallBox.Image = Image.FromFile(filePath + enteredPokemon.ToLower() + ".gif");
                playCry(enteredPokemon);
                
                pokemonBox.Text = enteredPokemon;
                int catchRate;

                switch (enteredPokemon)
                {
                    case "VOLCARONA":
                        catchRate = 15;
                        break;
                    case "DITTO":
                        catchRate = 35;
                        break;
                    case "SLOWKING":
                        catchRate = 70;
                        break;
                    case "MALAMAR":
                        catchRate = 80;
                        break;
                    case "MIME JR.":
                        catchRate = 145;
                        break;
                    case "CRAWDAUNT":
                        catchRate = 155;
                        break;
                    case "FURFROU":
                        catchRate = 160;
                        break;
                    case "CORPHISH":
                        catchRate = 205;
                        break;
                    default:
                        if (catchRate3.Contains(enteredPokemon))
                            catchRate = 3;
                        else if (catchRate25.Contains(enteredPokemon))
                            catchRate = 25;
                        else if (catchRate30.Contains(enteredPokemon))
                            catchRate = 30;
                        else if (catchRate45.Contains(enteredPokemon))
                            catchRate = 45;
                        else if (catchRate50.Contains(enteredPokemon))
                            catchRate = 50;
                        else if (catchRate55.Contains(enteredPokemon))
                            catchRate = 55;
                        else if (catchRate60.Contains(enteredPokemon))
                            catchRate = 60;
                        else if (catchRate65.Contains(enteredPokemon))
                            catchRate = 65;
                        else if (catchRate75.Contains(enteredPokemon))
                            catchRate = 75;
                        else if (catchRate90.Contains(enteredPokemon))
                            catchRate = 90;
                        else if (catchRate100.Contains(enteredPokemon))
                            catchRate = 100;
                        else if (catchRate120.Contains(enteredPokemon))
                            catchRate = 120;
                        else if (catchRate125.Contains(enteredPokemon))
                            catchRate = 125;
                        else if (catchRate127.Contains(enteredPokemon))
                            catchRate = 127;
                        else if (catchRate130.Contains(enteredPokemon))
                            catchRate = 130;
                        else if (catchRate140.Contains(enteredPokemon))
                            catchRate = 140;
                        else if (catchRate150.Contains(enteredPokemon))
                            catchRate = 150;
                        else if (catchRate170.Contains(enteredPokemon))
                            catchRate = 170;
                        else if (catchRate180.Contains(enteredPokemon))
                            catchRate = 180;
                        else if (catchRate190.Contains(enteredPokemon))
                            catchRate = 190;
                        else if (catchRate200.Contains(enteredPokemon))
                            catchRate = 200;
                        else if (catchRate220.Contains(enteredPokemon))
                            catchRate = 220;
                        else if (catchRate225.Contains(enteredPokemon))
                            catchRate = 225;
                        else if (catchRate235.Contains(enteredPokemon))
                            catchRate = 235;
                        else
                            catchRate = 255; // Default catch rate if not found
                        break;
                }

                catchRateBox.Text = catchRate.ToString();

            }
            else if (battleButton.Text == "Run")
            {
                run.Play();
                caughtLabel.Text = "You ran from " + enteredPokemon + "!";
                ballChosenBox.Clear();
                pokStatusBox.Clear();
                pokMaxHPBox.Clear();
                pokCurrentHPBox.Clear();
                catchRateBox.Clear();
                battleButton.Text = "Battle";
                randomPokemonButton.Enabled = true;
                pokemonBox.Enabled = true;
                pokemonBox.Clear();
                pokemonTeamBox.Enabled = true;
                pcBox.Enabled = true;
                pokeBallBox.Image = null;
                DisableControls(true);
            }
        }

        private void label5_Click(object sender, EventArgs e) //Pokemon Name Label
        {
            MessageBox.Show("Put Pokémon Name Here!", "Name Help");
            MessageBox.Show("Catch rate will automatically be fetched.", "Catch Rate Help");
        }

        private void addTeamReleaseButton_Click(object sender, EventArgs e)
        {
            if (pokemonTeamBox.Items.Count < 6)
            {
                string selectedItem = pcBox.SelectedItem?.ToString();
                if (!string.IsNullOrEmpty(selectedItem))
                {
                    pokemonTeamBox.Items.Add(selectedItem);
                    pcBox.Items.Remove(selectedItem);
                    pokeBallBox.Image = null;
                    withdrawDeposit.Play();
                }
            }
            else
            {
                MessageBox.Show("Not Enough Space In Party", "Capacity Error");
            }

            pokemonBox.Clear();
        }

        private void pokemonTeamBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            throwBallButton.Enabled = false;

            if (pokemonTeamBox.SelectedIndex != -1)
            {
                deselectButton.Enabled = true;
                //unselect the pokemon in the pc
                pcBox.SelectedIndex = -1;
                string selectedItem = pokemonTeamBox.SelectedItem.ToString();
                if (MegaStone > 0 && megas.Contains(selectedItem.ToUpper()))
                {
                    megaEvolveButton.Show();
                }

                if (pokemon.Contains(selectedItem) || megaNames.Contains(selectedItem.ToUpper()))
                {
                    pokeBallBox.Image = Image.FromFile(filePath + selectedItem.ToLower() + ".gif");
                    playCry(selectedItem);
                }
                else
                {
                    pokeBallBox.Image = null;
                }

                addToPCButton.Enabled = true;
                caughtLabel.Text = "";
            }
            else
            {
                pokeBallBox.Image = null;
                megaEvolveButton.Hide();
                battleButton.Enabled = true;
                addToPCButton.Enabled = false;
                caughtLabel.Text = "";
                pokemonNameLabel.Text = "Pokémon Name:";
            }

            addToTeamButton.Enabled = false;
            releaseButton.Enabled = false;
        }

        private void pcBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            addToPCButton.Enabled = false;

            if (pcBox.SelectedIndex != -1)
            {
                deselectButton.Enabled = true;
                //unselect the pokemon in the team
                pokemonTeamBox.SelectedIndex = -1;
                
                string selectedItem = pcBox.SelectedItem.ToString();
                if (pokemon.Contains(selectedItem) || megaNames.Contains(selectedItem.ToUpper()))
                {
                    pokeBallBox.Image = Image.FromFile(filePath + selectedItem + ".gif");
                    playCry(selectedItem);
                }
                else
                {
                    pokeBallBox.Image = null;
                }

                addToTeamButton.Enabled = true;
                releaseButton.Enabled = true;
                caughtLabel.Text = "";
            }
            else
            {
                releaseButton.Enabled = false;
                addToTeamButton.Enabled = false;
                pokeBallBox.Image = null;
            }
        }

        private void addToPCButton_Click(object sender, EventArgs e)
        {
            if (pokemonTeamBox.SelectedItem != null)
            {
                pcBox.Items.Add(pokemonTeamBox.SelectedItem.ToString());
                pokemonTeamBox.Items.Remove(pokemonTeamBox.SelectedItem);
                pokeBallBox.Image = null;
                pokemonBox.Clear();
                withdrawDeposit.Play();
            }
        }

        private void releaseButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to release this Pokémon?", "Release Pokémon", MessageBoxButtons.YesNo) != DialogResult.Yes)
            {
                return;
            }

            if (pcBox.SelectedItem != null)
            {
                string releasedPokemon = pcBox.SelectedItem.ToString();
                caughtLabel.Text = $"{releasedPokemon} was released!";
                pcBox.Items.Remove(releasedPokemon);
                pokeBallBox.Image = null;
                pokemonBox.Clear();
            }
        }

        private void label6_Click(object sender, EventArgs e) //Current Team Label
        {
            MessageBox.Show("Pokémon in your party to carry.", "Team Help");
        }

        private void buyPBButton_Click(object sender, EventArgs e)
        {
            PurchaseItem(POKEBALL_COST, () => PB++);
        }

        private void buyPBButton_MouseHover(object sender, EventArgs e)
        {
            pointer1.Show();
            martLogo.Image = Properties.Resources.PokeBall_Display;
        }

        private void buyGBButton_MouseHover(object sender, EventArgs e)
        {
            pointer2.Show();
            martLogo.Image = Properties.Resources.Great_Ball_Display;
        }

        private void buyGBButton_MouseLeave(object sender, EventArgs e)
        {
            pointer2.Hide();
            martLogo.Image = Properties.Resources.PokeMart_Icon;
        }

        private void buyPBButton_MouseLeave(object sender, EventArgs e)
        {
            pointer1.Hide();
            martLogo.Image = Properties.Resources.PokeMart_Icon;
        }

        private void buyUBButton_MouseHover(object sender, EventArgs e)
        {
            pointer3.Show();
            martLogo.Image = Properties.Resources.Ultra_Ball_Display;
        }

        private void buyUBButton_MouseLeave(object sender, EventArgs e)
        {
            pointer3.Hide();
            martLogo.Image = Properties.Resources.PokeMart_Icon;
        }

        private void buySBButton_MouseHover(object sender, EventArgs e)
        {
            pointer4.Show();
            martLogo.Image = Properties.Resources.Safari_Ball_Display;
        }

        private void buySBButton_MouseLeave(object sender, EventArgs e)
        {
            pointer4.Hide();
            martLogo.Image = Properties.Resources.PokeMart_Icon;
        }

        private void buyMBButton_MouseHover(object sender, EventArgs e)
        {
            pointer5.Show();
            martLogo.Image = Properties.Resources.Master_Ball_Display;
        }

        private void buyMBButton_MouseLeave(object sender, EventArgs e)
        {
            pointer5.Hide();
            martLogo.Image = Properties.Resources.PokeMart_Icon;
        }

        private void label8_Click(object sender, EventArgs e)
        {
            string message = "Buy more balls if you run out, or buy a Mega Stone to Mega Evolve your Pokémon!" + Environment.NewLine;

            if (MegaStone > 0)
            {
                message += "You currently have " + MegaStone + " Mega Stone" + (MegaStone == 1 ? "." : "s.");
            }

            MessageBox.Show(message, "Shop Help");
        }

        private void moneyBorder_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You get money for every pokemon you catch.", "Money Help");
            MessageBox.Show("The lowest you can get is 200 Pokémon Dollars, and the highest is 1000!", "Limits");
        }

        private void itemsBox_Click(object sender, EventArgs e)
        {
            MessageBox.Show("All of the items available for purchase.", "Item Help");
        }

        private void label7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Pokémon in the Personal Computer that are not able to fit in the team.", "PC Help");
        }

        private void buyGBButton_Click(object sender, EventArgs e)
        {
            PurchaseItem(GREATBALL_COST, () => GB++);
        }

        private void buyUBButton_Click(object sender, EventArgs e)
        {
            PurchaseItem(ULTRABALL_COST, () => UB++);
        }

        private void buySBButton_Click(object sender, EventArgs e)
        {
            PurchaseItem(SAFARIBALL_COST, () => SB++);
        }

        private void buyMBButton_Click(object sender, EventArgs e)
        {
            PurchaseItem(MASTERBALL_COST, () => MB++);
        }

        private void buyMegaStoneButton_Click(object sender, EventArgs e)
        {
            PurchaseItem(MEGASTONE_COST, () => MegaStone++);
        }

        private void buyMegaStoneButton_MouseHover(object sender, EventArgs e)
        {
            pointer6.Show();
            martLogo.Image = Properties.Resources.Mega_Stone_Display;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            SaveGameData();
            MessageBox.Show("Your game has been saved!", "Save");
        }

        private void SaveGameData()
        {
            string saveData = $"{PB},{GB},{UB},{SB},{MB},{MegaStone},{money}";
            string teamData = string.Join(",", pokemonTeamBox.Items.Cast<string>());
            string pcData = string.Join(",", pcBox.Items.Cast<string>());

            File.WriteAllText("saveData.txt", saveData);
            File.WriteAllText("teamData.txt", teamData);
            File.WriteAllText("pcData.txt", pcData);
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            LoadGameData();
            MessageBox.Show("Your game has been loaded!", "Load");
        }

        private void LoadGameData()
        {
            string[] saveData = File.ReadAllText("saveData.txt").Split(',');
            string[] teamData = File.ReadAllText("teamData.txt").Split(',');
            string[] pcData = File.ReadAllText("pcData.txt").Split(',');

            LoadGameState(saveData);
            LoadPokemonData(teamData, pcData);
        }

        private void LoadGameState(string[] saveData)
        {
            PB = int.Parse(saveData[0]);
            GB = int.Parse(saveData[1]);
            UB = int.Parse(saveData[2]);
            SB = int.Parse(saveData[3]);
            MB = int.Parse(saveData[4]);
            MegaStone = int.Parse(saveData[5]);
            money = int.Parse(saveData[6]);
            UpdateMoneyDisplay();
        }

        private void LoadPokemonData(string[] teamData, string[] pcData)
        {
            pokemonTeamBox.Items.Clear();
            pcBox.Items.Clear();
            pokeBallBox.Image = null;

            foreach (string pokemon in teamData.Where(p => !string.IsNullOrEmpty(p)))
            {
                pokemonTeamBox.Items.Add(pokemon);
            }

            foreach (string pokemon in pcData.Where(p => !string.IsNullOrEmpty(p)))
            {
                pcBox.Items.Add(pokemon);
            }
        }

        private void moneyLabel_TextChanged(object sender, EventArgs e)
        {
            // add commas to the money label
            moneyLabel.Text = string.Format("{0:n0}", money);

            // if the money is less than 0, set it to 0, and if it's more than 9999999999, set it to 9999999999
            if (money < 0)
            {
                money = 0;
            }
            else if (money > 9999999999)
            {
                money = 9999999999;
            }
        }

        private void buyMegaStoneButton_MouseLeave(object sender, EventArgs e)
        {
            pointer6.Hide();
            martLogo.Image = Properties.Resources.PokeMart_Icon;
        }

        private void megaEvolveButton_Click(object sender, EventArgs e)
        {
            if (pokemonTeamBox.SelectedItem != null)
            {
                string selectedPokemon = pokemonTeamBox.SelectedItem.ToString();
                if (!selectedPokemon.Contains("-Mega"))
                {
                    MegaStone--;
                    string megaEvolvedPokemon = selectedPokemon + "-Mega";
                    pokemonTeamBox.Items.Add(megaEvolvedPokemon);
                    pokemonTeamBox.Items.Remove(selectedPokemon);

                    megaEvolve.Play();

                    // automatically select the mega evolved pokemon, after sound effect is done
                    System.Threading.Thread.Sleep(2811);
                    pokemonTeamBox.SelectedItem = megaEvolvedPokemon;

                }
            }
        }

        private void deselectButton_Click(object sender, EventArgs e)
        {
            pokemonTeamBox.SelectedIndex = -1;
            pcBox.SelectedIndex = -1;
        }

        private void pokemonBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Search_Click((object)sender, (EventArgs)e);
            }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            DialogResult resetConfirmation = MessageBox.Show("Are you sure you want to restart the application? All progress will be lost.", "Quit", MessageBoxButtons.YesNo);
            if (resetConfirmation == DialogResult.Yes)
            {
                Application.Restart();
            }
        }

        private void randomPokemonButton_MouseDown(object sender, MouseEventArgs e)
        {
            pokemonBox.Text = pokemon[rnd.Next(pokemon.Count())].ToString();
        }

        private void randomBallButton_MouseDown(object sender, MouseEventArgs e)
        {
            Dictionary<string, int> ballInventory = new Dictionary<string, int>
    {
        { "PokeBall", PB },
        { "Master Ball", MB },
        { "Great Ball", GB },
        { "Safari Ball", SB },
        { "Ultra Ball", UB }
    };

            string ballNo = balls[rnd.Next(0, 5)];

            if (ballInventory.TryGetValue(ballNo, out int count) && count > 0)
            {
                ballChosenBox.Text = ballNo;
            }
        }

        private void randomStatusButton_MouseDown(object sender, MouseEventArgs e)
        {
            string[] statusArray = { "PAR", "SLP", "BRN", "FRZ", "PSN", "" };

            int index = rnd.Next(statusArray.Length);
            pokStatusBox.Text = statusArray[index];
        }

        private void randomMaxHPButton_MouseDown(object sender, MouseEventArgs e)
        {
            pokMaxHPBox.Text = rnd.Next(1, 256).ToString();
        }

        private void randomCurrentHPButton_MouseDown(object sender, MouseEventArgs e)
        {
            int maxHP;
            if (int.TryParse(pokMaxHPBox.Text, out maxHP))
            {
                int currentHP = rnd.Next(1, maxHP + 1);
                pokCurrentHPBox.Text = currentHP.ToString();
            }
            else
            {
                pokCurrentHPBox.Text = rnd.Next(1, 256).ToString();
            }
        }

        private void PurchaseItem(int cost, Action onSuccess)
        {
            if (money >= cost)
            {
                purchase.Play();
                onSuccess();
                money -= cost;
                UpdateMoneyDisplay();
            }
        }
    }
}
