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
        public EditProductForm(List<ICategories> categories,
            ProductTable products,
            ProductsRepository productsRepository,
            Action<Products> updateProductsTable,
            Action<int> deleteProductFromTable)
        {
            InitializeComponent();
            _categories = categories;
            _product = products;
            _updateProductsTable = updateProductsTable;
            _productsRepository = productsRepository;
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

        private void OnDeleteProductClick(object sender, EventArgs e)
        {
            try
            {
                try
                {
                    DialogResult result = ResultMessages.ShowQuestion($"Are you sure you want to delete?\n'{_product.Name}'", "Delete Product");
                    if (result is DialogResult.Yes)
                    {
                        _productsRepository.DeleteProduct(_product.ProductId);
                        _deleteProductFromTable(_product.ProductId);
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
