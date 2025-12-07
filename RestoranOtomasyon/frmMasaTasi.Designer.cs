namespace RestoranOtomasyon
{
    partial class frmMasaTasi
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnİptal = new ReaLTaiizor.Controls.MaterialButton();
            this.btnTasiBirlestir = new ReaLTaiizor.Controls.MaterialButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTutar_Yeni = new ReaLTaiizor.Controls.MaterialLabel();
            this.lstSiparisler = new ReaLTaiizor.Controls.MaterialListBox();
            this.lblMasaBaslik_Yeni = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(474, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(322, 444);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnİptal);
            this.panel1.Controls.Add(this.btnTasiBirlestir);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(343, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(125, 444);
            this.panel1.TabIndex = 2;
            // 
            // btnİptal
            // 
            this.btnİptal.AutoSize = false;
            this.btnİptal.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnİptal.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnİptal.Depth = 0;
            this.btnİptal.HighEmphasis = true;
            this.btnİptal.Icon = null;
            this.btnİptal.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.btnİptal.Location = new System.Drawing.Point(1, 290);
            this.btnİptal.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnİptal.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.btnİptal.Name = "btnİptal";
            this.btnİptal.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnİptal.Size = new System.Drawing.Size(124, 51);
            this.btnİptal.TabIndex = 5;
            this.btnİptal.Text = "İPTAL";
            this.btnİptal.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnİptal.UseAccentColor = false;
            this.btnİptal.UseVisualStyleBackColor = true;
            this.btnİptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // btnTasiBirlestir
            // 
            this.btnTasiBirlestir.AutoSize = false;
            this.btnTasiBirlestir.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnTasiBirlestir.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnTasiBirlestir.Depth = 0;
            this.btnTasiBirlestir.HighEmphasis = true;
            this.btnTasiBirlestir.Icon = null;
            this.btnTasiBirlestir.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.btnTasiBirlestir.Location = new System.Drawing.Point(0, 173);
            this.btnTasiBirlestir.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnTasiBirlestir.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.btnTasiBirlestir.Name = "btnTasiBirlestir";
            this.btnTasiBirlestir.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnTasiBirlestir.Size = new System.Drawing.Size(124, 49);
            this.btnTasiBirlestir.TabIndex = 3;
            this.btnTasiBirlestir.Text = "TAŞI / BİRLEŞTİR  ";
            this.btnTasiBirlestir.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnTasiBirlestir.UseAccentColor = false;
            this.btnTasiBirlestir.UseVisualStyleBackColor = true;
            this.btnTasiBirlestir.Click += new System.EventHandler(this.btnTasiBirlestir_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 72.23529F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.76471F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 328F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 450F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblTutar_Yeni);
            this.panel2.Controls.Add(this.lstSiparisler);
            this.panel2.Controls.Add(this.lblMasaBaslik_Yeni);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(334, 444);
            this.panel2.TabIndex = 4;
            // 
            // lblTutar_Yeni
            // 
            this.lblTutar_Yeni.AutoSize = true;
            this.lblTutar_Yeni.Depth = 0;
            this.lblTutar_Yeni.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblTutar_Yeni.ForeColor = System.Drawing.Color.Gold;
            this.lblTutar_Yeni.Location = new System.Drawing.Point(103, 407);
            this.lblTutar_Yeni.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.lblTutar_Yeni.Name = "lblTutar_Yeni";
            this.lblTutar_Yeni.Size = new System.Drawing.Size(45, 19);
            this.lblTutar_Yeni.TabIndex = 7;
            this.lblTutar_Yeni.Text = "0.00 ₺";
            // 
            // lstSiparisler
            // 
            this.lstSiparisler.BackColor = System.Drawing.Color.White;
            this.lstSiparisler.BorderColor = System.Drawing.Color.LightGray;
            this.lstSiparisler.Depth = 0;
            this.lstSiparisler.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lstSiparisler.Location = new System.Drawing.Point(9, 130);
            this.lstSiparisler.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.lstSiparisler.Name = "lstSiparisler";
            this.lstSiparisler.SelectedIndex = -1;
            this.lstSiparisler.SelectedItem = null;
            this.lstSiparisler.Size = new System.Drawing.Size(314, 263);
            this.lstSiparisler.TabIndex = 6;
            // 
            // lblMasaBaslik_Yeni
            // 
            this.lblMasaBaslik_Yeni.AutoSize = true;
            this.lblMasaBaslik_Yeni.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMasaBaslik_Yeni.ForeColor = System.Drawing.Color.Black;
            this.lblMasaBaslik_Yeni.Location = new System.Drawing.Point(100, 20);
            this.lblMasaBaslik_Yeni.Name = "lblMasaBaslik_Yeni";
            this.lblMasaBaslik_Yeni.Size = new System.Drawing.Size(94, 32);
            this.lblMasaBaslik_Yeni.TabIndex = 5;
            this.lblMasaBaslik_Yeni.Text = "MASA";
            // 
            // frmMasaTasi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmMasaTasi";
            this.Text = "MASA TAŞI";
            this.Load += new System.EventHandler(this.frmMasaTasi_Load);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private ReaLTaiizor.Controls.MaterialButton btnİptal;
        private ReaLTaiizor.Controls.MaterialButton btnTasiBirlestir;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private ReaLTaiizor.Controls.MaterialLabel lblTutar_Yeni;
        private ReaLTaiizor.Controls.MaterialListBox lstSiparisler;
        private System.Windows.Forms.Label lblMasaBaslik_Yeni;
    }
}