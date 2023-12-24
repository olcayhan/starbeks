using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VisualProgrammingProject
{
    public partial class AdminPage : Form
    {
        Category category = new Category();
        Product product = new Product();
        public AdminPage()
        {
            InitializeComponent();
            this.Activated += AdminPage_Activated;
        }

        private void AdminPage_Activated(object sender, EventArgs e)
        {
            updateCategories();
            updateProducts();
        }

        public void updateCategories()
        {
            liboxCategories.Items.Clear();
            cmbProductCategory.Items.Clear();

            foreach (Category item in category.GetCategories())
            {
                liboxCategories.Items.Add(item.Name);
                cmbProductCategory.Items.Add(item.Name);
            }
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {

            if (txtCategory.Text == "")
            {
                MessageBox.Show("Type a category.");
            }
            else
            {
                Category newCategory = new Category(txtCategory.Text);
                category.AddCategory(newCategory);
                updateCategories();
            }

            txtCategory.Text = "";
        }

        public void updateProducts()
        {
            liviewProducts.Items.Clear();
            foreach (Product productItem in product.getProducts())
            {
                ListViewItem item = new ListViewItem(productItem.Name.ToString());
                item.SubItems.Add(productItem.Amount.ToString());
                item.SubItems.Add(productItem.Category.Name);
                item.SubItems.Add(productItem.Price.ToString());
                liviewProducts.Items.Add(item);
            }
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            if (txtProductName.Text == "" || txtProductAmount.Text == "" || cmbProductCategory.Text == "" || txtProductPrice.Text == "")
            {
                MessageBox.Show("Fill in the blanks");
            }
            else
            {
                Category newCategory = new Category(cmbProductCategory.Text);
                Product newProduct = new Product(txtProductName.Text, newCategory, Convert.ToInt32(txtProductAmount.Text), Convert.ToDouble(txtProductPrice.Text));
                newProduct.addProduct(newProduct);
                updateProducts();
            }

            txtProductName.Text = "";
            txtProductAmount.Text = "";
            cmbProductCategory.SelectedIndex = 0;
            txtProductPrice.Text = "";
        }

        private void btnDeleteCategory_Click(object sender, EventArgs e)
        {
            if (liboxCategories.SelectedIndex != -1)
            {
                category.GetCategories().RemoveAt(liboxCategories.SelectedIndex);
                updateCategories();
            }
            else
            {
                MessageBox.Show("Select a Category");
            }
        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            if (liviewProducts.SelectedItems.Count > 0)
            {
                foreach (int index in liviewProducts.SelectedIndices)
                {
                    product.getProducts().RemoveAt(index);
                }
                updateProducts();
            }
            else
            {
                MessageBox.Show("Select a Product");
            }
        }
    }
}
