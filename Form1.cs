using InventoryApplication.Models;
using InventoryApplication.Utilities;
using System.ComponentModel;
using System.Configuration;

namespace InventoryApplication
{
    public partial class Form1 : Form
    {
        CategoriesRepository _categoriesRepository;
        ProductsRepository _productsRepository;
        public Form1()
        {
            InitializeComponent();
            _categoriesRepository = new CategoriesRepository();
            _productsRepository = new ProductsRepository();

            SetCategories(_categoriesRepository.GetCategories());
            SetProducts(_productsRepository.GetProducts());

        }

        private void SetCategories(IEnumerable<ICategories> categories)
        {
            dataGridView1.AutoGenerateColumns = false;
            var bindingSource = new BindingSource();

            foreach (ICategories category in categories)
            {
                bindingSource.Add(category);
                categoryComboBox.Items.Add(bindingSource);
                categoryComboBox.Text = category.Name;
                
            }
            dataGridView1.DataSource = bindingSource;
            
            
        }

        private void SetProducts(IEnumerable<IProducts> products)
        {
            dataGridView2.AutoGenerateColumns = false;
            var bindingSource = new BindingSource();
            foreach(IProducts product in products)
            {
                bindingSource.Add(product);
            }
            dataGridView2.DataSource = bindingSource;
        }

        private void OnSelectedCategory(object sender, EventArgs e)
        {

        }

        private void OnProductSelected(object sender, EventArgs e)
        {

        }
    }
}
