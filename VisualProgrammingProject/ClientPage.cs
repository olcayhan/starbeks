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
    }
}
