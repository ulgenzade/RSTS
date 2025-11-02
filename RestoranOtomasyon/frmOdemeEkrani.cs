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
        // YENİ: Ürünlerin fiyatlarını tutmak için bir sözlük (Dictionary)
        private Dictionary<string, decimal> urunFiyatlari = new Dictionary<string, decimal>();

        // YENİ: Özet listesindeki ürünlerin anlık toplamını tutmak için değişken
        private decimal anlikToplam = 0;

        public frmOdemeEkrani()
        {
            InitializeComponent();
        }

        private void frmOdemeEkrani_Load(object sender, EventArgs e)
        {
            this.btnAnaMenu.Click -= btnAnaMenu_Click;
            this.btnAnaMenu.Click += btnAnaMenu_Click;

            // YENİ: Başlangıçta toplam label'ını ayarla
            lblToplamTutar.Text = "Toplam: 0.00 TL";

            // YENİ: Ödeme panelini başlangıçta gizle
            pnlOdemeSecenekleri.Visible = false;

            // DÜZELTME:
            // Buton olayları (btnNakitOde vb.) tasarım ekranından
            // çift tıklanarak bağlandığı varsayıldığı için
            // çakışma yaratan 3 satırlık kod buradan silindi.
        }

        private void btnAnaMenu_Click(object sender, EventArgs e)
        {
            this.Close();
            frmSiparisEkrani siparisFormu = new frmSiparisEkrani();
            siparisFormu.Show();
        }

        private void panelUrunler_Paint(object sender, PaintEventArgs e)
        {
            // (Boş bırakılabilir)
        }

        private void btnHesapBilgisi_Click(object sender, EventArgs e)
        {
            // (İleride doldurulabilir)
        }

        // DEĞİŞTİ: Artık ürünleri fiyatlarıyla yüklüyor
        private void btnMasa1_Click(object sender, EventArgs e)
        {
            flowUrunler.Controls.Clear();

            // YENİ: Fiyat listemizi temizleyip yeniden dolduruyoruz
            urunFiyatlari.Clear();
            urunFiyatlari.Add("ÜRÜN A", 50.00m);
            urunFiyatlari.Add("ÜRÜN B", 30.50m);
            urunFiyatlari.Add("ÜRÜN C", 15.00m);
            urunFiyatlari.Add("ÜRÜN D", 80.75m);
            urunFiyatlari.Add("ÜRÜN E", 120.00m);
            urunFiyatlari.Add("ÜRÜN F", 10.00m);

            // Ürünleri sözlükten alıp buton olarak ekliyoruz
            foreach (string urunAdi in urunFiyatlari.Keys)
            {
                Button urunButonu = new Button();
                urunButonu.Text = urunAdi;
                urunButonu.Size = new Size(100, 50);
                urunButonu.Click += UrunButonu_Click;
                flowUrunler.Controls.Add(urunButonu);
            }
        }

        private void panelMasalar_Paint(object sender, PaintEventArgs e)
        {
            // (Boş bırakılabilir)
        }

        // DEĞİŞTİ: ÖDE Butonu artık ödeme panelini açıyor.
        private void btnOde_Click(object sender, EventArgs e)
        {
            if (listOzet.Items.Count > 0)
            {
                lblOdemeTutari.Text = "Ödenecek Tutar: " + anlikToplam.ToString("C");
                pnlOdemeSecenekleri.Visible = true;
                pnlOdemeSecenekleri.BringToFront();
            }
            else
            {
                MessageBox.Show("Ödeme yapmak için lütfen önce ürün seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // DEĞİŞTİ: Vazgeç butonu toplamı da sıfırlıyor.
        private void btnVazgecOde_Click(object sender, EventArgs e)
        {
            listOzet.Items.Clear();

            anlikToplam = 0;
            lblToplamTutar.Text = "Toplam: 0.00 TL";

            // Masayı yenilemek için (opsiyonel):
            // btnMasa1_Click(null, null); 
        }

        // DEĞİŞTİ: Ürün butonu artık fiyat hesaplıyor.
        private void UrunButonu_Click(object sender, EventArgs e)
        {
            Button tiklananButon = sender as Button;
            if (tiklananButon != null)
            {
                string urunAdi = tiklananButon.Text;

                if (urunFiyatlari.ContainsKey(urunAdi))
                {
                    decimal fiyat = urunFiyatlari[urunAdi];

                    listOzet.Items.Add(urunAdi + " - " + fiyat.ToString("C"));

                    anlikToplam += fiyat;
                    lblToplamTutar.Text = "Toplam: " + anlikToplam.ToString("C");

                    flowUrunler.Controls.Remove(tiklananButon);
                }
            }
        }

        // -------------------------------------------------------------------
        // YENİ EKLENEN METOTLAR (ÖDEME PANELİ İÇİN)
        // -------------------------------------------------------------------

        /// <summary>
        /// Ödeme işlemini (Nakit veya Kart) tamamlar ve ekranı sıfırlar.
        /// </summary>
        private void IslemiBitir(string odemeTuru)
        {
            MessageBox.Show("Ödeme (" + odemeTuru + ") başarıyla tamamlandı!\nToplam Tutar: " + anlikToplam.ToString("C"));

            listOzet.Items.Clear();
            anlikToplam = 0;
            lblToplamTutar.Text = "Toplam: 0.00 TL";

            pnlOdemeSecenekleri.Visible = false;

            // Masayı yenilemek için (opsiyonel):
            // btnMasa1_Click(null, null); 
        }

        // YENİ: Nakit ödeme butonu
        private void btnNakitOde_Click(object sender, EventArgs e)
        {
            IslemiBitir("Nakit");
        }

        // YENİ: Kartla ödeme butonu
        private void btnKartOde_Click(object sender, EventArgs e)
        {
            IslemiBitir("Kart");
        }

        // YENİ: Ödeme seçme ekranını iptal etme butonu
        private void btnOdemeIptal_Click(object sender, EventArgs e)
        {
            pnlOdemeSecenekleri.Visible = false;
        }
    }
}