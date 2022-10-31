using LogicLayer;
using Models;
using System.Security.Permissions;
using System.Windows.Forms;
using System.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.ServiceModel.Syndication;
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
        //Metod för att fylla kategori-comboboxen
        private void PopulateComboBoxCategory()
        {
            comboBoxKategori.Items.Clear();
            for (int i = 0; i < categoryController.RetrieveAllCategorys().Count; i++)
            {
                Category category = categoryController.RetrieveAllCategorys()[i];
                comboBoxKategori.Items.Add(category.Name);
            }
        }
        //Metod för att fylla Viewfeeden med alla media-objekt
        private void PopulateViewFeed()
        {
            try
            {
                lstViewFeed.Items.Clear();
                for (int i = 0; i < mediaController.RetrieveAllMedia().Count; i++)
                {
                    Media media = mediaController.RetrieveAllMedia()[i];
                    string[] row1 = { media.Name, media.Frequency.GetType().ToString().Substring(8), media.Category.Name };
                    lstViewFeed.Items.Add(media.NumberOfEpisodes.ToString()).SubItems.AddRange(row1);
                }
            }
            catch (FileNotFoundException) { }
            catch (DirectoryNotFoundException) { }
            catch (Exception) { }
        }
        //Metod för att fylla listboxen med varje episode-title
        private void PopulatelstBoxAvsnitt()
        {
            lstBoxAvsnitt.Items.Clear();
            Media media = mediaController.GetMediaById(lstViewFeed.FocusedItem.Index);
            
            {
                foreach (Episodes item in media.AllEpisodes)
                {
                    lstBoxAvsnitt.Items.Add(item.Title);
                    lblPodcastBeskrivning.Text = media.Name + ": "+ media.AllEpisodes.Count() +" avsnitt";
                }
            }
        }
        //Metod för att fylla listboxen med varje episode-description
        private void PopulatetxtBoxBeskrivning()
        {
            txtBoxBeskrivning.Clear();
            Media media = mediaController.GetMediaById(lstViewFeed.SelectedIndices[0]);
            int i = lstBoxAvsnitt.SelectedIndex;
            {
                txtBoxBeskrivning.AppendText(media.ListOfEpisodes()[i].Description);
                lblAvsinttsBeskrivning.Text = media.Name + ": " + media.ListOfEpisodes()[i].Title;
                
            }

        }
        //Lägger till ny kategori
        private void btnNyKategori_Click(object sender, EventArgs e)
        {
            try
            {
                validation.CheckEmpyField(txtBoxKategori);
                foreach (Category category in categoryController.RetrieveAllCategorys())
                {
                    validation.CheckDuplicate(txtBoxKategori, category.Name);

                }
                categoryController.CreateCategory(txtBoxKategori.Text);
                txtBoxKategori.Clear();
                PopulateCategoryListBox();
                PopulateComboBoxCategory();
            }
            catch(EmptyFieldException) { }
            catch(Exception) { }
        }
        //Tar bort markerad kategori och tillhörande feeds
        private void btnTaBortKategori_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Du håller nu på att ta bort kategorin " + lstBoxKategori.SelectedItem +
                " och dess tillhörande feeds", "", MessageBoxButtons.OKCancel);

            switch (dialog)
            {
                case DialogResult.OK:

                     List<Media> medialist = mediaController.RetrieveAllMedia();
                     for (int i = 0; i < medialist.Count; i++)
            {
                Media? media = medialist[i];
                if (media.Category.Equals(lstBoxKategori.SelectedItem))
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
        //Ändrar namn på markerad kategori och de feeds som har samma kategorinamn
        private void btnAndraKategori_Click(object sender, EventArgs e)
        {
            try
            {
                validation.CheckEmpyField(txtBoxKategori);
                Category category;
                category = categoryController.UpdateCategory(lstBoxKategori.SelectedIndex, txtBoxKategori.Text);
                List<Media> medialist = mediaController.RetrieveAllMedia();
                for (int i = 0; i < medialist.Count; i++)
                {
                    Media? media = medialist[i];
                    if (media.Category.Name.Equals(lstBoxKategori.SelectedItem))
                    {

                        mediaController.UpdateMedia(i, media.Name, category, media.Frequency, media.Url);
                    }
                }
                PopulateViewFeed();
                PopulateCategoryListBox();
                PopulateComboBoxCategory();
                txtBoxKategori.Clear();
            }
            catch (FileNotFoundException) { }
            catch (DirectoryNotFoundException) { }
            catch (Exception) { }
        }
        //Lägger till nya media-objekt i listView
        private void btnNyFeed_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (Media media in mediaController.RetrieveAllMedia())
                {
                    validation.CheckDuplicate(txtBoxURL, media.Url);

                }
                validation.CheckEmptyFields(txtBoxURL, comboBoxFrekvens, comboBoxKategori, txtBoxNamn);
                validation.CheckUrlFormat(txtBoxURL);

                int index = comboBoxKategori.SelectedIndex;
                Category theCategory = categoryController.RetrieveAllCategorys()[index];

                if (comboBoxFrekvens.SelectedItem.Equals("10 sek"))
                {
                    Frequency theFrequency = new _10sec();
                    mediaController.CreateMedia(txtBoxNamn.Text, theCategory, theFrequency, txtBoxURL.Text);

                }
                else if (comboBoxFrekvens.SelectedItem.Equals("30 sek"))
                {
                    Frequency theFrequency = new _30sec();
                    mediaController.CreateMedia(txtBoxNamn.Text, theCategory, theFrequency, txtBoxURL.Text);

                }
                else if (comboBoxFrekvens.SelectedItem.Equals("1 min"))
                {
                    Frequency theFrequency = new _1min();
                    mediaController.CreateMedia(txtBoxNamn.Text, theCategory, theFrequency, txtBoxURL.Text);

                }

                txtBoxURL.Clear();
                txtBoxNamn.Clear();
                comboBoxFrekvens.Text = "Uppspelningsfrekvens";
                comboBoxKategori.Text = "Välj kategori";
                PopulateViewFeed();
            }
            catch(EmptyFieldException)
            {
                
            }
            catch(FileNotFoundException) { }
            catch(DirectoryNotFoundException) { }
            catch(Exception) { }
        }

        //Ändrar media-objekt i listView
        private void btnAndraFeed_Click(object sender, EventArgs e)
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
            PopulateViewFeed();
            comboBoxFrekvens.Text = "Uppspelningsfrekvens";
            comboBoxKategori.Text = "Välj kategori";
            txtBoxURL.Clear();
            txtBoxNamn.Clear();
        }
        //Tar bort media-objekt från listView
        private void btnTaBortFeed_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialog = MessageBox.Show("Du håller nu på att ta bort ett feed", "", MessageBoxButtons.OKCancel);

                switch (dialog)
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
            catch (FileNotFoundException) { }
            catch (DirectoryNotFoundException) { }
            catch (Exception) { }

        }
        //Kallar på metoden som populerar avsnittslistan när man klickar på ett spesifikt feed i ViewFeed-listan
        private void lstViewFeed_SelectedIndexChanged(object sender, EventArgs e)
        {
            PopulatelstBoxAvsnitt();
            Media media = mediaController.GetMediaById(lstViewFeed.FocusedItem.Index);
            txtBoxURL.Text = media.Url;
        }
        //Kallar på metoden som populerar beskrivningsrutan när man klickar på ett specifikt avsnitt i avsnitslistan
        private void lstBoxAvsnitt_SelectedIndexChanged(object sender, EventArgs e)
        {
            PopulatetxtBoxBeskrivning();
        }

        //Sorterar feedet efter vald kategori
        private async void lstBoxKategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
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
            catch (FileNotFoundException) { }
            catch (DirectoryNotFoundException) { }
            catch (Exception) { }
        }
        private void btnAllaKategorier_Click(object sender, EventArgs e)
        {
            PopulateViewFeed();
        }
    }
}