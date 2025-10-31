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
    public partial class frmOdemeEkrani : Form
    {
        public frmOdemeEkrani()
        {
            InitializeComponent();
        }

        private void frmOdemeEkrani_Load(object sender, EventArgs e)
        {

        }

        private void panelUrunler_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnHesapBilgisi_Click(object sender, EventArgs e)
        {

        }

        private void btnMasa1_Click(object sender, EventArgs e)
        {
            // Önce mevcut ürünleri temizle
            flowUrunler.Controls.Clear();

            // Örnek ürünler oluşturup ekle (Normalde bunlar veritabanından gelecek)
            string[] urunler = { "ÜRÜN A", "ÜRÜN B", "ÜRÜN C", "ÜRÜN D", "ÜRÜN E", "ÜRÜN F" };
            foreach (string urunAdi in urunler)
            {
                Button urunButonu = new Button();
                urunButonu.Text = urunAdi;
                urunButonu.Size = new Size(100, 50); // Buton boyutu
                urunButonu.Click += UrunButonu_Click; // Tıklama olayını bağla
                flowUrunler.Controls.Add(urunButonu); // Panele ekle
            }
        }

        private void panelMasalar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnOde_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ödeme işlemi tamamlandı! Toplam " + listOzet.Items.Count + " adet ürün ödendi.");
            listOzet.Items.Clear(); // Özet listesini temizle
        }

        private void btnVazgecOde_Click(object sender, EventArgs e)
        {
            listOzet.Items.Clear(); // Sadece özet listesini temizle
        }

        // --- YENİ EKLENEN VE EKSİK OLAN METOT BURASI ---
        // Kodla oluşturulan ürün butonlarından herhangi birine tıklandığında bu fonksiyon çalışır.
        private void UrunButonu_Click(object sender, EventArgs e)
        {
            // Hangi butona tıklandığını 'sender' parametresi sayesinde anlıyoruz.
            Button tiklananButon = sender as Button;

            // Güvenlik kontrolü: Tıklanan şeyin bir buton olduğundan emin olalım.
            if (tiklananButon != null)
            {
                // Butonun üzerindeki yazıyı (ürün adını) sağdaki özet listesine ekle.
                listOzet.Items.Add(tiklananButon.Text);

                // Kullanıcıya seçildiğini göstermek için butonu ortadaki panelden kaldır.
                flowUrunler.Controls.Remove(tiklananButon);
            }
        }
    }
}