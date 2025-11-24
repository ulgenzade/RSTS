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
        //asd
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelMasalar = new System.Windows.Forms.Panel();
            this.panelOzet = new System.Windows.Forms.Panel();
            this.lblToplamTutar = new System.Windows.Forms.Label();
            this.btnOde = new System.Windows.Forms.Button();
            this.btnVazgecOde = new System.Windows.Forms.Button();
            this.listOzet = new System.Windows.Forms.ListBox();
            this.panelUrunler = new System.Windows.Forms.Panel();
            this.lvMasaSiparisleri = new ReaLTaiizor.Controls.MaterialListView();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnAnaMenu = new System.Windows.Forms.Button();
            this.btnCikisYap = new System.Windows.Forms.Button();
            this.btnHesapBilgisi = new System.Windows.Forms.Button();
            this.btnSolaAktar = new ReaLTaiizor.Controls.MaterialButton();
            this.btnSagaAktar = new ReaLTaiizor.Controls.MaterialButton();
            this.btnHepsiniEkle = new ReaLTaiizor.Controls.MaterialButton();
            this.btnHepsiniCikar = new ReaLTaiizor.Controls.MaterialButton();
            this.PanelAktarma = new System.Windows.Forms.Panel();
            this.panelOzet.SuspendLayout();
            this.panelUrunler.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.PanelAktarma.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMasalar
            // 
            this.panelMasalar.Location = new System.Drawing.Point(0, 78);
            this.panelMasalar.Name = "panelMasalar";
            this.panelMasalar.Size = new System.Drawing.Size(341, 554);
            this.panelMasalar.TabIndex = 0;
            // 
            // panelOzet
            // 
            this.panelOzet.Controls.Add(this.lblToplamTutar);
            this.panelOzet.Controls.Add(this.btnOde);
            this.panelOzet.Controls.Add(this.btnVazgecOde);
            this.panelOzet.Controls.Add(this.listOzet);
            this.panelOzet.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelOzet.Location = new System.Drawing.Point(1011, 0);
            this.panelOzet.Name = "panelOzet";
            this.panelOzet.Size = new System.Drawing.Size(321, 673);
            this.panelOzet.TabIndex = 1;
            // 
            // lblToplamTutar
            // 
            this.lblToplamTutar.AutoSize = true;
            this.lblToplamTutar.Location = new System.Drawing.Point(111, 597);
            this.lblToplamTutar.Name = "lblToplamTutar";
            this.lblToplamTutar.Size = new System.Drawing.Size(99, 16);
            this.lblToplamTutar.TabIndex = 3;
            this.lblToplamTutar.Text = "lblToplamTutar";
            // 
            // btnOde
            // 
            this.btnOde.Location = new System.Drawing.Point(234, 638);
            this.btnOde.Name = "btnOde";
            this.btnOde.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnOde.Size = new System.Drawing.Size(75, 23);
            this.btnOde.TabIndex = 2;
            this.btnOde.Text = "ÖDE";
            this.btnOde.UseVisualStyleBackColor = true;
            this.btnOde.Click += new System.EventHandler(this.btnOde_Click);
            // 
            // btnVazgecOde
            // 
            this.btnVazgecOde.Location = new System.Drawing.Point(6, 638);
            this.btnVazgecOde.Name = "btnVazgecOde";
            this.btnVazgecOde.Size = new System.Drawing.Size(75, 23);
            this.btnVazgecOde.TabIndex = 1;
            this.btnVazgecOde.Text = "VAZGEÇ";
            this.btnVazgecOde.UseVisualStyleBackColor = true;
            this.btnVazgecOde.Click += new System.EventHandler(this.btnVazgecOde_Click);
            // 
            // listOzet
            // 
            this.listOzet.FormattingEnabled = true;
            this.listOzet.ItemHeight = 16;
            this.listOzet.Location = new System.Drawing.Point(6, 84);
            this.listOzet.Name = "listOzet";
            this.listOzet.Size = new System.Drawing.Size(303, 548);
            this.listOzet.TabIndex = 0;
            // 
            // panelUrunler
            // 
            this.panelUrunler.Controls.Add(this.lvMasaSiparisleri);
            this.panelUrunler.Location = new System.Drawing.Point(347, 78);
            this.panelUrunler.Name = "panelUrunler";
            this.panelUrunler.Size = new System.Drawing.Size(495, 554);
            this.panelUrunler.TabIndex = 2;
            // 
            // lvMasaSiparisleri
            // 
            this.lvMasaSiparisleri.AutoSizeTable = false;
            this.lvMasaSiparisleri.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lvMasaSiparisleri.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvMasaSiparisleri.Depth = 0;
            this.lvMasaSiparisleri.FullRowSelect = true;
            this.lvMasaSiparisleri.HideSelection = false;
            this.lvMasaSiparisleri.Location = new System.Drawing.Point(4, 6);
            this.lvMasaSiparisleri.MinimumSize = new System.Drawing.Size(200, 100);
            this.lvMasaSiparisleri.MouseLocation = new System.Drawing.Point(-1, -1);
            this.lvMasaSiparisleri.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.lvMasaSiparisleri.Name = "lvMasaSiparisleri";
            this.lvMasaSiparisleri.OwnerDraw = true;
            this.lvMasaSiparisleri.Size = new System.Drawing.Size(488, 545);
            this.lvMasaSiparisleri.TabIndex = 4;
            this.lvMasaSiparisleri.UseCompatibleStateImageBehavior = false;
            this.lvMasaSiparisleri.View = System.Windows.Forms.View.Details;
            // 
            // panelMenu
            // 
            this.panelMenu.Controls.Add(this.btnAnaMenu);
            this.panelMenu.Controls.Add(this.btnCikisYap);
            this.panelMenu.Controls.Add(this.btnHesapBilgisi);
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(1007, 60);
            this.panelMenu.TabIndex = 0;
            // 
            // btnAnaMenu
            // 
            this.btnAnaMenu.Location = new System.Drawing.Point(847, 12);
            this.btnAnaMenu.Name = "btnAnaMenu";
            this.btnAnaMenu.Size = new System.Drawing.Size(157, 40);
            this.btnAnaMenu.TabIndex = 2;
            this.btnAnaMenu.Text = "Ana Menü";
            this.btnAnaMenu.UseVisualStyleBackColor = true;
            // 
            // btnCikisYap
            // 
            this.btnCikisYap.Location = new System.Drawing.Point(749, 12);
            this.btnCikisYap.Name = "btnCikisYap";
            this.btnCikisYap.Size = new System.Drawing.Size(93, 40);
            this.btnCikisYap.TabIndex = 1;
            this.btnCikisYap.Text = "Çıkış Yap";
            this.btnCikisYap.UseVisualStyleBackColor = true;
            // 
            // btnHesapBilgisi
            // 
            this.btnHesapBilgisi.Location = new System.Drawing.Point(6, 8);
            this.btnHesapBilgisi.Name = "btnHesapBilgisi";
            this.btnHesapBilgisi.Size = new System.Drawing.Size(180, 40);
            this.btnHesapBilgisi.TabIndex = 0;
            this.btnHesapBilgisi.Text = "Hesap Bilgiler";
            this.btnHesapBilgisi.UseVisualStyleBackColor = true;
            // 
            // btnSolaAktar
            // 
            this.btnSolaAktar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSolaAktar.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSolaAktar.Depth = 0;
            this.btnSolaAktar.HighEmphasis = true;
            this.btnSolaAktar.Icon = null;
            this.btnSolaAktar.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.btnSolaAktar.Location = new System.Drawing.Point(47, 303);
            this.btnSolaAktar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSolaAktar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.btnSolaAktar.Name = "btnSolaAktar";
            this.btnSolaAktar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSolaAktar.Size = new System.Drawing.Size(64, 36);
            this.btnSolaAktar.TabIndex = 6;
            this.btnSolaAktar.Text = "ÇIKAR";
            this.btnSolaAktar.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSolaAktar.UseAccentColor = false;
            this.btnSolaAktar.UseVisualStyleBackColor = true;
            this.btnSolaAktar.Click += new System.EventHandler(this.btnSolaAktar_Click);
            // 
            // btnSagaAktar
            // 
            this.btnSagaAktar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSagaAktar.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSagaAktar.Depth = 0;
            this.btnSagaAktar.HighEmphasis = true;
            this.btnSagaAktar.Icon = null;
            this.btnSagaAktar.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.btnSagaAktar.Location = new System.Drawing.Point(47, 255);
            this.btnSagaAktar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSagaAktar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.btnSagaAktar.Name = "btnSagaAktar";
            this.btnSagaAktar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSagaAktar.Size = new System.Drawing.Size(64, 36);
            this.btnSagaAktar.TabIndex = 7;
            this.btnSagaAktar.Text = "EKLE";
            this.btnSagaAktar.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSagaAktar.UseAccentColor = false;
            this.btnSagaAktar.UseVisualStyleBackColor = true;
            this.btnSagaAktar.Click += new System.EventHandler(this.btnSagaAktar_Click);
            // 
            // btnHepsiniEkle
            // 
            this.btnHepsiniEkle.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnHepsiniEkle.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnHepsiniEkle.Depth = 0;
            this.btnHepsiniEkle.HighEmphasis = true;
            this.btnHepsiniEkle.Icon = null;
            this.btnHepsiniEkle.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.btnHepsiniEkle.Location = new System.Drawing.Point(19, 207);
            this.btnHepsiniEkle.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnHepsiniEkle.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.btnHepsiniEkle.Name = "btnHepsiniEkle";
            this.btnHepsiniEkle.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnHepsiniEkle.Size = new System.Drawing.Size(120, 36);
            this.btnHepsiniEkle.TabIndex = 8;
            this.btnHepsiniEkle.Text = "TÜMÜNÜ EKLE";
            this.btnHepsiniEkle.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnHepsiniEkle.UseAccentColor = false;
            this.btnHepsiniEkle.UseVisualStyleBackColor = true;
            this.btnHepsiniEkle.Click += new System.EventHandler(this.btnHepsiniEkle_Click);
            // 
            // btnHepsiniCikar
            // 
            this.btnHepsiniCikar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnHepsiniCikar.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnHepsiniCikar.Depth = 0;
            this.btnHepsiniCikar.HighEmphasis = true;
            this.btnHepsiniCikar.Icon = null;
            this.btnHepsiniCikar.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.btnHepsiniCikar.Location = new System.Drawing.Point(39, 351);
            this.btnHepsiniCikar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnHepsiniCikar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.btnHepsiniCikar.Name = "btnHepsiniCikar";
            this.btnHepsiniCikar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnHepsiniCikar.Size = new System.Drawing.Size(81, 36);
            this.btnHepsiniCikar.TabIndex = 9;
            this.btnHepsiniCikar.Text = "TEMİZLE";
            this.btnHepsiniCikar.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnHepsiniCikar.UseAccentColor = false;
            this.btnHepsiniCikar.UseVisualStyleBackColor = true;
            this.btnHepsiniCikar.Click += new System.EventHandler(this.btnHepsiniCikar_Click);
            // 
            // PanelAktarma
            // 
            this.PanelAktarma.Controls.Add(this.btnHepsiniEkle);
            this.PanelAktarma.Controls.Add(this.btnSolaAktar);
            this.PanelAktarma.Controls.Add(this.btnHepsiniCikar);
            this.PanelAktarma.Controls.Add(this.btnSagaAktar);
            this.PanelAktarma.Location = new System.Drawing.Point(848, 81);
            this.PanelAktarma.Name = "PanelAktarma";
            this.PanelAktarma.Size = new System.Drawing.Size(159, 551);
            this.PanelAktarma.TabIndex = 10;
            // 
            // frmOdemeEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1332, 673);
            this.Controls.Add(this.PanelAktarma);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panelUrunler);
            this.Controls.Add(this.panelOzet);
            this.Controls.Add(this.panelMasalar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmOdemeEkrani";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ÖDEME EKRANI";
            this.Load += new System.EventHandler(this.frmOdemeEkrani_Load);
            this.panelOzet.ResumeLayout(false);
            this.panelOzet.PerformLayout();
            this.panelUrunler.ResumeLayout(false);
            this.panelMenu.ResumeLayout(false);
            this.PanelAktarma.ResumeLayout(false);
            this.PanelAktarma.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMasalar;
        private System.Windows.Forms.Panel panelOzet;
        private System.Windows.Forms.Panel panelUrunler;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnAnaMenu;
        private System.Windows.Forms.Button btnCikisYap;
        private System.Windows.Forms.Button btnHesapBilgisi;
        private System.Windows.Forms.Button btnOde;
        private System.Windows.Forms.Button btnVazgecOde;
        private System.Windows.Forms.ListBox listOzet;
        private System.Windows.Forms.Label lblToplamTutar;
        private ReaLTaiizor.Controls.MaterialListView lvMasaSiparisleri;
        private ReaLTaiizor.Controls.MaterialButton btnSolaAktar;
        private ReaLTaiizor.Controls.MaterialButton btnSagaAktar;
        private ReaLTaiizor.Controls.MaterialButton btnHepsiniEkle;
        private ReaLTaiizor.Controls.MaterialButton btnHepsiniCikar;
        private System.Windows.Forms.Panel PanelAktarma;
    }
}