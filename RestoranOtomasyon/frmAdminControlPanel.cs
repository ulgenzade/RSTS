using MySql.Data.MySqlClient;
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
    public partial class frmAdminControlPanel : Form
    {
        private VeritabaniIslemleri db = new VeritabaniIslemleri();

        private string aktifVeriTablosu = "";
        private int _seciliFlowID = -1;
        private Button _seciliFlowButonu = null;
        private int seciliHesapID = -1;

        public frmAdminControlPanel()
        {
            InitializeComponent();
        }

        private async void frmAdminControlPanel_Load_1(object sender, EventArgs e)
        {
            await KullaniciListeleriniDoldurAsync();
            aktifVeriTablosu = "";
            FlowDb.Controls.Clear();

        }

        private async Task KullaniciListeleriniDoldurAsync()
        {
            AdminTree.Nodes.Clear();
            CalisanTree.Nodes.Clear();
            try
            {
                DataTable kullanicilar = await db.KullanicilariGetirAsync();
                if (kullanicilar == null) return;

                foreach (DataRow row in kullanicilar.Rows)
                {
                    TreeNode node = new TreeNode($"{row["AdSoyad"]} ({row["KullaniciAdi"]})");
                    node.Tag = Convert.ToInt32(row["KullaniciID"]);
                    if (row["Rol"].ToString() == "Admin") AdminTree.Nodes.Add(node);
                    else CalisanTree.Nodes.Add(node);
                }
            }
            catch { }
        }


        #region Veri Butonları
        private void btnVeriMasalar_Click(object sender, EventArgs e)
        {
            VerileriYukle("Masalar");


        }

        private void btnVeriUrunler_Click(object sender, EventArgs e)
        {
            VerileriYukle("Urunler");
        }

        private void btnVeriKategoriler_Click(object sender, EventArgs e)
        {
            VerileriYukle("Kategoriler");
        }

        private async void btnVeriSil_Click(object sender, EventArgs e)
        {
            if (aktifVeriTablosu == "Loglar")
            {
                MessageBox.Show("Geçmiş sipariş kayıtları buradan silinemez.", "Güvenlik");
                return;
            }

            if (_seciliFlowID == -1) return;
            if (MessageBox.Show("Silinsin mi?", "Onay", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                bool sonuc = false;
                if (aktifVeriTablosu == "Urunler") sonuc = db.UrunSil(_seciliFlowID);
                else if (aktifVeriTablosu == "Kategoriler") sonuc = db.KategoriSil(_seciliFlowID);
                else if (aktifVeriTablosu == "Masalar") sonuc = db.MasaSil(_seciliFlowID);

                if (sonuc) VerileriYukle(aktifVeriTablosu);
                else MessageBox.Show("Silinemedi.");
            }
            if (_seciliFlowID == -1) return;
        }

        private void btnVeriDuzenle_Click(object sender, EventArgs e)
        {
            if (aktifVeriTablosu == "Loglar")
            {
                MessageBox.Show("Geçmiş sipariş kayıtları düzenlenemez.", "Güvenlik");
                return;
            }

            if (_seciliFlowID == -1) { MessageBox.Show("Seçim yapın."); return; }
            dbDuzenle form = new dbDuzenle(aktifVeriTablosu, _seciliFlowID);
            if (form.ShowDialog() == DialogResult.OK) VerileriYukle(aktifVeriTablosu);
        }

        private void btnVeriIstatistik_Click(object sender, EventArgs e)
        {
            aktifVeriTablosu = "Istatistik";
            _seciliFlowID = -1;

            FlowDb.Controls.Clear();
            FlowDb.AutoScroll = true;

            IstatistikModel veri = db.DetayliIstatistikGetir();

            FlowDb.Controls.Add(IstatistikKartiOlustur("GÜNLÜK RAPOR", veri.GunlukCiro, veri.GunlukSatisAdeti, Color.FromArgb(218, 158, 32), "Gunluk"));
            FlowDb.Controls.Add(IstatistikKartiOlustur("AYLIK RAPOR", veri.AylikCiro, veri.AylikSatisAdeti, Color.FromArgb(52, 152, 219), "Aylik"));
            FlowDb.Controls.Add(IstatistikKartiOlustur("YILLIK RAPOR", veri.YillikCiro, veri.YillikSatisAdeti, Color.FromArgb(155, 89, 182), "Yillik"));
            FlowDb.Controls.Add(IstatistikKartiOlustur("GENEL TOPLAM", veri.ToplamCiro, veri.ToplamSatisAdeti, Color.FromArgb(52, 73, 94), "Tumu"));
        }

        private void btnVeriLoglar_Click(object sender, EventArgs e)
        {
            VerileriYukle("Loglar");
        }

        private void btnVeriEkle_Click_1(object sender, EventArgs e)
        {
            if (aktifVeriTablosu == "") return;
            dbDuzenle form = new dbDuzenle(aktifVeriTablosu, -1);
            if (form.ShowDialog() == DialogResult.OK) VerileriYukle(aktifVeriTablosu);
        }


        #endregion

        #region Hesap Butonları
        private void btnHesapEkle_Click(object sender, EventArgs e)
        {
            treeDuzenle form = new treeDuzenle(-1);
            if (form.ShowDialog() == DialogResult.OK)  KullaniciListeleriniDoldurAsync();
        }

        private async void btnHesapSil_Click(object sender, EventArgs e)
        {
            // 1. Seçim var mı?
            if (seciliHesapID == -1)
            {
                MessageBox.Show("Lütfen silmek için bir kullanıcı seçin.", "Seçim Yok");
                return;
            }

            string kullaniciAdi = AdminTree.SelectedNode?.Text ?? CalisanTree.SelectedNode?.Text;

            if (kullaniciAdi.Contains("deleted_sys") || kullaniciAdi.Contains("Eski Kayıtlar"))
            {
                MessageBox.Show("Bu, sistemin yedekleme hesabıdır. Silinemez!", "Güvenlik Uyarısı", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                // 2. Seçilen Node ile Hafızadaki ID tutuyor mu? (Yanlış silmeyi önler)
                string silinecekIsim = "";
                bool eslesmeVar = false;

                if (AdminTree.SelectedNode != null && Convert.ToInt32(AdminTree.SelectedNode.Tag) == seciliHesapID)
                {
                    silinecekIsim = AdminTree.SelectedNode.Text;
                    eslesmeVar = true;
                }
                else if (CalisanTree.SelectedNode != null && Convert.ToInt32(CalisanTree.SelectedNode.Tag) == seciliHesapID)
                {
                    silinecekIsim = CalisanTree.SelectedNode.Text;
                    eslesmeVar = true;
                }

                if (!eslesmeVar) return; // ID ile seçim uyuşmuyorsa işlem yapma

                // 3. Onay ve Silme
                if (MessageBox.Show($"'{silinecekIsim}' kullanıcısını silmek istediğinize emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    if (db.KullaniciSil(seciliHesapID))
                    {
                        MessageBox.Show("Kullanıcı başarıyla silindi.");
                        await KullaniciListeleriniDoldurAsync(); // Listeyi yenile
                        seciliHesapID = -1; // Seçimi sıfırla
                    }
                    else
                    {
                        MessageBox.Show("Kullanıcı silinemedi.", "Hata");
                    }
                }
            }
        }

        private void btnHesapDuzenle_Click(object sender, EventArgs e)
        {
            if (seciliHesapID == -1) { MessageBox.Show("Lütfen düzenlemek için bir kullanıcı seçin."); return; }

            treeDuzenle form = new treeDuzenle(seciliHesapID);
            if (form.ShowDialog() == DialogResult.OK)  KullaniciListeleriniDoldurAsync();

        }
          
        #endregion

        #region Kullanici Listeleri
        private void KullaniciSecildi(object sender, TreeViewEventArgs e)
        {
            if (e.Node == null || e.Node.Tag == null) return;
            seciliHesapID = Convert.ToInt32(e.Node.Tag);

        }
        private void AdminTree_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (CalisanTree.SelectedNode != null) CalisanTree.SelectedNode = null;
            KullaniciSecildi(sender, e);
        }

        private void CalisanTree_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (AdminTree.SelectedNode != null) AdminTree.SelectedNode = null;
            KullaniciSecildi(sender, e);
        }

        private async void TreeView_AfterLabelEdit(object sender, NodeLabelEditEventArgs e)
        {
            // Eğer kullanıcı düzenlemeyi iptal ettiyse (ESC'ye bastıysa) veya boş bir metin girdiyse
            if (e.Label == null)
            {
                // Eğer bu yeni oluşturulan bir kullanıcıysa ve iptal edildiyse, listeden kaldır.
                if ((int)e.Node.Tag == -1)
                {
                    e.Node.Remove();
                }
                return; // Hiçbir şey yapma
            }

            // Kullanıcının girdiği yeni metni al. Örn: "Yeni İsim (yeni_kullanici_adi)"
            string yeniMetin = e.Label;

            // Bu metinden AdSoyad ve KullaniciAdi'nı ayırmaya çalışalım (basit bir varsayımla).
            string yeniAdSoyad = yeniMetin;

            int kullaniciID = (int)e.Node.Tag;

            bool sonuc = false;
            if (kullaniciID == -1) // EKLEME İŞLEMİ
            {
                // Yeni kullanıcı için varsayılan bir şifre ve rol atamamız gerekiyor.
                // Bu bilgiler daha sonra sağdaki panelden güncellenebilir.
                sonuc = db.KullaniciEkle(yeniAdSoyad, yeniAdSoyad.Replace(" ", "").ToLower(), "12345", "Garson");
                if (sonuc) MessageBox.Show("Yeni kullanıcı varsayılan şifre (12345) ile eklendi.");
            }
            else // GÜNCELLEME İŞLEMİ
            {
                // Sadece AdSoyad'ı güncelleyelim. Diğer bilgiler aynı kalsın.
                // Bunun için TekKullaniciGetir'i kullanabiliriz.
                DataTable dt = db.TekKullaniciGetir(kullaniciID);
                if (dt.Rows.Count > 0)
                {
                    string mevcutKullaniciAdi = dt.Rows[0]["KullaniciAdi"].ToString();
                    string mevcutRol = dt.Rows[0]["Rol"].ToString();
                    // Sadece AdSoyad'ı güncelleyen bir metot çağıralım. Şifre boş gönderildiği için değişmez.
                    sonuc = db.KullaniciGuncelle(kullaniciID, yeniAdSoyad, mevcutKullaniciAdi, "", mevcutRol);
                }
            }

            if (sonuc)
            {
                // Her şey başarılıysa listeyi yenile.
                await KullaniciListeleriniDoldurAsync();
            }
            else
            {
                MessageBox.Show("İşlem sırasında bir hata oluştu.");
                e.CancelEdit = true; // Düzenlemeyi iptal et, eski metne geri dön.
            }
        }
        #endregion

        #region Diğer Olaylar
        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void HesapLabel_Click(object sender, EventArgs e)
        {

        }

        private void VeriButonGroupBox_Load(object sender, EventArgs e)
        {

        }
        #endregion

        #region Sağ panel - Veri Yükleme - Flow Butonları

        private Button IstatistikKartiOlustur(string baslik, decimal ciro, int adet, Color renk, string tag)
        {
            Button btn = new Button();
            btn.Size = new Size(280, 160);
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.BackColor = renk;
            btn.ForeColor = Color.White;
            btn.Font = new Font("Segoe UI", 11, FontStyle.Regular);
            btn.Margin = new Padding(15);
            btn.TextAlign = ContentAlignment.TopLeft;

            // DEĞİŞİKLİK: Tag'i butona işliyoruz
            btn.Tag = tag;

            decimal ortalama = 0;
            if (adet > 0) ortalama = ciro / adet;

            btn.Text = $"{baslik}\n" +
                       "--------------------------\n" +
                       "(Detaylar için tıklayın)\n\n" +
                       $"💰 Ciro: {ciro:C2}\n" +
                       $"🧾 Adisyon: {adet} Adet\n" +
                       $"📊 Ort. Masa: {ortalama:C2}";

            // DEĞİŞİKLİK: Tıklama olayını bağlıyoruz
            btn.Click += IstatistikDetay_Click;

            return btn;
        }

        private void IstatistikDetay_Click(object sender, EventArgs e)
        {
            Button tiklananKart = (Button)sender;
            string periyot = tiklananKart.Tag.ToString();

            FlowDb.Controls.Clear();

            // Geri Dön Butonu
            Button btnGeri = new Button();
            btnGeri.Text = "⬅ İSTATİSTİKLERE DÖN";
            btnGeri.Size = new Size(FlowDb.Width - 40, 40);
            btnGeri.BackColor = Color.DimGray;
            btnGeri.ForeColor = Color.White;
            btnGeri.FlatStyle = FlatStyle.Flat;
            btnGeri.Click += btnVeriIstatistik_Click; // Tıklayınca ana ekrana dön
            FlowDb.Controls.Add(btnGeri);

            // Verileri Çek
            DataTable dt = db.PeriyodikRaporGetir(periyot);

            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Bu dönem için kayıt bulunamadı.");
                return;
            }

            foreach (DataRow row in dt.Rows)
            {
                Button btn = new Button();
                btn.Size = new Size(FlowDb.Width - 50, 60);
                btn.BackColor = Color.White;
                btn.FlatStyle = FlatStyle.Flat;
                btn.TextAlign = ContentAlignment.MiddleLeft;
                btn.Padding = new Padding(10, 0, 0, 0);
                btn.Font = new Font("Consolas", 10);

                string tarih = Convert.ToDateTime(row["AcilisZamani"]).ToString("dd.MM.yyyy HH:mm");
                string masa = row["MasaAdi"].ToString();
                string garson = row["AdSoyad"].ToString();
                string tutar = Convert.ToDecimal(row["ToplamTutar"]).ToString("C2");

                btn.Text = $"{tarih} | {masa} | Garson: {garson} | Tutar: {tutar}";
                FlowDb.Controls.Add(btn);
            }
        }

        private void FlowItem_Click(object sender, EventArgs e)
        {
            if (_seciliFlowButonu != null) _seciliFlowButonu.BackColor = Color.White;
            Button tiklanan = (Button)sender;
            _seciliFlowID = (int)tiklanan.Tag;
            _seciliFlowButonu = tiklanan;
            tiklanan.BackColor = Color.LightSkyBlue;
        }

        private void FlowDb_Click(object sender, EventArgs e)
        {

        }

        private void VerileriYukle(string tablo)
        {
            aktifVeriTablosu = tablo;
            _seciliFlowID = -1;
            _seciliFlowButonu = null;

            FlowDb.Controls.Clear();
            FlowDb.AutoScroll = true;

            DataTable dt = new DataTable();

            // Verileri Çek
            if (tablo == "Urunler") dt = db.UrunleriGetir();
            else if (tablo == "Kategoriler") dt = db.KategorileriGetir();
            else if (tablo == "Masalar") dt = db.MasalariGetir();
            else if (tablo == "Loglar") dt = db.TumSiparisleriGetir(); // Logları çekiyoruz

            foreach (DataRow row in dt.Rows)
            {
                Button btn = new Button();
                btn.FlatStyle = FlatStyle.Flat;
                btn.BackColor = Color.White;
                btn.ForeColor = Color.Black;
                btn.Font = new Font("Segoe UI", 10, FontStyle.Bold);
                btn.Margin = new Padding(10);

                // ID'yi her zaman ilk sütundan alıyoruz (SiparisID, UrunID vs.)
                int id = Convert.ToInt32(row[0]);
                btn.Tag = id;

                // --- TABLOYA GÖRE BUTON TASARIMI ---

                if (tablo == "Urunler")
                {
                    btn.Size = new Size(200, 80);
                    btn.Text = $"{row["UrunAdi"]}\n{row["Fiyat"]} TL\n({row["KategoriAdi"]})";
                }
                else if (tablo == "Kategoriler")
                {
                    btn.Size = new Size(200, 80);
                    btn.Text = row["KategoriAdi"].ToString();
                }
                else if (tablo == "Masalar")
                {
                    btn.Size = new Size(200, 80);
                    string durum = row["Durum"].ToString();
                    btn.Text = $"{row["MasaAdi"]}\n({durum})";
                    // Masa durumuna göre renk (Görsel Güzellik)
                    if (durum == "Dolu") btn.BackColor = Color.MistyRose;
                }
                else if (tablo == "Loglar")
                {
                    // LOGLAR İÇİN ÖZEL TASARIM
                    // Log kartları daha büyük olsun ki bilgiler sığsın
                    btn.Size = new Size(260, 120);

                    string masa = row["MasaAdi"].ToString();
                    string garson = row["AdSoyad"].ToString();
                    string tarih = Convert.ToDateTime(row["AcilisZamani"]).ToString("dd.MM HH:mm");
                    string tutar = row["ToplamTutar"].ToString();
                    string durum = row["OdemeDurumu"].ToString();

                    btn.Text = $"Sipariş #{id}\n{masa} - {garson}\n{tarih}\n{tutar} TL\n[{durum}]";

                    // Ödenmişse Yeşilimsi/Gri, Aktifse Turuncu yapalım ki dikkat çeksin
                    if (durum == "Ödendi")
                    {
                        btn.BackColor = Color.WhiteSmoke;
                        btn.ForeColor = Color.DimGray;
                    }
                    else
                    {
                        btn.BackColor = Color.LightYellow;
                        btn.ForeColor = Color.DarkRed;
                    }
                }

                // Tıklama olayını bağla
                btn.Click += FlowItem_Click;
                FlowDb.Controls.Add(btn);
            }
        }

        #endregion

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode37 = new System.Windows.Forms.TreeNode("Çalışan Hesaplar");
            System.Windows.Forms.TreeNode treeNode38 = new System.Windows.Forms.TreeNode("Yetkili Hesaplar");
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.HesapLabel = new ReaLTaiizor.Controls.MetroLabel();
            this.CalisanLabel = new ReaLTaiizor.Controls.MetroLabel();
            this.CalisanTree = new ReaLTaiizor.Controls.ForeverTreeView();
            this.AdminLabel = new ReaLTaiizor.Controls.MetroLabel();
            this.AdminTree = new ReaLTaiizor.Controls.ForeverTreeView();
            this.btnCikis = new ReaLTaiizor.Controls.MaterialButton();
            this.btnHesapDuzenle = new ReaLTaiizor.Controls.MaterialButton();
            this.btnHesapSil = new ReaLTaiizor.Controls.MaterialButton();
            this.btnHesapEkle = new ReaLTaiizor.Controls.MaterialButton();
            this.FlowDb = new System.Windows.Forms.FlowLayoutPanel();
            this.btnVeriLoglar = new ReaLTaiizor.Controls.MaterialButton();
            this.btnVeriKategoriler = new ReaLTaiizor.Controls.MaterialButton();
            this.btnVeriUrunler = new ReaLTaiizor.Controls.MaterialButton();
            this.btnVeriMasalar = new ReaLTaiizor.Controls.MaterialButton();
            this.btnVeriIstatistik = new ReaLTaiizor.Controls.MaterialButton();
            this.btnVeriDuzenle = new ReaLTaiizor.Controls.MaterialButton();
            this.btnVeriSil = new ReaLTaiizor.Controls.MaterialButton();
            this.btnVeriEkle = new ReaLTaiizor.Controls.MaterialButton();
            this.VeriKategoriButonPanel = new System.Windows.Forms.Panel();
            this.VeriKategoriLayout = new System.Windows.Forms.TableLayoutPanel();
            this.VeriButonPanel = new System.Windows.Forms.Panel();
            this.VeriButonLayout = new System.Windows.Forms.TableLayoutPanel();
            this.HesapButonPanel = new System.Windows.Forms.Panel();
            this.HesapButonLayout = new System.Windows.Forms.TableLayoutPanel();
            this.HesapBaslikPanel = new System.Windows.Forms.Panel();
            this.HesapPanel = new System.Windows.Forms.Panel();
            this.HesaplarLayout = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.VeriKategoriButonPanel.SuspendLayout();
            this.VeriKategoriLayout.SuspendLayout();
            this.VeriButonPanel.SuspendLayout();
            this.VeriButonLayout.SuspendLayout();
            this.HesapButonPanel.SuspendLayout();
            this.HesapButonLayout.SuspendLayout();
            this.HesapBaslikPanel.SuspendLayout();
            this.HesapPanel.SuspendLayout();
            this.HesaplarLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.HesaplarLayout);
            this.splitContainer1.Panel1.Controls.Add(this.HesapBaslikPanel);
            this.splitContainer1.Panel1.Controls.Add(this.HesapButonPanel);
            this.splitContainer1.Panel1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.splitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.FlowDb);
            this.splitContainer1.Panel2.Controls.Add(this.VeriKategoriButonPanel);
            this.splitContainer1.Panel2.Controls.Add(this.VeriButonPanel);
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint_1);
            this.splitContainer1.Size = new System.Drawing.Size(1282, 673);
            this.splitContainer1.SplitterDistance = 424;
            this.splitContainer1.TabIndex = 0;
            // 
            // HesapLabel
            // 
            this.HesapLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HesapLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.HesapLabel.IsDerivedStyle = true;
            this.HesapLabel.Location = new System.Drawing.Point(0, 0);
            this.HesapLabel.Name = "HesapLabel";
            this.HesapLabel.Size = new System.Drawing.Size(418, 54);
            this.HesapLabel.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            this.HesapLabel.StyleManager = null;
            this.HesapLabel.TabIndex = 0;
            this.HesapLabel.Text = "HESAPLAR";
            this.HesapLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.HesapLabel.ThemeAuthor = "Taiizor";
            this.HesapLabel.ThemeName = "MetroLight";
            this.HesapLabel.Click += new System.EventHandler(this.HesapLabel_Click);
            // 
            // CalisanLabel
            // 
            this.CalisanLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CalisanLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CalisanLabel.IsDerivedStyle = true;
            this.CalisanLabel.Location = new System.Drawing.Point(3, 276);
            this.CalisanLabel.Name = "CalisanLabel";
            this.CalisanLabel.Size = new System.Drawing.Size(418, 46);
            this.CalisanLabel.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            this.CalisanLabel.StyleManager = null;
            this.CalisanLabel.TabIndex = 9;
            this.CalisanLabel.Text = "Çalışan Hesaplar";
            this.CalisanLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CalisanLabel.ThemeAuthor = "Taiizor";
            this.CalisanLabel.ThemeName = "MetroLight";
            // 
            // CalisanTree
            // 
            this.CalisanTree.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.CalisanTree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CalisanTree.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CalisanTree.ForeColor = System.Drawing.Color.White;
            this.CalisanTree.LabelEdit = true;
            this.CalisanTree.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(29)))));
            this.CalisanTree.Location = new System.Drawing.Point(3, 325);
            this.CalisanTree.Name = "CalisanTree";
            treeNode37.Name = "CalisanNodes";
            treeNode37.Text = "Çalışan Hesaplar";
            this.CalisanTree.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode37});
            this.CalisanTree.Size = new System.Drawing.Size(418, 225);
            this.CalisanTree.TabIndex = 11;
            this.CalisanTree.AfterLabelEdit += new System.Windows.Forms.NodeLabelEditEventHandler(this.TreeView_AfterLabelEdit);
            this.CalisanTree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.CalisanTree_AfterSelect);
            // 
            // AdminLabel
            // 
            this.AdminLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AdminLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AdminLabel.IsDerivedStyle = true;
            this.AdminLabel.Location = new System.Drawing.Point(3, 0);
            this.AdminLabel.Name = "AdminLabel";
            this.AdminLabel.Size = new System.Drawing.Size(418, 46);
            this.AdminLabel.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            this.AdminLabel.StyleManager = null;
            this.AdminLabel.TabIndex = 8;
            this.AdminLabel.Text = "Yetkili Hesaplar";
            this.AdminLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AdminLabel.ThemeAuthor = "Taiizor";
            this.AdminLabel.ThemeName = "MetroLight";
            this.AdminLabel.Click += new System.EventHandler(this.AdminLabel_Click);
            // 
            // AdminTree
            // 
            this.AdminTree.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.AdminTree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AdminTree.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AdminTree.ForeColor = System.Drawing.Color.White;
            this.AdminTree.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(29)))));
            this.AdminTree.Location = new System.Drawing.Point(3, 49);
            this.AdminTree.Name = "AdminTree";
            treeNode38.Name = "AdminNodes";
            treeNode38.Text = "Yetkili Hesaplar";
            this.AdminTree.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode38});
            this.AdminTree.Size = new System.Drawing.Size(418, 224);
            this.AdminTree.TabIndex = 10;
            this.AdminTree.AfterLabelEdit += new System.Windows.Forms.NodeLabelEditEventHandler(this.TreeView_AfterLabelEdit);
            this.AdminTree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.AdminTree_AfterSelect);
            // 
            // btnCikis
            // 
            this.btnCikis.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCikis.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnCikis.Depth = 0;
            this.btnCikis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCikis.HighEmphasis = true;
            this.btnCikis.Icon = null;
            this.btnCikis.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.btnCikis.Location = new System.Drawing.Point(23, 6);
            this.btnCikis.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCikis.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnCikis.Size = new System.Drawing.Size(79, 42);
            this.btnCikis.TabIndex = 6;
            this.btnCikis.Text = "ÇIKIŞ";
            this.btnCikis.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnCikis.UseAccentColor = false;
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // btnHesapDuzenle
            // 
            this.btnHesapDuzenle.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnHesapDuzenle.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnHesapDuzenle.Depth = 0;
            this.btnHesapDuzenle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnHesapDuzenle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHesapDuzenle.HighEmphasis = true;
            this.btnHesapDuzenle.Icon = null;
            this.btnHesapDuzenle.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.btnHesapDuzenle.Location = new System.Drawing.Point(311, 6);
            this.btnHesapDuzenle.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnHesapDuzenle.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.btnHesapDuzenle.Name = "btnHesapDuzenle";
            this.btnHesapDuzenle.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnHesapDuzenle.Size = new System.Drawing.Size(79, 42);
            this.btnHesapDuzenle.TabIndex = 5;
            this.btnHesapDuzenle.Text = "DÜZENLE";
            this.btnHesapDuzenle.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnHesapDuzenle.UseAccentColor = false;
            this.btnHesapDuzenle.UseVisualStyleBackColor = true;
            this.btnHesapDuzenle.Click += new System.EventHandler(this.btnHesapDuzenle_Click);
            // 
            // btnHesapSil
            // 
            this.btnHesapSil.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnHesapSil.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnHesapSil.Depth = 0;
            this.btnHesapSil.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnHesapSil.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHesapSil.HighEmphasis = true;
            this.btnHesapSil.Icon = null;
            this.btnHesapSil.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.btnHesapSil.Location = new System.Drawing.Point(215, 6);
            this.btnHesapSil.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnHesapSil.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.btnHesapSil.Name = "btnHesapSil";
            this.btnHesapSil.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnHesapSil.Size = new System.Drawing.Size(79, 42);
            this.btnHesapSil.TabIndex = 3;
            this.btnHesapSil.Text = "SİL";
            this.btnHesapSil.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnHesapSil.UseAccentColor = false;
            this.btnHesapSil.UseVisualStyleBackColor = true;
            this.btnHesapSil.Click += new System.EventHandler(this.btnHesapSil_Click);
            // 
            // btnHesapEkle
            // 
            this.btnHesapEkle.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnHesapEkle.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnHesapEkle.Depth = 0;
            this.btnHesapEkle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnHesapEkle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHesapEkle.HighEmphasis = true;
            this.btnHesapEkle.Icon = null;
            this.btnHesapEkle.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.btnHesapEkle.Location = new System.Drawing.Point(119, 6);
            this.btnHesapEkle.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnHesapEkle.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.btnHesapEkle.Name = "btnHesapEkle";
            this.btnHesapEkle.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnHesapEkle.Size = new System.Drawing.Size(79, 42);
            this.btnHesapEkle.TabIndex = 1;
            this.btnHesapEkle.Text = "EKLE";
            this.btnHesapEkle.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnHesapEkle.UseAccentColor = false;
            this.btnHesapEkle.UseVisualStyleBackColor = true;
            this.btnHesapEkle.Click += new System.EventHandler(this.btnHesapEkle_Click);
            // 
            // FlowDb
            // 
            this.FlowDb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FlowDb.Location = new System.Drawing.Point(0, 60);
            this.FlowDb.Name = "FlowDb";
            this.FlowDb.Padding = new System.Windows.Forms.Padding(70, 3, 0, 3);
            this.FlowDb.Size = new System.Drawing.Size(854, 553);
            this.FlowDb.TabIndex = 11;
            this.FlowDb.Click += new System.EventHandler(this.FlowDb_Click);
            // 
            // btnVeriLoglar
            // 
            this.btnVeriLoglar.AutoSize = false;
            this.btnVeriLoglar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnVeriLoglar.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnVeriLoglar.Depth = 0;
            this.btnVeriLoglar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnVeriLoglar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVeriLoglar.HighEmphasis = true;
            this.btnVeriLoglar.Icon = null;
            this.btnVeriLoglar.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.btnVeriLoglar.Location = new System.Drawing.Point(626, 6);
            this.btnVeriLoglar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnVeriLoglar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.btnVeriLoglar.Name = "btnVeriLoglar";
            this.btnVeriLoglar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnVeriLoglar.Size = new System.Drawing.Size(139, 42);
            this.btnVeriLoglar.TabIndex = 4;
            this.btnVeriLoglar.Text = "KAYITLAR";
            this.btnVeriLoglar.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnVeriLoglar.UseAccentColor = false;
            this.btnVeriLoglar.UseVisualStyleBackColor = true;
            this.btnVeriLoglar.Click += new System.EventHandler(this.btnVeriLoglar_Click);
            // 
            // btnVeriKategoriler
            // 
            this.btnVeriKategoriler.AutoSize = false;
            this.btnVeriKategoriler.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnVeriKategoriler.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnVeriKategoriler.Depth = 0;
            this.btnVeriKategoriler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnVeriKategoriler.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVeriKategoriler.HighEmphasis = true;
            this.btnVeriKategoriler.Icon = null;
            this.btnVeriKategoriler.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.btnVeriKategoriler.Location = new System.Drawing.Point(443, 6);
            this.btnVeriKategoriler.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnVeriKategoriler.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.btnVeriKategoriler.Name = "btnVeriKategoriler";
            this.btnVeriKategoriler.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnVeriKategoriler.Size = new System.Drawing.Size(139, 42);
            this.btnVeriKategoriler.TabIndex = 3;
            this.btnVeriKategoriler.Text = "KATEGORİLER";
            this.btnVeriKategoriler.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnVeriKategoriler.UseAccentColor = false;
            this.btnVeriKategoriler.UseVisualStyleBackColor = true;
            this.btnVeriKategoriler.Click += new System.EventHandler(this.btnVeriKategoriler_Click);
            // 
            // btnVeriUrunler
            // 
            this.btnVeriUrunler.AutoSize = false;
            this.btnVeriUrunler.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnVeriUrunler.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnVeriUrunler.Depth = 0;
            this.btnVeriUrunler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnVeriUrunler.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnVeriUrunler.HighEmphasis = true;
            this.btnVeriUrunler.Icon = null;
            this.btnVeriUrunler.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.btnVeriUrunler.Location = new System.Drawing.Point(260, 6);
            this.btnVeriUrunler.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnVeriUrunler.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.btnVeriUrunler.Name = "btnVeriUrunler";
            this.btnVeriUrunler.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnVeriUrunler.Size = new System.Drawing.Size(139, 42);
            this.btnVeriUrunler.TabIndex = 2;
            this.btnVeriUrunler.Text = "ÜRÜNLER";
            this.btnVeriUrunler.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnVeriUrunler.UseAccentColor = false;
            this.btnVeriUrunler.UseVisualStyleBackColor = true;
            this.btnVeriUrunler.Click += new System.EventHandler(this.btnVeriUrunler_Click);
            // 
            // btnVeriMasalar
            // 
            this.btnVeriMasalar.AutoSize = false;
            this.btnVeriMasalar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnVeriMasalar.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnVeriMasalar.Depth = 0;
            this.btnVeriMasalar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnVeriMasalar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVeriMasalar.HighEmphasis = true;
            this.btnVeriMasalar.Icon = null;
            this.btnVeriMasalar.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.btnVeriMasalar.Location = new System.Drawing.Point(77, 6);
            this.btnVeriMasalar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnVeriMasalar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.btnVeriMasalar.Name = "btnVeriMasalar";
            this.btnVeriMasalar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnVeriMasalar.Size = new System.Drawing.Size(139, 42);
            this.btnVeriMasalar.TabIndex = 1;
            this.btnVeriMasalar.Text = "Masalar";
            this.btnVeriMasalar.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnVeriMasalar.UseAccentColor = false;
            this.btnVeriMasalar.UseVisualStyleBackColor = true;
            this.btnVeriMasalar.Click += new System.EventHandler(this.btnVeriMasalar_Click);
            // 
            // btnVeriIstatistik
            // 
            this.btnVeriIstatistik.AutoSize = false;
            this.btnVeriIstatistik.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnVeriIstatistik.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnVeriIstatistik.Depth = 0;
            this.btnVeriIstatistik.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnVeriIstatistik.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVeriIstatistik.HighEmphasis = true;
            this.btnVeriIstatistik.Icon = null;
            this.btnVeriIstatistik.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.btnVeriIstatistik.Location = new System.Drawing.Point(626, 6);
            this.btnVeriIstatistik.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnVeriIstatistik.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.btnVeriIstatistik.Name = "btnVeriIstatistik";
            this.btnVeriIstatistik.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnVeriIstatistik.Size = new System.Drawing.Size(139, 42);
            this.btnVeriIstatistik.TabIndex = 6;
            this.btnVeriIstatistik.Text = "İSTATİSTİK";
            this.btnVeriIstatistik.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnVeriIstatistik.UseAccentColor = false;
            this.btnVeriIstatistik.UseVisualStyleBackColor = true;
            this.btnVeriIstatistik.Click += new System.EventHandler(this.btnVeriIstatistik_Click);
            // 
            // btnVeriDuzenle
            // 
            this.btnVeriDuzenle.AutoSize = false;
            this.btnVeriDuzenle.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnVeriDuzenle.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnVeriDuzenle.Depth = 0;
            this.btnVeriDuzenle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnVeriDuzenle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnVeriDuzenle.HighEmphasis = true;
            this.btnVeriDuzenle.Icon = null;
            this.btnVeriDuzenle.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.btnVeriDuzenle.Location = new System.Drawing.Point(443, 6);
            this.btnVeriDuzenle.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnVeriDuzenle.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.btnVeriDuzenle.Name = "btnVeriDuzenle";
            this.btnVeriDuzenle.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnVeriDuzenle.Size = new System.Drawing.Size(139, 42);
            this.btnVeriDuzenle.TabIndex = 5;
            this.btnVeriDuzenle.Text = "DÜZENLE";
            this.btnVeriDuzenle.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnVeriDuzenle.UseAccentColor = false;
            this.btnVeriDuzenle.UseVisualStyleBackColor = true;
            this.btnVeriDuzenle.Click += new System.EventHandler(this.btnVeriDuzenle_Click);
            // 
            // btnVeriSil
            // 
            this.btnVeriSil.AutoSize = false;
            this.btnVeriSil.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnVeriSil.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnVeriSil.Depth = 0;
            this.btnVeriSil.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnVeriSil.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVeriSil.HighEmphasis = true;
            this.btnVeriSil.Icon = null;
            this.btnVeriSil.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.btnVeriSil.Location = new System.Drawing.Point(260, 6);
            this.btnVeriSil.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnVeriSil.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.btnVeriSil.Name = "btnVeriSil";
            this.btnVeriSil.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnVeriSil.Size = new System.Drawing.Size(139, 42);
            this.btnVeriSil.TabIndex = 3;
            this.btnVeriSil.Text = "SİL";
            this.btnVeriSil.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnVeriSil.UseAccentColor = false;
            this.btnVeriSil.UseVisualStyleBackColor = true;
            this.btnVeriSil.Click += new System.EventHandler(this.btnVeriSil_Click);
            // 
            // btnVeriEkle
            // 
            this.btnVeriEkle.AutoSize = false;
            this.btnVeriEkle.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnVeriEkle.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnVeriEkle.Depth = 0;
            this.btnVeriEkle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnVeriEkle.HighEmphasis = true;
            this.btnVeriEkle.Icon = null;
            this.btnVeriEkle.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.btnVeriEkle.Location = new System.Drawing.Point(77, 6);
            this.btnVeriEkle.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnVeriEkle.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.btnVeriEkle.Name = "btnVeriEkle";
            this.btnVeriEkle.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnVeriEkle.Size = new System.Drawing.Size(139, 42);
            this.btnVeriEkle.TabIndex = 7;
            this.btnVeriEkle.Text = "EKLE";
            this.btnVeriEkle.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnVeriEkle.UseAccentColor = false;
            this.btnVeriEkle.Click += new System.EventHandler(this.btnVeriEkle_Click_1);
            // 
            // VeriKategoriButonPanel
            // 
            this.VeriKategoriButonPanel.BackColor = System.Drawing.Color.Blue;
            this.VeriKategoriButonPanel.Controls.Add(this.VeriKategoriLayout);
            this.VeriKategoriButonPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.VeriKategoriButonPanel.Location = new System.Drawing.Point(0, 0);
            this.VeriKategoriButonPanel.Name = "VeriKategoriButonPanel";
            this.VeriKategoriButonPanel.Padding = new System.Windows.Forms.Padding(3);
            this.VeriKategoriButonPanel.Size = new System.Drawing.Size(854, 60);
            this.VeriKategoriButonPanel.TabIndex = 12;
            // 
            // VeriKategoriLayout
            // 
            this.VeriKategoriLayout.BackColor = System.Drawing.Color.White;
            this.VeriKategoriLayout.ColumnCount = 9;
            this.VeriKategoriLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.695652F));
            this.VeriKategoriLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.3913F));
            this.VeriKategoriLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.347826F));
            this.VeriKategoriLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.3913F));
            this.VeriKategoriLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.347826F));
            this.VeriKategoriLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.3913F));
            this.VeriKategoriLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.347826F));
            this.VeriKategoriLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.3913F));
            this.VeriKategoriLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.695652F));
            this.VeriKategoriLayout.Controls.Add(this.btnVeriLoglar, 7, 0);
            this.VeriKategoriLayout.Controls.Add(this.btnVeriKategoriler, 5, 0);
            this.VeriKategoriLayout.Controls.Add(this.btnVeriUrunler, 3, 0);
            this.VeriKategoriLayout.Controls.Add(this.btnVeriMasalar, 1, 0);
            this.VeriKategoriLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.VeriKategoriLayout.Location = new System.Drawing.Point(3, 3);
            this.VeriKategoriLayout.Name = "VeriKategoriLayout";
            this.VeriKategoriLayout.RowCount = 1;
            this.VeriKategoriLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.VeriKategoriLayout.Size = new System.Drawing.Size(848, 54);
            this.VeriKategoriLayout.TabIndex = 0;
            // 
            // VeriButonPanel
            // 
            this.VeriButonPanel.BackColor = System.Drawing.Color.Blue;
            this.VeriButonPanel.Controls.Add(this.VeriButonLayout);
            this.VeriButonPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.VeriButonPanel.Location = new System.Drawing.Point(0, 613);
            this.VeriButonPanel.Name = "VeriButonPanel";
            this.VeriButonPanel.Padding = new System.Windows.Forms.Padding(3);
            this.VeriButonPanel.Size = new System.Drawing.Size(854, 60);
            this.VeriButonPanel.TabIndex = 13;
            // 
            // VeriButonLayout
            // 
            this.VeriButonLayout.BackColor = System.Drawing.Color.White;
            this.VeriButonLayout.ColumnCount = 9;
            this.VeriButonLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.699131F));
            this.VeriButonLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.38826F));
            this.VeriButonLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.349566F));
            this.VeriButonLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.38826F));
            this.VeriButonLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.349566F));
            this.VeriButonLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.38826F));
            this.VeriButonLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.349566F));
            this.VeriButonLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.38826F));
            this.VeriButonLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.699131F));
            this.VeriButonLayout.Controls.Add(this.btnVeriIstatistik, 7, 0);
            this.VeriButonLayout.Controls.Add(this.btnVeriDuzenle, 5, 0);
            this.VeriButonLayout.Controls.Add(this.btnVeriSil, 3, 0);
            this.VeriButonLayout.Controls.Add(this.btnVeriEkle, 1, 0);
            this.VeriButonLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.VeriButonLayout.Location = new System.Drawing.Point(3, 3);
            this.VeriButonLayout.Name = "VeriButonLayout";
            this.VeriButonLayout.RowCount = 1;
            this.VeriButonLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.VeriButonLayout.Size = new System.Drawing.Size(848, 54);
            this.VeriButonLayout.TabIndex = 0;
            // 
            // HesapButonPanel
            // 
            this.HesapButonPanel.BackColor = System.Drawing.Color.Blue;
            this.HesapButonPanel.Controls.Add(this.HesapButonLayout);
            this.HesapButonPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.HesapButonPanel.Location = new System.Drawing.Point(0, 613);
            this.HesapButonPanel.Name = "HesapButonPanel";
            this.HesapButonPanel.Padding = new System.Windows.Forms.Padding(3);
            this.HesapButonPanel.Size = new System.Drawing.Size(424, 60);
            this.HesapButonPanel.TabIndex = 12;
            // 
            // HesapButonLayout
            // 
            this.HesapButonLayout.BackColor = System.Drawing.Color.White;
            this.HesapButonLayout.ColumnCount = 9;
            this.HesapButonLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.710034F));
            this.HesapButonLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.02457F));
            this.HesapButonLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.160556F));
            this.HesapButonLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.02457F));
            this.HesapButonLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.160556F));
            this.HesapButonLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.02457F));
            this.HesapButonLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.160556F));
            this.HesapButonLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.02457F));
            this.HesapButonLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.710033F));
            this.HesapButonLayout.Controls.Add(this.btnHesapSil, 5, 0);
            this.HesapButonLayout.Controls.Add(this.btnCikis, 1, 0);
            this.HesapButonLayout.Controls.Add(this.btnHesapDuzenle, 7, 0);
            this.HesapButonLayout.Controls.Add(this.btnHesapEkle, 3, 0);
            this.HesapButonLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HesapButonLayout.Location = new System.Drawing.Point(3, 3);
            this.HesapButonLayout.Name = "HesapButonLayout";
            this.HesapButonLayout.RowCount = 1;
            this.HesapButonLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.HesapButonLayout.Size = new System.Drawing.Size(418, 54);
            this.HesapButonLayout.TabIndex = 0;
            // 
            // HesapBaslikPanel
            // 
            this.HesapBaslikPanel.BackColor = System.Drawing.Color.Blue;
            this.HesapBaslikPanel.Controls.Add(this.HesapPanel);
            this.HesapBaslikPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.HesapBaslikPanel.Location = new System.Drawing.Point(0, 0);
            this.HesapBaslikPanel.Name = "HesapBaslikPanel";
            this.HesapBaslikPanel.Padding = new System.Windows.Forms.Padding(3);
            this.HesapBaslikPanel.Size = new System.Drawing.Size(424, 60);
            this.HesapBaslikPanel.TabIndex = 13;
            // 
            // HesapPanel
            // 
            this.HesapPanel.BackColor = System.Drawing.Color.White;
            this.HesapPanel.Controls.Add(this.HesapLabel);
            this.HesapPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HesapPanel.Location = new System.Drawing.Point(3, 3);
            this.HesapPanel.Name = "HesapPanel";
            this.HesapPanel.Size = new System.Drawing.Size(418, 54);
            this.HesapPanel.TabIndex = 0;
            // 
            // HesaplarLayout
            // 
            this.HesaplarLayout.ColumnCount = 1;
            this.HesaplarLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.HesaplarLayout.Controls.Add(this.CalisanTree, 0, 3);
            this.HesaplarLayout.Controls.Add(this.CalisanLabel, 0, 2);
            this.HesaplarLayout.Controls.Add(this.AdminLabel, 0, 0);
            this.HesaplarLayout.Controls.Add(this.AdminTree, 0, 1);
            this.HesaplarLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HesaplarLayout.Location = new System.Drawing.Point(0, 60);
            this.HesaplarLayout.Name = "HesaplarLayout";
            this.HesaplarLayout.RowCount = 4;
            this.HesaplarLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.HesaplarLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 41.66666F));
            this.HesaplarLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.HesaplarLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 41.66667F));
            this.HesaplarLayout.Size = new System.Drawing.Size(424, 553);
            this.HesaplarLayout.TabIndex = 14;
            // 
            // frmAdminControlPanel
            // 
            this.ClientSize = new System.Drawing.Size(1282, 673);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmAdminControlPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "YETKİLİ PANELİ";
            this.Load += new System.EventHandler(this.frmAdminControlPanel_Load_1);
            this.Shown += new System.EventHandler(this.frmAdminControlPanel_Shown);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.VeriKategoriButonPanel.ResumeLayout(false);
            this.VeriKategoriLayout.ResumeLayout(false);
            this.VeriButonPanel.ResumeLayout(false);
            this.VeriButonLayout.ResumeLayout(false);
            this.HesapButonPanel.ResumeLayout(false);
            this.HesapButonLayout.ResumeLayout(false);
            this.HesapButonLayout.PerformLayout();
            this.HesapBaslikPanel.ResumeLayout(false);
            this.HesapPanel.ResumeLayout(false);
            this.HesaplarLayout.ResumeLayout(false);
            this.ResumeLayout(false);

        }





        #endregion

        private void frmAdminControlPanel_Shown(object sender, EventArgs e)
        {
            this.ActiveControl = null;
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            frmGiris g = new frmGiris();
            g.Show();
            this.Close();
        }

        private void AdminLabel_Click(object sender, EventArgs e)
        {

        }

        private void BaslikBox_Load(object sender, EventArgs e)
        {

        }
    }
}
