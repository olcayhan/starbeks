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
        private int sipId = 1000;
        DateTime selectedDatetime = DateTime.Now;
        public KitchenPage()
        {
            InitializeComponent();
        }
        public void UpdateListView(Dictionary<string, int> orderDetailing, Dictionary<string, double> coffeePrice)
        {

            string id = sipId.ToString();
            string name = "hakan";


            foreach (var cfe in orderDetailing)
            {
                string orderDet = cfe.Key;
                int orderPiece = cfe.Value;

                ListViewItem item = new ListViewItem(id);
                item.SubItems.Add(name);
                item.SubItems.Add(orderPiece.ToString());
                item.SubItems.Add(orderDet);
                item.SubItems.Add("In Queue");
                item.SubItems.Add(selectedDatetime.ToString());
                liViewKitchen.Items.Add(item);
            }
            sipId++;
        }
        public void changeStatus(string status)
        {
            foreach (ListViewItem items in liViewKitchen.SelectedItems)
            {
                items.SubItems[4].Text = status;
                items.SubItems[5].Text = DateTime.Now.ToString();             
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
    }
}
