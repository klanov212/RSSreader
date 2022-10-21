using LogicLayer;
using Models;
using System.Security.Permissions;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PresentationLayer
{
    public partial class Form1 : Form
    {
        MediaController mediaController;
        CategoryController categoryController;
        FrequencyController frequencyController;
        public Form1()
        {
            InitializeComponent();
            mediaController = new MediaController();
            categoryController = new CategoryController();
            frequencyController = new FrequencyController();
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

        private void PopulateViewFeed()
        {
            for (int i = 0; i < mediaController.RetrieveAllMedia().Count; i++)
            {
                Media media = mediaController.RetrieveAllMedia()[i];
                //lstViewFeed.Items.Add(media.NumberOfEpisodes, media.Name, media.Frequency, media.Category);
                String[] row1 = { media.Name, media.Frequency.ToString(), media.Category.ToString() };
                lstViewFeed.Items.Add(media.NumberOfEpisodes.ToString()).SubItems.AddRange(row1);
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

        private void btnNyFeed_Click(object sender, EventArgs e)
        {
            int i = comboBoxKategori.SelectedIndex;
            int j = comboBoxFrekvens.SelectedIndex;
            Category category = categoryController.RetrieveAllCategorys()[i];
            Frequency frequency = frequencyController.RetrieveAllFrequencys()[j];
            mediaController.CreateMedia(category, frequency, txtBoxURL.Text);
            PopulateViewFeed();
            txtBoxURL.Clear();
        }

        private void comboBoxFrekvens_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxFrekvens.SelectedItem.Equals("10 sek"))
            {
                //frequencyController.CreateFrequency
            }
        }
    }
}