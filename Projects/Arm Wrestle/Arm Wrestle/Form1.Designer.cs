namespace Arm_Wrestle
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.mashButton = new System.Windows.Forms.Button();
            this.powerBar = new System.Windows.Forms.ProgressBar();
            this.boardBox = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.boardBox)).BeginInit();
            this.SuspendLayout();
            // 
            // mashButton
            // 
            this.mashButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mashButton.Location = new System.Drawing.Point(11, 9);
            this.mashButton.Name = "mashButton";
            this.mashButton.Size = new System.Drawing.Size(340, 82);
            this.mashButton.TabIndex = 0;
            this.mashButton.Text = "MASH";
            this.mashButton.UseVisualStyleBackColor = true;
            this.mashButton.Click += new System.EventHandler(this.mashButton_Click);
            // 
            // powerBar
            // 
            this.powerBar.Location = new System.Drawing.Point(11, 97);
            this.powerBar.Name = "powerBar";
            this.powerBar.Size = new System.Drawing.Size(340, 82);
            this.powerBar.TabIndex = 1;
            this.powerBar.Value = 50;
            // 
            // boardBox
            // 
            this.boardBox.Image = global::Arm_Wrestle.Properties.Resources.Neutral;
            this.boardBox.Location = new System.Drawing.Point(358, 9);
            this.boardBox.Name = "boardBox";
            this.boardBox.Size = new System.Drawing.Size(91, 170);
            this.boardBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.boardBox.TabIndex = 2;
            this.boardBox.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 189);
            this.Controls.Add(this.boardBox);
            this.Controls.Add(this.powerBar);
            this.Controls.Add(this.mashButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Arm Wrestle";
            ((System.ComponentModel.ISupportInitialize)(this.boardBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button mashButton;
        private System.Windows.Forms.ProgressBar powerBar;
        private System.Windows.Forms.PictureBox boardBox;
        private System.Windows.Forms.Timer timer1;
    }
}

