namespace Projectile_Motion_Calculator
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
            this.label1 = new System.Windows.Forms.Label();
            this.rangeBox = new System.Windows.Forms.TextBox();
            this.rangeUnitLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.heightBox = new System.Windows.Forms.TextBox();
            this.heightUnitLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.timeBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.velocityBox = new System.Windows.Forms.TextBox();
            this.timeUnitLabel = new System.Windows.Forms.Label();
            this.velocityUnitLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.gravityBox = new System.Windows.Forms.TextBox();
            this.gravityUnitLabel = new System.Windows.Forms.Label();
            this.solveButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.rangeRadio = new System.Windows.Forms.RadioButton();
            this.heightRadio = new System.Windows.Forms.RadioButton();
            this.velocityRadio = new System.Windows.Forms.RadioButton();
            this.gravityRadio = new System.Windows.Forms.RadioButton();
            this.dpUD = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dpUD)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Range:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // rangeBox
            // 
            this.rangeBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rangeBox.Location = new System.Drawing.Point(10, 50);
            this.rangeBox.Name = "rangeBox";
            this.rangeBox.Size = new System.Drawing.Size(273, 26);
            this.rangeBox.TabIndex = 1;
            this.rangeBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // rangeUnitLabel
            // 
            this.rangeUnitLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rangeUnitLabel.ForeColor = System.Drawing.Color.White;
            this.rangeUnitLabel.Location = new System.Drawing.Point(289, 54);
            this.rangeUnitLabel.Name = "rangeUnitLabel";
            this.rangeUnitLabel.Size = new System.Drawing.Size(42, 18);
            this.rangeUnitLabel.TabIndex = 2;
            this.rangeUnitLabel.Text = "m";
            this.rangeUnitLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.distanceLabel_MouseDown);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(271, 31);
            this.label2.TabIndex = 0;
            this.label2.Text = "Height:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // heightBox
            // 
            this.heightBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.heightBox.Location = new System.Drawing.Point(10, 123);
            this.heightBox.Name = "heightBox";
            this.heightBox.Size = new System.Drawing.Size(273, 26);
            this.heightBox.TabIndex = 2;
            this.heightBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // heightUnitLabel
            // 
            this.heightUnitLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.heightUnitLabel.ForeColor = System.Drawing.Color.White;
            this.heightUnitLabel.Location = new System.Drawing.Point(292, 127);
            this.heightUnitLabel.Name = "heightUnitLabel";
            this.heightUnitLabel.Size = new System.Drawing.Size(39, 18);
            this.heightUnitLabel.TabIndex = 2;
            this.heightUnitLabel.Text = "m";
            this.heightUnitLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.distanceLabel_MouseDown);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(271, 31);
            this.label3.TabIndex = 0;
            this.label3.Text = "Time:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // timeBox
            // 
            this.timeBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeBox.Location = new System.Drawing.Point(10, 196);
            this.timeBox.Name = "timeBox";
            this.timeBox.Size = new System.Drawing.Size(273, 26);
            this.timeBox.TabIndex = 3;
            this.timeBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(271, 31);
            this.label4.TabIndex = 0;
            this.label4.Text = "Velocity:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // velocityBox
            // 
            this.velocityBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.velocityBox.Location = new System.Drawing.Point(10, 269);
            this.velocityBox.Name = "velocityBox";
            this.velocityBox.Size = new System.Drawing.Size(256, 26);
            this.velocityBox.TabIndex = 4;
            this.velocityBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // timeUnitLabel
            // 
            this.timeUnitLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeUnitLabel.ForeColor = System.Drawing.Color.White;
            this.timeUnitLabel.Location = new System.Drawing.Point(292, 200);
            this.timeUnitLabel.Name = "timeUnitLabel";
            this.timeUnitLabel.Size = new System.Drawing.Size(39, 18);
            this.timeUnitLabel.TabIndex = 2;
            this.timeUnitLabel.Text = "s";
            this.timeUnitLabel.Click += new System.EventHandler(this.timeUnitLabel_Click);
            this.timeUnitLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.timeUnitLabel_MouseDown);
            // 
            // velocityUnitLabel
            // 
            this.velocityUnitLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.velocityUnitLabel.ForeColor = System.Drawing.Color.White;
            this.velocityUnitLabel.Location = new System.Drawing.Point(272, 273);
            this.velocityUnitLabel.Name = "velocityUnitLabel";
            this.velocityUnitLabel.Size = new System.Drawing.Size(52, 18);
            this.velocityUnitLabel.TabIndex = 2;
            this.velocityUnitLabel.Text = "m/s";
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 303);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(271, 31);
            this.label8.TabIndex = 0;
            this.label8.Text = "Gravity:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gravityBox
            // 
            this.gravityBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gravityBox.Location = new System.Drawing.Point(10, 342);
            this.gravityBox.Name = "gravityBox";
            this.gravityBox.Size = new System.Drawing.Size(249, 26);
            this.gravityBox.TabIndex = 5;
            this.gravityBox.Text = "9.81";
            this.gravityBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // gravityUnitLabel
            // 
            this.gravityUnitLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gravityUnitLabel.ForeColor = System.Drawing.Color.White;
            this.gravityUnitLabel.Location = new System.Drawing.Point(265, 346);
            this.gravityUnitLabel.Name = "gravityUnitLabel";
            this.gravityUnitLabel.Size = new System.Drawing.Size(59, 18);
            this.gravityUnitLabel.TabIndex = 2;
            this.gravityUnitLabel.Text = "m/s2";
            // 
            // solveButton
            // 
            this.solveButton.BackColor = System.Drawing.Color.Black;
            this.solveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.solveButton.ForeColor = System.Drawing.Color.White;
            this.solveButton.Location = new System.Drawing.Point(98, 381);
            this.solveButton.Name = "solveButton";
            this.solveButton.Size = new System.Drawing.Size(253, 52);
            this.solveButton.TabIndex = 6;
            this.solveButton.Text = "SOLVE";
            this.solveButton.UseVisualStyleBackColor = false;
            this.solveButton.Click += new System.EventHandler(this.solveButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.Color.Black;
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.ForeColor = System.Drawing.Color.White;
            this.clearButton.Location = new System.Drawing.Point(10, 381);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(82, 52);
            this.clearButton.TabIndex = 7;
            this.clearButton.Text = "CLEAR";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // rangeRadio
            // 
            this.rangeRadio.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rangeRadio.Location = new System.Drawing.Point(322, 50);
            this.rangeRadio.Name = "rangeRadio";
            this.rangeRadio.Size = new System.Drawing.Size(29, 26);
            this.rangeRadio.TabIndex = 8;
            this.rangeRadio.TabStop = true;
            this.rangeRadio.UseVisualStyleBackColor = true;
            // 
            // heightRadio
            // 
            this.heightRadio.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.heightRadio.Location = new System.Drawing.Point(322, 124);
            this.heightRadio.Name = "heightRadio";
            this.heightRadio.Size = new System.Drawing.Size(29, 26);
            this.heightRadio.TabIndex = 8;
            this.heightRadio.TabStop = true;
            this.heightRadio.UseVisualStyleBackColor = true;
            // 
            // velocityRadio
            // 
            this.velocityRadio.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.velocityRadio.Location = new System.Drawing.Point(322, 269);
            this.velocityRadio.Name = "velocityRadio";
            this.velocityRadio.Size = new System.Drawing.Size(29, 26);
            this.velocityRadio.TabIndex = 8;
            this.velocityRadio.TabStop = true;
            this.velocityRadio.UseVisualStyleBackColor = true;
            // 
            // gravityRadio
            // 
            this.gravityRadio.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.gravityRadio.Location = new System.Drawing.Point(322, 342);
            this.gravityRadio.Name = "gravityRadio";
            this.gravityRadio.Size = new System.Drawing.Size(29, 26);
            this.gravityRadio.TabIndex = 8;
            this.gravityRadio.TabStop = true;
            this.gravityRadio.UseVisualStyleBackColor = true;
            // 
            // dpUD
            // 
            this.dpUD.BackColor = System.Drawing.Color.Black;
            this.dpUD.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpUD.ForeColor = System.Drawing.Color.White;
            this.dpUD.Location = new System.Drawing.Point(275, 11);
            this.dpUD.Name = "dpUD";
            this.dpUD.Size = new System.Drawing.Size(40, 20);
            this.dpUD.TabIndex = 9;
            this.dpUD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.dpUD.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.dpUD.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.dpUD.ValueChanged += new System.EventHandler(this.dpUD_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(321, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "d.p";
            this.label5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.distanceLabel_MouseDown);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(363, 443);
            this.Controls.Add(this.dpUD);
            this.Controls.Add(this.gravityRadio);
            this.Controls.Add(this.velocityRadio);
            this.Controls.Add(this.heightRadio);
            this.Controls.Add(this.rangeRadio);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.solveButton);
            this.Controls.Add(this.gravityUnitLabel);
            this.Controls.Add(this.velocityUnitLabel);
            this.Controls.Add(this.heightUnitLabel);
            this.Controls.Add(this.timeUnitLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.rangeUnitLabel);
            this.Controls.Add(this.gravityBox);
            this.Controls.Add(this.velocityBox);
            this.Controls.Add(this.heightBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.timeBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rangeBox);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Yellow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Projectile Motion Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dpUD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox rangeBox;
        private System.Windows.Forms.Label rangeUnitLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox heightBox;
        private System.Windows.Forms.Label heightUnitLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox timeBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox velocityBox;
        private System.Windows.Forms.Label timeUnitLabel;
        private System.Windows.Forms.Label velocityUnitLabel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox gravityBox;
        private System.Windows.Forms.Label gravityUnitLabel;
        private System.Windows.Forms.Button solveButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.RadioButton rangeRadio;
        private System.Windows.Forms.RadioButton heightRadio;
        private System.Windows.Forms.RadioButton velocityRadio;
        private System.Windows.Forms.RadioButton gravityRadio;
        private System.Windows.Forms.NumericUpDown dpUD;
        private System.Windows.Forms.Label label5;
    }
}

