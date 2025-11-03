using RestoranOtomasyonu;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestoranOtomasyon
{
    public partial class frmGiris : Form
    {
        public frmGiris()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // Panel, form ilk açıldığında gizli olsun.
            panel2.Visible = false;

            // Şifre girerken karakterler '*' olarak görünsün.
            txtSifre.PasswordChar = '*';
        }
        private void dataGridViewKategoriler_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewKategoriler_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtSecim_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            txtSecim.Text = "Admin";
            panel2.Visible = false;
        }

        private void btnDropdown_Click(object sender, EventArgs e)
        {
            panel2.Visible = !panel2.Visible;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtSecim.Text = "Garson";
            panel2.Visible = false;
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSecim.Text) || string.IsNullOrWhiteSpace(txtSifre.Text))
            {
                MessageBox.Show("Lütfen rol seçin ve şifrenizi girin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            VeritabaniIslemleri db = new VeritabaniIslemleri();
            string secilenRol = txtSecim.Text;
            string girilenSifre = txtSifre.Text;

            // Yeni backend metodumuzu çağırıyoruz.
            DataRow kullanici = db.KullaniciGirisKontrol(secilenRol, girilenSifre);

            if (kullanici != null)
            {
                // KULLANICI BULUNDU == Bilgilerini statik sınıfa kaydet
                AktifKullanici.BilgileriAta(kullanici);

                MessageBox.Show($"Hoş geldiniz, {AktifKullanici.AdSoyad}!", "Giriş Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Şimdi role göre doğru formu aç.
                if (AktifKullanici.Rol == "Admin")
                {
                    frmAdminControlPanel adminFormu = new frmAdminControlPanel();
                    adminFormu.Show();
                    this.Hide();
                }
                else if (AktifKullanici.Rol == "Garson")
                {
                    frmSiparisEkrani siparisFormu = new frmSiparisEkrani();
                    siparisFormu.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Bu rol için tanımlanmış bir ekran bulunmamaktadır.", "Yetki Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Rol veya şifre hatalı!", "Giriş Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtSifre_KeyDown(object sender, KeyEventArgs e)
        {
            // Eğer basılan tuş Enter tuşu ise...
            if (e.KeyCode == Keys.Enter)
            {
                // ...Giriş butonuna tıkla.
                btnGiris.PerformClick();
            }
        }

        private void txtSifre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
