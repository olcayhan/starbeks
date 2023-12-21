namespace VisualProgrammingProject
{
    partial class AdminPage
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
            this.txtProductPrice = new System.Windows.Forms.TextBox();
            this.lblProductPrice = new System.Windows.Forms.Label();
            this.cmbProductCategory = new System.Windows.Forms.ComboBox();
            this.lblProductCategory = new System.Windows.Forms.Label();
            this.txtProductAmount = new System.Windows.Forms.TextBox();
            this.lblProductAmount = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.lblProduct = new System.Windows.Forms.Label();
            this.lblProducts = new System.Windows.Forms.Label();
            this.liviewProducts = new System.Windows.Forms.ListView();
            this.columnName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnAmount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnCategory = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAddCategory = new System.Windows.Forms.Button();
            this.lblCategory = new System.Windows.Forms.Label();
            this.txtCategory = new System.Windows.Forms.TextBox();
            this.liboxCategories = new System.Windows.Forms.ListBox();
            this.lblCategories = new System.Windows.Forms.Label();
            this.btnDeleteCategory = new System.Windows.Forms.Button();
            this.btnDeleteProduct = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtProductPrice
            // 
            this.txtProductPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtProductPrice.Location = new System.Drawing.Point(809, 496);
            this.txtProductPrice.Margin = new System.Windows.Forms.Padding(4);
            this.txtProductPrice.Name = "txtProductPrice";
            this.txtProductPrice.Size = new System.Drawing.Size(159, 32);
            this.txtProductPrice.TabIndex = 34;
            // 
            // lblProductPrice
            // 
            this.lblProductPrice.AutoSize = true;
            this.lblProductPrice.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblProductPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblProductPrice.Location = new System.Drawing.Point(817, 472);
            this.lblProductPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProductPrice.Name = "lblProductPrice";
            this.lblProductPrice.Size = new System.Drawing.Size(48, 20);
            this.lblProductPrice.TabIndex = 33;
            this.lblProductPrice.Text = "Price";
            // 
            // cmbProductCategory
            // 
            this.cmbProductCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbProductCategory.FormattingEnabled = true;
            this.cmbProductCategory.Items.AddRange(new object[] {
            "Sıcak",
            "Soğuk",
            "Sütlü"});
            this.cmbProductCategory.Location = new System.Drawing.Point(808, 436);
            this.cmbProductCategory.Margin = new System.Windows.Forms.Padding(4);
            this.cmbProductCategory.Name = "cmbProductCategory";
            this.cmbProductCategory.Size = new System.Drawing.Size(160, 30);
            this.cmbProductCategory.TabIndex = 32;
            // 
            // lblProductCategory
            // 
            this.lblProductCategory.AutoSize = true;
            this.lblProductCategory.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblProductCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblProductCategory.Location = new System.Drawing.Point(817, 411);
            this.lblProductCategory.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProductCategory.Name = "lblProductCategory";
            this.lblProductCategory.Size = new System.Drawing.Size(76, 20);
            this.lblProductCategory.TabIndex = 31;
            this.lblProductCategory.Text = "Category";
            // 
            // txtProductAmount
            // 
            this.txtProductAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtProductAmount.Location = new System.Drawing.Point(809, 375);
            this.txtProductAmount.Margin = new System.Windows.Forms.Padding(4);
            this.txtProductAmount.Name = "txtProductAmount";
            this.txtProductAmount.Size = new System.Drawing.Size(159, 32);
            this.txtProductAmount.TabIndex = 30;
            // 
            // lblProductAmount
            // 
            this.lblProductAmount.AutoSize = true;
            this.lblProductAmount.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblProductAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblProductAmount.Location = new System.Drawing.Point(817, 350);
            this.lblProductAmount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProductAmount.Name = "lblProductAmount";
            this.lblProductAmount.Size = new System.Drawing.Size(66, 20);
            this.lblProductAmount.TabIndex = 29;
            this.lblProductAmount.Text = "Amount";
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblProductName.Location = new System.Drawing.Point(817, 288);
            this.lblProductName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(53, 20);
            this.lblProductName.TabIndex = 28;
            this.lblProductName.Text = "Name";
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAddProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAddProduct.Location = new System.Drawing.Point(1072, 303);
            this.btnAddProduct.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(140, 67);
            this.btnAddProduct.TabIndex = 27;
            this.btnAddProduct.Text = "Add";
            this.btnAddProduct.UseVisualStyleBackColor = false;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // txtProductName
            // 
            this.txtProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtProductName.Location = new System.Drawing.Point(809, 313);
            this.txtProductName.Margin = new System.Windows.Forms.Padding(4);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(159, 32);
            this.txtProductName.TabIndex = 26;
            // 
            // lblProduct
            // 
            this.lblProduct.AutoSize = true;
            this.lblProduct.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblProduct.Location = new System.Drawing.Point(978, 256);
            this.lblProduct.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(87, 26);
            this.lblProduct.TabIndex = 25;
            this.lblProduct.Text = "Product";
            // 
            // lblProducts
            // 
            this.lblProducts.AutoSize = true;
            this.lblProducts.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblProducts.Location = new System.Drawing.Point(978, 4);
            this.lblProducts.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProducts.Name = "lblProducts";
            this.lblProducts.Size = new System.Drawing.Size(98, 26);
            this.lblProducts.TabIndex = 24;
            this.lblProducts.Text = "Products";
            // 
            // liviewProducts
            // 
            this.liviewProducts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnName,
            this.columnAmount,
            this.columnCategory,
            this.columnPrice});
            this.liviewProducts.HideSelection = false;
            this.liviewProducts.Location = new System.Drawing.Point(809, 35);
            this.liviewProducts.Margin = new System.Windows.Forms.Padding(4);
            this.liviewProducts.Name = "liviewProducts";
            this.liviewProducts.Size = new System.Drawing.Size(447, 201);
            this.liviewProducts.TabIndex = 23;
            this.liviewProducts.UseCompatibleStateImageBehavior = false;
            this.liviewProducts.View = System.Windows.Forms.View.Details;
            // 
            // columnName
            // 
            this.columnName.Text = "Name";
            // 
            // columnAmount
            // 
            this.columnAmount.Text = "Amount";
            this.columnAmount.Width = 79;
            // 
            // columnCategory
            // 
            this.columnCategory.Text = "Category";
            this.columnCategory.Width = 109;
            // 
            // columnPrice
            // 
            this.columnPrice.Text = "Price";
            this.columnPrice.Width = 84;
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAddCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAddCategory.Location = new System.Drawing.Point(133, 353);
            this.btnAddCategory.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.Size = new System.Drawing.Size(91, 30);
            this.btnAddCategory.TabIndex = 22;
            this.btnAddCategory.Text = "Add";
            this.btnAddCategory.UseVisualStyleBackColor = false;
            this.btnAddCategory.Click += new System.EventHandler(this.btnAddCategory_Click);
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCategory.Location = new System.Drawing.Point(152, 282);
            this.lblCategory.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(100, 26);
            this.lblCategory.TabIndex = 21;
            this.lblCategory.Text = "Category";
            // 
            // txtCategory
            // 
            this.txtCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtCategory.Location = new System.Drawing.Point(133, 313);
            this.txtCategory.Margin = new System.Windows.Forms.Padding(4);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Size = new System.Drawing.Size(159, 32);
            this.txtCategory.TabIndex = 20;
            
            // 
            // liboxCategories
            // 
            this.liboxCategories.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.liboxCategories.FormattingEnabled = true;
            this.liboxCategories.ItemHeight = 26;
            this.liboxCategories.Items.AddRange(new object[] {
            "Sıcak",
            "Soğuk",
            "Sütlü"});
            this.liboxCategories.Location = new System.Drawing.Point(133, 50);
            this.liboxCategories.Margin = new System.Windows.Forms.Padding(4);
            this.liboxCategories.Name = "liboxCategories";
            this.liboxCategories.Size = new System.Drawing.Size(159, 186);
            this.liboxCategories.TabIndex = 19;
            // 
            // lblCategories
            // 
            this.lblCategories.AutoSize = true;
            this.lblCategories.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblCategories.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCategories.Location = new System.Drawing.Point(152, 20);
            this.lblCategories.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCategories.Name = "lblCategories";
            this.lblCategories.Size = new System.Drawing.Size(117, 26);
            this.lblCategories.TabIndex = 18;
            this.lblCategories.Text = "Categories";
            // 
            // btnDeleteCategory
            // 
            this.btnDeleteCategory.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDeleteCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDeleteCategory.Location = new System.Drawing.Point(133, 391);
            this.btnDeleteCategory.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteCategory.Name = "btnDeleteCategory";
            this.btnDeleteCategory.Size = new System.Drawing.Size(91, 30);
            this.btnDeleteCategory.TabIndex = 35;
            this.btnDeleteCategory.Text = "Delete";
            this.btnDeleteCategory.UseVisualStyleBackColor = false;
            this.btnDeleteCategory.Click += new System.EventHandler(this.btnDeleteCategory_Click);
            // 
            // btnDeleteProduct
            // 
            this.btnDeleteProduct.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDeleteProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDeleteProduct.Location = new System.Drawing.Point(1072, 460);
            this.btnDeleteProduct.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteProduct.Name = "btnDeleteProduct";
            this.btnDeleteProduct.Size = new System.Drawing.Size(140, 68);
            this.btnDeleteProduct.TabIndex = 36;
            this.btnDeleteProduct.Text = "Delete";
            this.btnDeleteProduct.UseVisualStyleBackColor = false;
            this.btnDeleteProduct.Click += new System.EventHandler(this.btnDeleteProduct_Click);
            // 
            // AdminPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(1320, 625);
            this.Controls.Add(this.btnDeleteProduct);
            this.Controls.Add(this.btnDeleteCategory);
            this.Controls.Add(this.txtProductPrice);
            this.Controls.Add(this.lblProductPrice);
            this.Controls.Add(this.cmbProductCategory);
            this.Controls.Add(this.lblProductCategory);
            this.Controls.Add(this.txtProductAmount);
            this.Controls.Add(this.lblProductAmount);
            this.Controls.Add(this.lblProductName);
            this.Controls.Add(this.btnAddProduct);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.lblProduct);
            this.Controls.Add(this.lblProducts);
            this.Controls.Add(this.liviewProducts);
            this.Controls.Add(this.btnAddCategory);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.txtCategory);
            this.Controls.Add(this.liboxCategories);
            this.Controls.Add(this.lblCategories);
            this.Name = "AdminPage";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtProductPrice;
        private System.Windows.Forms.Label lblProductPrice;
        private System.Windows.Forms.ComboBox cmbProductCategory;
        private System.Windows.Forms.Label lblProductCategory;
        private System.Windows.Forms.TextBox txtProductAmount;
        private System.Windows.Forms.Label lblProductAmount;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.Label lblProducts;
        private System.Windows.Forms.ListView liviewProducts;
        private System.Windows.Forms.ColumnHeader columnName;
        private System.Windows.Forms.ColumnHeader columnAmount;
        private System.Windows.Forms.ColumnHeader columnCategory;
        private System.Windows.Forms.ColumnHeader columnPrice;
        private System.Windows.Forms.Button btnAddCategory;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.TextBox txtCategory;
        private System.Windows.Forms.ListBox liboxCategories;
        private System.Windows.Forms.Label lblCategories;
        private System.Windows.Forms.Button btnDeleteCategory;
        private System.Windows.Forms.Button btnDeleteProduct;
    }
}