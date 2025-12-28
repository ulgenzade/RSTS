using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestoranOtomasyon
{
    public partial class frmMasaTasi : Form
    {
        public int kaynakMasaId = 0;
        public int hedefMasaId = 0;
        public bool islemBasarili = false; 

        VeritabaniIslemleri db = new VeritabaniIslemleri();

        public frmMasaTasi()
        {
            InitializeComponent();
        }

        private async void frmMasaTasi_Load(object sender, EventArgs e)
        {
           
            Panel solPanel = this.Controls.OfType<Panel>().FirstOrDefault(p => p.Name == "pnlSol")
                             ?? this.Controls.OfType<Panel>().FirstOrDefault();

            if (solPanel != null) solPanel.BackColor = Color.White; 

            FlowLayoutPanel sagPanel = this.Controls.OfType<FlowLayoutPanel>().FirstOrDefault();
            if (sagPanel == null)
            {
                Control[] bulunanlar = this.Controls.Find("flowLayoutPanel1", true);
                if (bulunanlar.Length > 0) sagPanel = (FlowLayoutPanel)bulunanlar[0];
            }

            if (sagPanel != null)
            {
                sagPanel.AutoScroll = true;
                sagPanel.FlowDirection = FlowDirection.TopDown; 
                sagPanel.WrapContents = true;
                sagPanel.BackColor = Color.WhiteSmoke;
                sagPanel.Padding = new Padding(10);
            }

            if (kaynakMasaId != 0) await SolTarafiDoldur();
            if (sagPanel != null) SagTarafiDoldur(sagPanel);
        }

        private async Task SolTarafiDoldur()
        {
            try
            {
                DataTable dt = db.MasalariGetir();
                string masaAdi = "Masa ?";
                foreach (DataRow row in dt.Rows)
                {
                    if (Convert.ToInt32(row["MasaID"]) == kaynakMasaId)
                    {
                        masaAdi = row["MasaAdi"].ToString();
                        break;
                    }
                }

                if (lblBaslikFinal != null)
                {
                    lblBaslikFinal.Text = masaAdi;
                    lblBaslikFinal.ForeColor = Color.Black; 
                }

                if (lstListeFinal != null)
                {
                    lstListeFinal.Items.Clear();
                    lstListeFinal.ForeColor = Color.Black; 
                    lstListeFinal.Font = new Font("Segoe UI", 11, FontStyle.Regular);

                    var siparisler = await db.MasaSiparisleriniGetirAsync(kaynakMasaId);
                    decimal toplam = 0;

                    foreach (var s in siparisler)
                    {
                        string satir = $"{s.UrunAdi} x {s.Adet} = {(s.Adet * s.BirimFiyat):C2}";
                        lstListeFinal.Items.Add(satir);
                        toplam += (s.Adet * s.BirimFiyat);
                    }

                    if (lblTutarFinal != null)
                    {
                        lblTutarFinal.Text = "TOPLAM: " + toplam.ToString("C2");
                        lblTutarFinal.ForeColor = Color.Red; 
                    }
                }
            }
            catch { }
        }

        private void SagTarafiDoldur(FlowLayoutPanel panel)
        {
            panel.Controls.Clear();
            DataTable dt = db.MasalariGetir();

            foreach (DataRow row in dt.Rows)
            {
                int id = Convert.ToInt32(row["MasaID"]);
                if (id == kaynakMasaId) continue;

                Button btn = new Button();
                btn.Text = row["MasaAdi"].ToString();
                btn.Size = new Size(110, 70);
                btn.Margin = new Padding(5);
                btn.FlatStyle = FlatStyle.Flat;
                btn.Font = new Font("Segoe UI", 9, FontStyle.Bold);
                btn.ForeColor = Color.White;
                btn.Tag = id;

                string durum = row["Durum"].ToString();
                if (durum == "Dolu" || durum == "1") { btn.BackColor = Color.Crimson; btn.Text += "\n(DOLU)"; }
                else { btn.BackColor = Color.SeaGreen; btn.Text += "\n(BOŞ)"; }

                btn.Click += HedefMasa_Sec;
                panel.Controls.Add(btn);
            }
        }

        private void HedefMasa_Sec(object sender, EventArgs e)
        {
            Button secilen = (Button)sender;
            hedefMasaId = Convert.ToInt32(secilen.Tag);
            foreach (Control c in secilen.Parent.Controls)
            {
                if (c is Button b) b.BackColor = b.Text.Contains("DOLU") ? Color.Crimson : Color.SeaGreen;
            }
            secilen.BackColor = Color.Orange;
        }

        private void btnTasiBirlestir_Click(object sender, EventArgs e)
        {
            if (hedefMasaId == 0) { MessageBox.Show("Lütfen sağdan bir masa seçin."); return; }

            bool sonuc = db.MasaTasi(kaynakMasaId, hedefMasaId);
            if (sonuc)
            {
                MessageBox.Show("İşlem Başarılı!", "Tamam", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.islemBasarili = true;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Hata oluştu.");
            }
        }

        private void btnIptal_Click(object sender, EventArgs e) { this.Close(); }
        private void btnCikis_Click(object sender, EventArgs e) { this.Close(); }
        private void btnBitir_Click(object sender, EventArgs e) { this.Close(); }
    }
}