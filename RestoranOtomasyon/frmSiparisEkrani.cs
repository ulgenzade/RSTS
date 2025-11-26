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

        private VeritabaniIslemleri db = new VeritabaniIslemleri();

        // -- DURUM DEĞİŞKENLERİ --
        private int _seciliMasaID = -1;
        private string _seciliMasaDurumu = ""; // "Boş" veya "Dolu"
        private int _seciliKategoriID = 0; // 0 = Tümü

        // Hız için tüm ürünleri hafızada tutuyoruz
        private DataTable _tumUrunlerCache = new DataTable();

        // Veritabanına henüz gönderilmemiş, sepette bekleyen yeni ürünler
        private List<SepetUrunDto> _yeniSiparisListesi = new List<SepetUrunDto>();

        public frmSiparisEkrani()
        {
            InitializeComponent();
        }

        private void frmSiparisEkrani_Load(object sender, EventArgs e)
        {
            // 1. Garson Adını Yazdır
            // Tasarımda adı materialLabel1 olarak görünüyor
            materialLabel1.Text = "Garson: " + AktifKullanici.AdSoyad;

            // 2. DataGridView Ayarlarını Yap
            GridAyarlariniYap();

            // 3. Verileri Yükle
            MasalariYukle();
            KategorileriYukle();

            // 4. Tüm Ürünleri Hafızaya Çek (Hızlı arama için)
            _tumUrunlerCache = db.UrunleriGetir();

            // Başlangıçta tüm ürünleri göster
            UrunleriFiltreleVeGoster();
        }

        private void GridAyarlariniYap()
        {
            dgMevcutUrunler.Rows.Clear();
            dgMevcutUrunler.Columns.Clear();

            // Sütunları kodla ekliyoruz ki kontrol bizde olsun
            dgMevcutUrunler.ColumnCount = 4;
            dgMevcutUrunler.Columns[0].Name = "UrunAdi";
            dgMevcutUrunler.Columns[0].HeaderText = "Ürün Adı";
            dgMevcutUrunler.Columns[0].Width = 150;

            dgMevcutUrunler.Columns[1].Name = "Adet";
            dgMevcutUrunler.Columns[1].HeaderText = "Adet";
            dgMevcutUrunler.Columns[1].Width = 50;

            dgMevcutUrunler.Columns[2].Name = "Fiyat";
            dgMevcutUrunler.Columns[2].HeaderText = "Fiyat";

            dgMevcutUrunler.Columns[3].Name = "Durum";
            dgMevcutUrunler.Columns[3].HeaderText = "Durum";

            // Görsel ayarlar
            dgMevcutUrunler.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgMevcutUrunler.AllowUserToAddRows = false;
            dgMevcutUrunler.ReadOnly = true;
        }

        private void MasalariYukle()
        {
            flowMasalar.Controls.Clear();
            DataTable masalar = db.MasalariGetir();

            foreach (DataRow row in masalar.Rows)
            {
                Button btn = new Button();
                btn.Text = row["MasaAdi"].ToString();
                btn.Tag = row; // Satırın tamamını sakla
                btn.Size = new Size(120, 80);
                btn.FlatStyle = FlatStyle.Flat;
                btn.Font = new Font("Segoe UI", 10, FontStyle.Bold);
                btn.ForeColor = Color.White;

                string durum = row["Durum"].ToString();
                if (durum == "Dolu")
                    btn.BackColor = Color.Crimson; // Dolu masalar kırmızı
                else
                    btn.BackColor = Color.SeaGreen; // Boş masalar yeşil

                btn.Click += Masa_Click;
                flowMasalar.Controls.Add(btn);
            }
        }

        private void Masa_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            DataRow row = (DataRow)btn.Tag;

            _seciliMasaID = Convert.ToInt32(row["MasaID"]);
            _seciliMasaDurumu = row["Durum"].ToString();

            // Yeni bir masaya geçince sepeti (yeni eklenenleri) temizle
            _yeniSiparisListesi.Clear();

            // Grid'i güncelle (Eski siparişler + Varsa yeniler)
            SepetiVeGridiGuncelle();
        }

        private void KategorileriYukle()
        {
            flowKategoriler.Controls.Clear();

            // "TÜMÜ" butonu
            Button btnTumu = new Button();
            btnTumu.Text = "TÜMÜ";
            btnTumu.Tag = 0;
            btnTumu.Size = new Size(100, 50);
            btnTumu.BackColor = Color.DarkSlateGray;
            btnTumu.ForeColor = Color.White;
            btnTumu.Click += Kategori_Click;
            flowKategoriler.Controls.Add(btnTumu);

            DataTable kategoriler = db.KategorileriGetir();
            foreach (DataRow row in kategoriler.Rows)
            {
                Button btn = new Button();
                btn.Text = row["KategoriAdi"].ToString();
                btn.Tag = Convert.ToInt32(row["KategoriID"]);
                btn.Size = new Size(100, 50);
                btn.BackColor = Color.Teal;
                btn.ForeColor = Color.White;
                btn.Click += Kategori_Click;
                flowKategoriler.Controls.Add(btn);
            }
        }

        private void Kategori_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            _seciliKategoriID = (int)btn.Tag;

            // Kategori değişince ürünleri filtrele
            UrunleriFiltreleVeGoster();
        }

        // Eğer tasarımda bir Arama TextBox'ı varsa (ismi txtArama olmalı), bu event'i ona bağla.
        // Yoksa bu metot çalışmaz ama hata da vermez.
        private void txtArama_TextChanged(object sender, EventArgs e)
        {
            UrunleriFiltreleVeGoster();
        }

        private void UrunleriFiltreleVeGoster()
        {
            flowUrunler.Controls.Clear();

            // Tasarımda txtArama adında bir TextBox olduğunu varsayıyoruz.
            // Eğer yoksa arama metni boş kabul edilir.
            string arananKelime = "";
            Control[] matches = this.Controls.Find("txtArama", true);
            if (matches.Length > 0)
            {
                arananKelime = matches[0].Text.ToLower();
            }

            foreach (DataRow row in _tumUrunlerCache.Rows)
            {
                // 1. Kategori Kontrolü
                bool kategoriUygun = _seciliKategoriID == 0;
                if (!kategoriUygun && row.Table.Columns.Contains("KategoriID"))
                {
                    kategoriUygun = Convert.ToInt32(row["KategoriID"]) == _seciliKategoriID;
                }

                // 2. Arama Metni Kontrolü
                string urunAdi = row["UrunAdi"].ToString().ToLower();
                bool aramaUygun = urunAdi.Contains(arananKelime);

                if (kategoriUygun && aramaUygun)
                {
                    Button btn = new Button();
                    btn.Text = $"{row["UrunAdi"]}\n{row["Fiyat"]} TL";
                    btn.Size = new Size(110, 80);
                    btn.BackColor = Color.WhiteSmoke;

                    // DTO Nesnesini Tag içine sakla
                    btn.Tag = new SepetUrunDto
                    {
                        UrunID = Convert.ToInt32(row["UrunID"]),
                        BirimFiyat = Convert.ToDecimal(row["Fiyat"]),
                        Adet = 1 // Varsayılan 1 adet
                    };

                    btn.Click += Urun_Click;
                    flowUrunler.Controls.Add(btn);
                }
            }
        }

        private void Urun_Click(object sender, EventArgs e)
        {
            if (_seciliMasaID == -1)
            {
                MessageBox.Show("Lütfen önce sol taraftan bir masa seçin!", "Uyarı");
                return;
            }

            Button btn = (Button)sender;
            SepetUrunDto secilenUrun = (SepetUrunDto)btn.Tag;

            // Listeye ekle (Varsa adet arttır, yoksa yeni ekle)
            var varOlan = _yeniSiparisListesi.Find(x => x.UrunID == secilenUrun.UrunID);
            if (varOlan != null)
            {
                varOlan.Adet++;
            }
            else
            {
                // Listeye yeni bir kopya ekliyoruz
                _yeniSiparisListesi.Add(new SepetUrunDto
                {
                    UrunID = secilenUrun.UrunID,
                    Adet = 1,
                    BirimFiyat = secilenUrun.BirimFiyat
                });
            }

            // Grid'i güncelle
            SepetiVeGridiGuncelle();
        }

        private void SepetiVeGridiGuncelle()
        {
            dgMevcutUrunler.Rows.Clear();

            // 1. Önce Veritabanındaki ESKİ siparişleri yükle (Eğer masa doluysa)
            if (_seciliMasaDurumu == "Dolu")
            {
                // VeritabaniIslemleri'ndeki 'MasaSiparisleriniGetir' metodunu kullan
                List<SiparisUrunModel> eskiSiparisler = db.MasaSiparisleriniGetir(_seciliMasaID);

                foreach (var urun in eskiSiparisler)
                {
                    int satirIndex = dgMevcutUrunler.Rows.Add(urun.UrunAdi, urun.Adet, urun.AraToplam, "Mutfakta");
                    // Eski siparişler GRİ renkte olsun (karışmasın)
                    dgMevcutUrunler.Rows[satirIndex].DefaultCellStyle.BackColor = Color.LightGray;
                    dgMevcutUrunler.Rows[satirIndex].DefaultCellStyle.ForeColor = Color.DarkGray;
                }
            }

            // 2. Sonra Yeni Eklenenleri Yükle
            foreach (var urun in _yeniSiparisListesi)
            {
                // Ürün adını ID'den bulmamız lazım (Cache'den)
                string urunAdi = "Bilinmeyen Ürün";
                DataRow[] rows = _tumUrunlerCache.Select("UrunID = " + urun.UrunID);
                if (rows.Length > 0) urunAdi = rows[0]["UrunAdi"].ToString();

                decimal toplamFiyat = urun.Adet * urun.BirimFiyat;

                int satirIndex = dgMevcutUrunler.Rows.Add(urunAdi, urun.Adet, toplamFiyat, "Yeni Eklendi");
                // Yeni siparişler BEYAZ/NORMAL renkte olsun
                dgMevcutUrunler.Rows[satirIndex].DefaultCellStyle.BackColor = Color.White;
                dgMevcutUrunler.Rows[satirIndex].DefaultCellStyle.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            }

            // Seçimi kaldır
            dgMevcutUrunler.ClearSelection();
        }

        private void btnOnayla_Click(object sender, EventArgs e)
        {
            if (_seciliMasaID == -1) return;
            if (_yeniSiparisListesi.Count == 0)
            {
                MessageBox.Show("Sepette yeni ürün yok.");
                return;
            }

            bool sonuc = false;
            int garsonID = AktifKullanici.KullaniciID;

            if (_seciliMasaDurumu == "Boş")
            {
                // Masa boşsa, sıfırdan sipariş oluştur
                sonuc = db.SiparisOlusturVeOnayla(_seciliMasaID, garsonID, _yeniSiparisListesi);
            }
            else
            {
                // Masa doluysa, mevcut siparişe ekle
                sonuc = db.EkSiparisEkle(_seciliMasaID, _yeniSiparisListesi);
            }

            if (sonuc)
            {
                MessageBox.Show("Sipariş başarıyla kaydedildi!");
                _yeniSiparisListesi.Clear();

                // Masaları yenile (rengi değişsin diye)
                MasalariYukle();

                // Seçili masayı güncelle (Artık dolu)
                _seciliMasaDurumu = "Dolu";
                SepetiVeGridiGuncelle();
            }
            else
            {
                MessageBox.Show("Sipariş kaydedilirken hata oluştu.");
            }
        }

        private void btnVazgec_Click(object sender, EventArgs e)
        {
            // Sadece yeni eklenenleri temizle
            if (_yeniSiparisListesi.Count > 0)
            {
                DialogResult cvp = MessageBox.Show("Eklenen yeni ürünleri iptal etmek istiyor musunuz?", "İptal", MessageBoxButtons.YesNo);
                if (cvp == DialogResult.Yes)
                {
                    _yeniSiparisListesi.Clear();
                    SepetiVeGridiGuncelle();
                }
            }
        }

        private void btnOdeme_Click(object sender, EventArgs e)
        {
            if (_seciliMasaID == -1)
            {
                MessageBox.Show("Lütfen masa seçin.");
                return;
            }

            frmOdemeEkrani odeme = new frmOdemeEkrani();
            odeme.ShowDialog();

            // Ödeme yapılıp dönüldüyse masaları güncelle
            MasalariYukle();
            dgMevcutUrunler.Rows.Clear();
            _yeniSiparisListesi.Clear();
            _seciliMasaID = -1;
        }
        //EHEHEHE
        private void btnGeriDon_Click(object sender, EventArgs e)
        {
            frmGiris giris = new frmGiris();
            giris.Show();
            this.Close();
        }
    }
}
