using LogicLayer;
using Models;
using System.Security.Permissions;

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

        private void btnNyKategori_Click(object sender, EventArgs e)
        {
            Category categoryObj = null;
            categoryController.CreateCategory(txtBoxKategori.Text);

        }

        private void lstBoxKategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            categoryController.RetrieveAllCategorys();
        }
    }
}