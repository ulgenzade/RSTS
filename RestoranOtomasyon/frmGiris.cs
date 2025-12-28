using ReaLTaiizor.Enum.Metro;
using System;
using System.Data;
using System.Web.UI.WebControls;
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

        

        private void btnGiris_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSecim.Text) || string.IsNullOrWhiteSpace(txtSifre.Text))
            {
                MessageBox.Show("Lütfen rol seçin ve şifrenizi girin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            VeritabaniIslemleri db = new VeritabaniIslemleri();

            string ekrandakiRol = txtSecim.Text;
            string veritabaniRolu = ekrandakiRol;

            if (ekrandakiRol == "Yetkili" || ekrandakiRol == "yetkili")
            {
                veritabaniRolu = "Admin";
            }

            string girilenSifre = txtSifre.Text;

            DataRow kullanici = db.KullaniciGirisKontrol(veritabaniRolu, girilenSifre);

            if (kullanici != null)
            {
                AktifKullanici.BilgileriAta(kullanici);

                MessageBox.Show($"Hoş geldiniz, {AktifKullanici.AdSoyad}!", "Giriş Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                    MessageBox.Show("Bu rol için tanımlanmış bir ekran bulunmamaktadır.", "Yetki Hatası");
                }
            }
            else
            {
                MessageBox.Show("Rol veya şifre hatalı!", "Giriş Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtSifre_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {

                btnGiris.PerformClick();
            }
        }

        private void txtSifre_TextChanged(object sender, EventArgs e)
        {

        }

        private void textSecim_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void materialTextBoxEdit1_Click(object sender, EventArgs e)
        {
         
        }
    }
}
