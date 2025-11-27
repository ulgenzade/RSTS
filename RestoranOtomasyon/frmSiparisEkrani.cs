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
        private int _seciliKategoriID = 0;

        private DataTable _tumUrunlerCache = new DataTable();
        private List<SepetUrunDto> _yeniSiparisListesi = new List<SepetUrunDto>();

        public frmSiparisEkrani()
        {
            InitializeComponent();
        }

        private void frmSiparisEkrani_Load(object sender, EventArgs e)
        {
            if (Controls.Find("materialLabel1", true).Length > 0)
                Controls.Find("materialLabel1", true)[0].Text = "Garson: " + AktifKullanici.AdSoyad;

            ArayuzAyarlariniYap();
            GridAyarlariniYap();
            MasalariYukle();
            KategorileriYukle();

            _tumUrunlerCache = db.UrunleriGetir();
            UrunleriFiltreleVeGoster();
        }

        private void ArayuzAyarlariniYap()
        {
            if (flowKategoriler != null) { flowKategoriler.AutoScroll = true; flowKategoriler.WrapContents = true; }
            if (flowUrunler != null) { flowUrunler.AutoScroll = true; flowUrunler.WrapContents = true; }
        }

        private void GridAyarlariniYap()
        {
            dgMevcutUrunler.Rows.Clear();
            dgMevcutUrunler.Columns.Clear();
            dgMevcutUrunler.ColumnCount = 4;
            dgMevcutUrunler.Columns[0].Name = "UrunAdi"; dgMevcutUrunler.Columns[0].HeaderText = "Ürün Adı";
            dgMevcutUrunler.Columns[1].Name = "Adet"; dgMevcutUrunler.Columns[1].HeaderText = "Adet";
            dgMevcutUrunler.Columns[2].Name = "Fiyat"; dgMevcutUrunler.Columns[2].HeaderText = "Fiyat";
            dgMevcutUrunler.Columns[3].Name = "Durum"; dgMevcutUrunler.Columns[3].HeaderText = "Durum";
            dgMevcutUrunler.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgMevcutUrunler.AllowUserToAddRows = false;
            dgMevcutUrunler.ReadOnly = true;
            dgMevcutUrunler.RowHeadersVisible = false;
        }

        // --- MASALARI YÜKLE ---
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
                btn.ForeColor = Color.White;
                btn.Margin = new Padding(5);

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

        // --- KATEGORİLER ---
        private void KategorileriYukle()
        {
            flowKategoriler.Controls.Clear();
            Button btnTumu = new Button();
            btnTumu.Text = "TÜMÜ";
            btnTumu.Tag = 0;
            btnTumu.Size = new Size(120, 50);
            btnTumu.BackColor = Color.DarkOrange;
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
                btn.Size = new Size(120, 50);
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
            foreach (Control c in flowKategoriler.Controls)
            {
                if (c is Button b)
                    b.BackColor = ((int)b.Tag == _seciliKategoriID) ? Color.DarkOrange : Color.Teal;
            }
            UrunleriFiltreleVeGoster();
        }

        private void UrunleriFiltreleVeGoster()
        {
            flowUrunler.Controls.Clear();
            string aranan = "";
            if (Controls.Find("txtArama", true).Length > 0)
                aranan = Controls.Find("txtArama", true)[0].Text.ToLower();

            foreach (DataRow row in _tumUrunlerCache.Rows)
            {
                bool kategoriUygun = (_seciliKategoriID == 0);
                if (!kategoriUygun && row.Table.Columns.Contains("KategoriID") && row["KategoriID"] != DBNull.Value)
                {
                    if (Convert.ToInt32(row["KategoriID"]) == _seciliKategoriID) kategoriUygun = true;
                }

                string urunAdi = row["UrunAdi"].ToString().ToLower();
                if (!urunAdi.Contains(aranan)) continue;

                if (kategoriUygun)
                {
                    Button btn = new Button();
                    btn.Text = $"{row["UrunAdi"]}\n{row["Fiyat"]} ₺";
                    btn.Size = new Size(110, 80);
                    btn.BackColor = Color.WhiteSmoke;
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.Margin = new Padding(5);

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
                MessageBox.Show("Lütfen önce sol taraftan bir masa seçin!");
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
                MessageBox.Show("Sipariş mutfağa gönderildi.");
                _yeniSiparisListesi.Clear();
                MasalariYukle();
                _seciliMasaDurumu = "Dolu";
                SepetiVeGridiGuncelle();
            }
        }

        // ================================================================
        // ÖDEME BUTONU (Püf Nokta Burası!)
        // ================================================================
        private void btnOdeme_Click(object sender, EventArgs e)
        {
            if (_seciliMasaID == -1)
            {
                MessageBox.Show("Lütfen ödeme almak için dolu bir masa seçin.");
                return;
            }

            // 1. Ödeme Ekranını "Dialog" olarak açıyoruz.
            // Bu şu demek: Ödeme ekranı kapanana kadar arka plandaki kodlar DURUR.
            frmOdemeEkrani odeme = new frmOdemeEkrani(_seciliMasaID);
            odeme.ShowDialog();

            // 2. Ödeme ekranı kapandığı an (Close() tetiklenince) kod buraya düşer.
            // Şimdi masaları veritabanından tekrar çekip boyuyoruz.
            MasalariYukle();

            // Ekranı temizliyoruz
            _yeniSiparisListesi.Clear();
            _seciliMasaID = -1;
            _seciliMasaDurumu = "";
            dgMevcutUrunler.Rows.Clear();
        }

        private void btnVazgec_Click(object sender, EventArgs e)
        {
            _yeniSiparisListesi.Clear();
            SepetiVeGridiGuncelle();
        }

        private void btnGeriDon_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtArama_TextChanged(object sender, EventArgs e) { UrunleriFiltreleVeGoster(); }
        private void btnRezerve_Click_1(object sender, EventArgs e) { }
    }
}