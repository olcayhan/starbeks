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
    public partial class SignupPage : Form
    {
        public SignupPage()
        {
            InitializeComponent();
        }

        private void SignBtn_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            string name = txtName.Text;
            string email = txtemail.Text;
            string password = txtpassword.Text;

            if (name == "" || email == "" || password == "")
            {
                MessageBox.Show("Please fill all the fields.");
            }
            else
            {
                User user = new User();
                user.Signup(rnd.Next(1000, 9999), name, email, Users.Client, password);
                MessageBox.Show("You have successfully signed up.");
                OrderPage orderPage = new OrderPage();
                orderPage.Show();
                this.Hide();
            }

            txtName.Text = "";
            txtemail.Text = "";
            txtpassword.Text = "";
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            Auth auth = new Auth();
            auth.Show();
            this.Hide();
        }


    }
}
