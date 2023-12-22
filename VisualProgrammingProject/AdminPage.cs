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
        public AdminPage()
        {
            InitializeComponent();
            updateCategories();
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

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            if (txtProductName.Text == "" || txtProductAmount.Text == "" || cmbProductCategory.Text == "" || txtProductPrice.Text == "")
            {
                MessageBox.Show("Fill in the blanks");
            }
            else
            {

                ListViewItem item = new ListViewItem(txtProductName.Text);
                item.SubItems.Add(txtProductAmount.Text);
                item.SubItems.Add(cmbProductCategory.Text);
                item.SubItems.Add(txtProductPrice.Text);

                liviewProducts.Items.Add(item);


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
                foreach (ListViewItem item in liviewProducts.SelectedItems)
                {
                    liviewProducts.Items.Remove(item);
                }
            }
            else
            {
                MessageBox.Show("Select a Product");
            }
        }
    }
}
