using InventoryApplication.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryApplication.Utilities.Controls
{
    public static class EditTable
    {
       public static void RefreshProductsTable(List<Products> _products, 
                                                  List<ICategories> _categories,
                                                 DataGridView dataGridView2)
        {
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
        }

        public static void EditProductsRow(List<Products> _products, Products products)
        {
            var index = _products.FindIndex(x => x.ProductId == products.ProductId);
            _products[index].Name = products.Name;
            _products[index].CategoryId = products.CategoryId;
            _products[index].Quantity = products.Quantity;
            _products[index].Price = products.Price;
        }

        public static void RefreshCategoriesTable(List<ICategories> categories, DataGridView dataGridView1, ComboBox categoryComboBox, Button addProductButton)
        {
            var bindingSource = new BindingSource();
            foreach (var category in categories.OrderByDescending(x => x.CategoryId))
            {
                bindingSource.Add(category);
            }
            ResetCategoriesDataGridAndComboBox(dataGridView1, categoryComboBox, bindingSource, addProductButton);
        }

        public static void RefreshCategoriesTableOnProductsChange(Products new_product , List<ICategories> categories, DataGridView dataGridView1, ComboBox categoryComboBox, Button addProductButton)
        {
            var index = categories.FindIndex(x => x.CategoryId == new_product.CategoryId);
            categories[index].Total += 1;

            var bindingSource = new BindingSource();
            foreach (var category in categories.OrderByDescending(x => x.CategoryId))
            {
                bindingSource.Add(category);
            }
            ResetCategoriesDataGridAndComboBox(dataGridView1, categoryComboBox, bindingSource, addProductButton);
           
        }

        private static void ResetCategoriesDataGridAndComboBox(DataGridView dataGridView1, ComboBox categoryComboBox, BindingSource bindingSource, Button addProductButton)
        {
            dataGridView1.DataSource = categoryComboBox.DataSource = null;
            dataGridView1.DataSource = categoryComboBox.DataSource = bindingSource;

            categoryComboBox.ValueMember = "CategoryId";
            categoryComboBox.DisplayMember = "Name";
      
            categoryComboBox.Enabled = addProductButton.Enabled = true;

        }
        
       
       
    }
}
