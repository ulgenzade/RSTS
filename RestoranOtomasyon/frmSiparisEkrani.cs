using RestoranOtomasyon;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
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
        private List<SiparisUrunModel> _eskiSiparisCache = new List<SiparisUrunModel>();
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
            OlaylariBagla();
            GridAyarlariniYap();

            MasalariYukle();
            KategorileriYukle();

            _tumUrunlerCache = db.UrunleriGetir();
            UrunleriFiltreleVeGoster();
        }

        private void OlaylariBagla()
        {
            Control[] txtMatches = this.Controls.Find("txtArama", true);
            if (txtMatches.Length > 0)
            {
                try { ((ReaLTaiizor.Controls.MaterialTextBoxEdit)txtMatches[0]).TextChanged += txtArama_TextChanged; } catch { }
            }
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
            dgMevcutUrunler.Columns[0].Name = "UrunAdi"; dgMevcutUrunler.Columns[0].HeaderText = "Ürün Adı"; dgMevcutUrunler.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgMevcutUrunler.Columns[1].Name = "Adet"; dgMevcutUrunler.Columns[1].HeaderText = "Adet"; dgMevcutUrunler.Columns[1].Width = 50;
            dgMevcutUrunler.Columns[2].Name = "Fiyat"; dgMevcutUrunler.Columns[2].HeaderText = "Fiyat"; dgMevcutUrunler.Columns[2].Width = 70;
            dgMevcutUrunler.Columns[3].Name = "Durum"; dgMevcutUrunler.Columns[3].HeaderText = "Durum"; dgMevcutUrunler.Columns[3].Width = 80;
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
                btn.Font = new Font("Segoe UI", 10, FontStyle.Bold);
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

        private async void Masa_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            DataRow row = (DataRow)btn.Tag;

            _seciliMasaID = Convert.ToInt32(row["MasaID"]);
            _seciliMasaDurumu = row["Durum"].ToString();

            _yeniSiparisListesi.Clear();
            _eskiSiparisCache.Clear();

            if (_seciliMasaDurumu == "Dolu")
            {
                // Veritabanından asenkron çek
                _eskiSiparisCache = await db.MasaSiparisleriniGetirAsync(_seciliMasaID);
            }

            // Grid güncelle
            await SepetiVeGridiGuncelle();
        }

        // --- KATEGORİLER ---
        private void KategorileriYukle()
        {
            if (flowKategoriler == null) return;
            flowKategoriler.Controls.Clear();

            Button btnTumu = new Button();
            btnTumu.Text = "TÜMÜ";
            btnTumu.Tag = 0;
            btnTumu.Size = new Size(100, 50);
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
                btn.Size = new Size(100, 50);
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
                if (c is Button b) b.BackColor = ((int)b.Tag == _seciliKategoriID) ? Color.DarkOrange : Color.Teal;

            Control[] txtMatches = this.Controls.Find("txtArama", true);
            if (txtMatches.Length > 0)
            {
                try { ((ReaLTaiizor.Controls.MaterialTextBoxEdit)txtMatches[0]).Text = ""; } catch { }
            }
            UrunleriFiltreleVeGoster();
        }


        private void UrunleriFiltreleVeGoster()
        {
            if (flowUrunler == null) return;
            flowUrunler.Controls.Clear();
            flowUrunler.SuspendLayout();

            string arananKelime = "";
            Control[] matches = this.Controls.Find("txtArama", true);
            if (matches.Length > 0)
            {
                try { arananKelime = ((ReaLTaiizor.Controls.MaterialTextBoxEdit)matches[0]).Text.ToLower(); } catch { }
            }

            foreach (DataRow row in _tumUrunlerCache.Rows)
            {
                bool kategoriUygun = _seciliKategoriID == 0;
                if (!kategoriUygun && row.Table.Columns.Contains("KategoriID") && row["KategoriID"] != DBNull.Value)
                {
                    if (Convert.ToInt32(row["KategoriID"]) == _seciliKategoriID) kategoriUygun = true;
                }

                string urunAdi = row["UrunAdi"].ToString().ToLower();
                if (!urunAdi.Contains(arananKelime)) continue;

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
            flowUrunler.ResumeLayout();
        }

        private async void Urun_Click(object sender, EventArgs e)
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
            else _yeniSiparisListesi.Add(new SepetUrunDto
            {
                UrunID = secilenUrun.UrunID,
                Adet = 1,
                BirimFiyat = secilenUrun.BirimFiyat
            });

            await SepetiVeGridiGuncelle();
        }

        private async Task SepetiVeGridiGuncelle()
        {
            dgMevcutUrunler.Rows.Clear();

            // 1. ESKİ SİPARİŞLER (Hafızadan)
            if (_eskiSiparisCache != null && _eskiSiparisCache.Count > 0)
            {
                foreach (var urun in _eskiSiparisCache)
                {
                    decimal toplam = urun.Adet * urun.BirimFiyat;
                    int i = dgMevcutUrunler.Rows.Add(urun.UrunAdi, urun.Adet, toplam, "Mutfakta");
                    dgMevcutUrunler.Rows[i].DefaultCellStyle.BackColor = Color.LightGray;
                    dgMevcutUrunler.Rows[i].DefaultCellStyle.ForeColor = Color.DarkGray;
                }
            }

            // 2. YENİ EKLENENLER (Sepet Listesinden)
            foreach (var urun in _yeniSiparisListesi)
            {
                string ad = "Ürün";
                DataRow[] rows = _tumUrunlerCache.Select("UrunID=" + urun.UrunID);
                if (rows.Length > 0) ad = rows[0]["UrunAdi"].ToString();

                int i = dgMevcutUrunler.Rows.Add(ad, urun.Adet, (urun.Adet * urun.BirimFiyat), "Yeni");
                dgMevcutUrunler.Rows[i].DefaultCellStyle.BackColor = Color.White;
                dgMevcutUrunler.Rows[i].DefaultCellStyle.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            }
            dgMevcutUrunler.ClearSelection();

            // Asenkron metodun tamamlanmasını sağlar (boş olsa bile)
            await Task.CompletedTask;
        }

        private async void btnOnayla_Click(object sender, EventArgs e)
        {
            if (_seciliMasaID == -1 || _yeniSiparisListesi.Count == 0) return;

            bool sonuc = false;
            int garsonID = AktifKullanici.KullaniciID;

            // Butona basıldığında UI'yı dondurmamak için geçici bir 'await' koyabiliriz 
            // ama metodumuz zaten senkron. Hızlandırmak için asenkron yapılabilir.

            // Veritabanı işlemini arka planda yap
            await Task.Run(() =>
            {
                if (_seciliMasaDurumu == "Boş" || _seciliMasaDurumu == "Rezerve")
                    sonuc = db.SiparisOlusturVeOnayla(_seciliMasaID, garsonID, _yeniSiparisListesi);
                else
                    sonuc = db.EkSiparisEkle(_seciliMasaID, _yeniSiparisListesi);
            });

            if (sonuc)
            {
                MessageBox.Show("Sipariş mutfağa iletildi!", "Başarılı");
                _yeniSiparisListesi.Clear();
                MasalariYukle(); // Renkleri güncelle

                // Masayı tekrar tıkla ki güncel veriler çekilsin (Burası önemli)
                // Ama manuel buton click yerine sadece veri çekmeyi çağırabiliriz.
                _seciliMasaDurumu = "Dolu";

                // İnternetten güncel hali çekip cache'i güncelle
                _eskiSiparisCache = await db.MasaSiparisleriniGetirAsync(_seciliMasaID);
                await SepetiVeGridiGuncelle();
            }
            else
            {
                MessageBox.Show("Hata oluştu.", "Hata");
            }
        }

        private void btnOdeme_Click(object sender, EventArgs e)
        {
            if (_seciliMasaID == -1) return;
            frmOdemeEkrani odeme = new frmOdemeEkrani(_seciliMasaID);
            odeme.ShowDialog();

            // Döndüğünde
            MasalariYukle();
            dgMevcutUrunler.Rows.Clear();
            _yeniSiparisListesi.Clear();
            _eskiSiparisCache.Clear(); // Cache temizle
            _seciliMasaID = -1;
        }

        private async void btnVazgec_Click(object sender, EventArgs e)
        {
            _yeniSiparisListesi.Clear();
             await SepetiVeGridiGuncelle();
        }

        private void btnGeriDon_Click(object sender, EventArgs e)
        {
            frmGiris g = new frmGiris();
            g.Show();
            this.Close();
        }

        private void txtArama_TextChanged(object sender, EventArgs e) 
        {
            UrunleriFiltreleVeGoster();
        }

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

        private void materialLabel1_Click(object sender, EventArgs e)
        {

        }

        private void txtArama_Click(object sender, EventArgs e)
        {

        }
    }
}