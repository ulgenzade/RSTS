namespace RestoranOtomasyon
{
    partial class treeDuzenle
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.treeRoller = new ReaLTaiizor.Controls.MaterialComboBox();
            this.treeSifre = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            this.treeAdSoyad = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            this.treeKullaniciAdi = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.treeKaydet = new ReaLTaiizor.Controls.MaterialButton();
            this.treeIptal = new ReaLTaiizor.Controls.MaterialButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.treeRoller);
            this.panel1.Controls.Add(this.treeSifre);
            this.panel1.Controls.Add(this.treeAdSoyad);
            this.panel1.Controls.Add(this.treeKullaniciAdi);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(409, 487);
            this.panel1.TabIndex = 0;
            // 
            // treeRoller
            // 
            this.treeRoller.AutoResize = false;
            this.treeRoller.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.treeRoller.Depth = 0;
            this.treeRoller.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.treeRoller.DropDownHeight = 174;
            this.treeRoller.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.treeRoller.DropDownWidth = 121;
            this.treeRoller.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.treeRoller.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.treeRoller.FormattingEnabled = true;
            this.treeRoller.Hint = "ROLLER";
            this.treeRoller.IntegralHeight = false;
            this.treeRoller.ItemHeight = 43;
            this.treeRoller.Location = new System.Drawing.Point(79, 66);
            this.treeRoller.MaxDropDownItems = 4;
            this.treeRoller.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.treeRoller.Name = "treeRoller";
            this.treeRoller.Size = new System.Drawing.Size(250, 49);
            this.treeRoller.StartIndex = 0;
            this.treeRoller.TabIndex = 3;
            // 
            // treeSifre
            // 
            this.treeSifre.AllowPromptAsInput = true;
            this.treeSifre.AnimateReadOnly = false;
            this.treeSifre.AsciiOnly = false;
            this.treeSifre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.treeSifre.BeepOnError = false;
            this.treeSifre.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.treeSifre.Depth = 0;
            this.treeSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.treeSifre.HidePromptOnLeave = false;
            this.treeSifre.HideSelection = true;
            this.treeSifre.Hint = "ŞİFRE";
            this.treeSifre.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.treeSifre.LeadingIcon = null;
            this.treeSifre.Location = new System.Drawing.Point(79, 301);
            this.treeSifre.Mask = "";
            this.treeSifre.MaxLength = 32767;
            this.treeSifre.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.treeSifre.Name = "treeSifre";
            this.treeSifre.PasswordChar = '\0';
            this.treeSifre.PrefixSuffixText = null;
            this.treeSifre.PromptChar = '_';
            this.treeSifre.ReadOnly = false;
            this.treeSifre.RejectInputOnFirstFailure = false;
            this.treeSifre.ResetOnPrompt = true;
            this.treeSifre.ResetOnSpace = true;
            this.treeSifre.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.treeSifre.SelectedText = "";
            this.treeSifre.SelectionLength = 0;
            this.treeSifre.SelectionStart = 0;
            this.treeSifre.ShortcutsEnabled = true;
            this.treeSifre.Size = new System.Drawing.Size(250, 48);
            this.treeSifre.SkipLiterals = true;
            this.treeSifre.TabIndex = 2;
            this.treeSifre.TabStop = false;
            this.treeSifre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.treeSifre.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.treeSifre.TrailingIcon = null;
            this.treeSifre.UseSystemPasswordChar = false;
            this.treeSifre.ValidatingType = null;
            // 
            // treeAdSoyad
            // 
            this.treeAdSoyad.AllowPromptAsInput = true;
            this.treeAdSoyad.AnimateReadOnly = false;
            this.treeAdSoyad.AsciiOnly = false;
            this.treeAdSoyad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.treeAdSoyad.BeepOnError = false;
            this.treeAdSoyad.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.treeAdSoyad.Depth = 0;
            this.treeAdSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.treeAdSoyad.HidePromptOnLeave = false;
            this.treeAdSoyad.HideSelection = true;
            this.treeAdSoyad.Hint = "AD SOYAD";
            this.treeAdSoyad.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.treeAdSoyad.LeadingIcon = null;
            this.treeAdSoyad.Location = new System.Drawing.Point(79, 223);
            this.treeAdSoyad.Mask = "";
            this.treeAdSoyad.MaxLength = 32767;
            this.treeAdSoyad.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.treeAdSoyad.Name = "treeAdSoyad";
            this.treeAdSoyad.PasswordChar = '\0';
            this.treeAdSoyad.PrefixSuffixText = null;
            this.treeAdSoyad.PromptChar = '_';
            this.treeAdSoyad.ReadOnly = false;
            this.treeAdSoyad.RejectInputOnFirstFailure = false;
            this.treeAdSoyad.ResetOnPrompt = true;
            this.treeAdSoyad.ResetOnSpace = true;
            this.treeAdSoyad.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.treeAdSoyad.SelectedText = "";
            this.treeAdSoyad.SelectionLength = 0;
            this.treeAdSoyad.SelectionStart = 0;
            this.treeAdSoyad.ShortcutsEnabled = true;
            this.treeAdSoyad.Size = new System.Drawing.Size(250, 48);
            this.treeAdSoyad.SkipLiterals = true;
            this.treeAdSoyad.TabIndex = 1;
            this.treeAdSoyad.TabStop = false;
            this.treeAdSoyad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.treeAdSoyad.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.treeAdSoyad.TrailingIcon = null;
            this.treeAdSoyad.UseSystemPasswordChar = false;
            this.treeAdSoyad.ValidatingType = null;
            // 
            // treeKullaniciAdi
            // 
            this.treeKullaniciAdi.AllowPromptAsInput = true;
            this.treeKullaniciAdi.AnimateReadOnly = false;
            this.treeKullaniciAdi.AsciiOnly = false;
            this.treeKullaniciAdi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.treeKullaniciAdi.BeepOnError = false;
            this.treeKullaniciAdi.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.treeKullaniciAdi.Depth = 0;
            this.treeKullaniciAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.treeKullaniciAdi.HidePromptOnLeave = false;
            this.treeKullaniciAdi.HideSelection = true;
            this.treeKullaniciAdi.Hint = "KULLANICI ADI";
            this.treeKullaniciAdi.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.treeKullaniciAdi.LeadingIcon = null;
            this.treeKullaniciAdi.Location = new System.Drawing.Point(79, 145);
            this.treeKullaniciAdi.Mask = "";
            this.treeKullaniciAdi.MaxLength = 32767;
            this.treeKullaniciAdi.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.treeKullaniciAdi.Name = "treeKullaniciAdi";
            this.treeKullaniciAdi.PasswordChar = '\0';
            this.treeKullaniciAdi.PrefixSuffixText = null;
            this.treeKullaniciAdi.PromptChar = '_';
            this.treeKullaniciAdi.ReadOnly = false;
            this.treeKullaniciAdi.RejectInputOnFirstFailure = false;
            this.treeKullaniciAdi.ResetOnPrompt = true;
            this.treeKullaniciAdi.ResetOnSpace = true;
            this.treeKullaniciAdi.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.treeKullaniciAdi.SelectedText = "";
            this.treeKullaniciAdi.SelectionLength = 0;
            this.treeKullaniciAdi.SelectionStart = 0;
            this.treeKullaniciAdi.ShortcutsEnabled = true;
            this.treeKullaniciAdi.Size = new System.Drawing.Size(250, 48);
            this.treeKullaniciAdi.SkipLiterals = true;
            this.treeKullaniciAdi.TabIndex = 0;
            this.treeKullaniciAdi.TabStop = false;
            this.treeKullaniciAdi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.treeKullaniciAdi.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.treeKullaniciAdi.TrailingIcon = null;
            this.treeKullaniciAdi.UseSystemPasswordChar = false;
            this.treeKullaniciAdi.ValidatingType = null;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.treeKaydet);
            this.panel2.Controls.Add(this.treeIptal);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 420);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(409, 67);
            this.panel2.TabIndex = 1;
            // 
            // treeKaydet
            // 
            this.treeKaydet.AutoSize = false;
            this.treeKaydet.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.treeKaydet.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.treeKaydet.Depth = 0;
            this.treeKaydet.HighEmphasis = true;
            this.treeKaydet.Icon = null;
            this.treeKaydet.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.treeKaydet.Location = new System.Drawing.Point(248, 15);
            this.treeKaydet.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.treeKaydet.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.treeKaydet.Name = "treeKaydet";
            this.treeKaydet.NoAccentTextColor = System.Drawing.Color.Empty;
            this.treeKaydet.Size = new System.Drawing.Size(120, 36);
            this.treeKaydet.TabIndex = 1;
            this.treeKaydet.Text = "KAYDET";
            this.treeKaydet.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.treeKaydet.UseAccentColor = false;
            this.treeKaydet.UseVisualStyleBackColor = true;
            this.treeKaydet.Click += new System.EventHandler(this.treeKaydet_Click_1);
            // 
            // treeIptal
            // 
            this.treeIptal.AutoSize = false;
            this.treeIptal.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.treeIptal.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.treeIptal.Depth = 0;
            this.treeIptal.HighEmphasis = true;
            this.treeIptal.Icon = null;
            this.treeIptal.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.treeIptal.Location = new System.Drawing.Point(40, 15);
            this.treeIptal.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.treeIptal.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.treeIptal.Name = "treeIptal";
            this.treeIptal.NoAccentTextColor = System.Drawing.Color.Empty;
            this.treeIptal.Size = new System.Drawing.Size(120, 36);
            this.treeIptal.TabIndex = 0;
            this.treeIptal.Text = "İPTAL";
            this.treeIptal.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.treeIptal.UseAccentColor = false;
            this.treeIptal.UseVisualStyleBackColor = true;
            this.treeIptal.Click += new System.EventHandler(this.treeIptal_Click);
            // 
            // treeDuzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 487);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "treeDuzenle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ROL DÜZENLE";
            this.Load += new System.EventHandler(this.treeDuzenle_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private ReaLTaiizor.Controls.MaterialButton treeKaydet;
        private ReaLTaiizor.Controls.MaterialButton treeIptal;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox treeSifre;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox treeAdSoyad;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox treeKullaniciAdi;
        private ReaLTaiizor.Controls.MaterialComboBox treeRoller;
    }
}