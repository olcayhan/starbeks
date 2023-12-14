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
    public partial class Form1 : Form
    {
        public Form1()
        {
         
               
            

            


            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void liViewKitchen_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        public void button4_Click(object sender, EventArgs e)
        {
            ListViewItem item = new ListViewItem(txtName.Text);
            item.SubItems.Add(txtAmount.Text);
            item.SubItems.Add(txtDrink.Text);
            item.SubItems.Add("In Queue");

            liViewKitchen.Items.Add(item);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            changeStatus("In Queue");
        }

        

        private void button3_Click(object sender, EventArgs e)
        {
            changeStatus("Preparing");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            changeStatus("Ready");
        }
        public void changeStatus(string status)
        {
            foreach (ListViewItem items in liViewKitchen.SelectedItems)
            {
                items.SubItems[3].Text = status;
            }
        }
    }
}
