using InventoryApplication.Exceptions;
using InventoryApplication.Models;
using InventoryApplication.Utilities;
using InventoryApplication.Utilities.Validation;
using System.Collections;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Windows.Forms;

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
            toolStripStatusLabel.Text = string.Empty;

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

            foreach (Products _product in _products)
            {
                var new_date = DateTime.Parse(_product.CreatedDate);
                _product.CreatedDate = new_date.ToShortDateString();

                var productTable = new ProductTable()
                {
                    ProductId = _product.ProductId,
                    Name = _product.Name,
                    Quantity = _product.Quantity,
                    Price = _product.Price,
                    CategoryId = _product.CategoryId,
                    CategoryName = _categories.Where(x => x.CategoryId == _product.CategoryId).First().Name,
                    CreatedDate = _product.CreatedDate,
                };

                bindingSource.Insert(0, productTable);
            }

            dataGridView2.DataSource = bindingSource;
        }

        private void OnSelectedCategory(object sender, EventArgs e)
        {

        }

        private void OnProductSelected(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {
                var row = dataGridView2.SelectedRows[0];
                var dataTableRow = (ProductTable)row.DataBoundItem;

                EditProductForm form = new EditProductForm(_categories,
                    dataTableRow, _productsRepository,
                    RefreshProductsTableOnEdit,
                    RefreshProductsTableOnDelete);
                form.Show();
            }
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
                            CategoryId = item.CategoryId,
                            CreatedDate = DateTime.Now.ToShortDateString() // Revert DateTime.TryParse(string);
                        };
                        ProductValidation.ValidateInput(product);
                        var new_product = _productsRepository.AddProduct(product);
                        prodName.Text = string.Empty;
                        prodQuantity.Value = 1;
                        prodPrice.Value = 0;
                        resetButton.Enabled = false;
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
                ResultMessages.ShowGeneralError();
            }
        }

        public async void RefreshProductsTable(Products new_product)
        {
            toolStripStatusLabel.Text = "Adding Product...";
            //Insert new Item
            _products.Add(new_product);
            //Recreate table
            var newBindingSource = new BindingSource();
            foreach (var _product in _products.OrderByDescending(x => x.ProductId))
            {
                var new_prod = new ProductTable()
                {
                    ProductId = _product.ProductId,
                    Name = _product.Name,
                    CategoryId = _product.CategoryId,
                    CategoryName = _categories.Where(x => x.CategoryId == _product.CategoryId).First().Name,
                    Quantity = _product.Quantity,
                    Price = _product.Price,
                    CreatedDate = DateTime.Parse(_product.CreatedDate).ToShortDateString(),
                };
                newBindingSource.Add(new_prod);
            }
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = newBindingSource;
            await StatusMessage("Product Added");

        }

        public async void RefreshProductsTableOnEdit(Products products)
        {
            var index = _products.FindIndex(x => x.ProductId == products.ProductId);
            _products[index].Name = products.Name;
            _products[index].CategoryId = products.CategoryId;
            _products[index].Quantity = products.Quantity;
            _products[index].Price = products.Price;

            var newBindingSource = new BindingSource();
            foreach (var _product in _products.OrderByDescending(x => x.ProductId))
            {
                var new_prod = new ProductTable()
                {
                    ProductId = _product.ProductId,
                    Name = _product.Name,
                    CategoryId = _product.CategoryId,
                    CategoryName = _categories.Where(x => x.CategoryId == _product.CategoryId).First().Name,
                    Quantity = _product.Quantity,
                    Price = _product.Price,
                    CreatedDate = DateTime.Parse(_product.CreatedDate).ToShortDateString(),
                };
                newBindingSource.Add(new_prod);
            }
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = newBindingSource;
            await StatusMessage("Product Updated");
        }


        public async void RefreshProductsTableOnDelete(int ProductId)
        {
            toolStripStatusLabel.Text = "Adding Product...";
            //Insert new Item
            var deleted_product = _products.Where(x => x.ProductId == ProductId).First();
            _products.Remove(deleted_product);
            //Recreate table
            var newBindingSource = new BindingSource();
            foreach (var _product in _products.OrderByDescending(x => x.ProductId))
            {
                var new_prod = new ProductTable()
                {
                    ProductId = _product.ProductId,
                    Name = _product.Name,
                    CategoryId = _product.CategoryId,
                    CategoryName = _categories.Where(x => x.CategoryId == _product.CategoryId).First().Name,
                    Quantity = _product.Quantity,
                    Price = _product.Price,
                    CreatedDate = DateTime.Parse(_product.CreatedDate).ToShortDateString(),
                };
                newBindingSource.Add(new_prod);
            }
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = newBindingSource;
            await StatusMessage("Product Deleted");

        }

        private async Task StatusMessage(string message)
        {
            toolStripStatusLabel.Text = message;
            await Task.Delay(5000);
            toolStripStatusLabel.Text = string.Empty;
        }

        private void OnNameKeyUp(object sender, KeyEventArgs e)
        {
            if (prodName.Text != string.Empty)
                resetButton.Enabled = true;

            else
                resetButton.Enabled = false;


        }

        private void OnResetClick(object sender, EventArgs e)
        {
            prodName.Text = string.Empty;
            prodQuantity.Value = 1;
            prodPrice.Value = 0;
            resetButton.Enabled = false;
        }
    }
}
