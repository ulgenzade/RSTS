namespace RestoranOtomasyon
{
    partial class dbDuzenle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dbDuzenle));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dbIptal = new ReaLTaiizor.Controls.MaterialButton();
            this.dbKaydet = new ReaLTaiizor.Controls.MaterialButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.materialComboBox1 = new ReaLTaiizor.Controls.MaterialComboBox();
            this.dbUrunAdi = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            this.dbUrunFiyati = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dbIptal);
            this.panel1.Controls.Add(this.dbKaydet);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 411);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(409, 76);
            this.panel1.TabIndex = 0;
            // 
            // dbIptal
            // 
            this.dbIptal.AutoSize = false;
            this.dbIptal.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.dbIptal.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.dbIptal.Depth = 0;
            this.dbIptal.HighEmphasis = true;
            this.dbIptal.Icon = null;
            this.dbIptal.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.dbIptal.Location = new System.Drawing.Point(38, 20);
            this.dbIptal.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.dbIptal.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.dbIptal.Name = "dbIptal";
            this.dbIptal.NoAccentTextColor = System.Drawing.Color.Empty;
            this.dbIptal.Size = new System.Drawing.Size(120, 36);
            this.dbIptal.TabIndex = 1;
            this.dbIptal.Text = "İPTAL";
            this.dbIptal.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.dbIptal.UseAccentColor = false;
            this.dbIptal.UseVisualStyleBackColor = true;
            this.dbIptal.Click += new System.EventHandler(this.dbIptal_Click);
            // 
            // dbKaydet
            // 
            this.dbKaydet.AutoSize = false;
            this.dbKaydet.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.dbKaydet.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.dbKaydet.Depth = 0;
            this.dbKaydet.HighEmphasis = true;
            this.dbKaydet.Icon = null;
            this.dbKaydet.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.dbKaydet.Location = new System.Drawing.Point(250, 20);
            this.dbKaydet.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.dbKaydet.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.dbKaydet.Name = "dbKaydet";
            this.dbKaydet.NoAccentTextColor = System.Drawing.Color.Empty;
            this.dbKaydet.Size = new System.Drawing.Size(120, 36);
            this.dbKaydet.TabIndex = 0;
            this.dbKaydet.Text = "KAYDET";
            this.dbKaydet.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.dbKaydet.UseAccentColor = false;
            this.dbKaydet.UseVisualStyleBackColor = true;
            this.dbKaydet.Click += new System.EventHandler(this.dbKaydet_Click_1);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.materialComboBox1);
            this.panel2.Controls.Add(this.dbUrunAdi);
            this.panel2.Controls.Add(this.dbUrunFiyati);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(409, 411);
            this.panel2.TabIndex = 1;
            // 
            // materialComboBox1
            // 
            this.materialComboBox1.AutoResize = false;
            this.materialComboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialComboBox1.Depth = 0;
            this.materialComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.materialComboBox1.DropDownHeight = 174;
            this.materialComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.materialComboBox1.DropDownWidth = 121;
            this.materialComboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialComboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialComboBox1.FormattingEnabled = true;
            this.materialComboBox1.Hint = "KATEGORİ";
            this.materialComboBox1.IntegralHeight = false;
            this.materialComboBox1.ItemHeight = 43;
            this.materialComboBox1.Location = new System.Drawing.Point(82, 101);
            this.materialComboBox1.MaxDropDownItems = 4;
            this.materialComboBox1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.materialComboBox1.Name = "materialComboBox1";
            this.materialComboBox1.Size = new System.Drawing.Size(250, 49);
            this.materialComboBox1.StartIndex = 0;
            this.materialComboBox1.TabIndex = 2;
            // 
            // dbUrunAdi
            // 
            this.dbUrunAdi.AllowPromptAsInput = true;
            this.dbUrunAdi.AnimateReadOnly = false;
            this.dbUrunAdi.AsciiOnly = false;
            this.dbUrunAdi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.dbUrunAdi.BeepOnError = false;
            this.dbUrunAdi.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.dbUrunAdi.Depth = 0;
            this.dbUrunAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dbUrunAdi.HidePromptOnLeave = false;
            this.dbUrunAdi.HideSelection = true;
            this.dbUrunAdi.Hint = "ÜRÜN ADI";
            this.dbUrunAdi.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.dbUrunAdi.LeadingIcon = null;
            this.dbUrunAdi.Location = new System.Drawing.Point(82, 184);
            this.dbUrunAdi.Mask = "";
            this.dbUrunAdi.MaxLength = 32767;
            this.dbUrunAdi.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.dbUrunAdi.Name = "dbUrunAdi";
            this.dbUrunAdi.PasswordChar = '\0';
            this.dbUrunAdi.PrefixSuffixText = null;
            this.dbUrunAdi.PromptChar = '_';
            this.dbUrunAdi.ReadOnly = false;
            this.dbUrunAdi.RejectInputOnFirstFailure = false;
            this.dbUrunAdi.ResetOnPrompt = true;
            this.dbUrunAdi.ResetOnSpace = true;
            this.dbUrunAdi.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dbUrunAdi.SelectedText = "";
            this.dbUrunAdi.SelectionLength = 0;
            this.dbUrunAdi.SelectionStart = 0;
            this.dbUrunAdi.ShortcutsEnabled = true;
            this.dbUrunAdi.Size = new System.Drawing.Size(250, 48);
            this.dbUrunAdi.SkipLiterals = true;
            this.dbUrunAdi.TabIndex = 1;
            this.dbUrunAdi.TabStop = false;
            this.dbUrunAdi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.dbUrunAdi.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.dbUrunAdi.TrailingIcon = null;
            this.dbUrunAdi.UseSystemPasswordChar = false;
            this.dbUrunAdi.ValidatingType = null;
            // 
            // dbUrunFiyati
            // 
            this.dbUrunFiyati.AllowPromptAsInput = true;
            this.dbUrunFiyati.AnimateReadOnly = false;
            this.dbUrunFiyati.AsciiOnly = false;
            this.dbUrunFiyati.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.dbUrunFiyati.BeepOnError = false;
            this.dbUrunFiyati.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.dbUrunFiyati.Depth = 0;
            this.dbUrunFiyati.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dbUrunFiyati.HidePromptOnLeave = false;
            this.dbUrunFiyati.HideSelection = true;
            this.dbUrunFiyati.Hint = "ÜRÜN FİYATI";
            this.dbUrunFiyati.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.dbUrunFiyati.LeadingIcon = null;
            this.dbUrunFiyati.Location = new System.Drawing.Point(82, 264);
            this.dbUrunFiyati.Mask = "";
            this.dbUrunFiyati.MaxLength = 32767;
            this.dbUrunFiyati.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.dbUrunFiyati.Name = "dbUrunFiyati";
            this.dbUrunFiyati.PasswordChar = '\0';
            this.dbUrunFiyati.PrefixSuffixText = null;
            this.dbUrunFiyati.PromptChar = '_';
            this.dbUrunFiyati.ReadOnly = false;
            this.dbUrunFiyati.RejectInputOnFirstFailure = false;
            this.dbUrunFiyati.ResetOnPrompt = true;
            this.dbUrunFiyati.ResetOnSpace = true;
            this.dbUrunFiyati.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dbUrunFiyati.SelectedText = "";
            this.dbUrunFiyati.SelectionLength = 0;
            this.dbUrunFiyati.SelectionStart = 0;
            this.dbUrunFiyati.ShortcutsEnabled = true;
            this.dbUrunFiyati.Size = new System.Drawing.Size(250, 48);
            this.dbUrunFiyati.SkipLiterals = true;
            this.dbUrunFiyati.TabIndex = 0;
            this.dbUrunFiyati.TabStop = false;
            this.dbUrunFiyati.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.dbUrunFiyati.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.dbUrunFiyati.TrailingIcon = null;
            this.dbUrunFiyati.UseSystemPasswordChar = false;
            this.dbUrunFiyati.ValidatingType = null;
            // 
            // dbDuzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 487);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "dbDuzenle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VERİ BİLGİLERİ";
            this.Load += new System.EventHandler(this.dbDuzenle_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private ReaLTaiizor.Controls.MaterialButton dbKaydet;
        private System.Windows.Forms.Panel panel2;
        private ReaLTaiizor.Controls.MaterialButton dbIptal;
        private ReaLTaiizor.Controls.MaterialComboBox materialComboBox1;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox dbUrunAdi;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox dbUrunFiyati;
    }
}