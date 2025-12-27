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

        // DÜZELTME: Değişken adını senin hata mesajındakiyle eşitledim.
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
        }

        private void btnVeriDuzenle_Click(object sender, EventArgs e)
        {
            if (_seciliFlowID == -1) { MessageBox.Show("Seçim yapın."); return; }
            dbDuzenle form = new dbDuzenle(aktifVeriTablosu, _seciliFlowID);
            if (form.ShowDialog() == DialogResult.OK) VerileriYukle(aktifVeriTablosu);
        }

        private void btnVeriIstatistik_Click(object sender, EventArgs e)
        {
            MessageBox.Show("İstatistik özelliği henüz aktif değil.");
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

        #region Yardımcı Metotlar
        private void BilgiKutulariniKilitle()
        {

        }

        private void BilgiKutularininKilidiniAc()
        {

        }

        private void BilgiKutulariniTemizleVeAc()
        {
            BilgiKutulariniTemizleVeKilitle();
            BilgiKutularininKilidiniAc();
        }

        private void BilgiKutulariniTemizleVeKilitle()
        {
        }


        private void YenileAktifTablo()
        {
            switch (aktifVeriTablosu)
            {
                case "Masalar": btnVeriMasalar_Click(null, null); break;
                case "Urunler": btnVeriUrunler_Click(null, null); break;
                case "Kategoriler": btnVeriKategoriler_Click(null, null); break;
            }
        }

        private void KullaniciyiTreeViewdeSec(int kullaniciID)
        {
            // Önce AdminTree'nin düğümlerini (Nodes) kontrol et
            foreach (TreeNode node in AdminTree.Nodes)
            {
                if (node.Tag != null && (int)node.Tag == kullaniciID)
                {
                    AdminTree.SelectedNode = node;
                    // Bulunca, TreeView'in seçilen node'a odaklanmasını sağla.
                    node.EnsureVisible();
                    return; // Kullanıcıyı bulduk, daha fazla aramaya gerek yok.
                }
            }

            // Eğer AdminTree'de bulamadıysak, CalisanTree'yi kontrol et
            foreach (TreeNode node in CalisanTree.Nodes)
            {
                if (node.Tag != null && (int)node.Tag == kullaniciID)
                {
                    CalisanTree.SelectedNode = node;
                    node.EnsureVisible();
                    return;
                }
            }
        }

        #endregion

        #region Diğer Olaylar
        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void listCalisanlar_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void gbUrunler_Click(object sender, EventArgs e)
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


        private void VerileriYukle(string tablo)
        {
            aktifVeriTablosu = tablo;
            _seciliFlowID = -1;
            _seciliFlowButonu = null;
            FlowDb.Controls.Clear();
            FlowDb.AutoScroll = true;

            DataTable dt = new DataTable();
            if (tablo == "Urunler") dt = db.UrunleriGetir();
            else if (tablo == "Kategoriler") dt = db.KategorileriGetir();
            else if (tablo == "Masalar") dt = db.MasalariGetir();

            foreach (DataRow row in dt.Rows)
            {
                Button btn = new Button();
                btn.Size = new Size(200, 80);
                btn.FlatStyle = FlatStyle.Flat;
                btn.BackColor = Color.White;
                btn.ForeColor = Color.Black;
                btn.Font = new Font("Segoe UI", 10, FontStyle.Bold);
                btn.Margin = new Padding(10);
                btn.Tag = Convert.ToInt32(row[0]);

                if (tablo == "Urunler") btn.Text = $"{row["UrunAdi"]}\n{row["Fiyat"]} TL\n({row["KategoriAdi"]})";
                else if (tablo == "Kategoriler") btn.Text = row["KategoriAdi"].ToString();
                else if (tablo == "Masalar") btn.Text = row["MasaAdi"].ToString();

                btn.Click += FlowItem_Click;
                FlowDb.Controls.Add(btn);
            }
        }


        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Çalışan Hesaplar");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Yetkili Hesaplar");
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.BaslikBox = new ReaLTaiizor.Controls.CyberGroupBox();
            this.HesapLabel = new ReaLTaiizor.Controls.MetroLabel();
            this.CalisanLabel = new ReaLTaiizor.Controls.MetroLabel();
            this.CalisanTree = new ReaLTaiizor.Controls.ForeverTreeView();
            this.AdminLabel = new ReaLTaiizor.Controls.MetroLabel();
            this.AdminTree = new ReaLTaiizor.Controls.ForeverTreeView();
            this.HesapButonGroupBox = new ReaLTaiizor.Controls.CyberGroupBox();
            this.btnCikis = new ReaLTaiizor.Controls.MaterialButton();
            this.btnHesapDuzenle = new ReaLTaiizor.Controls.MaterialButton();
            this.btnHesapSil = new ReaLTaiizor.Controls.MaterialButton();
            this.btnHesapEkle = new ReaLTaiizor.Controls.MaterialButton();
            this.FlowDb = new System.Windows.Forms.FlowLayoutPanel();
            this.VeriKategoriButonGroupBox = new ReaLTaiizor.Controls.CyberGroupBox();
            this.btnVeriLoglar = new ReaLTaiizor.Controls.MaterialButton();
            this.btnVeriKategoriler = new ReaLTaiizor.Controls.MaterialButton();
            this.btnVeriUrunler = new ReaLTaiizor.Controls.MaterialButton();
            this.btnVeriMasalar = new ReaLTaiizor.Controls.MaterialButton();
            this.VeriButonGroupBox = new ReaLTaiizor.Controls.CyberGroupBox();
            this.btnVeriIstatistik = new ReaLTaiizor.Controls.MaterialButton();
            this.btnVeriDuzenle = new ReaLTaiizor.Controls.MaterialButton();
            this.btnVeriSil = new ReaLTaiizor.Controls.MaterialButton();
            this.btnVeriEkle = new ReaLTaiizor.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.BaslikBox.SuspendLayout();
            this.HesapButonGroupBox.SuspendLayout();
            this.VeriKategoriButonGroupBox.SuspendLayout();
            this.VeriButonGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(3, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.BaslikBox);
            this.splitContainer1.Panel1.Controls.Add(this.CalisanLabel);
            this.splitContainer1.Panel1.Controls.Add(this.CalisanTree);
            this.splitContainer1.Panel1.Controls.Add(this.AdminLabel);
            this.splitContainer1.Panel1.Controls.Add(this.AdminTree);
            this.splitContainer1.Panel1.Controls.Add(this.HesapButonGroupBox);
            this.splitContainer1.Panel1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.splitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.FlowDb);
            this.splitContainer1.Panel2.Controls.Add(this.VeriKategoriButonGroupBox);
            this.splitContainer1.Panel2.Controls.Add(this.VeriButonGroupBox);
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint_1);
            this.splitContainer1.Size = new System.Drawing.Size(1332, 673);
            this.splitContainer1.SplitterDistance = 441;
            this.splitContainer1.TabIndex = 0;
            // 
            // BaslikBox
            // 
            this.BaslikBox.Alpha = 20;
            this.BaslikBox.BackColor = System.Drawing.Color.Transparent;
            this.BaslikBox.Background = true;
            this.BaslikBox.Background_WidthPen = 3F;
            this.BaslikBox.BackgroundPen = true;
            this.BaslikBox.ColorBackground = System.Drawing.Color.White;
            this.BaslikBox.ColorBackground_1 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(68)))));
            this.BaslikBox.ColorBackground_2 = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(63)))), ((int)(((byte)(86)))));
            this.BaslikBox.ColorBackground_Pen = System.Drawing.Color.Blue;
            this.BaslikBox.ColorLighting = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.BaslikBox.ColorPen_1 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(68)))));
            this.BaslikBox.ColorPen_2 = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(63)))), ((int)(((byte)(86)))));
            this.BaslikBox.Controls.Add(this.HesapLabel);
            this.BaslikBox.CyberGroupBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            this.BaslikBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.BaslikBox.Lighting = false;
            this.BaslikBox.LinearGradient_Background = false;
            this.BaslikBox.LinearGradientPen = false;
            this.BaslikBox.Location = new System.Drawing.Point(3, 0);
            this.BaslikBox.Name = "BaslikBox";
            this.BaslikBox.PenWidth = 15;
            this.BaslikBox.RGB = false;
            this.BaslikBox.Rounding = true;
            this.BaslikBox.RoundingInt = 60;
            this.BaslikBox.Size = new System.Drawing.Size(435, 58);
            this.BaslikBox.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.BaslikBox.TabIndex = 8;
            this.BaslikBox.Tag = "Cyber";
            this.BaslikBox.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.BaslikBox.Timer_RGB = 300;
            // 
            // HesapLabel
            // 
            this.HesapLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.HesapLabel.IsDerivedStyle = true;
            this.HesapLabel.Location = new System.Drawing.Point(14, 11);
            this.HesapLabel.Name = "HesapLabel";
            this.HesapLabel.Size = new System.Drawing.Size(415, 36);
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
            this.CalisanLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CalisanLabel.IsDerivedStyle = true;
            this.CalisanLabel.Location = new System.Drawing.Point(13, 319);
            this.CalisanLabel.Name = "CalisanLabel";
            this.CalisanLabel.Size = new System.Drawing.Size(416, 34);
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
            this.CalisanTree.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CalisanTree.ForeColor = System.Drawing.Color.White;
            this.CalisanTree.LabelEdit = true;
            this.CalisanTree.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(29)))));
            this.CalisanTree.Location = new System.Drawing.Point(14, 356);
            this.CalisanTree.Name = "CalisanTree";
            treeNode9.Name = "CalisanNodes";
            treeNode9.Text = "Çalışan Hesaplar";
            this.CalisanTree.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode9});
            this.CalisanTree.Size = new System.Drawing.Size(411, 212);
            this.CalisanTree.TabIndex = 11;
            this.CalisanTree.AfterLabelEdit += new System.Windows.Forms.NodeLabelEditEventHandler(this.TreeView_AfterLabelEdit);
            this.CalisanTree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.CalisanTree_AfterSelect);
            // 
            // AdminLabel
            // 
            this.AdminLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AdminLabel.IsDerivedStyle = true;
            this.AdminLabel.Location = new System.Drawing.Point(14, 61);
            this.AdminLabel.Name = "AdminLabel";
            this.AdminLabel.Size = new System.Drawing.Size(415, 36);
            this.AdminLabel.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            this.AdminLabel.StyleManager = null;
            this.AdminLabel.TabIndex = 8;
            this.AdminLabel.Text = "Yetkili Hesaplar";
            this.AdminLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AdminLabel.ThemeAuthor = "Taiizor";
            this.AdminLabel.ThemeName = "MetroLight";
            // 
            // AdminTree
            // 
            this.AdminTree.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.AdminTree.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AdminTree.ForeColor = System.Drawing.Color.White;
            this.AdminTree.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(29)))));
            this.AdminTree.Location = new System.Drawing.Point(14, 104);
            this.AdminTree.Name = "AdminTree";
            treeNode10.Name = "AdminNodes";
            treeNode10.Text = "Yetkili Hesaplar";
            this.AdminTree.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode10});
            this.AdminTree.Size = new System.Drawing.Size(411, 212);
            this.AdminTree.TabIndex = 10;
            this.AdminTree.AfterLabelEdit += new System.Windows.Forms.NodeLabelEditEventHandler(this.TreeView_AfterLabelEdit);
            this.AdminTree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.AdminTree_AfterSelect);
            // 
            // HesapButonGroupBox
            // 
            this.HesapButonGroupBox.Alpha = 20;
            this.HesapButonGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.HesapButonGroupBox.Background = true;
            this.HesapButonGroupBox.Background_WidthPen = 3F;
            this.HesapButonGroupBox.BackgroundPen = true;
            this.HesapButonGroupBox.ColorBackground = System.Drawing.Color.White;
            this.HesapButonGroupBox.ColorBackground_1 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(68)))));
            this.HesapButonGroupBox.ColorBackground_2 = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(63)))), ((int)(((byte)(86)))));
            this.HesapButonGroupBox.ColorBackground_Pen = System.Drawing.Color.Blue;
            this.HesapButonGroupBox.ColorLighting = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.HesapButonGroupBox.ColorPen_1 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(68)))));
            this.HesapButonGroupBox.ColorPen_2 = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(63)))), ((int)(((byte)(86)))));
            this.HesapButonGroupBox.Controls.Add(this.btnCikis);
            this.HesapButonGroupBox.Controls.Add(this.btnHesapDuzenle);
            this.HesapButonGroupBox.Controls.Add(this.btnHesapSil);
            this.HesapButonGroupBox.Controls.Add(this.btnHesapEkle);
            this.HesapButonGroupBox.CyberGroupBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            this.HesapButonGroupBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.HesapButonGroupBox.Lighting = false;
            this.HesapButonGroupBox.LinearGradient_Background = false;
            this.HesapButonGroupBox.LinearGradientPen = false;
            this.HesapButonGroupBox.Location = new System.Drawing.Point(3, 604);
            this.HesapButonGroupBox.Name = "HesapButonGroupBox";
            this.HesapButonGroupBox.PenWidth = 15;
            this.HesapButonGroupBox.RGB = false;
            this.HesapButonGroupBox.Rounding = true;
            this.HesapButonGroupBox.RoundingInt = 60;
            this.HesapButonGroupBox.Size = new System.Drawing.Size(435, 69);
            this.HesapButonGroupBox.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.HesapButonGroupBox.TabIndex = 7;
            this.HesapButonGroupBox.Tag = "Cyber";
            this.HesapButonGroupBox.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.HesapButonGroupBox.Timer_RGB = 300;
            // 
            // btnCikis
            // 
            this.btnCikis.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCikis.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnCikis.Depth = 0;
            this.btnCikis.HighEmphasis = true;
            this.btnCikis.Icon = null;
            this.btnCikis.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.btnCikis.Location = new System.Drawing.Point(35, 16);
            this.btnCikis.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCikis.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnCikis.Size = new System.Drawing.Size(64, 36);
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
            this.btnHesapDuzenle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHesapDuzenle.HighEmphasis = true;
            this.btnHesapDuzenle.Icon = null;
            this.btnHesapDuzenle.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.btnHesapDuzenle.Location = new System.Drawing.Point(314, 16);
            this.btnHesapDuzenle.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnHesapDuzenle.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.btnHesapDuzenle.Name = "btnHesapDuzenle";
            this.btnHesapDuzenle.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnHesapDuzenle.Size = new System.Drawing.Size(85, 36);
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
            this.btnHesapSil.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHesapSil.HighEmphasis = true;
            this.btnHesapSil.Icon = null;
            this.btnHesapSil.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.btnHesapSil.Location = new System.Drawing.Point(128, 16);
            this.btnHesapSil.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnHesapSil.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.btnHesapSil.Name = "btnHesapSil";
            this.btnHesapSil.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnHesapSil.Size = new System.Drawing.Size(64, 36);
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
            this.btnHesapEkle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHesapEkle.HighEmphasis = true;
            this.btnHesapEkle.Icon = null;
            this.btnHesapEkle.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.btnHesapEkle.Location = new System.Drawing.Point(221, 16);
            this.btnHesapEkle.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnHesapEkle.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.btnHesapEkle.Name = "btnHesapEkle";
            this.btnHesapEkle.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnHesapEkle.Size = new System.Drawing.Size(64, 36);
            this.btnHesapEkle.TabIndex = 1;
            this.btnHesapEkle.Text = "EKLE";
            this.btnHesapEkle.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnHesapEkle.UseAccentColor = false;
            this.btnHesapEkle.UseVisualStyleBackColor = true;
            this.btnHesapEkle.Click += new System.EventHandler(this.btnHesapEkle_Click);
            // 
            // FlowDb
            // 
            this.FlowDb.Location = new System.Drawing.Point(14, 104);
            this.FlowDb.Name = "FlowDb";
            this.FlowDb.Size = new System.Drawing.Size(858, 464);
            this.FlowDb.TabIndex = 11;
            this.FlowDb.Click += new System.EventHandler(this.FlowDb_Click);
            // 
            // VeriKategoriButonGroupBox
            // 
            this.VeriKategoriButonGroupBox.Alpha = 20;
            this.VeriKategoriButonGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.VeriKategoriButonGroupBox.Background = true;
            this.VeriKategoriButonGroupBox.Background_WidthPen = 3F;
            this.VeriKategoriButonGroupBox.BackgroundPen = true;
            this.VeriKategoriButonGroupBox.ColorBackground = System.Drawing.Color.White;
            this.VeriKategoriButonGroupBox.ColorBackground_1 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(68)))));
            this.VeriKategoriButonGroupBox.ColorBackground_2 = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(63)))), ((int)(((byte)(86)))));
            this.VeriKategoriButonGroupBox.ColorBackground_Pen = System.Drawing.Color.Blue;
            this.VeriKategoriButonGroupBox.ColorLighting = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.VeriKategoriButonGroupBox.ColorPen_1 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(68)))));
            this.VeriKategoriButonGroupBox.ColorPen_2 = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(63)))), ((int)(((byte)(86)))));
            this.VeriKategoriButonGroupBox.Controls.Add(this.btnVeriLoglar);
            this.VeriKategoriButonGroupBox.Controls.Add(this.btnVeriKategoriler);
            this.VeriKategoriButonGroupBox.Controls.Add(this.btnVeriUrunler);
            this.VeriKategoriButonGroupBox.Controls.Add(this.btnVeriMasalar);
            this.VeriKategoriButonGroupBox.CyberGroupBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            this.VeriKategoriButonGroupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.VeriKategoriButonGroupBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.VeriKategoriButonGroupBox.Lighting = false;
            this.VeriKategoriButonGroupBox.LinearGradient_Background = false;
            this.VeriKategoriButonGroupBox.LinearGradientPen = false;
            this.VeriKategoriButonGroupBox.Location = new System.Drawing.Point(0, 0);
            this.VeriKategoriButonGroupBox.Name = "VeriKategoriButonGroupBox";
            this.VeriKategoriButonGroupBox.PenWidth = 15;
            this.VeriKategoriButonGroupBox.RGB = false;
            this.VeriKategoriButonGroupBox.Rounding = true;
            this.VeriKategoriButonGroupBox.RoundingInt = 60;
            this.VeriKategoriButonGroupBox.Size = new System.Drawing.Size(887, 58);
            this.VeriKategoriButonGroupBox.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.VeriKategoriButonGroupBox.TabIndex = 10;
            this.VeriKategoriButonGroupBox.Tag = "Cyber";
            this.VeriKategoriButonGroupBox.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.VeriKategoriButonGroupBox.Timer_RGB = 300;
            // 
            // btnVeriLoglar
            // 
            this.btnVeriLoglar.AutoSize = false;
            this.btnVeriLoglar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnVeriLoglar.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnVeriLoglar.Depth = 0;
            this.btnVeriLoglar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVeriLoglar.HighEmphasis = true;
            this.btnVeriLoglar.Icon = null;
            this.btnVeriLoglar.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.btnVeriLoglar.Location = new System.Drawing.Point(615, 11);
            this.btnVeriLoglar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnVeriLoglar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.btnVeriLoglar.Name = "btnVeriLoglar";
            this.btnVeriLoglar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnVeriLoglar.Size = new System.Drawing.Size(155, 36);
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
            this.btnVeriKategoriler.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVeriKategoriler.HighEmphasis = true;
            this.btnVeriKategoriler.Icon = null;
            this.btnVeriKategoriler.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.btnVeriKategoriler.Location = new System.Drawing.Point(447, 11);
            this.btnVeriKategoriler.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnVeriKategoriler.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.btnVeriKategoriler.Name = "btnVeriKategoriler";
            this.btnVeriKategoriler.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnVeriKategoriler.Size = new System.Drawing.Size(155, 36);
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
            this.btnVeriUrunler.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnVeriUrunler.HighEmphasis = true;
            this.btnVeriUrunler.Icon = null;
            this.btnVeriUrunler.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.btnVeriUrunler.Location = new System.Drawing.Point(279, 11);
            this.btnVeriUrunler.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnVeriUrunler.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.btnVeriUrunler.Name = "btnVeriUrunler";
            this.btnVeriUrunler.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnVeriUrunler.Size = new System.Drawing.Size(155, 36);
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
            this.btnVeriMasalar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVeriMasalar.HighEmphasis = true;
            this.btnVeriMasalar.Icon = null;
            this.btnVeriMasalar.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.btnVeriMasalar.Location = new System.Drawing.Point(111, 11);
            this.btnVeriMasalar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnVeriMasalar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.btnVeriMasalar.Name = "btnVeriMasalar";
            this.btnVeriMasalar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnVeriMasalar.Size = new System.Drawing.Size(155, 36);
            this.btnVeriMasalar.TabIndex = 1;
            this.btnVeriMasalar.Text = "Masalar";
            this.btnVeriMasalar.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnVeriMasalar.UseAccentColor = false;
            this.btnVeriMasalar.UseVisualStyleBackColor = true;
            this.btnVeriMasalar.Click += new System.EventHandler(this.btnVeriMasalar_Click);
            // 
            // VeriButonGroupBox
            // 
            this.VeriButonGroupBox.Alpha = 20;
            this.VeriButonGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.VeriButonGroupBox.Background = true;
            this.VeriButonGroupBox.Background_WidthPen = 3F;
            this.VeriButonGroupBox.BackgroundPen = true;
            this.VeriButonGroupBox.ColorBackground = System.Drawing.Color.White;
            this.VeriButonGroupBox.ColorBackground_1 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(68)))));
            this.VeriButonGroupBox.ColorBackground_2 = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(63)))), ((int)(((byte)(86)))));
            this.VeriButonGroupBox.ColorBackground_Pen = System.Drawing.Color.Blue;
            this.VeriButonGroupBox.ColorLighting = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.VeriButonGroupBox.ColorPen_1 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(68)))));
            this.VeriButonGroupBox.ColorPen_2 = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(63)))), ((int)(((byte)(86)))));
            this.VeriButonGroupBox.Controls.Add(this.btnVeriIstatistik);
            this.VeriButonGroupBox.Controls.Add(this.btnVeriDuzenle);
            this.VeriButonGroupBox.Controls.Add(this.btnVeriSil);
            this.VeriButonGroupBox.Controls.Add(this.btnVeriEkle);
            this.VeriButonGroupBox.CyberGroupBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            this.VeriButonGroupBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.VeriButonGroupBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.VeriButonGroupBox.Lighting = false;
            this.VeriButonGroupBox.LinearGradient_Background = false;
            this.VeriButonGroupBox.LinearGradientPen = false;
            this.VeriButonGroupBox.Location = new System.Drawing.Point(0, 604);
            this.VeriButonGroupBox.Name = "VeriButonGroupBox";
            this.VeriButonGroupBox.PenWidth = 15;
            this.VeriButonGroupBox.RGB = false;
            this.VeriButonGroupBox.Rounding = true;
            this.VeriButonGroupBox.RoundingInt = 60;
            this.VeriButonGroupBox.Size = new System.Drawing.Size(887, 69);
            this.VeriButonGroupBox.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.VeriButonGroupBox.TabIndex = 8;
            this.VeriButonGroupBox.Tag = "Cyber";
            this.VeriButonGroupBox.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.VeriButonGroupBox.Timer_RGB = 300;
            this.VeriButonGroupBox.Load += new System.EventHandler(this.VeriButonGroupBox_Load);
            // 
            // btnVeriIstatistik
            // 
            this.btnVeriIstatistik.AutoSize = false;
            this.btnVeriIstatistik.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnVeriIstatistik.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnVeriIstatistik.Depth = 0;
            this.btnVeriIstatistik.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVeriIstatistik.HighEmphasis = true;
            this.btnVeriIstatistik.Icon = null;
            this.btnVeriIstatistik.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.btnVeriIstatistik.Location = new System.Drawing.Point(680, 17);
            this.btnVeriIstatistik.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnVeriIstatistik.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.btnVeriIstatistik.Name = "btnVeriIstatistik";
            this.btnVeriIstatistik.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnVeriIstatistik.Size = new System.Drawing.Size(155, 36);
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
            this.btnVeriDuzenle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnVeriDuzenle.HighEmphasis = true;
            this.btnVeriDuzenle.Icon = null;
            this.btnVeriDuzenle.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.btnVeriDuzenle.Location = new System.Drawing.Point(469, 17);
            this.btnVeriDuzenle.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnVeriDuzenle.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.btnVeriDuzenle.Name = "btnVeriDuzenle";
            this.btnVeriDuzenle.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnVeriDuzenle.Size = new System.Drawing.Size(155, 36);
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
            this.btnVeriSil.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVeriSil.HighEmphasis = true;
            this.btnVeriSil.Icon = null;
            this.btnVeriSil.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.btnVeriSil.Location = new System.Drawing.Point(258, 15);
            this.btnVeriSil.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnVeriSil.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.btnVeriSil.Name = "btnVeriSil";
            this.btnVeriSil.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnVeriSil.Size = new System.Drawing.Size(155, 36);
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
            this.btnVeriEkle.HighEmphasis = true;
            this.btnVeriEkle.Icon = null;
            this.btnVeriEkle.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.btnVeriEkle.Location = new System.Drawing.Point(47, 15);
            this.btnVeriEkle.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnVeriEkle.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.btnVeriEkle.Name = "btnVeriEkle";
            this.btnVeriEkle.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnVeriEkle.Size = new System.Drawing.Size(155, 36);
            this.btnVeriEkle.TabIndex = 7;
            this.btnVeriEkle.Text = "EKLE";
            this.btnVeriEkle.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnVeriEkle.UseAccentColor = false;
            this.btnVeriEkle.Click += new System.EventHandler(this.btnVeriEkle_Click_1);
            // 
            // frmAdminControlPanel
            // 
            this.ClientSize = new System.Drawing.Size(1332, 673);
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
            this.BaslikBox.ResumeLayout(false);
            this.HesapButonGroupBox.ResumeLayout(false);
            this.HesapButonGroupBox.PerformLayout();
            this.VeriKategoriButonGroupBox.ResumeLayout(false);
            this.VeriButonGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }





        #endregion

        private void frmAdminControlPanel_Shown(object sender, EventArgs e)
        {
            this.ActiveControl = null;
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

        private void btnVeriLoglar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Loglar yakında eklenecek.");
        }

        private void btnVeriEkle_Click_1(object sender, EventArgs e)
        {
            if (aktifVeriTablosu == "") return;
            dbDuzenle form = new dbDuzenle(aktifVeriTablosu, -1);
            if (form.ShowDialog() == DialogResult.OK) VerileriYukle(aktifVeriTablosu);
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            frmGiris g = new frmGiris();
            g.Show();
            this.Close();
        }
    }
}
