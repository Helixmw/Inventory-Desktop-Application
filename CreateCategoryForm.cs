using InventoryApplication.Exceptions;
using InventoryApplication.Models;
using InventoryApplication.Utilities;
using InventoryApplication.Utilities.Controls;
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
        List<ICategories> categoriesList;
        Action<Categories> _setCategoryNameFromEdit;
        Action _resetProductsTableOnCategoryEdit;
        Action<List<Categories>> _resetCategoriesTable;
        int selectedCategoryId;
        public CreateCategoryForm(CategoriesRepository categoriesRepository,
            AddToCategoriesTable addToCategoriesTable,
            List<ICategories> categoriesList,
            Action<Categories> setCategoryNameFromEdit,
            Action resetProductsTableOnCategoryEdit,
            Action<List<Categories>> resetCategoriesTable
            )
        {
            InitializeComponent();
            _categoriesRepository = categoriesRepository;
            _addToCategoriesTable = addToCategoriesTable;
            this.categoriesList = categoriesList;
            this._setCategoryNameFromEdit = setCategoryNameFromEdit;
            this._resetProductsTableOnCategoryEdit = resetProductsTableOnCategoryEdit;
            this._resetCategoriesTable = resetCategoriesTable;
            SetCategoriesInListBox();
        }

        public delegate void AddToCategoriesTable(List<Categories> categories);

        private void SetCategoriesInListBox()
        {
            BindingSource bindingSource = new BindingSource();

            foreach (var category in categoriesList)
            {
                bindingSource.Insert(0, category);
            }

            categoryListBox.DataSource = bindingSource;

        }

        private void ResetListBox(List<Categories> categories)
        {
            categoriesList.Clear();
            foreach(var category in categories)
            {
                categoriesList.Add(category);
            }
            categoryListBox.DataSource = null;
            var bindingSource = new BindingSource();
            foreach(var category in categoriesList)
            {
                bindingSource.Insert(0, category);
            }
            categoryListBox.DataSource = bindingSource;
            categoryListBox.DisplayMember = "Name";
            categoryListBox.ValueMember = "CategoryId";         

        }

        private void CreateNewCategory(object sender, EventArgs e)
        {
            try
            {
                try
                {
                    CategoryValidation.ValidateInput(categoryName.Text);
                    CategoryValidation.CategoryExists(categoryName.Text, categoriesList);

                    var categories = _categoriesRepository.AddCategory(categoryName.Text);
                    _addToCategoriesTable(categories);
                    ResetListBox(categories);
                    //this.Close();
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

        private void OnCategorySelected(object sender, EventArgs e)
        {
            if (categoryListBox.SelectedValue is not null)
            {
                categoryName.Text = (string)categoryListBox.Text;
                selectedCategoryId = (int)categoryListBox.SelectedValue;
            }

            createButton.Enabled = false;
            editButton.Enabled = true;
            deleteButton.Enabled = true;
        }

        private void CheckValueExists(object sender, KeyEventArgs e)
        {
            var count = categoriesList.Where(x => x.Name.ToLower() == categoryName.Text.Trim().ToLower()).FirstOrDefault();
            if (count is not null)
            {
                categoryName.Text = count.Name;
                selectedCategoryId = count.CategoryId;

                createButton.Enabled = false;
                editButton.Enabled = true;
                deleteButton.Enabled = true;
            }
            else
            {
                createButton.Enabled = true;
                editButton.Enabled = false;
                deleteButton.Enabled = false;
            }

        }

        public void DeleteCategory(ICategories category, Form? editForm = null)
        {
            var result =  Prompts.QuestionPrompt($"Are you sure you want to delete {category.Name}?\n" +
                                        $"Deleting {category.Name} results in erasing all product records.", "Delete Category");
            if (result == DialogResult.Yes)
            {
                var new_categories = _categoriesRepository.DeleteCategoryData((Categories)category);
                _resetCategoriesTable(new_categories);
                _resetProductsTableOnCategoryEdit();
                ResetCategoriesAndListBox(new_categories);
                SetCategoriesInListBox();
                categoryListBox.DisplayMember = "Name";

                if (editForm is not null)
                editForm.Close();

                ResultMessages.ShowSuccess($"You have deleted all Products and the category {category.Name}");

            }
        }

        private void ResetCategoriesAndListBox(List<Categories> new_categories)
        {
            categoriesList.Clear();
            foreach (var category in new_categories)
            {
                categoriesList.Add(category);
            }
            categoryListBox.DataSource = null;
        }




        public void ResetCategory(Categories category, Form editForm)
        {
            var result = Prompts.QuestionPrompt($"Are you sure you want to reset {category.Name} Products?\n" +
                                        $"Resetting {category.Name} Products deletes all the products under this category.", "Reset Category Products");
            if(result == DialogResult.Yes)
            {
                var new_categories = _categoriesRepository.DeleteCategoryProducts(category);
                _resetProductsTableOnCategoryEdit();
                _resetCategoriesTable(new_categories);
                editForm.Close();
                ResultMessages.ShowSuccess($"You have reset all Products under {category.Name}");
            }

        }

        public void SaveCategory(Categories category, Form editForm)
        {
            _categoriesRepository.UpdateCategory(category);
            ResetListBox();
            ResetNameField(category);
            _setCategoryNameFromEdit(category);  
            editForm.Close();
        }

        private void ResetListBox()
        {
            categoriesList.Clear();
            var categories = _categoriesRepository.GetCategories();
            var bindingSource = new BindingSource();
            foreach (var category in categories)
            {
                categoriesList.Add(category);
                bindingSource.Add(category);
            }

            categoryListBox.DataSource = null;
            categoryListBox.DataSource = bindingSource;
            categoryListBox.DisplayMember = "Name";
            categoryListBox.ValueMember = "CategoryId";
         
        }

        private void ResetNameField(Categories category)
        {
            var category_name = category.Name.ToLower();
            if(categoryName.Text.ToLower() != category_name && selectedCategoryId == category.CategoryId)
            {
                createButton.Enabled = true;
                editButton.Enabled = false;
                deleteButton.Enabled = false;
            }

        }

        

        private void EditButtonClick(object sender, EventArgs e)
        {
            var selected_category = categoriesList.Where(x => x.CategoryId == selectedCategoryId).FirstOrDefault();
            if (selected_category is not null)
            {
                EditCategoryForm editCategory = new EditCategoryForm(selected_category,
                                DeleteCategory, ResetCategory, SaveCategory);
                editCategory.Show();
            }
        }

        private void DeleteButtonClick(object sender, EventArgs e)
        {
            var selected_category = categoriesList.Where(x => x.CategoryId == selectedCategoryId).FirstOrDefault();
            if (selected_category is not null)
            DeleteCategory(selected_category);
        }
    }
}
