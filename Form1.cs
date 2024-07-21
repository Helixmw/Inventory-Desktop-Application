using InventoryApplication.Exceptions;
using InventoryApplication.Models;
using InventoryApplication.Utilities;
using InventoryApplication.Utilities.Validation;
using System.Collections;
using System.ComponentModel;
using System.Configuration;
using System.Data;

namespace InventoryApplication
{
    public partial class Form1 : Form
    {
        CategoriesRepository _categoriesRepository;
        ProductsRepository _productsRepository;
        List<ICategories> _categories = new();
        List<Products> _products = new();
        public Form1()
        {
            InitializeComponent();
            _categoriesRepository = new CategoriesRepository();
            _productsRepository = new ProductsRepository();
            var categories = _categoriesRepository.GetCategories();
            foreach (var category in categories)
            {
                _categories.Add(category);
            }
            SetCategories(_categories);
            SetProducts(_productsRepository.GetProducts());

        }

        private void SetCategories(IEnumerable<ICategories> categories)
        {
            dataGridView1.AutoGenerateColumns = false;
            var bindingSource = new BindingSource();

            foreach (ICategories category in categories)
            {
                bindingSource.Add(category);                            
                
            }
            dataGridView1.DataSource = bindingSource;
            categoryComboBox.DataSource = bindingSource;



        }

        private void SetProducts(IEnumerable<IProducts> products)
        {
            dataGridView2.AutoGenerateColumns = false;
            var bindingSource = new BindingSource();

            _products = (List<Products>)products;

            foreach(Products _product in _products)
            {
                bindingSource.Insert(0, _product);
            }

            dataGridView2.DataSource = bindingSource;
        }

        private void OnSelectedCategory(object sender, EventArgs e)
        {

        }

        private void OnProductSelected(object sender, EventArgs e)
        {

        }

        private void AddProduct(object sender, EventArgs e)
        {
            try
            {
                try
                {
                    try
                    {

                        var item = (Categories)categoryComboBox.SelectedItem;
                        var product = new Products()
                        {
                            Name = prodName.Text,
                            Quantity = (int)prodQuantity.Value,
                            Price = (int)prodPrice.Value,
                            CategoryId = item.CategoryId
                        };
                        ProductValidation.ValidateInput(product);
                        var new_product = _productsRepository.AddProduct(product);
                        _productsRepository.UpdateTable(RefreshProductsTable, new_product);
                    }
                    catch (InvalidEntryException ex)
                    {
                        ResultMessages.ShowInputError("Invalid Entry", ex.Message);
                    }
                   
                }
                catch (DatabaseOperationException ex)
                {
                    ResultMessages.ShowError(ex.Message);
                }
            }
            catch (Exception)
            {
                ResultMessages.ShowError("Something went wrong. Unable to process task");
            }
        }

        public void RefreshProductsTable(Products new_product)
        {
            var prod = new Products()
            {
                ProductId = new_product.ProductId,
                Name = new_product.Name,
                CategoryId = new_product.CategoryId,
                Quantity = new_product.Quantity,
                Price = new_product.Price,
                CreatedDate = new_product.CreatedDate,
            };
            _products.Insert(0, prod);

            var newBindingSource = new BindingSource();

            foreach (Products prd in _products)
            {
                newBindingSource.Add(prd);
            }
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = newBindingSource;
            ResultMessages.ShowSuccess("Successfully added new product");
        }
    }
}
