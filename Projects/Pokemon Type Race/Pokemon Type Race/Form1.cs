using System;
using System.Windows.Forms;
using System.Media;
using System.Net.Http;
using Newtonsoft.Json.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Reflection.Emit;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Pokemon_Type_Race
{
    public partial class Form1 : Form
    {
        private readonly HttpClient httpClient = new HttpClient();
        private readonly SoundPlayer ding = new SoundPlayer(Properties.Resources.Ding);

        private int time = 60;
        private float wps;
        private float wordsWritten = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var pokemonNames = await GetPokemonNamesAsync();

            var rnd = new Random();
            var text = pokemonNames[rnd.Next(0, pokemonNames.Count)];
            label2.Text = text;

            textBox1.Focus();
            var start = DateTime.Now;

            while (time > 0)
            {
                textBox1.Focus();

                if (textBox1.Text.ToUpper() == text)
                {
                    textBox1.Text = "";
                    wordsWritten += text.Split(' ').Length;
                    label4.Text = wordsWritten.ToString();

                    var end = DateTime.Now;
                    var elapsed = end - start;
                    wps = wordsWritten / (float)elapsed.TotalSeconds;
                    label6.Text = wps.ToString("F2") + " WPS";

                    text = pokemonNames[rnd.Next(0, pokemonNames.Count)];
                    label2.Text = text;

                    ding.Play();
                }

                var remaining = TimeSpan.FromSeconds(time);
                label7.Text = remaining.ToString(@"ss\.ff");

                await Task.Delay(50);
                time--;
            }

            textBox1.Enabled = false;
            button1.Enabled = false;
        }

        private async Task<System.Collections.Generic.List<string>> GetPokemonNamesAsync()
        {
            var response = await httpClient.GetAsync("https://pokeapi.co/api/v2/pokemon?limit=10000");
            var json = await response.Content.ReadAsStringAsync();
            var result = JObject.Parse(json);
            var pokemonArray = JArray.Parse(result["results"].ToString());
            var pokemonNames = new System.Collections.Generic.List<string>();
            foreach (var item in pokemonArray)
            {
                pokemonNames.Add(item["name"].ToString().ToUpper());
            }
            return pokemonNames;
        }
    }
}
