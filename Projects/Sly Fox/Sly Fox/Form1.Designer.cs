namespace Sly_Fox
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
            this.stepButton = new System.Windows.Forms.Button();
            this.step0 = new System.Windows.Forms.PictureBox();
            this.foxBox = new System.Windows.Forms.PictureBox();
            this.step1 = new System.Windows.Forms.PictureBox();
            this.step2 = new System.Windows.Forms.PictureBox();
            this.step3 = new System.Windows.Forms.PictureBox();
            this.step4 = new System.Windows.Forms.PictureBox();
            this.step5 = new System.Windows.Forms.PictureBox();
            this.exitButton = new System.Windows.Forms.Button();
            this.lookTimer = new System.Windows.Forms.Timer(this.components);
            this.levelLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.step0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.foxBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.step1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.step2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.step3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.step4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.step5)).BeginInit();
            this.SuspendLayout();
            // 
            // stepButton
            // 
            this.stepButton.BackColor = System.Drawing.Color.White;
            this.stepButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stepButton.Image = global::Sly_Fox.Properties.Resources.Footprint;
            this.stepButton.Location = new System.Drawing.Point(354, 463);
            this.stepButton.Name = "stepButton";
            this.stepButton.Size = new System.Drawing.Size(70, 70);
            this.stepButton.TabIndex = 1;
            this.stepButton.Tag = "";
            this.stepButton.UseVisualStyleBackColor = false;
            this.stepButton.Click += new System.EventHandler(this.stepButton_Click);
            this.stepButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.stepButton_MouseDown);
            // 
            // step0
            // 
            this.step0.Image = global::Sly_Fox.Properties.Resources.Player;
            this.step0.Location = new System.Drawing.Point(191, 449);
            this.step0.Name = "step0";
            this.step0.Size = new System.Drawing.Size(55, 84);
            this.step0.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.step0.TabIndex = 2;
            this.step0.TabStop = false;
            // 
            // foxBox
            // 
            this.foxBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.foxBox.Image = global::Sly_Fox.Properties.Resources.LookFront;
            this.foxBox.Location = new System.Drawing.Point(192, 12);
            this.foxBox.Name = "foxBox";
            this.foxBox.Size = new System.Drawing.Size(53, 84);
            this.foxBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.foxBox.TabIndex = 0;
            this.foxBox.TabStop = false;
            // 
            // step1
            // 
            this.step1.Image = global::Sly_Fox.Properties.Resources.Player;
            this.step1.Location = new System.Drawing.Point(192, 359);
            this.step1.Name = "step1";
            this.step1.Size = new System.Drawing.Size(55, 84);
            this.step1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.step1.TabIndex = 2;
            this.step1.TabStop = false;
            this.step1.Visible = false;
            // 
            // step2
            // 
            this.step2.Image = global::Sly_Fox.Properties.Resources.Player;
            this.step2.Location = new System.Drawing.Point(190, 269);
            this.step2.Name = "step2";
            this.step2.Size = new System.Drawing.Size(55, 84);
            this.step2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.step2.TabIndex = 2;
            this.step2.TabStop = false;
            this.step2.Visible = false;
            // 
            // step3
            // 
            this.step3.Image = global::Sly_Fox.Properties.Resources.Player;
            this.step3.Location = new System.Drawing.Point(191, 179);
            this.step3.Name = "step3";
            this.step3.Size = new System.Drawing.Size(55, 84);
            this.step3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.step3.TabIndex = 2;
            this.step3.TabStop = false;
            this.step3.Visible = false;
            // 
            // step4
            // 
            this.step4.Image = global::Sly_Fox.Properties.Resources.Player;
            this.step4.Location = new System.Drawing.Point(192, 89);
            this.step4.Name = "step4";
            this.step4.Size = new System.Drawing.Size(55, 84);
            this.step4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.step4.TabIndex = 2;
            this.step4.TabStop = false;
            this.step4.Visible = false;
            // 
            // step5
            // 
            this.step5.Image = global::Sly_Fox.Properties.Resources.Player;
            this.step5.Location = new System.Drawing.Point(191, 12);
            this.step5.Name = "step5";
            this.step5.Size = new System.Drawing.Size(55, 84);
            this.step5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.step5.TabIndex = 2;
            this.step5.TabStop = false;
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.ForeColor = System.Drawing.Color.White;
            this.exitButton.Location = new System.Drawing.Point(371, 12);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(53, 29);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "X";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // lookTimer
            // 
            this.lookTimer.Enabled = true;
            this.lookTimer.Interval = 1000;
            this.lookTimer.Tick += new System.EventHandler(this.lookTimer_Tick);
            // 
            // levelLabel
            // 
            this.levelLabel.AutoSize = true;
            this.levelLabel.Font = new System.Drawing.Font("Minecraft", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.levelLabel.ForeColor = System.Drawing.Color.White;
            this.levelLabel.Location = new System.Drawing.Point(12, 14);
            this.levelLabel.Name = "levelLabel";
            this.levelLabel.Size = new System.Drawing.Size(105, 19);
            this.levelLabel.TabIndex = 4;
            this.levelLabel.Text = "LEVEL 0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(436, 545);
            this.Controls.Add(this.levelLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.step4);
            this.Controls.Add(this.step3);
            this.Controls.Add(this.step2);
            this.Controls.Add(this.step1);
            this.Controls.Add(this.step0);
            this.Controls.Add(this.stepButton);
            this.Controls.Add(this.foxBox);
            this.Controls.Add(this.step5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.step0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.foxBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.step1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.step2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.step3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.step4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.step5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox foxBox;
        private System.Windows.Forms.Button stepButton;
        private System.Windows.Forms.PictureBox step0;
        private System.Windows.Forms.PictureBox step1;
        private System.Windows.Forms.PictureBox step2;
        private System.Windows.Forms.PictureBox step3;
        private System.Windows.Forms.PictureBox step4;
        private System.Windows.Forms.PictureBox step5;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Timer lookTimer;
        private System.Windows.Forms.Label levelLabel;
    }
}

