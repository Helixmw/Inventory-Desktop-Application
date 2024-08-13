namespace InventoryApplication
{
    partial class CreateCategoryForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateCategoryForm));
            categoryName = new TextBox();
            createButton = new Button();
            editButton = new Button();
            deleteButton = new Button();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            categoryListBox = new ListBox();
            categoriesBindingSource = new BindingSource(components);
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)categoriesBindingSource).BeginInit();
            SuspendLayout();
            // 
            // categoryName
            // 
            categoryName.Location = new Point(24, 42);
            categoryName.Name = "categoryName";
            categoryName.Size = new Size(355, 31);
            categoryName.TabIndex = 1;
            categoryName.KeyUp += CheckValueExists;
            // 
            // createButton
            // 
            createButton.Location = new Point(24, 82);
            createButton.Name = "createButton";
            createButton.Size = new Size(112, 34);
            createButton.TabIndex = 2;
            createButton.Text = "&Create";
            createButton.UseVisualStyleBackColor = true;
            createButton.Click += CreateNewCategory;
            // 
            // editButton
            // 
            editButton.Enabled = false;
            editButton.Location = new Point(147, 82);
            editButton.Name = "editButton";
            editButton.Size = new Size(112, 34);
            editButton.TabIndex = 3;
            editButton.Text = "&Edit";
            editButton.UseVisualStyleBackColor = true;
            editButton.Click += EditButtonClick;
            // 
            // deleteButton
            // 
            deleteButton.Enabled = false;
            deleteButton.Location = new Point(267, 82);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(112, 34);
            deleteButton.TabIndex = 4;
            deleteButton.Text = "&Delete";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += DeleteButtonClick;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(categoryName);
            groupBox1.Controls.Add(deleteButton);
            groupBox1.Controls.Add(createButton);
            groupBox1.Controls.Add(editButton);
            groupBox1.Location = new Point(38, 37);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(415, 178);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Add and Edit Category";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(categoryListBox);
            groupBox2.Location = new Point(477, 37);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(445, 460);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "Categories List";
            // 
            // categoryListBox
            // 
            categoryListBox.DataSource = categoriesBindingSource;
            categoryListBox.DisplayMember = "Name";
            categoryListBox.FormattingEnabled = true;
            categoryListBox.ItemHeight = 25;
            categoryListBox.Location = new Point(27, 47);
            categoryListBox.Name = "categoryListBox";
            categoryListBox.Size = new Size(392, 379);
            categoryListBox.TabIndex = 5;
            categoryListBox.ValueMember = "CategoryId";
            categoryListBox.Click += OnCategorySelected;
            // 
            // categoriesBindingSource
            // 
            categoriesBindingSource.DataSource = typeof(Models.Categories);
            // 
            // CreateCategoryForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(959, 523);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(981, 579);
            MinimumSize = new Size(981, 579);
            Name = "CreateCategoryForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ShopPlus Inventory Application - Categories";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)categoriesBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private TextBox categoryName;
        private Button createButton;
        private Button editButton;
        private Button deleteButton;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private ListBox categoryListBox;
        private BindingSource categoriesBindingSource;
    }
}