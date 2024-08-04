namespace InventoryApplication
{
    partial class EditProductForm
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
            label1 = new Label();
            label2 = new Label();
            editName = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            editCategory = new ComboBox();
            categoriesBindingSource = new BindingSource(components);
            editQuantity = new NumericUpDown();
            editPrice = new NumericUpDown();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)categoriesBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)editQuantity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)editPrice).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(115, 29);
            label1.Name = "label1";
            label1.Size = new Size(208, 25);
            label1.TabIndex = 0;
            label1.Text = "Edit Product Information";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(136, 71);
            label2.Name = "label2";
            label2.Size = new Size(59, 25);
            label2.TabIndex = 0;
            label2.Text = "Name";
            // 
            // editName
            // 
            editName.Location = new Point(213, 68);
            editName.Name = "editName";
            editName.Size = new Size(254, 31);
            editName.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(111, 126);
            label3.Name = "label3";
            label3.Size = new Size(84, 25);
            label3.TabIndex = 0;
            label3.Text = "Category";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(115, 187);
            label4.Name = "label4";
            label4.Size = new Size(80, 25);
            label4.TabIndex = 0;
            label4.Text = "Quantity";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(146, 246);
            label5.Name = "label5";
            label5.Size = new Size(49, 25);
            label5.TabIndex = 0;
            label5.Text = "Price";
            // 
            // editCategory
            // 
            editCategory.DataSource = categoriesBindingSource;
            editCategory.DisplayMember = "Name";
            editCategory.FormattingEnabled = true;
            editCategory.Location = new Point(215, 124);
            editCategory.Name = "editCategory";
            editCategory.Size = new Size(181, 33);
            editCategory.TabIndex = 2;
            editCategory.ValueMember = "CategoryId";
            // 
            // categoriesBindingSource
            // 
            categoriesBindingSource.DataSource = typeof(Models.Categories);
            // 
            // editQuantity
            // 
            editQuantity.Location = new Point(216, 186);
            editQuantity.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            editQuantity.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            editQuantity.Name = "editQuantity";
            editQuantity.Size = new Size(180, 31);
            editQuantity.TabIndex = 3;
            editQuantity.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // editPrice
            // 
            editPrice.Location = new Point(216, 244);
            editPrice.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            editPrice.Name = "editPrice";
            editPrice.Size = new Size(180, 31);
            editPrice.TabIndex = 4;
            // 
            // button1
            // 
            button1.Location = new Point(216, 311);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 5;
            button1.Text = "&Save";
            button1.UseVisualStyleBackColor = true;
            button1.Click += OnClickSaveChanges;
            // 
            // button2
            // 
            button2.Location = new Point(355, 311);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 6;
            button2.Text = "&Delete";
            button2.UseVisualStyleBackColor = true;
            button2.Click += OnDeleteProductClick;
            // 
            // EditProductForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(595, 384);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(editPrice);
            Controls.Add(editQuantity);
            Controls.Add(editCategory);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(editName);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximumSize = new Size(617, 440);
            MinimumSize = new Size(617, 440);
            Name = "EditProductForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ShopPlus - Edit Product";
            ((System.ComponentModel.ISupportInitialize)categoriesBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)editQuantity).EndInit();
            ((System.ComponentModel.ISupportInitialize)editPrice).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox editName;
        private Label label3;
        private Label label4;
        private Label label5;
        private ComboBox editCategory;
        private NumericUpDown editQuantity;
        private NumericUpDown editPrice;
        private Button button1;
        private Button button2;
        private BindingSource categoriesBindingSource;
    }
}