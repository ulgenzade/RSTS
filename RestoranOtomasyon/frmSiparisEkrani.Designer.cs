namespace RestoranOtomasyon
{
    partial class frmSiparisEkrani
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
            this.flowMasalar = new System.Windows.Forms.FlowLayoutPanel();
            this.btnOrnekMasa = new System.Windows.Forms.Button();
            this.panelSiparis = new System.Windows.Forms.Panel();
            this.btnOdeme = new System.Windows.Forms.Button();
            this.lblGarsonAdi = new System.Windows.Forms.Label();
            this.btnOnayla = new System.Windows.Forms.Button();
            this.btnVazgec = new System.Windows.Forms.Button();
            this.panelSiparisListesi = new System.Windows.Forms.Panel();
            this.txtArama = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.flowMasalar.SuspendLayout();
            this.panelSiparis.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowMasalar
            // 
            this.flowMasalar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowMasalar.Controls.Add(this.btnOrnekMasa);
            this.flowMasalar.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowMasalar.Location = new System.Drawing.Point(0, 0);
            this.flowMasalar.Name = "flowMasalar";
            this.flowMasalar.Size = new System.Drawing.Size(200, 577);
            this.flowMasalar.TabIndex = 0;
            this.flowMasalar.Paint += new System.Windows.Forms.PaintEventHandler(this.flowMasalar_Paint);
            // 
            // btnOrnekMasa
            // 
            this.btnOrnekMasa.Location = new System.Drawing.Point(3, 3);
            this.btnOrnekMasa.Name = "btnOrnekMasa";
            this.btnOrnekMasa.Size = new System.Drawing.Size(196, 115);
            this.btnOrnekMasa.TabIndex = 0;
            this.btnOrnekMasa.Text = "MASA-1";
            this.btnOrnekMasa.UseVisualStyleBackColor = true;
            // 
            // panelSiparis
            // 
            this.panelSiparis.Controls.Add(this.btnOdeme);
            this.panelSiparis.Controls.Add(this.lblGarsonAdi);
            this.panelSiparis.Controls.Add(this.btnOnayla);
            this.panelSiparis.Controls.Add(this.btnVazgec);
            this.panelSiparis.Controls.Add(this.panelSiparisListesi);
            this.panelSiparis.Controls.Add(this.txtArama);
            this.panelSiparis.Controls.Add(this.label1);
            this.panelSiparis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSiparis.Location = new System.Drawing.Point(200, 0);
            this.panelSiparis.Name = "panelSiparis";
            this.panelSiparis.Size = new System.Drawing.Size(932, 577);
            this.panelSiparis.TabIndex = 1;
            this.panelSiparis.Visible = false;
            this.panelSiparis.Paint += new System.Windows.Forms.PaintEventHandler(this.panelSiparis_Paint);
            // 
            // btnOdeme
            // 
            this.btnOdeme.Location = new System.Drawing.Point(666, 517);
            this.btnOdeme.Name = "btnOdeme";
            this.btnOdeme.Size = new System.Drawing.Size(254, 23);
            this.btnOdeme.TabIndex = 6;
            this.btnOdeme.Text = "ÖDE";
            this.btnOdeme.UseVisualStyleBackColor = true;
            this.btnOdeme.Click += new System.EventHandler(this.btnOdeme_Click);
            // 
            // lblGarsonAdi
            // 
            this.lblGarsonAdi.AutoSize = true;
            this.lblGarsonAdi.Location = new System.Drawing.Point(663, 552);
            this.lblGarsonAdi.Name = "lblGarsonAdi";
            this.lblGarsonAdi.Size = new System.Drawing.Size(44, 16);
            this.lblGarsonAdi.TabIndex = 5;
            this.lblGarsonAdi.Text = "label2";
            this.lblGarsonAdi.Click += new System.EventHandler(this.lblGarsonAdi_Click);
            // 
            // btnOnayla
            // 
            this.btnOnayla.Location = new System.Drawing.Point(796, 488);
            this.btnOnayla.Name = "btnOnayla";
            this.btnOnayla.Size = new System.Drawing.Size(124, 23);
            this.btnOnayla.TabIndex = 4;
            this.btnOnayla.Text = "ONAYLA";
            this.btnOnayla.UseVisualStyleBackColor = true;
            // 
            // btnVazgec
            // 
            this.btnVazgec.Location = new System.Drawing.Point(666, 488);
            this.btnVazgec.Name = "btnVazgec";
            this.btnVazgec.Size = new System.Drawing.Size(124, 23);
            this.btnVazgec.TabIndex = 3;
            this.btnVazgec.Text = "VAZGEÇ";
            this.btnVazgec.UseVisualStyleBackColor = true;
            // 
            // panelSiparisListesi
            // 
            this.panelSiparisListesi.AutoScroll = true;
            this.panelSiparisListesi.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSiparisListesi.Location = new System.Drawing.Point(0, 22);
            this.panelSiparisListesi.Name = "panelSiparisListesi";
            this.panelSiparisListesi.Size = new System.Drawing.Size(932, 100);
            this.panelSiparisListesi.TabIndex = 2;
            // 
            // txtArama
            // 
            this.txtArama.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtArama.Location = new System.Drawing.Point(0, 0);
            this.txtArama.Name = "txtArama";
            this.txtArama.Size = new System.Drawing.Size(932, 22);
            this.txtArama.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(497, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "SİPARİŞLER";
            // 
            // frmSiparisEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 577);
            this.Controls.Add(this.panelSiparis);
            this.Controls.Add(this.flowMasalar);
            this.Name = "frmSiparisEkrani";
            this.Text = "frmSiparisEkrani";
            this.Load += new System.EventHandler(this.frmSiparisEkrani_Load);
            this.flowMasalar.ResumeLayout(false);
            this.panelSiparis.ResumeLayout(false);
            this.panelSiparis.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowMasalar;
        private System.Windows.Forms.Panel panelSiparis;
        private System.Windows.Forms.TextBox txtArama;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblGarsonAdi;
        private System.Windows.Forms.Button btnOnayla;
        private System.Windows.Forms.Button btnVazgec;
        private System.Windows.Forms.Panel panelSiparisListesi;
        private System.Windows.Forms.Button btnOdeme;
        private System.Windows.Forms.Button btnOrnekMasa;
    }
}