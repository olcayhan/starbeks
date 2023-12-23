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


        public void hideForms()
        {
            adminForm.Hide();
            orderForm.Hide();
            kitchenForm.Hide();
            checkoutForm.Hide();
        }

        private void Form_Closing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            hideForms();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            orderForm.FormClosing += Form_Closing;
            handleClose(orderForm);
        }

 
        private void btnKitchen_Click(object sender, EventArgs e)
        {
            kitchenForm.FormClosing += Form_Closing;
            handleClose(kitchenForm);
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            checkoutForm.FormClosing += Form_Closing;
            handleClose(checkoutForm);
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            adminForm.FormClosing += Form_Closing;
            handleClose(adminForm);   
        }

        private void handleClose(Form newForm)
        {
            hideForms();
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
