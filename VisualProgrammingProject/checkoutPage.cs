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
    public partial class checkoutPage : Form
    {

        Dictionary<string, List<string>> kahveTurleri = new Dictionary<string, List<string>>
        {
            { "Sıcak Kahve", new List<string> { "Türk Kahvesi", "Espresso", "Americano" } },
            { "Soğuk Kahve", new List<string> { "Frappe", "Cold Brew", "Iced Latte" } },
            { "Sütlü Kahve", new List<string> { "Latte", "Cappuccino", "Macchiato" } }
        };

        Dictionary<string, double> kahveFiyatlari = new Dictionary<string, double>
        {
            { "Türk Kahvesi", 8.00 },
            { "Espresso", 10.00 },
            { "Americano", 12.00 },
            { "Frappe", 15.00 },
            { "Cold Brew", 14.00 },
            { "Iced Latte", 16.00 },
            { "Latte", 14.50 },
            { "Cappuccino", 16.50 },
            { "Macchiato", 15.50 }
        };

        Dictionary<string, int> FaturaPage = new Dictionary<string, int>();

        public checkoutPage()
        {
            InitializeComponent();
        }
        private void updateFatura()
        {
            lstviewFatura.Items.Clear();
            double toplamfiyat = 0;

            foreach (var Cfe in FaturaPage)
            {
                string cfename = Cfe.Key;
                int cfepiece = Cfe.Value;
                double cfeprice = kahveFiyatlari[cfename];
                toplamfiyat += cfeprice * cfeprice;
                ListViewItem item = new ListViewItem(cfename);
                item.SubItems.Add(cfepiece.ToString());
                item.SubItems.Add((cfeprice * cfepiece).ToString("C"));

            }
            txtPrice.Text = toplamfiyat.ToString();

        }



        private void btnOde_Click(object sender, EventArgs e)
        {
            int fiyat = Convert.ToInt32(txtPrice.Text);
            if(fiyat > 0) 
            {
                    
            }
            else
            {
                MessageBox.Show("Hesap Ödenmiş");
            }
        }
    }
}
