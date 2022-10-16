namespace RPS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.scissorsButton = new System.Windows.Forms.Button();
            this.paperButton = new System.Windows.Forms.Button();
            this.rockButton = new System.Windows.Forms.Button();
            this.playerScoreLabel = new System.Windows.Forms.Label();
            this.cpuScoreLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cpuHandImage = new System.Windows.Forms.PictureBox();
            this.playerHandImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.cpuHandImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerHandImage)).BeginInit();
            this.SuspendLayout();
            // 
            // scissorsButton
            // 
            this.scissorsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scissorsButton.Location = new System.Drawing.Point(174, 82);
            this.scissorsButton.Name = "scissorsButton";
            this.scissorsButton.Size = new System.Drawing.Size(78, 23);
            this.scissorsButton.TabIndex = 10;
            this.scissorsButton.Text = "SCISSORS";
            this.scissorsButton.UseVisualStyleBackColor = true;
            this.scissorsButton.Click += new System.EventHandler(this.scissorsButton_Click);
            // 
            // paperButton
            // 
            this.paperButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paperButton.Location = new System.Drawing.Point(174, 53);
            this.paperButton.Name = "paperButton";
            this.paperButton.Size = new System.Drawing.Size(78, 23);
            this.paperButton.TabIndex = 11;
            this.paperButton.Text = "PAPER";
            this.paperButton.UseVisualStyleBackColor = true;
            this.paperButton.Click += new System.EventHandler(this.paperButton_Click);
            // 
            // rockButton
            // 
            this.rockButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rockButton.Location = new System.Drawing.Point(174, 24);
            this.rockButton.Name = "rockButton";
            this.rockButton.Size = new System.Drawing.Size(78, 23);
            this.rockButton.TabIndex = 12;
            this.rockButton.Text = "ROCK";
            this.rockButton.UseVisualStyleBackColor = true;
            this.rockButton.Click += new System.EventHandler(this.rockButton_Click);
            // 
            // playerScoreLabel
            // 
            this.playerScoreLabel.Location = new System.Drawing.Point(14, 109);
            this.playerScoreLabel.Name = "playerScoreLabel";
            this.playerScoreLabel.Size = new System.Drawing.Size(155, 18);
            this.playerScoreLabel.TabIndex = 8;
            this.playerScoreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cpuScoreLabel
            // 
            this.cpuScoreLabel.Location = new System.Drawing.Point(260, 109);
            this.cpuScoreLabel.Name = "cpuScoreLabel";
            this.cpuScoreLabel.Size = new System.Drawing.Size(151, 18);
            this.cpuScoreLabel.TabIndex = 9;
            this.cpuScoreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(372, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "CPU:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Player:";
            // 
            // cpuHandImage
            // 
            this.cpuHandImage.Image = global::RPS.Properties.Resources.Paper_Blue;
            this.cpuHandImage.Location = new System.Drawing.Point(260, 29);
            this.cpuHandImage.Name = "cpuHandImage";
            this.cpuHandImage.Size = new System.Drawing.Size(151, 72);
            this.cpuHandImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cpuHandImage.TabIndex = 4;
            this.cpuHandImage.TabStop = false;
            // 
            // playerHandImage
            // 
            this.playerHandImage.Image = global::RPS.Properties.Resources.Paper_Green;
            this.playerHandImage.Location = new System.Drawing.Point(14, 29);
            this.playerHandImage.Name = "playerHandImage";
            this.playerHandImage.Size = new System.Drawing.Size(155, 72);
            this.playerHandImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.playerHandImage.TabIndex = 5;
            this.playerHandImage.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 135);
            this.Controls.Add(this.scissorsButton);
            this.Controls.Add(this.paperButton);
            this.Controls.Add(this.rockButton);
            this.Controls.Add(this.playerScoreLabel);
            this.Controls.Add(this.cpuScoreLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cpuHandImage);
            this.Controls.Add(this.playerHandImage);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rock, Paper, Scissors";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cpuHandImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerHandImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button scissorsButton;
        private System.Windows.Forms.Button paperButton;
        private System.Windows.Forms.Button rockButton;
        private System.Windows.Forms.Label playerScoreLabel;
        private System.Windows.Forms.Label cpuScoreLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox cpuHandImage;
        private System.Windows.Forms.PictureBox playerHandImage;

    }
}

