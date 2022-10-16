using System;
using System.Windows.Forms;
using System.Media;

namespace Media_Player
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SoundPlayer audio;
        private void openAudioButton_Click(object sender, EventArgs e)
        {
            if (songDialog.ShowDialog() == DialogResult.OK)
            {
                audio = new SoundPlayer(songDialog.FileName);
                Text = songDialog.FileName + " - Wave File Player";
                playButton.Show();
                stopButton.Show();
                openAudioButton.Hide();
            }
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            audio.Stop();
            playButton.Hide();
            stopButton.Hide();
            openAudioButton.Show();
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            audio.PlayLooping();
        }
    }
}
