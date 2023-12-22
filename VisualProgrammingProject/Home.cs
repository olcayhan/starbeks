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
            this.FormClosing += Home_FormClosing;
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            OrderPage orderForm = new OrderPage();
            handleClose(orderForm);
        }


        private void btnKitchen_Click(object sender, EventArgs e)
        {
            KitchenPage kitchenForm = new KitchenPage();
            handleClose(kitchenForm);
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        { 
            checkoutPage checkoutForm = new checkoutPage();
            handleClose(checkoutForm);
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            AdminPage adminForm = new AdminPage();
            handleClose(adminForm);   
        }

        private void handleClose(Form newForm)
        {
            KitchenPage kitchenForm = new KitchenPage();
            OrderPage orderForm = new OrderPage();
            checkoutPage checkoutForm = new checkoutPage();
            AdminPage adminForm = new AdminPage();

            adminForm.Hide();
            orderForm.Hide();
            kitchenForm.Hide();
            checkoutForm.Hide();

            newForm.Show();

        }

        private void Home_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Formu kapatmak istediğinizden emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.No)
            {    
                e.Cancel = true;
            }
            
        }
    }
}
