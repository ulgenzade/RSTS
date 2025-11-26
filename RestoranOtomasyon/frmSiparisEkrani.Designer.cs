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
            this.btnOnayla = new ReaLTaiizor.Controls.MaterialButton();
            this.btnGeriDon = new ReaLTaiizor.Controls.MaterialButton();
            this.btnVazgec = new ReaLTaiizor.Controls.MaterialButton();
            this.materialLabel1 = new ReaLTaiizor.Controls.MaterialLabel();
            this.btnOdeme = new ReaLTaiizor.Controls.MaterialButton();
            this.txtArama = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            ((System.ComponentModel.ISupportInitialize)(this.dgMevcutUrunler)).BeginInit();
            this.SuspendLayout();
            // 
            // flowMasalar
            // 
            this.flowMasalar.Location = new System.Drawing.Point(13, 13);
            this.flowMasalar.Name = "flowMasalar";
            this.flowMasalar.Size = new System.Drawing.Size(609, 423);
            this.flowMasalar.TabIndex = 0;
            // 
            // dgMevcutUrunler
            // 
            this.dgMevcutUrunler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMevcutUrunler.Location = new System.Drawing.Point(13, 442);
            this.dgMevcutUrunler.Name = "dgMevcutUrunler";
            this.dgMevcutUrunler.RowHeadersWidth = 51;
            this.dgMevcutUrunler.RowTemplate.Height = 24;
            this.dgMevcutUrunler.Size = new System.Drawing.Size(609, 219);
            this.dgMevcutUrunler.TabIndex = 1;
            // 
            // flowKategoriler
            // 
            this.flowKategoriler.Location = new System.Drawing.Point(664, 90);
            this.flowKategoriler.Name = "flowKategoriler";
            this.flowKategoriler.Size = new System.Drawing.Size(672, 141);
            this.flowKategoriler.TabIndex = 2;
            // 
            // flowUrunler
            // 
            this.flowUrunler.Location = new System.Drawing.Point(664, 261);
            this.flowUrunler.Name = "flowUrunler";
            this.flowUrunler.Size = new System.Drawing.Size(672, 311);
            this.flowUrunler.TabIndex = 3;
            // 
            // btnOnayla
            // 
            this.btnOnayla.AutoSize = false;
            this.btnOnayla.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnOnayla.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnOnayla.Depth = 0;
            this.btnOnayla.HighEmphasis = true;
            this.btnOnayla.Icon = null;
            this.btnOnayla.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.btnOnayla.Location = new System.Drawing.Point(800, 581);
            this.btnOnayla.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnOnayla.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.btnOnayla.Name = "btnOnayla";
            this.btnOnayla.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnOnayla.Size = new System.Drawing.Size(87, 36);
            this.btnOnayla.TabIndex = 4;
            this.btnOnayla.Text = "ONAYLA";
            this.btnOnayla.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnOnayla.UseAccentColor = false;
            this.btnOnayla.UseVisualStyleBackColor = true;
            this.btnOnayla.Click += new System.EventHandler(this.btnOnayla_Click);
            // 
            // btnGeriDon
            // 
            this.btnGeriDon.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGeriDon.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnGeriDon.Depth = 0;
            this.btnGeriDon.HighEmphasis = true;
            this.btnGeriDon.Icon = null;
            this.btnGeriDon.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.btnGeriDon.Location = new System.Drawing.Point(664, 625);
            this.btnGeriDon.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnGeriDon.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.btnGeriDon.Name = "btnGeriDon";
            this.btnGeriDon.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnGeriDon.Size = new System.Drawing.Size(87, 36);
            this.btnGeriDon.TabIndex = 5;
            this.btnGeriDon.Text = "GERİ DÖN";
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
            this.btnVazgec.HighEmphasis = true;
            this.btnVazgec.Icon = null;
            this.btnVazgec.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.btnVazgec.Location = new System.Drawing.Point(664, 581);
            this.btnVazgec.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnVazgec.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.btnVazgec.Name = "btnVazgec";
            this.btnVazgec.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnVazgec.Size = new System.Drawing.Size(87, 36);
            this.btnVazgec.TabIndex = 6;
            this.btnVazgec.Text = "VAZGEÇ";
            this.btnVazgec.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnVazgec.UseAccentColor = false;
            this.btnVazgec.UseVisualStyleBackColor = true;
            this.btnVazgec.Click += new System.EventHandler(this.btnVazgec_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(897, 642);
            this.materialLabel1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(107, 19);
            this.materialLabel1.TabIndex = 7;
            this.materialLabel1.Text = "materialLabel1";
            // 
            // btnOdeme
            // 
            this.btnOdeme.AutoSize = false;
            this.btnOdeme.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnOdeme.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnOdeme.Depth = 0;
            this.btnOdeme.HighEmphasis = true;
            this.btnOdeme.Icon = null;
            this.btnOdeme.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.btnOdeme.Location = new System.Drawing.Point(1249, 622);
            this.btnOdeme.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnOdeme.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.btnOdeme.Name = "btnOdeme";
            this.btnOdeme.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnOdeme.Size = new System.Drawing.Size(87, 36);
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
            this.txtArama.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtArama.HideSelection = true;
            this.txtArama.Hint = "ÜRÜN ARA";
            this.txtArama.LeadingIcon = null;
            this.txtArama.Location = new System.Drawing.Point(664, 12);
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
            this.txtArama.Size = new System.Drawing.Size(672, 48);
            this.txtArama.TabIndex = 9;
            this.txtArama.TabStop = false;
            this.txtArama.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtArama.TrailingIcon = null;
            this.txtArama.UseSystemPasswordChar = false;
            // 
            // frmSiparisEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1362, 673);
            this.Controls.Add(this.txtArama);
            this.Controls.Add(this.btnOdeme);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.btnVazgec);
            this.Controls.Add(this.btnGeriDon);
            this.Controls.Add(this.btnOnayla);
            this.Controls.Add(this.flowUrunler);
            this.Controls.Add(this.flowKategoriler);
            this.Controls.Add(this.dgMevcutUrunler);
            this.Controls.Add(this.flowMasalar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmSiparisEkrani";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSiparisEkrani";
            this.Load += new System.EventHandler(this.frmSiparisEkrani_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgMevcutUrunler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}