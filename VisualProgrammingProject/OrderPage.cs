using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace VisualProgrammingProject
{
    public partial class OrderPage : Form
    {
        public static List<OrderProduct> BasketList = new List<OrderProduct>();
        User user = new User();

        public OrderPage(int userID)
        {
            InitializeComponent();
            user = user.getUser(userID);
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
                int piece = Convert.ToInt32(NumericPiece.Value);

                if (piece == 0)
                {
                    MessageBox.Show("Please take at least one piece.");
                    return;
                }

                OrderProduct product = BasketList.Find(x => x.ID == productID);
                if (product == null)
                {
                    Random rnd = new Random();
                    Product prd = new Product().getProduct(productID);
                    OrderProduct newProd = new OrderProduct(rnd.Next(10000, 99999), productID, prd.Name, piece, prd.Price, 0);
                    BasketList.Add(newProd);
                }
                else
                {
                    product.Piece += piece;
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
            if (LstVwOrder.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please Choose a Coffee");
                return;
            }

            foreach (ListViewItem selectedItem in LstVwOrder.SelectedItems)
            {
                OrderProduct prd = BasketList.Find(x => x.ID == Convert.ToInt32(selectedItem.Text));

                if (prd != null)
                {
                    prd.Piece -= 1;

                    if (prd.Piece == 0)
                    {
                        BasketList.Remove(prd);
                    }
                }
            }

            OrderUpdate();
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
            int orderID = rnd.Next(1000, 9999);
            Order newOrder = new Order(orderID, user.Name, DateTime.Now, Status.inQueue, user.ID);

            if (LstVwOrder.Items.Count > 0)
            {
                newOrder.addOrder(newOrder);

                foreach (OrderProduct product in BasketList)
                {
                    product.orderID = orderID;
                    newOrder.addProduct(product);
                }
                cleanList();
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
                btn.Click += getProducts;
                flowLayoutPanel.Controls.Add(btn);
            }


        }

        private void getProducts(object sender, EventArgs e)
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
