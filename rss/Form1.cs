using LogicLayer;
using Models;
using System.Security.Permissions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PresentationLayer
{
    public partial class Form1 : Form
    {
        MediaController mediacontroller;
        CategoryController categoryController;
        public Form1()
        {
            InitializeComponent();
            mediacontroller = new MediaController();
            categoryController = new CategoryController();
        }
        //Fyller alla fällt i formen när man kör programmet
        private void Form1_Load(object sender, EventArgs e)
        {
            if (categoryController.RetrieveAllCategorys != null)
            {
                PopulateCategoryListBox();
                PopulateComboBoxCategory();
            }
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
        
        //Lägger till ny kategori
        private void btnNyKategori_Click(object sender, EventArgs e)
        {
            Category categoryObj = null;
            categoryController.CreateCategory(txtBoxKategori.Text);
            PopulateListBox();
        }

        private void lstBoxKategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            categoryController.RetrieveAllCategorys();
        }
        

        private void PopulateListBox()
        {
            lstBoxKategori.Items.Clear();
            List<Category> list = categoryController.RetrieveAllCategorys();
            for (int i = 0; i < list.Count; i++)
            {
                Category category = list[i];
                lstBoxKategori.Items.Add(category.Name);
            }
        }

    }
}