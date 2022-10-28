using LogicLayer;
using Models;
using System.Security.Permissions;
using System.Windows.Forms;
using System.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Octokit;

namespace PresentationLayer
{
    public partial class Form1 : Form
    {
        MediaController mediaController;
        CategoryController categoryController;
        Validation validation;
        //FrequencyController frequencyController;
        public Form1()
        {
            InitializeComponent();
            mediaController = new MediaController();
            categoryController = new CategoryController();
            validation = new Validation();
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
            Media media = mediaController.GetMediaById(lstViewFeed.FocusedItem.Index);
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
            int i = lstBoxAvsnitt.SelectedIndex;
            Task GetUrlData = media.GetUrlAsync(media.Url);
            await GetUrlData;
            {    
                    txtBoxBeskrivning.AppendText(media.ListOfEpisodes()[i].Description);
            }
        }
        //Lägger till ny kategori men ej dublett-värden
        private void btnNyKategori_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (Category category in categoryController.RetrieveAllCategorys())
                {
                    validation.CheckDuplicate(txtBoxKategori, category.Name);

                }

                categoryController.CreateCategory(txtBoxKategori.Text);
                PopulateCategoryListBox();
                PopulateComboBoxCategory();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        //Tar bort markerad kategori och tillhörande feeds
        private void btnTaBortKategori_Click(object sender, EventArgs e)
        {
           DialogResult dialog = MessageBox.Show("Du håller nu på att ta bort kategorin " + lstBoxKategori.SelectedItem +
                " och dess tillhörande feed", "", MessageBoxButtons.OKCancel);
            try
            {
                switch (dialog)
                {
                    case DialogResult.OK:
                        List<Media> medialist = mediaController.RetrieveAllMedia();
                        for (int i = 0; i < medialist.Count; i++)
                        {
                            Media? media = medialist[i];
                            if (media.Category.Name.Equals(lstBoxKategori.SelectedItem))
                            {
                                mediaController.DeleteMedia(i);
                            }
                        }
                        categoryController.DeleteCategory(lstBoxKategori.SelectedIndex);
                        PopulateViewFeed();
                        lstBoxAvsnitt.Items.Clear();
                        txtBoxBeskrivning.Clear();
                        PopulateCategoryListBox();
                        PopulateComboBoxCategory();
                        break;

                    case DialogResult.Cancel:
                        break;

                    default:
                        break;
                }
            }

            catch(Exception)
            {

            }
            
        }
        //Ändrar namn på markerad kategori och de feeds som har samma kategorinamn
        private void btnAndraKategori_Click(object sender, EventArgs e)
        {
            Category category;
            category = categoryController.UpdateCategory(lstBoxKategori.SelectedIndex, txtBoxKategori.Text);
            List<Media> medialist = mediaController.RetrieveAllMedia();
            for (int i = 0; i < medialist.Count; i++)
            {
                Media? media = medialist[i];
                if (media.Category.Name.Equals(lstBoxKategori.SelectedItem))
                {
                    
                    media = mediaController.UpdateMedia(i, media.Name, category, media.Frequency, media.Url);
                }
            }          
            PopulateViewFeed();
            PopulateCategoryListBox();
            PopulateComboBoxCategory();
            txtBoxKategori.Clear();
        }
        //Lägger till nya media-objekt i listView
        private async void btnNyFeed_Click(object sender, EventArgs e)
        {
            int index = comboBoxKategori.SelectedIndex;
            Category theCategory = categoryController.RetrieveAllCategorys()[index];
            Media media;
            if (comboBoxFrekvens.SelectedItem.Equals("10 sek"))
            {
                Frequency theFrequency = new _10sec();
                media = mediaController.CreateMedia(txtBoxNamn.Text ,theCategory, theFrequency, txtBoxURL.Text);
                Task GetUrlData = media.GetUrlAsync(txtBoxURL.Text);
                await GetUrlData;
            }
            else if (comboBoxFrekvens.SelectedItem.Equals("30 sek"))
            {
                Frequency theFrequency = new _30sec();
                media = mediaController.CreateMedia(txtBoxNamn.Text, theCategory, theFrequency, txtBoxURL.Text);
                Task GetUrlData = media.GetUrlAsync(txtBoxURL.Text);
                await GetUrlData;
            }
            else if (comboBoxFrekvens.SelectedItem.Equals("1 min"))
            {
                Frequency theFrequency = new _1min();
                media = mediaController.CreateMedia(txtBoxNamn.Text, theCategory, theFrequency, txtBoxURL.Text);
                Task GetUrlData = media.GetUrlAsync(txtBoxURL.Text);
                await GetUrlData;
            }
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
                mediaController.UpdateMedia(lstViewFeed.SelectedIndices[0], txtBoxNamn.Text, theCategory, theFrequency, txtBoxURL.Text);
            }
            else if (comboBoxFrekvens.SelectedItem.Equals("30 sek"))
            {
                _30sec theFrequency = new _30sec();
                mediaController.UpdateMedia(lstViewFeed.SelectedIndices[0], txtBoxNamn.Text, theCategory, theFrequency, txtBoxURL.Text);
            }
            else if (comboBoxFrekvens.SelectedItem.Equals("1 min"))
            {
                _1min theFrequency = new _1min();
                mediaController.UpdateMedia(lstViewFeed.SelectedIndices[0], txtBoxNamn.Text, theCategory, theFrequency, txtBoxURL.Text);
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
            DialogResult dialog = MessageBox.Show("Du håller nu på att ta bort " + lstViewFeed.SelectedItems, 
                "", MessageBoxButtons.OKCancel);

            switch(dialog)
            {
                case DialogResult.OK:
                mediaController.DeleteMedia(lstViewFeed.SelectedIndices[0]);
                PopulateViewFeed();
                lstBoxAvsnitt.Items.Clear();
                txtBoxBeskrivning.Clear();
                    break;

                case DialogResult.Cancel:
                    break;

                default: 
                    break;
            }
            
        }
        //Kallar på metoden som populerar avsnittslistan när man klickar på ett spesifikt feed i ViewFeed-listan
        private void lstViewFeed_SelectedIndexChanged(object sender, EventArgs e)
        {
            PopulatelstBoxAvsnitt();
        }
        //Kallar på metoden som populerar beskrivningsrutan när man klickar på ett specifikt avsnitt i avsnitslistan
        private void lstBoxAvsnitt_SelectedIndexChanged(object sender, EventArgs e)
        {
            PopulatetxtBoxBeskrivning();
        }

        //Sorterar feedet efter vald kategori
        private async void lstBoxKategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstViewFeed.Items.Clear();
            List<Media> medialist = mediaController.RetrieveAllMedia();
            foreach (var media in medialist)
            {
                if (media.Category.Name.Equals(lstBoxKategori.SelectedItem))
                {
                    Task GetUrlData = media.GetUrlAsync(media.Url);
                    await GetUrlData;
                    string[] row1 = { media.Name, media.Frequency.GetType().ToString().Substring(8), media.Category.Name };
                    lstViewFeed.Items.Add(media.NumberOfEpisodes.ToString()).SubItems.AddRange(row1);
                }               
            }           
        }
        private void btnAllaKategorier_Click(object sender, EventArgs e)
        {
            PopulateViewFeed();
        }
    }
}