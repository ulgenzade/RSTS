using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace RestoranOtomasyon
{
    public partial class frmOdemeEkrani : Form
    {
        private VeritabaniIslemleri db = new VeritabaniIslemleri();
        private int seciliMasaID = -1;
        private int aktifSiparisID = -1;
        private decimal anlikToplam = 0;

        public frmOdemeEkrani()
        {
            InitializeComponent();
        }

        private void frmOdemeEkrani_Load(object sender, EventArgs e)
        {
            MasalariYukle();
            this.btnAnaMenu.Click -= btnAnaMenu_Click;
            this.btnAnaMenu.Click += btnAnaMenu_Click;
        }

        private void MasalariYukle()
        {
            panelMasalar.Controls.Clear();
            DataTable masalar = db.MasalariGetir();
            foreach (DataRow row in masalar.Rows)
            {
                if (row["Durum"].ToString() == "Dolu")
                {
                    Button masaButonu = new Button();
                    masaButonu.Text = row["MasaAdi"].ToString();
                    masaButonu.Tag = row["MasaID"];
                    // Butonların tasarımını Designer dosyasındaki gibi yapabilirsin
                    masaButonu.Size = new Size(143, 110);
                    masaButonu.UseVisualStyleBackColor = true;
                    masaButonu.Click += MasaButonu_Click;
                    panelMasalar.Controls.Add(masaButonu);
                }
            }
        }

        private void MasaButonu_Click(object sender, EventArgs e)
        {
            Button tiklananButon = sender as Button;
            if (tiklananButon == null) return;

            seciliMasaID = Convert.ToInt32(tiklananButon.Tag);
            HesabiYukle(seciliMasaID);
        }

        private void HesabiYukle(int masaID)
        {
            listOzet.Items.Clear();
            anlikToplam = 0;
            aktifSiparisID = db.AktifSiparisIDGetir(masaID);

            if (aktifSiparisID == -1)
            {
                lblToplamTutar.Text = "Toplam: 0.00 TL";
                MessageBox.Show("Bu masanın aktif bir siparişi bulunamadı.", "Hata");
                return;
            }

            List<SiparisUrunModel> siparisDetaylari = db.MasaSiparisleriniGetir(masaID);

            foreach (var urun in siparisDetaylari)
            {
                listOzet.Items.Add($"{urun.Adet} x {urun.UrunAdi} - {urun.AraToplam:C2}");
                anlikToplam += urun.AraToplam;
            }
            lblToplamTutar.Text = $"Toplam: {anlikToplam:C2}";
        }

        private void btnOde_Click(object sender, EventArgs e)
        {
            if (listOzet.Items.Count > 0 && aktifSiparisID != -1)
            {
                
                
            }
            else
            {
                MessageBox.Show("Ödeme yapmak için lütfen hesabı olan bir masa seçin.", "Uyarı");
            }
        }

        private void btnVazgecOde_Click(object sender, EventArgs e)
        {
            listOzet.Items.Clear();
            anlikToplam = 0;
            lblToplamTutar.Text = "Toplam: 0.00 TL";
            seciliMasaID = -1;
            aktifSiparisID = -1;
        }

        private void IslemiBitir(string odemeTuru)
        {
            bool odemeSonuc = db.OdemeEkle(aktifSiparisID, odemeTuru, anlikToplam);
            bool hesapKapatmaSonuc = db.SiparisHesapKapat(aktifSiparisID, anlikToplam, "Ödendi");
            bool masaBosaltmaSonuc = db.MasaDurumGuncelle(seciliMasaID, "Boş");

            if (odemeSonuc && hesapKapatmaSonuc && masaBosaltmaSonuc)
            {
                MessageBox.Show($"Ödeme ({odemeTuru}) başarıyla tamamlandı!\nToplam Tutar: {anlikToplam:C2}");

                btnVazgecOde_Click(null, null);
                MasalariYukle();
            }
            else
            {
                MessageBox.Show("Ödeme veritabanına kaydedilirken bir hata oluştu.", "Veritabanı Hatası");
            }
        }

        private void btnNakitOde_Click(object sender, EventArgs e)
        {
            if (aktifSiparisID == -1) { return; }
            IslemiBitir("Nakit");
        }

        private void btnKartOde_Click(object sender, EventArgs e)
        {
            if (aktifSiparisID == -1) { return; }
            IslemiBitir("Kart");
        }

        private void btnOdemeIptal_Click(object sender, EventArgs e)
        {
            
        }

        // Ana menüye dönme veya formu kapatma işlevi
        private void btnAnaMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aaa1_Load(object sender, EventArgs e)
        {

        }
    }
}