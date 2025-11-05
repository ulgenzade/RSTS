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
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Yetkili Hesaplar");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Çalışan Hesaplar");
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.HesapLabel = new ReaLTaiizor.Controls.MetroLabel();
            this.btnHesapEkle = new ReaLTaiizor.Controls.MaterialButton();
            this.btnHesapKaydet = new ReaLTaiizor.Controls.MaterialButton();
            this.btnHesapSil = new ReaLTaiizor.Controls.MaterialButton();
            this.btnHesapGuncelle = new ReaLTaiizor.Controls.MaterialButton();
            this.HesapButonGroupBox = new ReaLTaiizor.Controls.CyberGroupBox();
            this.btnHesapDuzenle = new ReaLTaiizor.Controls.MaterialButton();
            this.AdminLabel = new ReaLTaiizor.Controls.MetroLabel();
            this.CalisanLabel = new ReaLTaiizor.Controls.MetroLabel();
            this.AdminTree = new ReaLTaiizor.Controls.ForeverTreeView();
            this.CalisanTree = new ReaLTaiizor.Controls.ForeverTreeView();
            this.BaslikBox = new ReaLTaiizor.Controls.CyberGroupBox();
            this.VeriButonGroupBox = new ReaLTaiizor.Controls.CyberGroupBox();
            this.btnVeriDuzenle = new ReaLTaiizor.Controls.MaterialButton();
            this.btnVeriSil = new ReaLTaiizor.Controls.MaterialButton();
            this.btnVeriKaydet = new ReaLTaiizor.Controls.MaterialButton();
            this.btnVeriGuncelle = new ReaLTaiizor.Controls.MaterialButton();
            this.btnVeriEkle = new ReaLTaiizor.Controls.MaterialButton();
            this.btnVeriIstatistik = new ReaLTaiizor.Controls.MaterialButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.HesapButonGroupBox.SuspendLayout();
            this.BaslikBox.SuspendLayout();
            this.VeriButonGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer1.Panel2.Controls.Add(this.VeriButonGroupBox);
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint_1);
            this.splitContainer1.Size = new System.Drawing.Size(1332, 673);
            this.splitContainer1.SplitterDistance = 443;
            this.splitContainer1.TabIndex = 0;
            // 
            // HesapLabel
            // 
            this.HesapLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.HesapLabel.IsDerivedStyle = true;
            this.HesapLabel.Location = new System.Drawing.Point(14, 9);
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
            // btnHesapEkle
            // 
            this.btnHesapEkle.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnHesapEkle.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnHesapEkle.Depth = 0;
            this.btnHesapEkle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHesapEkle.HighEmphasis = true;
            this.btnHesapEkle.Icon = null;
            this.btnHesapEkle.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.btnHesapEkle.Location = new System.Drawing.Point(86, 24);
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
            // btnHesapKaydet
            // 
            this.btnHesapKaydet.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnHesapKaydet.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnHesapKaydet.Depth = 0;
            this.btnHesapKaydet.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHesapKaydet.HighEmphasis = true;
            this.btnHesapKaydet.Icon = null;
            this.btnHesapKaydet.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.btnHesapKaydet.Location = new System.Drawing.Point(353, 24);
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
            // btnHesapSil
            // 
            this.btnHesapSil.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnHesapSil.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnHesapSil.Depth = 0;
            this.btnHesapSil.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHesapSil.HighEmphasis = true;
            this.btnHesapSil.Icon = null;
            this.btnHesapSil.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.btnHesapSil.Location = new System.Drawing.Point(14, 24);
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
            // btnHesapGuncelle
            // 
            this.btnHesapGuncelle.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnHesapGuncelle.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnHesapGuncelle.Depth = 0;
            this.btnHesapGuncelle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHesapGuncelle.HighEmphasis = true;
            this.btnHesapGuncelle.Icon = null;
            this.btnHesapGuncelle.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.btnHesapGuncelle.Location = new System.Drawing.Point(158, 24);
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
            this.HesapButonGroupBox.Location = new System.Drawing.Point(0, 598);
            this.HesapButonGroupBox.Name = "HesapButonGroupBox";
            this.HesapButonGroupBox.PenWidth = 15;
            this.HesapButonGroupBox.RGB = false;
            this.HesapButonGroupBox.Rounding = true;
            this.HesapButonGroupBox.RoundingInt = 60;
            this.HesapButonGroupBox.Size = new System.Drawing.Size(443, 75);
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
            this.btnHesapDuzenle.Location = new System.Drawing.Point(260, 24);
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
            // AdminTree
            // 
            this.AdminTree.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.AdminTree.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AdminTree.ForeColor = System.Drawing.Color.White;
            this.AdminTree.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(29)))));
            this.AdminTree.Location = new System.Drawing.Point(14, 104);
            this.AdminTree.Name = "AdminTree";
            treeNode6.Name = "AdminNodes";
            treeNode6.Text = "Yetkili Hesaplar";
            this.AdminTree.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode6});
            this.AdminTree.Size = new System.Drawing.Size(411, 212);
            this.AdminTree.TabIndex = 10;
            // 
            // CalisanTree
            // 
            this.CalisanTree.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.CalisanTree.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.CalisanTree.ForeColor = System.Drawing.Color.White;
            this.CalisanTree.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(29)))));
            this.CalisanTree.Location = new System.Drawing.Point(14, 356);
            this.CalisanTree.Name = "CalisanTree";
            treeNode5.Name = "CalisanNodes";
            treeNode5.Text = "Çalışan Hesaplar";
            this.CalisanTree.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode5});
            this.CalisanTree.Size = new System.Drawing.Size(411, 212);
            this.CalisanTree.TabIndex = 11;
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
            this.VeriButonGroupBox.Location = new System.Drawing.Point(0, 598);
            this.VeriButonGroupBox.Name = "VeriButonGroupBox";
            this.VeriButonGroupBox.PenWidth = 15;
            this.VeriButonGroupBox.RGB = false;
            this.VeriButonGroupBox.Rounding = true;
            this.VeriButonGroupBox.RoundingInt = 60;
            this.VeriButonGroupBox.Size = new System.Drawing.Size(885, 75);
            this.VeriButonGroupBox.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.VeriButonGroupBox.TabIndex = 8;
            this.VeriButonGroupBox.Tag = "Cyber";
            this.VeriButonGroupBox.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.VeriButonGroupBox.Timer_RGB = 300;
            this.VeriButonGroupBox.Load += new System.EventHandler(this.VeriButonGroupBox_Load);
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
            this.btnVeriDuzenle.Location = new System.Drawing.Point(595, 24);
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
            this.btnVeriSil.Location = new System.Drawing.Point(20, 24);
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
            this.btnVeriKaydet.Location = new System.Drawing.Point(688, 24);
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
            this.btnVeriGuncelle.Location = new System.Drawing.Point(164, 24);
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
            this.btnVeriEkle.Location = new System.Drawing.Point(92, 24);
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
            // btnVeriIstatistik
            // 
            this.btnVeriIstatistik.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnVeriIstatistik.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnVeriIstatistik.Depth = 0;
            this.btnVeriIstatistik.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVeriIstatistik.HighEmphasis = true;
            this.btnVeriIstatistik.Icon = null;
            this.btnVeriIstatistik.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.btnVeriIstatistik.Location = new System.Drawing.Point(772, 24);
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
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(885, 598);
            this.dataGridView1.TabIndex = 9;
            // 
            // frmAdminControlPanel
            // 
            this.ClientSize = new System.Drawing.Size(1332, 673);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmAdminControlPanel";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.HesapButonGroupBox.ResumeLayout(false);
            this.HesapButonGroupBox.PerformLayout();
            this.BaslikBox.ResumeLayout(false);
            this.VeriButonGroupBox.ResumeLayout(false);
            this.VeriButonGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
    }
}
