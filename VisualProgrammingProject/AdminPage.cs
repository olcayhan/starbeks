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
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            ListViewItem item = new ListViewItem(txtProductName.Text);
            item.SubItems.Add(txtProductAmount.Text);
            item.SubItems.Add(cmbProductCategory.Text);
            item.SubItems.Add(txtProductPrice.Text);

            liviewProducts.Items.Add(item);
        }

        
    }
}
