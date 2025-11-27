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

        // DEĞİŞKENLER
        int seciliMasaID = -1;
        int aktifSiparisID = -1;
        decimal toplamMasaTutari = 0;

        // LİSTELER
        List<SiparisUrunModel> solListeVerileri = new List<SiparisUrunModel>();
        List<SiparisUrunModel> sagListeVerileri = new List<SiparisUrunModel>();

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
            // 1. SAAT AYARI
            if (timer1 != null)
            {
                timer1.Interval = 1000;
                timer1.Tick += timer1_Tick;
                timer1.Start();
            }

            // 2. SAATİ BİRAZ SOLA KAYDIRMA
            Control[] lblSaat = Controls.Find("labelSaatBilgi", true);
            if (lblSaat.Length > 0)
            {
                lblSaat[0].Left = lblSaat[0].Left - 40;
            }

            // 3. GARSON ADI
            Control[] lblGarson = Controls.Find("labelHesapBilgi", true);
            if (lblGarson.Length > 0)
                lblGarson[0].Text = "Garson: " + AktifKullanici.AdSoyad;

            if (seciliMasaID != -1)
            {
                Control[] labels = Controls.Find("labelMasaBilgi", true);
                if (labels.Length > 0) labels[0].Text = "MASA " + seciliMasaID;
                HesabiGetir();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Control[] lblSaat = Controls.Find("labelSaatBilgi", true);
            if (lblSaat.Length > 0)
            {
                lblSaat[0].Text = DateTime.Now.ToString("HH:mm:ss");
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
            // SOL TARAFI ÇİZ
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
            if (lblSol.Length > 0) lblSol[0].Text = $"TOPLAM: {toplamMasaTutari:C2}";

            // SAĞ TARAFI ÇİZ
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
            if (lblSag.Length > 0)
                lblSag[0].Text = $"{odenecekTutar:C2}";
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

        // TIKLAMA OLAYLARI
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

        // --- YENİ EKLENEN KISIM: ADET SORAN PENCERE ---
        private int MiktarSor(string urunAdi, int maxAdet)
        {
            Form prompt = new Form()
            {
                Width = 300,
                Height = 180,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = "Adet Seçimi",
                StartPosition = FormStartPosition.CenterScreen,
                MinimizeBox = false,
                MaximizeBox = false
            };

            Label textLabel = new Label() { Left = 20, Top = 20, Text = $"{urunAdi}\nKaç adet ödenecek? (Max: {maxAdet})", AutoSize = true, Font = new Font("Segoe UI", 10, FontStyle.Bold) };
            TextBox inputBox = new TextBox() { Left = 20, Top = 70, Width = 240, Text = "1" };
            Button confirmation = new Button() { Text = "Tamam", Left = 160, Width = 100, Top = 100, DialogResult = DialogResult.OK };

            prompt.Controls.Add(textLabel);
            prompt.Controls.Add(inputBox);
            prompt.Controls.Add(confirmation);
            prompt.AcceptButton = confirmation;

            return prompt.ShowDialog() == DialogResult.OK && int.TryParse(inputBox.Text, out int result) && result > 0 && result <= maxAdet ? result : -1;
        }

        // --- GÜNCELLENEN AKTARMA BUTONU ---
        private void btnSecilenAktar_Click(object sender, EventArgs e)
        {
            if (solSecilenler.Count == 0) return;

            // Listeyi kopyalayıp döngüye sokuyoruz ki işlem sırasında hata vermesin
            var islenecekUrunler = new List<SiparisUrunModel>(solSecilenler);

            foreach (var item in islenecekUrunler)
            {
                int aktarilacakAdet = 1;

                // Eğer ürün 1 taneden fazlaysa SOR
                if (item.Adet > 1)
                {
                    int girilenAdet = MiktarSor(item.UrunAdi, item.Adet);
                    if (girilenAdet == -1) continue; // İptal ederse atla
                    aktarilacakAdet = girilenAdet;
                }
                else
                {
                    aktarilacakAdet = 1; // Zaten 1 tane varsa direkt al
                }

                // Mantık: Hepsini mi alıyoruz, bir kısmını mı?
                if (aktarilacakAdet == item.Adet)
                {
                    sagListeVerileri.Add(item);
                    solListeVerileri.Remove(item);
                }
                else
                {
                    // Parçalama işlemi
                    item.Adet -= aktarilacakAdet;
                    item.AraToplam = item.Adet * item.BirimFiyat; // Sol tarafın fiyatını güncelle

                    // Sağ tarafa yeni parça oluştur
                    SiparisUrunModel yeniParca = new SiparisUrunModel
                    {
                        UrunID = item.UrunID,
                        UrunAdi = item.UrunAdi,
                        BirimFiyat = item.BirimFiyat,
                        Adet = aktarilacakAdet,
                        AraToplam = aktarilacakAdet * item.BirimFiyat
                    };
                    sagListeVerileri.Add(yeniParca);
                }
            }

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

        // HIZLI ÖDEME
        private void HizliOdemeYap(string odemeTuru)
        {
            decimal odenecekTutar = 0;
            foreach (var item in sagListeVerileri) odenecekTutar += item.AraToplam;

            if (odenecekTutar <= 0)
            {
                MessageBox.Show("Lütfen önce sağ tarafa ürün aktarın.", "Uyarı");
                return;
            }

            bool sonuc = db.OdemeEkle(aktifSiparisID, odemeTuru, odenecekTutar);

            if (sonuc)
            {
                MessageBox.Show($"{odenecekTutar:C2} tutarındaki ödeme {odemeTuru.ToUpper()} olarak alındı.", "İşlem Başarılı");
                sagListeVerileri.Clear();
                EkranlariCiz();
            }
            else
            {
                MessageBox.Show("Hata oluştu!", "Hata");
            }
        }

        private void btnNakit_Click(object sender, EventArgs e) { HizliOdemeYap("Nakit"); }
        private void btnKart_Click(object sender, EventArgs e) { HizliOdemeYap("Kart"); }

        // BİTİR BUTONU
        private void btnBitir_Click(object sender, EventArgs e)
        {
            if (solListeVerileri.Count > 0 || sagListeVerileri.Count > 0)
            {
                MessageBox.Show("Masada hala ödenmemiş ürünler var! Borcu sıfırlamadan masayı kapatamazsınız.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            db.SiparisHesapKapat(aktifSiparisID, 0, "Kapandı");
            db.MasaDurumGuncelle(seciliMasaID, "Boş");
            MessageBox.Show("Hesap kapatıldı, masa boşaltıldı.", "Tamamlandı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void btnGeriDon_Click(object sender, EventArgs e) { this.Close(); }

        // BOŞ EVENTLER
        private void btnOde_Click(object sender, EventArgs e) { MessageBox.Show("Lütfen aşağıdaki NAKİT veya KART butonlarını kullanınız."); }
        private void panelOdenecekler_Paint(object sender, PaintEventArgs e) { }
        private void panelOrta_Paint(object sender, PaintEventArgs e) { }
        private void labelOdemeYontemi_Click(object sender, EventArgs e) { }
        private void labelToplam_Click(object sender, EventArgs e) { }
    }
}