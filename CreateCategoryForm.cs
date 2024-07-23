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
    public partial class CreateCategoryForm : Form
    {
        CategoriesRepository _categoriesRepository;
        AddToCategoriesTable _addToCategoriesTable;
        public CreateCategoryForm(CategoriesRepository categoriesRepository, AddToCategoriesTable addToCategoriesTable)
        {
            InitializeComponent();
            _categoriesRepository = categoriesRepository;
            _addToCategoriesTable = addToCategoriesTable;
        }

        public delegate void AddToCategoriesTable(Categories categories);

        private void CreateNewCategory(object sender, EventArgs e)
        {
            try
            {
                try
                {
                    CategoryValidation.ValidateInput(categoryName.Text);
                    var category = _categoriesRepository.AddCategory(categoryName.Text);
                    _addToCategoriesTable(category);
                    this.Close();
                }
                catch (InvalidEntryException ex)
                {
                    ResultMessages.ShowInputError("Invalid Entry", ex.Message);
                }
            }catch(DatabaseOperationException ex)
            {
                ResultMessages.ShowError(ex.Message);
            }

        }
    }
}
