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
            // Bu, şifrenin ekranda görünmesini engeller.
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
            txtSecim.Text = "Admin"; // veya button2.Text de yazabilirsin
            panel2.Visible = false;
        }

        private void btnDropdown_Click(object sender, EventArgs e)
        {
            panel2.Visible = !panel2.Visible;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtSecim.Text = "ayse"; // veya button1.Text de yazabilirsin
            panel2.Visible = false;
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            // 1. Alanların boş olup olmadığını kontrol et.
            if (string.IsNullOrWhiteSpace(txtSecim.Text) || string.IsNullOrWhiteSpace(txtSifre.Text))
            {
                MessageBox.Show("Lütfen kullanıcı adı ve şifre alanlarını doldurun.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Hata varsa metodun devamını çalıştırma.
            }

            // 2. Backend'i çağır!
            VeritabaniIslemleri db = new VeritabaniIslemleri();
            string kullaniciAdi = txtSecim.Text;
            string sifre = txtSifre.Text;

            // Veritabanına gidip bu kullanıcı adı ve şifreye sahip biri var mı diye kontrol et.
            DataRow kullanici = db.KullaniciGirisKontrol(kullaniciAdi, sifre);

            // 3. Gelen sonuca göre karar ver.
            if (kullanici != null) // EĞER VERİTABANINDA KULLANICI BULUNDUYSA...
            {
                // ...giriş başarılıdır.
                string rol = kullanici["Rol"].ToString(); // Kullanıcının Rolünü öğren.

                MessageBox.Show($"Giriş başarılı! Hoş geldiniz.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Şimdi role göre doğru formu aç.
                if (rol == "Admin")
                {
                    // BU İSİMLERİ KENDİ PROJENDİKİ FORM İSİMLERİYLE DEĞİŞTİR!
                    frmAdminControlPanel adminFormu = new frmAdminControlPanel();
                    adminFormu.Show();
                    this.Hide(); // Giriş formunu gizle.
                }
                else if (rol == "Garson")
                {
                    // BU İSİMLERİ KENDİ PROJENDİKİ FORM İSİMLERİYLE DEĞİŞTİR!
                    frmSiparisEkrani siparisFormu = new frmSiparisEkrani();
                    siparisFormu.Show();
                    this.Hide(); // Giriş formunu gizle.
                }
                else
                {
                    MessageBox.Show("Bu rol için tanımlanmış bir ekran bulunmamaktadır.", "Yetki Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else // EĞER VERİTABANINDA KULLANICI BULUNAMADIYSA...
            {
                MessageBox.Show("Kullanıcı adı veya şifre hatalı!", "Giriş Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
    }
}
