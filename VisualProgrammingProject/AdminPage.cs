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
        Random rnd = new Random();

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
                Category newCategory = new Category(rnd.Next(100, 999), txtCategory.Text);
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
                ListViewItem item = new ListViewItem(productItem.ID.ToString());
                item.SubItems.Add(productItem.Name);
                item.SubItems.Add(productItem.Category.Name);
                item.SubItems.Add(productItem.Price.ToString());
                liviewProducts.Items.Add(item);
            }
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            if (txtProductName.Text == "" || cmbProductCategory.SelectedIndex == -1 || txtProductPrice.Text == "")
            {
                MessageBox.Show("Fill in the blanks");
            }
            else
            {
                Category newCategory = category.getCategory(cmbProductCategory.SelectedItem.ToString());
                Product newProduct = new Product(rnd.Next(1000, 9999), txtProductName.Text, newCategory,  Convert.ToDouble(txtProductPrice.Text));
                newProduct.addProduct(newProduct);
                updateProducts();
            }

            txtProductName.Text = "";
            cmbProductCategory.SelectedIndex = -1;
            txtProductPrice.Text = "";
        }

        private void btnDeleteCategory_Click(object sender, EventArgs e)
        {
            if (liboxCategories.SelectedIndex != -1)
            {
                category.removeCategory(category.getCategory(liboxCategories.SelectedItem.ToString()));
                updateCategories();
                updateProducts();
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
                foreach (ListViewItem item in liviewProducts.SelectedItems)
                    product.removeProduct(product.getProduct(Convert.ToInt32(item.Text)));
                updateProducts();
            }
            else
                MessageBox.Show("Select a Product");
        }
    }
}
