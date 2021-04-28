using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChuckNorrisAPI;

namespace ChuckNorrisForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public async Task populateCategories()
        {
            IEnumerable<string> categories = await ChuckNorrisClient.GetCategories();
            foreach (var list in categories)
            {
                categoriesTxt.Items.Add(Convert.ToString(categories));
            }
        }

        private async void Form1_Load(object sender, EventArgs e)
        {

            Joke joke = new Joke();

            await populateCategories();

            joke.Categories = (IEnumerable<string>)categoriesTxt.SelectedItem;
        }

        private async void generateJokeCmd_Click(object sender, EventArgs e)
        {
            Joke joke = await ChuckNorrisClient.GetRandomJoke();

            jokeIdTxt.Text = joke.Id.ToString();
            jokeDescriptionTxt.Text = joke.JokeText;
        }
    }
}
