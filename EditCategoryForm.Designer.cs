namespace InventoryApplication
{
    partial class EditCategoryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditCategoryForm));
            label1 = new Label();
            categoryName = new TextBox();
            saveChangesButton = new Button();
            resetProductsButton = new Button();
            deleteButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 26);
            label1.Name = "label1";
            label1.Size = new Size(190, 25);
            label1.TabIndex = 0;
            label1.Text = "Edit Selected Category";
            // 
            // categoryName
            // 
            categoryName.Location = new Point(24, 68);
            categoryName.Name = "categoryName";
            categoryName.Size = new Size(539, 31);
            categoryName.TabIndex = 1;
            // 
            // saveChangesButton
            // 
            saveChangesButton.Location = new Point(24, 113);
            saveChangesButton.Name = "saveChangesButton";
            saveChangesButton.Size = new Size(145, 34);
            saveChangesButton.TabIndex = 2;
            saveChangesButton.Text = "&Save Changes";
            saveChangesButton.UseVisualStyleBackColor = true;
            saveChangesButton.Click += SaveChangesClick;
            // 
            // resetProductsButton
            // 
            resetProductsButton.Location = new Point(179, 113);
            resetProductsButton.Name = "resetProductsButton";
            resetProductsButton.Size = new Size(150, 34);
            resetProductsButton.TabIndex = 3;
            resetProductsButton.Text = "&Reset Products";
            resetProductsButton.UseVisualStyleBackColor = true;
            resetProductsButton.Click += ResetProductsClick;
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(338, 113);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(88, 34);
            deleteButton.TabIndex = 4;
            deleteButton.Text = "&Delete";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += DeleteButtonClick;
            // 
            // EditCategoryForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(607, 189);
            Controls.Add(deleteButton);
            Controls.Add(resetProductsButton);
            Controls.Add(saveChangesButton);
            Controls.Add(categoryName);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(629, 245);
            MinimumSize = new Size(629, 245);
            Name = "EditCategoryForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Edit Category";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox categoryName;
        private Button saveChangesButton;
        private Button resetProductsButton;
        private Button deleteButton;
    }
}