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
        public AdminPage()
        {
            InitializeComponent();
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            liboxCategories.Items.Add(txtCategory.Text);
            cmbProductCategory.Items.Add(txtCategory.Text);

            if(txtCategory.Text == "")
            {
                MessageBox.Show("Type a category.");
            }
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            if(txtProductName.Text == "" || txtProductAmount.Text == "")
            {
                MessageBox.Show("Fill in the blanks");
            }
            else if(cmbProductCategory.Text == "" || txtProductPrice.Text == "")
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
        }

        private void btnDeleteCategory_Click(object sender, EventArgs e)
        {
            if(liboxCategories.SelectedIndex != -1)
            {
                cmbProductCategory.Items.RemoveAt(liboxCategories.SelectedIndex);
                liboxCategories.Items.RemoveAt(liboxCategories.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Select a Category");
            }
        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            if(liviewProducts.SelectedItems.Count > 0)
            {
                foreach(ListViewItem item in liviewProducts.SelectedItems)
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
