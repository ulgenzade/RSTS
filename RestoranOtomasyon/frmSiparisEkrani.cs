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
        private string _seciliMasaDurumu = "";
        private int _seciliKategoriID = 0; // 0 = Tümü

        private DataTable _tumUrunlerCache = new DataTable();
        private List<SepetUrunDto> _yeniSiparisListesi = new List<SepetUrunDto>();

        public frmSiparisEkrani()
        {
            InitializeComponent();
        }

        private void frmSiparisEkrani_Load(object sender, EventArgs e)
        {
            // 1. Garson Adı
            if (Controls.Find("materialLabel1", true).Length > 0)
                Controls.Find("materialLabel1", true)[0].Text = "Garson: " + AktifKullanici.AdSoyad;

            // 2. TASARIM VE AYAR DÜZELTMELERİ (Otomatik)
            ArayuzAyarlariniYap();

            // 3. Olayları (Events) Elle Bağla (Hata riskini sıfırlamak için)
            OlaylariBagla();

            // 4. Verileri Yükle
            GridAyarlariniYap();
            MasalariYukle();
            KategorileriYukle();

            // 5. Ürünleri Hafızaya Al ve Göster
            _tumUrunlerCache = db.UrunleriGetir();
            UrunleriFiltreleVeGoster();
        }

        private void ArayuzAyarlariniYap()
        {
            // KAYDIRMA ÖZELLİĞİ (SCROLL)
            flowUrunler.AutoScroll = true;       // Ürünler sığmazsa kaydırma çubuğu çıksın
            flowUrunler.WrapContents = true;     // Ürünler yan yana dizilsin, sığmayınca aşağı insin

            flowKategoriler.AutoScroll = true;   // Kategoriler için de kaydırma
            flowKategoriler.WrapContents = false; // Kategoriler tek satırda yan yana gitsin (İstersen true yapıp alt alta alabilirsin)
            flowKategoriler.FlowDirection = FlowDirection.LeftToRight; // Soldan sağa dizilim

            // HİZALAMA DÜZELTMESİ
            // Kategori panelini Ürün paneliyle aynı genişliğe ve X koordinatına getiriyoruz.
            flowKategoriler.Width = flowUrunler.Width;
            flowKategoriler.Left = flowUrunler.Left;

            // "GERİ DÖN" BUTONU BOYUT DÜZELTMESİ
            // Butonun Anchor özelliğini kaldırıp sabit boyut veriyoruz.
            btnGeriDon.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnGeriDon.AutoSize = false;
            btnGeriDon.Size = new Size(120, 40); // İdeal boyut
        }

        private void OlaylariBagla()
        {
            Control[] txtMatches = this.Controls.Find("txtArama", true);
            if (txtMatches.Length > 0)
            {
                // Standart TextBox yerine MaterialTextBoxEdit olarak cast ediyoruz.
                ((ReaLTaiizor.Controls.MaterialTextBoxEdit)txtMatches[0]).TextChanged += txtArama_TextChanged;
            }
        }

        private void GridAyarlariniYap()
        {
            dgMevcutUrunler.Rows.Clear();
            dgMevcutUrunler.Columns.Clear();

            dgMevcutUrunler.ColumnCount = 4;
            dgMevcutUrunler.Columns[0].Name = "UrunAdi";
            dgMevcutUrunler.Columns[0].HeaderText = "Ürün Adı";
            dgMevcutUrunler.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; // İsmi genişlet

            dgMevcutUrunler.Columns[1].Name = "Adet";
            dgMevcutUrunler.Columns[1].HeaderText = "Adet";
            dgMevcutUrunler.Columns[1].Width = 50;

            dgMevcutUrunler.Columns[2].Name = "Fiyat";
            dgMevcutUrunler.Columns[2].HeaderText = "Fiyat";
            dgMevcutUrunler.Columns[2].Width = 70;

            dgMevcutUrunler.Columns[3].Name = "Durum";
            dgMevcutUrunler.Columns[3].HeaderText = "Durum";
            dgMevcutUrunler.Columns[3].Width = 80;

            dgMevcutUrunler.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgMevcutUrunler.AllowUserToAddRows = false;
            dgMevcutUrunler.ReadOnly = true;
            dgMevcutUrunler.RowHeadersVisible = false; // Soldaki gri boşluğu kaldır
        }

        private void MasalariYukle()
        {
            flowMasalar.Controls.Clear();
            DataTable masalar = db.MasalariGetir();

            foreach (DataRow row in masalar.Rows)
            {
                Button btn = new Button();
                btn.Text = row["MasaAdi"].ToString();
                btn.Tag = row;
                btn.Size = new Size(110, 80); // Masa buton boyutu
                btn.FlatStyle = FlatStyle.Flat;
                btn.Font = new Font("Segoe UI", 10, FontStyle.Bold);
                btn.ForeColor = Color.White;

                string durum = row["Durum"].ToString();
                if (durum == "Dolu") btn.BackColor = Color.Crimson;
                else btn.BackColor = Color.SeaGreen;

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

            _yeniSiparisListesi.Clear();
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
            btnTumu.BackColor = Color.FromArgb(64, 64, 64); // Koyu Gri
            btnTumu.ForeColor = Color.White;
            btnTumu.FlatStyle = FlatStyle.Flat;
            btnTumu.Click += Kategori_Click;
            flowKategoriler.Controls.Add(btnTumu);

            DataTable kategoriler = db.KategorileriGetir();
            foreach (DataRow row in kategoriler.Rows)
            {
                Button btn = new Button();
                btn.Text = row["KategoriAdi"].ToString();
                btn.Tag = Convert.ToInt32(row["KategoriID"]);
                btn.Size = new Size(120, 50); // Kategori buton boyutu
                btn.BackColor = Color.Teal;
                btn.ForeColor = Color.White;
                btn.FlatStyle = FlatStyle.Flat;
                btn.Click += Kategori_Click;
                flowKategoriler.Controls.Add(btn);
            }
        }

        private void Kategori_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            _seciliKategoriID = (int)btn.Tag;

            // Arama kutusunu temizle ki tüm kategori ürünleri gelsin
            Control[] txtMatches = this.Controls.Find("txtArama", true);
            if (txtMatches.Length > 0) ((ReaLTaiizor.Controls.MaterialTextBoxEdit)txtMatches[0]).Text = "";

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

            string arananKelime = "";
            Control[] matches = this.Controls.Find("txtArama", true);
            if (matches.Length > 0) arananKelime = ((ReaLTaiizor.Controls.MaterialTextBoxEdit)matches[0]).Text.ToLower();

            foreach (DataRow row in _tumUrunlerCache.Rows)
            {
                // 1. Kategori Filtresi
                bool kategoriUygun = _seciliKategoriID == 0;
                // KategoriID sütunu var mı kontrol et
                if (!kategoriUygun && row.Table.Columns.Contains("KategoriID"))
                {
                    // Veritabanından gelen değer ile seçili ID eşleşiyor mu?
                    if (Convert.ToInt32(row["KategoriID"]) == _seciliKategoriID)
                    {
                        kategoriUygun = true;
                    }
                }

                // 2. İsim Filtresi
                string urunAdi = row["UrunAdi"].ToString().ToLower();
                bool aramaUygun = urunAdi.Contains(arananKelime);

                if (kategoriUygun && aramaUygun)
                {
                    Button btn = new Button();
                    btn.Text = $"{row["UrunAdi"]}\n{row["Fiyat"]} ₺";
                    btn.Size = new Size(130, 90); // Ürün buton boyutu
                    btn.BackColor = Color.White;
                    btn.ForeColor = Color.Black;
                    btn.FlatStyle = FlatStyle.Flat;

                    // DTO Nesnesini Tag içine sakla
                    btn.Tag = new SepetUrunDto
                    {
                        UrunID = Convert.ToInt32(row["UrunID"]),
                        BirimFiyat = Convert.ToDecimal(row["Fiyat"]),
                        Adet = 1
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

            // Listede var mı kontrol et
            var varOlan = _yeniSiparisListesi.Find(x => x.UrunID == secilenUrun.UrunID);
            if (varOlan != null)
            {
                varOlan.Adet++;
            }
            else
            {
                // Yeni kopya ekle
                _yeniSiparisListesi.Add(new SepetUrunDto
                {
                    UrunID = secilenUrun.UrunID,
                    Adet = 1,
                    BirimFiyat = secilenUrun.BirimFiyat
                });
            }

            SepetiVeGridiGuncelle();
        }

        private void SepetiVeGridiGuncelle()
        {
            dgMevcutUrunler.Rows.Clear();

            // 1. ESKİ SİPARİŞLER (GRİ)
            if (_seciliMasaDurumu == "Dolu")
            {
                List<SiparisUrunModel> eskiSiparisler = db.MasaSiparisleriniGetir(_seciliMasaID);
                foreach (var urun in eskiSiparisler)
                {
                    int satirIndex = dgMevcutUrunler.Rows.Add(urun.UrunAdi, urun.Adet, urun.AraToplam, "Mutfakta");
                    dgMevcutUrunler.Rows[satirIndex].DefaultCellStyle.BackColor = Color.LightGray;
                    dgMevcutUrunler.Rows[satirIndex].DefaultCellStyle.ForeColor = Color.DarkGray;
                }
            }

            // 2. YENİ EKLENENLER (BEYAZ)
            foreach (var urun in _yeniSiparisListesi)
            {
                string urunAdi = "Ürün";
                DataRow[] rows = _tumUrunlerCache.Select("UrunID = " + urun.UrunID);
                if (rows.Length > 0) urunAdi = rows[0]["UrunAdi"].ToString();

                decimal toplamFiyat = urun.Adet * urun.BirimFiyat;

                int satirIndex = dgMevcutUrunler.Rows.Add(urunAdi, urun.Adet, toplamFiyat, "Yeni Eklendi");
                dgMevcutUrunler.Rows[satirIndex].DefaultCellStyle.BackColor = Color.White;
                dgMevcutUrunler.Rows[satirIndex].DefaultCellStyle.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            }
            dgMevcutUrunler.ClearSelection();
        }

        private void btnOnayla_Click(object sender, EventArgs e)
        {
            if (_seciliMasaID == -1 || _yeniSiparisListesi.Count == 0) return;

            bool sonuc = false;
            int garsonID = AktifKullanici.KullaniciID;

            if (_seciliMasaDurumu == "Boş")
                sonuc = db.SiparisOlusturVeOnayla(_seciliMasaID, garsonID, _yeniSiparisListesi);
            else
                sonuc = db.EkSiparisEkle(_seciliMasaID, _yeniSiparisListesi);

            if (sonuc)
            {
                MessageBox.Show("Sipariş mutfağa iletildi!", "Başarılı");
                _yeniSiparisListesi.Clear();
                MasalariYukle();
                _seciliMasaDurumu = "Dolu";
                SepetiVeGridiGuncelle();
            }
            else
            {
                MessageBox.Show("Hata oluştu.", "Hata");
            }
        }

        private void btnVazgec_Click(object sender, EventArgs e)
        {
            if (_yeniSiparisListesi.Count > 0)
            {
                if (MessageBox.Show("Yeni eklenenleri iptal et?", "İptal", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    _yeniSiparisListesi.Clear();
                    SepetiVeGridiGuncelle();
                }
            }
        }

        private void btnOdeme_Click(object sender, EventArgs e)
        {
            if (_seciliMasaID == -1) return;
            frmOdemeEkrani odeme = new frmOdemeEkrani();
            odeme.ShowDialog();
            MasalariYukle();
            dgMevcutUrunler.Rows.Clear();
            _yeniSiparisListesi.Clear();
            _seciliMasaID = -1;
        }

        private void btnGeriDon_Click(object sender, EventArgs e)
        {
            frmGiris giris = new frmGiris();
            giris.Show();
            this.Close();
        }
    }
}
