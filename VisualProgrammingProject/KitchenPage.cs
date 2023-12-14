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
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
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

        private void button1_Click_1(object sender, EventArgs e)
        {
            changeStatus("In Queue");
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            changeStatus("Preparing");
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            changeStatus("Ready");
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            ListViewItem item = new ListViewItem(txtName.Text);
            item.SubItems.Add(txtAmount.Text);
            item.SubItems.Add(txtDrink.Text);
            item.SubItems.Add("In Queue");

            liViewKitchen.Items.Add(item);
        }
    }
}
