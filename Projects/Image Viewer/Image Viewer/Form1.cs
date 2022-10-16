using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Image_Viewer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                ForeColor = colorDialog.Color;
            }
        }
        int index;
        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void clearImageButton_Click(object sender, EventArgs e)
        {
            imageViewer.Image = null;
            Text = "Image Viewer";
            clearImageButton.Enabled = false;
            stretchImageCheckBox.Enabled = false;
        }

        private void stretchImageCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (stretchImageCheckBox.Checked)
            {
                imageViewer.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else
            {
                imageViewer.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }

        private void loadImageButton_Click(object sender, EventArgs e)
        {
            if (loadImageDialog.ShowDialog() == DialogResult.OK)
            {
                imageViewer.ImageLocation = loadImageDialog.FileName;
                index = loadImageDialog.SafeFileName.IndexOf(".");
                if (index > 0)
                {
                    Text = loadImageDialog.SafeFileName.Substring(0,index) + " - Image Viewer";
                }
                stretchImageCheckBox.Enabled = true;
                clearImageButton.Enabled = true;
            }
        }

        private void changeBGColorButton_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                BackColor = colorDialog.Color;
            }
        }
    }
}
