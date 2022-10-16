namespace Media_Player
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.openAudioButton = new System.Windows.Forms.Button();
            this.playButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.songDialog = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // openAudioButton
            // 
            this.openAudioButton.Location = new System.Drawing.Point(13, 11);
            this.openAudioButton.Name = "openAudioButton";
            this.openAudioButton.Size = new System.Drawing.Size(287, 70);
            this.openAudioButton.TabIndex = 1;
            this.openAudioButton.Text = "Load Song";
            this.openAudioButton.UseVisualStyleBackColor = true;
            this.openAudioButton.Click += new System.EventHandler(this.openAudioButton_Click);
            // 
            // playButton
            // 
            this.playButton.Location = new System.Drawing.Point(13, 12);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(287, 35);
            this.playButton.TabIndex = 2;
            this.playButton.Text = "Play";
            this.playButton.UseVisualStyleBackColor = true;
            this.playButton.Visible = false;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // stopButton
            // 
            this.stopButton.Location = new System.Drawing.Point(13, 45);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(287, 35);
            this.stopButton.TabIndex = 2;
            this.stopButton.Text = "Stop";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Visible = false;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // songDialog
            // 
            this.songDialog.Filter = "WAV files|*.wav";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 92);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.playButton);
            this.Controls.Add(this.openAudioButton);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(328, 131);
            this.MinimumSize = new System.Drawing.Size(328, 131);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Wave File Player";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button openAudioButton;
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.OpenFileDialog songDialog;
    }
}

