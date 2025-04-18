using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;
using System.Threading.Tasks;

namespace Least_Amount_Of_Coins_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Initialize the array of PictureBoxes in the constructor
            coinPictureBoxes = new PictureBox[]
            {
                coin1, coin2, coin3, coin4, coin5, coin6, coin7, coin8,
                coin9, coin10, coin11, coin12, coin13, coin14, coin15, coin16,
                coin17, coin18, coin19, coin20, coin21, coin22, coin23, coin24,
                coin25, coin26, coin27, coin28, coin29, coin30, coin31, coin32,
                coin33, coin34, coin35, coin36
            };
        }

        double pound;
        double pence;
        double money;

        private readonly Dictionary<int, Image> coinImages = new Dictionary<int, Image>
        {
            { 200, Properties.Resources._2 },
            { 100, Properties.Resources._1 },
            { 50, Properties.Resources._50p },
            { 20, Properties.Resources._20p },
            { 10, Properties.Resources._10p },
            { 5, Properties.Resources._5p },
            { 2, Properties.Resources._2p },
            { 1, Properties.Resources._1p }
        };

        private readonly PictureBox[] coinPictureBoxes;

        private async void submit_Click(object sender, EventArgs e)
        {
            // Parse and validate input
            pence = string.IsNullOrWhiteSpace(penceBox.Text) ? 0 : double.Parse(penceBox.Text);
            pound = string.IsNullOrWhiteSpace(poundBox.Text) ? 0 : double.Parse(poundBox.Text);

            penceBox.Text = pence < 10 ? $"0{pence}" : pence.ToString();
            poundBox.Text = pound < 10 ? $"0{pound}" : pound.ToString();

            money = (pound * 100) + pence;

            // Reset all PictureBoxes
            foreach (var pictureBox in coinPictureBoxes)
            {
                pictureBox.Image = null;
            }

            // Calculate coins and display them gradually
            foreach (var pictureBox in coinPictureBoxes)
            {
                foreach (var coin in coinImages)
                {
                    if (money >= coin.Key)
                    {
                        pictureBox.Image = coin.Value;
                        money -= coin.Key;

                        // Wait for half a second before showing the next coin
                        await Task.Delay(100);
                        break;
                    }
                }
            }

            // Handle leftover money
            if (money > 0)
            {
                MessageBox.Show($"£{money / 100:F2} left over.");
            }
        }

        private void textBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                submit_Click(sender, e);
            }
        }
    }
}
