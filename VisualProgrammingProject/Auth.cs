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
        private bool Valid(string Email, string Password)
        {
            return Email == "admin" && Password == "password";
        }
        private void LogBtn_Click(object sender, EventArgs e)
        {
            string email = txtemail.Text;
            string password = txtpassword.Text;

            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("E-mail and password cannot be empty. Please fill in all fields.");
            }
            else
            {
                if (Valid(email, password))
                {
                    MessageBox.Show("Login Succesful");
                }
                else
                {
                    MessageBox.Show("Unvalid password and E-mail, Please Try Again");
                }
            }
        }
    }
}
