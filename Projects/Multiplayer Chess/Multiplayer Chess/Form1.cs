using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Multiplayer_Chess
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            BackgroundImage = null;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void backgroundToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void marbleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            boardMaterialBox.Image = Properties.Resources.marble;
        }

        private void woodToolStripMenuItem_Click(object sender, EventArgs e)
        {
            boardMaterialBox.Image = Properties.Resources.wood;
        }

        private void steelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            boardMaterialBox.Image = Properties.Resources.steel;
        }

        private void plasticToolStripMenuItem_Click(object sender, EventArgs e)
        {
            boardMaterialBox.Image = Properties.Resources.plastic;
        }

        private void customColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (boardColorDialog.ShowDialog() == DialogResult.OK)
            {
                boardMaterialBox.Image = null;
                boardMaterialBox.BackColor = boardColorDialog.Color;
            }
        }

        private void customColorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (bgColorDialog.ShowDialog() == DialogResult.OK)
            {
                BackgroundImage = null;
                BackColor = bgColorDialog.Color;
            }
        }

        private void skyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BackgroundImage = Properties.Resources.sky;
        }

        private void grassToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BackgroundImage = Properties.Resources.grass;
        }

        private void woodenTableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BackgroundImage = Properties.Resources.wooden_table;
        }
    }
}
