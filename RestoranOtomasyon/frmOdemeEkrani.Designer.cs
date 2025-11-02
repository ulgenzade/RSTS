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
            this.panelMasalar = new System.Windows.Forms.Panel();
            this.btnMasa3 = new System.Windows.Forms.Button();
            this.btnMasa2 = new System.Windows.Forms.Button();
            this.btnMasa1 = new System.Windows.Forms.Button();
            this.panelOzet = new System.Windows.Forms.Panel();
            this.lblToplamTutar = new System.Windows.Forms.Label();
            this.btnOde = new System.Windows.Forms.Button();
            this.btnVazgecOde = new System.Windows.Forms.Button();
            this.listOzet = new System.Windows.Forms.ListBox();
            this.panelUrunler = new System.Windows.Forms.Panel();
            this.btnSecimiOnayla = new System.Windows.Forms.Button();
            this.btnVazgec = new System.Windows.Forms.Button();
            this.btnSec = new System.Windows.Forms.Button();
            this.btnHepsiniSec = new System.Windows.Forms.Button();
            this.flowUrunler = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlOdemeSecenekleri = new System.Windows.Forms.Panel();
            this.btnOdemeIptal = new System.Windows.Forms.Button();
            this.btnKartOde = new System.Windows.Forms.Button();
            this.btnNakitOde = new System.Windows.Forms.Button();
            this.lblOdemeTutari = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnAnaMenu = new System.Windows.Forms.Button();
            this.btnCikisYap = new System.Windows.Forms.Button();
            this.btnHesapBilgisi = new System.Windows.Forms.Button();
            this.panelMasalar.SuspendLayout();
            this.panelOzet.SuspendLayout();
            this.panelUrunler.SuspendLayout();
            this.flowUrunler.SuspendLayout();
            this.pnlOdemeSecenekleri.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMasalar
            // 
            this.panelMasalar.Controls.Add(this.btnMasa3);
            this.panelMasalar.Controls.Add(this.btnMasa2);
            this.panelMasalar.Controls.Add(this.btnMasa1);
            this.panelMasalar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMasalar.Location = new System.Drawing.Point(0, 0);
            this.panelMasalar.Name = "panelMasalar";
            this.panelMasalar.Size = new System.Drawing.Size(200, 579);
            this.panelMasalar.TabIndex = 0;
            this.panelMasalar.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMasalar_Paint);
            // 
            // btnMasa3
            // 
            this.btnMasa3.Location = new System.Drawing.Point(27, 351);
            this.btnMasa3.Name = "btnMasa3";
            this.btnMasa3.Size = new System.Drawing.Size(143, 117);
            this.btnMasa3.TabIndex = 2;
            this.btnMasa3.Text = "MASA- 3";
            this.btnMasa3.UseVisualStyleBackColor = true;
            // 
            // btnMasa2
            // 
            this.btnMasa2.Location = new System.Drawing.Point(27, 232);
            this.btnMasa2.Name = "btnMasa2";
            this.btnMasa2.Size = new System.Drawing.Size(143, 113);
            this.btnMasa2.TabIndex = 1;
            this.btnMasa2.Text = "MASA-2";
            this.btnMasa2.UseVisualStyleBackColor = true;
            // 
            // btnMasa1
            // 
            this.btnMasa1.Location = new System.Drawing.Point(27, 116);
            this.btnMasa1.Name = "btnMasa1";
            this.btnMasa1.Size = new System.Drawing.Size(143, 110);
            this.btnMasa1.TabIndex = 0;
            this.btnMasa1.Text = "MASA-1";
            this.btnMasa1.UseVisualStyleBackColor = true;
            this.btnMasa1.Click += new System.EventHandler(this.btnMasa1_Click);
            // 
            // panelOzet
            // 
            this.panelOzet.Controls.Add(this.lblToplamTutar);
            this.panelOzet.Controls.Add(this.btnOde);
            this.panelOzet.Controls.Add(this.btnVazgecOde);
            this.panelOzet.Controls.Add(this.listOzet);
            this.panelOzet.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelOzet.Location = new System.Drawing.Point(880, 0);
            this.panelOzet.Name = "panelOzet";
            this.panelOzet.Size = new System.Drawing.Size(200, 579);
            this.panelOzet.TabIndex = 1;
            // 
            // lblToplamTutar
            // 
            this.lblToplamTutar.AutoSize = true;
            this.lblToplamTutar.Location = new System.Drawing.Point(51, 436);
            this.lblToplamTutar.Name = "lblToplamTutar";
            this.lblToplamTutar.Size = new System.Drawing.Size(99, 16);
            this.lblToplamTutar.TabIndex = 3;
            this.lblToplamTutar.Text = "lblToplamTutar";
            // 
            // btnOde
            // 
            this.btnOde.Location = new System.Drawing.Point(122, 511);
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
            this.btnVazgecOde.Location = new System.Drawing.Point(6, 511);
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
            this.listOzet.Location = new System.Drawing.Point(6, 68);
            this.listOzet.Name = "listOzet";
            this.listOzet.Size = new System.Drawing.Size(191, 436);
            this.listOzet.TabIndex = 0;
            // 
            // panelUrunler
            // 
            this.panelUrunler.Controls.Add(this.btnSecimiOnayla);
            this.panelUrunler.Controls.Add(this.btnVazgec);
            this.panelUrunler.Controls.Add(this.btnSec);
            this.panelUrunler.Controls.Add(this.btnHepsiniSec);
            this.panelUrunler.Controls.Add(this.flowUrunler);
            this.panelUrunler.Location = new System.Drawing.Point(206, 66);
            this.panelUrunler.Name = "panelUrunler";
            this.panelUrunler.Size = new System.Drawing.Size(668, 501);
            this.panelUrunler.TabIndex = 2;
            this.panelUrunler.Paint += new System.Windows.Forms.PaintEventHandler(this.panelUrunler_Paint);
            // 
            // btnSecimiOnayla
            // 
            this.btnSecimiOnayla.Location = new System.Drawing.Point(511, 445);
            this.btnSecimiOnayla.Name = "btnSecimiOnayla";
            this.btnSecimiOnayla.Size = new System.Drawing.Size(133, 23);
            this.btnSecimiOnayla.TabIndex = 3;
            this.btnSecimiOnayla.Text = "SEÇİMİ ONAYLA";
            this.btnSecimiOnayla.UseVisualStyleBackColor = true;
            // 
            // btnVazgec
            // 
            this.btnVazgec.Location = new System.Drawing.Point(430, 445);
            this.btnVazgec.Name = "btnVazgec";
            this.btnVazgec.Size = new System.Drawing.Size(75, 23);
            this.btnVazgec.TabIndex = 2;
            this.btnVazgec.Text = "VAZGEÇ";
            this.btnVazgec.UseVisualStyleBackColor = true;
            // 
            // btnSec
            // 
            this.btnSec.Location = new System.Drawing.Point(349, 445);
            this.btnSec.Name = "btnSec";
            this.btnSec.Size = new System.Drawing.Size(75, 23);
            this.btnSec.TabIndex = 1;
            this.btnSec.Text = "SEÇ";
            this.btnSec.UseVisualStyleBackColor = true;
            // 
            // btnHepsiniSec
            // 
            this.btnHepsiniSec.Location = new System.Drawing.Point(228, 445);
            this.btnHepsiniSec.Name = "btnHepsiniSec";
            this.btnHepsiniSec.Size = new System.Drawing.Size(115, 23);
            this.btnHepsiniSec.TabIndex = 0;
            this.btnHepsiniSec.Text = "HEPSİNİ SEÇ";
            this.btnHepsiniSec.UseVisualStyleBackColor = true;
            // 
            // flowUrunler
            // 
            this.flowUrunler.Controls.Add(this.pnlOdemeSecenekleri);
            this.flowUrunler.Controls.Add(this.flowLayoutPanel1);
            this.flowUrunler.Location = new System.Drawing.Point(23, 15);
            this.flowUrunler.Name = "flowUrunler";
            this.flowUrunler.Size = new System.Drawing.Size(621, 423);
            this.flowUrunler.TabIndex = 0;
            // 
            // pnlOdemeSecenekleri
            // 
            this.pnlOdemeSecenekleri.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlOdemeSecenekleri.Controls.Add(this.btnOdemeIptal);
            this.pnlOdemeSecenekleri.Controls.Add(this.btnKartOde);
            this.pnlOdemeSecenekleri.Controls.Add(this.btnNakitOde);
            this.pnlOdemeSecenekleri.Controls.Add(this.lblOdemeTutari);
            this.pnlOdemeSecenekleri.Location = new System.Drawing.Point(3, 3);
            this.pnlOdemeSecenekleri.Name = "pnlOdemeSecenekleri";
            this.pnlOdemeSecenekleri.Size = new System.Drawing.Size(618, 420);
            this.pnlOdemeSecenekleri.TabIndex = 0;
            this.pnlOdemeSecenekleri.Visible = false;
            this.pnlOdemeSecenekleri.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlOdemeSecenekleri_Paint);
            // 
            // btnOdemeIptal
            // 
            this.btnOdemeIptal.Location = new System.Drawing.Point(112, 173);
            this.btnOdemeIptal.Name = "btnOdemeIptal";
            this.btnOdemeIptal.Size = new System.Drawing.Size(104, 23);
            this.btnOdemeIptal.TabIndex = 3;
            this.btnOdemeIptal.Text = "btnOdemeIptal";
            this.btnOdemeIptal.UseVisualStyleBackColor = true;
            // 
            // btnKartOde
            // 
            this.btnKartOde.Location = new System.Drawing.Point(112, 117);
            this.btnKartOde.Name = "btnKartOde";
            this.btnKartOde.Size = new System.Drawing.Size(97, 23);
            this.btnKartOde.TabIndex = 2;
            this.btnKartOde.Text = "btnKartOde";
            this.btnKartOde.UseVisualStyleBackColor = true;
            // 
            // btnNakitOde
            // 
            this.btnNakitOde.Location = new System.Drawing.Point(112, 67);
            this.btnNakitOde.Name = "btnNakitOde";
            this.btnNakitOde.Size = new System.Drawing.Size(97, 23);
            this.btnNakitOde.TabIndex = 1;
            this.btnNakitOde.Text = "btnNakitOde";
            this.btnNakitOde.UseVisualStyleBackColor = true;
            // 
            // lblOdemeTutari
            // 
            this.lblOdemeTutari.AutoSize = true;
            this.lblOdemeTutari.Location = new System.Drawing.Point(116, 31);
            this.lblOdemeTutari.Name = "lblOdemeTutari";
            this.lblOdemeTutari.Size = new System.Drawing.Size(100, 16);
            this.lblOdemeTutari.TabIndex = 0;
            this.lblOdemeTutari.Text = "lblOdemeTutari";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 429);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(26, 12);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // panelMenu
            // 
            this.panelMenu.Controls.Add(this.btnAnaMenu);
            this.panelMenu.Controls.Add(this.btnCikisYap);
            this.panelMenu.Controls.Add(this.btnHesapBilgisi);
            this.panelMenu.Location = new System.Drawing.Point(200, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(680, 60);
            this.panelMenu.TabIndex = 0;
            // 
            // btnAnaMenu
            // 
            this.btnAnaMenu.Location = new System.Drawing.Point(517, 8);
            this.btnAnaMenu.Name = "btnAnaMenu";
            this.btnAnaMenu.Size = new System.Drawing.Size(157, 40);
            this.btnAnaMenu.TabIndex = 2;
            this.btnAnaMenu.Text = "Ana Menü";
            this.btnAnaMenu.UseVisualStyleBackColor = true;
            this.btnAnaMenu.Click += new System.EventHandler(this.btnAnaMenu_Click_1);
            // 
            // btnCikisYap
            // 
            this.btnCikisYap.Location = new System.Drawing.Point(418, 8);
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
            this.btnHesapBilgisi.Click += new System.EventHandler(this.btnHesapBilgisi_Click);
            // 
            // frmOdemeEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 579);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panelUrunler);
            this.Controls.Add(this.panelOzet);
            this.Controls.Add(this.panelMasalar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmOdemeEkrani";
            this.Text = "frmOdemeEkrani";
            this.Load += new System.EventHandler(this.frmOdemeEkrani_Load);
            this.panelMasalar.ResumeLayout(false);
            this.panelOzet.ResumeLayout(false);
            this.panelOzet.PerformLayout();
            this.panelUrunler.ResumeLayout(false);
            this.flowUrunler.ResumeLayout(false);
            this.pnlOdemeSecenekleri.ResumeLayout(false);
            this.pnlOdemeSecenekleri.PerformLayout();
            this.panelMenu.ResumeLayout(false);
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
        private System.Windows.Forms.Button btnMasa3;
        private System.Windows.Forms.Button btnMasa2;
        private System.Windows.Forms.Button btnMasa1;
        private System.Windows.Forms.Button btnOde;
        private System.Windows.Forms.Button btnVazgecOde;
        private System.Windows.Forms.ListBox listOzet;
        private System.Windows.Forms.Button btnHepsiniSec;
        private System.Windows.Forms.FlowLayoutPanel flowUrunler;
        private System.Windows.Forms.Button btnSec;
        private System.Windows.Forms.Button btnSecimiOnayla;
        private System.Windows.Forms.Button btnVazgec;
        private System.Windows.Forms.Panel pnlOdemeSecenekleri;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnOdemeIptal;
        private System.Windows.Forms.Button btnKartOde;
        private System.Windows.Forms.Button btnNakitOde;
        private System.Windows.Forms.Label lblOdemeTutari;
        private System.Windows.Forms.Label lblToplamTutar;
    }
}