namespace Hangman
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
            this.playerTurn = new System.Windows.Forms.Label();
            this.wordBox = new System.Windows.Forms.TextBox();
            this.playButton = new System.Windows.Forms.Button();
            this.scene = new System.Windows.Forms.PictureBox();
            this.firstLetter = new System.Windows.Forms.Label();
            this.secondLetter = new System.Windows.Forms.Label();
            this.thirdLetter = new System.Windows.Forms.Label();
            this.fourthLetter = new System.Windows.Forms.Label();
            this.fifthLetter = new System.Windows.Forms.Label();
            this.sixthLetter = new System.Windows.Forms.Label();
            this.seventhLetter = new System.Windows.Forms.Label();
            this.eighthLetter = new System.Windows.Forms.Label();
            this.ninthLetter = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.newWordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newWordToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonA = new System.Windows.Forms.Button();
            this.buttonB = new System.Windows.Forms.Button();
            this.buttonC = new System.Windows.Forms.Button();
            this.buttonD = new System.Windows.Forms.Button();
            this.buttonE = new System.Windows.Forms.Button();
            this.buttonF = new System.Windows.Forms.Button();
            this.buttonG = new System.Windows.Forms.Button();
            this.buttonH = new System.Windows.Forms.Button();
            this.buttonI = new System.Windows.Forms.Button();
            this.buttonJ = new System.Windows.Forms.Button();
            this.buttonK = new System.Windows.Forms.Button();
            this.buttonL = new System.Windows.Forms.Button();
            this.buttonM = new System.Windows.Forms.Button();
            this.buttonN = new System.Windows.Forms.Button();
            this.buttonO = new System.Windows.Forms.Button();
            this.buttonP = new System.Windows.Forms.Button();
            this.buttonQ = new System.Windows.Forms.Button();
            this.buttonR = new System.Windows.Forms.Button();
            this.buttonS = new System.Windows.Forms.Button();
            this.buttonT = new System.Windows.Forms.Button();
            this.buttonU = new System.Windows.Forms.Button();
            this.buttonV = new System.Windows.Forms.Button();
            this.buttonW = new System.Windows.Forms.Button();
            this.buttonX = new System.Windows.Forms.Button();
            this.buttonY = new System.Windows.Forms.Button();
            this.buttonZ = new System.Windows.Forms.Button();
            this.advice = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.scene)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // playerTurn
            // 
            this.playerTurn.AutoSize = true;
            this.playerTurn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerTurn.Location = new System.Drawing.Point(440, 216);
            this.playerTurn.Name = "playerTurn";
            this.playerTurn.Size = new System.Drawing.Size(231, 25);
            this.playerTurn.TabIndex = 0;
            this.playerTurn.Text = "Player 1: Enter Word";
            // 
            // wordBox
            // 
            this.wordBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wordBox.Location = new System.Drawing.Point(334, 285);
            this.wordBox.MaxLength = 9;
            this.wordBox.Name = "wordBox";
            this.wordBox.Size = new System.Drawing.Size(443, 35);
            this.wordBox.TabIndex = 1;
            this.wordBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.wordBox.UseSystemPasswordChar = true;
            this.wordBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.wordBox_KeyDown);
            // 
            // playButton
            // 
            this.playButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playButton.Location = new System.Drawing.Point(518, 354);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(75, 37);
            this.playButton.TabIndex = 2;
            this.playButton.Text = "PLAY!";
            this.playButton.UseVisualStyleBackColor = true;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // scene
            // 
            this.scene.Image = global::Hangman.Properties.Resources.blank;
            this.scene.Location = new System.Drawing.Point(-6, 2);
            this.scene.Name = "scene";
            this.scene.Size = new System.Drawing.Size(725, 607);
            this.scene.TabIndex = 3;
            this.scene.TabStop = false;
            this.scene.Visible = false;
            // 
            // firstLetter
            // 
            this.firstLetter.AutoSize = true;
            this.firstLetter.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstLetter.Location = new System.Drawing.Point(741, 43);
            this.firstLetter.MinimumSize = new System.Drawing.Size(35, 18);
            this.firstLetter.Name = "firstLetter";
            this.firstLetter.Size = new System.Drawing.Size(35, 18);
            this.firstLetter.TabIndex = 4;
            this.firstLetter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // secondLetter
            // 
            this.secondLetter.AutoSize = true;
            this.secondLetter.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secondLetter.Location = new System.Drawing.Point(781, 43);
            this.secondLetter.MinimumSize = new System.Drawing.Size(35, 18);
            this.secondLetter.Name = "secondLetter";
            this.secondLetter.Size = new System.Drawing.Size(35, 18);
            this.secondLetter.TabIndex = 4;
            this.secondLetter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // thirdLetter
            // 
            this.thirdLetter.AutoSize = true;
            this.thirdLetter.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thirdLetter.Location = new System.Drawing.Point(821, 43);
            this.thirdLetter.MinimumSize = new System.Drawing.Size(35, 18);
            this.thirdLetter.Name = "thirdLetter";
            this.thirdLetter.Size = new System.Drawing.Size(35, 18);
            this.thirdLetter.TabIndex = 4;
            this.thirdLetter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fourthLetter
            // 
            this.fourthLetter.AutoSize = true;
            this.fourthLetter.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fourthLetter.Location = new System.Drawing.Point(861, 43);
            this.fourthLetter.MinimumSize = new System.Drawing.Size(35, 18);
            this.fourthLetter.Name = "fourthLetter";
            this.fourthLetter.Size = new System.Drawing.Size(35, 18);
            this.fourthLetter.TabIndex = 4;
            this.fourthLetter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fifthLetter
            // 
            this.fifthLetter.AutoSize = true;
            this.fifthLetter.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fifthLetter.Location = new System.Drawing.Point(901, 43);
            this.fifthLetter.MinimumSize = new System.Drawing.Size(35, 18);
            this.fifthLetter.Name = "fifthLetter";
            this.fifthLetter.Size = new System.Drawing.Size(35, 18);
            this.fifthLetter.TabIndex = 4;
            this.fifthLetter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sixthLetter
            // 
            this.sixthLetter.AutoSize = true;
            this.sixthLetter.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sixthLetter.Location = new System.Drawing.Point(941, 43);
            this.sixthLetter.MinimumSize = new System.Drawing.Size(35, 18);
            this.sixthLetter.Name = "sixthLetter";
            this.sixthLetter.Size = new System.Drawing.Size(35, 18);
            this.sixthLetter.TabIndex = 4;
            this.sixthLetter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // seventhLetter
            // 
            this.seventhLetter.AutoSize = true;
            this.seventhLetter.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seventhLetter.Location = new System.Drawing.Point(981, 43);
            this.seventhLetter.MinimumSize = new System.Drawing.Size(35, 18);
            this.seventhLetter.Name = "seventhLetter";
            this.seventhLetter.Size = new System.Drawing.Size(35, 18);
            this.seventhLetter.TabIndex = 4;
            this.seventhLetter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // eighthLetter
            // 
            this.eighthLetter.AutoSize = true;
            this.eighthLetter.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eighthLetter.Location = new System.Drawing.Point(1021, 43);
            this.eighthLetter.MinimumSize = new System.Drawing.Size(35, 18);
            this.eighthLetter.Name = "eighthLetter";
            this.eighthLetter.Size = new System.Drawing.Size(35, 18);
            this.eighthLetter.TabIndex = 4;
            this.eighthLetter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ninthLetter
            // 
            this.ninthLetter.AutoSize = true;
            this.ninthLetter.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ninthLetter.Location = new System.Drawing.Point(1061, 43);
            this.ninthLetter.MinimumSize = new System.Drawing.Size(35, 18);
            this.ninthLetter.Name = "ninthLetter";
            this.ninthLetter.Size = new System.Drawing.Size(35, 18);
            this.ninthLetter.TabIndex = 4;
            this.ninthLetter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newWordToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1110, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // newWordToolStripMenuItem
            // 
            this.newWordToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newWordToolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.newWordToolStripMenuItem.Name = "newWordToolStripMenuItem";
            this.newWordToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.newWordToolStripMenuItem.Text = "File";
            // 
            // newWordToolStripMenuItem1
            // 
            this.newWordToolStripMenuItem1.Name = "newWordToolStripMenuItem1";
            this.newWordToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newWordToolStripMenuItem1.Size = new System.Drawing.Size(173, 22);
            this.newWordToolStripMenuItem1.Text = "New Word";
            this.newWordToolStripMenuItem1.Click += new System.EventHandler(this.newWordToolStripMenuItem1_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // buttonA
            // 
            this.buttonA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonA.Location = new System.Drawing.Point(754, 108);
            this.buttonA.Name = "buttonA";
            this.buttonA.Size = new System.Drawing.Size(60, 60);
            this.buttonA.TabIndex = 3;
            this.buttonA.Text = "A";
            this.buttonA.UseVisualStyleBackColor = true;
            this.buttonA.Visible = false;
            this.buttonA.Click += new System.EventHandler(this.letter_click);
            // 
            // buttonB
            // 
            this.buttonB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonB.Location = new System.Drawing.Point(820, 108);
            this.buttonB.Name = "buttonB";
            this.buttonB.Size = new System.Drawing.Size(60, 60);
            this.buttonB.TabIndex = 4;
            this.buttonB.Text = "B";
            this.buttonB.UseVisualStyleBackColor = true;
            this.buttonB.Visible = false;
            this.buttonB.Click += new System.EventHandler(this.letter_click);
            // 
            // buttonC
            // 
            this.buttonC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonC.Location = new System.Drawing.Point(886, 108);
            this.buttonC.Name = "buttonC";
            this.buttonC.Size = new System.Drawing.Size(60, 60);
            this.buttonC.TabIndex = 5;
            this.buttonC.Text = "C";
            this.buttonC.UseVisualStyleBackColor = true;
            this.buttonC.Visible = false;
            this.buttonC.Click += new System.EventHandler(this.letter_click);
            // 
            // buttonD
            // 
            this.buttonD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonD.Location = new System.Drawing.Point(952, 108);
            this.buttonD.Name = "buttonD";
            this.buttonD.Size = new System.Drawing.Size(60, 60);
            this.buttonD.TabIndex = 6;
            this.buttonD.Text = "D";
            this.buttonD.UseVisualStyleBackColor = true;
            this.buttonD.Visible = false;
            this.buttonD.Click += new System.EventHandler(this.letter_click);
            // 
            // buttonE
            // 
            this.buttonE.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonE.Location = new System.Drawing.Point(1018, 108);
            this.buttonE.Name = "buttonE";
            this.buttonE.Size = new System.Drawing.Size(60, 60);
            this.buttonE.TabIndex = 7;
            this.buttonE.Text = "E";
            this.buttonE.UseVisualStyleBackColor = true;
            this.buttonE.Visible = false;
            this.buttonE.Click += new System.EventHandler(this.letter_click);
            // 
            // buttonF
            // 
            this.buttonF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonF.Location = new System.Drawing.Point(754, 174);
            this.buttonF.Name = "buttonF";
            this.buttonF.Size = new System.Drawing.Size(60, 60);
            this.buttonF.TabIndex = 8;
            this.buttonF.Text = "F";
            this.buttonF.UseVisualStyleBackColor = true;
            this.buttonF.Visible = false;
            this.buttonF.Click += new System.EventHandler(this.letter_click);
            // 
            // buttonG
            // 
            this.buttonG.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonG.Location = new System.Drawing.Point(820, 174);
            this.buttonG.Name = "buttonG";
            this.buttonG.Size = new System.Drawing.Size(60, 60);
            this.buttonG.TabIndex = 9;
            this.buttonG.Text = "G";
            this.buttonG.UseVisualStyleBackColor = true;
            this.buttonG.Visible = false;
            this.buttonG.Click += new System.EventHandler(this.letter_click);
            // 
            // buttonH
            // 
            this.buttonH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonH.Location = new System.Drawing.Point(886, 174);
            this.buttonH.Name = "buttonH";
            this.buttonH.Size = new System.Drawing.Size(60, 60);
            this.buttonH.TabIndex = 10;
            this.buttonH.Text = "H";
            this.buttonH.UseVisualStyleBackColor = true;
            this.buttonH.Visible = false;
            this.buttonH.Click += new System.EventHandler(this.letter_click);
            // 
            // buttonI
            // 
            this.buttonI.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonI.Location = new System.Drawing.Point(952, 174);
            this.buttonI.Name = "buttonI";
            this.buttonI.Size = new System.Drawing.Size(60, 60);
            this.buttonI.TabIndex = 11;
            this.buttonI.Tag = "";
            this.buttonI.Text = "I";
            this.buttonI.UseVisualStyleBackColor = true;
            this.buttonI.Visible = false;
            this.buttonI.Click += new System.EventHandler(this.letter_click);
            // 
            // buttonJ
            // 
            this.buttonJ.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonJ.Location = new System.Drawing.Point(1018, 174);
            this.buttonJ.Name = "buttonJ";
            this.buttonJ.Size = new System.Drawing.Size(60, 60);
            this.buttonJ.TabIndex = 12;
            this.buttonJ.Text = "J";
            this.buttonJ.UseVisualStyleBackColor = true;
            this.buttonJ.Visible = false;
            this.buttonJ.Click += new System.EventHandler(this.letter_click);
            // 
            // buttonK
            // 
            this.buttonK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonK.Location = new System.Drawing.Point(754, 240);
            this.buttonK.Name = "buttonK";
            this.buttonK.Size = new System.Drawing.Size(60, 60);
            this.buttonK.TabIndex = 13;
            this.buttonK.Text = "K";
            this.buttonK.UseVisualStyleBackColor = true;
            this.buttonK.Visible = false;
            this.buttonK.Click += new System.EventHandler(this.letter_click);
            // 
            // buttonL
            // 
            this.buttonL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonL.Location = new System.Drawing.Point(820, 240);
            this.buttonL.Name = "buttonL";
            this.buttonL.Size = new System.Drawing.Size(60, 60);
            this.buttonL.TabIndex = 14;
            this.buttonL.Text = "L";
            this.buttonL.UseVisualStyleBackColor = true;
            this.buttonL.Visible = false;
            this.buttonL.Click += new System.EventHandler(this.letter_click);
            // 
            // buttonM
            // 
            this.buttonM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonM.Location = new System.Drawing.Point(886, 240);
            this.buttonM.Name = "buttonM";
            this.buttonM.Size = new System.Drawing.Size(60, 60);
            this.buttonM.TabIndex = 15;
            this.buttonM.Text = "M";
            this.buttonM.UseVisualStyleBackColor = true;
            this.buttonM.Visible = false;
            this.buttonM.Click += new System.EventHandler(this.letter_click);
            // 
            // buttonN
            // 
            this.buttonN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonN.Location = new System.Drawing.Point(952, 240);
            this.buttonN.Name = "buttonN";
            this.buttonN.Size = new System.Drawing.Size(60, 60);
            this.buttonN.TabIndex = 16;
            this.buttonN.Text = "N";
            this.buttonN.UseVisualStyleBackColor = true;
            this.buttonN.Visible = false;
            this.buttonN.Click += new System.EventHandler(this.letter_click);
            // 
            // buttonO
            // 
            this.buttonO.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonO.Location = new System.Drawing.Point(1018, 240);
            this.buttonO.Name = "buttonO";
            this.buttonO.Size = new System.Drawing.Size(60, 60);
            this.buttonO.TabIndex = 17;
            this.buttonO.Text = "O";
            this.buttonO.UseVisualStyleBackColor = true;
            this.buttonO.Visible = false;
            this.buttonO.Click += new System.EventHandler(this.letter_click);
            // 
            // buttonP
            // 
            this.buttonP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonP.Location = new System.Drawing.Point(754, 306);
            this.buttonP.Name = "buttonP";
            this.buttonP.Size = new System.Drawing.Size(60, 60);
            this.buttonP.TabIndex = 18;
            this.buttonP.Text = "P";
            this.buttonP.UseVisualStyleBackColor = true;
            this.buttonP.Visible = false;
            this.buttonP.Click += new System.EventHandler(this.letter_click);
            // 
            // buttonQ
            // 
            this.buttonQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonQ.Location = new System.Drawing.Point(820, 306);
            this.buttonQ.Name = "buttonQ";
            this.buttonQ.Size = new System.Drawing.Size(60, 60);
            this.buttonQ.TabIndex = 19;
            this.buttonQ.Text = "Q";
            this.buttonQ.UseVisualStyleBackColor = true;
            this.buttonQ.Visible = false;
            this.buttonQ.Click += new System.EventHandler(this.letter_click);
            // 
            // buttonR
            // 
            this.buttonR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonR.Location = new System.Drawing.Point(886, 306);
            this.buttonR.Name = "buttonR";
            this.buttonR.Size = new System.Drawing.Size(60, 60);
            this.buttonR.TabIndex = 20;
            this.buttonR.Text = "R";
            this.buttonR.UseVisualStyleBackColor = true;
            this.buttonR.Visible = false;
            this.buttonR.Click += new System.EventHandler(this.letter_click);
            // 
            // buttonS
            // 
            this.buttonS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonS.Location = new System.Drawing.Point(952, 306);
            this.buttonS.Name = "buttonS";
            this.buttonS.Size = new System.Drawing.Size(60, 60);
            this.buttonS.TabIndex = 21;
            this.buttonS.Text = "S";
            this.buttonS.UseVisualStyleBackColor = true;
            this.buttonS.Visible = false;
            this.buttonS.Click += new System.EventHandler(this.letter_click);
            // 
            // buttonT
            // 
            this.buttonT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonT.Location = new System.Drawing.Point(1018, 306);
            this.buttonT.Name = "buttonT";
            this.buttonT.Size = new System.Drawing.Size(60, 60);
            this.buttonT.TabIndex = 22;
            this.buttonT.Text = "T";
            this.buttonT.UseVisualStyleBackColor = true;
            this.buttonT.Visible = false;
            this.buttonT.Click += new System.EventHandler(this.letter_click);
            // 
            // buttonU
            // 
            this.buttonU.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonU.Location = new System.Drawing.Point(754, 372);
            this.buttonU.Name = "buttonU";
            this.buttonU.Size = new System.Drawing.Size(60, 60);
            this.buttonU.TabIndex = 23;
            this.buttonU.Text = "U";
            this.buttonU.UseVisualStyleBackColor = true;
            this.buttonU.Visible = false;
            this.buttonU.Click += new System.EventHandler(this.letter_click);
            // 
            // buttonV
            // 
            this.buttonV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonV.Location = new System.Drawing.Point(820, 372);
            this.buttonV.Name = "buttonV";
            this.buttonV.Size = new System.Drawing.Size(60, 60);
            this.buttonV.TabIndex = 24;
            this.buttonV.Text = "V";
            this.buttonV.UseVisualStyleBackColor = true;
            this.buttonV.Visible = false;
            this.buttonV.Click += new System.EventHandler(this.letter_click);
            // 
            // buttonW
            // 
            this.buttonW.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonW.Location = new System.Drawing.Point(886, 372);
            this.buttonW.Name = "buttonW";
            this.buttonW.Size = new System.Drawing.Size(60, 60);
            this.buttonW.TabIndex = 25;
            this.buttonW.Text = "W";
            this.buttonW.UseVisualStyleBackColor = true;
            this.buttonW.Visible = false;
            this.buttonW.Click += new System.EventHandler(this.letter_click);
            // 
            // buttonX
            // 
            this.buttonX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonX.Location = new System.Drawing.Point(952, 372);
            this.buttonX.Name = "buttonX";
            this.buttonX.Size = new System.Drawing.Size(60, 60);
            this.buttonX.TabIndex = 26;
            this.buttonX.Text = "X";
            this.buttonX.UseVisualStyleBackColor = true;
            this.buttonX.Visible = false;
            this.buttonX.Click += new System.EventHandler(this.letter_click);
            // 
            // buttonY
            // 
            this.buttonY.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonY.Location = new System.Drawing.Point(1018, 372);
            this.buttonY.Name = "buttonY";
            this.buttonY.Size = new System.Drawing.Size(60, 60);
            this.buttonY.TabIndex = 27;
            this.buttonY.Text = "Y";
            this.buttonY.UseVisualStyleBackColor = true;
            this.buttonY.Visible = false;
            this.buttonY.Click += new System.EventHandler(this.letter_click);
            // 
            // buttonZ
            // 
            this.buttonZ.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonZ.Location = new System.Drawing.Point(886, 438);
            this.buttonZ.Name = "buttonZ";
            this.buttonZ.Size = new System.Drawing.Size(60, 60);
            this.buttonZ.TabIndex = 28;
            this.buttonZ.Text = "Z";
            this.buttonZ.UseVisualStyleBackColor = true;
            this.buttonZ.Visible = false;
            this.buttonZ.Click += new System.EventHandler(this.letter_click);
            // 
            // advice
            // 
            this.advice.AutoSize = true;
            this.advice.Location = new System.Drawing.Point(476, 257);
            this.advice.Name = "advice";
            this.advice.Size = new System.Drawing.Size(159, 13);
            this.advice.TabIndex = 7;
            this.advice.Text = "(Only use alphabetic characters)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1110, 606);
            this.Controls.Add(this.advice);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.ninthLetter);
            this.Controls.Add(this.eighthLetter);
            this.Controls.Add(this.seventhLetter);
            this.Controls.Add(this.sixthLetter);
            this.Controls.Add(this.fifthLetter);
            this.Controls.Add(this.fourthLetter);
            this.Controls.Add(this.thirdLetter);
            this.Controls.Add(this.secondLetter);
            this.Controls.Add(this.firstLetter);
            this.Controls.Add(this.playButton);
            this.Controls.Add(this.wordBox);
            this.Controls.Add(this.playerTurn);
            this.Controls.Add(this.scene);
            this.Controls.Add(this.buttonY);
            this.Controls.Add(this.buttonT);
            this.Controls.Add(this.buttonO);
            this.Controls.Add(this.buttonX);
            this.Controls.Add(this.buttonS);
            this.Controls.Add(this.buttonN);
            this.Controls.Add(this.buttonZ);
            this.Controls.Add(this.buttonW);
            this.Controls.Add(this.buttonR);
            this.Controls.Add(this.buttonM);
            this.Controls.Add(this.buttonV);
            this.Controls.Add(this.buttonQ);
            this.Controls.Add(this.buttonL);
            this.Controls.Add(this.buttonU);
            this.Controls.Add(this.buttonP);
            this.Controls.Add(this.buttonK);
            this.Controls.Add(this.buttonJ);
            this.Controls.Add(this.buttonI);
            this.Controls.Add(this.buttonH);
            this.Controls.Add(this.buttonG);
            this.Controls.Add(this.buttonF);
            this.Controls.Add(this.buttonE);
            this.Controls.Add(this.buttonD);
            this.Controls.Add(this.buttonC);
            this.Controls.Add(this.buttonB);
            this.Controls.Add(this.buttonA);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1126, 645);
            this.MinimumSize = new System.Drawing.Size(1126, 645);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hangman";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.scene)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label playerTurn;
        private System.Windows.Forms.TextBox wordBox;
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.PictureBox scene;
        private System.Windows.Forms.Label firstLetter;
        private System.Windows.Forms.Label secondLetter;
        private System.Windows.Forms.Label thirdLetter;
        private System.Windows.Forms.Label fourthLetter;
        private System.Windows.Forms.Label fifthLetter;
        private System.Windows.Forms.Label sixthLetter;
        private System.Windows.Forms.Label seventhLetter;
        private System.Windows.Forms.Label eighthLetter;
        private System.Windows.Forms.Label ninthLetter;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem newWordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newWordToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button buttonA;
        private System.Windows.Forms.Button buttonB;
        private System.Windows.Forms.Button buttonC;
        private System.Windows.Forms.Button buttonD;
        private System.Windows.Forms.Button buttonE;
        private System.Windows.Forms.Button buttonF;
        private System.Windows.Forms.Button buttonG;
        private System.Windows.Forms.Button buttonH;
        private System.Windows.Forms.Button buttonI;
        private System.Windows.Forms.Button buttonJ;
        private System.Windows.Forms.Button buttonK;
        private System.Windows.Forms.Button buttonL;
        private System.Windows.Forms.Button buttonM;
        private System.Windows.Forms.Button buttonN;
        private System.Windows.Forms.Button buttonO;
        private System.Windows.Forms.Button buttonP;
        private System.Windows.Forms.Button buttonQ;
        private System.Windows.Forms.Button buttonR;
        private System.Windows.Forms.Button buttonS;
        private System.Windows.Forms.Button buttonT;
        private System.Windows.Forms.Button buttonU;
        private System.Windows.Forms.Button buttonV;
        private System.Windows.Forms.Button buttonW;
        private System.Windows.Forms.Button buttonX;
        private System.Windows.Forms.Button buttonY;
        private System.Windows.Forms.Button buttonZ;
        private System.Windows.Forms.Label advice;
    }
}

