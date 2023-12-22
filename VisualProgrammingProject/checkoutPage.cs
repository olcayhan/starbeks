using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace VisualProgrammingProject
{
    public partial class checkoutPage : Form
    {
        Dictionary<string, double> IdName = new Dictionary<string, double>()
        {
            { "hakan", 1000  },
            { "olcay", 1001 },
            { "ismail",1002  }
        };

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
        private void updateNameList()
        {
            lstVwName.Items.Clear();
            foreach (var OrderName in  IdName)
            {
                string name = OrderName.Key;
                double id = OrderName.Value;
                
                ListViewItem item = new ListViewItem(id.ToString());
                item.SubItems.Add(name);
                lstVwName.Items.Add(item);
            }
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
            updateNameList();
        }

        double toplamFiyat = 0;

        private void HesaplaVeYazdir()
        {
            ListViewItem selectedRow = lstviewFatura.SelectedItems[0];
            string fiyatSutunu = selectedRow.SubItems[2].Text;

            int sayi = DegeriAl(fiyatSutunu);
            toplamFiyat += sayi*1.00;
            txtSecilen.Text = toplamFiyat.ToString("C");
        }
        static int DegeriAl(string metinselIfade)
        {
            // Sayıyı almak için Regex kullanalım
            Match match = Regex.Match(metinselIfade, @"\d+");

            if (match.Success)
            {
                return int.Parse(match.Value);
            }

            return -1;
        }
        private void btnÖde_Click(object sender, EventArgs e)
        {
            HesaplaVeYazdir();
            string textBoxText = txtSecilen.Text;

            if (!string.IsNullOrEmpty(textBoxText))
            {
                MessageBox.Show(textBoxText, "TextBox Değer");

                txtSecilen.Clear();
            }
            else
            {
                MessageBox.Show("TextBox boş. Lütfen bir sayı girin.");
            }
        }

        private void lstviewFatura_MouseClick(object sender, MouseEventArgs e)
        {
            HesaplaVeYazdir();
        }
    }
}
