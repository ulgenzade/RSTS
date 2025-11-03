using Org.BouncyCastle.Pqc.Crypto.Lms;

namespace RestoranOtomasyon
{
    partial class frmGiris
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
            this.txtSifre = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            this.txtSecim = new ReaLTaiizor.Controls.MaterialComboBox();
            this.btnGiris = new ReaLTaiizor.Controls.MaterialButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtSifre);
            this.panel1.Controls.Add(this.txtSecim);
            this.panel1.Controls.Add(this.btnGiris);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(364, 435);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // txtSifre
            // 
            this.txtSifre.AnimateReadOnly = false;
            this.txtSifre.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtSifre.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtSifre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtSifre.CausesValidation = false;
            this.txtSifre.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtSifre.Depth = 0;
            this.txtSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtSifre.HideSelection = true;
            this.txtSifre.LeadingIcon = null;
            this.txtSifre.Location = new System.Drawing.Point(47, 200);
            this.txtSifre.MaxLength = 32767;
            this.txtSifre.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.PasswordChar = '●';
            this.txtSifre.PrefixSuffixText = null;
            this.txtSifre.ReadOnly = false;
            this.txtSifre.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtSifre.SelectedText = "";
            this.txtSifre.SelectionLength = 0;
            this.txtSifre.SelectionStart = 0;
            this.txtSifre.ShortcutsEnabled = true;
            this.txtSifre.Size = new System.Drawing.Size(270, 48);
            this.txtSifre.TabIndex = 5;
            this.txtSifre.TabStop = false;
            this.txtSifre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSifre.TrailingIcon = null;
            this.txtSifre.UseSystemPasswordChar = true;
            this.txtSifre.Click += new System.EventHandler(this.materialTextBoxEdit1_Click);
            this.txtSifre.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSifre_KeyDown);
            this.txtSifre.TextChanged += new System.EventHandler(this.txtSifre_TextChanged);
            // 
            // txtSecim
            // 
            this.txtSecim.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSecim.AutoResize = false;
            this.txtSecim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtSecim.Depth = 0;
            this.txtSecim.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.txtSecim.DropDownHeight = 174;
            this.txtSecim.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtSecim.DropDownWidth = 121;
            this.txtSecim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.txtSecim.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtSecim.FormattingEnabled = true;
            this.txtSecim.IntegralHeight = false;
            this.txtSecim.ItemHeight = 43;
            this.txtSecim.Items.AddRange(new object[] {
            "-KULLANICI SEÇİNİZ-",
            "Admin",
            "Garson"});
            this.txtSecim.Location = new System.Drawing.Point(47, 126);
            this.txtSecim.MaxDropDownItems = 4;
            this.txtSecim.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.txtSecim.Name = "txtSecim";
            this.txtSecim.Size = new System.Drawing.Size(270, 49);
            this.txtSecim.StartIndex = 0;
            this.txtSecim.TabIndex = 4;
            this.txtSecim.SelectedIndexChanged += new System.EventHandler(this.textSecim_SelectedIndexChanged);

            // 
            // btnGiris
            // 
            this.btnGiris.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGiris.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnGiris.Depth = 0;
            this.btnGiris.FlatAppearance.BorderSize = 19;
            this.btnGiris.HighEmphasis = true;
            this.btnGiris.Icon = null;
            this.btnGiris.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.btnGiris.Location = new System.Drawing.Point(150, 273);
            this.btnGiris.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnGiris.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnGiris.Size = new System.Drawing.Size(64, 36);
            this.btnGiris.TabIndex = 3;
            this.btnGiris.Text = "GİRİŞ";
            this.btnGiris.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnGiris.UseAccentColor = false;
            this.btnGiris.UseVisualStyleBackColor = true;
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click_1);
            // 
            // frmGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(388, 459);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmGiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RST-Giriş";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private ReaLTaiizor.Controls.MaterialButton btnGiris;
        private ReaLTaiizor.Controls.MaterialComboBox txtSecim;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtSifre;
    }
}

