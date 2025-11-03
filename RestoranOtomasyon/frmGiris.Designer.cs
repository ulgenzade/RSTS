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
            this.btnDropdown = new System.Windows.Forms.Button();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.txtSecim = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Garson = new System.Windows.Forms.Button();
            this.Admin = new System.Windows.Forms.Button();
            this.btnGiris = new ReaLTaiizor.Controls.MaterialButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnGiris);
            this.panel1.Controls.Add(this.btnDropdown);
            this.panel1.Controls.Add(this.txtSifre);
            this.panel1.Controls.Add(this.txtSecim);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(364, 435);
            this.panel1.TabIndex = 0;
            // 
            // btnDropdown
            // 
            this.btnDropdown.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDropdown.Location = new System.Drawing.Point(256, 177);
            this.btnDropdown.Name = "btnDropdown";
            this.btnDropdown.Size = new System.Drawing.Size(33, 34);
            this.btnDropdown.TabIndex = 0;
            this.btnDropdown.Text = "^";
            this.btnDropdown.UseVisualStyleBackColor = true;
            this.btnDropdown.Click += new System.EventHandler(this.btnDropdown_Click);
            // 
            // txtSifre
            // 
            this.txtSifre.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSifre.Location = new System.Drawing.Point(111, 253);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.PasswordChar = '*';
            this.txtSifre.Size = new System.Drawing.Size(149, 34);
            this.txtSifre.TabIndex = 2;
            this.txtSifre.TextChanged += new System.EventHandler(this.txtSifre_TextChanged);
            this.txtSifre.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSifre_KeyDown);
            // 
            // txtSecim
            // 
            this.txtSecim.Location = new System.Drawing.Point(111, 213);
            this.txtSecim.Multiline = true;
            this.txtSecim.Name = "txtSecim";
            this.txtSecim.ReadOnly = true;
            this.txtSecim.Size = new System.Drawing.Size(149, 34);
            this.txtSecim.TabIndex = 1;
            this.txtSecim.TextChanged += new System.EventHandler(this.txtSecim_TextChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Garson);
            this.panel2.Controls.Add(this.Admin);
            this.panel2.Location = new System.Drawing.Point(91, 103);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(182, 110);
            this.panel2.TabIndex = 2;
            this.panel2.Visible = false;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // Garson
            // 
            this.Garson.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Garson.Location = new System.Drawing.Point(20, 15);
            this.Garson.Name = "Garson";
            this.Garson.Size = new System.Drawing.Size(149, 41);
            this.Garson.TabIndex = 1;
            this.Garson.Text = "Garson";
            this.Garson.UseVisualStyleBackColor = true;
            this.Garson.Click += new System.EventHandler(this.button2_Click);
            // 
            // Admin
            // 
            this.Admin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Admin.Location = new System.Drawing.Point(20, 62);
            this.Admin.Name = "Admin";
            this.Admin.Size = new System.Drawing.Size(149, 41);
            this.Admin.TabIndex = 0;
            this.Admin.Text = "Admin";
            this.Admin.UseVisualStyleBackColor = true;
            this.Admin.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnGiris
            // 
            this.btnGiris.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGiris.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnGiris.Depth = 0;
            this.btnGiris.HighEmphasis = true;
            this.btnGiris.Icon = null;
            this.btnGiris.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.btnGiris.Location = new System.Drawing.Point(106, 296);
            this.btnGiris.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnGiris.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnGiris.Size = new System.Drawing.Size(158, 36);
            this.btnGiris.TabIndex = 3;
            this.btnGiris.Text = "materialButton1";
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
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtSecim;
        private System.Windows.Forms.Button btnDropdown;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Admin;
        private System.Windows.Forms.Button Garson;
        private System.Windows.Forms.TextBox txtSifre;
        private ReaLTaiizor.Controls.MaterialButton btnGiris;
    }
}

