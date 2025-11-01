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
    public partial class frmMasalar : Form
    {
        public frmMasalar()
        {
            InitializeComponent();
        }

        // Form ilk yüklendiğinde bu metot otomatik olarak çalışır.
        private void frmMasalar_Load(object sender, EventArgs e)
        {
            // Veritabanından geliyormuş gibi 10 tane masa oluşturalım.
            // Alper daha sonra bu for döngüsünü, veritabanından masaları çeken gerçek kodla değiştirecek.
            for (int i = 1; i <= 10; i++)
            {
                Button masaButonu = new Button();
                masaButonu.Text = "MASA - " + i;
                masaButonu.Name = "btnMasa" + i;
                masaButonu.Size = new Size(150, 100);
                masaButonu.Margin = new Padding(10);
                masaButonu.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
                masaButonu.Tag = i; // Butonun hangi masa olduğunu (ID'sini) saklıyoruz. Bu çok önemli.

                // Başlangıçta hepsi yeşil (Boş) olsun.
                // Alper daha sonra veritabanından gelen duruma göre bu rengi ayarlayacak.
                masaButonu.BackColor = Color.LightGreen;

                // Bu yeni oluşturulan butona tıklandığında hangi metodun çalışacağını belirtiyoruz.
                masaButonu.Click += MasaButonu_Click;

                // Hazırlanan butonu, tasarım ekranına sürüklediğin flowMasalar paneline ekliyoruz.
                flowMasalar.Controls.Add(masaButonu);
            }
        }

        // Yukarıda kodla oluşturulan masa butonlarından herhangi birine tıklandığında bu metot çalışır.
        private void MasaButonu_Click(object sender, EventArgs e)
        {
            // 'sender' parametresi, hangi butonun tıklandığı bilgisini taşır.
            Button tiklananButon = sender as Button;
            int masaNumarasi = (int)tiklananButon.Tag;

            // Durum değiştirme formunu (frmMasaDurum) açıyoruz.
            // Hangi masa için açıldığını belirtmek için masa numarasını ona gönderiyoruz.
            frmMasaDurum durumFormu = new frmMasaDurum(masaNumarasi);

            // Yeni formu bir diyalog penceresi olarak aç ve kullanıcının bir butona basmasını bekle.
            DialogResult sonuc = durumFormu.ShowDialog();

            // Eğer kullanıcı o formdaki durum butonlarından birine bastıysa (pencereyi çarpıdan kapatmadıysa)...
            if (sonuc == DialogResult.OK)
            {
                // --- ALPER'İN İŞİNİ KOLAYLAŞTIRAN YER ---
                // Kullanıcının seçtiği yeni durumu (örn: "Dolu") alıyoruz.
                string yeniDurum = durumFormu.SecilenDurum;

                // Alper'in tek yapması gereken, bu 'yeniDurum' bilgisini alıp
                // 'masaNumarasi' ID'li masanın durumunu veritabanında güncellemek olacak.
                MessageBox.Show("Masa " + masaNumarasi + " durumu " + yeniDurum + " olarak güncellenecek.");

                // Ana ekrandaki butonun rengini, seçilen yeni duruma göre güncelliyoruz.
                switch (yeniDurum)
                {
                    case "Dolu":
                        tiklananButon.BackColor = Color.Salmon;
                        break;
                    case "Boş":
                        tiklananButon.BackColor = Color.LightGreen;
                        break;
                    case "Rezerve":
                        tiklananButon.BackColor = Color.LightBlue;
                        break;
                }
            }
        }

        // Bu metot, tasarımcı tarafından otomatik olarak oluşturulmuştur, şimdilik boş kalabilir.
        private void flowMasalar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmMasalar_Load_1(object sender, EventArgs e)
        {

        }
    }
}