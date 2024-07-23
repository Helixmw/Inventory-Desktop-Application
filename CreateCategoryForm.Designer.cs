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
            label1 = new Label();
            categoryName = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 26);
            label1.Name = "label1";
            label1.Size = new Size(169, 25);
            label1.TabIndex = 0;
            label1.Text = "Enter New Category";
            // 
            // categoryName
            // 
            categoryName.Location = new Point(24, 63);
            categoryName.Name = "categoryName";
            categoryName.Size = new Size(428, 31);
            categoryName.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(24, 110);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 2;
            button1.Text = "&Create";
            button1.UseVisualStyleBackColor = true;
            button1.Click += CreateNewCategory;
            // 
            // CreateCategoryForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(481, 198);
            Controls.Add(button1);
            Controls.Add(categoryName);
            Controls.Add(label1);
            MaximumSize = new Size(503, 254);
            MinimumSize = new Size(503, 254);
            Name = "CreateCategoryForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Create Category";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox categoryName;
        private Button button1;
    }
}