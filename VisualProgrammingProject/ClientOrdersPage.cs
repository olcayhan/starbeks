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
    public partial class ClientOrdersPage : Form
    {
        int userID;
        OrderStatus orderStatus;
        public ClientOrdersPage(int ID, OrderStatus status)
        {
            InitializeComponent();
            userID =ID;   
            orderStatus = status;
        }

        private void orderDetailsBtn_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                OrderDetails orderDetails = new OrderDetails(Convert.ToInt32(listView1.SelectedItems[0].Text));
                orderDetails.Show();
            }
            else
            {
                MessageBox.Show("Please select an order to view details");
            }
        }

        private void ClientOrdersPage_Load(object sender, EventArgs e)
        {
            if (orderStatus == OrderStatus.Active)
            {

                foreach (Order order in new Order().getActiveOrders(userID))
                {
                    ListViewItem item = new ListViewItem(order.ID.ToString());
                    item.SubItems.Add(order.Name.ToString());
                    item.SubItems.Add(order.Status.ToString());
                    item.SubItems.Add(order.Time.ToString());
                    listView1.Items.Add(item);
                }
            }
            else if (orderStatus == OrderStatus.Completed)
            {

                foreach (Order order in new Order().getCompletedOrders(userID))
                {
                    ListViewItem item = new ListViewItem(order.ID.ToString());
                    item.SubItems.Add(order.Name.ToString());
                    item.SubItems.Add(order.Status.ToString());
                    item.SubItems.Add(order.Time.ToString());
                    listView1.Items.Add(item);
                }
            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            ClientPage clientPage = new ClientPage(userID);
            clientPage.Show();
            this.Close();
        }
    }
}
