using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace VisualProgrammingProject
{
    public partial class Auth : Form
    {
        public Auth()
        {
            InitializeComponent();
        }
        private void LogBtn_Click(object sender, EventArgs e)
        {
            string email = txtemail.Text;
            string password = txtpassword.Text;


            if(email == "" || password == "")
            {
                MessageBox.Show("Please fill all the fields.");
            }
            else
            {
                User user = new User().Auth(email, password);
                if(user.Role == Users.Admin)
                {
                    AdminPage admin = new AdminPage();
                    admin.Show();
                    this.Hide();
                }
                else if(user.Role == Users.Client)
                {
                    OrderPage client = new OrderPage();
                    client.Show();
                    this.Hide();
                }
                else if(user.Role == Users.Waiter)
                {
                    KitchenPage waiter = new KitchenPage();
                    waiter.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid email or password");
                }
            }
        }

        private void signupBtn_Click(object sender, EventArgs e)
        {
            SignupPage signup = new SignupPage();
            signup.Show();
            this.Hide();
        }
    }
}
