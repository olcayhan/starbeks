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

            foreach (var product in order.orderDetails)
            {
                ListViewItem item = new ListViewItem(product.productName.ToString());
                item.SubItems.Add(product.productPiece.ToString());
                item.SubItems.Add(product.productPrice.ToString());
                listView1.Items.Add(item);
                
            }
        }
    }
}
