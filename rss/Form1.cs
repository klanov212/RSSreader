using LogicLayer;
using Models;
using System.Security.Permissions;
using System.Windows.Forms;
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
            PopulateCategoryListBox();
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
        //Lägger till ny kategori
        private void btnNyKategori_Click(object sender, EventArgs e)
        {
            categoryController.CreateCategory(txtBoxKategori.Text);
            PopulateCategoryListBox();
            txtBoxKategori.Clear();
        }
        //Tar bort markerad kategori
        private void btnTaBortKategori_Click(object sender, EventArgs e)
        {
            categoryController.DeleteCategory(lstBoxKategori.SelectedIndex);
            PopulateCategoryListBox();
        }
        //Ändrar namn på markerad kategori
        private void btnAndraKategori_Click(object sender, EventArgs e)
        {
            categoryController.UpdateCategory(lstBoxKategori.SelectedIndex, txtBoxKategori.Text);
            PopulateCategoryListBox();
            txtBoxKategori.Clear();
        }

    }
}