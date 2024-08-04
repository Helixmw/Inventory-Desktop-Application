using InventoryApplication.Exceptions;
using InventoryApplication.Models;
using InventoryApplication.Utilities;
using InventoryApplication.Utilities.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryApplication
{
    public partial class EditProductForm : Form
    {

        ProductsRepository _productsRepository;
        ProductTable _product;
        List<ICategories> _categories;
        Action<Products> _updateProductsTable;
        Action<int> _deleteProductFromTable;
        Action _updateCategoriesTable;
        Action _updateCategoriesControl;
        public EditProductForm(List<ICategories> categories,
            ProductTable products,
            ProductsRepository productsRepository,
            Action<Products> updateProductsTable,
            Action<int> deleteProductFromTable,
            Action updateCategoriesTable,
            Action updateCategoriesControl)
        {
            _product = products;
            InitializeComponent();
            _categories = categories;
            _updateProductsTable = updateProductsTable;
            _productsRepository = productsRepository;
            _updateCategoriesTable = updateCategoriesTable;
            _updateCategoriesControl = updateCategoriesControl;
            FillForm();
            _deleteProductFromTable = deleteProductFromTable;
        }

        private void FillForm()
        {
            var bindingSource = new BindingSource();
            foreach (var category in _categories)
            {
                bindingSource.Add(category);
            }
            editCategory.DataSource = bindingSource;

            editName.Text = _product.Name;
            editCategory.SelectedItem = _categories.Where(x => x.CategoryId == _product.CategoryId).FirstOrDefault();
            editCategory.Text = _product.CategoryName;
            editCategory.SelectedValue = _product.CategoryId;
            editPrice.Value = _product.Price;
            editQuantity.Value = _product.Quantity;
        }

        private void OnClickSaveChanges(object sender, EventArgs e)
        {
            try
            {
                try
                {
                    try
                    {

                        if (editCategory.SelectedValue is not null)
                        {
                            var categoryId = (int)editCategory.SelectedValue;

                            var product = new Products()
                            {
                                ProductId = _product.ProductId,
                                Name = editName.Text,
                                CategoryId = categoryId,
                                Quantity = (int)editQuantity.Value,
                                Price = (int)editPrice.Value,
                            };
                            ProductValidation.ValidateInput(product);
                            _productsRepository.EditProduct(product);
                            //ResultMessages.ShowSuccess($"Successfully made changes to:\n'{product.Name}'");
                            _updateProductsTable(product);
                            this.Close();
                        }

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

        private async void OnDeleteProductClick(object sender, EventArgs e)
        {
            try
            {
                try
                {
                    DialogResult result = ResultMessages.ShowQuestion($"Are you sure you want to delete?\n'{_product.Name}'", "Delete Product");
                    if (result is DialogResult.Yes)
                    {
                        await _productsRepository.DeleteProduct(new Products()
                        {
                            ProductId = _product.ProductId,
                            CategoryId = _product.CategoryId
                        });
                        _deleteProductFromTable(_product.ProductId);
                        _updateCategoriesControl();
                        _updateCategoriesTable();
                        this.Close();
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
    }
}
