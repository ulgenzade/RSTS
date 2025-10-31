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
            txtSecim.Text = "Garson"; // veya button1.Text de yazabilirsin
            panel2.Visible = false;
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            // Seçilen oturum adını ve girilen şifreyi alalım
            string secilenOturum = txtSecim.Text;
            string girilenSifre = txtSifre.Text;

            // --- GERÇEK GİRİŞ KONTROLÜ BURADA BAŞLIYOR ---

            // Örnek: Eğer seçilen oturum "Admin" ve şifre "1234" ise giriş başarılı olsun
            if (secilenOturum == "Admin" && girilenSifre == "1234")
            {
                // Giriş başarılı olduğunda gösterilecek mesaj
                MessageBox.Show("Giriş yapılmıştır!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // İPUCU: Burada ana menü formunu açan kodu yazabilirsin.
                // frmAnamenu anamenu = new frmAnamenu();
                // anamenu.Show();
                // this.Hide(); // Bu giriş ekranını gizle
            }
            // Örnek: Eğer seçilen oturum "Garson" ve şifre "garson" ise giriş başarılı olsun
            else if (secilenOturum == "Garson" && girilenSifre == "garson")
            {
                MessageBox.Show("Giriş yapılmıştır!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Yukarıdaki şartlar tutmuyorsa, giriş başarısızdır
                MessageBox.Show("Hatalı kullanıcı adı veya şifre!", "Hatalı Giriş", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
