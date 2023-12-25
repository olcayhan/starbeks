using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VisualProgrammingProject
{
    public partial class KitchenPage : System.Windows.Forms.Form
    {
        Order order = new Order();
        public KitchenPage()
        {
            InitializeComponent();
            this.Activated += KitchenPage_Activated; ;
        }

        private void KitchenPage_Activated(object sender, EventArgs e)
        {
            UpdateListView();
        }
        public void UpdateListView()
        {
            liViewKitchen.Items.Clear();
            foreach (Order order in order.getOrders())
            {
                ListViewItem item = new ListViewItem(order.orderID.ToString());
                item.SubItems.Add(order.orderName);
                item.SubItems.Add("35");
                item.SubItems.Add("Çay");
                item.SubItems.Add(order.orderStatus.ToString());
                item.SubItems.Add(order.orderTime.ToString());
                if(order.orderStatus == Status.inQueue) item.BackColor = Color.IndianRed;
                else if(order.orderStatus == Status.Preparing) item.BackColor = Color.LightYellow;
                else item.BackColor = Color.LightSeaGreen;

                liViewKitchen.Items.Add(item);
            }
        }
        public void changeStatus(Status status)
        {
            if (liViewKitchen.SelectedItems.Count > 0)
            {
                foreach (ListViewItem listItem in liViewKitchen.SelectedItems)
                {
                    Order newOrder = order.getOrders().Find(item => item.orderID.ToString() == listItem.Text);
                    newOrder.orderStatus = status;
                    newOrder.orderTime = DateTime.Now;
                }
                UpdateListView();
            }
            else
            {
                MessageBox.Show("Please select a row.");
            }
        }
        private void btnQueue_Click(object sender, EventArgs e)
        {
                changeStatus(Status.inQueue);
        }
        private void btnPrepare_Click(object sender, EventArgs e)
        {
                changeStatus(Status.Preparing);
        }
        private void btnReady_Click(object sender, EventArgs e)
        {
                changeStatus(Status.Ready);
        }

        private void liViewKitchen_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(liViewKitchen.SelectedItems.Count > 0){
                Order newOrder = order.getOrders().Find(item => item.orderID == Convert.ToInt32(liViewKitchen.SelectedItems[0].Text)); 

                OrderDetails orderDetailsForm = new OrderDetails(newOrder);
                orderDetailsForm.ShowDialog();
            }

            
        }
    }
}
