using RestoranOtomasyon;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace RestoranOtomasyon
{
    public partial class frmOdemeEkrani : Form
    {
        VeritabaniIslemleri db = new VeritabaniIslemleri();

        int seciliMasaID = -1;
        int aktifSiparisID = -1;
        decimal toplamMasaTutari = 0;

        // Veri Listeleri
        List<SiparisUrunModel> solListeVerileri = new List<SiparisUrunModel>(); // Kalanlar
        List<SiparisUrunModel> sagListeVerileri = new List<SiparisUrunModel>(); // Ödenecekler

        // Seçim Listeleri
        List<SiparisUrunModel> solSecilenler = new List<SiparisUrunModel>();
        List<SiparisUrunModel> sagSecilenler = new List<SiparisUrunModel>();

        public frmOdemeEkrani(int masaID)
        {
            InitializeComponent();
            this.seciliMasaID = masaID;
        }

        public frmOdemeEkrani() { InitializeComponent(); }

        private void frmOdemeEkrani_Load(object sender, EventArgs e)
        {
            if (seciliMasaID != -1)
            {
                Control[] labels = Controls.Find("labelMasaBilgi", true);
                if (labels.Length > 0) labels[0].Text = "MASA " + seciliMasaID;
                HesabiGetir();
            }
        }

        private void HesabiGetir()
        {
            aktifSiparisID = db.AktifSiparisIDGetir(seciliMasaID);
            if (aktifSiparisID == -1)
            {
                MessageBox.Show("Bu masada aktif sipariş bulunamadı!");
                this.Close();
                return;
            }
            solListeVerileri = db.MasaSiparisleriniGetir(seciliMasaID);
            EkranlariCiz();
        }

        private void EkranlariCiz()
        {
            // --- SOL TARAFI ÇİZ ---
            flowTumSiparisler.Controls.Clear();
            toplamMasaTutari = 0;

            foreach (var urun in solListeVerileri)
            {
                toplamMasaTutari += urun.AraToplam;
                Button btn = KartOlustur(urun, SolUrun_Click);
                if (solSecilenler.Contains(urun)) btn.BackColor = Color.DarkOrange;
                flowTumSiparisler.Controls.Add(btn);
            }

            Control[] lblSol = Controls.Find("labelToplamTutar", true);
            if (lblSol.Length > 0) lblSol[0].Text = $"{toplamMasaTutari:C2}";

            // --- SAĞ TARAFI ÇİZ ---
            panelOdenecekler.Controls.Clear();
            decimal odenecekTutar = 0;

            foreach (var urun in sagListeVerileri)
            {
                odenecekTutar += urun.AraToplam;
                Button btn = KartOlustur(urun, SagUrun_Click);
                if (sagSecilenler.Contains(urun)) btn.BackColor = Color.DarkOrange;
                panelOdenecekler.Controls.Add(btn);
            }

            Control[] lblSag = Controls.Find("labelOdenecekTutar", true);
            if (lblSag.Length > 0) lblSag[0].Text = $"{odenecekTutar:C2}";
        }

        private Button KartOlustur(SiparisUrunModel urun, EventHandler tiklamaOlayi)
        {
            Button btn = new Button();
            btn.Text = $"{urun.Adet}x {urun.UrunAdi}\n{urun.AraToplam:C2}";
            btn.Size = new Size(130, 70);
            btn.FlatStyle = FlatStyle.Flat;
            btn.BackColor = Color.WhiteSmoke;
            btn.Tag = urun;
            btn.Click += tiklamaOlayi;
            return btn;
        }

        // --- TIKLAMA OLAYLARI ---
        private void SolUrun_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            SiparisUrunModel urun = (SiparisUrunModel)btn.Tag;
            if (solSecilenler.Contains(urun)) { solSecilenler.Remove(urun); btn.BackColor = Color.WhiteSmoke; }
            else { solSecilenler.Add(urun); btn.BackColor = Color.DarkOrange; }
        }

        private void SagUrun_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            SiparisUrunModel urun = (SiparisUrunModel)btn.Tag;
            if (sagSecilenler.Contains(urun)) { sagSecilenler.Remove(urun); btn.BackColor = Color.WhiteSmoke; }
            else { sagSecilenler.Add(urun); btn.BackColor = Color.DarkOrange; }
        }

        // --- AKTARMA BUTONLARI ---
        private void btnSecilenAktar_Click(object sender, EventArgs e)
        {
            foreach (var item in solSecilenler) { sagListeVerileri.Add(item); solListeVerileri.Remove(item); }
            solSecilenler.Clear();
            EkranlariCiz();
        }

        private void btnSecilenleriGeriAl_Click(object sender, EventArgs e)
        {
            foreach (var item in sagSecilenler) { solListeVerileri.Add(item); sagListeVerileri.Remove(item); }
            sagSecilenler.Clear();
            EkranlariCiz();
        }

        private void btnHepsiniAktar_Click(object sender, EventArgs e)
        {
            sagListeVerileri.AddRange(solListeVerileri);
            solListeVerileri.Clear();
            solSecilenler.Clear();
            EkranlariCiz();
        }

        private void btnHepsiniGeriAl_Click(object sender, EventArgs e)
        {
            solListeVerileri.AddRange(sagListeVerileri);
            sagListeVerileri.Clear();
            sagSecilenler.Clear();
            EkranlariCiz();
        }

        // =========================================================================
        // 1. BUTON: ÖDE (Masayı BOŞALTMAZ, Sadece Parayı Alır)
        // =========================================================================
        private void btnOde_Click(object sender, EventArgs e)
        {
            decimal odenecekTutar = 0;
            foreach (var item in sagListeVerileri) odenecekTutar += item.AraToplam;

            if (odenecekTutar <= 0)
            {
                MessageBox.Show("Lütfen sağ tarafa ödenecek ürün aktarın.", "Uyarı");
                return;
            }

            // Ödeme Tipi Sor
            DialogResult cevap = MessageBox.Show(
                $"Tutar: {odenecekTutar:C2}\nÖdeme NAKİT mi?",
                "Ödeme Tipi", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            if (cevap == DialogResult.Cancel) return;
            string odemeTuru = (cevap == DialogResult.Yes) ? "Nakit" : "Kart";

            // Veritabanına Ekle
            bool sonuc = db.OdemeEkle(aktifSiparisID, odemeTuru, odenecekTutar);

            if (sonuc)
            {
                MessageBox.Show($"{odenecekTutar:C2} ödeme ({odemeTuru}) alındı.\nKalan borç varsa BİTİR demeden önce tahsil ediniz.", "Bilgi");

                // Sağ tarafı temizle (Çünkü ödendi, artık borç değil)
                sagListeVerileri.Clear();

                // Ekranı güncelle (Ödenenler listeden gitti, kalanlar solda duruyor)
                EkranlariCiz();
            }
            else
            {
                MessageBox.Show("Hata oluştu!", "Hata");
            }
        }

        // =========================================================================
        // 2. BUTON: BİTİR (Masa Boşaltma Kodu BURAYA TAŞINDI)
        // =========================================================================
        private void btnBitir_Click(object sender, EventArgs e)
        {
            // 1. Borç Kontrolü
            if (solListeVerileri.Count > 0 || sagListeVerileri.Count > 0)
            {
                MessageBox.Show("Masada hala ödenmemiş ürünler var!\nLütfen önce 'HEPSİNİ AKTAR' ve 'ÖDE' butonlarını kullanarak borcu sıfırlayın.",
                                "Hesap Kapanmadı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. HESAP TAMAMEN ÖDENMİŞSE -> Masayı Boşalt ve Kapat

            // Siparişi 'Kapandı' yapıyoruz
            db.SiparisHesapKapat(aktifSiparisID, 0, "Kapandı");

            // --- İSTEDİĞİN ÖZELLİK: MASAYI BURADA BOŞALTIYORUZ ---
            db.MasaDurumGuncelle(seciliMasaID, "Boş");

            MessageBox.Show("Masa başarıyla kapatıldı.", "İşlem Tamam", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close(); // Sipariş ekranına dön
        }

        // Butonlar için yönlendirmeler
        private void btnGeriDon_Click(object sender, EventArgs e) { this.Close(); }
        private void btnNakit_Click(object sender, EventArgs e) { btnOde_Click(null, null); }
        private void btnKart_Click(object sender, EventArgs e) { btnOde_Click(null, null); }

        private void panelOrta_Paint(object sender, PaintEventArgs e) { }
        private void labelOdemeYontemi_Click(object sender, EventArgs e) { }
        private void labelToplam_Click(object sender, EventArgs e) { }
    }
}