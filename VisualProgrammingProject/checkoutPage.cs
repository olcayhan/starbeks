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
        private void CalculateBill()
        {
            if (lstviewFatura.SelectedItems.Count > 0) txtChoose.Text = lstviewFatura.SelectedItems[0].SubItems[2].Text;
            else MessageBox.Show("Choose a Bill");
        }

        private void lstviewFatura_MouseClick(object sender, MouseEventArgs e)
        {
            CalculateBill();
        }

        private void lstVwName_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateBillList();
        }

        private void BtnPay_Click(object sender, EventArgs e)
        {
            CalculateBill();
            string BillPay = txtChoose.Text;

            if (double.TryParse(txtPrice.Text, out double currentBillPrice) &&
               double.TryParse(BillPay, out double paymentAmount))
            {
                if (lstviewFatura.SelectedItems.Count > 0)
                {
                    int id = Convert.ToInt32(lstVwName.SelectedItems[0].Text);
                    double UpdateBillPrice = currentBillPrice - paymentAmount;
                    Order newOrder = order.getOrder(id);

                    //newOrder.removeProduct(newOrder.orderDetails[lstviewFatura.SelectedIndices[0]]);
                    txtPrice.Text = UpdateBillPrice.ToString();
                    txtChoose.Clear();

                    //if (newOrder.orderDetails.Count == 0)
                    //{
                    //    newOrder.removeOrder(newOrder);
                    //    updateNameList();
                    //}
                }
                UpdateBillList();
            }
        }
        private void BtnPayAll_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtPrice.Text.Replace("₺", "").Trim(), out double total))
            {
                if (total > 0)
                {
                    int id = Convert.ToInt32(lstVwName.SelectedItems[0].Text);
                    Order newOrder = order.getOrder(id);
                    newOrder.removeOrder(newOrder);
                    txtPrice.Clear();
                    txtChoose.Clear();
                }
                else MessageBox.Show("Bill was pay");
                UpdateNameList();
            }
        }
    }
}
