using InventoryApplication.Models;
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
    public partial class EditCategoryForm : Form
    {
        ICategories category;
        Action<Categories, Form> DeleteSelectedCategory;
        Action<Categories, Form> ResetSelectedCategory;
        Action<Categories,Form> SaveSelectedCategory;
        public EditCategoryForm(ICategories category,
            Action<Categories, Form> deleteSelectedCategory,
            Action<Categories, Form> resetSelectedCategory,
            Action<Categories,Form> saveSelectedCategory
            )
        {
            InitializeComponent();
            this.category = category;
            DeleteSelectedCategory = deleteSelectedCategory;
            ResetSelectedCategory = resetSelectedCategory;
            SaveSelectedCategory = saveSelectedCategory;
            categoryName.Text = category.Name;
        }

        private void DeleteButtonClick(object sender, EventArgs e)
        {
            var selected_category = (Categories)category;
            DeleteSelectedCategory(selected_category, this);
        }

        private void ResetProductsClick(object sender, EventArgs e)
        {
            var selected_category = (Categories)category;
            ResetSelectedCategory(selected_category, this);
        }

        private void SaveChangesClick(object sender, EventArgs e)
        {
            var selected_category = (Categories)category;
            selected_category.Name = categoryName.Text;
            SaveSelectedCategory(selected_category, this);
            this.Close();
        }
    }
}
