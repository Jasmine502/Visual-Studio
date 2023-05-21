namespace Gen_1PokemonCaptureSimulation
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
            this.chooseBallLabel = new System.Windows.Forms.Label();
            this.ballChosenBox = new System.Windows.Forms.TextBox();
            this.pokStatusLabel = new System.Windows.Forms.Label();
            this.pokStatusBox = new System.Windows.Forms.TextBox();
            this.catchRateLabel = new System.Windows.Forms.Label();
            this.catchRateBox = new System.Windows.Forms.TextBox();
            this.throwBallButton = new System.Windows.Forms.Button();
            this.pokMaxHPLabel = new System.Windows.Forms.Label();
            this.pokMaxHPBox = new System.Windows.Forms.TextBox();
            this.currentHPLabel = new System.Windows.Forms.Label();
            this.pokCurrentHPBox = new System.Windows.Forms.TextBox();
            this.caughtTimer = new System.Windows.Forms.Timer(this.components);
            this.freeTimer = new System.Windows.Forms.Timer(this.components);
            this.pokemonNameLabel = new System.Windows.Forms.Label();
            this.pokemonBox = new System.Windows.Forms.TextBox();
            this.battleButton = new System.Windows.Forms.Button();
            this.caughtLabel = new System.Windows.Forms.Label();
            this.pokemonTeamBox = new System.Windows.Forms.ListBox();
            this.currentTeamLabel = new System.Windows.Forms.Label();
            this.addToTeamButton = new System.Windows.Forms.Button();
            this.pcLabel = new System.Windows.Forms.Label();
            this.pcBox = new System.Windows.Forms.ListBox();
            this.addToPCButton = new System.Windows.Forms.Button();
            this.releaseButton = new System.Windows.Forms.Button();
            this.moneyLabel = new System.Windows.Forms.Label();
            this.moneyBorder = new System.Windows.Forms.Label();
            this.shopLabel = new System.Windows.Forms.Label();
            this.itemsBox = new System.Windows.Forms.Label();
            this.buyPBButton = new System.Windows.Forms.Button();
            this.buyGBButton = new System.Windows.Forms.Button();
            this.buyUBButton = new System.Windows.Forms.Button();
            this.buySBButton = new System.Windows.Forms.Button();
            this.buyMBButton = new System.Windows.Forms.Button();
            this.shopBG = new System.Windows.Forms.Label();
            this.buyMegaStoneButton = new System.Windows.Forms.Button();
            this.megaEvolveButton = new System.Windows.Forms.Button();
            this.deselectButton = new System.Windows.Forms.Button();
            this.randomCurrentHPButton = new System.Windows.Forms.PictureBox();
            this.randomMaxHPButton = new System.Windows.Forms.PictureBox();
            this.randomStatusButton = new System.Windows.Forms.PictureBox();
            this.randomPokemonButton = new System.Windows.Forms.PictureBox();
            this.randomBallButton = new System.Windows.Forms.PictureBox();
            this.pointer6 = new System.Windows.Forms.PictureBox();
            this.pointer5 = new System.Windows.Forms.PictureBox();
            this.pointer4 = new System.Windows.Forms.PictureBox();
            this.pointer3 = new System.Windows.Forms.PictureBox();
            this.pointer2 = new System.Windows.Forms.PictureBox();
            this.pointer1 = new System.Windows.Forms.PictureBox();
            this.pokemonDollarSign = new System.Windows.Forms.PictureBox();
            this.martLogo = new System.Windows.Forms.PictureBox();
            this.pokeBallBox = new System.Windows.Forms.PictureBox();
            this.resetButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.randomCurrentHPButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.randomMaxHPButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.randomStatusButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.randomPokemonButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.randomBallButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pointer6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pointer5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pointer4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pointer3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pointer2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pointer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pokemonDollarSign)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.martLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pokeBallBox)).BeginInit();
            this.SuspendLayout();
            // 
            // chooseBallLabel
            // 
            this.chooseBallLabel.AutoSize = true;
            this.chooseBallLabel.BackColor = System.Drawing.Color.Transparent;
            this.chooseBallLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chooseBallLabel.Location = new System.Drawing.Point(58, 89);
            this.chooseBallLabel.Name = "chooseBallLabel";
            this.chooseBallLabel.Size = new System.Drawing.Size(78, 13);
            this.chooseBallLabel.TabIndex = 0;
            this.chooseBallLabel.Text = "Choose Ball:";
            this.chooseBallLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // ballChosenBox
            // 
            this.ballChosenBox.AutoCompleteCustomSource.AddRange(new string[] {
            "PokeBall",
            "Great Ball",
            "Ultra Ball",
            "Safari Ball",
            "Master Ball"});
            this.ballChosenBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.ballChosenBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.ballChosenBox.Location = new System.Drawing.Point(47, 109);
            this.ballChosenBox.Name = "ballChosenBox";
            this.ballChosenBox.Size = new System.Drawing.Size(100, 20);
            this.ballChosenBox.TabIndex = 2;
            this.ballChosenBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pokStatusLabel
            // 
            this.pokStatusLabel.AutoSize = true;
            this.pokStatusLabel.BackColor = System.Drawing.Color.Transparent;
            this.pokStatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pokStatusLabel.Location = new System.Drawing.Point(46, 136);
            this.pokStatusLabel.Name = "pokStatusLabel";
            this.pokStatusLabel.Size = new System.Drawing.Size(103, 13);
            this.pokStatusLabel.TabIndex = 0;
            this.pokStatusLabel.Text = "Pokémon Status:\r\n";
            this.pokStatusLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // pokStatusBox
            // 
            this.pokStatusBox.Location = new System.Drawing.Point(80, 156);
            this.pokStatusBox.MaxLength = 3;
            this.pokStatusBox.Name = "pokStatusBox";
            this.pokStatusBox.Size = new System.Drawing.Size(34, 20);
            this.pokStatusBox.TabIndex = 3;
            this.pokStatusBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // catchRateLabel
            // 
            this.catchRateLabel.AutoSize = true;
            this.catchRateLabel.BackColor = System.Drawing.Color.Transparent;
            this.catchRateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.catchRateLabel.Location = new System.Drawing.Point(32, 183);
            this.catchRateLabel.Name = "catchRateLabel";
            this.catchRateLabel.Size = new System.Drawing.Size(131, 13);
            this.catchRateLabel.TabIndex = 0;
            this.catchRateLabel.Text = "Pokémon Catch Rate:";
            this.catchRateLabel.Click += new System.EventHandler(this.label3_Click);
            // 
            // catchRateBox
            // 
            this.catchRateBox.Enabled = false;
            this.catchRateBox.Location = new System.Drawing.Point(47, 203);
            this.catchRateBox.Name = "catchRateBox";
            this.catchRateBox.Size = new System.Drawing.Size(100, 20);
            this.catchRateBox.TabIndex = 4;
            this.catchRateBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // throwBallButton
            // 
            this.throwBallButton.BackColor = System.Drawing.Color.White;
            this.throwBallButton.Enabled = false;
            this.throwBallButton.Location = new System.Drawing.Point(60, 324);
            this.throwBallButton.Name = "throwBallButton";
            this.throwBallButton.Size = new System.Drawing.Size(75, 23);
            this.throwBallButton.TabIndex = 7;
            this.throwBallButton.Text = "Throw Ball!";
            this.throwBallButton.UseVisualStyleBackColor = false;
            this.throwBallButton.Click += new System.EventHandler(this.throwBallButton_Click);
            // 
            // pokMaxHPLabel
            // 
            this.pokMaxHPLabel.AutoSize = true;
            this.pokMaxHPLabel.BackColor = System.Drawing.Color.Transparent;
            this.pokMaxHPLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pokMaxHPLabel.Location = new System.Drawing.Point(28, 230);
            this.pokMaxHPLabel.Name = "pokMaxHPLabel";
            this.pokMaxHPLabel.Size = new System.Drawing.Size(139, 13);
            this.pokMaxHPLabel.TabIndex = 0;
            this.pokMaxHPLabel.Text = "Pokémon Maximum HP:";
            this.pokMaxHPLabel.Click += new System.EventHandler(this.label4_Click);
            // 
            // pokMaxHPBox
            // 
            this.pokMaxHPBox.Location = new System.Drawing.Point(47, 250);
            this.pokMaxHPBox.Name = "pokMaxHPBox";
            this.pokMaxHPBox.Size = new System.Drawing.Size(100, 20);
            this.pokMaxHPBox.TabIndex = 5;
            this.pokMaxHPBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.pokMaxHPBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.pokMaxHPBox_KeyDown);
            // 
            // currentHPLabel
            // 
            this.currentHPLabel.AutoSize = true;
            this.currentHPLabel.BackColor = System.Drawing.Color.Transparent;
            this.currentHPLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentHPLabel.Location = new System.Drawing.Point(33, 277);
            this.currentHPLabel.Name = "currentHPLabel";
            this.currentHPLabel.Size = new System.Drawing.Size(129, 13);
            this.currentHPLabel.TabIndex = 0;
            this.currentHPLabel.Text = "Pokémon Current HP:";
            this.currentHPLabel.Click += new System.EventHandler(this.currentHPLabel_Click);
            // 
            // pokCurrentHPBox
            // 
            this.pokCurrentHPBox.Location = new System.Drawing.Point(47, 297);
            this.pokCurrentHPBox.Name = "pokCurrentHPBox";
            this.pokCurrentHPBox.Size = new System.Drawing.Size(100, 20);
            this.pokCurrentHPBox.TabIndex = 6;
            this.pokCurrentHPBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // caughtTimer
            // 
            this.caughtTimer.Tick += new System.EventHandler(this.caughtTimer_Tick);
            // 
            // freeTimer
            // 
            this.freeTimer.Tick += new System.EventHandler(this.freeTimer_Tick);
            // 
            // pokemonNameLabel
            // 
            this.pokemonNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.pokemonNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pokemonNameLabel.Location = new System.Drawing.Point(25, 15);
            this.pokemonNameLabel.Name = "pokemonNameLabel";
            this.pokemonNameLabel.Size = new System.Drawing.Size(148, 19);
            this.pokemonNameLabel.TabIndex = 0;
            this.pokemonNameLabel.Text = "Pokémon Name:\r\n";
            this.pokemonNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.pokemonNameLabel.Click += new System.EventHandler(this.label5_Click);
            // 
            // pokemonBox
            // 
            this.pokemonBox.AutoCompleteCustomSource.AddRange(new string[] {
            "ABOMASNOW",
            "ABRA",
            "ABSOL",
            "ACCELGOR",
            "AEGISLASH",
            "AERODACTYL",
            "AGGRON",
            "AIPOM",
            "ALAKAZAM",
            "ALOMOMOLA",
            "ALTARIA",
            "AMAURA",
            "AMBIPOM",
            "AMOONGUSS",
            "AMPHAROS",
            "ANORITH",
            "ARBOK",
            "ARCANINE",
            "ARCEUS",
            "ARCHEN",
            "ARCHEOPS",
            "ARIADOS",
            "ARMALDO",
            "AROMATISSE",
            "ARON",
            "ARTICUNO",
            "AUDINO",
            "AURORUS",
            "AVALUGG",
            "AXEW",
            "AZELF",
            "AZUMARILL",
            "AZURILL",
            "BAGON",
            "BALTOY",
            "BANETTE",
            "BARBARACLE",
            "BARBOACH",
            "BASCULIN",
            "BASTIODON",
            "BAYLEEF",
            "BEARTIC",
            "BEAUTIFLY",
            "BEEDRILL",
            "BEHEEYEM",
            "BELDUM",
            "BELLOSSOM",
            "BELLSPROUT",
            "BERGMITE",
            "BIBAREL",
            "BIDOOF",
            "BINACLE",
            "BISHARP",
            "BLASTOISE",
            "BLAZIKEN",
            "BLISSEY",
            "BLITZLE",
            "BOLDORE",
            "BONSLY",
            "BOUFFALANT",
            "BRAIXEN",
            "BRAVIARY",
            "BRELOOM",
            "BRONZONG",
            "BRONZOR",
            "BUDEW",
            "BUIZEL",
            "BULBASAUR",
            "BUNEARY",
            "BUNNELBY",
            "BURMY",
            "BUTTERFREE",
            "CACNEA",
            "CACTURNE",
            "CAMERUPT",
            "CARBINK",
            "CARNIVINE",
            "CARRACOSTA",
            "CARVANHA",
            "CASCOON",
            "CASTFORM",
            "CATERPIE",
            "CELEBI",
            "CHANDELURE",
            "CHANSEY",
            "CHARIZARD",
            "CHARMANDER",
            "CHARMELEON",
            "CHATOT",
            "CHERRIM",
            "CHERUBI",
            "CHESNAUGHT",
            "CHESPIN",
            "CHIKORITA",
            "CHIMCHAR",
            "CHIMECHO",
            "CHINCHOU",
            "CHINGLING",
            "CINCCINO",
            "CLAMPERL",
            "CLAUNCHER",
            "CLAWITZER",
            "CLAYDOL",
            "CLEFABLE",
            "CLEFAIRY",
            "CLEFFA",
            "CLOYSTER",
            "COBALION",
            "COFAGRIGUS",
            "COMBEE",
            "COMBUSKEN",
            "CONKELDURR",
            "CORPHISH",
            "CORSOLA",
            "COTTONEE",
            "CRADILY",
            "CRANIDOS",
            "CRAWDAUNT",
            "CRESSELIA",
            "CROAGUNK",
            "CROBAT",
            "CROCONAW",
            "CRUSTLE",
            "CRYOGONAL",
            "CUBCHOO",
            "CUBONE",
            "CYNDAQUIL",
            "DARKRAI",
            "DARMANITAN",
            "DARUMAKA",
            "DEDENNE",
            "DEERLING",
            "DEINO",
            "DELCATTY",
            "DELIBIRD",
            "DELPHOX",
            "DEOXYS",
            "DEWGONG",
            "DEWOTT",
            "DIALGA",
            "DIANCIE",
            "DIGGERSBY",
            "DIGLETT",
            "DITTO",
            "DODRIO",
            "DODUO",
            "DONPHAN",
            "DOUBLADE",
            "DRAGALGE",
            "DRAGONAIR",
            "DRAGONITE",
            "DRAPION",
            "DRATINI",
            "DRIFBLIM",
            "DRIFLOON",
            "DRILBUR",
            "DROWZEE",
            "DRUDDIGON",
            "DUCKLETT",
            "DUGTRIO",
            "DUNSPARCE",
            "DUOSION",
            "DURANT",
            "DUSCLOPS",
            "DUSKNOIR",
            "DUSKULL",
            "DUSTOX",
            "DWEBBLE",
            "EELEKTRIK",
            "EELEKTROSS",
            "EEVEE",
            "EKANS",
            "ELECTABUZZ",
            "ELECTIVIRE",
            "ELECTRIKE",
            "ELECTRODE",
            "ELEKID",
            "ELGYEM",
            "EMBOAR",
            "EMOLGA",
            "EMPOLEON",
            "ENTEI",
            "ESCAVALIER",
            "ESPEON",
            "ESPURR",
            "EXCADRILL",
            "EXEGGCUTE",
            "EXEGGUTOR",
            "EXPLOUD",
            "FARFETCH\'D",
            "FEAROW",
            "FEEBAS",
            "FENNEKIN",
            "FERALIGATR",
            "FERROSEED",
            "FERROTHORN",
            "FINNEON",
            "FLAAFFY",
            "FLABÉBÉ",
            "FLAREON",
            "FLETCHINDER",
            "FLETCHLING",
            "FLOATZEL",
            "FLOETTE",
            "FLORGES",
            "FLYGON",
            "FOONGUS",
            "FORRETRESS",
            "FRAXURE",
            "FRILLISH",
            "FROAKIE",
            "FROGADIER",
            "FROSLASS",
            "FURFROU",
            "FURRET",
            "GABITE",
            "GALLADE",
            "GALVANTULA",
            "GARBODOR",
            "GARCHOMP",
            "GARDEVOIR",
            "GASTLY",
            "GASTRODON",
            "GENESECT",
            "GENGAR",
            "GEODUDE",
            "GIBLE",
            "GIGALITH",
            "GIRAFARIG",
            "GIRATINA",
            "GLACEON",
            "GLALIE",
            "GLAMEOW",
            "GLIGAR",
            "GLISCOR",
            "GLOOM",
            "GOGOAT",
            "GOLBAT",
            "GOLDEEN",
            "GOLDUCK",
            "GOLEM",
            "GOLETT",
            "GOLURK",
            "GOODRA",
            "GOOMY",
            "GOREBYSS",
            "GOTHITA",
            "GOTHITELLE",
            "GOTHORITA",
            "GOURGEIST",
            "GRANBULL",
            "GRAVELER",
            "GRENINJA",
            "GRIMER",
            "GROTLE",
            "GROUDON",
            "GROVYLE",
            "GROWLITHE",
            "GRUMPIG",
            "GULPIN",
            "GURDURR",
            "GYARADOS",
            "HAPPINY",
            "HARIYAMA",
            "HAUNTER",
            "HAWLUCHA",
            "HAXORUS",
            "HEATMOR",
            "HEATRAN",
            "HELIOLISK",
            "HELIOPTILE",
            "HERACROSS",
            "HERDIER",
            "HIPPOPOTAS",
            "HIPPOWDON",
            "HITMONCHAN",
            "HITMONLEE",
            "HITMONTOP",
            "HO-OH",
            "HONCHKROW",
            "HONEDGE",
            "HOOPA",
            "HOOTHOOT",
            "HOPPIP",
            "HORSEA",
            "HOUNDOOM",
            "HOUNDOUR",
            "HUNTAIL",
            "HYDREIGON",
            "HYPNO",
            "IGGLYBUFF",
            "ILLUMISE",
            "INFERNAPE",
            "INKAY",
            "IVYSAUR",
            "JELLICENT",
            "JIGGLYPUFF",
            "JIRACHI",
            "JOLTEON",
            "JOLTIK",
            "JUMPLUFF",
            "JYNX",
            "KABUTO",
            "KABUTOPS",
            "KADABRA",
            "KAKUNA",
            "KANGASKHAN",
            "KARRABLAST",
            "KECLEON",
            "KELDEO",
            "KINGDRA",
            "KINGLER",
            "KIRLIA",
            "KLANG",
            "KLEFKI",
            "KLINK",
            "KLINKLANG",
            "KOFFING",
            "KRABBY",
            "KRICKETOT",
            "KRICKETUNE",
            "KROKOROK",
            "KROOKODILE",
            "KYOGRE",
            "KYUREM",
            "LAIRON",
            "LAMPENT",
            "LANDORUS",
            "LANTURN",
            "LAPRAS",
            "LARVESTA",
            "LARVITAR",
            "LATIAS",
            "LATIOS",
            "LEAFEON",
            "LEAVANNY",
            "LEDIAN",
            "LEDYBA",
            "LICKILICKY",
            "LICKITUNG",
            "LIEPARD",
            "LILEEP",
            "LILLIGANT",
            "LILLIPUP",
            "LINOONE",
            "LITLEO",
            "LITWICK",
            "LOMBRE",
            "LOPUNNY",
            "LOTAD",
            "LOUDRED",
            "LUCARIO",
            "LUDICOLO",
            "LUGIA",
            "LUMINEON",
            "LUNATONE",
            "LUVDISC",
            "LUXIO",
            "LUXRAY",
            "MACHAMP",
            "MACHOKE",
            "MACHOP",
            "MAGBY",
            "MAGCARGO",
            "MAGIKARP",
            "MAGMAR",
            "MAGMORTAR",
            "MAGNEMITE",
            "MAGNETON",
            "MAGNEZONE",
            "MAKUHITA",
            "MALAMAR",
            "MAMOSWINE",
            "MANAPHY",
            "MANDIBUZZ",
            "MANECTRIC",
            "MANKEY",
            "MANTINE",
            "MANTYKE",
            "MARACTUS",
            "MAREANIE",
            "MAREEP",
            "MARILL",
            "MAROWAK",
            "MARSHTOMP",
            "MASQUERAIN",
            "MAWILE",
            "MEDICHAM",
            "MEDITITE",
            "MEGANIUM",
            "MELOETTA",
            "MEOWSTIC",
            "MEOWTH",
            "MESPRIT",
            "METAGROSS",
            "METANG",
            "METAPOD",
            "MEW",
            "MEWTWO",
            "MIENFOO",
            "MIENSHAO",
            "MIGHTYENA",
            "MILOTIC",
            "MILTANK",
            "MIME JR.",
            "MINCCINO",
            "MINUN",
            "MISDREAVUS",
            "MISMAGIUS",
            "MOLTRES",
            "MONFERNO",
            "MOTHIM",
            "MR. MIME",
            "MUDKIP",
            "MUK",
            "MUNCHLAX",
            "MUNNA",
            "MURKROW",
            "MUSHARNA",
            "NATU",
            "NIDOKING",
            "NIDOQUEEN",
            "NIDORAN♀",
            "NIDORAN♂",
            "NIDORINA",
            "NIDORINO",
            "NINCADA",
            "NINETALES",
            "NINJASK",
            "NOCTOWL",
            "NOIBAT",
            "NOIVERN",
            "NOSEPASS",
            "NUMEL",
            "NUZLEAF",
            "OCTILLERY",
            "ODDISH",
            "OMANYTE",
            "OMASTAR",
            "ONIX",
            "OSHAWOTT",
            "PACHIRISU",
            "PALKIA",
            "PALPITOAD",
            "PANCHAM",
            "PANGORO",
            "PANPOUR",
            "PANSAGE",
            "PANSEAR",
            "PARAS",
            "PARASECT",
            "PATRAT",
            "PAWNIARD",
            "PELIPPER",
            "PERSIAN",
            "PETILIL",
            "PHANPY",
            "PHANTUMP",
            "PHIONE",
            "PICHU",
            "PIDGEOT",
            "PIDGEOTTO",
            "PIDGEY",
            "PIDOVE",
            "PIGNITE",
            "PIKACHU",
            "PILOSWINE",
            "PINECO",
            "PINSIR",
            "PIPLUP",
            "PLUSLE",
            "POLITOED",
            "POLIWAG",
            "POLIWHIRL",
            "POLIWRATH",
            "PONYTA",
            "POOCHYENA",
            "PORYGON",
            "PORYGON-Z",
            "PORYGON2",
            "PRIMEAPE",
            "PRINPLUP",
            "PROBOPASS",
            "PSYDUCK",
            "PUMPKABOO",
            "PUPITAR",
            "PURRLOIN",
            "PURUGLY",
            "PYROAR",
            "QUAGSIRE",
            "QUILAVA",
            "QUILLADIN",
            "QWILFISH",
            "RAICHU",
            "RAIKOU",
            "RALTS",
            "RAMPARDOS",
            "RAPIDASH",
            "RATICATE",
            "RATTATA",
            "RAYQUAZA",
            "REGICE",
            "REGIGIGAS",
            "REGIROCK",
            "REGISTEEL",
            "RELICANTH",
            "REMORAID",
            "RESHIRAM",
            "REUNICLUS",
            "RHYDON",
            "RHYHORN",
            "RHYPERIOR",
            "RIOLU",
            "ROGGENROLA",
            "ROSELIA",
            "ROSERADE",
            "ROTOM",
            "RUFFLET",
            "SABLEYE",
            "SALAMENCE",
            "SAMUROTT",
            "SANDILE",
            "SANDSHREW",
            "SANDSLASH",
            "SAWK",
            "SAWSBUCK",
            "SCATTERBUG",
            "SCEPTILE",
            "SCIZOR",
            "SCOLIPEDE",
            "SCRAFTY",
            "SCRAGGY",
            "SCYTHER",
            "SEADRA",
            "SEAKING",
            "SEALEO",
            "SEEDOT",
            "SEEL",
            "SEISMITOAD",
            "SENTRET",
            "SERPERIOR",
            "SERVINE",
            "SEVIPER",
            "SEWADDLE",
            "SHARPEDO",
            "SHAYMIN",
            "SHEDINJA",
            "SHELGON",
            "SHELLDER",
            "SHELLOS",
            "SHELMET",
            "SHIELDON",
            "SHIFTRY",
            "SHINX",
            "SHROOMISH",
            "SHUCKLE",
            "SHUPPET",
            "SIGILYPH",
            "SILCOON",
            "SIMIPOUR",
            "SIMISAGE",
            "SIMISEAR",
            "SKARMORY",
            "SKIDDO",
            "SKIPLOOM",
            "SKITTY",
            "SKORUPI",
            "SKRELP",
            "SKUNTANK",
            "SLAKING",
            "SLAKOTH",
            "SLIGGOO",
            "SLOWBRO",
            "SLOWKING",
            "SLOWPOKE",
            "SLUGMA",
            "SLURPUFF",
            "SMEARGLE",
            "SMOOCHUM",
            "SNEASEL",
            "SNIVY",
            "SNORLAX",
            "SNORUNT",
            "SNOVER",
            "SNUBBULL",
            "SOLOSIS",
            "SOLROCK",
            "SPEAROW",
            "SPEWPA",
            "SPHEAL",
            "SPINARAK",
            "SPINDA",
            "SPIRITOMB",
            "SPOINK",
            "SPRITZEE",
            "SQUIRTLE",
            "STANTLER",
            "STARAPTOR",
            "STARAVIA",
            "STARLY",
            "STARMIE",
            "STARYU",
            "STEELIX",
            "STOUTLAND",
            "STUNFISK",
            "STUNKY",
            "SUDOWOODO",
            "SUICUNE",
            "SUNFLORA",
            "SUNKERN",
            "SURSKIT",
            "SWABLU",
            "SWADLOON",
            "SWALOT",
            "SWAMPERT",
            "SWANNA",
            "SWELLOW",
            "SWINUB",
            "SWIRLIX",
            "SWOOBAT",
            "SYLVEON",
            "TAILLOW",
            "TALONFLAME",
            "TANGELA",
            "TANGROWTH",
            "TAUROS",
            "TEDDIURSA",
            "TENTACOOL",
            "TENTACRUEL",
            "TEPIG",
            "TERRAKION",
            "THROH",
            "THUNDURUS",
            "TIMBURR",
            "TIRTOUGA",
            "TOGEKISS",
            "TOGEPI",
            "TOGETIC",
            "TORCHIC",
            "TORKOAL",
            "TORNADUS",
            "TORTERRA",
            "TOTODILE",
            "TOXICROAK",
            "TRANQUILL",
            "TRAPINCH",
            "TREECKO",
            "TREVENANT",
            "TROPIUS",
            "TRUBBISH",
            "TURTWIG",
            "TYMPOLE",
            "TYNAMO",
            "TYPHLOSION",
            "TYRANITAR",
            "TYRANTRUM",
            "TYROGUE",
            "TYRUNT",
            "UMBREON",
            "UNFEZANT",
            "UNOWN",
            "URSARING",
            "UXIE",
            "VANILLISH",
            "VANILLITE",
            "VANILLUXE",
            "VAPOREON",
            "VENIPEDE",
            "VENOMOTH",
            "VENONAT",
            "VENUSAUR",
            "VESPIQUEN",
            "VIBRAVA",
            "VICTINI",
            "VICTREEBEL",
            "VIGOROTH",
            "VILEPLUME",
            "VIRIZION",
            "VIVILLON",
            "VOLBEAT",
            "VOLCANION",
            "VOLCARONA",
            "VOLTORB",
            "VULLABY",
            "VULPIX",
            "WAILMER",
            "WAILORD",
            "WALREIN",
            "WARTORTLE",
            "WATCHOG",
            "WEAVILE",
            "WEEDLE",
            "WEEPINBELL",
            "WEEZING",
            "WHIMSICOTT",
            "WHIRLIPEDE",
            "WHISCASH",
            "WHISMUR",
            "WIGGLYTUFF",
            "WINGULL",
            "WOBBUFFET",
            "WOOBAT",
            "WOOPER",
            "WORMADAM",
            "WURMPLE",
            "WYNAUT",
            "XATU",
            "XERNEAS",
            "YAMASK",
            "YANMA",
            "YANMEGA",
            "YVELTAL",
            "ZANGOOSE",
            "ZAPDOS",
            "ZEBSTRIKA",
            "ZEKROM",
            "ZIGZAGOON",
            "ZOROARK",
            "ZORUA",
            "ZUBAT",
            "ZWEILOUS",
            "ZYGARDE"});
            this.pokemonBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.pokemonBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.pokemonBox.Location = new System.Drawing.Point(21, 32);
            this.pokemonBox.Name = "pokemonBox";
            this.pokemonBox.Size = new System.Drawing.Size(153, 20);
            this.pokemonBox.TabIndex = 1;
            this.pokemonBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.pokemonBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.pokemonBox_KeyDown);
            // 
            // battleButton
            // 
            this.battleButton.BackColor = System.Drawing.Color.White;
            this.battleButton.Location = new System.Drawing.Point(60, 59);
            this.battleButton.Name = "battleButton";
            this.battleButton.Size = new System.Drawing.Size(75, 23);
            this.battleButton.TabIndex = 2;
            this.battleButton.Text = "Battle";
            this.battleButton.UseVisualStyleBackColor = false;
            this.battleButton.Click += new System.EventHandler(this.Search_Click);
            // 
            // caughtLabel
            // 
            this.caughtLabel.BackColor = System.Drawing.Color.Transparent;
            this.caughtLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.caughtLabel.Location = new System.Drawing.Point(-3, 351);
            this.caughtLabel.Name = "caughtLabel";
            this.caughtLabel.Size = new System.Drawing.Size(201, 23);
            this.caughtLabel.TabIndex = 9;
            this.caughtLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.caughtLabel.Click += new System.EventHandler(this.caughtLabel_Click);
            // 
            // pokemonTeamBox
            // 
            this.pokemonTeamBox.BackColor = System.Drawing.Color.White;
            this.pokemonTeamBox.FormattingEnabled = true;
            this.pokemonTeamBox.Location = new System.Drawing.Point(218, 30);
            this.pokemonTeamBox.Name = "pokemonTeamBox";
            this.pokemonTeamBox.Size = new System.Drawing.Size(164, 82);
            this.pokemonTeamBox.TabIndex = 8;
            this.pokemonTeamBox.SelectedIndexChanged += new System.EventHandler(this.pokemonTeamBox_SelectedIndexChanged);
            // 
            // currentTeamLabel
            // 
            this.currentTeamLabel.AutoSize = true;
            this.currentTeamLabel.BackColor = System.Drawing.Color.Transparent;
            this.currentTeamLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentTeamLabel.Location = new System.Drawing.Point(257, 10);
            this.currentTeamLabel.Name = "currentTeamLabel";
            this.currentTeamLabel.Size = new System.Drawing.Size(87, 13);
            this.currentTeamLabel.TabIndex = 4;
            this.currentTeamLabel.Text = "Current Team:";
            this.currentTeamLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.currentTeamLabel.Click += new System.EventHandler(this.label6_Click);
            // 
            // addToTeamButton
            // 
            this.addToTeamButton.BackColor = System.Drawing.Color.White;
            this.addToTeamButton.Enabled = false;
            this.addToTeamButton.Location = new System.Drawing.Point(220, 119);
            this.addToTeamButton.Name = "addToTeamButton";
            this.addToTeamButton.Size = new System.Drawing.Size(161, 23);
            this.addToTeamButton.TabIndex = 10;
            this.addToTeamButton.Text = "Add To Team";
            this.addToTeamButton.UseVisualStyleBackColor = false;
            this.addToTeamButton.Click += new System.EventHandler(this.addTeamReleaseButton_Click);
            // 
            // pcLabel
            // 
            this.pcLabel.AutoSize = true;
            this.pcLabel.BackColor = System.Drawing.Color.Transparent;
            this.pcLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pcLabel.Location = new System.Drawing.Point(287, 208);
            this.pcLabel.Name = "pcLabel";
            this.pcLabel.Size = new System.Drawing.Size(27, 13);
            this.pcLabel.TabIndex = 4;
            this.pcLabel.Text = "PC:";
            this.pcLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.pcLabel.Click += new System.EventHandler(this.label7_Click);
            // 
            // pcBox
            // 
            this.pcBox.BackColor = System.Drawing.Color.White;
            this.pcBox.FormattingEnabled = true;
            this.pcBox.Location = new System.Drawing.Point(218, 228);
            this.pcBox.Name = "pcBox";
            this.pcBox.Size = new System.Drawing.Size(164, 277);
            this.pcBox.TabIndex = 9;
            this.pcBox.SelectedIndexChanged += new System.EventHandler(this.pcBox_SelectedIndexChanged);
            // 
            // addToPCButton
            // 
            this.addToPCButton.BackColor = System.Drawing.Color.White;
            this.addToPCButton.Enabled = false;
            this.addToPCButton.Location = new System.Drawing.Point(219, 178);
            this.addToPCButton.Name = "addToPCButton";
            this.addToPCButton.Size = new System.Drawing.Size(163, 23);
            this.addToPCButton.TabIndex = 12;
            this.addToPCButton.Text = "Add To PC";
            this.addToPCButton.UseVisualStyleBackColor = false;
            this.addToPCButton.Click += new System.EventHandler(this.addToPCButton_Click);
            // 
            // releaseButton
            // 
            this.releaseButton.BackColor = System.Drawing.Color.White;
            this.releaseButton.Enabled = false;
            this.releaseButton.Location = new System.Drawing.Point(220, 149);
            this.releaseButton.Name = "releaseButton";
            this.releaseButton.Size = new System.Drawing.Size(161, 22);
            this.releaseButton.TabIndex = 11;
            this.releaseButton.Text = "Release";
            this.releaseButton.UseVisualStyleBackColor = false;
            this.releaseButton.Click += new System.EventHandler(this.releaseButton_Click);
            // 
            // moneyLabel
            // 
            this.moneyLabel.BackColor = System.Drawing.Color.White;
            this.moneyLabel.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moneyLabel.Location = new System.Drawing.Point(473, 88);
            this.moneyLabel.Name = "moneyLabel";
            this.moneyLabel.Size = new System.Drawing.Size(158, 31);
            this.moneyLabel.TabIndex = 0;
            this.moneyLabel.Text = "0";
            this.moneyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // moneyBorder
            // 
            this.moneyBorder.BackColor = System.Drawing.Color.White;
            this.moneyBorder.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.moneyBorder.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moneyBorder.Location = new System.Drawing.Point(409, 59);
            this.moneyBorder.Name = "moneyBorder";
            this.moneyBorder.Size = new System.Drawing.Size(222, 65);
            this.moneyBorder.TabIndex = 16;
            this.moneyBorder.Text = "Money";
            this.moneyBorder.Click += new System.EventHandler(this.moneyBorder_Click);
            // 
            // shopLabel
            // 
            this.shopLabel.AutoSize = true;
            this.shopLabel.BackColor = System.Drawing.Color.Black;
            this.shopLabel.Font = new System.Drawing.Font("Agency FB", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shopLabel.ForeColor = System.Drawing.Color.White;
            this.shopLabel.Location = new System.Drawing.Point(402, 13);
            this.shopLabel.Name = "shopLabel";
            this.shopLabel.Size = new System.Drawing.Size(74, 39);
            this.shopLabel.TabIndex = 0;
            this.shopLabel.Text = "Shop:";
            this.shopLabel.Click += new System.EventHandler(this.label8_Click);
            // 
            // itemsBox
            // 
            this.itemsBox.BackColor = System.Drawing.Color.White;
            this.itemsBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemsBox.ForeColor = System.Drawing.Color.Black;
            this.itemsBox.Location = new System.Drawing.Point(637, 59);
            this.itemsBox.Name = "itemsBox";
            this.itemsBox.Size = new System.Drawing.Size(210, 468);
            this.itemsBox.TabIndex = 0;
            this.itemsBox.Text = "Items:";
            this.itemsBox.Click += new System.EventHandler(this.itemsBox_Click);
            // 
            // buyPBButton
            // 
            this.buyPBButton.BackColor = System.Drawing.Color.Black;
            this.buyPBButton.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buyPBButton.ForeColor = System.Drawing.Color.White;
            this.buyPBButton.Location = new System.Drawing.Point(658, 88);
            this.buyPBButton.Name = "buyPBButton";
            this.buyPBButton.Size = new System.Drawing.Size(181, 61);
            this.buyPBButton.TabIndex = 13;
            this.buyPBButton.Text = "POKÉBALL                    200";
            this.buyPBButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buyPBButton.UseVisualStyleBackColor = false;
            this.buyPBButton.Click += new System.EventHandler(this.buyPBButton_Click);
            this.buyPBButton.MouseLeave += new System.EventHandler(this.buyPBButton_MouseLeave);
            this.buyPBButton.MouseHover += new System.EventHandler(this.buyPBButton_MouseHover);
            // 
            // buyGBButton
            // 
            this.buyGBButton.BackColor = System.Drawing.Color.White;
            this.buyGBButton.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buyGBButton.ForeColor = System.Drawing.Color.Black;
            this.buyGBButton.Location = new System.Drawing.Point(658, 163);
            this.buyGBButton.Name = "buyGBButton";
            this.buyGBButton.Size = new System.Drawing.Size(181, 61);
            this.buyGBButton.TabIndex = 14;
            this.buyGBButton.Text = "GREAT BALL                 600";
            this.buyGBButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buyGBButton.UseVisualStyleBackColor = false;
            this.buyGBButton.Click += new System.EventHandler(this.buyGBButton_Click);
            this.buyGBButton.MouseLeave += new System.EventHandler(this.buyGBButton_MouseLeave);
            this.buyGBButton.MouseHover += new System.EventHandler(this.buyGBButton_MouseHover);
            // 
            // buyUBButton
            // 
            this.buyUBButton.BackColor = System.Drawing.Color.Black;
            this.buyUBButton.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buyUBButton.ForeColor = System.Drawing.Color.White;
            this.buyUBButton.Location = new System.Drawing.Point(658, 238);
            this.buyUBButton.Name = "buyUBButton";
            this.buyUBButton.Size = new System.Drawing.Size(181, 61);
            this.buyUBButton.TabIndex = 15;
            this.buyUBButton.Text = "ULTRA BALL                1200";
            this.buyUBButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buyUBButton.UseVisualStyleBackColor = false;
            this.buyUBButton.Click += new System.EventHandler(this.buyUBButton_Click);
            this.buyUBButton.MouseLeave += new System.EventHandler(this.buyUBButton_MouseLeave);
            this.buyUBButton.MouseHover += new System.EventHandler(this.buyUBButton_MouseHover);
            // 
            // buySBButton
            // 
            this.buySBButton.BackColor = System.Drawing.Color.White;
            this.buySBButton.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buySBButton.ForeColor = System.Drawing.Color.Black;
            this.buySBButton.Location = new System.Drawing.Point(658, 313);
            this.buySBButton.Name = "buySBButton";
            this.buySBButton.Size = new System.Drawing.Size(181, 61);
            this.buySBButton.TabIndex = 16;
            this.buySBButton.Text = "SAFARI BALL               1700";
            this.buySBButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buySBButton.UseVisualStyleBackColor = false;
            this.buySBButton.Click += new System.EventHandler(this.buySBButton_Click);
            this.buySBButton.MouseLeave += new System.EventHandler(this.buySBButton_MouseLeave);
            this.buySBButton.MouseHover += new System.EventHandler(this.buySBButton_MouseHover);
            // 
            // buyMBButton
            // 
            this.buyMBButton.BackColor = System.Drawing.Color.Black;
            this.buyMBButton.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buyMBButton.ForeColor = System.Drawing.Color.White;
            this.buyMBButton.Location = new System.Drawing.Point(658, 388);
            this.buyMBButton.Name = "buyMBButton";
            this.buyMBButton.Size = new System.Drawing.Size(181, 61);
            this.buyMBButton.TabIndex = 17;
            this.buyMBButton.Text = "MASTER BALL             3400";
            this.buyMBButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buyMBButton.UseVisualStyleBackColor = false;
            this.buyMBButton.Click += new System.EventHandler(this.buyMBButton_Click);
            this.buyMBButton.MouseLeave += new System.EventHandler(this.buyMBButton_MouseLeave);
            this.buyMBButton.MouseHover += new System.EventHandler(this.buyMBButton_MouseHover);
            // 
            // shopBG
            // 
            this.shopBG.BackColor = System.Drawing.Color.Black;
            this.shopBG.Location = new System.Drawing.Point(399, -2);
            this.shopBG.Name = "shopBG";
            this.shopBG.Size = new System.Drawing.Size(460, 539);
            this.shopBG.TabIndex = 32;
            // 
            // buyMegaStoneButton
            // 
            this.buyMegaStoneButton.BackColor = System.Drawing.Color.White;
            this.buyMegaStoneButton.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buyMegaStoneButton.ForeColor = System.Drawing.Color.Black;
            this.buyMegaStoneButton.Location = new System.Drawing.Point(658, 455);
            this.buyMegaStoneButton.Name = "buyMegaStoneButton";
            this.buyMegaStoneButton.Size = new System.Drawing.Size(181, 61);
            this.buyMegaStoneButton.TabIndex = 18;
            this.buyMegaStoneButton.Text = "MEGA STONE              10000";
            this.buyMegaStoneButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buyMegaStoneButton.UseVisualStyleBackColor = false;
            this.buyMegaStoneButton.Click += new System.EventHandler(this.buyMegaStoneButton_Click);
            this.buyMegaStoneButton.MouseLeave += new System.EventHandler(this.buyMegaStoneButton_MouseLeave);
            this.buyMegaStoneButton.MouseHover += new System.EventHandler(this.buyMegaStoneButton_MouseHover);
            // 
            // megaEvolveButton
            // 
            this.megaEvolveButton.BackColor = System.Drawing.Color.White;
            this.megaEvolveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.megaEvolveButton.Location = new System.Drawing.Point(409, 486);
            this.megaEvolveButton.Name = "megaEvolveButton";
            this.megaEvolveButton.Size = new System.Drawing.Size(222, 41);
            this.megaEvolveButton.TabIndex = 19;
            this.megaEvolveButton.Text = "MEGA EVOLVE";
            this.megaEvolveButton.UseVisualStyleBackColor = false;
            this.megaEvolveButton.Visible = false;
            this.megaEvolveButton.Click += new System.EventHandler(this.megaEvolveButton_Click);
            // 
            // deselectButton
            // 
            this.deselectButton.BackColor = System.Drawing.Color.White;
            this.deselectButton.Enabled = false;
            this.deselectButton.Location = new System.Drawing.Point(220, 511);
            this.deselectButton.Name = "deselectButton";
            this.deselectButton.Size = new System.Drawing.Size(162, 23);
            this.deselectButton.TabIndex = 35;
            this.deselectButton.Text = "DESELECT";
            this.deselectButton.UseVisualStyleBackColor = false;
            this.deselectButton.Click += new System.EventHandler(this.deselectButton_Click);
            // 
            // randomCurrentHPButton
            // 
            this.randomCurrentHPButton.Image = global::Gen_1PokemonCaptureSimulation.Properties.Resources.Random_Icon;
            this.randomCurrentHPButton.Location = new System.Drawing.Point(153, 297);
            this.randomCurrentHPButton.Name = "randomCurrentHPButton";
            this.randomCurrentHPButton.Size = new System.Drawing.Size(20, 20);
            this.randomCurrentHPButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.randomCurrentHPButton.TabIndex = 34;
            this.randomCurrentHPButton.TabStop = false;
            this.randomCurrentHPButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.randomCurrentHPButton_MouseDown);
            // 
            // randomMaxHPButton
            // 
            this.randomMaxHPButton.Image = global::Gen_1PokemonCaptureSimulation.Properties.Resources.Random_Icon;
            this.randomMaxHPButton.Location = new System.Drawing.Point(153, 250);
            this.randomMaxHPButton.Name = "randomMaxHPButton";
            this.randomMaxHPButton.Size = new System.Drawing.Size(20, 20);
            this.randomMaxHPButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.randomMaxHPButton.TabIndex = 34;
            this.randomMaxHPButton.TabStop = false;
            this.randomMaxHPButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.randomMaxHPButton_MouseDown);
            // 
            // randomStatusButton
            // 
            this.randomStatusButton.Image = global::Gen_1PokemonCaptureSimulation.Properties.Resources.Random_Icon;
            this.randomStatusButton.Location = new System.Drawing.Point(120, 156);
            this.randomStatusButton.Name = "randomStatusButton";
            this.randomStatusButton.Size = new System.Drawing.Size(20, 20);
            this.randomStatusButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.randomStatusButton.TabIndex = 34;
            this.randomStatusButton.TabStop = false;
            this.randomStatusButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.randomStatusButton_MouseDown);
            // 
            // randomPokemonButton
            // 
            this.randomPokemonButton.Image = global::Gen_1PokemonCaptureSimulation.Properties.Resources.Random_Icon;
            this.randomPokemonButton.Location = new System.Drawing.Point(180, 32);
            this.randomPokemonButton.Name = "randomPokemonButton";
            this.randomPokemonButton.Size = new System.Drawing.Size(20, 20);
            this.randomPokemonButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.randomPokemonButton.TabIndex = 34;
            this.randomPokemonButton.TabStop = false;
            this.randomPokemonButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.randomPokemonButton_MouseDown);
            // 
            // randomBallButton
            // 
            this.randomBallButton.Image = global::Gen_1PokemonCaptureSimulation.Properties.Resources.Random_Icon;
            this.randomBallButton.Location = new System.Drawing.Point(154, 109);
            this.randomBallButton.Name = "randomBallButton";
            this.randomBallButton.Size = new System.Drawing.Size(20, 20);
            this.randomBallButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.randomBallButton.TabIndex = 34;
            this.randomBallButton.TabStop = false;
            this.randomBallButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.randomBallButton_MouseDown);
            // 
            // pointer6
            // 
            this.pointer6.BackColor = System.Drawing.Color.White;
            this.pointer6.ErrorImage = global::Gen_1PokemonCaptureSimulation.Properties.Resources.pointer;
            this.pointer6.Image = global::Gen_1PokemonCaptureSimulation.Properties.Resources.pointer;
            this.pointer6.Location = new System.Drawing.Point(642, 455);
            this.pointer6.Name = "pointer6";
            this.pointer6.Size = new System.Drawing.Size(10, 61);
            this.pointer6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pointer6.TabIndex = 26;
            this.pointer6.TabStop = false;
            this.pointer6.Visible = false;
            // 
            // pointer5
            // 
            this.pointer5.BackColor = System.Drawing.Color.White;
            this.pointer5.ErrorImage = global::Gen_1PokemonCaptureSimulation.Properties.Resources.pointer;
            this.pointer5.Image = global::Gen_1PokemonCaptureSimulation.Properties.Resources.pointer;
            this.pointer5.Location = new System.Drawing.Point(642, 388);
            this.pointer5.Name = "pointer5";
            this.pointer5.Size = new System.Drawing.Size(10, 61);
            this.pointer5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pointer5.TabIndex = 26;
            this.pointer5.TabStop = false;
            this.pointer5.Visible = false;
            // 
            // pointer4
            // 
            this.pointer4.BackColor = System.Drawing.Color.White;
            this.pointer4.ErrorImage = global::Gen_1PokemonCaptureSimulation.Properties.Resources.pointer;
            this.pointer4.Image = global::Gen_1PokemonCaptureSimulation.Properties.Resources.pointer;
            this.pointer4.Location = new System.Drawing.Point(642, 313);
            this.pointer4.Name = "pointer4";
            this.pointer4.Size = new System.Drawing.Size(10, 61);
            this.pointer4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pointer4.TabIndex = 26;
            this.pointer4.TabStop = false;
            this.pointer4.Visible = false;
            // 
            // pointer3
            // 
            this.pointer3.BackColor = System.Drawing.Color.White;
            this.pointer3.ErrorImage = global::Gen_1PokemonCaptureSimulation.Properties.Resources.pointer;
            this.pointer3.Image = global::Gen_1PokemonCaptureSimulation.Properties.Resources.pointer;
            this.pointer3.Location = new System.Drawing.Point(642, 238);
            this.pointer3.Name = "pointer3";
            this.pointer3.Size = new System.Drawing.Size(10, 61);
            this.pointer3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pointer3.TabIndex = 26;
            this.pointer3.TabStop = false;
            this.pointer3.Visible = false;
            // 
            // pointer2
            // 
            this.pointer2.BackColor = System.Drawing.Color.White;
            this.pointer2.ErrorImage = global::Gen_1PokemonCaptureSimulation.Properties.Resources.pointer;
            this.pointer2.Image = global::Gen_1PokemonCaptureSimulation.Properties.Resources.pointer;
            this.pointer2.Location = new System.Drawing.Point(642, 163);
            this.pointer2.Name = "pointer2";
            this.pointer2.Size = new System.Drawing.Size(10, 61);
            this.pointer2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pointer2.TabIndex = 26;
            this.pointer2.TabStop = false;
            this.pointer2.Visible = false;
            // 
            // pointer1
            // 
            this.pointer1.BackColor = System.Drawing.Color.White;
            this.pointer1.ErrorImage = global::Gen_1PokemonCaptureSimulation.Properties.Resources.pointer;
            this.pointer1.Image = global::Gen_1PokemonCaptureSimulation.Properties.Resources.pointer;
            this.pointer1.Location = new System.Drawing.Point(642, 88);
            this.pointer1.Name = "pointer1";
            this.pointer1.Size = new System.Drawing.Size(10, 61);
            this.pointer1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pointer1.TabIndex = 26;
            this.pointer1.TabStop = false;
            this.pointer1.Visible = false;
            // 
            // pokemonDollarSign
            // 
            this.pokemonDollarSign.BackColor = System.Drawing.Color.White;
            this.pokemonDollarSign.Image = global::Gen_1PokemonCaptureSimulation.Properties.Resources.PokémonDollar_I;
            this.pokemonDollarSign.Location = new System.Drawing.Point(418, 88);
            this.pokemonDollarSign.Name = "pokemonDollarSign";
            this.pokemonDollarSign.Size = new System.Drawing.Size(15, 34);
            this.pokemonDollarSign.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pokemonDollarSign.TabIndex = 17;
            this.pokemonDollarSign.TabStop = false;
            // 
            // martLogo
            // 
            this.martLogo.BackColor = System.Drawing.Color.Black;
            this.martLogo.Image = global::Gen_1PokemonCaptureSimulation.Properties.Resources.PokeMart_Icon;
            this.martLogo.Location = new System.Drawing.Point(409, 122);
            this.martLogo.Name = "martLogo";
            this.martLogo.Size = new System.Drawing.Size(222, 358);
            this.martLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.martLogo.TabIndex = 15;
            this.martLogo.TabStop = false;
            // 
            // pokeBallBox
            // 
            this.pokeBallBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pokeBallBox.BackColor = System.Drawing.Color.Transparent;
            this.pokeBallBox.Location = new System.Drawing.Point(0, 372);
            this.pokeBallBox.Name = "pokeBallBox";
            this.pokeBallBox.Size = new System.Drawing.Size(212, 153);
            this.pokeBallBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pokeBallBox.TabIndex = 8;
            this.pokeBallBox.TabStop = false;
            this.pokeBallBox.Click += new System.EventHandler(this.pokeBallBox_Click);
            // 
            // resetButton
            // 
            this.resetButton.BackColor = System.Drawing.Color.Black;
            this.resetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetButton.ForeColor = System.Drawing.Color.White;
            this.resetButton.Location = new System.Drawing.Point(764, 10);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(83, 42);
            this.resetButton.TabIndex = 36;
            this.resetButton.Text = "RESET";
            this.resetButton.UseVisualStyleBackColor = false;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 544);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.pokemonBox);
            this.Controls.Add(this.deselectButton);
            this.Controls.Add(this.megaEvolveButton);
            this.Controls.Add(this.randomCurrentHPButton);
            this.Controls.Add(this.randomMaxHPButton);
            this.Controls.Add(this.randomStatusButton);
            this.Controls.Add(this.randomPokemonButton);
            this.Controls.Add(this.randomBallButton);
            this.Controls.Add(this.shopLabel);
            this.Controls.Add(this.pointer6);
            this.Controls.Add(this.pointer5);
            this.Controls.Add(this.pointer4);
            this.Controls.Add(this.pointer3);
            this.Controls.Add(this.pointer2);
            this.Controls.Add(this.pointer1);
            this.Controls.Add(this.buyMegaStoneButton);
            this.Controls.Add(this.buyMBButton);
            this.Controls.Add(this.buySBButton);
            this.Controls.Add(this.buyUBButton);
            this.Controls.Add(this.buyGBButton);
            this.Controls.Add(this.buyPBButton);
            this.Controls.Add(this.itemsBox);
            this.Controls.Add(this.moneyLabel);
            this.Controls.Add(this.pokemonDollarSign);
            this.Controls.Add(this.moneyBorder);
            this.Controls.Add(this.martLogo);
            this.Controls.Add(this.releaseButton);
            this.Controls.Add(this.addToPCButton);
            this.Controls.Add(this.addToTeamButton);
            this.Controls.Add(this.pcBox);
            this.Controls.Add(this.pokemonTeamBox);
            this.Controls.Add(this.pcLabel);
            this.Controls.Add(this.currentTeamLabel);
            this.Controls.Add(this.caughtLabel);
            this.Controls.Add(this.pokeBallBox);
            this.Controls.Add(this.battleButton);
            this.Controls.Add(this.throwBallButton);
            this.Controls.Add(this.pokStatusBox);
            this.Controls.Add(this.pokStatusLabel);
            this.Controls.Add(this.pokCurrentHPBox);
            this.Controls.Add(this.pokMaxHPBox);
            this.Controls.Add(this.catchRateBox);
            this.Controls.Add(this.ballChosenBox);
            this.Controls.Add(this.currentHPLabel);
            this.Controls.Add(this.pokMaxHPLabel);
            this.Controls.Add(this.catchRateLabel);
            this.Controls.Add(this.chooseBallLabel);
            this.Controls.Add(this.shopBG);
            this.Controls.Add(this.pokemonNameLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(875, 583);
            this.MinimumSize = new System.Drawing.Size(875, 583);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pokémon Capture Simulator";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.randomCurrentHPButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.randomMaxHPButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.randomStatusButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.randomPokemonButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.randomBallButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pointer6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pointer5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pointer4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pointer3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pointer2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pointer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pokemonDollarSign)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.martLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pokeBallBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label chooseBallLabel;
        private System.Windows.Forms.TextBox ballChosenBox;
        private System.Windows.Forms.Label pokStatusLabel;
        private System.Windows.Forms.TextBox pokStatusBox;
        private System.Windows.Forms.Label catchRateLabel;
        private System.Windows.Forms.TextBox catchRateBox;
        private System.Windows.Forms.Button throwBallButton;
        private System.Windows.Forms.Label pokMaxHPLabel;
        private System.Windows.Forms.TextBox pokMaxHPBox;
        private System.Windows.Forms.Label currentHPLabel;
        private System.Windows.Forms.TextBox pokCurrentHPBox;
        private System.Windows.Forms.Timer caughtTimer;
        private System.Windows.Forms.Timer freeTimer;
        private System.Windows.Forms.Label pokemonNameLabel;
        private System.Windows.Forms.TextBox pokemonBox;
        private System.Windows.Forms.Button battleButton;
        private System.Windows.Forms.PictureBox pokeBallBox;
        private System.Windows.Forms.Label caughtLabel;
        private System.Windows.Forms.ListBox pokemonTeamBox;
        private System.Windows.Forms.Label currentTeamLabel;
        private System.Windows.Forms.Button addToTeamButton;
        private System.Windows.Forms.Label pcLabel;
        private System.Windows.Forms.ListBox pcBox;
        private System.Windows.Forms.Button addToPCButton;
        private System.Windows.Forms.Button releaseButton;
        private System.Windows.Forms.Label moneyLabel;
        private System.Windows.Forms.PictureBox pokemonDollarSign;
        private System.Windows.Forms.Label moneyBorder;
        private System.Windows.Forms.PictureBox martLogo;
        private System.Windows.Forms.Label shopLabel;
        private System.Windows.Forms.Label itemsBox;
        private System.Windows.Forms.PictureBox pointer1;
        private System.Windows.Forms.Button buyPBButton;
        private System.Windows.Forms.Button buyGBButton;
        private System.Windows.Forms.PictureBox pointer2;
        private System.Windows.Forms.Button buyUBButton;
        private System.Windows.Forms.PictureBox pointer3;
        private System.Windows.Forms.Button buySBButton;
        private System.Windows.Forms.PictureBox pointer4;
        private System.Windows.Forms.Button buyMBButton;
        private System.Windows.Forms.PictureBox pointer5;
        private System.Windows.Forms.PictureBox randomBallButton;
        private System.Windows.Forms.PictureBox randomStatusButton;
        private System.Windows.Forms.PictureBox randomMaxHPButton;
        private System.Windows.Forms.PictureBox randomCurrentHPButton;
        private System.Windows.Forms.PictureBox randomPokemonButton;
        private System.Windows.Forms.Label shopBG;
        private System.Windows.Forms.Button buyMegaStoneButton;
        private System.Windows.Forms.PictureBox pointer6;
        private System.Windows.Forms.Button megaEvolveButton;
        private System.Windows.Forms.Button deselectButton;
        private System.Windows.Forms.Button resetButton;
    }
}

