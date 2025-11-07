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
        public frmAdminControlPanel()
        {
            InitializeComponent();
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void listCalisanlar_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmAdminControlPanel_Load(object sender, EventArgs e)
        {

        }

        private void gbUrunler_Click(object sender, EventArgs e)
        {

        }

        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Çalışan Hesaplar");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Yetkili Hesaplar");
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.BaslikBox = new ReaLTaiizor.Controls.CyberGroupBox();
            this.HesapLabel = new ReaLTaiizor.Controls.MetroLabel();
            this.CalisanLabel = new ReaLTaiizor.Controls.MetroLabel();
            this.CalisanTree = new ReaLTaiizor.Controls.ForeverTreeView();
            this.AdminLabel = new ReaLTaiizor.Controls.MetroLabel();
            this.AdminTree = new ReaLTaiizor.Controls.ForeverTreeView();
            this.HesapButonGroupBox = new ReaLTaiizor.Controls.CyberGroupBox();
            this.btnHesapDuzenle = new ReaLTaiizor.Controls.MaterialButton();
            this.btnHesapSil = new ReaLTaiizor.Controls.MaterialButton();
            this.btnHesapKaydet = new ReaLTaiizor.Controls.MaterialButton();
            this.btnHesapGuncelle = new ReaLTaiizor.Controls.MaterialButton();
            this.btnHesapEkle = new ReaLTaiizor.Controls.MaterialButton();
            this.VeriKategoriButonGroupBox = new ReaLTaiizor.Controls.CyberGroupBox();
            this.btnVeriKategoriler = new ReaLTaiizor.Controls.MaterialButton();
            this.btnVeriUrunler = new ReaLTaiizor.Controls.MaterialButton();
            this.btnVeriMasalar = new ReaLTaiizor.Controls.MaterialButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.VeriButonGroupBox = new ReaLTaiizor.Controls.CyberGroupBox();
            this.btnVeriIstatistik = new ReaLTaiizor.Controls.MaterialButton();
            this.btnVeriDuzenle = new ReaLTaiizor.Controls.MaterialButton();
            this.btnVeriSil = new ReaLTaiizor.Controls.MaterialButton();
            this.btnVeriKaydet = new ReaLTaiizor.Controls.MaterialButton();
            this.btnVeriGuncelle = new ReaLTaiizor.Controls.MaterialButton();
            this.btnVeriEkle = new ReaLTaiizor.Controls.MaterialButton();
            this.SeciliKullaniciBilgileriGroupBox = new ReaLTaiizor.Controls.CyberGroupBox();
            this.txtKullaniciAdi = new ReaLTaiizor.Controls.AloneTextBox();
            this.txtAdSoyad = new ReaLTaiizor.Controls.AloneTextBox();
            this.txtSifre = new ReaLTaiizor.Controls.AloneTextBox();
            this.cmbRol = new ReaLTaiizor.Controls.AloneComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.BaslikBox.SuspendLayout();
            this.HesapButonGroupBox.SuspendLayout();
            this.VeriKategoriButonGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.VeriButonGroupBox.SuspendLayout();
            this.SeciliKullaniciBilgileriGroupBox.SuspendLayout();
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
            this.splitContainer1.Panel2.Controls.Add(this.SeciliKullaniciBilgileriGroupBox);
            this.splitContainer1.Panel2.Controls.Add(this.VeriKategoriButonGroupBox);
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer1.Panel2.Controls.Add(this.VeriButonGroupBox);
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint_1);
            this.splitContainer1.Size = new System.Drawing.Size(1332, 673);
            this.splitContainer1.SplitterDistance = 443;
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
            this.BaslikBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.BaslikBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.BaslikBox.Lighting = false;
            this.BaslikBox.LinearGradient_Background = false;
            this.BaslikBox.LinearGradientPen = false;
            this.BaslikBox.Location = new System.Drawing.Point(0, 0);
            this.BaslikBox.Name = "BaslikBox";
            this.BaslikBox.PenWidth = 15;
            this.BaslikBox.RGB = false;
            this.BaslikBox.Rounding = true;
            this.BaslikBox.RoundingInt = 60;
            this.BaslikBox.Size = new System.Drawing.Size(443, 58);
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
            this.CalisanTree.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.CalisanTree.ForeColor = System.Drawing.Color.White;
            this.CalisanTree.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(29)))));
            this.CalisanTree.Location = new System.Drawing.Point(14, 356);
            this.CalisanTree.Name = "CalisanTree";
            treeNode3.Name = "CalisanNodes";
            treeNode3.Text = "Çalışan Hesaplar";
            this.CalisanTree.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode3});
            this.CalisanTree.Size = new System.Drawing.Size(411, 212);
            this.CalisanTree.TabIndex = 11;
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
            this.AdminTree.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AdminTree.ForeColor = System.Drawing.Color.White;
            this.AdminTree.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(29)))));
            this.AdminTree.Location = new System.Drawing.Point(14, 104);
            this.AdminTree.Name = "AdminTree";
            treeNode4.Name = "AdminNodes";
            treeNode4.Text = "Yetkili Hesaplar";
            this.AdminTree.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode4});
            this.AdminTree.Size = new System.Drawing.Size(411, 212);
            this.AdminTree.TabIndex = 10;
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
            this.HesapButonGroupBox.Controls.Add(this.btnHesapDuzenle);
            this.HesapButonGroupBox.Controls.Add(this.btnHesapSil);
            this.HesapButonGroupBox.Controls.Add(this.btnHesapKaydet);
            this.HesapButonGroupBox.Controls.Add(this.btnHesapGuncelle);
            this.HesapButonGroupBox.Controls.Add(this.btnHesapEkle);
            this.HesapButonGroupBox.CyberGroupBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            this.HesapButonGroupBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.HesapButonGroupBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.HesapButonGroupBox.Lighting = false;
            this.HesapButonGroupBox.LinearGradient_Background = false;
            this.HesapButonGroupBox.LinearGradientPen = false;
            this.HesapButonGroupBox.Location = new System.Drawing.Point(0, 604);
            this.HesapButonGroupBox.Name = "HesapButonGroupBox";
            this.HesapButonGroupBox.PenWidth = 15;
            this.HesapButonGroupBox.RGB = false;
            this.HesapButonGroupBox.Rounding = true;
            this.HesapButonGroupBox.RoundingInt = 60;
            this.HesapButonGroupBox.Size = new System.Drawing.Size(443, 69);
            this.HesapButonGroupBox.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.HesapButonGroupBox.TabIndex = 7;
            this.HesapButonGroupBox.Tag = "Cyber";
            this.HesapButonGroupBox.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.HesapButonGroupBox.Timer_RGB = 300;
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
            this.btnHesapDuzenle.Location = new System.Drawing.Point(260, 19);
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
            this.btnHesapSil.Location = new System.Drawing.Point(14, 19);
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
            // 
            // btnHesapKaydet
            // 
            this.btnHesapKaydet.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnHesapKaydet.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnHesapKaydet.Depth = 0;
            this.btnHesapKaydet.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHesapKaydet.HighEmphasis = true;
            this.btnHesapKaydet.Icon = null;
            this.btnHesapKaydet.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.btnHesapKaydet.Location = new System.Drawing.Point(353, 19);
            this.btnHesapKaydet.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnHesapKaydet.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.btnHesapKaydet.Name = "btnHesapKaydet";
            this.btnHesapKaydet.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnHesapKaydet.Size = new System.Drawing.Size(76, 36);
            this.btnHesapKaydet.TabIndex = 2;
            this.btnHesapKaydet.Text = "KAYDET";
            this.btnHesapKaydet.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnHesapKaydet.UseAccentColor = false;
            this.btnHesapKaydet.UseVisualStyleBackColor = true;
            // 
            // btnHesapGuncelle
            // 
            this.btnHesapGuncelle.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnHesapGuncelle.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnHesapGuncelle.Depth = 0;
            this.btnHesapGuncelle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHesapGuncelle.HighEmphasis = true;
            this.btnHesapGuncelle.Icon = null;
            this.btnHesapGuncelle.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.btnHesapGuncelle.Location = new System.Drawing.Point(158, 19);
            this.btnHesapGuncelle.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnHesapGuncelle.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.btnHesapGuncelle.Name = "btnHesapGuncelle";
            this.btnHesapGuncelle.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnHesapGuncelle.Size = new System.Drawing.Size(94, 36);
            this.btnHesapGuncelle.TabIndex = 4;
            this.btnHesapGuncelle.Text = "GÜNCELLE";
            this.btnHesapGuncelle.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnHesapGuncelle.UseAccentColor = false;
            this.btnHesapGuncelle.UseVisualStyleBackColor = true;
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
            this.btnHesapEkle.Location = new System.Drawing.Point(86, 19);
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
            this.VeriKategoriButonGroupBox.Size = new System.Drawing.Size(885, 58);
            this.VeriKategoriButonGroupBox.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.VeriKategoriButonGroupBox.TabIndex = 10;
            this.VeriKategoriButonGroupBox.Tag = "Cyber";
            this.VeriKategoriButonGroupBox.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.VeriKategoriButonGroupBox.Timer_RGB = 300;
            // 
            // btnVeriKategoriler
            // 
            this.btnVeriKategoriler.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnVeriKategoriler.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnVeriKategoriler.Depth = 0;
            this.btnVeriKategoriler.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVeriKategoriler.HighEmphasis = true;
            this.btnVeriKategoriler.Icon = null;
            this.btnVeriKategoriler.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.btnVeriKategoriler.Location = new System.Drawing.Point(479, 11);
            this.btnVeriKategoriler.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnVeriKategoriler.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.btnVeriKategoriler.Name = "btnVeriKategoriler";
            this.btnVeriKategoriler.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnVeriKategoriler.Size = new System.Drawing.Size(117, 36);
            this.btnVeriKategoriler.TabIndex = 3;
            this.btnVeriKategoriler.Text = "KATEGORİLER";
            this.btnVeriKategoriler.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnVeriKategoriler.UseAccentColor = false;
            this.btnVeriKategoriler.UseVisualStyleBackColor = true;
            // 
            // btnVeriUrunler
            // 
            this.btnVeriUrunler.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnVeriUrunler.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnVeriUrunler.Depth = 0;
            this.btnVeriUrunler.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnVeriUrunler.HighEmphasis = true;
            this.btnVeriUrunler.Icon = null;
            this.btnVeriUrunler.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.btnVeriUrunler.Location = new System.Drawing.Point(385, 11);
            this.btnVeriUrunler.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnVeriUrunler.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.btnVeriUrunler.Name = "btnVeriUrunler";
            this.btnVeriUrunler.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnVeriUrunler.Size = new System.Drawing.Size(86, 36);
            this.btnVeriUrunler.TabIndex = 2;
            this.btnVeriUrunler.Text = "ÜRÜNLER";
            this.btnVeriUrunler.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnVeriUrunler.UseAccentColor = false;
            this.btnVeriUrunler.UseVisualStyleBackColor = true;
            // 
            // btnVeriMasalar
            // 
            this.btnVeriMasalar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnVeriMasalar.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnVeriMasalar.Depth = 0;
            this.btnVeriMasalar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVeriMasalar.HighEmphasis = true;
            this.btnVeriMasalar.Icon = null;
            this.btnVeriMasalar.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.btnVeriMasalar.Location = new System.Drawing.Point(288, 11);
            this.btnVeriMasalar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnVeriMasalar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.btnVeriMasalar.Name = "btnVeriMasalar";
            this.btnVeriMasalar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnVeriMasalar.Size = new System.Drawing.Size(89, 36);
            this.btnVeriMasalar.TabIndex = 1;
            this.btnVeriMasalar.Text = "Masalar";
            this.btnVeriMasalar.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnVeriMasalar.UseAccentColor = false;
            this.btnVeriMasalar.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(0, 61);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(885, 543);
            this.dataGridView1.TabIndex = 9;
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
            this.VeriButonGroupBox.Controls.Add(this.btnVeriKaydet);
            this.VeriButonGroupBox.Controls.Add(this.btnVeriGuncelle);
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
            this.VeriButonGroupBox.Size = new System.Drawing.Size(885, 69);
            this.VeriButonGroupBox.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.VeriButonGroupBox.TabIndex = 8;
            this.VeriButonGroupBox.Tag = "Cyber";
            this.VeriButonGroupBox.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.VeriButonGroupBox.Timer_RGB = 300;
            this.VeriButonGroupBox.Load += new System.EventHandler(this.VeriButonGroupBox_Load);
            // 
            // btnVeriIstatistik
            // 
            this.btnVeriIstatistik.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnVeriIstatistik.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnVeriIstatistik.Depth = 0;
            this.btnVeriIstatistik.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVeriIstatistik.HighEmphasis = true;
            this.btnVeriIstatistik.Icon = null;
            this.btnVeriIstatistik.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.btnVeriIstatistik.Location = new System.Drawing.Point(770, 19);
            this.btnVeriIstatistik.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnVeriIstatistik.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.btnVeriIstatistik.Name = "btnVeriIstatistik";
            this.btnVeriIstatistik.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnVeriIstatistik.Size = new System.Drawing.Size(97, 36);
            this.btnVeriIstatistik.TabIndex = 6;
            this.btnVeriIstatistik.Text = "İSTATİSTİK";
            this.btnVeriIstatistik.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnVeriIstatistik.UseAccentColor = false;
            this.btnVeriIstatistik.UseVisualStyleBackColor = true;
            // 
            // btnVeriDuzenle
            // 
            this.btnVeriDuzenle.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnVeriDuzenle.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnVeriDuzenle.Depth = 0;
            this.btnVeriDuzenle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnVeriDuzenle.HighEmphasis = true;
            this.btnVeriDuzenle.Icon = null;
            this.btnVeriDuzenle.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.btnVeriDuzenle.Location = new System.Drawing.Point(593, 19);
            this.btnVeriDuzenle.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnVeriDuzenle.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.btnVeriDuzenle.Name = "btnVeriDuzenle";
            this.btnVeriDuzenle.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnVeriDuzenle.Size = new System.Drawing.Size(85, 36);
            this.btnVeriDuzenle.TabIndex = 5;
            this.btnVeriDuzenle.Text = "DÜZENLE";
            this.btnVeriDuzenle.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnVeriDuzenle.UseAccentColor = false;
            this.btnVeriDuzenle.UseVisualStyleBackColor = true;
            // 
            // btnVeriSil
            // 
            this.btnVeriSil.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnVeriSil.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnVeriSil.Depth = 0;
            this.btnVeriSil.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVeriSil.HighEmphasis = true;
            this.btnVeriSil.Icon = null;
            this.btnVeriSil.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.btnVeriSil.Location = new System.Drawing.Point(18, 19);
            this.btnVeriSil.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnVeriSil.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.btnVeriSil.Name = "btnVeriSil";
            this.btnVeriSil.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnVeriSil.Size = new System.Drawing.Size(64, 36);
            this.btnVeriSil.TabIndex = 3;
            this.btnVeriSil.Text = "SİL";
            this.btnVeriSil.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnVeriSil.UseAccentColor = false;
            this.btnVeriSil.UseVisualStyleBackColor = true;
            // 
            // btnVeriKaydet
            // 
            this.btnVeriKaydet.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnVeriKaydet.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnVeriKaydet.Depth = 0;
            this.btnVeriKaydet.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnVeriKaydet.HighEmphasis = true;
            this.btnVeriKaydet.Icon = null;
            this.btnVeriKaydet.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.btnVeriKaydet.Location = new System.Drawing.Point(686, 19);
            this.btnVeriKaydet.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnVeriKaydet.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.btnVeriKaydet.Name = "btnVeriKaydet";
            this.btnVeriKaydet.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnVeriKaydet.Size = new System.Drawing.Size(76, 36);
            this.btnVeriKaydet.TabIndex = 2;
            this.btnVeriKaydet.Text = "KAYDET";
            this.btnVeriKaydet.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnVeriKaydet.UseAccentColor = false;
            this.btnVeriKaydet.UseVisualStyleBackColor = true;
            // 
            // btnVeriGuncelle
            // 
            this.btnVeriGuncelle.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnVeriGuncelle.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnVeriGuncelle.Depth = 0;
            this.btnVeriGuncelle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVeriGuncelle.HighEmphasis = true;
            this.btnVeriGuncelle.Icon = null;
            this.btnVeriGuncelle.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.btnVeriGuncelle.Location = new System.Drawing.Point(162, 19);
            this.btnVeriGuncelle.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnVeriGuncelle.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.btnVeriGuncelle.Name = "btnVeriGuncelle";
            this.btnVeriGuncelle.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnVeriGuncelle.Size = new System.Drawing.Size(94, 36);
            this.btnVeriGuncelle.TabIndex = 4;
            this.btnVeriGuncelle.Text = "GÜNCELLE";
            this.btnVeriGuncelle.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnVeriGuncelle.UseAccentColor = false;
            this.btnVeriGuncelle.UseVisualStyleBackColor = true;
            // 
            // btnVeriEkle
            // 
            this.btnVeriEkle.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnVeriEkle.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnVeriEkle.Depth = 0;
            this.btnVeriEkle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnVeriEkle.HighEmphasis = true;
            this.btnVeriEkle.Icon = null;
            this.btnVeriEkle.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.btnVeriEkle.Location = new System.Drawing.Point(90, 19);
            this.btnVeriEkle.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnVeriEkle.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.btnVeriEkle.Name = "btnVeriEkle";
            this.btnVeriEkle.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnVeriEkle.Size = new System.Drawing.Size(64, 36);
            this.btnVeriEkle.TabIndex = 1;
            this.btnVeriEkle.Text = "EKLE";
            this.btnVeriEkle.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnVeriEkle.UseAccentColor = false;
            this.btnVeriEkle.UseVisualStyleBackColor = true;
            // 
            // SeciliKullaniciBilgileriGroupBox
            // 
            this.SeciliKullaniciBilgileriGroupBox.Alpha = 20;
            this.SeciliKullaniciBilgileriGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.SeciliKullaniciBilgileriGroupBox.Background = true;
            this.SeciliKullaniciBilgileriGroupBox.Background_WidthPen = 3F;
            this.SeciliKullaniciBilgileriGroupBox.BackgroundPen = true;
            this.SeciliKullaniciBilgileriGroupBox.ColorBackground = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(68)))));
            this.SeciliKullaniciBilgileriGroupBox.ColorBackground_1 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(68)))));
            this.SeciliKullaniciBilgileriGroupBox.ColorBackground_2 = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(63)))), ((int)(((byte)(86)))));
            this.SeciliKullaniciBilgileriGroupBox.ColorBackground_Pen = System.Drawing.Color.Blue;
            this.SeciliKullaniciBilgileriGroupBox.ColorLighting = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.SeciliKullaniciBilgileriGroupBox.ColorPen_1 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(68)))));
            this.SeciliKullaniciBilgileriGroupBox.ColorPen_2 = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(63)))), ((int)(((byte)(86)))));
            this.SeciliKullaniciBilgileriGroupBox.Controls.Add(this.txtKullaniciAdi);
            this.SeciliKullaniciBilgileriGroupBox.Controls.Add(this.cmbRol);
            this.SeciliKullaniciBilgileriGroupBox.Controls.Add(this.txtAdSoyad);
            this.SeciliKullaniciBilgileriGroupBox.Controls.Add(this.txtSifre);
            this.SeciliKullaniciBilgileriGroupBox.CyberGroupBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            this.SeciliKullaniciBilgileriGroupBox.Enabled = false;
            this.SeciliKullaniciBilgileriGroupBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.SeciliKullaniciBilgileriGroupBox.Lighting = false;
            this.SeciliKullaniciBilgileriGroupBox.LinearGradient_Background = false;
            this.SeciliKullaniciBilgileriGroupBox.LinearGradientPen = false;
            this.SeciliKullaniciBilgileriGroupBox.Location = new System.Drawing.Point(308, 158);
            this.SeciliKullaniciBilgileriGroupBox.Name = "SeciliKullaniciBilgileriGroupBox";
            this.SeciliKullaniciBilgileriGroupBox.PenWidth = 15;
            this.SeciliKullaniciBilgileriGroupBox.RGB = false;
            this.SeciliKullaniciBilgileriGroupBox.Rounding = true;
            this.SeciliKullaniciBilgileriGroupBox.RoundingInt = 60;
            this.SeciliKullaniciBilgileriGroupBox.Size = new System.Drawing.Size(269, 357);
            this.SeciliKullaniciBilgileriGroupBox.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.SeciliKullaniciBilgileriGroupBox.TabIndex = 12;
            this.SeciliKullaniciBilgileriGroupBox.Tag = "Cyber";
            this.SeciliKullaniciBilgileriGroupBox.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.SeciliKullaniciBilgileriGroupBox.Timer_RGB = 300;
            this.SeciliKullaniciBilgileriGroupBox.Load += new System.EventHandler(this.SeciliKullaniciBilgileriGroupBox_Load);
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.BackColor = System.Drawing.Color.Transparent;
            this.txtKullaniciAdi.EnabledCalc = true;
            this.txtKullaniciAdi.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtKullaniciAdi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(133)))), ((int)(((byte)(142)))));
            this.txtKullaniciAdi.Location = new System.Drawing.Point(52, 170);
            this.txtKullaniciAdi.MaxLength = 32767;
            this.txtKullaniciAdi.MultiLine = false;
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.ReadOnly = false;
            this.txtKullaniciAdi.Size = new System.Drawing.Size(164, 51);
            this.txtKullaniciAdi.TabIndex = 14;
            this.txtKullaniciAdi.Text = "Kullanıcı Adı";
            this.txtKullaniciAdi.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtKullaniciAdi.UseSystemPasswordChar = false;
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.BackColor = System.Drawing.Color.Transparent;
            this.txtAdSoyad.EnabledCalc = true;
            this.txtAdSoyad.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtAdSoyad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(133)))), ((int)(((byte)(142)))));
            this.txtAdSoyad.Location = new System.Drawing.Point(52, 113);
            this.txtAdSoyad.MaxLength = 32767;
            this.txtAdSoyad.MultiLine = false;
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.ReadOnly = false;
            this.txtAdSoyad.Size = new System.Drawing.Size(164, 51);
            this.txtAdSoyad.TabIndex = 15;
            this.txtAdSoyad.Text = "Ad Soyad";
            this.txtAdSoyad.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtAdSoyad.UseSystemPasswordChar = false;
            // 
            // txtSifre
            // 
            this.txtSifre.BackColor = System.Drawing.Color.Transparent;
            this.txtSifre.EnabledCalc = true;
            this.txtSifre.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSifre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(133)))), ((int)(((byte)(142)))));
            this.txtSifre.Location = new System.Drawing.Point(52, 225);
            this.txtSifre.MaxLength = 32767;
            this.txtSifre.MultiLine = false;
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.ReadOnly = false;
            this.txtSifre.Size = new System.Drawing.Size(164, 51);
            this.txtSifre.TabIndex = 16;
            this.txtSifre.Text = "Şifre";
            this.txtSifre.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtSifre.UseSystemPasswordChar = false;
            // 
            // cmbRol
            // 
            this.cmbRol.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbRol.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbRol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRol.EnabledCalc = true;
            this.cmbRol.FormattingEnabled = true;
            this.cmbRol.ItemHeight = 20;
            this.cmbRol.Location = new System.Drawing.Point(102, 81);
            this.cmbRol.Name = "cmbRol";
            this.cmbRol.Size = new System.Drawing.Size(64, 26);
            this.cmbRol.TabIndex = 17;
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
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.BaslikBox.ResumeLayout(false);
            this.HesapButonGroupBox.ResumeLayout(false);
            this.HesapButonGroupBox.PerformLayout();
            this.VeriKategoriButonGroupBox.ResumeLayout(false);
            this.VeriKategoriButonGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.VeriButonGroupBox.ResumeLayout(false);
            this.VeriButonGroupBox.PerformLayout();
            this.SeciliKullaniciBilgileriGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void btnHesapEkle_Click(object sender, EventArgs e)
        {

        }

        private void HesapLabel_Click(object sender, EventArgs e)
        {

        }

        private void VeriButonGroupBox_Load(object sender, EventArgs e)
        {

        }

        private void frmAdminControlPanel_Load_1(object sender, EventArgs e)
        {

        }

        private void txtAdSoyad_Click(object sender, EventArgs e)
        {

        }

        private void SeciliKullaniciBilgileriGroupBox_Load(object sender, EventArgs e)
        {

        }
    }
}
