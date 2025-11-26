using RestoranOtomasyon;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace RestoranOtomasyon
{
    public partial class frmSiparisEkrani : Form
    {
        private VeritabaniIslemleri db = new VeritabaniIslemleri();

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
            // Garson adı
            if (Controls.Find("materialLabel1", true).Length > 0)
                Controls.Find("materialLabel1", true)[0].Text = "Garson: " + AktifKullanici.AdSoyad;

            // 1. Arayüz Düzeni (Üst üste binmeyi engellemek için)
            ArayuzAyarlariniYap();
            
            // 2. Olayları Bağla
            OlaylariBagla();

            // 3. Grid Ayarları
            GridAyarlariniYap();

            // 4. Verileri Yükle
            MasalariYukle();
            KategorileriYukle();

            // 5. Ürünleri Hafızaya Al ve Göster
            _tumUrunlerCache = db.UrunleriGetir();
            UrunleriFiltreleVeGoster();
        }

        private void ArayuzAyarlariniYap()
        {
            // --- KATEGORİ PANELİ DÜZENİ ---
            flowKategoriler.AutoScroll = true;
            flowKategoriler.WrapContents = true; // Sığmazsa alt satıra geçsin
            flowKategoriler.Padding = new Padding(5); // İç boşluk
            flowKategoriler.FlowDirection = FlowDirection.LeftToRight;
            
            // --- ÜRÜN PANELİ DÜZENİ ---
            flowUrunler.AutoScroll = true;
            flowUrunler.WrapContents = true; 
            flowUrunler.Padding = new Padding(5);
        }

        private void OlaylariBagla()
        {
            Control[] txtMatches = this.Controls.Find("txtArama", true);
            if (txtMatches.Length > 0)
            {
                try { ((ReaLTaiizor.Controls.MaterialTextBoxEdit)txtMatches[0]).TextChanged += txtArama_TextChanged; } catch { }
            }
        }

        private void GridAyarlariniYap()
        {
            dgMevcutUrunler.Rows.Clear();
            dgMevcutUrunler.Columns.Clear();
            dgMevcutUrunler.ColumnCount = 4;
            dgMevcutUrunler.Columns[0].Name = "UrunAdi"; dgMevcutUrunler.Columns[0].HeaderText = "Ürün Adı"; dgMevcutUrunler.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgMevcutUrunler.Columns[1].Name = "Adet"; dgMevcutUrunler.Columns[1].HeaderText = "Adet"; dgMevcutUrunler.Columns[1].Width = 50;
            dgMevcutUrunler.Columns[2].Name = "Fiyat"; dgMevcutUrunler.Columns[2].HeaderText = "Fiyat"; dgMevcutUrunler.Columns[2].Width = 70;
            dgMevcutUrunler.Columns[3].Name = "Durum"; dgMevcutUrunler.Columns[3].HeaderText = "Durum"; dgMevcutUrunler.Columns[3].Width = 80;
            dgMevcutUrunler.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgMevcutUrunler.AllowUserToAddRows = false;
            dgMevcutUrunler.ReadOnly = true;
            dgMevcutUrunler.RowHeadersVisible = false;
        }

        // --- MASALAR ---
        private void MasalariYukle()
        {
            flowMasalar.Controls.Clear();
            DataTable masalar = db.MasalariGetir();

            foreach (DataRow row in masalar.Rows)
            {
                Button btn = new Button();
                btn.Text = row["MasaAdi"].ToString();
                btn.Tag = row;
                btn.Size = new Size(110, 80);
                btn.FlatStyle = FlatStyle.Flat;
                btn.Font = new Font("Segoe UI", 10, FontStyle.Bold);
                btn.ForeColor = Color.White;
                btn.Margin = new Padding(5); // Butonlar birbirine yapışmasın

                string durum = row["Durum"].ToString();
                if (durum == "Dolu") btn.BackColor = Color.Crimson;
                else if (durum == "Rezerve") btn.BackColor = Color.Orange;
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

        // --- KATEGORİLER (DÜZELTİLDİ) ---
        private void KategorileriYukle()
        {
            flowKategoriler.Controls.Clear();

            // "TÜMÜ" Butonu
            Button btnTumu = new Button();
            btnTumu.Text = "TÜMÜ";
            btnTumu.Tag = 0;
            btnTumu.Size = new Size(120, 50); // Biraz daha geniş
            btnTumu.BackColor = Color.FromArgb(64, 64, 64);
            btnTumu.ForeColor = Color.White;
            btnTumu.FlatStyle = FlatStyle.Flat;
            btnTumu.Margin = new Padding(3); // Boşluk bırak
            btnTumu.Click += Kategori_Click;
            flowKategoriler.Controls.Add(btnTumu);

            DataTable kategoriler = db.KategorileriGetir();
            foreach (DataRow row in kategoriler.Rows)
            {
                Button btn = new Button();
                btn.Text = row["KategoriAdi"].ToString();
                btn.Tag = Convert.ToInt32(row["KategoriID"]);
                btn.Size = new Size(120, 50);
                btn.BackColor = Color.Teal;
                btn.ForeColor = Color.White;
                btn.FlatStyle = FlatStyle.Flat;
                btn.Margin = new Padding(3); // Boşluk bırak
                btn.Click += Kategori_Click;
                flowKategoriler.Controls.Add(btn);
            }
        }

        private void Kategori_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            _seciliKategoriID = (int)btn.Tag;

            // Kategori butonlarının renklerini güncelle (Seçili olanı belli et)
            foreach (Control c in flowKategoriler.Controls)
            {
                if (c is Button b) 
                    b.BackColor = ((int)b.Tag == _seciliKategoriID) ? Color.DarkOrange : Color.Teal;
            }
            // "Tümü" butonu rengi özel
            if (_seciliKategoriID == 0) ((Button)flowKategoriler.Controls[0]).BackColor = Color.DarkOrange;
            else ((Button)flowKategoriler.Controls[0]).BackColor = Color.FromArgb(64, 64, 64);


            // Arama kutusunu temizle
            Control[] txtMatches = this.Controls.Find("txtArama", true);
            if (txtMatches.Length > 0)
            {
                try { ((ReaLTaiizor.Controls.MaterialTextBoxEdit)txtMatches[0]).Text = ""; } catch { }
            }

            UrunleriFiltreleVeGoster();
        }

        // --- ÜRÜNLER VE FİLTRELEME (DÜZELTİLDİ) ---
        private void txtArama_TextChanged(object sender, EventArgs e)
        {
            UrunleriFiltreleVeGoster();
        }

        private void UrunleriFiltreleVeGoster()
        {
            flowUrunler.Controls.Clear();
            // Performans için görünürlüğü kapatıp açabiliriz ama şimdilik basit tutalım.
            
            string arananKelime = "";
            Control[] matches = this.Controls.Find("txtArama", true);
            if (matches.Length > 0)
            {
                try { arananKelime = ((ReaLTaiizor.Controls.MaterialTextBoxEdit)matches[0]).Text.ToLower(); } catch { }
            }

            foreach (DataRow row in _tumUrunlerCache.Rows)
            {
                // 1. Kategori Filtresi
                bool kategoriUygun = false;
                if (_seciliKategoriID == 0) 
                {
                    kategoriUygun = true; // Tümü seçiliyse hepsi uygun
                }
                else if (row.Table.Columns.Contains("KategoriID") && row["KategoriID"] != DBNull.Value)
                {
                    // ADIM 1'deki VeritabaniIslemleri değişikliği sayesinde bu sütun artık var!
                    if (Convert.ToInt32(row["KategoriID"]) == _seciliKategoriID) 
                        kategoriUygun = true;
                }

                // 2. Arama Metni Filtresi
                string urunAdi = row["UrunAdi"].ToString().ToLower();
                bool aramaUygun = urunAdi.Contains(arananKelime);

                if (kategoriUygun && aramaUygun)
                {
                    Button btn = new Button();
                    btn.Text = $"{row["UrunAdi"]}\n{row["Fiyat"]} ₺";
                    btn.Size = new Size(110, 80);
                    btn.BackColor = Color.WhiteSmoke;
                    btn.ForeColor = Color.Black;
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.Margin = new Padding(5); // Butonlar birbirine girmesin

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

        // --- SEPET ---
        private void Urun_Click(object sender, EventArgs e)
        {
            if (_seciliMasaID == -1)
            {
                MessageBox.Show("Lütfen önce sol taraftan bir masa seçin!", "Uyarı");
                return;
            }

            Button btn = (Button)sender;
            SepetUrunDto secilenUrun = (SepetUrunDto)btn.Tag;

            var varOlan = _yeniSiparisListesi.Find(x => x.UrunID == secilenUrun.UrunID);
            if (varOlan != null) varOlan.Adet++;
            else _yeniSiparisListesi.Add(new SepetUrunDto { UrunID = secilenUrun.UrunID, Adet = 1, BirimFiyat = secilenUrun.BirimFiyat });

            SepetiVeGridiGuncelle();
        }

        private void SepetiVeGridiGuncelle()
        {
            dgMevcutUrunler.Rows.Clear();

            if (_seciliMasaDurumu == "Dolu")
            {
                List<SiparisUrunModel> eskiler = db.MasaSiparisleriniGetir(_seciliMasaID);
                foreach (var urun in eskiler)
                {
                    int i = dgMevcutUrunler.Rows.Add(urun.UrunAdi, urun.Adet, urun.AraToplam, "Mutfakta");
                    dgMevcutUrunler.Rows[i].DefaultCellStyle.BackColor = Color.LightGray;
                }
            }

            foreach (var urun in _yeniSiparisListesi)
            {
                string ad = "Ürün";
                DataRow[] rows = _tumUrunlerCache.Select("UrunID=" + urun.UrunID);
                if (rows.Length > 0) ad = rows[0]["UrunAdi"].ToString();
                int i = dgMevcutUrunler.Rows.Add(ad, urun.Adet, (urun.Adet * urun.BirimFiyat), "Yeni");
                dgMevcutUrunler.Rows[i].DefaultCellStyle.BackColor = Color.White;
            }
            dgMevcutUrunler.ClearSelection();
        }

        // --- BUTONLAR ---
        private void btnOnayla_Click(object sender, EventArgs e)
        {
            if (_seciliMasaID == -1 || _yeniSiparisListesi.Count == 0) return;
            bool sonuc = false;
            int garsonID = AktifKullanici.KullaniciID;

            if (_seciliMasaDurumu == "Boş" || _seciliMasaDurumu == "Rezerve")
                sonuc = db.SiparisOlusturVeOnayla(_seciliMasaID, garsonID, _yeniSiparisListesi);
            else
                sonuc = db.EkSiparisEkle(_seciliMasaID, _yeniSiparisListesi);

            if (sonuc)
            {
                MessageBox.Show("Sipariş gönderildi.");
                _yeniSiparisListesi.Clear();
                MasalariYukle();
                _seciliMasaDurumu = "Dolu";
                SepetiVeGridiGuncelle();
            }
        }

        private void btnVazgec_Click(object sender, EventArgs e)
        {
            _yeniSiparisListesi.Clear();
            SepetiVeGridiGuncelle();
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

        // TASARIMDA BUTONA ÇİFT TIKLAYIP BAĞLA
        private void btnRezerve_Click_1(object sender, EventArgs e)
        {
            if (_seciliMasaID == -1) { MessageBox.Show("Masa seçiniz."); return; }
            if (_seciliMasaDurumu == "Dolu") { MessageBox.Show("Dolu masa rezerve edilemez."); return; }

            string yeniDurum = (_seciliMasaDurumu == "Boş") ? "Rezerve" : "Boş";
            if (db.MasaDurumGuncelle(_seciliMasaID, yeniDurum))
            {
                MasalariYukle();
                _seciliMasaDurumu = yeniDurum;
                MessageBox.Show(yeniDurum == "Rezerve" ? "Masa rezerve edildi." : "Rezervasyon kaldırıldı.");
            }
        }
        
        // Eğer tasarımda çift tıkla oluşturulmuş fazladan bir click eventi varsa (btnRezerve_Click_1 gibi), onu silebilirsin.
    }
}