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
            this.dgMevcutUrunler = new System.Windows.Forms.DataGridView();
            this.flowKategoriler = new System.Windows.Forms.FlowLayoutPanel();
            this.flowUrunler = new System.Windows.Forms.FlowLayoutPanel();
            this.materialLabel1 = new ReaLTaiizor.Controls.MaterialLabel();
            this.btnOnayla = new ReaLTaiizor.Controls.MaterialButton();
            this.btnGeriDon = new ReaLTaiizor.Controls.MaterialButton();
            this.btnVazgec = new ReaLTaiizor.Controls.MaterialButton();
            this.btnOdeme = new ReaLTaiizor.Controls.MaterialButton();
            this.txtArama = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            this.btnRezerve = new ReaLTaiizor.Controls.MaterialButton();
            this.panelSol = new System.Windows.Forms.Panel();
            this.panelSag = new System.Windows.Forms.Panel();
            this.btnBorder = new System.Windows.Forms.Panel();
            this.btnTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.btnTasiBirlestir = new ReaLTaiizor.Controls.MaterialButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.dgMevcutUrunler)).BeginInit();
            this.panelSol.SuspendLayout();
            this.panelSag.SuspendLayout();
            this.btnBorder.SuspendLayout();
            this.btnTableLayoutPanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowMasalar
            // 
            this.flowMasalar.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowMasalar.Location = new System.Drawing.Point(0, 0);
            this.flowMasalar.Name = "flowMasalar";
            this.flowMasalar.Padding = new System.Windows.Forms.Padding(70, 3, 0, 3);
            this.flowMasalar.Size = new System.Drawing.Size(632, 423);
            this.flowMasalar.TabIndex = 0;
            // 
            // dgMevcutUrunler
            // 
            this.dgMevcutUrunler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMevcutUrunler.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgMevcutUrunler.Location = new System.Drawing.Point(0, 429);
            this.dgMevcutUrunler.Name = "dgMevcutUrunler";
            this.dgMevcutUrunler.RowHeadersWidth = 51;
            this.dgMevcutUrunler.RowTemplate.Height = 24;
            this.dgMevcutUrunler.Size = new System.Drawing.Size(632, 262);
            this.dgMevcutUrunler.TabIndex = 1;
            // 
            // flowKategoriler
            // 
            this.flowKategoriler.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowKategoriler.Location = new System.Drawing.Point(0, 48);
            this.flowKategoriler.Name = "flowKategoriler";
            this.flowKategoriler.Padding = new System.Windows.Forms.Padding(35, 3, 0, 3);
            this.flowKategoriler.Size = new System.Drawing.Size(633, 172);
            this.flowKategoriler.TabIndex = 2;
            // 
            // flowUrunler
            // 
            this.flowUrunler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowUrunler.Location = new System.Drawing.Point(0, 220);
            this.flowUrunler.Name = "flowUrunler";
            this.flowUrunler.Padding = new System.Windows.Forms.Padding(70, 3, 0, 3);
            this.flowUrunler.Size = new System.Drawing.Size(633, 351);
            this.flowUrunler.TabIndex = 3;
            // 
            // materialLabel1
            // 
            this.btnTableLayoutPanel.SetColumnSpan(this.materialLabel1, 6);
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(3, 61);
            this.materialLabel1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(621, 53);
            this.materialLabel1.TabIndex = 7;
            this.materialLabel1.Text = "HESAP BİLGİSİ";
            this.materialLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.materialLabel1.Click += new System.EventHandler(this.materialLabel1_Click);
            // 
            // btnOnayla
            // 
            this.btnOnayla.AutoSize = false;
            this.btnOnayla.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnOnayla.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnOnayla.Depth = 0;
            this.btnOnayla.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnOnayla.HighEmphasis = true;
            this.btnOnayla.Icon = null;
            this.btnOnayla.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.btnOnayla.Location = new System.Drawing.Point(4, 6);
            this.btnOnayla.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnOnayla.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.btnOnayla.Name = "btnOnayla";
            this.btnOnayla.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnOnayla.Size = new System.Drawing.Size(96, 49);
            this.btnOnayla.TabIndex = 4;
            this.btnOnayla.Text = "ONAYLA";
            this.btnOnayla.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnOnayla.UseAccentColor = false;
            this.btnOnayla.UseVisualStyleBackColor = true;
            this.btnOnayla.Click += new System.EventHandler(this.btnOnayla_Click);
            // 
            // btnGeriDon
            // 
            this.btnGeriDon.AutoSize = false;
            this.btnGeriDon.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGeriDon.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnGeriDon.Depth = 0;
            this.btnGeriDon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnGeriDon.HighEmphasis = true;
            this.btnGeriDon.Icon = null;
            this.btnGeriDon.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.btnGeriDon.Location = new System.Drawing.Point(524, 6);
            this.btnGeriDon.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnGeriDon.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.btnGeriDon.Name = "btnGeriDon";
            this.btnGeriDon.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnGeriDon.Size = new System.Drawing.Size(99, 49);
            this.btnGeriDon.TabIndex = 5;
            this.btnGeriDon.Text = "ÇIKIŞ YAP";
            this.btnGeriDon.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnGeriDon.UseAccentColor = false;
            this.btnGeriDon.UseVisualStyleBackColor = true;
            this.btnGeriDon.Click += new System.EventHandler(this.btnGeriDon_Click);
            // 
            // btnVazgec
            // 
            this.btnVazgec.AutoSize = false;
            this.btnVazgec.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnVazgec.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnVazgec.Depth = 0;
            this.btnVazgec.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnVazgec.HighEmphasis = true;
            this.btnVazgec.Icon = null;
            this.btnVazgec.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.btnVazgec.Location = new System.Drawing.Point(108, 6);
            this.btnVazgec.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnVazgec.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.btnVazgec.Name = "btnVazgec";
            this.btnVazgec.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnVazgec.Size = new System.Drawing.Size(96, 49);
            this.btnVazgec.TabIndex = 6;
            this.btnVazgec.Text = "VAZGEÇ";
            this.btnVazgec.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnVazgec.UseAccentColor = false;
            this.btnVazgec.UseVisualStyleBackColor = true;
            this.btnVazgec.Click += new System.EventHandler(this.btnVazgec_Click);
            // 
            // btnOdeme
            // 
            this.btnOdeme.AutoSize = false;
            this.btnOdeme.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnOdeme.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnOdeme.Depth = 0;
            this.btnOdeme.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnOdeme.HighEmphasis = true;
            this.btnOdeme.Icon = null;
            this.btnOdeme.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.btnOdeme.Location = new System.Drawing.Point(420, 6);
            this.btnOdeme.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnOdeme.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.btnOdeme.Name = "btnOdeme";
            this.btnOdeme.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnOdeme.Size = new System.Drawing.Size(96, 49);
            this.btnOdeme.TabIndex = 8;
            this.btnOdeme.Text = "ÖDE";
            this.btnOdeme.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnOdeme.UseAccentColor = false;
            this.btnOdeme.UseVisualStyleBackColor = true;
            this.btnOdeme.Click += new System.EventHandler(this.btnOdeme_Click);
            // 
            // txtArama
            // 
            this.txtArama.AnimateReadOnly = false;
            this.txtArama.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtArama.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtArama.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtArama.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtArama.Depth = 0;
            this.txtArama.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtArama.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtArama.HideSelection = true;
            this.txtArama.Hint = "ÜRÜN ARA";
            this.txtArama.LeadingIcon = null;
            this.txtArama.Location = new System.Drawing.Point(0, 0);
            this.txtArama.MaxLength = 32767;
            this.txtArama.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.txtArama.Name = "txtArama";
            this.txtArama.PasswordChar = '\0';
            this.txtArama.PrefixSuffixText = null;
            this.txtArama.ReadOnly = false;
            this.txtArama.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtArama.SelectedText = "";
            this.txtArama.SelectionLength = 0;
            this.txtArama.SelectionStart = 0;
            this.txtArama.ShortcutsEnabled = true;
            this.txtArama.Size = new System.Drawing.Size(633, 48);
            this.txtArama.TabIndex = 9;
            this.txtArama.TabStop = false;
            this.txtArama.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtArama.TrailingIcon = null;
            this.txtArama.UseSystemPasswordChar = false;
            this.txtArama.Click += new System.EventHandler(this.txtArama_Click);
            // 
            // btnRezerve
            // 
            this.btnRezerve.AutoSize = false;
            this.btnRezerve.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRezerve.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnRezerve.Depth = 0;
            this.btnRezerve.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRezerve.HighEmphasis = true;
            this.btnRezerve.Icon = null;
            this.btnRezerve.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.btnRezerve.Location = new System.Drawing.Point(212, 6);
            this.btnRezerve.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnRezerve.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.btnRezerve.Name = "btnRezerve";
            this.btnRezerve.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnRezerve.Size = new System.Drawing.Size(96, 49);
            this.btnRezerve.TabIndex = 10;
            this.btnRezerve.Text = "REZERVE";
            this.btnRezerve.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnRezerve.UseAccentColor = false;
            this.btnRezerve.UseVisualStyleBackColor = true;
            this.btnRezerve.Click += new System.EventHandler(this.btnRezerve_Click_1);
            // 
            // panelSol
            // 
            this.panelSol.Controls.Add(this.flowMasalar);
            this.panelSol.Controls.Add(this.dgMevcutUrunler);
            this.panelSol.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSol.Location = new System.Drawing.Point(3, 3);
            this.panelSol.Name = "panelSol";
            this.panelSol.Size = new System.Drawing.Size(632, 691);
            this.panelSol.TabIndex = 11;
            // 
            // panelSag
            // 
            this.panelSag.Controls.Add(this.flowUrunler);
            this.panelSag.Controls.Add(this.flowKategoriler);
            this.panelSag.Controls.Add(this.txtArama);
            this.panelSag.Controls.Add(this.btnBorder);
            this.panelSag.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSag.Location = new System.Drawing.Point(641, 3);
            this.panelSag.Name = "panelSag";
            this.panelSag.Size = new System.Drawing.Size(633, 691);
            this.panelSag.TabIndex = 12;
            // 
            // btnBorder
            // 
            this.btnBorder.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnBorder.Controls.Add(this.btnTableLayoutPanel);
            this.btnBorder.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnBorder.Location = new System.Drawing.Point(0, 571);
            this.btnBorder.Name = "btnBorder";
            this.btnBorder.Padding = new System.Windows.Forms.Padding(3);
            this.btnBorder.Size = new System.Drawing.Size(633, 120);
            this.btnBorder.TabIndex = 12;
            // 
            // btnTableLayoutPanel
            // 
            this.btnTableLayoutPanel.BackColor = System.Drawing.Color.White;
            this.btnTableLayoutPanel.ColumnCount = 6;
            this.btnTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.btnTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.btnTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.btnTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.btnTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.btnTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.btnTableLayoutPanel.Controls.Add(this.materialLabel1, 0, 1);
            this.btnTableLayoutPanel.Controls.Add(this.btnVazgec, 1, 0);
            this.btnTableLayoutPanel.Controls.Add(this.btnOnayla, 0, 0);
            this.btnTableLayoutPanel.Controls.Add(this.btnRezerve, 2, 0);
            this.btnTableLayoutPanel.Controls.Add(this.btnGeriDon, 5, 0);
            this.btnTableLayoutPanel.Controls.Add(this.btnOdeme, 4, 0);
            this.btnTableLayoutPanel.Controls.Add(this.btnTasiBirlestir, 3, 0);
            this.btnTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTableLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.btnTableLayoutPanel.Name = "btnTableLayoutPanel";
            this.btnTableLayoutPanel.RowCount = 2;
            this.btnTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 53.50877F));
            this.btnTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 46.49123F));
            this.btnTableLayoutPanel.Size = new System.Drawing.Size(627, 114);
            this.btnTableLayoutPanel.TabIndex = 0;
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
            this.btnTasiBirlestir.Location = new System.Drawing.Point(316, 6);
            this.btnTasiBirlestir.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnTasiBirlestir.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.btnTasiBirlestir.Name = "btnTasiBirlestir";
            this.btnTasiBirlestir.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnTasiBirlestir.Size = new System.Drawing.Size(96, 49);
            this.btnTasiBirlestir.TabIndex = 11;
            this.btnTasiBirlestir.Text = "TAŞI / BİRLEŞTİR";
            this.btnTasiBirlestir.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnTasiBirlestir.UseAccentColor = false;
            this.btnTasiBirlestir.UseVisualStyleBackColor = true;
            this.btnTasiBirlestir.Click += new System.EventHandler(this.btnTasiBirlestir_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panelSol, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panelSag, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1277, 697);
            this.tableLayoutPanel1.TabIndex = 13;
            // 
            // frmSiparisEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1277, 697);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmSiparisEkrani";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SİPARİŞ EKRANI";
            this.Load += new System.EventHandler(this.frmSiparisEkrani_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgMevcutUrunler)).EndInit();
            this.panelSol.ResumeLayout(false);
            this.panelSag.ResumeLayout(false);
            this.btnBorder.ResumeLayout(false);
            this.btnTableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowMasalar;
        private System.Windows.Forms.DataGridView dgMevcutUrunler;
        private System.Windows.Forms.FlowLayoutPanel flowKategoriler;
        private System.Windows.Forms.FlowLayoutPanel flowUrunler;
        private ReaLTaiizor.Controls.MaterialButton btnOnayla;
        private ReaLTaiizor.Controls.MaterialButton btnGeriDon;
        private ReaLTaiizor.Controls.MaterialButton btnVazgec;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel1;
        private ReaLTaiizor.Controls.MaterialButton btnOdeme;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtArama;
        private ReaLTaiizor.Controls.MaterialButton btnRezerve;
        private System.Windows.Forms.Panel panelSol;
        private System.Windows.Forms.Panel panelSag;
        private ReaLTaiizor.Controls.MaterialButton btnTasiBirlestir;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel btnBorder;
        private System.Windows.Forms.TableLayoutPanel btnTableLayoutPanel;
    }
}