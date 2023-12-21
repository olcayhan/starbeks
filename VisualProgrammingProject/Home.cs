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
    public partial class Home : System.Windows.Forms.Form
    {
        KitchenPage kitchenForm = new KitchenPage();
        OrderPage orderForm = new OrderPage();
        checkoutPage checkoutForm = new checkoutPage();
        AdminPage adminForm = new AdminPage();
        public Home()
        {
            InitializeComponent();
            
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            orderForm.Show();
            kitchenForm.Hide();
            checkoutForm.Hide();
            adminForm.Hide();
        }

        private void btnKitchen_Click(object sender, EventArgs e)
        {
            kitchenForm.Show();
            adminForm.Hide();
            orderForm.Hide();
            checkoutForm.Hide();
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            checkoutForm.Show();
            adminForm.Hide();
            orderForm.Hide();
            kitchenForm.Hide();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            adminForm.Show();
            orderForm.Hide();
            kitchenForm.Hide();
            checkoutForm.Hide();
        }
    }
}
