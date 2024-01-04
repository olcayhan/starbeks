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
            lblOrderIDResponse.Text = order.ID.ToString();
            lblNameresponse.Text = order.Name;
            lblStatusResponse.Text = order.Status.ToString();

            foreach (OrderProduct product in order.getProducts(order.ID))
            {
                ListViewItem item = new ListViewItem(product.Name.ToString());
                item.SubItems.Add(product.Piece.ToString());
                item.SubItems.Add(product.Price.ToString());
                listView1.Items.Add(item);
            }
        }
    }
}
