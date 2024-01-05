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

        private void oldListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void NameLbl_Click(object sender, EventArgs e)
        {

        }

        private void activeListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void orderBtn_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
