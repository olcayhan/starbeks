using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace VisualProgrammingProject
{
    public partial class checkoutPage : Form
    {
        Order order = new Order();
        public checkoutPage()
        {
            InitializeComponent();
            this.Activated += CheckoutPage_Activated; ;
        }

        private void CheckoutPage_Activated(object sender, EventArgs e)
        {
            updateNameList();
        }

        private void updateNameList()
        {
            lstVwName.Items.Clear();
            foreach (Order item in order.getOrders())
            {
                ListViewItem listItem = new ListViewItem(item.orderID.ToString());
                listItem.SubItems.Add(item.orderName);
                lstVwName.Items.Add(listItem);
            }
        }

        private void btnOde_Click(object sender, EventArgs e)
        {
            updateNameList();

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

        private void lstVwName_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstviewFatura.Items.Clear();
            double toplamfiyat = 0;

            if (lstVwName.SelectedItems.Count > 0)
            {
                foreach (var product in order.getOrders()[lstVwName.SelectedIndices[0]].orderDetails)
                {
                    string cfename = product.productName;
                    double cfepiece = product.productPiece;
                    double cfeprice = product.productPrice;
                    toplamfiyat += cfeprice * cfepiece;

                    ListViewItem item = new ListViewItem(cfename);
                    item.SubItems.Add(cfepiece.ToString());
                    item.SubItems.Add((cfeprice * cfepiece).ToString("C"));

                    lstviewFatura.Items.Add(item);
                }
            }

            txtPrice.Text = toplamfiyat.ToString("C");
        }
    }
}
