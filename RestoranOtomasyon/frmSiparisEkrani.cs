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
    public partial class frmSiparisEkrani : Form
    {
        public frmSiparisEkrani()
        {
            InitializeComponent();
        }

        // FORM İLK AÇILDIĞINDA BU METOT ÇALIŞIR
        private void frmSiparisEkrani_Load(object sender, EventArgs e)
        {
            // Sol tarafa 1'den 6'ya kadar masa butonlarını oluşturalım.
            // Bu kısım daha sonra Alper'in veritabanından masaları çeken koduyla değiştirilecek.
            for (int i = 1; i <= 6; i++)
            {
                // Yeni bir buton nesnesi yarat
                Button masaButonu = new Button();

                // Butonun özelliklerini ayarla
                masaButonu.Text = "MASA - " + i;
                masaButonu.Name = "btnMasa" + i;
                masaButonu.Size = new Size(150, 100);       // Butonun boyutu
                masaButonu.Margin = new Padding(10);         // Butonlar arası boşluk
                masaButonu.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
                masaButonu.Tag = i;                          // Butonun hangi masa olduğunu (ID'sini) saklamak için gizli bir etiket. Bu çok önemlidir.

                // Bu yeni oluşturulan butona tıklandığında hangi metodun çalışacağını belirtiyoruz.
                // Bütün masa butonları tıklandığında AŞAĞIDAKİ AYNI metot çalışacak.
                masaButonu.Click += new EventHandler(MasaButonu_Click);

                // Hazırlanan butonu sol panelimize (flowMasalar) ekle
                flowMasalar.Controls.Add(masaButonu);
            }
        }

        // YUKARIDA OLUŞTURULAN MASA BUTONLARINDAN HERHANGİ BİRİNE TIKLANDIĞINDA BU METOT ÇALIŞIR
        private void MasaButonu_Click(object sender, EventArgs e)
        {
            // 'sender' parametresi, hangi butonun tıklandığı bilgisini taşır.
            Button tiklananMasaButonu = sender as Button;

            // Güvenlik kontrolü
            if (tiklananMasaButonu == null) return;

            // Butonun Tag özelliğinde sakladığımız masa numarasını alıyoruz.
            int masaNumarasi = Convert.ToInt32(tiklananMasaButonu.Tag);

            // Sağdaki sipariş panelini görünür yapalım
            panelSiparis.Visible = true;

            // Sipariş panelinin içini önce bir temizleyelim (varsa eski siparişlerden kurtulmak için)
            panelSiparisListesi.Controls.Clear();

            // --- BU KISIM DAHA SONRA VERİTABANI KODLARIYLA DEĞİŞECEK ---
            // Şimdilik, tıklanan masaya göre sahte sipariş verileri oluşturalım.
            // Örneğin, 1 numaralı masanın siparişleri farklı, diğerlerinin farklı olsun.
            List<string> urunler = new List<string>();
            if (masaNumarasi == 1)
            {
                urunler.Add("Adana Kebap");
                urunler.Add("Ayran");
                urunler.Add("Salata");
            }
            else
            {
                urunler.Add("Çorba");
                urunler.Add("İskender");
                urunler.Add("Kola");
                urunler.Add("Künefe");
            }
            // -------------------------------------------------------------

            // Sağ tarafa, gelen her bir ürün için bir "sipariş satırı" ekleyelim
            foreach (string urunAdi in urunler)
            {
                // Her bir sipariş satırı için bir Panel oluşturuyoruz. Bu, elemanları bir arada tutar.
                Panel urunSatiriPaneli = new Panel();
                urunSatiriPaneli.Size = new Size(panelSiparisListesi.Width - 25, 40); // Genişliği ana panele göre ayarla
                urunSatiriPaneli.BorderStyle = BorderStyle.FixedSingle;
                urunSatiriPaneli.Dock = DockStyle.Top; // Panellerin üst üste dizilmesini sağlar

                // Panelin içine ürünün adını yazan bir Label ekleyelim
                Label lblUrunAdi = new Label();
                lblUrunAdi.Text = urunAdi;
                lblUrunAdi.Location = new Point(10, 10);
                lblUrunAdi.AutoSize = true;

                // Hazırladığımız Label'ı satır paneline ekleyelim
                urunSatiriPaneli.Controls.Add(lblUrunAdi);

                // Hazırladığımız bu satır panelini de ana sipariş listesi paneline ekliyoruz
                panelSiparisListesi.Controls.Add(urunSatiriPaneli);
            }
        }

        // Bu metot, tasarımcı tarafından otomatik oluşturulmuştur, şimdilik boş kalabilir.
        private void panelSiparis_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnOrnekMasa_Click(object sender, EventArgs e)
        {

        }

        private void lblGarsonAdi_Click(object sender, EventArgs e)
        {

        }
    }
}