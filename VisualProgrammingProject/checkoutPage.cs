using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace VisualProgrammingProject
{
    public partial class checkoutPage : Form
    {
        Dictionary<string, double> CfeFiyat = new Dictionary<string, double>
        {
            { "Türk Kahvesi", 8.00 },
            { "Espresso", 10.00 },
            { "Americano", 12.00 }
        };

        Dictionary<string, int> FaturaPage = new Dictionary<string, int>();

        public checkoutPage()
        {
            InitializeComponent();
            checkoutPage_Load(this, EventArgs.Empty);
        }

        private void updateFatura()
        {
            lstviewFatura.Items.Clear();
            double toplamfiyat = 0;

            foreach (var Cfe in CfeFiyat)
            {
                Random  rnd = new Random();
                string cfename = Cfe.Key;
                double cfepiece = rnd.Next(3,7);
                double cfeprice = CfeFiyat[cfename];
                toplamfiyat += cfeprice * cfepiece;

                ListViewItem item = new ListViewItem(cfename);
                item.SubItems.Add(cfepiece.ToString());
                item.SubItems.Add((cfeprice * cfepiece).ToString("C"));

                lstviewFatura.Items.Add(item);
            }
            txtPrice.Text = toplamfiyat.ToString("C");
        }

        private void btnOde_Click(object sender, EventArgs e)
        {
         
            double tutar;

            if (double.TryParse(txtPrice.Text.Replace("₺", "").Trim(), out tutar))
            {
                if (tutar > 0)
                {
                    string message = "Toplam Tutar: " + tutar.ToString("C") + "\n\n";

                    if (!string.IsNullOrEmpty(message))
                    {
                        MessageBox.Show(message, "Hesap Ödeme İşlemi");
                        txtPrice.Text = "₺0.00";
                    }
                }
                else
                {
                    MessageBox.Show("hesap ödenmiş");
                }
            }
        }
        private void checkoutPage_Load(object sender, EventArgs e)
        {
            updateFatura();
        }
    }
}
