namespace InventoryApplication
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            menuStrip1 = new MenuStrip();
            editToolStripMenuItem = new ToolStripMenuItem();
            categoriesToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel = new ToolStripStatusLabel();
            groupBox1 = new GroupBox();
            resetButton = new Button();
            categoryComboBox = new ComboBox();
            categoriesBindingSource2 = new BindingSource(components);
            label4 = new Label();
            prodPrice = new NumericUpDown();
            addProductButton = new Button();
            prodQuantity = new NumericUpDown();
            label3 = new Label();
            label2 = new Label();
            prodName = new TextBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            dataGridView1 = new DataGridView();
            categoryIdDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            totalDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            categoriesBindingSource1 = new BindingSource(components);
            groupBox3 = new GroupBox();
            dataGridView2 = new DataGridView();
            productIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            categoryIdDataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            categoryNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            quantityDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            priceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            createdDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            productTableBindingSource = new BindingSource(components);
            productsBindingSource = new BindingSource(components);
            categoriesBindingSource = new BindingSource(components);
            categoryIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            totalDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)categoriesBindingSource2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)prodPrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)prodQuantity).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)categoriesBindingSource1).BeginInit();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productTableBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productsBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)categoriesBindingSource).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { editToolStripMenuItem, helpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1119, 33);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { categoriesToolStripMenuItem });
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(58, 29);
            editToolStripMenuItem.Text = "&Edit";
            // 
            // categoriesToolStripMenuItem
            // 
            categoriesToolStripMenuItem.Name = "categoriesToolStripMenuItem";
            categoriesToolStripMenuItem.Size = new Size(198, 34);
            categoriesToolStripMenuItem.Text = "&Categories";
            categoriesToolStripMenuItem.Click += CreateCategoryOnClick;
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aboutToolStripMenuItem });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(65, 29);
            helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(164, 34);
            aboutToolStripMenuItem.Text = "&About";
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(24, 24);
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel });
            statusStrip1.Location = new Point(0, 859);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1119, 32);
            statusStrip1.TabIndex = 1;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel
            // 
            toolStripStatusLabel.Name = "toolStripStatusLabel";
            toolStripStatusLabel.Size = new Size(88, 25);
            toolStripStatusLabel.Text = "Loading...";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(resetButton);
            groupBox1.Controls.Add(categoryComboBox);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(prodPrice);
            groupBox1.Controls.Add(addProductButton);
            groupBox1.Controls.Add(prodQuantity);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(prodName);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(27, 54);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(416, 289);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Add New Item";
            // 
            // resetButton
            // 
            resetButton.Enabled = false;
            resetButton.Location = new Point(147, 234);
            resetButton.Name = "resetButton";
            resetButton.Size = new Size(112, 34);
            resetButton.TabIndex = 7;
            resetButton.Text = "&Reset";
            resetButton.UseVisualStyleBackColor = true;
            resetButton.Click += OnResetClick;
            // 
            // categoryComboBox
            // 
            categoryComboBox.DataSource = categoriesBindingSource2;
            categoryComboBox.DisplayMember = "Name";
            categoryComboBox.FormattingEnabled = true;
            categoryComboBox.Location = new Point(104, 86);
            categoryComboBox.Name = "categoryComboBox";
            categoryComboBox.Size = new Size(267, 33);
            categoryComboBox.TabIndex = 2;
            categoryComboBox.ValueMember = "CategoryId";
            // 
            // categoriesBindingSource2
            // 
            categoriesBindingSource2.DataSource = typeof(Models.Categories);
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 88);
            label4.Name = "label4";
            label4.Size = new Size(84, 25);
            label4.TabIndex = 0;
            label4.Text = "Category";
            // 
            // prodPrice
            // 
            prodPrice.Location = new Point(103, 186);
            prodPrice.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            prodPrice.Name = "prodPrice";
            prodPrice.Size = new Size(180, 31);
            prodPrice.TabIndex = 4;
            // 
            // addProductButton
            // 
            addProductButton.Location = new Point(21, 234);
            addProductButton.Name = "addProductButton";
            addProductButton.Size = new Size(112, 34);
            addProductButton.TabIndex = 5;
            addProductButton.Text = "&Add";
            addProductButton.UseVisualStyleBackColor = true;
            addProductButton.Click += AddProduct;
            // 
            // prodQuantity
            // 
            prodQuantity.Location = new Point(105, 136);
            prodQuantity.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            prodQuantity.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            prodQuantity.Name = "prodQuantity";
            prodQuantity.Size = new Size(180, 31);
            prodQuantity.TabIndex = 3;
            prodQuantity.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(33, 192);
            label3.Name = "label3";
            label3.Size = new Size(49, 25);
            label3.TabIndex = 0;
            label3.Text = "Price";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 138);
            label2.Name = "label2";
            label2.Size = new Size(80, 25);
            label2.TabIndex = 0;
            label2.Text = "Quantity";
            // 
            // prodName
            // 
            prodName.Location = new Point(102, 40);
            prodName.Name = "prodName";
            prodName.Size = new Size(271, 31);
            prodName.TabIndex = 1;
            prodName.KeyUp += OnNameKeyUp;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 43);
            label1.Name = "label1";
            label1.Size = new Size(59, 25);
            label1.TabIndex = 0;
            label1.Text = "Name";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView1);
            groupBox2.Location = new Point(472, 54);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(612, 289);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Storage Catalogues";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { categoryIdDataGridViewTextBoxColumn1, nameDataGridViewTextBoxColumn1, totalDataGridViewTextBoxColumn1 });
            dataGridView1.DataSource = categoriesBindingSource1;
            dataGridView1.Location = new Point(48, 43);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(518, 225);
            dataGridView1.TabIndex = 0;
            // 
            // categoryIdDataGridViewTextBoxColumn1
            // 
            categoryIdDataGridViewTextBoxColumn1.DataPropertyName = "CategoryId";
            categoryIdDataGridViewTextBoxColumn1.HeaderText = "ID";
            categoryIdDataGridViewTextBoxColumn1.MinimumWidth = 8;
            categoryIdDataGridViewTextBoxColumn1.Name = "categoryIdDataGridViewTextBoxColumn1";
            categoryIdDataGridViewTextBoxColumn1.Visible = false;
            categoryIdDataGridViewTextBoxColumn1.Width = 150;
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            nameDataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            nameDataGridViewTextBoxColumn1.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn1.HeaderText = "Name";
            nameDataGridViewTextBoxColumn1.MinimumWidth = 8;
            nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            // 
            // totalDataGridViewTextBoxColumn1
            // 
            totalDataGridViewTextBoxColumn1.DataPropertyName = "Total";
            totalDataGridViewTextBoxColumn1.HeaderText = "Total";
            totalDataGridViewTextBoxColumn1.MinimumWidth = 8;
            totalDataGridViewTextBoxColumn1.Name = "totalDataGridViewTextBoxColumn1";
            totalDataGridViewTextBoxColumn1.Width = 150;
            // 
            // categoriesBindingSource1
            // 
            categoriesBindingSource1.DataSource = typeof(Models.Categories);
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dataGridView2);
            groupBox3.Location = new Point(30, 378);
            groupBox3.MinimumSize = new Size(1054, 464);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(1054, 464);
            groupBox3.TabIndex = 0;
            groupBox3.TabStop = false;
            groupBox3.Text = "Inventory Table";
            // 
            // dataGridView2
            // 
            dataGridView2.AutoGenerateColumns = false;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { productIdDataGridViewTextBoxColumn, nameDataGridViewTextBoxColumn2, categoryIdDataGridViewTextBoxColumn2, categoryNameDataGridViewTextBoxColumn, quantityDataGridViewTextBoxColumn, priceDataGridViewTextBoxColumn, createdDateDataGridViewTextBoxColumn });
            dataGridView2.DataSource = productTableBindingSource;
            dataGridView2.Location = new Point(18, 45);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 62;
            dataGridView2.RowTemplate.Height = 33;
            dataGridView2.Size = new Size(1015, 399);
            dataGridView2.TabIndex = 0;
            dataGridView2.SelectionChanged += OnProductSelected;
            // 
            // productIdDataGridViewTextBoxColumn
            // 
            productIdDataGridViewTextBoxColumn.DataPropertyName = "ProductId";
            productIdDataGridViewTextBoxColumn.HeaderText = "ID";
            productIdDataGridViewTextBoxColumn.MinimumWidth = 8;
            productIdDataGridViewTextBoxColumn.Name = "productIdDataGridViewTextBoxColumn";
            productIdDataGridViewTextBoxColumn.Width = 150;
            // 
            // nameDataGridViewTextBoxColumn2
            // 
            nameDataGridViewTextBoxColumn2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            nameDataGridViewTextBoxColumn2.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn2.HeaderText = "Name";
            nameDataGridViewTextBoxColumn2.MinimumWidth = 8;
            nameDataGridViewTextBoxColumn2.Name = "nameDataGridViewTextBoxColumn2";
            // 
            // categoryIdDataGridViewTextBoxColumn2
            // 
            categoryIdDataGridViewTextBoxColumn2.DataPropertyName = "CategoryId";
            categoryIdDataGridViewTextBoxColumn2.HeaderText = "CategoryId";
            categoryIdDataGridViewTextBoxColumn2.MinimumWidth = 8;
            categoryIdDataGridViewTextBoxColumn2.Name = "categoryIdDataGridViewTextBoxColumn2";
            categoryIdDataGridViewTextBoxColumn2.Visible = false;
            categoryIdDataGridViewTextBoxColumn2.Width = 150;
            // 
            // categoryNameDataGridViewTextBoxColumn
            // 
            categoryNameDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            categoryNameDataGridViewTextBoxColumn.DataPropertyName = "CategoryName";
            categoryNameDataGridViewTextBoxColumn.HeaderText = "Catalogue";
            categoryNameDataGridViewTextBoxColumn.MinimumWidth = 8;
            categoryNameDataGridViewTextBoxColumn.Name = "categoryNameDataGridViewTextBoxColumn";
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            quantityDataGridViewTextBoxColumn.MinimumWidth = 8;
            quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            quantityDataGridViewTextBoxColumn.Width = 150;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            priceDataGridViewTextBoxColumn.HeaderText = "Price";
            priceDataGridViewTextBoxColumn.MinimumWidth = 8;
            priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            priceDataGridViewTextBoxColumn.Width = 150;
            // 
            // createdDateDataGridViewTextBoxColumn
            // 
            createdDateDataGridViewTextBoxColumn.DataPropertyName = "CreatedDate";
            createdDateDataGridViewTextBoxColumn.HeaderText = "Added Date";
            createdDateDataGridViewTextBoxColumn.MinimumWidth = 8;
            createdDateDataGridViewTextBoxColumn.Name = "createdDateDataGridViewTextBoxColumn";
            createdDateDataGridViewTextBoxColumn.Width = 150;
            // 
            // productTableBindingSource
            // 
            productTableBindingSource.DataSource = typeof(Models.ProductTable);
            // 
            // productsBindingSource
            // 
            productsBindingSource.DataSource = typeof(Models.Products);
            // 
            // categoriesBindingSource
            // 
            categoriesBindingSource.DataSource = typeof(Models.Categories);
            // 
            // categoryIdDataGridViewTextBoxColumn
            // 
            categoryIdDataGridViewTextBoxColumn.DataPropertyName = "CategoryId";
            categoryIdDataGridViewTextBoxColumn.HeaderText = "Id";
            categoryIdDataGridViewTextBoxColumn.MinimumWidth = 8;
            categoryIdDataGridViewTextBoxColumn.Name = "categoryIdDataGridViewTextBoxColumn";
            categoryIdDataGridViewTextBoxColumn.Width = 150;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Name";
            nameDataGridViewTextBoxColumn.MinimumWidth = 8;
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // totalDataGridViewTextBoxColumn
            // 
            totalDataGridViewTextBoxColumn.DataPropertyName = "Total";
            totalDataGridViewTextBoxColumn.HeaderText = "Total";
            totalDataGridViewTextBoxColumn.MinimumWidth = 8;
            totalDataGridViewTextBoxColumn.Name = "totalDataGridViewTextBoxColumn";
            totalDataGridViewTextBoxColumn.Width = 150;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1119, 891);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            MinimumSize = new Size(1141, 923);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ShopPlus Inventory Application";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)categoriesBindingSource2).EndInit();
            ((System.ComponentModel.ISupportInitialize)prodPrice).EndInit();
            ((System.ComponentModel.ISupportInitialize)prodQuantity).EndInit();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)categoriesBindingSource1).EndInit();
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)productTableBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)productsBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)categoriesBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem categoriesToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label3;
        private Label label2;
        private TextBox prodName;
        private Label label1;
        private Button addProductButton;
        private NumericUpDown prodQuantity;
        private Label label4;
        private NumericUpDown prodPrice;
        private Button resetButton;
        private ComboBox categoryComboBox;
        private GroupBox groupBox3;
        private BindingSource categoriesBindingSource;
        private DataGridViewTextBoxColumn categoryIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
        private DataGridView dataGridView1;
        private BindingSource categoriesBindingSource1;
        private DataGridView dataGridView2;
        private BindingSource productsBindingSource;
        private BindingSource categoriesBindingSource2;
        private DataGridViewTextBoxColumn categoryIdDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn1;
        private BindingSource productTableBindingSource;
        private DataGridViewTextBoxColumn productIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn categoryIdDataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn categoryNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn createdDateDataGridViewTextBoxColumn;
    }
}
