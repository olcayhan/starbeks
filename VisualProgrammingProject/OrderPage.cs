using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace VisualProgrammingProject
{
    public partial class OrderPage : Form
    {
        public static List<OrderProduct> BasketList = new List<OrderProduct>();
       
        public OrderPage()
        {
            InitializeComponent();
        }

        private void OrderUpdate()
        {
            LstVwOrder.Items.Clear();

            double total = 0;
            foreach (OrderProduct coffee in BasketList)
            {
                total += coffee.Piece * coffee.Price;

                ListViewItem item = new ListViewItem(coffee.ID.ToString());
                item.SubItems.Add(coffee.Name.ToString());
                item.SubItems.Add(coffee.Piece.ToString());
                item.SubItems.Add((coffee.Piece * coffee.Price).ToString());
                LstVwOrder.Items.Add(item);
            }

            NumericPiece.Value = 0;
            txtTotal.Text = total.ToString();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (LstVwMenu.SelectedItems.Count > 0)
            {
                int productID = Convert.ToInt32(LstVwMenu.SelectedItems[0].Text);
                Product product1 = new Product().getProduct(productID);
                int piece = Convert.ToInt32(NumericPiece.Value);
                
                if (piece == 0)
                {
                    MessageBox.Show("Please take at least one piece.");
                    return;
                }
                
                OrderUpdate();
            }
            else
            {
                MessageBox.Show("Please Choose a Coffee");
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
        //    if (LstVwOrder.SelectedItems.Count == 0)
        //    {
        //        MessageBox.Show("Please Choose a Coffee");
        //        return;
        //    }

        //    foreach (ListViewItem selectedItem in LstVwOrder.SelectedItems)
        //    {
        //        string selectCoffee = selectedItem.Text;

        //        if (BasketList.ContainsKey(selectCoffee))
        //        {
        //            BasketList[selectCoffee]--;

        //            if (BasketList[selectCoffee] == 0)
        //            {
        //                BasketList.Remove(selectCoffee);
        //            }
        //        }
        //    }

        //    OrderUpdate();
        }

        private void cleanList()
        {
            BasketList.Clear();
            LstVwOrder.Items.Clear();
            txtTotal.Text = "";
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            cleanList();
        }

        private void orderbtn_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int orderID = rnd.Next(1000, 3000);
            Order newOrder = new Order(orderID, txtName.Text, DateTime.Now, Status.inQueue);

            if (txtName.Text == "") MessageBox.Show("Plase enter your name");
            else if (LstVwOrder.Items.Count > 0)
            {
                newOrder.addOrder(newOrder);

                foreach (ListViewItem item in LstVwOrder.Items)
                {
                    int productID = rnd.Next(1000, 3000);
                    OrderProduct newProduct = new OrderProduct(productID, item.Text, Convert.ToInt32(item.SubItems[2].Text), Convert.ToDouble(item.SubItems[1].Text), orderID);
                    newOrder.addProduct(newProduct);
                }
                //cleanList();
                MessageBox.Show("Your order has been received");
            }
            else MessageBox.Show("Plase select at least one product");
        }

        private void OrderPage_Load(object sender, EventArgs e)
        {

            foreach (Category item in new Category().GetCategories())
            {
                Button btn = new Button();
                btn.Text = item.Name;
                btn.Name = item.ID.ToString();
                btn.UseCompatibleTextRendering = true;
                btn.Width = 100;
                btn.Height = 100;
                btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
                btn.Click += Btn_Click;
                flowLayoutPanel.Controls.Add(btn);
            }


        }

        private void Btn_Click(object sender, EventArgs e)
        {
            LstVwMenu.Items.Clear();

            foreach (Product coffee in new Product().getProductsByCategory(Convert.ToInt32((sender as Button).Name)))
            {
                ListViewItem item = new ListViewItem(coffee.ID.ToString());
                item.SubItems.Add(coffee.Name);
                item.SubItems.Add(coffee.Price.ToString());
                LstVwMenu.Items.Add(item);
            }
        }
    }
}
