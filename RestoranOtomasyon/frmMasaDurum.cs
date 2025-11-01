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
    public partial class frmMasaDurum : Form
    {
        // Bu property (özellik), bu form kapatıldığında ana formun (frmMasalar)
        // hangi duruma tıklandığını okuyabilmesi için bir "posta kutusu" görevi görür.
        public string SecilenDurum { get; private set; }

        // Varsayılan constructor'ı siliyoruz ve yerine bunu kullanıyoruz.
        // Bu formun, hangi masa için açıldığını bilmek zorunda olduğunu belirtiyoruz.
        public frmMasaDurum(int masaNumarasi)
        {
            InitializeComponent();

            // Ana formdan gelen masa numarasını kullanarak başlık Label'ını güncelliyoruz.
            lblMasaAdi.Text = "MASA - " + masaNumarasi + " DURUMUNU GÜNCELLE";
        }

        // Tasarımcı tarafından oluşturulan Load metodu, şimdilik boş kalabilir.
        private void frmMasaDurum_Load(object sender, EventArgs e)
        {
            // Bu form yüklendiğinde yapılacak bir işlem varsa buraya yazılabilir.
        }

        // --- DURUM BUTONLARININ TIKLANMA OLAYLARI ---

        private void btnDolu_Click(object sender, EventArgs e)
        {
            // 1. Seçilen durumu "posta kutumuza" koy.
            this.SecilenDurum = "Dolu";

            // 2. Ana forma işlemin başarıyla tamamlandığını bildirmek için "OK" sinyali gönder.
            this.DialogResult = DialogResult.OK;

            // 3. Bu formu kapat.
            this.Close();
        }

        private void btnBos_Click(object sender, EventArgs e)
        {
            this.SecilenDurum = "Boş";
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnRezerve_Click(object sender, EventArgs e)
        {
            this.SecilenDurum = "Rezerve";
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}