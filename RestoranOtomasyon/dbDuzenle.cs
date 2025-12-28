using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Org.BouncyCastle.Crypto.Engines.SM2Engine;

namespace RestoranOtomasyon
{
    public partial class dbDuzenle : Form
    {
        private VeritabaniIslemleri db = new VeritabaniIslemleri();
        private string _mod;
        private int _id;

        public dbDuzenle(string mod, int id)
        {
            InitializeComponent();
            _mod = mod;
            _id = id;
        }

        private void dbDuzenle_Load(object sender, EventArgs e)
        {
            try
            {
                materialComboBox1.DataSource = db.KategorileriGetir();
                materialComboBox1.DisplayMember = "KategoriAdi";
                materialComboBox1.ValueMember = "KategoriID";
                materialComboBox1.SelectedIndex = -1;
            }
            catch { }

            EkranGorunumunuAyarla();
            if (_id != -1) VerileriDoldur();
        }

        private void EkranGorunumunuAyarla()
        {
            switch (_mod)
            {
                case "Urunler":
                    this.Text = (_id == -1) ? "Ürün Ekle" : "Ürün Düzenle";
                    dbUrunAdi.Hint = "Ürün Adı";
                    dbUrunFiyati.Visible = true;
                    materialComboBox1.Visible = true;
                    break;
                case "Kategoriler":
                    this.Text = (_id == -1) ? "Kategori Ekle" : "Kategori Düzenle";
                    dbUrunAdi.Hint = "Kategori Adı";
                    dbUrunFiyati.Visible = true;
                    dbUrunFiyati.Hint = "Açıklama";
                    materialComboBox1.Visible = false;
                    break;
                case "Masalar":
                    this.Text = (_id == -1) ? "Masa Ekle" : "Masa Düzenle";
                    dbUrunAdi.Hint = "Masa Adı";
                    dbUrunFiyati.Visible = false;
                    materialComboBox1.Visible = false;
                    break;
            }
        }

        private void VerileriDoldur()
        {
            DataTable dt = new DataTable();
            if (_mod == "Urunler") dt = db.UrunleriGetir();
            else if (_mod == "Kategoriler") dt = db.KategorileriGetir();
            else if (_mod == "Masalar") dt = db.MasalariGetir();

            foreach (DataRow row in dt.Rows)
            {
                if (Convert.ToInt32(row[0]) == _id)
                {
                    dbUrunAdi.Text = row[1].ToString();
                    if (_mod == "Urunler")
                    {
                        dbUrunFiyati.Text = row["Fiyat"].ToString();
                        materialComboBox1.Text = row["KategoriAdi"].ToString();
                    }
                    else if (_mod == "Kategoriler")
                    {
                        dbUrunFiyati.Text = row["Aciklama"].ToString();
                    }
                    break;
                }
            }
        }

        private void dbKaydet_Click_1(object sender, EventArgs e)
        {
            try
            {
                bool sonuc = false;
                if (_mod == "Urunler")
                {
                    decimal fiyat = Convert.ToDecimal(dbUrunFiyati.Text);
                    int katID = Convert.ToInt32(materialComboBox1.SelectedValue);
                    if (_id == -1) sonuc = db.UrunEkle(dbUrunAdi.Text, fiyat, katID, true);
                    else sonuc = db.UrunGuncelle(_id, dbUrunAdi.Text, fiyat, katID, true);
                }
                else if (_mod == "Kategoriler")
                {
                    if (_id == -1) sonuc = db.KategoriEkle(dbUrunAdi.Text, dbUrunFiyati.Text);
                    else sonuc = db.KategoriGuncelle(_id, dbUrunAdi.Text, dbUrunFiyati.Text);
                }
                else if (_mod == "Masalar")
                {
                    if (_id == -1)
                    {
                      sonuc = db.MasaEkle(dbUrunAdi.Text);
                    }
                    else
                    {
                        sonuc = db.MasaGuncelle(_id, dbUrunAdi.Text);
                    }
                }

                if (sonuc) { this.DialogResult = DialogResult.OK; this.Close(); }
            }
            catch { MessageBox.Show("Hata oluştu. Değerleri kontrol et."); }
        }

        private void dbIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
