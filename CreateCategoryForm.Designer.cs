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
            categoryName = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            listBox1 = new ListBox();
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
            // 
            // button1
            // 
            button1.Location = new Point(24, 82);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 2;
            button1.Text = "&Create";
            button1.UseVisualStyleBackColor = true;
            button1.Click += CreateNewCategory;
            // 
            // button2
            // 
            button2.Enabled = false;
            button2.Location = new Point(147, 82);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 3;
            button2.Text = "&Save";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Enabled = false;
            button3.Location = new Point(267, 82);
            button3.Name = "button3";
            button3.Size = new Size(112, 34);
            button3.TabIndex = 4;
            button3.Text = "&Delete";
            button3.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(categoryName);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(button2);
            groupBox1.Location = new Point(38, 37);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(415, 178);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Add and Edit Category";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(listBox1);
            groupBox2.Location = new Point(477, 37);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(445, 460);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "Categories List";
            // 
            // listBox1
            // 
            listBox1.DataSource = categoriesBindingSource;
            listBox1.DisplayMember = "Name";
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 25;
            listBox1.Location = new Point(27, 47);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(392, 379);
            listBox1.TabIndex = 0;
            listBox1.ValueMember = "CategoryId";
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
        private Button button1;
        private Button button2;
        private Button button3;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private ListBox listBox1;
        private BindingSource categoriesBindingSource;
    }
}