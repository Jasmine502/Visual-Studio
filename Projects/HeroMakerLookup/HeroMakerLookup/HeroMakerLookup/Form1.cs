using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace HeroMakerLookup
{
    public partial class Form1 : Form
    {
        private Dictionary<string, string> data; // Dictionary to store the item name and description

        public Form1()
        {
            InitializeComponent();
            InitializeData();
        }

        private void InitializeData()
        {
            // Initialize the data dictionary and populate it with the item name and description
            data = new Dictionary<string, string>
            {
                {"Fire Ball", @"
Glyph: Fire glyph (Ardour)
Use: Unlimited
Difficulty: Beginner
Variations:Messier the glyph, wilder the flame
Failure: Sizzles into ashes"},
                {"Water Sprout", @"
Glyph: Water glyph (Alter)
Use: Unlimited
Difficulty: Beginner
Variations: More waves on the glyph, stronger current
Failure: Nothing happens"},
                {"Light Point", @"
Glyph: Light glyph (Ardour)
Use: Unlimited
Difficulty: Beginner
Variations: Can be embedded on an item to make it glow
Failure: Nothing happens"},
                {"Rock Formation", @"
Glyph: Earth glyph (Aura)
Use: Unlimited
Difficulty: Easy
Variations: The higher the midline is on the glyph, the bigger the rock formation
Failure: Creates mud, dirt or sand"},
                {"Explosive Blast", @"
Glyph: Explosion glyph (Ardour)
Use: One shot
Difficulty: Easy
Failure: Can reverse and blast against the user"},
                {"Stone Wall", @"
Glyph: Wall glyph (Aura)
Use: Unlimited
Difficulty: Easy
Variations: The nicer the glyph, the smoother the wall
Failure: Wall is fragile"},
                {"Demon Blast", @"
Glyph: Demon glyph (Amoral) + Explosion glyph (Ardour)
Use: One shot
Difficulty: Easy
Variations: Unmixed can create a radius instead of a single pointed blast
Failure: Can reverse and blast against the user"},
                {"Fire Wall", @"
Glyph: Fire glyph (Ardour) + Wall glyph (Aura)
Use: Unlimited
Difficulty: Easy
Variations: Doesn't work unmixed
Failure: Can create an obsidian wall instead"},
                {"Primal Forces", @"
Description: The unique magic originated from the world. Long existing before the Gods, who were not creators of the world, simply visitors. It is said that the world is alive, and the primal forces are part of the world, as in its sentience."},
                {"Natural Glyphs", @"
Description: The sentient existence of Primal Forces. Appearing at certain times. They resemble things that are seen around the world but when looked closer, they have hidden patterns in them. It is said to be a long lost language. This is how a lot of magic came to be, using these glyphs."},
                {"Controlled magic", @"
Description: Uses glyphs to perform magic."},
                {"Wild magic", @"
Description: More of a mental glyph, where the glyph appears naturally."},
                {"Nights", @"
Description: Half demon, half human"},
                {"Stelings", @"
Description: Half god, half human"},
                {"Druids", @"
Description: Healers (Earth and Healing)"},
                {"Redbounds", @"
Description: Dimension Travellers (Demon and Rift)"},
                {"Glyph Weavers", @"
Description: A Night clan that specializes in studying Glyphs"},
                {"Spirits", @"
Description: Ghosts that live in the same plane as us but cannot be remembered."},
                {"Magical items", @"
Description: They stink, and the more they smell of magic, the stronger the item is."},
                {"The Giant Grove", @"
Description: A Forest around Hondenn that is very massive and somewhat dangerous for those who don't know it well."},
                {"The Expanse of Borena", @"
Description: The main Ocean of this world. Controlled by Pirates."},
                {"The Empire", @"
Description: Biggest and richest city in the world, houses the monarchy. Full of golden towers and luxuries."},
                {"Hondenn Village", @"
Description: MC's home."},
                {"The Demon Empire", @"
Description: Where Demons come from and where the Demon Lord and his Generals live."},
                {"Tadyr's Land", @"
Description: Some part in the South where the Glyph Weavers are settled. It's a dry land that cultivates delicious fruit, and a quiet forest that protects those who live in it. It's a bit of a wasteland. Tadyr was the dragon who once ruled that land."},
                {"Mildew", @"
Description: Looks like corn and it grows flowers, it's a type of vegetable that secretes extremely sticky honey. It's usually very sweet. Corn can be used to make extremely comfortable cloth."},
                {"Health Potions", @"
Description: Taste like peaches."},
                {"Painkiller Potions", @"
Description: Taste like Jackies."},
                {"Ter-na Seeds", @"
Description: Damp lavender seeds that function as medicine for stomach aches, throat aches, and headaches."},
                {"Water Era", @"
Description: Blue flowers of translucent leaves that live in the depths of the ocean. They are quite rare and are often found near treasure."},
            {"Pop-pie berries", @"
Description: Stick-like, thin, and square, usually bright yellow. They are crunchy if good and papery if not."},
            {"Shrodo", @"
Description: A pink flower with curled petals, usually used in salad and tastes like rich lettuce."},
            {"Ice Tooth", @"
Description: A Natural Glyph of the world that resembles a snowflake. Most common in storms, it disappears as soon as it touches the ground. If touched, it can cause a deadly sickness on the victim. There is a cure, of course."},
            {"Tatiana's Wings", @"
Description: A yellow flower with only two long petals. It signifies blessings and fortune."},
            {"Peppies", @"
Description: Pink and sometimes orange flowers. They have petals that stand upright. It signifies valor and courage."},
            {"Short-tails", @"
Description: Looks like wheat, they range from all colors of the rainbow, changing with the seasons. Summer is usually yellow."},
            {"Shrewds", @"
Description: Similar to Ginger, but very twirly, like a pretzel. They taste sour when uncooked. Functions very well for pain relievers."},
            {"Fehts", @"
Description: A fruit most common in the south. They are born from rocky terrain and flourish in the darkness. They look like figs but much flatter on one side. They have a grey hue that turns black when they are ripe. They taste juicy and contain water."},
            {"Horntooth Vines", @"
Description: These are vines that grow in dark places and have purple, bell-shaped flowers. The petals of these flowers are poisonous but can be used in small amounts for medicinal purposes. The vines themselves also have thorns that are equally poisonous."},
            {"Jackies", @"
Description: This is a type of mint plant, normally an icy blue, that grows only in the coldest parts of the world. It has a strong, minty flavor and can be used in teas and candies."},
            {"Soonbloom", @"
Description: These are flowers of round fluffy shapes that bloom only during the full moon. They are white and glow in the dark, and are said to have magical properties."},
            {"Spirit Roots", @"
Description: These are roots that grow from the branches of a Spirit tree. They have a ghostly, translucent appearance, with tangly rough textures. They are said to have the power to ward off evil spirits."},
            {"Liht", @"
Description: This is a root vegetable that grows deep in the ground and is said to have lightning coursing through its veins. It is spicy and can be used in many types of savory dishes."},
            {"Fairies", @"
Description: They are tricksters and malevolent most of the time. They lie and there are many. They glow and have sharp teeth. They can entice and control minds, forcing people to turn cannibalistic as they are too."},
            {"Droplets", @"
Description: Glowing orbs that are affected by emotions around them, they change colors and serve as warnings for prey."},
            {"Wyvern", @"
Description: A small dragon, looks like a lizard crocodile. They spit out blue fire that only harms those unpure of heart."},
            {"Gerulls", @"
Description: It has ram horns and goat lower legs, but it has bear body and front paws, its head is a mix of a bear and a goat. They are organized and extremely aggressive to others that could possess a threat."},
            {"Morrabirds", @"
Description: Pitch black birds that emit a strange, eerie song. They can only be seen in the shadows, and they can enter and leave them as they please. It is said that those who hear their song are doomed to suffer from nightmares."},
            {"Luminars", @"
Description: They are golems made of magic, they possess an otherworldly glow that can be seen from far away. They are peaceful and passive creatures, but they are fiercely protective of those that seem to be hurt."},
            {"Petalhoof(F) or Antherhoof(M)", @"
Description: A delicate and graceful deer with fur in shades of the flower they are born with. They are often found in meadows filled with flowers, and their antlers are adorned with flower buds that bloom in the spring."},
            {"Twigdancer", @"
Description: A tiny and curious insect resembling a twig but with wings that resemble leaves. They are often found flitting about in the forest, collecting bits of leaf and twig to build their nests. They also like dancing."}

        };

            queryListBox.DataSource = data.Keys.ToList(); // Set the initial data source to the list of item names
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            string searchText = searchTextBox.Text.ToLower(); // Get the search text in lowercase

            // Filter the data dictionary based on the search text
            var filteredData = data.Where(item => item.Key.ToLower().Contains(searchText))
                                   .ToDictionary(item => item.Key, item => item.Value);

            // Update the ListBox with the filtered results
            queryListBox.DataSource = filteredData.Keys.ToList();


        }
        private void queryListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Get the selected item from the ListBox
            string selectedItem = queryListBox.SelectedItem?.ToString();

            // Update the title of the window to reflect the selected item
            string windowTitle = string.IsNullOrEmpty(selectedItem) ? "HeroMaker Lookup" : $"HeroMaker Lookup - {selectedItem}";
            this.Text = windowTitle;

            if (!string.IsNullOrEmpty(selectedItem))
            {
                // Get the description for the selected item
                string description = data[selectedItem];

                // Clear previous DataGridView rows and columns
                resultsDataGridView.Rows.Clear();
                resultsDataGridView.Columns.Clear();

                // Add columns to the DataGridView
                resultsDataGridView.Columns.Add("Heading", "Heading");
                resultsDataGridView.Columns.Add("Value", "Value");

                // Split the description into individual lines
                string[] lines = description.Split('\n');

                // Add each line as a separate row in the DataGridView
                foreach (string line in lines)
                {
                    // Split each line into heading and value
                    string[] parts = line.Split(':');

                    if (parts.Length == 2)
                    {
                        // Add a row to the DataGridView with the heading and value
                        resultsDataGridView.Rows.Add(parts[0].Trim(), parts[1].Trim());
                    }
                }

                // Set the AutoSizeColumnsMode and AutoSizeRowsMode to Fill
                resultsDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                resultsDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

                // Enable text wrapping for the Value column
                resultsDataGridView.Columns["Value"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            }
        }
    }
}
