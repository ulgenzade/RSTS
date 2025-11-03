namespace RestoranOtomasyon
{
    partial class frmAdminControlPanel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.listCalisanlar = new System.Windows.Forms.ListBox();
            this.lblCalisanHeader = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.listAdmins = new System.Windows.Forms.ListBox();
            this.lblAdminHeader = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.gbHesaplar = new Guna.UI2.WinForms.Guna2GroupBox();
            this.btnHesapKaydet = new Guna.UI2.WinForms.Guna2Button();
            this.btnHesapGuncelle = new Guna.UI2.WinForms.Guna2Button();
            this.btnHesapSil = new Guna.UI2.WinForms.Guna2Button();
            this.btnHesapEkle = new Guna.UI2.WinForms.Guna2Button();
            this.gbUrunler = new Guna.UI2.WinForms.Guna2GroupBox();
            this.btnCikis = new Guna.UI2.WinForms.Guna2Button();
            this.btnSiparisEkrani = new Guna.UI2.WinForms.Guna2Button();
            this.btnUrunKaydet = new Guna.UI2.WinForms.Guna2Button();
            this.btnIstatistik = new Guna.UI2.WinForms.Guna2Button();
            this.btnUrunSil = new Guna.UI2.WinForms.Guna2Button();
            this.btnUrunEkle = new Guna.UI2.WinForms.Guna2Button();
            this.dgvUrunler = new Guna.UI2.WinForms.Guna2DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.gbHesaplar.SuspendLayout();
            this.gbUrunler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUrunler)).BeginInit();
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
            this.splitContainer1.Panel1.Controls.Add(this.listCalisanlar);
            this.splitContainer1.Panel1.Controls.Add(this.lblCalisanHeader);
            this.splitContainer1.Panel1.Controls.Add(this.listAdmins);
            this.splitContainer1.Panel1.Controls.Add(this.lblAdminHeader);
            this.splitContainer1.Panel1.Controls.Add(this.gbHesaplar);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gbUrunler);
            this.splitContainer1.Panel2.Controls.Add(this.dgvUrunler);
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(1066, 511);
            this.splitContainer1.SplitterDistance = 355;
            this.splitContainer1.TabIndex = 0;
            // 
            // listCalisanlar
            // 
            this.listCalisanlar.Dock = System.Windows.Forms.DockStyle.Top;
            this.listCalisanlar.FormattingEnabled = true;
            this.listCalisanlar.ItemHeight = 16;
            this.listCalisanlar.Location = new System.Drawing.Point(0, 168);
            this.listCalisanlar.Name = "listCalisanlar";
            this.listCalisanlar.Size = new System.Drawing.Size(355, 132);
            this.listCalisanlar.TabIndex = 6;
            this.listCalisanlar.SelectedIndexChanged += new System.EventHandler(this.listCalisanlar_SelectedIndexChanged);
            // 
            // lblCalisanHeader
            // 
            this.lblCalisanHeader.BackColor = System.Drawing.Color.Transparent;
            this.lblCalisanHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCalisanHeader.Location = new System.Drawing.Point(0, 150);
            this.lblCalisanHeader.Name = "lblCalisanHeader";
            this.lblCalisanHeader.Size = new System.Drawing.Size(355, 18);
            this.lblCalisanHeader.TabIndex = 5;
            this.lblCalisanHeader.Text = "Çalışan Hesapları";
            // 
            // listAdmins
            // 
            this.listAdmins.Dock = System.Windows.Forms.DockStyle.Top;
            this.listAdmins.FormattingEnabled = true;
            this.listAdmins.ItemHeight = 16;
            this.listAdmins.Location = new System.Drawing.Point(0, 18);
            this.listAdmins.Name = "listAdmins";
            this.listAdmins.Size = new System.Drawing.Size(355, 132);
            this.listAdmins.TabIndex = 4;
            // 
            // lblAdminHeader
            // 
            this.lblAdminHeader.BackColor = System.Drawing.Color.Transparent;
            this.lblAdminHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblAdminHeader.Location = new System.Drawing.Point(0, 0);
            this.lblAdminHeader.Name = "lblAdminHeader";
            this.lblAdminHeader.Size = new System.Drawing.Size(355, 18);
            this.lblAdminHeader.TabIndex = 3;
            this.lblAdminHeader.Text = "Admin Hesapları";
            // 
            // gbHesaplar
            // 
            this.gbHesaplar.BorderRadius = 15;
            this.gbHesaplar.Controls.Add(this.btnHesapKaydet);
            this.gbHesaplar.Controls.Add(this.btnHesapGuncelle);
            this.gbHesaplar.Controls.Add(this.btnHesapSil);
            this.gbHesaplar.Controls.Add(this.btnHesapEkle);
            this.gbHesaplar.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gbHesaplar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gbHesaplar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gbHesaplar.ForeColor = System.Drawing.Color.White;
            this.gbHesaplar.Location = new System.Drawing.Point(0, 383);
            this.gbHesaplar.Name = "gbHesaplar";
            this.gbHesaplar.Size = new System.Drawing.Size(355, 128);
            this.gbHesaplar.TabIndex = 2;
            this.gbHesaplar.Text = "HESAP AYARLARI";
            this.gbHesaplar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnHesapKaydet
            // 
            this.btnHesapKaydet.BorderRadius = 15;
            this.btnHesapKaydet.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnHesapKaydet.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnHesapKaydet.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnHesapKaydet.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnHesapKaydet.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnHesapKaydet.ForeColor = System.Drawing.Color.White;
            this.btnHesapKaydet.Location = new System.Drawing.Point(232, 55);
            this.btnHesapKaydet.Name = "btnHesapKaydet";
            this.btnHesapKaydet.Size = new System.Drawing.Size(101, 30);
            this.btnHesapKaydet.TabIndex = 3;
            this.btnHesapKaydet.Text = "KAYDET";
            // 
            // btnHesapGuncelle
            // 
            this.btnHesapGuncelle.BorderRadius = 16;
            this.btnHesapGuncelle.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnHesapGuncelle.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnHesapGuncelle.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnHesapGuncelle.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnHesapGuncelle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnHesapGuncelle.ForeColor = System.Drawing.Color.White;
            this.btnHesapGuncelle.Location = new System.Drawing.Point(232, 91);
            this.btnHesapGuncelle.Name = "btnHesapGuncelle";
            this.btnHesapGuncelle.Size = new System.Drawing.Size(101, 30);
            this.btnHesapGuncelle.TabIndex = 2;
            this.btnHesapGuncelle.Text = "GÜNCELLE";
            // 
            // btnHesapSil
            // 
            this.btnHesapSil.BorderRadius = 15;
            this.btnHesapSil.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnHesapSil.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnHesapSil.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnHesapSil.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnHesapSil.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnHesapSil.ForeColor = System.Drawing.Color.White;
            this.btnHesapSil.Location = new System.Drawing.Point(92, 91);
            this.btnHesapSil.Name = "btnHesapSil";
            this.btnHesapSil.Size = new System.Drawing.Size(73, 30);
            this.btnHesapSil.TabIndex = 1;
            this.btnHesapSil.Text = "SİL";
            // 
            // btnHesapEkle
            // 
            this.btnHesapEkle.BorderRadius = 15;
            this.btnHesapEkle.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnHesapEkle.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnHesapEkle.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnHesapEkle.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnHesapEkle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnHesapEkle.ForeColor = System.Drawing.Color.White;
            this.btnHesapEkle.Location = new System.Drawing.Point(13, 91);
            this.btnHesapEkle.Name = "btnHesapEkle";
            this.btnHesapEkle.Size = new System.Drawing.Size(73, 30);
            this.btnHesapEkle.TabIndex = 0;
            this.btnHesapEkle.Text = "EKLE";
            // 
            // gbUrunler
            // 
            this.gbUrunler.BorderRadius = 15;
            this.gbUrunler.Controls.Add(this.btnCikis);
            this.gbUrunler.Controls.Add(this.btnSiparisEkrani);
            this.gbUrunler.Controls.Add(this.btnUrunKaydet);
            this.gbUrunler.Controls.Add(this.btnIstatistik);
            this.gbUrunler.Controls.Add(this.btnUrunSil);
            this.gbUrunler.Controls.Add(this.btnUrunEkle);
            this.gbUrunler.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gbUrunler.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gbUrunler.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gbUrunler.ForeColor = System.Drawing.Color.White;
            this.gbUrunler.Location = new System.Drawing.Point(0, 383);
            this.gbUrunler.Name = "gbUrunler";
            this.gbUrunler.Size = new System.Drawing.Size(707, 128);
            this.gbUrunler.TabIndex = 1;
            this.gbUrunler.Text = "ÜRÜN AYARLARI";
            this.gbUrunler.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gbUrunler.Click += new System.EventHandler(this.gbUrunler_Click);
            // 
            // btnCikis
            // 
            this.btnCikis.BorderRadius = 15;
            this.btnCikis.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCikis.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCikis.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCikis.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCikis.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCikis.ForeColor = System.Drawing.Color.White;
            this.btnCikis.Location = new System.Drawing.Point(16, 55);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(180, 30);
            this.btnCikis.TabIndex = 5;
            this.btnCikis.Text = "ÇIKIŞ YAP";
            // 
            // btnSiparisEkrani
            // 
            this.btnSiparisEkrani.BorderRadius = 15;
            this.btnSiparisEkrani.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSiparisEkrani.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSiparisEkrani.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSiparisEkrani.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSiparisEkrani.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSiparisEkrani.ForeColor = System.Drawing.Color.White;
            this.btnSiparisEkrani.Location = new System.Drawing.Point(16, 91);
            this.btnSiparisEkrani.Name = "btnSiparisEkrani";
            this.btnSiparisEkrani.Size = new System.Drawing.Size(180, 30);
            this.btnSiparisEkrani.TabIndex = 4;
            this.btnSiparisEkrani.Text = "SİPARİŞ EKRANI";
            // 
            // btnUrunKaydet
            // 
            this.btnUrunKaydet.BorderRadius = 15;
            this.btnUrunKaydet.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUrunKaydet.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUrunKaydet.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUrunKaydet.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUrunKaydet.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnUrunKaydet.ForeColor = System.Drawing.Color.White;
            this.btnUrunKaydet.Location = new System.Drawing.Point(487, 91);
            this.btnUrunKaydet.Name = "btnUrunKaydet";
            this.btnUrunKaydet.Size = new System.Drawing.Size(101, 30);
            this.btnUrunKaydet.TabIndex = 3;
            this.btnUrunKaydet.Text = "KAYDET";
            // 
            // btnIstatistik
            // 
            this.btnIstatistik.BorderRadius = 15;
            this.btnIstatistik.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnIstatistik.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnIstatistik.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnIstatistik.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnIstatistik.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnIstatistik.ForeColor = System.Drawing.Color.White;
            this.btnIstatistik.Location = new System.Drawing.Point(594, 91);
            this.btnIstatistik.Name = "btnIstatistik";
            this.btnIstatistik.Size = new System.Drawing.Size(101, 30);
            this.btnIstatistik.TabIndex = 2;
            this.btnIstatistik.Text = "İSTATİSTİK";
            // 
            // btnUrunSil
            // 
            this.btnUrunSil.BorderRadius = 15;
            this.btnUrunSil.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUrunSil.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUrunSil.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUrunSil.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUrunSil.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnUrunSil.ForeColor = System.Drawing.Color.White;
            this.btnUrunSil.Location = new System.Drawing.Point(408, 91);
            this.btnUrunSil.Name = "btnUrunSil";
            this.btnUrunSil.Size = new System.Drawing.Size(73, 30);
            this.btnUrunSil.TabIndex = 1;
            this.btnUrunSil.Text = "SİL";
            // 
            // btnUrunEkle
            // 
            this.btnUrunEkle.BorderRadius = 15;
            this.btnUrunEkle.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUrunEkle.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUrunEkle.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUrunEkle.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUrunEkle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnUrunEkle.ForeColor = System.Drawing.Color.White;
            this.btnUrunEkle.Location = new System.Drawing.Point(329, 91);
            this.btnUrunEkle.Name = "btnUrunEkle";
            this.btnUrunEkle.Size = new System.Drawing.Size(73, 30);
            this.btnUrunEkle.TabIndex = 0;
            this.btnUrunEkle.Text = "EKLE";
            // 
            // dgvUrunler
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvUrunler.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUrunler.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvUrunler.ColumnHeadersHeight = 4;
            this.dgvUrunler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvUrunler.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvUrunler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUrunler.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvUrunler.Location = new System.Drawing.Point(0, 0);
            this.dgvUrunler.Name = "dgvUrunler";
            this.dgvUrunler.RowHeadersVisible = false;
            this.dgvUrunler.RowHeadersWidth = 51;
            this.dgvUrunler.RowTemplate.Height = 24;
            this.dgvUrunler.Size = new System.Drawing.Size(707, 511);
            this.dgvUrunler.TabIndex = 0;
            this.dgvUrunler.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvUrunler.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvUrunler.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvUrunler.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvUrunler.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvUrunler.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvUrunler.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvUrunler.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvUrunler.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvUrunler.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dgvUrunler.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvUrunler.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvUrunler.ThemeStyle.HeaderStyle.Height = 4;
            this.dgvUrunler.ThemeStyle.ReadOnly = false;
            this.dgvUrunler.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvUrunler.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvUrunler.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dgvUrunler.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvUrunler.ThemeStyle.RowsStyle.Height = 24;
            this.dgvUrunler.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvUrunler.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvUrunler.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.guna2DataGridView1_CellContentClick);
            // 
            // frmAdminControlPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 511);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmAdminControlPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAdminControlPanel";
            this.Load += new System.EventHandler(this.frmAdminControlPanel_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.gbHesaplar.ResumeLayout(false);
            this.gbUrunler.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUrunler)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private Guna.UI2.WinForms.Guna2GroupBox gbHesaplar;
        private Guna.UI2.WinForms.Guna2Button btnHesapGuncelle;
        private Guna.UI2.WinForms.Guna2Button btnHesapSil;
        private Guna.UI2.WinForms.Guna2Button btnHesapEkle;
        private Guna.UI2.WinForms.Guna2DataGridView dgvUrunler;
        private Guna.UI2.WinForms.Guna2GroupBox gbUrunler;
        private Guna.UI2.WinForms.Guna2Button btnUrunSil;
        private Guna.UI2.WinForms.Guna2Button btnUrunEkle;
        private Guna.UI2.WinForms.Guna2Button btnSiparisEkrani;
        private Guna.UI2.WinForms.Guna2Button btnUrunKaydet;
        private Guna.UI2.WinForms.Guna2Button btnIstatistik;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblAdminHeader;
        private Guna.UI2.WinForms.Guna2Button btnHesapKaydet;
        private Guna.UI2.WinForms.Guna2Button btnCikis;
        private System.Windows.Forms.ListBox listCalisanlar;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblCalisanHeader;
        private System.Windows.Forms.ListBox listAdmins;
    }
}