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
    public partial class OrderDetails : Form
    {
        public OrderDetails(Order order)
        {
            InitializeComponent();
            lblOrderIDResponse.Text = order.orderID.ToString();
            lblNameresponse.Text = order.orderName;
            lblStatusResponse.Text = order.orderStatus.ToString();

            foreach (OrderProduct product in order.getProducts(order.orderID))
            {
                ListViewItem item = new ListViewItem(product.Name.ToString());
                item.SubItems.Add(product.Piece.ToString());
                item.SubItems.Add(product.Price.ToString());
                listView1.Items.Add(item);
            }
        }
    }
}
