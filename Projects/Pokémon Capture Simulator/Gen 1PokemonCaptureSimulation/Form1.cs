using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using System.Media;
using System.Collections.Generic;

namespace Gen_1PokemonCaptureSimulation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // file path for pokemon sprites
        private string filePath = Path.Combine(Directory.GetParent(Directory.GetParent(Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).FullName).FullName).FullName, "Resources", "Pokemon Sprites" + Path.DirectorySeparatorChar);
        
        //GLOBAL VARIABLES
        Random rnd = new Random();
        bool hintShown = false;
        int MegaStone, PB, GB, UB, SB, MB;
        float money, N, statVal, currentBallShakes;
        Bitmap normalBall, rightBall, leftBall, caughtBall;
        String[] balls = { "PokeBall", "Master Ball", "Great Ball", "Ultra Ball", "Safari Ball" };
        String[] megaNames = { "ABOMASNOW-MEGA", "ABSOL-MEGA", "AERODACTYL-MEGA", "AGGRON-MEGA", "ALAKAZAM-MEGA", "ALTARIA-MEGA", "AMPHAROS-MEGA", "AUDINO-MEGA", "BANETTE-MEGA", "BEEDRILL-MEGA", "BLASTOISE-MEGA", "BLAZIKEN-MEGA", "CAMERUPT-MEGA", "CHARIZARD-MEGA", "DIANCIE-MEGA", "GALLADE-MEGA", "GARCHOMP-MEGA", "GARDEVOIR-MEGA", "GENGAR-MEGA", "GLALIE-MEGA", "GYARADOS-MEGA", "HERACROSS-MEGA", "HOUNDOOM-MEGA", "KANGASKHAN-MEGA", "LATIAS-MEGA", "LATIOS-MEGA", "LOPUNNY-MEGA", "LUCARIO-MEGA", "MANECTRIC-MEGA", "MAWILE-MEGA", "MEDICHAM-MEGA", "METAGROSS-MEGA", "MEWTWO-MEGA", "PIDGEOT-MEGA", "PINSIR-MEGA", "RAYQUAZA-MEGA", "SABLEYE-MEGA", "SALAMENCE-MEGA", "SCEPTILE-MEGA", "SCIZOR-MEGA", "SHARPEDO-MEGA", "SLOWBRO-MEGA", "STEELIX-MEGA", "SWAMPERT-MEGA", "TYRANITAR-MEGA", "VENUSAUR-MEGA" };
        String[] megas = { "ABOMASNOW", "ABSOL", "AERODACTYL", "AGGRON", "ALAKAZAM", "ALTARIA", "AMPHAROS", "AUDINO", "BANETTE", "BEEDRILL", "BLASTOISE", "BLAZIKEN", "CAMERUPT", "CHARIZARD", "DIANCIE", "GALLADE", "GARCHOMP", "GARDEVOIR", "GENGAR", "GLALIE", "GYARADOS", "HERACROSS", "HOUNDOOM", "KANGASKHAN", "LATIAS", "LATIOS", "LOPUNNY", "LUCARIO", "MANECTRIC", "MAWILE", "MEDICHAM", "METAGROSS", "MEWTWO", "PIDGEOT", "PINSIR", "RAYQUAZA", "SABLEYE", "SALAMENCE", "SCEPTILE", "SCIZOR", "SHARPEDO", "SLOWBRO", "STEELIX", "SWAMPERT", "TYRANITAR", "VENUSAUR" };
        String[] pokemon = { "ABOMASNOW", "ABRA", "ABSOL", "ACCELGOR", "AEGISLASH", "AERODACTYL", "AGGRON", "AIPOM", "ALAKAZAM", "ALOMOMOLA", "ALTARIA", "AMAURA", "AMBIPOM", "AMOONGUSS", "AMPHAROS", "ANORITH", "ARAQUANID", "ARBOK", "ARCANINE", "ARCEUS", "ARCHEN", "ARCHEOPS", "ARIADOS", "ARMALDO", "AROMATISSE", "ARON", "ARTICUNO", "AUDINO", "AURORUS", "AVALUGG", "AXEW", "AZELF", "AZUMARILL", "AZURILL", "BAGON", "BALTOY", "BANETTE", "BARBARACLE", "BARBOACH", "BASCULIN", "BASTIODON", "BAYLEEF", "BEARTIC", "BEAUTIFLY", "BEEDRILL", "BEHEEYEM", "BELDUM", "BELLOSSOM", "BELLSPROUT", "BERGMITE", "BEWEAR", "BIBAREL", "BIDOOF", "BINACLE", "BISHARP", "BLASTOISE", "BLAZIKEN", "BLISSEY", "BLITZLE", "BOLDORE", "BONSLY", "BOUFFALANT", "BOUNSWEET", "BRAIXEN", "BRAVIARY", "BRELOOM", "BRIONNE", "BRONZONG", "BRONZOR", "BRUXISH", "BUDEW", "BUIZEL", "BULBASAUR", "BUNEARY", "BUNNELBY", "BURMY", "BUTTERFREE", "BUZZWOLE", "CACNEA", "CACTURNE", "CAMERUPT", "CARBINK", "CARNIVINE", "CARRACOSTA", "CARVANHA", "CASCOON", "CASTFORM", "CATERPIE", "CELEBI", "CELESTEELA", "CHANDELURE", "CHANSEY", "CHARIZARD", "CHARJABUG", "CHARMANDER", "CHARMELEON", "CHATOT", "CHERRIM", "CHERUBI", "CHESNAUGHT", "CHESPIN", "CHIKORITA", "CHIMCHAR", "CHIMECHO", "CHINCHOU", "CHINGLING", "CINCCINO", "CLAMPERL", "CLAUNCHER", "CLAWITZER", "CLAYDOL", "CLEFABLE", "CLEFAIRY", "CLEFFA", "CLOYSTER", "COBALION", "COFAGRIGUS", "COMBEE", "COMBUSKEN", "COMFEY", "CONKELDURR", "CORPHISH", "CORSOLA", "COSMOEM", "COSMOG", "COTTONEE", "CRABOMINABLE", "CRABRAWLER", "CRADILY", "CRANIDOS", "CRAWDAUNT", "CRESSELIA", "CROAGUNK", "CROBAT", "CROCONAW", "CRUSTLE", "CRYOGONAL", "CUBCHOO", "CUBONE", "CUTIEFLY", "CYNDAQUIL", "DARKRAI", "DARMANITAN", "DARTRIX", "DARUMAKA", "DECIDUEYE", "DEDENNE", "DEERLING", "DEINO", "DELCATTY", "DELIBIRD", "DELPHOX", "DEOXYS", "DEWGONG", "DEWOTT", "DEWPIDER", "DHELMISE", "DIALGA", "DIANCIE", "DIGGERSBY", "DIGLETT", "DIGLETT-ALOLA", "DITTO", "DODRIO", "DODUO", "DONPHAN", "DOUBLADE", "DRAGALGE", "DRAGONAIR", "DRAGONITE", "DRAMPA", "DRAPION", "DRATINI", "DRIFBLIM", "DRIFLOON", "DRILBUR", "DROWZEE", "DRUDDIGON", "DUCKLETT", "DUGTRIO", "DUGTRIO-ALOLA", "DUNSPARCE", "DUOSION", "DURANT", "DUSCLOPS", "DUSKNOIR", "DUSKULL", "DUSTOX", "DWEBBLE", "EELEKTRIK", "EELEKTROSS", "EEVEE", "EKANS", "ELECTABUZZ", "ELECTIVIRE", "ELECTRIKE", "ELECTRODE", "ELEKID", "ELGYEM", "EMBOAR", "EMOLGA", "EMPOLEON", "ENTEI", "ESCAVALIER", "ESPEON", "ESPURR", "EXCADRILL", "EXEGGCUTE", "EXEGGUTOR", "EXEGGUTOR-ALOLA", "EXPLOUD", "FARFETCH'D", "FEAROW", "FEEBAS", "FENNEKIN", "FERALIGATR", "FERROSEED", "FERROTHORN", "FINNEON", "FLAAFFY", "FLABÉBÉ", "FLAREON", "FLETCHINDER", "FLETCHLING", "FLOATZEL", "FLOETTE", "FLORGES", "FLYGON", "FOMANTIS", "FOONGUS", "FORRETRESS", "FRAXURE", "FRILLISH", "FROAKIE", "FROGADIER", "FROSLASS", "FURFROU", "FURRET", "GABITE", "GALLADE", "GALVANTULA", "GARBODOR", "GARCHOMP", "GARDEVOIR", "GASTLY", "GASTRODON", "GASTRODON-EAST", "GENESECT", "GENGAR", "GEODUDE", "GEODUDE-ALOLA", "GIBLE", "GIGALITH", "GIRAFARIG", "GIRATINA", "GLACEON", "GLALIE", "GLAMEOW", "GLIGAR", "GLISCOR", "GLOOM", "GOGOAT", "GOLBAT", "GOLDEEN", "GOLDUCK", "GOLEM", "GOLEM-ALOLA", "GOLETT", "GOLISOPOD", "GOLURK", "GOODRA", "GOOMY", "GOREBYSS", "GOTHITA", "GOTHITELLE", "GOTHORITA", "GOURGEIST", "GRANBULL", "GRAVELER", "GRAVELER-ALOLA", "GRENINJA", "GRIMER", "GRIMER-ALOLA", "GROTLE", "GROUDON", "GROVYLE", "GROWLITHE", "GRUBBIN", "GRUMPIG", "GULPIN", "GUMSHOOS", "GURDURR", "GUZZLORD", "GYARADOS", "HAKAMO-O", "HAPPINY", "HARIYAMA", "HAUNTER", "HAWLUCHA", "HAXORUS", "HEATMOR", "HEATRAN", "HELIOLISK", "HELIOPTILE", "HERACROSS", "HERDIER", "HIPPOPOTAS", "HIPPOWDON", "HITMONCHAN", "HITMONLEE", "HITMONTOP", "HO-OH", "HONCHKROW", "HONEDGE", "HOOPA", "HOOTHOOT", "HOPPIP", "HORSEA", "HOUNDOOM", "HOUNDOUR", "HUNTAIL", "HYDREIGON", "HYPNO", "IGGLYBUFF", "ILLUMISE", "INCINEROAR", "INFERNAPE", "INKAY", "IVYSAUR", "JANGMO-O", "JELLICENT", "JIGGLYPUFF", "JIRACHI", "JOLTEON", "JOLTIK", "JUMPLUFF", "JYNX", "KABUTO", "KABUTOPS", "KADABRA", "KAKUNA", "KANGASKHAN", "KARRABLAST", "KARTANA", "KECLEON", "KELDEO", "KINGDRA", "KINGLER", "KIRLIA", "KLANG", "KLEFKI", "KLINK", "KLINKLANG", "KOFFING", "KOMMO-O", "KRABBY", "KRICKETOT", "KRICKETUNE", "KROKOROK", "KROOKODILE", "KYOGRE", "KYUREM", "LAIRON", "LAMPENT", "LANDORUS", "LANTURN", "LAPRAS", "LARVESTA", "LARVITAR", "LATIAS", "LATIOS", "LEAFEON", "LEAVANNY", "LEDIAN", "LEDYBA", "LICKILICKY", "LICKITUNG", "LIEPARD", "LILEEP", "LILLIGANT", "LILLIPUP", "LINOONE", "LITLEO", "LITTEN", "LITWICK", "LOMBRE", "LOPUNNY", "LOTAD", "LOUDRED", "LUCARIO", "LUDICOLO", "LUGIA", "LUMINEON", "LUNALA", "LUNATONE", "LURANTIS", "LUVDISC", "LUXIO", "LUXRAY", "LYCANROC", "LYCANROC-MIDNIGHT", "MACHAMP", "MACHOKE", "MACHOP", "MAGBY", "MAGCARGO", "MAGEARNA", "MAGEARNA-POKEBALL", "MAGIKARP", "MAGMAR", "MAGMORTAR", "MAGNEMITE", "MAGNETON", "MAGNEZONE", "MAKUHITA", "MALAMAR", "MAMOSWINE", "MANAPHY", "MANDIBUZZ", "MANECTRIC", "MANKEY", "MANTINE", "MANTYKE", "MARACTUS", "MAREANIE", "MAREEP", "MARILL", "MAROWAK", "MAROWAK-ALOLA", "MARSHADOW", "MARSHTOMP", "MASQUERAIN", "MAWILE", "MEDICHAM", "MEDITITE", "MEGANIUM", "MELOETTA", "MEOWSTIC", "MEOWTH", "MEOWTH-ALOLA", "MESPRIT", "METAGROSS", "METANG", "METAPOD", "MEW", "MEWTWO", "MIENFOO", "MIENSHAO", "MIGHTYENA", "MILOTIC", "MILTANK", "MIME JR.", "MIMIKYU", "MINCCINO", "MINIOR", "MINUN", "MISDREAVUS", "MISMAGIUS", "MOLTRES", "MONFERNO", "MORELULL", "MOTHIM", "MR. MIME", "MUDBRAY", "MUDKIP", "MUDSDALE", "MUK", "MUK-ALOLA", "MUNCHLAX", "MUNNA", "MURKROW", "MUSHARNA", "NATU", "NECROZMA", "NIDOKING", "NIDOQUEEN", "NIDORANM", "NIDORANF", "NIDORINA", "NIDORINO", "NIHILEGO", "NINCADA", "NINETALES", "NINETALES-ALOLA", "NINJASK", "NOCTOWL", "NOIBAT", "NOIVERN", "NOSEPASS", "NUMEL", "NUZLEAF", "OCTILLERY", "ODDISH", "OMANYTE", "OMASTAR", "ONIX", "ORANGURU", "ORICORIO", "ORICORIO-PAU", "ORICORIO-POMPOM", "ORICORIO-SENSU", "OSHAWOTT", "PACHIRISU", "PALKIA", "PALOSSAND", "PALPITOAD", "PANCHAM", "PANGORO", "PANPOUR", "PANSAGE", "PANSEAR", "PARAS", "PARASECT", "PASSIMIAN", "PATRAT", "PAWNIARD", "PELIPPER", "PERSIAN", "PERSIAN-ALOLA", "PETILIL", "PHANPY", "PHANTUMP", "PHEROMOSA", "PHIONE", "PICHU", "PIDGEOT", "PIDGEOTTO", "PIDGEY", "PIDOVE", "PIGNITE", "PIKACHU", "PIKIPEK", "PILOSWINE", "PINECO", "PINSIR", "PIPLUP", "PLUSLE", "POLITOED", "POLIWAG", "POLIWHIRL", "POLIWRATH", "PONYTA", "POOCHYENA", "POPPLIO", "PORYGON", "PORYGON-Z", "PORYGON2", "PRIMARINA", "PRIMEAPE", "PRINPLUP", "PROBOPASS", "PSYDUCK", "PUMPKABOO", "PUPITAR", "PURRLOIN", "PURUGLY", "PYROAR", "PYUKUMUKU", "QUAGSIRE", "QUILAVA", "QUILLADIN", "QWILFISH", "RAICHU", "RAICHU-ALOLA", "RAIKOU", "RALTS", "RAMPARDOS", "RAPIDASH", "RATICATE", "RATICATE-ALOLA", "RATTATA", "RATTATA-ALOLA", "RAYQUAZA", "RAYQUAZA-MEGA", "REGICE", "REGIGIGAS", "REGIROCK", "REGISTEEL", "RELICANTH", "REMORAID", "RESHIRAM", "REUNICLUS", "RHYDON", "RHYHORN", "RHYPERIOR", "RIBOMBEE", "RIOLU", "ROCKRUFF", "ROGGENROLA", "ROSELIA", "ROSERADE", "ROTOM", "ROTOM-FAN", "ROTOM-FROST", "ROTOM-HEAT", "ROTOM-MOW", "ROTOM-WASH", "ROWLET", "RUFFLET", "SABLEYE", "SALAMENCE", "SALANDIT", "SALAZZLE", "SAMUROTT", "SANDILE", "SANDSHREW", "SANDSHREW-ALOLA", "SANDSLASH", "SANDSLASH-ALOLA", "SAWK", "SAWSBUCK", "SCATTERBUG", "SCEPTILE", "SCEPTILE-MEGA", "SCIZOR", "SCOLIPEDE", "SCRAFTY", "SCRAGGY", "SCYTHER", "SEADRA", "SEAKING", "SEALEO", "SEEDOT", "SEEL", "SEISMITOAD", "SENTRET", "SERPERIOR", "SERVINE", "SEVIPER", "SEWADDLE", "SHARPEDO", "SHAYMIN", "SHAYMIN-SKY", "SHEDINJA", "SHELGON", "SHELLDER", "SHELLOS", "SHELLOS-WEST", "SHELMET", "SHIELDON", "SHIFTRY", "SHIINOTIC", "SHINX", "SHROOMISH", "SHUCKLE", "SHUPPET", "SIGILYPH", "SILCOON", "SILVALLY", "SIMIPOUR", "SIMISAGE", "SIMISEAR", "SKARMORY", "SKIDDO", "SKIPLOOM", "SKITTY", "SKORUPI", "SKRELP", "SKUNTANK", "SLAKING", "SLAKOTH", "SLIGGOO", "SLOWBRO", "SLOWKING", "SLOWPOKE", "SLUGMA", "SLURPUFF", "SMEARGLE", "SMOOCHUM", "SNEASEL", "SNIVY", "SNORLAX", "SNORUNT", "SNOVER", "SNUBBULL", "SOLGALEO", "SOLOSIS", "SOLROCK", "SPEAROW", "SPEWPA", "SPHEAL", "SPINARAK", "SPINDA", "SPIRITOMB", "SPOINK", "SPRITZEE", "SQUIRTLE", "STANTLER", "STARAPTOR", "STARAVIA", "STARLY", "STARMIE", "STARYU", "STEELIX", "STEENEE", "STOUTLAND", "STUFFUL", "STUNFISK", "STUNKY", "SUDOWOODO", "SUICUNE", "SUNFLORA", "SUNKERN", "SURSKIT", "SWABLU", "SWADLOON", "SWALOT", "SWAMPERT", "SWANNA", "SWELLOW", "SWINUB", "SWIRLIX", "SWOOBAT", "SYLVEON", "TAILLOW", "TALONFLAME", "TANGELA", "TANGROWTH", "TAPU-BULU", "TAPU-FINI", "TAPU-KOKO", "TAPU-LELE", "TAUROS", "TEDDIURSA", "TENTACOOL", "TENTACRUEL", "TEPIG", "TERRAKION", "THROH", "THUNDURUS", "TIMBURR", "TIRTOUGA", "TOGEDEMARU", "TOGEKISS", "TOGEPI", "TOGETIC", "TORCHIC", "TORKOAL", "TORNADUS", "TORRACAT", "TORTERRA", "TOTODILE", "TOUCANNON", "TOXAPEX", "TOXICROAK", "TRANQUILL", "TRAPINCH", "TREECKO", "TREVENANT", "TROPIUS", "TRUBBISH", "TRUMBEAK", "TSAREENA", "TURTONATOR", "TURTWIG", "TYMPOLE", "TYNAMO", "TYPE-NULL", "TYPHLOSION", "TYRANITAR", "TYRANTRUM", "TYROGUE", "TYRUNT", "UMBREON", "UNFEZANT", "UNOWN", "URSARING", "UXIE", "VANILLISH", "VANILLITE", "VANILLUXE", "VAPOREON", "VENIPEDE", "VENOMOTH", "VENONAT", "VENUSAUR", "VESPIQUEN", "VIBRAVA", "VICTINI", "VICTREEBEL", "VIGOROTH", "VIKAVOLT", "VILEPLUME", "VIRIZION", "VIVILLON", "VOLBEAT", "VOLCANION", "VOLCARONA", "VOLTORB", "VULLABY", "VULPIX", "VULPIX-ALOLA", "WAILMER", "WAILORD", "WALREIN", "WARTORTLE", "WATCHOG", "WEAVILE", "WEEDLE", "WEEPINBELL", "WEEZING", "WHIMSICOTT", "WHIRLIPEDE", "WHISCASH", "WHISMUR", "WIGGLYTUFF", "WIMPOD", "WINGULL", "WISHIWASHI", "WISHIWASHI-SCHOOL", "WOBBUFFET", "WOOBAT", "WOOPER", "WORMADAM", "WURMPLE", "WYNAUT", "XATU", "XERNEAS", "XURKITREE", "YAMASK", "YANMA", "YANMEGA", "YUNGOOS", "YVELTAL", "ZANGOOSE", "ZAPDOS", "ZEBSTRIKA", "ZEKROM", "ZIGZAGOON", "ZOROARK", "ZORUA", "ZUBAT", "ZWEILOUS", "ZYGARDE", "ZYGARDE-10", "ZYGARDE-COMPLETE" };

        //SOUNDS
        SoundPlayer ballToss = new SoundPlayer(Properties.Resources.BALL_TOSS);
        SoundPlayer ballPoof = new SoundPlayer(Properties.Resources.BALL_POOF);
        SoundPlayer tink = new SoundPlayer(Properties.Resources.TINK);
        SoundPlayer denied = new SoundPlayer(Properties.Resources.DENIED);
        SoundPlayer caughtMon = new SoundPlayer(Properties.Resources.CAUGHT_MON);
        SoundPlayer purchase = new SoundPlayer(Properties.Resources.PURCHASE);
        SoundPlayer megaEvolve = new SoundPlayer(Properties.Resources.MEGA_EVOLVE);
        SoundPlayer withdrawDeposit = new SoundPlayer(Properties.Resources.WITHDRAW_DEPOSIT);
        SoundPlayer run = new SoundPlayer(Properties.Resources.RUN);

        //CATCH RATES
        String[] catchRate3 = { "MAGEARNA-POKEBALL", "ZYGARDE-10", "ZYGARDE-COMPLETE", "MARSHADOW", "MAGEARNA", "TAPU-FINI", "TAPU-BULU", "TAPU-LELE", "TAPU-KOKO", "SILVALLY", "TYPE-NULL", "ARCEUS", "ARTICUNO", "AZELF", "BELDUM", "COBALIO", "COBALION", "CRESSELIA", "DARKRAI", "DEOXYS", "DEOXYS-NORMAL", "DEOXYS-ATTACK", "DEOXYS-DEFENSE", "DEOXYS-SPEED", "DIALGA", "DIANCIE", "ENTEI", "GENESECT", "GIRATINA", "GIRATINA-ALTERED", "GIRATINA-ORIGIN", "GROUDON", "HEATRAN", "HO-OH", "HOOPA", "HOOPA-CONFINED", "HOOPA-UNBOUND", "JIRACHI", "KELDEO", "KYOGRE", "KYUREM", "LANDORUS", "LATIAS", "LATIOS", "LUGIA", "MANAPHY", "MELOETTA", "MELOETTA-ARIA", "MELOETTA-PIROUETTE", "MESPRIT", "METAGROSS", "METANG", "MEWTWO", "MOLTRES", "PALKIA", "RAIKOU", "REGICE", "REGIGIGAS", "REGIROCK", "REGISTEEL", "RESHIRAM", "SUICUNE", "TERRAKION", "THUNDURUS", "TORNADUS", "UXIE", "VICTINI", "VIRIZION", "VOLCANION", "ZAPDOS", "ZEKROM", "ZYGARDE" };
        String[] catchRate25 = { "DHELMISE", "BASCULIN", "BASCULIN-RED STRIPED FORM", "BASCULIN-BLUE STRIPED FORM", "CLEFABLE", "CRYOGONAL", "MANTINE", "MANTYKE", "RELICANTH", "SCIZOR", "SKARMORY", "SNORLAX", "STEELIX" };
        String[] catchRate30 = { "MINIOR", "PASSIMIAN", "ORANGURU", "ABSOL", "BLISSEY", "CHANSEY", "CHATOT", "EELEKTROSS", "ELECTIVIRE", "GLISCOR", "HONCHKROW", "KLINKLANG", "LICKILICKY", "MAGMORTAR", "MAGNEZONE", "MURKROW", "PHIONE", "PORYGON-Z", "RHYPERIOR", "TANGROWTH", "TOGEKISS", "YANMEGA" };
        String[] catchRate45 = { "EXEGGUTOR-ALOLA", "GOLEM-ALOLA", "NAGANADEL", "POIPOLE", "NIHILEGO", "BUZZWOLE", "PHEROMOSA", "XURKITREE", "CELESTEELA", "KARTANA", "GUZZLORD", "LUNALA", "SOLGALEO", "COSMOEM", "COSMOG", "KOMMO-O", "HAKAMO-O", "JANGMO-O", "MIMIKYU", "KOMALA", "GOLISOPOD", "TSAREENA", "SALAZZLE", "ORICORIO", "ORICORIO-POMPOM", "ORICORIO-PAU", "ORICORIO-SENSU", "VIKAVOLT", "TOUCANNON", "PRIMARINA", "BRIONNE", "POPPLIO", "INCINEROAR", "TORRACAT", "LITTEN", "DECIDUEYE", "DARTRIX", "ROWLET", "SOLGALEO", "AEGISLASH", "AERODACTYL", "AGGRON", "AIPOM", "ALTARIA", "AMAURA", "AMBIPOM", "AMPHAROS", "ANORITH", "ARCHEN", "ARCHEOPS", "ARMALDO", "AURORUS", "BAGON", "BANETTE", "BARBARACLE", "BASTIODON", "BAYLEEF", "BEAUTIFLY", "BEEDRILL", "BELLOSSOM", "BISHARP", "BLASTOISE", "BLAZIKEN", "BOUFFALANT", "BRAIXEN", "BULBASAUR", "BUTTERFREE", "CARRACOSTA", "CASTFORM", "CASTFORM-WATER", "CASTFORM-FIRE", "CASTFORM-ICE", "CASTFORM-NORMAL", "CELEBI", "CHANDELURE", "CHARIZARD", "CHARMANDER", "CHARMELEON", "CHESNAUGHT", "CHESPIN", "CHIKORITA", "CHIMCHAR", "CHIMECHO", "COMBUSKEN", "CONKELDURR", "CRADILY", "CRANIDOS", "CROCONAW", "CYNDAQUIL", "DEINO", "DELIBIRD", "DELPHOX", "DEWOTT", "DODRIO", "DRAGONAIR", "DRAGONITE", "DRAPION", "DRATINI", "DRUDDIGON", "DUSKNOIR", "DUSTOX", "EEVEE", "ELECTABUZZ", "ELEKID", "EMBOAR", "EMPOLEON", "ESPEON", "EXEGGUTOR", "EXPLOUD", "FARFETCH'D", "FARFETCHD", "FENNEKIN", "FERALIGATR", "FLAREON", "FLORGES", "FLYGON", "FROAKIE", "FROGADIER", "GABITE", "GALLADE", "GARCHOMP", "GARDEVOIR", "GENGAR", "GIBLE", "GIGALITH", "GLACEON", "GOGOAT", "GOLEM", "GOODRA", "GOOMY", "GRENINJA", "GROTLE", "GROVYLE", "GYARADOS", "HAXORUS", "HERACROSS", "HITMONCHAN", "HITMONLEE", "HITMONTOP", "HOUNDOOM", "HYDREIGON", "INFERNAPE", "IVYSAUR", "JOLTEON", "JUMPLUFF", "JYNX", "KABUTO", "KABUTOPS", "KANGASKHAN", "KINGDRA", "KRICKETUNE", "KROOKODILE", "LAPRAS", "LARVESTA", "LARVITAR", "LEAFEON", "LEAVANNY", "LICKITUNG", "LILEEP", "LUCARIO", "LUDICOLO", "LUNATONE", "LUXRAY", "MACHAMP", "MAGBY", "MAGMAR", "MANECTRIC", "MARSHTOMP", "MAWILE", "MEGANIUM", "MEW", "MIENSHAO", "MILTANK", "MISDREAVUS", "MISMAGIUS", "MISTERMIME", "MISTER MIME", "MONFERNO", "MOTHIM", "MR. MIME", "MR MIME", "MRMIME", "MUDKIP", "NIDOKING", "NIDOQUEEN", "NOIVERN", "OMANYTE", "OMASTAR", "ONIX", "OSHAWOTT", "PELIPPER", "PIDGEOT", "PIGNITE", "PINSIR", "PIPLUP", "POLITOED", "POLIWRATH", "PORYGON", "PRINPLUP", "PUPITAR", "QUILAVA", "QUILLADIN", "QWILFISH", "RAMPARDOS", "RAYQUAZA", "ROTOM", "ROTOM-HEAT", "ROTOM-WASH", "ROTOM-FROST", "ROTOM-FAN", "ROTOM-MOW", "SABLEYE", "SALAMENCE", "SAMUROTT", "SAWK", "SCEPTILE", "SCOLIPEDE", "SCYTHER", "SEISMITOAD", "SERPERIOR", "SERVINE", "SHAYMIN", "SHAYMIN-LAND", "SHAYMIN-SKY", "SHEDINJA", "SHELGON", "SHIELDON", "SHIFTRY", "SIGILYPH", "SLAKING", "SLIGGOO", "SMEARGLE", "SMOOCHUM", "SNIVY", "SOLROCK", "SQUIRTLE", "STANTLER", "STARAPTOR", "STOUTLAND", "SWAMPERT", "SWANNA", "SWELLOW", "SWOOBAT", "SYLVEON", "TALONFLAME", "TANGELA", "TAUROS", "TEPIG", "THROH", "TIRTOUGA", "TORCHIC", "TORTERRA", "TOTODILE", "TREECKO", "TURTWIG", "TYPHLOSION", "TYRANITAR", "TYRANTRUM", "TYRUNT", "UMBREON", "UNFEZANT", "UNFEZANT-MALE", "UNFEZANT-FEMALE", "VANILLUXE", "VAPOREON", "VENUSAUR", "VESPIQUEN", "VICTREEBEL", "VILEPLUME", "VIVILLON", "WALREIN", "WARTORTLE", "WEAVIL", "WEAVILE", "WOBBUFFET", "WORMADAM", "WORMADAM-PLANT", "WORMADAM-SANDY", "WORMADAM-TRASH", "XERNEAS", "YVELTAL", "ZOROARK", "ZWEILOUS" };
        String[] catchRate50 = { "DUGTRIO-ALOLA", "ALAKAZAM", "DUGTRIO", "GOTHITELLE", "MAMOSWINE", "MUNCHLAX", "REUNICLUS", "WIGGLYTUFF" };
        String[] catchRate55 = { "DRAGALGE", "CLAWITZER", "AVALUGG" };
        String[] catchRate60 = { "PYUKUMUKU", "PALOSSAND", "COMFEY", "MUDSDALE", "WISHIWASHI", "WISHIWASHI-SCHOOL", "CRABOMINABLE", "TENTACRUEL", "RAPIDASH", "MAGNETON", "CLOYSTER", "KINGLER", "ELECTRODE", "WEEZING", "RHYDON", "SEAKING", "STARMIE", "GIRAFARIG", "GLIGAR", "SNEASEL", "URSARING", "CORSOLA", "DONPHAN", "DELCATTY", "SHARPEDO", "WAILORD", "GRUMPIG", "CACTURNE", "MILOTIC", "HUNTAIL", "GOREBYSS", "DRIFBLIM", "LOPUNNY", "SKUNTANK", "HIPPOWDON", "ABOMASNOW", "PROBOPASS", "EXCADRILL", "DARMANITAN", "DARMANITAN-ZEN", "GARBODOR", "CINCCINO", "JELLICENT", "JELLICENT-MALE", "JELLICENT-FEMALE", "KLANG", "EELEKTRIK", "FRAXURE", "BEARTIC", "BRAVIARY", "MANDIBUZZ", "CARBINK", "TREVENANT", "GOURGEIST" };
        String[] catchRate65 = { "DRAMPA", "TURTONATOR", "BEWEAR", "PANGORO", "PYROAR", "SUDOWOODO" };
        String[] catchRate75 = { "NINETALES-ALOLA", "MAROWAK-ALOLA", "MUK-ALOLA", "RAICHU-ALOLA", "BRUXISH", "SHIINOTIC", "LURANTIS", "TOXAPEX", "RIBOMBEE", "ACCELGOR", "ALOMOMOLA", "AMOONGUSS", "ARCANINE", "AXEW", "AZUMARILL", "CHERRIM", "CRUSTLE", "DEWGONG", "ESCAVALIER", "FLOATZEL", "FORRETRESS", "FROSLASS", "GALVANTULA", "GASTRODON", "GASTRODON-WEST", "GASTRODON-EAST", "GLALIE", "GOLDUCK", "GRANBULL", "HELIOLISK", "HYPNO", "KLEFKI", "LANTURN", "LILLIGANT", "LUMINEON", "MAGCARGO", "MAROWAK", "MASQUERAIN", "MEOWSTIC", "MUK", "MUSHARNA", "NINETALES", "OCTILLERY", "PARASECT", "PILOSWINE", "PRIMEAPE", "PURUGLY", "RAICHU", "RIOL", "ROSERADE", "SAWSBUCK", "SEADRA", "SIMIPOUR", "SIMISAGE", "SIMISEAR", "SLOWBRO", "STUNFISK", "SWALOT", "TOGETIC", "TOXICROAK", "TYROGUE", "URIOLU", "VENOMOTH", "WHIMSICOTT", "WHISCASH", "XATU", "YANMA", "ZEBSTRIKA", "ZORUA" };
        String[] catchRate90 = { "PERSIAN-ALOLA", "SANDSLASH-ALOLA", "WIMPOD", "LYCANROC", "LYCANROC-MIDNIGHT", "ARBOK", "ARIADOS", "BEHEEYEM", "BRELOOM", "BRONZONG", "CLAYDOL", "COFAGRIGUS", "CROBAT", "DOUBLADE", "DURANT", "DUSCLOPS", "EXEGGCUTE", "FEAROW", "FERROTHORN", "FURRET", "GOLBAT", "GOLURK", "GURDURR", "HAUNTER", "HEATMOR", "KROKOROK", "LAIRON", "LAMPENT", "LEDIAN", "LIEPARD", "LINOONE", "MACHOKE", "MEDICHAM", "NOCTOWL", "PERSIAN", "QUAGSIRE", "SANDSLASH", "SCRAFTY", "SEVIPER", "TORKOAL", "ZANGOOSE" };
        String[] catchRate100 = { "ARAQUANID", "DUOSION", "GOTHORITA", "HAWLUCHA", "KADABRA", "SPIRITOMB" };
        String[] catchRate120 = { "GRAVELER-ALOLA", "STEENEE", "SALANDIT", "CHARJABUG", "TRUMBEAK", "BINACLE", "BOLDORE", "BURMY", "BURMY-PLANT", "BURMY-SANDY", "BURMY-TRASH", "CASCOON", "CHINGLING", "COMBEE", "CUBCHOO", "DARUMAKA", "DRILBUR", "ELECTRIKE", "FLAAFFY", "FLETCHINDER", "FLOETTE", "GLOOM", "GRAVELER", "HERDIER", "HOUNDOUR", "KAKUNA", "KIRLIA", "LOMBRE", "LOUDRED", "LUXIO", "METAPOD", "NIDORINA", "NIDORINO", "NINJASK", "NUZLEAF", "PALPITOAD", "PAWNIARD", "PHANPY", "PHANTUMP", "PIDGEOTTO", "POLIWHIRL", "PUMPKABOO", "RHYHORN", "SEALEO", "SILCOON", "SKIPLOOM", "SKORUPI", "SNOVER", "SPEWPA", "STARAVIA", "SUNFLORA", "SWADLOON", "TEDDIURSA", "TRANQUILL", "VANILLISH", "VIBRAVA", "VIGOROTH", "WEEPINBELL", "WHIRLIPEDE" };
        String[] catchRate125 = { "WAILMER", "WYNAUT", "DRIFLOON" };
        String[] catchRate127 = { "RATICATE-ALOLA", "GUMSHOOS", "BIBAREL", "DIGGERSBY", "MIGHTYENA", "RATICATE" };
        String[] catchRate130 = { "HAPPINY", "KLINK" };
        String[] catchRate140 = { "SANDYGAST", "STUFFUL", "CROAGUNK", "AROMATISSE", "SLURPUFF", "HIPPOPOTAS" };
        String[] catchRate150 = { "AZURILL", "CAMERUPT", "CLEFAIRY", "CLEFFA", "ILLUMISE", "ROSELIA", "VOLBEAT" };
        String[] catchRate170 = { "IGGLYBUFF", "JIGGLYPUFF" };
        String[] catchRate180 = { "TOGEDEMAR", "ARON", "DEDENNE", "HONEDGE", "MACHOP", "MAKUHITA", "MEDITITE", "MIENFOO", "SANDILE", "SCRAGGY", "TIMBURR" };
        String[] catchRate190 = { "MAREANIE", "VULPIX-ALOLA", "GRIMER-ALOLA", "MORELULL", "FOMANTIS", "MUDBRAY", "MARENIE", "ROCKRUFF", "CUTIEFLY", "BARBOACH", "BERGMITE", "BLITZLE", "BUIZEL", "BUNEARY", "CACNEA", "CHERUBI", "CHINCHOU", "COTTONEE", "CUBONE", "DEERLING", "DODUO", "DROWZEE", "DUCKLETT", "DUNSPARCE", "DUSKULL", "DWEBBLE", "ESPURR", "FINNEON", "FOONGUS", "FRILLISH", "FRILLISH-MALE", "FRILLISH-FEMALE", "GASTLY", "GLAMEOW", "GOLETT", "GRIMER", "GROWLITHE", "HELIOPTILE", "INKAY", "JOLTIK", "KOFFING", "LITWICK", "MAGNEMITE", "MANKEY", "MARILL", "MUNNA", "NATU", "NOIBAT", "PANPOUR", "PANSAGE", "PANSEAR", "PARAS", "PETILIL", "PICHU", "PIKACHU", "PINECO", "PONYTA", "PSYDUCK", "REMORAID", "RUFFLET", "SEEL", "SHELLDER", "SHELLOS", "SHELLOS-WEST SEA", "SHELLOS-EAST SEA", "SHUCKLE", "SLOWPOKE", "SLUGMA", "SNORUNT", "SNUBBULL", "TENTACOOL", "TOGEPI", "TRUBBISH", "TYNAMO", "VENONAT", "VOLTORB", "VULLABY", "VULPIX", "WHISMUR", "WINGULL", "WOOBAT", "YAMASK" };
        String[] catchRate200 = { "DEWPIDER", "ABRA", "CARNIVINE", "EMOLGA", "GOTHITA", "HARIYAMA", "KARRABLAST", "KECLEON", "MINUN", "PACHIRISU", "PLUSLE", "SHELMET", "SKIDDO", "SOLOSIS", "SPRITZEE", "SURSKIT", "SWIRLIX", "TAILLOW", "TROPIUS" };
        String[] catchRate220 = { "LITLEO", "PANCHAM" };
        String[] catchRate225 = { "CRABRAWLER", "CARVANHA", "CLAUNCHER", "FLABÉBÉ", "FLABEBE", "GOLDEEN", "GULPIN", "HORSEA", "KRABBY", "LUVDISC", "SHUPPET", "SKRELP", "STARYU", "STUNKY", "SWINUB", "UNOWN" };
        String[] catchRate235 = { "BOUNSWEET", "MAREEP", "NIDORANM", "NIDORANF", "RALTS", "SHINX", "SUNKERN" };
        String[] catchRate255 = { "GEODUDE-ALOLA", "DIGLETT-ALOLA", "MEOWTH-ALOLA", "SANDSHREW-ALOLA", "RATTATA-ALOLA", "NECROZMA", "GRUBBIN", "YUNGOOS", "PIKIPEK", "AUDINO", "BALTOY", "BELLSPROUT", "BIDOOF", "BONSLY", "BRONZOR", "BUDEW", "BUNNELBY", "CATERPIE", "CLAMPERL", "DIGLETT", "EKANS", "ELGYEM", "FEEBAS", "FERROSEED", "FLETCHLING", "GEODUDE", "HOOTHOOT", "HOPPIP", "KRICKETOT", "LEDYBA", "LILLIPUP", "LOTAD", "MAGIKARP", "MARACTUS", "MEOWTH", "MINCCINO", "NINCADA", "NOSEPASS", "NUMEL", "ODDISH", "PATRAT", "PIDGEY", "PIDOVE", "POLIWAG", "POOCHYENA", "PURRLOIN", "RATTATA", "ROGGENROLA", "SANDSHREW", "SCATTERBUG", "SEEDOT", "SENTRET", "SEWADDLE", "SHROOMISH", "SKITTY", "SLAKOTH", "SPEAROW", "SPHEAL", "SPINARAK", "SPINDA", "SPOINK", "STARLY", "SWABLU", "TRAPINCH", "TYMPOLE", "VANILLITE", "VENIPEDE", "WATCHOG", "WEEDLE", "WOOPER", "WURMPLE", "ZIGZAGOON", "ZUBAT" };



        private void throwBallButton_Click(object sender, EventArgs e)
        {
            if (pokemonBox.Text == "")
            {
                denied.Play();
                MessageBox.Show("Please enter an existing Pokémon into the textbox.", "Battle Error");
                return;
            }

            if (ballChosenBox.Text == "")
            {
                denied.Play();
                MessageBox.Show("Please enter the type of ball you are using to attempt to catch the Pokémon.");
                return;
            }

            if (pokMaxHPBox.Text == "" || float.Parse(pokMaxHPBox.Text) > 255)
            {
                denied.Play();
                MessageBox.Show("Please enter a valid maximum HP for the Pokémon.");
                return;
            }

            if (pokCurrentHPBox.Text == "" || float.Parse(pokCurrentHPBox.Text) > float.Parse(pokMaxHPBox.Text))
            {
                denied.Play();
                MessageBox.Show("Please enter a valid current HP for the Pokémon that does not exceed the maximum HP.");
                return;
            }


            // Use actual capture method to determine statVal
            if (pokStatusBox.Text.ToUpper() == "SLP" || pokStatusBox.Text.ToUpper() == "FRZ")
            {
                statVal = 25;
            }
            else if (pokStatusBox.Text.ToUpper() == "PAR" || pokStatusBox.Text.ToUpper() == "BRN" || pokStatusBox.Text.ToUpper() == "PSN")
            {
                statVal = 12;
            }
            else
            {
                statVal = 0;
            }

            if (ballChosenBox.Text.ToUpper().Contains("POK") && PB > 0)
            {
                PB--;
                N = rnd.Next(0, 255);
                normalBall = Properties.Resources.PokeBall_normal;
                rightBall = Properties.Resources.PokeBall_right;
                leftBall = Properties.Resources.PokeBall_left;
                caughtBall = Properties.Resources.PokeBall_caught;
            }
            else if (ballChosenBox.Text.ToUpper().Contains("GRE") && GB > 0)
            {
                GB--;
                N = rnd.Next(0, 200);
                currentBallShakes = 0;
                normalBall = Properties.Resources.Great_Ball_normal;
                rightBall = Properties.Resources.Great_Ball_right;
                leftBall = Properties.Resources.Great_Ball_left;
                caughtBall = Properties.Resources.Great_Ball_caught;
            }
            else if (ballChosenBox.Text.ToUpper().Contains("ULT") && UB > 0)
            {
                UB--;
                normalBall = Properties.Resources.Ultra_Ball_normal;
                rightBall = Properties.Resources.Ultra_Ball_right;
                leftBall = Properties.Resources.Ultra_Ball_left;
                caughtBall = Properties.Resources.Ultra_Ball_caught;
                N = rnd.Next(0, 150);
            }
            else if (ballChosenBox.Text.ToUpper().Contains("SAF") && SB > 0)
            {
                SB--;
                normalBall = Properties.Resources.Safari_Ball;
                rightBall = Properties.Resources.Safari_Ball_right;
                leftBall = Properties.Resources.Safari_Ball_left;
                caughtBall = Properties.Resources.Safari_Ball_caught;
                N = rnd.Next(0, 150);
            }
            else if (ballChosenBox.Text.ToUpper().Contains("MAS") && MB > 0)
            {
                MB--;
                caughtTimer.Start();
                currentBallShakes = 0;
                rightBall = Properties.Resources.Master_Ball_right;
                leftBall = Properties.Resources.Master_Ball_left;
                normalBall = Properties.Resources.Master_Ball_normal;
                caughtBall = Properties.Resources.Master_Ball_caught;
            }
            else
            {
                MessageBox.Show("You don't have enough of the chosen ball type.");
                return;
            }

            // Determine if the Pokémon will be caught
            if (N < (int)((3 * float.Parse(pokMaxHPBox.Text) - 2 * float.Parse(pokCurrentHPBox.Text)) * float.Parse(catchRateBox.Text) * statVal / (3 * float.Parse(pokMaxHPBox.Text))) && !ballChosenBox.Text.ToUpper().Contains("MAS"))
            {
                caughtTimer.Start();
            }
            else if (ballChosenBox.Text.ToUpper().Contains("MAS"))
            {
                caughtTimer.Start();
            }
            else
            {
                freeTimer.Start();
            }
            currentBallShakes = 0;

            // Disable UI elements
            battleButton.Enabled = false;
            randomPokemonButton.Enabled = false;
            disableControls(true);

            // Play sound
            ballToss.Play();
        }


        private void caughtTimer_Tick(object sender, EventArgs e)
        {
            int maxBallShakes = 400;
            int minMoneyToAdd = 200;
            int maxMoneyToAdd = 1001;
            
            currentBallShakes += 6;

            if (currentBallShakes >= maxBallShakes)
            {
                caughtTimer.Stop();
                
                int moneyToAdd = rnd.Next(minMoneyToAdd, maxMoneyToAdd);
                // multiplier for moneyToAdd with catch rate (higher catch rate = less money, lower catch rate = more money)
                moneyToAdd *= (int)(255 / float.Parse(catchRateBox.Text));

                // if the pokemon was caught with a master ball, reduce the money gained
                if (ballChosenBox.Text.ToUpper().Contains("MAS"))
                {
                    moneyToAdd /= 10;
                }

                money += moneyToAdd;
                moneyLabel.Text = money.ToString();
                moneyLabel.Text = money.ToString();

                caughtLabel.Text = pokemonBox.Text.ToUpper() + " Caught!";
                caughtMon.Play();
                pokeBallBox.Image = caughtBall;

                if (pokemonTeamBox.Items.Count < 6)
                {
                    pokemonTeamBox.Items.Add(pokemonBox.Text.ToUpper());
                }
                else
                {
                    pcBox.Items.Add(pokemonBox.Text.ToUpper());
                }

                ballChosenBox.Clear();
                pokStatusBox.Clear();
                catchRateBox.Clear();
                pokMaxHPBox.Clear();
                pokCurrentHPBox.Clear();
                pokemonBox.Clear();

                battleButton.Enabled = true;
                battleButton.Text = "Battle";
                randomPokemonButton.Enabled = true;
                pokemonBox.Enabled = true;
                pokemonTeamBox.Enabled = true;
                pcBox.Enabled = true;
            }
            else if (currentBallShakes < 50)
            {
                caughtLabel.Text = "Good aim!";
                pokeBallBox.Image = normalBall;

            }
            else if (currentBallShakes < 100)
            {
                caughtLabel.Text = "";
                pokeBallBox.Image = rightBall;
            }
            else if (currentBallShakes < 150 || (currentBallShakes >= 200 && currentBallShakes < 250) || (currentBallShakes >= 300 && currentBallShakes < 350))
            {
                pokeBallBox.Image = normalBall;
            }
            else if (currentBallShakes < 200)
            {
                pokeBallBox.Image = leftBall;
            }
            else if (currentBallShakes < 250)
            {
                caughtLabel.Text = "Almost there!";
                pokeBallBox.Image = normalBall;
            }
            else if (currentBallShakes < 300)
            {
                caughtLabel.Text = "";
                pokeBallBox.Image = rightBall;
            }
            else if (currentBallShakes < 350)
            {
                pokeBallBox.Image = normalBall;
            }

        }

        // Timer for when the pokemon breaks free
        private void freeTimer_Tick(object sender, EventArgs e)
        {
            //ball will shake 2 times, using normalBall, leftBall and rightBall
            const int maxBallShakes = 250;
            currentBallShakes += 6;

            if (currentBallShakes >= maxBallShakes)
            {
                ballPoof.Play();
                freeTimer.Stop();
                // convert to Title case
                caughtLabel.Text = pokemonBox.Text.ToUpper() + " Broke Free!";
                pokeBallBox.Image = Image.FromFile(filePath + pokemonBox.Text.ToLower() + ".gif");
                battleButton.Enabled = true;
                battleButton.Text = "Run";
                disableControls(false);
                pokemonTeamBox.Enabled = true;
                pcBox.Enabled = true;
            }
            else if (currentBallShakes < 50)
            {
                caughtLabel.Text = "Good aim!";
                pokeBallBox.Image = normalBall;
            }
            else if (currentBallShakes < 100)
            {
                pokeBallBox.Image = rightBall;
            }
            else if (currentBallShakes < 150)
            {
                pokeBallBox.Image = normalBall;
            }
            else if (currentBallShakes < 200)
            {
                pokeBallBox.Image = leftBall;
            }
            else if (currentBallShakes < 250)
            {
                caughtLabel.Text = "Almost there!";
                pokeBallBox.Image = normalBall;
            }

        }


        private void label1_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"PokeBall ({PB}), Great Ball ({GB}), Ultra Ball ({UB}), Safari Ball ({SB}), Master Ball ({MB}).", "Write either:");

            if (!hintShown)
            {
                MessageBox.Show("Master Balls catch Pokémon with no chance of failure!", "Master Ball Help");
                hintShown = true;
            }
        }


        private void label2_Click(object sender, EventArgs e) //Pokemon Status Label
        {
            MessageBox.Show("Asleep (SLP), Frozen (FRZ), Paralyzed (PAR), Burnt (BRN), Poisoned (PSN), Leave Blank If None", "Write either:");
        }

        private void label3_Click(object sender, EventArgs e) //Catch Rate Label
        {
            MessageBox.Show("A high catch rate makes the Pokémon easier to catch!", "Catch Rate Help");
        }

        private void label4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Number between (1-255)", "Write a:");
        }

        private void currentHPLabel_Click(object sender, EventArgs e)
        {
            string maxHP = pokMaxHPBox.Text;

            if (string.IsNullOrEmpty(maxHP))
            {
                MessageBox.Show("Number between (1-255)", "Write a:");
            }
            else
            {
                MessageBox.Show($"Number between (1-{maxHP})", "Write a:");
            }
        }

        //function that disables/enables the controls for the random buttons and the textboxes
        private void disableControls(bool disable)
        {
            if (disable)
            {
                randomBallButton.Enabled = false;
                randomStatusButton.Enabled = false;
                randomMaxHPButton.Enabled = false;
                randomCurrentHPButton.Enabled = false;
                ballChosenBox.Enabled = false;
                pokStatusBox.Enabled = false;
                pokMaxHPBox.Enabled = false;
                pokCurrentHPBox.Enabled = false;
                throwBallButton.Enabled = false;
            }
            else
            {
                randomBallButton.Enabled = true;
                randomStatusButton.Enabled = true;
                randomMaxHPButton.Enabled = true;
                randomCurrentHPButton.Enabled = true;
                ballChosenBox.Enabled = true;
                pokStatusBox.Enabled = true;
                pokMaxHPBox.Enabled = true;
                pokCurrentHPBox.Enabled = true;
                throwBallButton.Enabled = true;
            }
        }

        //function that plays the cry of the pokemon
        private void playCry(string pokemonName)
        {
            // remove any spaces from the name or periods
            pokemonName = pokemonName.Replace(" ", "").Replace(".", "");

            // play the cry
            SoundPlayer crySound = new SoundPlayer(Properties.Resources.ResourceManager.GetStream(pokemonName.ToLower()));
            crySound.Play();
        }


        // Function for the Battle Button
        private void Search_Click(object sender, EventArgs e)
        {
            caughtLabel.Text = "";
            throwBallButton.Enabled = true;

            string enteredPokemon = pokemonBox.Text.ToUpper();

            if (string.IsNullOrEmpty(enteredPokemon))
            {
                denied.Play();
                MessageBox.Show("Please enter a Pokémon into the textbox.", "Registry Error");
                
            }
            else if (!pokemon.Contains(enteredPokemon))
            {
                denied.Play();
                MessageBox.Show("Please enter an existing Pokémon into the textbox.", "Registry Error");
            }
            else if (battleButton.Text == "Battle")
            {
                ballChosenBox.Clear();
                pokStatusBox.Clear();
                pokMaxHPBox.Clear();
                pokCurrentHPBox.Clear();
                battleButton.Text = "Run";
                randomPokemonButton.Enabled = false;
                pokemonBox.Enabled = false;
                pokemonTeamBox.Enabled = false;
                pcBox.Enabled = false;
                disableControls(false);

                
                pokeBallBox.Image = Image.FromFile(filePath + enteredPokemon.ToLower() + ".gif");
                playCry(enteredPokemon);
                
                pokemonBox.Text = enteredPokemon;
                int catchRate;

                switch (enteredPokemon)
                {
                    case "VOLCARONA":
                        catchRate = 15;
                        break;
                    case "DITTO":
                        catchRate = 35;
                        break;
                    case "SLOWKING":
                        catchRate = 70;
                        break;
                    case "MALAMAR":
                        catchRate = 80;
                        break;
                    case "MIME JR.":
                        catchRate = 145;
                        break;
                    case "CRAWDAUNT":
                        catchRate = 155;
                        break;
                    case "FURFROU":
                        catchRate = 160;
                        break;
                    case "CORPHISH":
                        catchRate = 205;
                        break;
                    default:
                        if (catchRate3.Contains(enteredPokemon))
                            catchRate = 3;
                        else if (catchRate25.Contains(enteredPokemon))
                            catchRate = 25;
                        else if (catchRate30.Contains(enteredPokemon))
                            catchRate = 30;
                        else if (catchRate45.Contains(enteredPokemon))
                            catchRate = 45;
                        else if (catchRate50.Contains(enteredPokemon))
                            catchRate = 50;
                        else if (catchRate55.Contains(enteredPokemon))
                            catchRate = 55;
                        else if (catchRate60.Contains(enteredPokemon))
                            catchRate = 60;
                        else if (catchRate65.Contains(enteredPokemon))
                            catchRate = 65;
                        else if (catchRate75.Contains(enteredPokemon))
                            catchRate = 75;
                        else if (catchRate90.Contains(enteredPokemon))
                            catchRate = 90;
                        else if (catchRate100.Contains(enteredPokemon))
                            catchRate = 100;
                        else if (catchRate120.Contains(enteredPokemon))
                            catchRate = 120;
                        else if (catchRate125.Contains(enteredPokemon))
                            catchRate = 125;
                        else if (catchRate127.Contains(enteredPokemon))
                            catchRate = 127;
                        else if (catchRate130.Contains(enteredPokemon))
                            catchRate = 130;
                        else if (catchRate140.Contains(enteredPokemon))
                            catchRate = 140;
                        else if (catchRate150.Contains(enteredPokemon))
                            catchRate = 150;
                        else if (catchRate170.Contains(enteredPokemon))
                            catchRate = 170;
                        else if (catchRate180.Contains(enteredPokemon))
                            catchRate = 180;
                        else if (catchRate190.Contains(enteredPokemon))
                            catchRate = 190;
                        else if (catchRate200.Contains(enteredPokemon))
                            catchRate = 200;
                        else if (catchRate220.Contains(enteredPokemon))
                            catchRate = 220;
                        else if (catchRate225.Contains(enteredPokemon))
                            catchRate = 225;
                        else if (catchRate235.Contains(enteredPokemon))
                            catchRate = 235;
                        else
                            catchRate = 255; // Default catch rate if not found
                        break;
                }


                catchRateBox.Text = catchRate.ToString();

            }
            else if (battleButton.Text == "Run")
            {
                run.Play();
                caughtLabel.Text = "You ran from " + enteredPokemon + "!";
                ballChosenBox.Clear();
                pokStatusBox.Clear();
                pokMaxHPBox.Clear();
                pokCurrentHPBox.Clear();
                catchRateBox.Clear();
                battleButton.Text = "Battle";
                randomPokemonButton.Enabled = true;
                pokemonBox.Enabled = true;
                pokemonBox.Clear();
                pokemonTeamBox.Enabled = true;
                pcBox.Enabled = true;
                pokeBallBox.Image = null;
                disableControls(true);
            }
        }


        private void label5_Click(object sender, EventArgs e) //Pokemon Name Label
        {
            MessageBox.Show("Put Pokémon Name Here!", "Name Help");
            MessageBox.Show("Catch rate will automatically be fetched.", "Catch Rate Help");
        }

        private void addTeamReleaseButton_Click(object sender, EventArgs e)
        {
            if (pokemonTeamBox.Items.Count < 6)
            {
                string selectedItem = pcBox.SelectedItem?.ToString();
                if (!string.IsNullOrEmpty(selectedItem))
                {
                    pokemonTeamBox.Items.Add(selectedItem);
                    pcBox.Items.Remove(selectedItem);
                    pokeBallBox.Image = null;
                    withdrawDeposit.Play();
                }
            }
            else
            {
                MessageBox.Show("Not Enough Space In Party", "Capacity Error");
            }

            pokemonBox.Clear();
        }


        private void pokemonTeamBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            throwBallButton.Enabled = false;

            if (pokemonTeamBox.SelectedIndex != -1)
            {
                deselectButton.Enabled = true;
                //unselect the pokemon in the pc
                pcBox.SelectedIndex = -1;
                string selectedItem = pokemonTeamBox.SelectedItem.ToString();
                if (MegaStone > 0 && megas.Contains(selectedItem.ToUpper()))
                {
                    megaEvolveButton.Show();
                }

                if (pokemon.Contains(selectedItem) || megaNames.Contains(selectedItem.ToUpper()))
                {
                    pokeBallBox.Image = Image.FromFile(filePath + selectedItem.ToLower() + ".gif");
                    playCry(selectedItem);
                }
                else
                {
                    pokeBallBox.Image = null;
                }

                addToPCButton.Enabled = true;
                caughtLabel.Text = "";
            }
            else
            {
                pokeBallBox.Image = null;
                megaEvolveButton.Hide();
                battleButton.Enabled = true;
                addToPCButton.Enabled = false;
                caughtLabel.Text = "";
                pokemonNameLabel.Text = "Pokémon Name:";
            }

            addToTeamButton.Enabled = false;
            releaseButton.Enabled = false;
        }

        private void pcBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            addToPCButton.Enabled = false;

            if (pcBox.SelectedIndex != -1)
            {
                deselectButton.Enabled = true;
                //unselect the pokemon in the team
                pokemonTeamBox.SelectedIndex = -1;
                
                string selectedItem = pcBox.SelectedItem.ToString();
                if (pokemon.Contains(selectedItem) || megaNames.Contains(selectedItem.ToUpper()))
                {
                    pokeBallBox.Image = Image.FromFile(filePath + selectedItem + ".gif");
                    playCry(selectedItem);
                }
                else
                {
                    pokeBallBox.Image = null;
                }

                addToTeamButton.Enabled = true;
                releaseButton.Enabled = true;
                caughtLabel.Text = "";
            }
            else
            {
                releaseButton.Enabled = false;
                addToTeamButton.Enabled = false;
                pokeBallBox.Image = null;
            }
        }


        private void addToPCButton_Click(object sender, EventArgs e)
        {
            if (pokemonTeamBox.SelectedItem != null)
            {
                pcBox.Items.Add(pokemonTeamBox.SelectedItem.ToString());
                pokemonTeamBox.Items.Remove(pokemonTeamBox.SelectedItem);
                pokeBallBox.Image = null;
                pokemonBox.Clear();
                withdrawDeposit.Play();
            }
        }

        private void releaseButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to release this Pokémon?", "Release Pokémon", MessageBoxButtons.YesNo) != DialogResult.Yes)
            {
                return;
            }

            if (pcBox.SelectedItem != null)
            {
                string releasedPokemon = pcBox.SelectedItem.ToString();
                caughtLabel.Text = $"{releasedPokemon} was released!";
                pcBox.Items.Remove(releasedPokemon);
                pokeBallBox.Image = null;
                pokemonBox.Clear();
            }
        }



        private void label6_Click(object sender, EventArgs e) //Current Team Label
        {
            MessageBox.Show("Pokémon in your party to carry.", "Team Help");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MegaStone = 0; //default=0
            PB = 10; //default=10
            GB = 5; //default=5
            SB = 3; //default=3
            UB = 3; //default=3
            MB = 1; //default=1
            money = 500; //default=500
            moneyLabel.Text = money.ToString();
        }

        private void buyPBButton_Click(object sender, EventArgs e)
        {
            const int pokeBallCost = 200;

            if (money >= pokeBallCost)
            {
                purchase.Play();
                PB++;
                money -= pokeBallCost;
                moneyLabel.Text = money.ToString();
            }
        }


        private void buyPBButton_MouseHover(object sender, EventArgs e)
        {
            pointer1.Show();
            martLogo.Image = Properties.Resources.PokeBall_Display;
        }

        private void buyGBButton_MouseHover(object sender, EventArgs e)
        {
            pointer2.Show();
            martLogo.Image = Properties.Resources.Great_Ball_Display;
        }

        private void buyGBButton_MouseLeave(object sender, EventArgs e)
        {
            pointer2.Hide();
            martLogo.Image = Properties.Resources.PokeMart_Icon;
        }

        private void buyPBButton_MouseLeave(object sender, EventArgs e)
        {
            pointer1.Hide();
            martLogo.Image = Properties.Resources.PokeMart_Icon;
        }

        private void buyUBButton_MouseHover(object sender, EventArgs e)
        {
            pointer3.Show();
            martLogo.Image = Properties.Resources.Ultra_Ball_Display;
        }

        private void buyUBButton_MouseLeave(object sender, EventArgs e)
        {
            pointer3.Hide();
            martLogo.Image = Properties.Resources.PokeMart_Icon;
        }

        private void buySBButton_MouseHover(object sender, EventArgs e)
        {
            pointer4.Show();
            martLogo.Image = Properties.Resources.Safari_Ball_Display;
        }

        private void buySBButton_MouseLeave(object sender, EventArgs e)
        {
            pointer4.Hide();
            martLogo.Image = Properties.Resources.PokeMart_Icon;
        }

        private void buyMBButton_MouseHover(object sender, EventArgs e)
        {
            pointer5.Show();
            martLogo.Image = Properties.Resources.Master_Ball_Display;
        }

        private void buyMBButton_MouseLeave(object sender, EventArgs e)
        {
            pointer5.Hide();
            martLogo.Image = Properties.Resources.PokeMart_Icon;
        }
        private void label8_Click(object sender, EventArgs e)
        {
            string message = "Buy more balls if you run out, or buy a Mega Stone to Mega Evolve your Pokémon!" + Environment.NewLine;

            if (MegaStone > 0)
            {
                message += "You currently have " + MegaStone + " Mega Stone" + (MegaStone == 1 ? "." : "s.");
            }

            MessageBox.Show(message, "Shop Help");
        }


        private void moneyBorder_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You get money for every pokemon you catch.", "Money Help");
            MessageBox.Show("The lowest you can get is 200 Pokémon Dollars, and the highest is 1000!", "Limits");
        }

        private void itemsBox_Click(object sender, EventArgs e)
        {
            MessageBox.Show("All of the items available for purchase.", "Item Help");
        }

        private void label7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Pokémon in the Personal Computer that are not able to fit in the team.", "PC Help");
        }

        private void buyGBButton_Click(object sender, EventArgs e)
        {
            const int greatBallCost = 600;

            if (money >= greatBallCost)
            {
                purchase.Play();
                GB++;
                money -= greatBallCost;
                moneyLabel.Text = money.ToString();
            }
        }

        private void buyUBButton_Click(object sender, EventArgs e)
        {
            const int ultraBallCost = 1200;

            if (money >= ultraBallCost)
            {
                purchase.Play();
                UB++;
                money -= ultraBallCost;
                moneyLabel.Text = money.ToString();
            }
        }

        private void buySBButton_Click(object sender, EventArgs e)
        {
            const int safariBallCost = 1700;

            if (money >= safariBallCost)
            {
                purchase.Play();
                SB++;
                money -= safariBallCost;
                moneyLabel.Text = money.ToString();
            }
        }

        private void buyMBButton_Click(object sender, EventArgs e)
        {
            const int masterBallCost = 3400;

            if (money >= masterBallCost)
            {
                purchase.Play();
                MB++;
                money -= masterBallCost;
                moneyLabel.Text = money.ToString();
            }
        }

        private void buyMegaStoneButton_Click(object sender, EventArgs e)
        {
            const int megaStoneCost = 10000;

            if (money >= megaStoneCost)
            {
                purchase.Play();
                MegaStone++;
                money -= megaStoneCost;
                moneyLabel.Text = money.ToString();
            }
        }

        private void buyMegaStoneButton_MouseHover(object sender, EventArgs e)
        {
            pointer6.Show();
            martLogo.Image = Properties.Resources.Mega_Stone_Display;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            string saveData = $"{PB},{GB},{UB},{SB},{MB},{MegaStone},{money}";
            string teamData = "";
            string pcData = "";

            //save pokemon in team to another file
            foreach (string pokemon in pokemonTeamBox.Items)
            {
                teamData += pokemon + ",";
            }

            //save pokemon in pc to another file
            foreach (string pokemon in pcBox.Items)
            {
                pcData += pokemon + ",";
            }

            //save the data to a file, not using filePath since it's not a pokemon
            File.WriteAllText("saveData.txt", saveData);
            File.WriteAllText("teamData.txt", teamData);
            File.WriteAllText("pcData.txt", pcData);
            
            MessageBox.Show("Your game has been saved!", "Save");

        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            //load the data from the file
            string saveData = File.ReadAllText("saveData.txt");
            string teamData = File.ReadAllText("teamData.txt");
            string pcData = File.ReadAllText("pcData.txt");

            //split the data into an array
            string[] saveDataArray = saveData.Split(',');
            string[] teamDataArray = teamData.Split(',');
            string[] pcDataArray = pcData.Split(',');

            //set the variables to the data in the array
            PB = int.Parse(saveDataArray[0]);
            GB = int.Parse(saveDataArray[1]);
            UB = int.Parse(saveDataArray[2]);
            SB = int.Parse(saveDataArray[3]);
            MB = int.Parse(saveDataArray[4]);
            MegaStone = int.Parse(saveDataArray[5]);
            money = int.Parse(saveDataArray[6]);

            //set the textboxes to the data in the array
            moneyLabel.Text = money.ToString();

            //clear the listboxes and the picturebox
            pokemonTeamBox.Items.Clear();
            pcBox.Items.Clear();
            pokeBallBox.Image = null;

            //add the pokemon to the listboxes
            foreach (string pokemon in teamDataArray)
            {
                if (pokemon != "")
                {
                    pokemonTeamBox.Items.Add(pokemon);
                }
            }

            foreach (string pokemon in pcDataArray)
            {
                if (pokemon != "")
                {
                    pcBox.Items.Add(pokemon);
                }
            }

            MessageBox.Show("Your game has been loaded!", "Load");
        }


        private void moneyLabel_TextChanged(object sender, EventArgs e)
        {
            // add commas to the money label
            moneyLabel.Text = string.Format("{0:n0}", money);

            // if the money is less than 0, set it to 0, and if it's more than 9999999999, set it to 9999999999
            if (money < 0)
            {
                money = 0;
            }
            else if (money > 9999999999)
            {
                money = 9999999999;
            }
        }

        private void buyMegaStoneButton_MouseLeave(object sender, EventArgs e)
        {
            pointer6.Hide();
            martLogo.Image = Properties.Resources.PokeMart_Icon;
        }

        private void megaEvolveButton_Click(object sender, EventArgs e)
        {
            if (pokemonTeamBox.SelectedItem != null)
            {
                string selectedPokemon = pokemonTeamBox.SelectedItem.ToString();
                if (!selectedPokemon.Contains("-Mega"))
                {
                    MegaStone--;
                    string megaEvolvedPokemon = selectedPokemon + "-Mega";
                    pokemonTeamBox.Items.Add(megaEvolvedPokemon);
                    pokemonTeamBox.Items.Remove(selectedPokemon);

                    megaEvolve.Play();

                    // automatically select the mega evolved pokemon, after sound effect is done
                    System.Threading.Thread.Sleep(2811);
                    pokemonTeamBox.SelectedItem = megaEvolvedPokemon;

                }
            }
        }


        private void deselectButton_Click(object sender, EventArgs e)
        {
            pokemonTeamBox.SelectedIndex = -1;
            pcBox.SelectedIndex = -1;
        }

    private void pokemonBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Search_Click((object)sender, (EventArgs)e);
            }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            DialogResult resetConfirmation = MessageBox.Show("Are you sure you want to restart the application? All progress will be lost.", "Quit", MessageBoxButtons.YesNo);
            if (resetConfirmation == DialogResult.Yes)
            {
                Application.Restart();
            }
        }

        private void randomPokemonButton_MouseDown(object sender, MouseEventArgs e)
        {
            pokemonBox.Text = pokemon[rnd.Next(pokemon.Count())].ToString();

        }

        private void randomBallButton_MouseDown(object sender, MouseEventArgs e)
        {
            Dictionary<string, int> ballInventory = new Dictionary<string, int>
    {
        { "PokeBall", PB },
        { "Master Ball", MB },
        { "Great Ball", GB },
        { "Safari Ball", SB },
        { "Ultra Ball", UB }
    };

            string ballNo = balls[rnd.Next(0, 5)];

            if (ballInventory.TryGetValue(ballNo, out int count) && count > 0)
            {
                ballChosenBox.Text = ballNo;
            }
        }



        private void randomStatusButton_MouseDown(object sender, MouseEventArgs e)
        {
            string[] statusArray = { "PAR", "SLP", "BRN", "FRZ", "PSN", "" };

            int index = rnd.Next(statusArray.Length);
            pokStatusBox.Text = statusArray[index];
        }

        private void randomMaxHPButton_MouseDown(object sender, MouseEventArgs e)
        {
            pokMaxHPBox.Text = rnd.Next(1, 256).ToString();
        }

        private void randomCurrentHPButton_MouseDown(object sender, MouseEventArgs e)
        {
            int maxHP;
            if (int.TryParse(pokMaxHPBox.Text, out maxHP))
            {
                int currentHP = rnd.Next(1, maxHP + 1);
                pokCurrentHPBox.Text = currentHP.ToString();
            }
            else
            {
                pokCurrentHPBox.Text = rnd.Next(1, 256).ToString();
            }
        }

    }
}
