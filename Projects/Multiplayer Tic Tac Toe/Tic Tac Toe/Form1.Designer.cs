namespace Tic_Tac_Toe
{
    partial class main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.A1 = new System.Windows.Forms.Button();
            this.B1 = new System.Windows.Forms.Button();
            this.C1 = new System.Windows.Forms.Button();
            this.A2 = new System.Windows.Forms.Button();
            this.B2 = new System.Windows.Forms.Button();
            this.C2 = new System.Windows.Forms.Button();
            this.A3 = new System.Windows.Forms.Button();
            this.B3 = new System.Windows.Forms.Button();
            this.C3 = new System.Windows.Forms.Button();
            this.gameLabel = new System.Windows.Forms.Label();
            this.colorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.foregroundToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.victoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.player1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.player2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bgColorDialog = new System.Windows.Forms.ColorDialog();
            this.fgColorDialog = new System.Windows.Forms.ColorDialog();
            this.victoryColorDialog = new System.Windows.Forms.ColorDialog();
            this.resetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(330, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.colorsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.newGameToolStripMenuItem.Text = "New Game";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.newGameToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.scoreToolStripMenuItem,
            this.resetToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // scoreToolStripMenuItem
            // 
            this.scoreToolStripMenuItem.Name = "scoreToolStripMenuItem";
            this.scoreToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.scoreToolStripMenuItem.Text = "Score";
            this.scoreToolStripMenuItem.Click += new System.EventHandler(this.scoreToolStripMenuItem_Click);
            // 
            // A1
            // 
            this.A1.BackColor = System.Drawing.Color.White;
            this.A1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A1.Location = new System.Drawing.Point(8, 74);
            this.A1.Name = "A1";
            this.A1.Size = new System.Drawing.Size(100, 100);
            this.A1.TabIndex = 0;
            this.A1.TabStop = false;
            this.A1.UseVisualStyleBackColor = false;
            this.A1.Click += new System.EventHandler(this.button_click);
            this.A1.MouseEnter += new System.EventHandler(this.button_hover);
            this.A1.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // B1
            // 
            this.B1.BackColor = System.Drawing.Color.White;
            this.B1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B1.Location = new System.Drawing.Point(114, 74);
            this.B1.Name = "B1";
            this.B1.Size = new System.Drawing.Size(100, 100);
            this.B1.TabIndex = 0;
            this.B1.TabStop = false;
            this.B1.UseVisualStyleBackColor = false;
            this.B1.Click += new System.EventHandler(this.button_click);
            this.B1.MouseEnter += new System.EventHandler(this.button_hover);
            this.B1.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // C1
            // 
            this.C1.BackColor = System.Drawing.Color.White;
            this.C1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C1.Location = new System.Drawing.Point(220, 74);
            this.C1.Name = "C1";
            this.C1.Size = new System.Drawing.Size(100, 100);
            this.C1.TabIndex = 0;
            this.C1.TabStop = false;
            this.C1.UseVisualStyleBackColor = false;
            this.C1.Click += new System.EventHandler(this.button_click);
            this.C1.MouseEnter += new System.EventHandler(this.button_hover);
            this.C1.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // A2
            // 
            this.A2.BackColor = System.Drawing.Color.White;
            this.A2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A2.Location = new System.Drawing.Point(8, 180);
            this.A2.Name = "A2";
            this.A2.Size = new System.Drawing.Size(100, 100);
            this.A2.TabIndex = 0;
            this.A2.TabStop = false;
            this.A2.UseVisualStyleBackColor = false;
            this.A2.Click += new System.EventHandler(this.button_click);
            this.A2.MouseEnter += new System.EventHandler(this.button_hover);
            this.A2.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // B2
            // 
            this.B2.BackColor = System.Drawing.Color.White;
            this.B2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B2.Location = new System.Drawing.Point(114, 180);
            this.B2.Name = "B2";
            this.B2.Size = new System.Drawing.Size(100, 100);
            this.B2.TabIndex = 0;
            this.B2.TabStop = false;
            this.B2.UseVisualStyleBackColor = false;
            this.B2.Click += new System.EventHandler(this.button_click);
            this.B2.MouseEnter += new System.EventHandler(this.button_hover);
            this.B2.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // C2
            // 
            this.C2.BackColor = System.Drawing.Color.White;
            this.C2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C2.Location = new System.Drawing.Point(220, 180);
            this.C2.Name = "C2";
            this.C2.Size = new System.Drawing.Size(100, 100);
            this.C2.TabIndex = 0;
            this.C2.TabStop = false;
            this.C2.UseVisualStyleBackColor = false;
            this.C2.Click += new System.EventHandler(this.button_click);
            this.C2.MouseEnter += new System.EventHandler(this.button_hover);
            this.C2.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // A3
            // 
            this.A3.BackColor = System.Drawing.Color.White;
            this.A3.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A3.Location = new System.Drawing.Point(8, 286);
            this.A3.Name = "A3";
            this.A3.Size = new System.Drawing.Size(100, 100);
            this.A3.TabIndex = 0;
            this.A3.TabStop = false;
            this.A3.UseVisualStyleBackColor = false;
            this.A3.Click += new System.EventHandler(this.button_click);
            this.A3.MouseEnter += new System.EventHandler(this.button_hover);
            this.A3.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // B3
            // 
            this.B3.BackColor = System.Drawing.Color.White;
            this.B3.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B3.Location = new System.Drawing.Point(114, 286);
            this.B3.Name = "B3";
            this.B3.Size = new System.Drawing.Size(100, 100);
            this.B3.TabIndex = 0;
            this.B3.TabStop = false;
            this.B3.UseVisualStyleBackColor = false;
            this.B3.Click += new System.EventHandler(this.button_click);
            this.B3.MouseEnter += new System.EventHandler(this.button_hover);
            this.B3.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // C3
            // 
            this.C3.BackColor = System.Drawing.Color.White;
            this.C3.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C3.Location = new System.Drawing.Point(220, 286);
            this.C3.Name = "C3";
            this.C3.Size = new System.Drawing.Size(100, 100);
            this.C3.TabIndex = 0;
            this.C3.TabStop = false;
            this.C3.UseVisualStyleBackColor = false;
            this.C3.Click += new System.EventHandler(this.button_click);
            this.C3.MouseEnter += new System.EventHandler(this.button_hover);
            this.C3.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // gameLabel
            // 
            this.gameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gameLabel.AutoSize = true;
            this.gameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameLabel.ForeColor = System.Drawing.Color.White;
            this.gameLabel.Location = new System.Drawing.Point(68, 33);
            this.gameLabel.Name = "gameLabel";
            this.gameLabel.Size = new System.Drawing.Size(195, 31);
            this.gameLabel.TabIndex = 2;
            this.gameLabel.Text = "Player 1\'s Turn";
            this.gameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // colorsToolStripMenuItem
            // 
            this.colorsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.foregroundToolStripMenuItem,
            this.backgroundToolStripMenuItem,
            this.victoryToolStripMenuItem});
            this.colorsToolStripMenuItem.Name = "colorsToolStripMenuItem";
            this.colorsToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.colorsToolStripMenuItem.Text = "Colors";
            // 
            // backgroundToolStripMenuItem
            // 
            this.backgroundToolStripMenuItem.Name = "backgroundToolStripMenuItem";
            this.backgroundToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.backgroundToolStripMenuItem.Text = "Background";
            this.backgroundToolStripMenuItem.Click += new System.EventHandler(this.backgroundToolStripMenuItem_Click);
            // 
            // foregroundToolStripMenuItem
            // 
            this.foregroundToolStripMenuItem.Name = "foregroundToolStripMenuItem";
            this.foregroundToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.foregroundToolStripMenuItem.Text = "Foreground";
            this.foregroundToolStripMenuItem.Click += new System.EventHandler(this.foregroundToolStripMenuItem_Click);
            // 
            // victoryToolStripMenuItem
            // 
            this.victoryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.player1ToolStripMenuItem,
            this.player2ToolStripMenuItem});
            this.victoryToolStripMenuItem.Name = "victoryToolStripMenuItem";
            this.victoryToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.victoryToolStripMenuItem.Text = "Victory";
            // 
            // player1ToolStripMenuItem
            // 
            this.player1ToolStripMenuItem.Name = "player1ToolStripMenuItem";
            this.player1ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.player1ToolStripMenuItem.Text = "Player 1";
            this.player1ToolStripMenuItem.Click += new System.EventHandler(this.player1ToolStripMenuItem_Click);
            // 
            // player2ToolStripMenuItem
            // 
            this.player2ToolStripMenuItem.Name = "player2ToolStripMenuItem";
            this.player2ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.player2ToolStripMenuItem.Text = "Player 2";
            this.player2ToolStripMenuItem.Click += new System.EventHandler(this.player2ToolStripMenuItem_Click);
            // 
            // bgColorDialog
            // 
            this.bgColorDialog.AnyColor = true;
            // 
            // fgColorDialog
            // 
            this.fgColorDialog.AnyColor = true;
            this.fgColorDialog.Color = System.Drawing.Color.White;
            // 
            // victoryColorDialog
            // 
            this.victoryColorDialog.AnyColor = true;
            // 
            // resetToolStripMenuItem
            // 
            this.resetToolStripMenuItem.Name = "resetToolStripMenuItem";
            this.resetToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.resetToolStripMenuItem.Text = "Reset";
            this.resetToolStripMenuItem.Click += new System.EventHandler(this.resetToolStripMenuItem_Click);
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(330, 399);
            this.Controls.Add(this.gameLabel);
            this.Controls.Add(this.C3);
            this.Controls.Add(this.C2);
            this.Controls.Add(this.C1);
            this.Controls.Add(this.B3);
            this.Controls.Add(this.A3);
            this.Controls.Add(this.B2);
            this.Controls.Add(this.A2);
            this.Controls.Add(this.B1);
            this.Controls.Add(this.A1);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(346, 438);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(346, 438);
            this.Name = "main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tic Tac Toe";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Button A1;
        private System.Windows.Forms.Button B1;
        private System.Windows.Forms.Button C1;
        private System.Windows.Forms.Button A2;
        private System.Windows.Forms.Button B2;
        private System.Windows.Forms.Button C2;
        private System.Windows.Forms.Button A3;
        private System.Windows.Forms.Button B3;
        private System.Windows.Forms.Button C3;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scoreToolStripMenuItem;
        private System.Windows.Forms.Label gameLabel;
        private System.Windows.Forms.ToolStripMenuItem colorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem victoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem player1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem player2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem foregroundToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backgroundToolStripMenuItem;
        private System.Windows.Forms.ColorDialog bgColorDialog;
        private System.Windows.Forms.ColorDialog fgColorDialog;
        private System.Windows.Forms.ColorDialog victoryColorDialog;
        private System.Windows.Forms.ToolStripMenuItem resetToolStripMenuItem;
    }
}

