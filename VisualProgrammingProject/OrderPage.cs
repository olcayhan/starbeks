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
    public partial class OrderPage : Form
    {
        Dictionary<string, List<string>> CoffeeType = new Dictionary<string, List<string>>
        {
            { "Hot Coffee", new List<string> { "Turkish coffee", "Espresso", "Americano" } },
            { "Cold Coffee", new List<string> { "Frappe", "Cold Brew", "Iced Latte" } },
            { "Milky Coffee", new List<string> { "Latte", "Cappuccino", "Macchiato" } }
        };

        Dictionary<string, double> CoffeePrice = new Dictionary<string, double>
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

        Dictionary<string, int> OrderDetailing = new Dictionary<string, int>();

        public OrderPage()
        {
            InitializeComponent();
        }
        private void MenuUpdate(string cofetype)
        {
            LstVwMenu.Items.Clear();

            foreach (var Cfe in CoffeeType[cofetype])
            {
                string coffeename = Cfe;
                double price = CoffeePrice[coffeename];

                ListViewItem item = new ListViewItem(coffeename);
                item.SubItems.Add(price.ToString("C"));
                LstVwMenu.Items.Add(item);
            }
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
                string ChooseCfe = LstVwMenu.SelectedItems[0].Text;
                int piece = Convert.ToInt32(NumericPiece.Value);

                if (piece == 0)
                {
                    MessageBox.Show("Please take a piece.");
                    return;
                }
                if(OrderDetailing.ContainsKey(ChooseCfe))
                {
                    OrderDetailing[ChooseCfe] += piece;
                }
                else
                {
                    OrderDetailing.Add(ChooseCfe, piece);
                }

                LstVwOrder.Items.Clear();

                double Total = 0;
                
                foreach (var Cfe in OrderDetailing) 
                {
                    string orderdet = Cfe.Key;
                    int orderpiece = Cfe.Value;
                    double cfeprice = CoffeePrice[orderdet];
                    Total += orderpiece*cfeprice;

                    ListViewItem item = new ListViewItem(orderdet);
                    item.SubItems.Add(orderpiece.ToString());
                    item.SubItems.Add((orderpiece * cfeprice).ToString("C"));
                    LstVwOrder.Items.Add(item);
                }
                NumericPiece.Value = 0;
                txtTotal.Text = Total.ToString("C");

            }
            else
            {
                MessageBox.Show("Please Choose a Coffee");
            }
        }
    }
}
