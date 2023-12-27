using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace VisualProgrammingProject
{
    public partial class OrderPage : Form
    {
        private readonly Dictionary<string, List<string>> CoffeeType = new Dictionary<string, List<string>>
        {
            { "Hot Coffee", new List<string> { "Turkish coffee", "Espresso", "Americano" } },
            { "Cold Coffee", new List<string> { "Frappe", "Cold Brew", "Iced Latte" } },
            { "Milky Coffee", new List<string> { "Latte", "Cappuccino", "Macchiato" } }
        };

        private readonly Dictionary<string, double> CoffeePrice = new Dictionary<string, double>
        {
            { "Turkish coffee", 8.00 },
            { "Espresso", 10.00 },
            { "Americano", 12.00 },
            { "Frappe", 15.00 },
            { "Cold Brew", 14.00 },
            { "Iced Latte", 16.00 },
            { "Latte", 14.50 },
            { "Cappuccino", 16.50 },
            { "Macchiato", 15.50 }
        };

        private readonly Dictionary<string, int> OrderDetailing = new Dictionary<string, int>();

        public OrderPage()
        {
            InitializeComponent();
        }

        private void MenuUpdate(string coffeeType)
        {
            LstVwMenu.Items.Clear();

            foreach (var coffee in CoffeeType[coffeeType])
            {
                double price = CoffeePrice[coffee];

                ListViewItem item = new ListViewItem(coffee);
                item.SubItems.Add(price.ToString());
                LstVwMenu.Items.Add(item);
            }
        }

        private void OrderUpdate()
        {
            LstVwOrder.Items.Clear();

            double total = 0;

            foreach (var coffee in OrderDetailing)
            {
                string orderDet = coffee.Key;
                int orderPiece = coffee.Value;
                double coffeePrice = CoffeePrice[orderDet];
                total += orderPiece * coffeePrice;

                ListViewItem item = new ListViewItem(orderDet);
                item.SubItems.Add(orderPiece.ToString());
                item.SubItems.Add((orderPiece * coffeePrice).ToString());
                LstVwOrder.Items.Add(item);
            }

            NumericPiece.Value = 0;
            txtTotal.Text = total.ToString();
        }

        private void btnHot_Click(object sender, EventArgs e)
        {
            MenuUpdate("Hot Coffee");
        }

        private void BtnCold_Click(object sender, EventArgs e)
        {
            MenuUpdate("Cold Coffee");
        }

        private void BtnMilky_Click(object sender, EventArgs e)
        {
            MenuUpdate("Milky Coffee");
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (LstVwMenu.SelectedItems.Count > 0)
            {
                string chooseCoffee = LstVwMenu.SelectedItems[0].Text;
                int piece = Convert.ToInt32(NumericPiece.Value);

                if (piece == 0)
                {
                    MessageBox.Show("Please take at least one piece.");
                    return;
                }

                if (OrderDetailing.ContainsKey(chooseCoffee))
                {
                    OrderDetailing[chooseCoffee] += piece;
                }
                else
                {
                    OrderDetailing.Add(chooseCoffee, piece);
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
                string selectCoffee = selectedItem.Text;

                if (OrderDetailing.ContainsKey(selectCoffee))
                {
                    OrderDetailing[selectCoffee]--;

                    if (OrderDetailing[selectCoffee] == 0)
                    {
                        OrderDetailing.Remove(selectCoffee);
                    }
                }
            }

            OrderUpdate();
        }

        private void cleanList()
        {
            foreach (ListViewItem selectedItem in LstVwOrder.Items)
            {
                LstVwOrder.Items.Remove(selectedItem);

                string selectCoffee = selectedItem.Text;

                if (OrderDetailing.ContainsKey(selectCoffee))
                {
                    OrderDetailing.Remove(selectCoffee);
                }

                txtTotal.Text = "";
            }
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            cleanList();
        }

        private void orderbtn_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            Order newOrder = new Order(rnd.Next(1000, 3000), txtName.Text, DateTime.Now);



            if (txtName.Text == "") MessageBox.Show("Plase enter your name");
            else if (LstVwOrder.Items.Count > 0)
            {
                foreach (ListViewItem item in LstVwOrder.Items)
                {
                    OrderProduct newProduct = new OrderProduct(item.Text, Convert.ToDouble(item.SubItems[2].Text), Convert.ToInt32(item.SubItems[1].Text));
                    newOrder.addProduct(newProduct);
                }
                newOrder.addOrder(newOrder);
                cleanList();
                MessageBox.Show("Your order has been received");
            }
            else MessageBox.Show("Plase select at least one product");
        }
    }
}
