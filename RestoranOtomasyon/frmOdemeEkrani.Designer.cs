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
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelHesapBilgi = new ReaLTaiizor.Controls.MaterialLabel();
            this.labelToplamTutar = new ReaLTaiizor.Controls.MaterialLabel();
            this.labelToplam = new ReaLTaiizor.Controls.MaterialLabel();
            this.panelSag = new System.Windows.Forms.Panel();
            this.panelOdenecekler = new System.Windows.Forms.FlowLayoutPanel();
            this.panelSagAlt = new System.Windows.Forms.Panel();
            this.labelToplamOdenecek = new ReaLTaiizor.Controls.MaterialLabel();
            this.btnOde = new ReaLTaiizor.Controls.MaterialButton();
            this.btnKart = new ReaLTaiizor.Controls.MaterialButton();
            this.btnNakit = new ReaLTaiizor.Controls.MaterialButton();
            this.labelOdemeYontemi = new ReaLTaiizor.Controls.MaterialLabel();
            this.labelOdenecekTutar = new ReaLTaiizor.Controls.MaterialLabel();
            this.panelOrta = new System.Windows.Forms.Panel();
            this.btnBitir = new ReaLTaiizor.Controls.MaterialButton();
            this.btnHepsiniGeriAl = new ReaLTaiizor.Controls.MaterialButton();
            this.btnSecilenleriGeriAl = new ReaLTaiizor.Controls.MaterialButton();
            this.btnHepsiniAktar = new ReaLTaiizor.Controls.MaterialButton();
            this.btnSecilenAktar = new ReaLTaiizor.Controls.MaterialButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelUst.SuspendLayout();
            this.panelSol.SuspendLayout();
            this.panelSolAlt.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelSag.SuspendLayout();
            this.panelSagAlt.SuspendLayout();
            this.panelOrta.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelUst
            // 
            this.panelUst.Controls.Add(this.labelSaatBilgi);
            this.panelUst.Controls.Add(this.labelMasaBilgi);
            this.panelUst.Controls.Add(this.btnGeriDon);
            this.panelUst.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelUst.Location = new System.Drawing.Point(0, 0);
            this.panelUst.Name = "panelUst";
            this.panelUst.Size = new System.Drawing.Size(1262, 62);
            this.panelUst.TabIndex = 1;
            // 
            // labelSaatBilgi
            // 
            this.labelSaatBilgi.AutoSize = true;
            this.labelSaatBilgi.Depth = 0;
            this.labelSaatBilgi.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labelSaatBilgi.Location = new System.Drawing.Point(1184, 22);
            this.labelSaatBilgi.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.labelSaatBilgi.Name = "labelSaatBilgi";
            this.labelSaatBilgi.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.labelSaatBilgi.Size = new System.Drawing.Size(41, 19);
            this.labelSaatBilgi.TabIndex = 2;
            this.labelSaatBilgi.Text = "SAAT";
            this.labelSaatBilgi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelMasaBilgi
            // 
            this.labelMasaBilgi.AutoSize = true;
            this.labelMasaBilgi.Depth = 0;
            this.labelMasaBilgi.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labelMasaBilgi.Location = new System.Drawing.Point(553, 22);
            this.labelMasaBilgi.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.labelMasaBilgi.Name = "labelMasaBilgi";
            this.labelMasaBilgi.Size = new System.Drawing.Size(156, 19);
            this.labelMasaBilgi.TabIndex = 1;
            this.labelMasaBilgi.Text = "MASA VE SİPAİRŞ NO";
            this.labelMasaBilgi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.btnGeriDon.Location = new System.Drawing.Point(14, 6);
            this.btnGeriDon.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnGeriDon.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.btnGeriDon.Name = "btnGeriDon";
            this.btnGeriDon.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnGeriDon.Size = new System.Drawing.Size(96, 52);
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
            this.panelSol.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSol.Location = new System.Drawing.Point(0, 62);
            this.panelSol.Name = "panelSol";
            this.panelSol.Size = new System.Drawing.Size(538, 611);
            this.panelSol.TabIndex = 2;
            // 
            // flowTumSiparisler
            // 
            this.flowTumSiparisler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowTumSiparisler.Location = new System.Drawing.Point(0, 0);
            this.flowTumSiparisler.Name = "flowTumSiparisler";
            this.flowTumSiparisler.Size = new System.Drawing.Size(538, 516);
            this.flowTumSiparisler.TabIndex = 1;
            // 
            // panelSolAlt
            // 
            this.panelSolAlt.Controls.Add(this.panel1);
            this.panelSolAlt.Controls.Add(this.labelToplamTutar);
            this.panelSolAlt.Controls.Add(this.labelToplam);
            this.panelSolAlt.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelSolAlt.Location = new System.Drawing.Point(0, 516);
            this.panelSolAlt.Name = "panelSolAlt";
            this.panelSolAlt.Size = new System.Drawing.Size(538, 95);
            this.panelSolAlt.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelHesapBilgi);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(538, 46);
            this.panel1.TabIndex = 2;
            // 
            // labelHesapBilgi
            // 
            this.labelHesapBilgi.AutoSize = true;
            this.labelHesapBilgi.Depth = 0;
            this.labelHesapBilgi.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labelHesapBilgi.Location = new System.Drawing.Point(12, 17);
            this.labelHesapBilgi.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.labelHesapBilgi.Name = "labelHesapBilgi";
            this.labelHesapBilgi.Size = new System.Drawing.Size(107, 19);
            this.labelHesapBilgi.TabIndex = 0;
            this.labelHesapBilgi.Text = "HESAP BİLGİSİ";
            // 
            // labelToplamTutar
            // 
            this.labelToplamTutar.AutoSize = true;
            this.labelToplamTutar.Depth = 0;
            this.labelToplamTutar.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labelToplamTutar.Location = new System.Drawing.Point(110, 18);
            this.labelToplamTutar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.labelToplamTutar.Name = "labelToplamTutar";
            this.labelToplamTutar.Size = new System.Drawing.Size(44, 19);
            this.labelToplamTutar.TabIndex = 1;
            this.labelToplamTutar.Text = "0,00 ₺";
            // 
            // labelToplam
            // 
            this.labelToplam.AutoSize = true;
            this.labelToplam.Depth = 0;
            this.labelToplam.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labelToplam.Location = new System.Drawing.Point(11, 18);
            this.labelToplam.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.labelToplam.Name = "labelToplam";
            this.labelToplam.Size = new System.Drawing.Size(81, 19);
            this.labelToplam.TabIndex = 0;
            this.labelToplam.Text = "TOPLAM:   ";
            this.labelToplam.Click += new System.EventHandler(this.labelToplam_Click);
            // 
            // panelSag
            // 
            this.panelSag.Controls.Add(this.panelOdenecekler);
            this.panelSag.Controls.Add(this.panelSagAlt);
            this.panelSag.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelSag.Location = new System.Drawing.Point(775, 62);
            this.panelSag.Name = "panelSag";
            this.panelSag.Size = new System.Drawing.Size(487, 611);
            this.panelSag.TabIndex = 3;
            // 
            // panelOdenecekler
            // 
            this.panelOdenecekler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelOdenecekler.Location = new System.Drawing.Point(0, 0);
            this.panelOdenecekler.Name = "panelOdenecekler";
            this.panelOdenecekler.Size = new System.Drawing.Size(487, 445);
            this.panelOdenecekler.TabIndex = 1;
            this.panelOdenecekler.Paint += new System.Windows.Forms.PaintEventHandler(this.panelOdenecekler_Paint);
            // 
            // panelSagAlt
            // 
            this.panelSagAlt.Controls.Add(this.labelToplamOdenecek);
            this.panelSagAlt.Controls.Add(this.btnOde);
            this.panelSagAlt.Controls.Add(this.btnKart);
            this.panelSagAlt.Controls.Add(this.btnNakit);
            this.panelSagAlt.Controls.Add(this.labelOdemeYontemi);
            this.panelSagAlt.Controls.Add(this.labelOdenecekTutar);
            this.panelSagAlt.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelSagAlt.Location = new System.Drawing.Point(0, 445);
            this.panelSagAlt.Name = "panelSagAlt";
            this.panelSagAlt.Size = new System.Drawing.Size(487, 166);
            this.panelSagAlt.TabIndex = 0;
            // 
            // labelToplamOdenecek
            // 
            this.labelToplamOdenecek.AutoSize = true;
            this.labelToplamOdenecek.Depth = 0;
            this.labelToplamOdenecek.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labelToplamOdenecek.Location = new System.Drawing.Point(206, 26);
            this.labelToplamOdenecek.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.labelToplamOdenecek.Name = "labelToplamOdenecek";
            this.labelToplamOdenecek.Size = new System.Drawing.Size(44, 19);
            this.labelToplamOdenecek.TabIndex = 5;
            this.labelToplamOdenecek.Text = "0,00 ₺";
            // 
            // btnOde
            // 
            this.btnOde.AutoSize = false;
            this.btnOde.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnOde.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnOde.Depth = 0;
            this.btnOde.HighEmphasis = true;
            this.btnOde.Icon = null;
            this.btnOde.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.btnOde.Location = new System.Drawing.Point(353, 108);
            this.btnOde.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnOde.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.btnOde.Name = "btnOde";
            this.btnOde.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnOde.Size = new System.Drawing.Size(108, 52);
            this.btnOde.TabIndex = 4;
            this.btnOde.Text = "ÖDE";
            this.btnOde.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnOde.UseAccentColor = false;
            this.btnOde.UseVisualStyleBackColor = true;
            this.btnOde.Click += new System.EventHandler(this.btnOde_Click);
            // 
            // btnKart
            // 
            this.btnKart.AutoSize = false;
            this.btnKart.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnKart.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnKart.Depth = 0;
            this.btnKart.HighEmphasis = true;
            this.btnKart.Icon = null;
            this.btnKart.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.btnKart.Location = new System.Drawing.Point(193, 108);
            this.btnKart.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnKart.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.btnKart.Name = "btnKart";
            this.btnKart.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnKart.Size = new System.Drawing.Size(108, 52);
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
            this.btnNakit.HighEmphasis = true;
            this.btnNakit.Icon = null;
            this.btnNakit.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.btnNakit.Location = new System.Drawing.Point(33, 108);
            this.btnNakit.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnNakit.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.btnNakit.Name = "btnNakit";
            this.btnNakit.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnNakit.Size = new System.Drawing.Size(108, 52);
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
            this.labelOdemeYontemi.Depth = 0;
            this.labelOdemeYontemi.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labelOdemeYontemi.Location = new System.Drawing.Point(18, 71);
            this.labelOdemeYontemi.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.labelOdemeYontemi.Name = "labelOdemeYontemi";
            this.labelOdemeYontemi.Size = new System.Drawing.Size(132, 19);
            this.labelOdemeYontemi.TabIndex = 1;
            this.labelOdemeYontemi.Text = "ÖDEME YÖNTEMİ:";
            this.labelOdemeYontemi.Click += new System.EventHandler(this.labelOdemeYontemi_Click);
            // 
            // labelOdenecekTutar
            // 
            this.labelOdenecekTutar.AutoSize = true;
            this.labelOdenecekTutar.Depth = 0;
            this.labelOdenecekTutar.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labelOdenecekTutar.Location = new System.Drawing.Point(18, 26);
            this.labelOdenecekTutar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.labelOdenecekTutar.Name = "labelOdenecekTutar";
            this.labelOdenecekTutar.Size = new System.Drawing.Size(159, 19);
            this.labelOdenecekTutar.TabIndex = 0;
            this.labelOdenecekTutar.Text = "ÖDENECEK TUTAR:     ";
            // 
            // panelOrta
            // 
            this.panelOrta.Controls.Add(this.btnBitir);
            this.panelOrta.Controls.Add(this.btnHepsiniGeriAl);
            this.panelOrta.Controls.Add(this.btnSecilenleriGeriAl);
            this.panelOrta.Controls.Add(this.btnHepsiniAktar);
            this.panelOrta.Controls.Add(this.btnSecilenAktar);
            this.panelOrta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelOrta.Location = new System.Drawing.Point(538, 62);
            this.panelOrta.Name = "panelOrta";
            this.panelOrta.Size = new System.Drawing.Size(237, 611);
            this.panelOrta.TabIndex = 4;
            this.panelOrta.Paint += new System.Windows.Forms.PaintEventHandler(this.panelOrta_Paint);
            // 
            // btnBitir
            // 
            this.btnBitir.AutoSize = false;
            this.btnBitir.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBitir.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnBitir.Depth = 0;
            this.btnBitir.HighEmphasis = true;
            this.btnBitir.Icon = null;
            this.btnBitir.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.btnBitir.Location = new System.Drawing.Point(64, 553);
            this.btnBitir.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnBitir.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.btnBitir.Name = "btnBitir";
            this.btnBitir.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnBitir.Size = new System.Drawing.Size(108, 52);
            this.btnBitir.TabIndex = 6;
            this.btnBitir.Text = "BİTİR";
            this.btnBitir.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnBitir.UseAccentColor = false;
            this.btnBitir.UseVisualStyleBackColor = true;
            // 
            // btnHepsiniGeriAl
            // 
            this.btnHepsiniGeriAl.AutoSize = false;
            this.btnHepsiniGeriAl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnHepsiniGeriAl.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnHepsiniGeriAl.Depth = 0;
            this.btnHepsiniGeriAl.HighEmphasis = true;
            this.btnHepsiniGeriAl.Icon = null;
            this.btnHepsiniGeriAl.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.btnHepsiniGeriAl.Location = new System.Drawing.Point(4, 395);
            this.btnHepsiniGeriAl.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnHepsiniGeriAl.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.btnHepsiniGeriAl.Name = "btnHepsiniGeriAl";
            this.btnHepsiniGeriAl.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnHepsiniGeriAl.Size = new System.Drawing.Size(229, 52);
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
            this.btnSecilenleriGeriAl.HighEmphasis = true;
            this.btnSecilenleriGeriAl.Icon = null;
            this.btnSecilenleriGeriAl.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.btnSecilenleriGeriAl.Location = new System.Drawing.Point(4, 318);
            this.btnSecilenleriGeriAl.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSecilenleriGeriAl.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.btnSecilenleriGeriAl.Name = "btnSecilenleriGeriAl";
            this.btnSecilenleriGeriAl.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSecilenleriGeriAl.Size = new System.Drawing.Size(229, 52);
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
            this.btnHepsiniAktar.HighEmphasis = true;
            this.btnHepsiniAktar.Icon = null;
            this.btnHepsiniAktar.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.btnHepsiniAktar.Location = new System.Drawing.Point(4, 241);
            this.btnHepsiniAktar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnHepsiniAktar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.btnHepsiniAktar.Name = "btnHepsiniAktar";
            this.btnHepsiniAktar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnHepsiniAktar.Size = new System.Drawing.Size(229, 52);
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
            this.btnSecilenAktar.HighEmphasis = true;
            this.btnSecilenAktar.Icon = null;
            this.btnSecilenAktar.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.btnSecilenAktar.Location = new System.Drawing.Point(4, 164);
            this.btnSecilenAktar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSecilenAktar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.btnSecilenAktar.Name = "btnSecilenAktar";
            this.btnSecilenAktar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSecilenAktar.Size = new System.Drawing.Size(229, 52);
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
            // frmOdemeEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.panelOrta);
            this.Controls.Add(this.panelSag);
            this.Controls.Add(this.panelSol);
            this.Controls.Add(this.panelUst);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmOdemeEkrani";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ÖDEME EKRANI";
            this.Load += new System.EventHandler(this.frmOdemeEkrani_Load);
            this.panelUst.ResumeLayout(false);
            this.panelUst.PerformLayout();
            this.panelSol.ResumeLayout(false);
            this.panelSolAlt.ResumeLayout(false);
            this.panelSolAlt.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelSag.ResumeLayout(false);
            this.panelSagAlt.ResumeLayout(false);
            this.panelSagAlt.PerformLayout();
            this.panelOrta.ResumeLayout(false);
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
        private ReaLTaiizor.Controls.MaterialLabel labelToplam;
        private ReaLTaiizor.Controls.MaterialLabel labelOdenecekTutar;
        private ReaLTaiizor.Controls.MaterialButton btnOde;
        private ReaLTaiizor.Controls.MaterialButton btnKart;
        private ReaLTaiizor.Controls.MaterialButton btnNakit;
        private ReaLTaiizor.Controls.MaterialLabel labelOdemeYontemi;
        private ReaLTaiizor.Controls.MaterialLabel labelToplamTutar;
        private ReaLTaiizor.Controls.MaterialLabel labelToplamOdenecek;
        private System.Windows.Forms.FlowLayoutPanel panelOdenecekler;
        private System.Windows.Forms.Panel panel1;
        private ReaLTaiizor.Controls.MaterialLabel labelHesapBilgi;
        private ReaLTaiizor.Controls.MaterialButton btnBitir;
        private System.Windows.Forms.Timer timer1;
    }
}