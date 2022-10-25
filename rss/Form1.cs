using LogicLayer;
using Models;
using System.Security.Permissions;
using System.Windows.Forms;
using System.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PresentationLayer
{
    public partial class Form1 : Form
    {
        MediaController mediaController;
        CategoryController categoryController;
        //FrequencyController frequencyController;
        public Form1()
        {
            InitializeComponent();
            mediaController = new MediaController();
            categoryController = new CategoryController();
            //frequencyController = new FrequencyController();
        }
        //Fyller alla fällt i formen när man kör programmet
        private void Form1_Load(object sender, EventArgs e)
        {   
            PopulateCategoryListBox();
            PopulateComboBoxCategory();
            PopulateViewFeed();
        }
        //Metod för att fylla kategori-listboxen med kategorier från xml-filen
        private void PopulateCategoryListBox()
        {
            lstBoxKategori.Items.Clear();
            for (int i = 0; i < categoryController.RetrieveAllCategorys().Count; i++)
            {
                Category category = categoryController.RetrieveAllCategorys()[i];
                lstBoxKategori.Items.Add(category.Name);
            }
        }
        private void PopulateComboBoxCategory()
        {
            comboBoxKategori.Items.Clear();
            for (int i = 0; i < categoryController.RetrieveAllCategorys().Count; i++)
            {
                Category category = categoryController.RetrieveAllCategorys()[i];
                comboBoxKategori.Items.Add(category.Name);
            }
        }

        private async void PopulateViewFeed()
        {
            lstViewFeed.Items.Clear();
            for (int i = 0; i < mediaController.RetrieveAllMedia().Count; i++)
            {
                Media media = mediaController.RetrieveAllMedia()[i];
                Task GetUrlData = media.GetUrlAsync(media.Url);
                await GetUrlData;
                string[] row1 = { media.Name, media.Frequency.GetType().ToString().Substring(8), media.Category.Name };
                lstViewFeed.Items.Add(media.NumberOfEpisodes.ToString()).SubItems.AddRange(row1);
            }
        }
        private async void PopulatelstBoxAvsnitt()
        {
            lstBoxAvsnitt.Items.Clear();
            Media media = mediaController.GetMediaById(lstViewFeed.SelectedIndices[0]);
            Task GetUrlData = media.GetUrlAsync(media.Url);
            await GetUrlData;
            {
                foreach (var item in media.ListOfEpisodes())
                {
                    lstBoxAvsnitt.Items.Add(item.Title);
                }
            }
        }
        private async void PopulatetxtBoxBeskrivning()
        {
            txtBoxBeskrivning.Clear();
            Media media = mediaController.GetMediaById(lstViewFeed.SelectedIndices[0]);
            Task GetUrlData = media.GetUrlAsync(media.Url);
            await GetUrlData;
            {
                foreach(var item in media.ListOfEpisodes())
                {          
                    txtBoxBeskrivning.AppendText(item.Description);
                }            
            }
        }
        //Lägger till ny kategori
        private void btnNyKategori_Click(object sender, EventArgs e)
        {
            categoryController.CreateCategory(txtBoxKategori.Text);
            PopulateCategoryListBox();
            PopulateComboBoxCategory();
            txtBoxKategori.Clear();
        }
        //Tar bort markerad kategori
        private void btnTaBortKategori_Click(object sender, EventArgs e)
        {
            categoryController.DeleteCategory(lstBoxKategori.SelectedIndex);
            PopulateCategoryListBox();
            PopulateComboBoxCategory();
        }
        //Ändrar namn på markerad kategori
        private void btnAndraKategori_Click(object sender, EventArgs e)
        {
            categoryController.UpdateCategory(lstBoxKategori.SelectedIndex, txtBoxKategori.Text);
            PopulateCategoryListBox();
            PopulateComboBoxCategory();
            txtBoxKategori.Clear();
        }
        //Lägger till nya media-objekt i listView
        private async void btnNyFeed_Click(object sender, EventArgs e)
        {
            int index = comboBoxKategori.SelectedIndex;
            Category theCategory = categoryController.RetrieveAllCategorys()[index];
            if (comboBoxFrekvens.SelectedItem.Equals("10 sek"))
            {
                Frequency theFrequency = new _10sec();
                mediaController.CreateMedia(theCategory, theFrequency, txtBoxURL.Text);
                
            }
            else if (comboBoxFrekvens.SelectedItem.Equals("30 sek"))
            {
                Frequency theFrequency = new _30sec();
                mediaController.CreateMedia(theCategory, theFrequency, txtBoxURL.Text);
            }
            else if (comboBoxFrekvens.SelectedItem.Equals("1 min"))
            {
                Frequency theFrequency = new _1min();
                mediaController.CreateMedia(theCategory, theFrequency, txtBoxURL.Text);
            }
            Media media = new Media();
            Task GetUrlData = media.GetUrlAsync(txtBoxURL.Text);
            await GetUrlData;
            PopulateViewFeed();
            txtBoxURL.Clear();
        }
        //Ändrar media-objekt i listView
        private async void btnAndraFeed_Click(object sender, EventArgs e)
        {
            int index = comboBoxKategori.SelectedIndex;
            Category theCategory = categoryController.RetrieveAllCategorys()[index];

            if (comboBoxFrekvens.SelectedItem.Equals("10 sek"))
            {               
                _10sec theFrequency = new _10sec();
                mediaController.UpdateMedia(lstViewFeed.SelectedIndices[0], theCategory, theFrequency, txtBoxURL.Text);
            }
            else if (comboBoxFrekvens.SelectedItem.Equals("30 sek"))
            {
                _30sec theFrequency = new _30sec();
                mediaController.UpdateMedia(lstViewFeed.SelectedIndices[0], theCategory, theFrequency, txtBoxURL.Text);
            }
            else if (comboBoxFrekvens.SelectedItem.Equals("1 min"))
            {
                _1min theFrequency = new _1min();
                mediaController.UpdateMedia(lstViewFeed.SelectedIndices[0], theCategory, theFrequency, txtBoxURL.Text);
            }
            Media media = new Media();
            Task GetUrlData = media.GetUrlAsync(txtBoxURL.Text);
            await GetUrlData;
            PopulateViewFeed();
            txtBoxURL.Clear();
        }
        //Tar bort media-objekt från listView
        private void btnTaBortFeed_Click(object sender, EventArgs e)
        {
            mediaController.DeleteMedia(lstViewFeed.SelectedIndices[0]);
            PopulateViewFeed();
        }

        private void lstViewFeed_SelectedIndexChanged(object sender, EventArgs e)
        {
            PopulatelstBoxAvsnitt();
        }

        private void lstBoxAvsnitt_SelectedIndexChanged(object sender, EventArgs e)
        {
            PopulatetxtBoxBeskrivning();
        }
    }
}