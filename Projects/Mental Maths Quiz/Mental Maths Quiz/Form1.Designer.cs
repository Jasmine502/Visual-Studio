namespace Mental_Maths_Quiz
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
            this.startFinishButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.timeLeftLabel = new System.Windows.Forms.Label();
            this.plusLeftLabel = new System.Windows.Forms.Label();
            this.plusRightLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.sum = new System.Windows.Forms.NumericUpDown();
            this.minusLeftLabel = new System.Windows.Forms.Label();
            this.minusRightLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.difference = new System.Windows.Forms.NumericUpDown();
            this.timesLeftLabel = new System.Windows.Forms.Label();
            this.timesRightLabel = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.product = new System.Windows.Forms.NumericUpDown();
            this.dividedLeftLabel = new System.Windows.Forms.Label();
            this.dividedRightLabel = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.quotient = new System.Windows.Forms.NumericUpDown();
            this.multiplicationCheck = new System.Windows.Forms.PictureBox();
            this.divisionCheck = new System.Windows.Forms.PictureBox();
            this.subtractionCheck = new System.Windows.Forms.PictureBox();
            this.additionCheck = new System.Windows.Forms.PictureBox();
            this.countDownTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.sum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.difference)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.product)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quotient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.multiplicationCheck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.divisionCheck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subtractionCheck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.additionCheck)).BeginInit();
            this.SuspendLayout();
            // 
            // startFinishButton
            // 
            this.startFinishButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startFinishButton.Location = new System.Drawing.Point(118, 292);
            this.startFinishButton.Name = "startFinishButton";
            this.startFinishButton.Size = new System.Drawing.Size(142, 45);
            this.startFinishButton.TabIndex = 1;
            this.startFinishButton.Text = "START";
            this.startFinishButton.UseVisualStyleBackColor = true;
            this.startFinishButton.Click += new System.EventHandler(this.startFinishButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(70, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Time Left:";
            // 
            // timeLeftLabel
            // 
            this.timeLeftLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.timeLeftLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.timeLeftLabel.Location = new System.Drawing.Point(183, 15);
            this.timeLeftLabel.Name = "timeLeftLabel";
            this.timeLeftLabel.Size = new System.Drawing.Size(125, 27);
            this.timeLeftLabel.TabIndex = 2;
            this.timeLeftLabel.Text = "60 seconds";
            this.timeLeftLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // plusLeftLabel
            // 
            this.plusLeftLabel.AutoSize = true;
            this.plusLeftLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plusLeftLabel.Location = new System.Drawing.Point(44, 65);
            this.plusLeftLabel.Name = "plusLeftLabel";
            this.plusLeftLabel.Size = new System.Drawing.Size(26, 29);
            this.plusLeftLabel.TabIndex = 3;
            this.plusLeftLabel.Text = "?";
            this.plusLeftLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // plusRightLabel
            // 
            this.plusRightLabel.AutoSize = true;
            this.plusRightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plusRightLabel.Location = new System.Drawing.Point(129, 65);
            this.plusRightLabel.Name = "plusRightLabel";
            this.plusRightLabel.Size = new System.Drawing.Size(26, 29);
            this.plusRightLabel.TabIndex = 3;
            this.plusRightLabel.Text = "?";
            this.plusRightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(92, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "+";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(177, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 24);
            this.label6.TabIndex = 4;
            this.label6.Text = "=";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sum
            // 
            this.sum.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sum.Location = new System.Drawing.Point(215, 65);
            this.sum.Name = "sum";
            this.sum.Size = new System.Drawing.Size(120, 29);
            this.sum.TabIndex = 2;
            this.sum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // minusLeftLabel
            // 
            this.minusLeftLabel.AutoSize = true;
            this.minusLeftLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minusLeftLabel.Location = new System.Drawing.Point(44, 121);
            this.minusLeftLabel.Name = "minusLeftLabel";
            this.minusLeftLabel.Size = new System.Drawing.Size(26, 29);
            this.minusLeftLabel.TabIndex = 3;
            this.minusLeftLabel.Text = "?";
            this.minusLeftLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // minusRightLabel
            // 
            this.minusRightLabel.AutoSize = true;
            this.minusRightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minusRightLabel.Location = new System.Drawing.Point(129, 121);
            this.minusRightLabel.Name = "minusRightLabel";
            this.minusRightLabel.Size = new System.Drawing.Size(26, 29);
            this.minusRightLabel.TabIndex = 3;
            this.minusRightLabel.Text = "?";
            this.minusRightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(92, 123);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(16, 24);
            this.label7.TabIndex = 4;
            this.label7.Text = "-";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(177, 123);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(21, 24);
            this.label8.TabIndex = 4;
            this.label8.Text = "=";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // difference
            // 
            this.difference.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.difference.Location = new System.Drawing.Point(215, 121);
            this.difference.Name = "difference";
            this.difference.Size = new System.Drawing.Size(120, 29);
            this.difference.TabIndex = 3;
            this.difference.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // timesLeftLabel
            // 
            this.timesLeftLabel.AutoSize = true;
            this.timesLeftLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timesLeftLabel.Location = new System.Drawing.Point(44, 233);
            this.timesLeftLabel.Name = "timesLeftLabel";
            this.timesLeftLabel.Size = new System.Drawing.Size(26, 29);
            this.timesLeftLabel.TabIndex = 3;
            this.timesLeftLabel.Text = "?";
            this.timesLeftLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timesRightLabel
            // 
            this.timesRightLabel.AutoSize = true;
            this.timesRightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timesRightLabel.Location = new System.Drawing.Point(129, 233);
            this.timesRightLabel.Name = "timesRightLabel";
            this.timesRightLabel.Size = new System.Drawing.Size(26, 29);
            this.timesRightLabel.TabIndex = 3;
            this.timesRightLabel.Text = "?";
            this.timesRightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(92, 235);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(21, 24);
            this.label11.TabIndex = 4;
            this.label11.Text = "×";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(177, 235);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(21, 24);
            this.label12.TabIndex = 4;
            this.label12.Text = "=";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // product
            // 
            this.product.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.product.Location = new System.Drawing.Point(215, 233);
            this.product.Name = "product";
            this.product.Size = new System.Drawing.Size(120, 29);
            this.product.TabIndex = 5;
            this.product.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // dividedLeftLabel
            // 
            this.dividedLeftLabel.AutoSize = true;
            this.dividedLeftLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dividedLeftLabel.Location = new System.Drawing.Point(44, 177);
            this.dividedLeftLabel.Name = "dividedLeftLabel";
            this.dividedLeftLabel.Size = new System.Drawing.Size(26, 29);
            this.dividedLeftLabel.TabIndex = 3;
            this.dividedLeftLabel.Text = "?";
            this.dividedLeftLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dividedRightLabel
            // 
            this.dividedRightLabel.AutoSize = true;
            this.dividedRightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dividedRightLabel.Location = new System.Drawing.Point(129, 177);
            this.dividedRightLabel.Name = "dividedRightLabel";
            this.dividedRightLabel.Size = new System.Drawing.Size(26, 29);
            this.dividedRightLabel.TabIndex = 3;
            this.dividedRightLabel.Text = "?";
            this.dividedRightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(92, 179);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(15, 24);
            this.label15.TabIndex = 4;
            this.label15.Text = "/";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(177, 179);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(21, 24);
            this.label16.TabIndex = 4;
            this.label16.Text = "=";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // quotient
            // 
            this.quotient.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quotient.Location = new System.Drawing.Point(215, 177);
            this.quotient.Name = "quotient";
            this.quotient.Size = new System.Drawing.Size(120, 29);
            this.quotient.TabIndex = 4;
            this.quotient.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // multiplicationCheck
            // 
            this.multiplicationCheck.Location = new System.Drawing.Point(345, 233);
            this.multiplicationCheck.Name = "multiplicationCheck";
            this.multiplicationCheck.Size = new System.Drawing.Size(29, 29);
            this.multiplicationCheck.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.multiplicationCheck.TabIndex = 6;
            this.multiplicationCheck.TabStop = false;
            // 
            // divisionCheck
            // 
            this.divisionCheck.Location = new System.Drawing.Point(345, 177);
            this.divisionCheck.Name = "divisionCheck";
            this.divisionCheck.Size = new System.Drawing.Size(29, 29);
            this.divisionCheck.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.divisionCheck.TabIndex = 6;
            this.divisionCheck.TabStop = false;
            // 
            // subtractionCheck
            // 
            this.subtractionCheck.Location = new System.Drawing.Point(345, 121);
            this.subtractionCheck.Name = "subtractionCheck";
            this.subtractionCheck.Size = new System.Drawing.Size(29, 29);
            this.subtractionCheck.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.subtractionCheck.TabIndex = 6;
            this.subtractionCheck.TabStop = false;
            // 
            // additionCheck
            // 
            this.additionCheck.Location = new System.Drawing.Point(345, 65);
            this.additionCheck.Name = "additionCheck";
            this.additionCheck.Size = new System.Drawing.Size(29, 29);
            this.additionCheck.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.additionCheck.TabIndex = 6;
            this.additionCheck.TabStop = false;
            // 
            // countDownTimer
            // 
            this.countDownTimer.Interval = 1000;
            this.countDownTimer.Tick += new System.EventHandler(this.countDownTimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(378, 352);
            this.Controls.Add(this.multiplicationCheck);
            this.Controls.Add(this.divisionCheck);
            this.Controls.Add(this.subtractionCheck);
            this.Controls.Add(this.additionCheck);
            this.Controls.Add(this.quotient);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.product);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.difference);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.sum);
            this.Controls.Add(this.dividedRightLabel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.timesRightLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dividedLeftLabel);
            this.Controls.Add(this.minusRightLabel);
            this.Controls.Add(this.timesLeftLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.minusLeftLabel);
            this.Controls.Add(this.plusRightLabel);
            this.Controls.Add(this.plusLeftLabel);
            this.Controls.Add(this.timeLeftLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.startFinishButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(394, 391);
            this.MinimumSize = new System.Drawing.Size(394, 391);
            this.Name = "Form1";
            this.Text = "Mental Maths Quiz";
            ((System.ComponentModel.ISupportInitialize)(this.sum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.difference)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.product)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quotient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.multiplicationCheck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.divisionCheck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subtractionCheck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.additionCheck)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startFinishButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label timeLeftLabel;
        private System.Windows.Forms.Label plusLeftLabel;
        private System.Windows.Forms.Label plusRightLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown sum;
        private System.Windows.Forms.Label minusLeftLabel;
        private System.Windows.Forms.Label minusRightLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown difference;
        private System.Windows.Forms.Label timesLeftLabel;
        private System.Windows.Forms.Label timesRightLabel;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown product;
        private System.Windows.Forms.Label dividedLeftLabel;
        private System.Windows.Forms.Label dividedRightLabel;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.NumericUpDown quotient;
        private System.Windows.Forms.PictureBox additionCheck;
        private System.Windows.Forms.PictureBox subtractionCheck;
        private System.Windows.Forms.PictureBox divisionCheck;
        private System.Windows.Forms.PictureBox multiplicationCheck;
        private System.Windows.Forms.Timer countDownTimer;
    }
}

