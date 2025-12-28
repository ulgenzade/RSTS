namespace RestoranOtomasyon
{
    partial class frmOdemeEkrani
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
            this.components = new System.ComponentModel.Container();
            this.panelUst = new System.Windows.Forms.Panel();
            this.labelSaatBilgi = new ReaLTaiizor.Controls.MaterialLabel();
            this.labelMasaBilgi = new ReaLTaiizor.Controls.MaterialLabel();
            this.btnGeriDon = new ReaLTaiizor.Controls.MaterialButton();
            this.panelSol = new System.Windows.Forms.Panel();
            this.flowTumSiparisler = new System.Windows.Forms.FlowLayoutPanel();
            this.panelSolAlt = new System.Windows.Forms.Panel();
            this.labelHesapBilgi = new ReaLTaiizor.Controls.MaterialLabel();
            this.labelToplamTutar = new ReaLTaiizor.Controls.MaterialLabel();
            this.panelSag = new System.Windows.Forms.Panel();
            this.panelOdenecekler = new System.Windows.Forms.FlowLayoutPanel();
            this.panelSagAlt = new System.Windows.Forms.Panel();
            this.labelVergi = new ReaLTaiizor.Controls.MaterialLabel();
            this.btnAdisyonYazdir = new ReaLTaiizor.Controls.MaterialButton();
            this.btnKart = new ReaLTaiizor.Controls.MaterialButton();
            this.btnNakit = new ReaLTaiizor.Controls.MaterialButton();
            this.labelOdemeYontemi = new ReaLTaiizor.Controls.MaterialLabel();
            this.labelOdenecekTutar = new ReaLTaiizor.Controls.MaterialLabel();
            this.panelOrta = new System.Windows.Forms.Panel();
            this.btnTasiBirlestir = new ReaLTaiizor.Controls.MaterialButton();
            this.btnBitir = new ReaLTaiizor.Controls.MaterialButton();
            this.btnHepsiniGeriAl = new ReaLTaiizor.Controls.MaterialButton();
            this.btnSecilenleriGeriAl = new ReaLTaiizor.Controls.MaterialButton();
            this.btnHepsiniAktar = new ReaLTaiizor.Controls.MaterialButton();
            this.btnSecilenAktar = new ReaLTaiizor.Controls.MaterialButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.panelUst.SuspendLayout();
            this.panelSol.SuspendLayout();
            this.panelSolAlt.SuspendLayout();
            this.panelSag.SuspendLayout();
            this.panelSagAlt.SuspendLayout();
            this.panelOrta.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelUst
            // 
            this.panelUst.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panelUst.Controls.Add(this.tableLayoutPanel5);
            this.panelUst.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelUst.Location = new System.Drawing.Point(0, 0);
            this.panelUst.Name = "panelUst";
            this.panelUst.Size = new System.Drawing.Size(1206, 62);
            this.panelUst.TabIndex = 1;
            // 
            // labelSaatBilgi
            // 
            this.labelSaatBilgi.AutoSize = true;
            this.labelSaatBilgi.Depth = 0;
            this.labelSaatBilgi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelSaatBilgi.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labelSaatBilgi.Location = new System.Drawing.Point(807, 3);
            this.labelSaatBilgi.Margin = new System.Windows.Forms.Padding(3);
            this.labelSaatBilgi.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.labelSaatBilgi.Name = "labelSaatBilgi";
            this.labelSaatBilgi.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.labelSaatBilgi.Size = new System.Drawing.Size(396, 56);
            this.labelSaatBilgi.TabIndex = 2;
            this.labelSaatBilgi.Text = "SAAT";
            this.labelSaatBilgi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelMasaBilgi
            // 
            this.labelMasaBilgi.AutoSize = true;
            this.labelMasaBilgi.Depth = 0;
            this.labelMasaBilgi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelMasaBilgi.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labelMasaBilgi.Location = new System.Drawing.Point(405, 3);
            this.labelMasaBilgi.Margin = new System.Windows.Forms.Padding(3);
            this.labelMasaBilgi.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.labelMasaBilgi.Name = "labelMasaBilgi";
            this.labelMasaBilgi.Size = new System.Drawing.Size(396, 56);
            this.labelMasaBilgi.TabIndex = 1;
            this.labelMasaBilgi.Text = "MASA VE SİPARİŞ NO";
            this.labelMasaBilgi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelMasaBilgi.Click += new System.EventHandler(this.labelMasaBilgi_Click);
            // 
            // btnGeriDon
            // 
            this.btnGeriDon.AutoSize = false;
            this.btnGeriDon.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGeriDon.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnGeriDon.Depth = 0;
            this.btnGeriDon.HighEmphasis = true;
            this.btnGeriDon.Icon = null;
            this.btnGeriDon.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.btnGeriDon.Location = new System.Drawing.Point(4, 6);
            this.btnGeriDon.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnGeriDon.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.btnGeriDon.Name = "btnGeriDon";
            this.btnGeriDon.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnGeriDon.Size = new System.Drawing.Size(96, 50);
            this.btnGeriDon.TabIndex = 0;
            this.btnGeriDon.Text = "GERİ DÖN";
            this.btnGeriDon.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnGeriDon.UseAccentColor = false;
            this.btnGeriDon.UseVisualStyleBackColor = true;
            this.btnGeriDon.Click += new System.EventHandler(this.btnGeriDon_Click);
            // 
            // panelSol
            // 
            this.panelSol.Controls.Add(this.flowTumSiparisler);
            this.panelSol.Controls.Add(this.panelSolAlt);
            this.panelSol.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSol.Location = new System.Drawing.Point(3, 3);
            this.panelSol.Name = "panelSol";
            this.panelSol.Size = new System.Drawing.Size(476, 605);
            this.panelSol.TabIndex = 2;
            // 
            // flowTumSiparisler
            // 
            this.flowTumSiparisler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowTumSiparisler.Location = new System.Drawing.Point(0, 0);
            this.flowTumSiparisler.Name = "flowTumSiparisler";
            this.flowTumSiparisler.Size = new System.Drawing.Size(476, 439);
            this.flowTumSiparisler.TabIndex = 1;
            // 
            // panelSolAlt
            // 
            this.panelSolAlt.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panelSolAlt.Controls.Add(this.tableLayoutPanel4);
            this.panelSolAlt.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelSolAlt.Location = new System.Drawing.Point(0, 439);
            this.panelSolAlt.Name = "panelSolAlt";
            this.panelSolAlt.Size = new System.Drawing.Size(476, 166);
            this.panelSolAlt.TabIndex = 0;
            // 
            // labelHesapBilgi
            // 
            this.labelHesapBilgi.AutoSize = true;
            this.labelHesapBilgi.Depth = 0;
            this.labelHesapBilgi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelHesapBilgi.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labelHesapBilgi.Location = new System.Drawing.Point(3, 81);
            this.labelHesapBilgi.Margin = new System.Windows.Forms.Padding(3);
            this.labelHesapBilgi.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.labelHesapBilgi.Name = "labelHesapBilgi";
            this.labelHesapBilgi.Size = new System.Drawing.Size(470, 82);
            this.labelHesapBilgi.TabIndex = 0;
            this.labelHesapBilgi.Text = "HESAP BİLGİSİ";
            this.labelHesapBilgi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelToplamTutar
            // 
            this.labelToplamTutar.AutoSize = true;
            this.labelToplamTutar.Depth = 0;
            this.labelToplamTutar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelToplamTutar.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labelToplamTutar.Location = new System.Drawing.Point(3, 3);
            this.labelToplamTutar.Margin = new System.Windows.Forms.Padding(3);
            this.labelToplamTutar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.labelToplamTutar.Name = "labelToplamTutar";
            this.labelToplamTutar.Size = new System.Drawing.Size(470, 72);
            this.labelToplamTutar.TabIndex = 1;
            this.labelToplamTutar.Text = "0,00 ₺";
            this.labelToplamTutar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelSag
            // 
            this.panelSag.Controls.Add(this.panelOdenecekler);
            this.panelSag.Controls.Add(this.panelSagAlt);
            this.panelSag.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSag.Location = new System.Drawing.Point(726, 3);
            this.panelSag.Name = "panelSag";
            this.panelSag.Size = new System.Drawing.Size(477, 605);
            this.panelSag.TabIndex = 3;
            // 
            // panelOdenecekler
            // 
            this.panelOdenecekler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelOdenecekler.Location = new System.Drawing.Point(0, 0);
            this.panelOdenecekler.Name = "panelOdenecekler";
            this.panelOdenecekler.Size = new System.Drawing.Size(477, 439);
            this.panelOdenecekler.TabIndex = 1;
            this.panelOdenecekler.Paint += new System.Windows.Forms.PaintEventHandler(this.panelOdenecekler_Paint);
            // 
            // panelSagAlt
            // 
            this.panelSagAlt.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panelSagAlt.Controls.Add(this.tableLayoutPanel3);
            this.panelSagAlt.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelSagAlt.Location = new System.Drawing.Point(0, 439);
            this.panelSagAlt.Name = "panelSagAlt";
            this.panelSagAlt.Size = new System.Drawing.Size(477, 166);
            this.panelSagAlt.TabIndex = 0;
            // 
            // labelVergi
            // 
            this.labelVergi.AutoSize = true;
            this.tableLayoutPanel3.SetColumnSpan(this.labelVergi, 3);
            this.labelVergi.Depth = 0;
            this.labelVergi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelVergi.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labelVergi.Location = new System.Drawing.Point(3, 23);
            this.labelVergi.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.labelVergi.Name = "labelVergi";
            this.labelVergi.Size = new System.Drawing.Size(471, 28);
            this.labelVergi.TabIndex = 7;
            this.labelVergi.Text = "VERGİ:            ";
            this.labelVergi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnAdisyonYazdir
            // 
            this.btnAdisyonYazdir.AutoSize = false;
            this.btnAdisyonYazdir.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAdisyonYazdir.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAdisyonYazdir.Depth = 0;
            this.btnAdisyonYazdir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAdisyonYazdir.HighEmphasis = true;
            this.btnAdisyonYazdir.Icon = null;
            this.btnAdisyonYazdir.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.btnAdisyonYazdir.Location = new System.Drawing.Point(319, 80);
            this.btnAdisyonYazdir.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.btnAdisyonYazdir.Name = "btnAdisyonYazdir";
            this.btnAdisyonYazdir.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAdisyonYazdir.Size = new System.Drawing.Size(155, 83);
            this.btnAdisyonYazdir.TabIndex = 6;
            this.btnAdisyonYazdir.Text = "ADİSYON YAZDIR";
            this.btnAdisyonYazdir.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAdisyonYazdir.UseAccentColor = false;
            this.btnAdisyonYazdir.UseVisualStyleBackColor = true;
            this.btnAdisyonYazdir.Click += new System.EventHandler(this.btnAdisyonYazdir_Click);
            // 
            // btnKart
            // 
            this.btnKart.AutoSize = false;
            this.btnKart.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnKart.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnKart.Depth = 0;
            this.btnKart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnKart.HighEmphasis = true;
            this.btnKart.Icon = null;
            this.btnKart.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.btnKart.Location = new System.Drawing.Point(3, 80);
            this.btnKart.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.btnKart.Name = "btnKart";
            this.btnKart.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnKart.Size = new System.Drawing.Size(152, 83);
            this.btnKart.TabIndex = 3;
            this.btnKart.Text = "KART";
            this.btnKart.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnKart.UseAccentColor = false;
            this.btnKart.UseVisualStyleBackColor = true;
            this.btnKart.Click += new System.EventHandler(this.btnKart_Click);
            // 
            // btnNakit
            // 
            this.btnNakit.AutoSize = false;
            this.btnNakit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnNakit.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnNakit.Depth = 0;
            this.btnNakit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNakit.HighEmphasis = true;
            this.btnNakit.Icon = null;
            this.btnNakit.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.btnNakit.Location = new System.Drawing.Point(161, 80);
            this.btnNakit.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.btnNakit.Name = "btnNakit";
            this.btnNakit.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnNakit.Size = new System.Drawing.Size(152, 83);
            this.btnNakit.TabIndex = 2;
            this.btnNakit.Text = "NAKİT";
            this.btnNakit.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnNakit.UseAccentColor = false;
            this.btnNakit.UseVisualStyleBackColor = true;
            this.btnNakit.Click += new System.EventHandler(this.btnNakit_Click);
            // 
            // labelOdemeYontemi
            // 
            this.labelOdemeYontemi.AutoSize = true;
            this.tableLayoutPanel3.SetColumnSpan(this.labelOdemeYontemi, 3);
            this.labelOdemeYontemi.Depth = 0;
            this.labelOdemeYontemi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelOdemeYontemi.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labelOdemeYontemi.Location = new System.Drawing.Point(3, 51);
            this.labelOdemeYontemi.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.labelOdemeYontemi.Name = "labelOdemeYontemi";
            this.labelOdemeYontemi.Size = new System.Drawing.Size(471, 26);
            this.labelOdemeYontemi.TabIndex = 1;
            this.labelOdemeYontemi.Text = "ÖDEME YÖNTEMİ:";
            this.labelOdemeYontemi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelOdemeYontemi.Click += new System.EventHandler(this.labelOdemeYontemi_Click);
            // 
            // labelOdenecekTutar
            // 
            this.labelOdenecekTutar.AutoSize = true;
            this.tableLayoutPanel3.SetColumnSpan(this.labelOdenecekTutar, 3);
            this.labelOdenecekTutar.Depth = 0;
            this.labelOdenecekTutar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelOdenecekTutar.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labelOdenecekTutar.Location = new System.Drawing.Point(3, 0);
            this.labelOdenecekTutar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.labelOdenecekTutar.Name = "labelOdenecekTutar";
            this.labelOdenecekTutar.Size = new System.Drawing.Size(471, 23);
            this.labelOdenecekTutar.TabIndex = 0;
            this.labelOdenecekTutar.Text = "ÖDENECEK TUTAR:     ";
            this.labelOdenecekTutar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelOrta
            // 
            this.panelOrta.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panelOrta.Controls.Add(this.tableLayoutPanel2);
            this.panelOrta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelOrta.Location = new System.Drawing.Point(485, 3);
            this.panelOrta.Name = "panelOrta";
            this.panelOrta.Size = new System.Drawing.Size(235, 605);
            this.panelOrta.TabIndex = 4;
            this.panelOrta.Paint += new System.Windows.Forms.PaintEventHandler(this.panelOrta_Paint);
            // 
            // btnTasiBirlestir
            // 
            this.btnTasiBirlestir.AutoSize = false;
            this.btnTasiBirlestir.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnTasiBirlestir.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnTasiBirlestir.Depth = 0;
            this.btnTasiBirlestir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTasiBirlestir.HighEmphasis = true;
            this.btnTasiBirlestir.Icon = null;
            this.btnTasiBirlestir.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.btnTasiBirlestir.Location = new System.Drawing.Point(3, 387);
            this.btnTasiBirlestir.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.btnTasiBirlestir.Name = "btnTasiBirlestir";
            this.btnTasiBirlestir.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnTasiBirlestir.Size = new System.Drawing.Size(229, 78);
            this.btnTasiBirlestir.TabIndex = 7;
            this.btnTasiBirlestir.Text = "TAŞI / BİRLEŞTİR";
            this.btnTasiBirlestir.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnTasiBirlestir.UseAccentColor = false;
            this.btnTasiBirlestir.UseVisualStyleBackColor = true;
            this.btnTasiBirlestir.Click += new System.EventHandler(this.btnTasiBirlestir_Click);
            // 
            // btnBitir
            // 
            this.btnBitir.AutoSize = false;
            this.btnBitir.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBitir.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnBitir.Depth = 0;
            this.btnBitir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBitir.HighEmphasis = true;
            this.btnBitir.Icon = null;
            this.btnBitir.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.btnBitir.Location = new System.Drawing.Point(3, 519);
            this.btnBitir.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.btnBitir.Name = "btnBitir";
            this.btnBitir.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnBitir.Size = new System.Drawing.Size(229, 83);
            this.btnBitir.TabIndex = 6;
            this.btnBitir.Text = "BİTİR";
            this.btnBitir.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnBitir.UseAccentColor = false;
            this.btnBitir.UseVisualStyleBackColor = true;
            this.btnBitir.Click += new System.EventHandler(this.btnBitir_Click);
            // 
            // btnHepsiniGeriAl
            // 
            this.btnHepsiniGeriAl.AutoSize = false;
            this.btnHepsiniGeriAl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnHepsiniGeriAl.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnHepsiniGeriAl.Depth = 0;
            this.btnHepsiniGeriAl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnHepsiniGeriAl.HighEmphasis = true;
            this.btnHepsiniGeriAl.Icon = null;
            this.btnHepsiniGeriAl.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.btnHepsiniGeriAl.Location = new System.Drawing.Point(3, 279);
            this.btnHepsiniGeriAl.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.btnHepsiniGeriAl.Name = "btnHepsiniGeriAl";
            this.btnHepsiniGeriAl.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnHepsiniGeriAl.Size = new System.Drawing.Size(229, 78);
            this.btnHepsiniGeriAl.TabIndex = 3;
            this.btnHepsiniGeriAl.Text = "<--  HEPSİNİ GERİ AL";
            this.btnHepsiniGeriAl.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnHepsiniGeriAl.UseAccentColor = false;
            this.btnHepsiniGeriAl.UseVisualStyleBackColor = true;
            this.btnHepsiniGeriAl.Click += new System.EventHandler(this.btnHepsiniGeriAl_Click);
            // 
            // btnSecilenleriGeriAl
            // 
            this.btnSecilenleriGeriAl.AutoSize = false;
            this.btnSecilenleriGeriAl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSecilenleriGeriAl.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSecilenleriGeriAl.Depth = 0;
            this.btnSecilenleriGeriAl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSecilenleriGeriAl.HighEmphasis = true;
            this.btnSecilenleriGeriAl.Icon = null;
            this.btnSecilenleriGeriAl.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.btnSecilenleriGeriAl.Location = new System.Drawing.Point(3, 195);
            this.btnSecilenleriGeriAl.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.btnSecilenleriGeriAl.Name = "btnSecilenleriGeriAl";
            this.btnSecilenleriGeriAl.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSecilenleriGeriAl.Size = new System.Drawing.Size(229, 78);
            this.btnSecilenleriGeriAl.TabIndex = 2;
            this.btnSecilenleriGeriAl.Text = "<--  SEÇİLENLERİ GERİ AL";
            this.btnSecilenleriGeriAl.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSecilenleriGeriAl.UseAccentColor = false;
            this.btnSecilenleriGeriAl.UseVisualStyleBackColor = true;
            this.btnSecilenleriGeriAl.Click += new System.EventHandler(this.btnSecilenleriGeriAl_Click);
            // 
            // btnHepsiniAktar
            // 
            this.btnHepsiniAktar.AutoSize = false;
            this.btnHepsiniAktar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnHepsiniAktar.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnHepsiniAktar.Depth = 0;
            this.btnHepsiniAktar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnHepsiniAktar.HighEmphasis = true;
            this.btnHepsiniAktar.Icon = null;
            this.btnHepsiniAktar.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.btnHepsiniAktar.Location = new System.Drawing.Point(3, 87);
            this.btnHepsiniAktar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.btnHepsiniAktar.Name = "btnHepsiniAktar";
            this.btnHepsiniAktar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnHepsiniAktar.Size = new System.Drawing.Size(229, 78);
            this.btnHepsiniAktar.TabIndex = 1;
            this.btnHepsiniAktar.Text = "HEPSİNİ AKTAR   -->";
            this.btnHepsiniAktar.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnHepsiniAktar.UseAccentColor = false;
            this.btnHepsiniAktar.UseVisualStyleBackColor = true;
            this.btnHepsiniAktar.Click += new System.EventHandler(this.btnHepsiniAktar_Click);
            // 
            // btnSecilenAktar
            // 
            this.btnSecilenAktar.AutoSize = false;
            this.btnSecilenAktar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSecilenAktar.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSecilenAktar.Depth = 0;
            this.btnSecilenAktar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSecilenAktar.HighEmphasis = true;
            this.btnSecilenAktar.Icon = null;
            this.btnSecilenAktar.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.btnSecilenAktar.Location = new System.Drawing.Point(3, 3);
            this.btnSecilenAktar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.btnSecilenAktar.Name = "btnSecilenAktar";
            this.btnSecilenAktar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSecilenAktar.Size = new System.Drawing.Size(229, 78);
            this.btnSecilenAktar.TabIndex = 0;
            this.btnSecilenAktar.Text = "SEÇİLENLERİ AKTAR   -->";
            this.btnSecilenAktar.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSecilenAktar.UseAccentColor = false;
            this.btnSecilenAktar.UseVisualStyleBackColor = true;
            this.btnSecilenAktar.Click += new System.EventHandler(this.btnSecilenAktar_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.Controls.Add(this.panelSol, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panelSag, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.panelOrta, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 62);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1206, 611);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.btnTasiBirlestir, 0, 6);
            this.tableLayoutPanel2.Controls.Add(this.btnBitir, 0, 8);
            this.tableLayoutPanel2.Controls.Add(this.btnSecilenAktar, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnHepsiniAktar, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.btnSecilenleriGeriAl, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.btnHepsiniGeriAl, 0, 4);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 9;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(235, 605);
            this.tableLayoutPanel2.TabIndex = 0;
            this.tableLayoutPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel2_Paint);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.Controls.Add(this.btnKart, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.btnNakit, 1, 3);
            this.tableLayoutPanel3.Controls.Add(this.btnAdisyonYazdir, 2, 3);
            this.tableLayoutPanel3.Controls.Add(this.labelOdemeYontemi, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.labelOdenecekTutar, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.labelVergi, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 4;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.85542F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.86747F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.66265F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 53.61446F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(477, 166);
            this.tableLayoutPanel3.TabIndex = 8;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Controls.Add(this.labelToplamTutar, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.labelHesapBilgi, 0, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 46.98795F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 53.01205F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(476, 166);
            this.tableLayoutPanel4.TabIndex = 2;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 3;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel5.Controls.Add(this.btnGeriDon, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.labelSaatBilgi, 2, 0);
            this.tableLayoutPanel5.Controls.Add(this.labelMasaBilgi, 1, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(1206, 62);
            this.tableLayoutPanel5.TabIndex = 3;
            // 
            // frmOdemeEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1206, 673);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panelUst);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmOdemeEkrani";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ÖDEME EKRANI";
            this.Load += new System.EventHandler(this.frmOdemeEkrani_Load);
            this.panelUst.ResumeLayout(false);
            this.panelSol.ResumeLayout(false);
            this.panelSolAlt.ResumeLayout(false);
            this.panelSag.ResumeLayout(false);
            this.panelSagAlt.ResumeLayout(false);
            this.panelOrta.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelUst;
        private ReaLTaiizor.Controls.MaterialButton btnGeriDon;
        private ReaLTaiizor.Controls.MaterialLabel labelSaatBilgi;
        private ReaLTaiizor.Controls.MaterialLabel labelMasaBilgi;
        private System.Windows.Forms.Panel panelSol;
        private System.Windows.Forms.Panel panelSolAlt;
        private System.Windows.Forms.Panel panelSag;
        private System.Windows.Forms.Panel panelSagAlt;
        private System.Windows.Forms.Panel panelOrta;
        private ReaLTaiizor.Controls.MaterialButton btnHepsiniGeriAl;
        private ReaLTaiizor.Controls.MaterialButton btnSecilenleriGeriAl;
        private ReaLTaiizor.Controls.MaterialButton btnHepsiniAktar;
        private ReaLTaiizor.Controls.MaterialButton btnSecilenAktar;
        private System.Windows.Forms.FlowLayoutPanel flowTumSiparisler;
        private ReaLTaiizor.Controls.MaterialLabel labelOdenecekTutar;
        private ReaLTaiizor.Controls.MaterialButton btnKart;
        private ReaLTaiizor.Controls.MaterialButton btnNakit;
        private ReaLTaiizor.Controls.MaterialLabel labelOdemeYontemi;
        private ReaLTaiizor.Controls.MaterialLabel labelToplamTutar;
        private System.Windows.Forms.FlowLayoutPanel panelOdenecekler;
        private ReaLTaiizor.Controls.MaterialLabel labelHesapBilgi;
        private ReaLTaiizor.Controls.MaterialButton btnBitir;
        private System.Windows.Forms.Timer timer1;
        private ReaLTaiizor.Controls.MaterialButton btnAdisyonYazdir;
        private ReaLTaiizor.Controls.MaterialButton btnTasiBirlestir;
        private ReaLTaiizor.Controls.MaterialLabel labelVergi;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
    }
}