using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace VisualProgrammingProject
{
    public partial class checkoutPage : Form
    {
        Order order = new Order();
         
        public checkoutPage()
        {
            InitializeComponent();
            this.Activated += CheckoutPage_Activated;
        }

        private void CheckoutPage_Activated(object sender, EventArgs e)
        {
            UpdateNameList();
        }
        private void UpdateBillList()
        {
            lstviewFatura.Items.Clear();
            double TotalPrice = 0;
            if (lstVwName.SelectedItems.Count > 0)
            {
                foreach (OrderProduct product in order.getProducts(Convert.ToInt32(lstVwName.SelectedItems[0].Text)))
                {
                    TotalPrice += product.Price;
                    ListViewItem item = new ListViewItem(product.Name);
                    item.SubItems.Add(product.Piece.ToString());
                    item.SubItems.Add(product.Price.ToString());
                    lstviewFatura.Items.Add(item);
                }
            }

            txtPrice.Text = TotalPrice.ToString();
        }


        private void UpdateNameList()
        {
            lstVwName.Items.Clear();
            foreach (Order item in order.getReadyOrders())
            {
                ListViewItem listItem = new ListViewItem(item.ID.ToString());
                listItem.SubItems.Add(item.Name);
                lstVwName.Items.Add(listItem);
            }
            UpdateBillList();
        }
       
        private void lstVwName_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateBillList();
        }
        private void BtnPayAll_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtPrice.Text.Replace("₺", "").Trim(), out double total))
            {
                if (total > 0)
                {
                    int id = Convert.ToInt32(lstVwName.SelectedItems[0].Text);
                    Order newOrder = order.getOrder(id);
                    newOrder.PayOrder(newOrder);
                    txtPrice.Clear();
                }
                else MessageBox.Show("Bill was pay");
                UpdateNameList();
            }
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            Auth auth = new Auth();
            auth.Show();
            this.Close();
        }
    }
}
