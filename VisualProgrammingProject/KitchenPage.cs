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
    public partial class KitchenPage : System.Windows.Forms.Form
    {
        public KitchenPage()
        {
            InitializeComponent();
        }

        
        public void changeStatus(string status)
        {
            foreach (ListViewItem items in liViewKitchen.SelectedItems)
            {
                items.SubItems[3].Text = status;
            }
        }
        private void btnQueue_Click(object sender, EventArgs e)
        {
            
            if (liViewKitchen.SelectedItems.Count > 0)
            {
                changeStatus("In Queue");
                liViewKitchen.SelectedItems[0].BackColor = Color.IndianRed;
            }
            else
            {
                MessageBox.Show("Please select a row.");
            }
        }

        private void btnPrepare_Click(object sender, EventArgs e)
        {
            
            if (liViewKitchen.SelectedItems.Count > 0)
            {
                changeStatus("Preparing");
                liViewKitchen.SelectedItems[0].BackColor = Color.LightYellow;
            }
            else
            {
                MessageBox.Show("Please select a row.");
            }
        }

        private void btnReady_Click(object sender, EventArgs e)
        {
           
            if (liViewKitchen.SelectedItems.Count > 0)
            {
                changeStatus("Ready");
                liViewKitchen.SelectedItems[0].BackColor = Color.LightSeaGreen;

            }
            else
            {
                MessageBox.Show("Please select a row.");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ListViewItem item = new ListViewItem(txtName.Text);
            item.SubItems.Add(txtAmount.Text);
            item.SubItems.Add(txtDrink.Text);
            item.SubItems.Add("In Queue");
            item.BackColor = Color.IndianRed;

            liViewKitchen.Items.Add(item);
        }
    }
}
