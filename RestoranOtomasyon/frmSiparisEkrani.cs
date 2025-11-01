using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestoranOtomasyon
{
    public partial class frmSiparisEkrani : Form
    {
        // --- YENİ EKLENDİ ---
        // Hangi masaya tıklandığını formun her yerinden erişebilmek için
        // bu değişkeni sınıf seviyesinde tanımlıyoruz.
        private int seciliMasaNumarasi = -1;

        public frmSiparisEkrani()
        {
            InitializeComponent();
        }

        private void frmSiparisEkrani_Load(object sender, EventArgs e)
        {
            for (int i = 1; i <= 6; i++)
            {
                Button masaButonu = new Button();
                masaButonu.Text = "MASA - " + i;
                masaButonu.Name = "btnMasa" + i;
                masaButonu.Size = new Size(150, 100);
                masaButonu.Margin = new Padding(10);
                masaButonu.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
                masaButonu.Tag = i;
                masaButonu.Click += new EventHandler(MasaButonu_Click);
                flowMasalar.Controls.Add(masaButonu);
               
            }
        }

        private void MasaButonu_Click(object sender, EventArgs e)
        {
            Button tiklananMasaButonu = sender as Button;
            if (tiklananMasaButonu == null) return;

            // --- DEĞİŞİKLİK ---
            // Tıklanan masanın numarasını hafızaya alıyoruz.
            seciliMasaNumarasi = Convert.ToInt32(tiklananMasaButonu.Tag);

            panelSiparis.Visible = true;
            panelSiparisListesi.Controls.Clear();

            // ... (Sahte ürün oluşturma kodları aynı kalıyor) ...
            List<string> urunler = new List<string>();
            if (seciliMasaNumarasi == 1)
            {
                urunler.Add("Adana Kebap");
                urunler.Add("Ayran");
            }
            else
            {
                urunler.Add("Çorba");
                urunler.Add("İskender");
            }

            foreach (string urunAdi in urunler)
            {
                Panel urunSatiriPaneli = new Panel();
                urunSatiriPaneli.Size = new Size(panelSiparisListesi.Width - 25, 40);
                urunSatiriPaneli.BorderStyle = BorderStyle.FixedSingle;
                urunSatiriPaneli.Dock = DockStyle.Top;
                Label lblUrunAdi = new Label();
                lblUrunAdi.Text = urunAdi;
                lblUrunAdi.Location = new Point(10, 10);
                lblUrunAdi.AutoSize = true;
                urunSatiriPaneli.Controls.Add(lblUrunAdi);
                panelSiparisListesi.Controls.Add(urunSatiriPaneli);
            }
        }

        // --- YENİ EKLENEN BUTONUN OLAYI ---
        private void btnOdeme_Click(object sender, EventArgs e)
        {
            // Ödeme ekranından bir nesne oluşturuyoruz
            frmOdemeEkrani odemeFormu = new frmOdemeEkrani();

            // Yeni formu açıyoruz
            odemeFormu.Show();
        }


        // --- DİĞER METOTLAR ---
        private void panelSiparis_Paint(object sender, PaintEventArgs e) { }
        private void btnOrnekMasa_Click(object sender, EventArgs e) { }
        private void lblGarsonAdi_Click(object sender, EventArgs e) { }

        private void flowMasalar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnOrnekMasa_Click_1(object sender, EventArgs e)
        {

        }

        private void panelSiparisListesi_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}