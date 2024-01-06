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
    public enum OrderStatus
    {
        Active,
        Completed
    }

    public partial class ClientPage : Form
    {
    
        User user = new User();

        public ClientPage(int userID)
        {
            InitializeComponent();
            user = user.getUser(userID);
        }

        private void ClientPage_Load(object sender, EventArgs e)
        {
            NameLbl.Text = user.Name;
        }

        private void orderBtn_Click(object sender, EventArgs e)
        {
            OrderPage order = new OrderPage(user.ID);
            order.Show();
            this.Close();
        }

        private void activeOrderBtn_Click(object sender, EventArgs e)
        {
            ClientOrdersPage orders = new ClientOrdersPage(user.ID,OrderStatus.Active);
            orders.Show();
            this.Close();
        }

        private void oldOrdersBtn_Click(object sender, EventArgs e)
        {
            ClientOrdersPage orders = new ClientOrdersPage(user.ID, OrderStatus.Completed);
            orders.Show();
            this.Close();
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            Auth auth = new Auth();
            auth.Show();
            this.Close();
        }
    }
}
