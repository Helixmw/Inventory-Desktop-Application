using InventoryApplication.Exceptions;
using InventoryApplication.Models;
using InventoryApplication.Utilities;
using InventoryApplication.Utilities.Controls;
using InventoryApplication.Utilities.Validation;
using System.Collections;
using System.Collections.Generic;
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
            try
            {
                SetCategories();
                SetProducts(_productsRepository.GetProducts());

                toolStripStatusLabel.Text = string.Empty;
                dataGridView1.AllowUserToAddRows = false;
                dataGridView2.AllowUserToAddRows = false;
                ButtonPresets();
            }
            catch (DatabaseOperationException ex)
            {
                ResultMessages.ShowError(ex.Message);
            }

        }

        private void ButtonPresets()
        {
            addProductButton.Enabled = false;
            CheckCategoriesDropdown();
        }

        private void CheckCategoriesDropdown()
        {
            if (_categories.Count is 0)
            {
                categoryComboBox.Enabled = false;
                addProductButton.Enabled = false;

            }
            else
            {
                categoryComboBox.Enabled = true;
                addProductButton.Enabled = true;

            }
        }

        private void SetCategories()
        {
            //if(_categories.Count is 0)
            //    _categories.Clear();

            var categories = _categoriesRepository.GetCategories();
            foreach (var category in categories)
            {
                _categories.Add(category);
            }

            dataGridView1.AutoGenerateColumns = false;




            var bindingSource = new BindingSource();

            foreach (ICategories category in _categories.OrderByDescending(x => x.CategoryId))
            {
                bindingSource.Add(category);

            }
            dataGridView1.DataSource = bindingSource;
            categoryComboBox.DataSource = bindingSource;
            categoryComboBox.DisplayMember = "Name";
            categoryComboBox.ValueMember = "CategoryId";

        }

        public void ClearCategoriesAndComboBox()
        {
            _categories.Clear();
            dataGridView1.DataSource = null;
            categoryComboBox.DataSource = null;
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



        private void OnProductSelected(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {
                var row = dataGridView2.SelectedRows[0];
                var dataTableRow = (ProductTable)row.DataBoundItem;

                EditProductForm form = new EditProductForm(_categories,
                    dataTableRow, _productsRepository,
                    RefreshProductsTableOnEdit,
                    RefreshProductsTableOnDelete,
                    SetCategories,
                    ClearCategoriesAndComboBox);
                form.Show();
            }
        }

        private async void AddProduct(object sender, EventArgs e)
        {
            try
            {
                try
                {
                    try
                    {
                        QuantityPriceValidation.CheckValueLimits(prodQuantity, prodPrice);

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

                        var new_product = await _productsRepository.AddProduct(product);

                        EditTable.RefreshCategoriesTableOnProductsChange(new_product, _categories, dataGridView1, categoryComboBox, addProductButton);

                        prodName.Text = string.Empty;
                        prodQuantity.Value = 1;
                        prodPrice.Value = 0;
                        resetButton.Enabled = false;
                        _productsRepository.UpdateTable(RefreshProductsTable, new_product);
                    }
                    catch (InvalidEntryException ex)
                    {
                        ResultMessages.ShowInputError(ex.Message);
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
            _products.Add(new_product);
            EditTable.RefreshProductsTable(_products, _categories, dataGridView2);
            //SetCategories();
            await StatusMessage("Product Added");
        }

        public async void RefreshProductsTableOnEdit(Products products)
        {
            EditTable.EditProductsRow(_products, products);
            EditTable.RefreshProductsTable(_products, _categories, dataGridView2);
            await StatusMessage("Product Updated");
        }


        public async void RefreshProductsTableOnDelete(int ProductId)
        {
            toolStripStatusLabel.Text = "Deleting Product...";
            var deleted_product = _products.Where(x => x.ProductId == ProductId).First();
            _products.Remove(deleted_product);


            EditTable.RefreshProductsTable(_products, _categories, dataGridView2);
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
            {
                resetButton.Enabled = true;
                addProductButton.Enabled = true;
            }

            else
            {
                resetButton.Enabled = false;
                addProductButton.Enabled = false;
            }

            CheckCategoriesDropdown();
        }

        private void OnResetClick(object sender, EventArgs e)
        {
            prodName.Text = string.Empty;
            prodQuantity.Value = 1;
            prodPrice.Value = 0;
            resetButton.Enabled = false;
        }

        private void CreateCategoryOnClick(object sender, EventArgs e)
        {
            CreateCategoryForm createCategoryForm = new CreateCategoryForm(_categoriesRepository,
                AddToCategoriesTable, _categories,
                SetCategoryNameFromEdit);
            createCategoryForm.Show();
        }

        public async void AddToCategoriesTable(Categories categories)
        {
            _categories.Add(categories);
            EditTable.RefreshCategoriesTable(_categories, dataGridView1, categoryComboBox, addProductButton);
            await StatusMessage("New Category Added");
        }

        public void SetCategoryNameFromEdit(Categories category)
        {
            var categoryBindingSource = new BindingSource();
            _categories.Clear();

            var categories = _categoriesRepository.GetCategories();

            foreach (var _category in categories)
            {
                _categories.Add(_category);
                categoryBindingSource.Add(_category);
            }

            dataGridView1.AutoGenerateColumns = false;

            dataGridView1.DataSource = categoryComboBox.DataSource = null;
            dataGridView1.DataSource = categoryComboBox.DataSource = categoryBindingSource;
            categoryComboBox.DisplayMember = "Name";
            categoryComboBox.ValueMember = "CategoryId";

            ResetProductsTableOnCategoryEdit();

        }

        private void ResetProductsTableOnCategoryEdit()
        {
            _products.Clear();
            dataGridView2.DataSource = null;
            SetProducts(_productsRepository.GetProducts());
        }
    }
}
