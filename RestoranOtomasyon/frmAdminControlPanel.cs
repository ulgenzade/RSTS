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
    public partial class frmAdminControlPanel : Form
    {
        public frmAdminControlPanel()
        {
            InitializeComponent();
        }

        // FORM İLK YÜKLENDİĞİNDE BU METOT ÇALIŞIR
        private void frmAdminControlPanel_Load(object sender, EventArgs e)
        {
            // --- ALPER'İN İŞİNİ KOLAYLAŞTIRACAK BÖLÜM ---
            // Alper, aşağıdaki sahte veri oluşturma kısımlarını,
            // veritabanından veri çeken kendi metotlarıyla değiştirecek.

            // 1. Sol taraftaki sahte kullanıcı verilerini ListBox'lara yükleyelim.
            listAdmins.Items.Add("Admin A (ulgenzade)");
            listAdmins.Items.Add("Admin B (JustKedy)");
            listCalisanlar.Items.Add("Çalışan A (yunuskr0)");
            listCalisanlar.Items.Add("Çalışan B");

            // 2. Sağ taraftaki sahte ürün verilerini DataGridView'e yükleyelim.
            DataTable urunTablosu = new DataTable();
            urunTablosu.Columns.Add("ID", typeof(int));
            urunTablosu.Columns.Add("Ürün Adı", typeof(string));
            urunTablosu.Columns.Add("Fiyat", typeof(decimal));

            // İçine birkaç satır sahte veri ekleyelim.
            urunTablosu.Rows.Add(1, "Adana Kebap", 150.00);
            urunTablosu.Rows.Add(2, "Ayran", 30.00);
            urunTablosu.Rows.Add(3, "Künefe", 80.00);

            // Hazırladığımız bu sahte tabloyu DataGridView'in kaynağı olarak ata.
            dgvUrunler.DataSource = urunTablosu;

            // Tablonun daha güzel görünmesi için ayarlar.
            dgvUrunler.Columns["ID"].Width = 50;
            dgvUrunler.Columns["Ürün Adı"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvUrunler.SelectionMode = DataGridViewSelectionMode.FullRowSelect; // Tıklayınca tüm satırı seç
        }

        // --- YUNUS'UN İÇİNİ DOLDURACAĞI OLAYLAR ---

        // Sol paneldeki "SİL" butonu
        private void btnHesapSil_Click(object sender, EventArgs e)
        {
            if (listAdmins.SelectedItem != null)
            {
                MessageBox.Show(listAdmins.SelectedItem.ToString() + " hesabı silinecek.");
                // Yunus buraya, seçilen admini veritabanından silen kodu yazacak.
            }
            else if (listCalisanlar.SelectedItem != null)
            {
                MessageBox.Show(listCalisanlar.SelectedItem.ToString() + " hesabı silinecek.");
                // Yunus buraya, seçilen çalışanı veritabanından silen kodu yazacak.
            }
            else
            {
                MessageBox.Show("Lütfen silmek için bir hesap seçin.");
            }
        }

        // Sağ paneldeki "SİL" butonu
        private void btnUrunSil_Click(object sender, EventArgs e)
        {
            if (dgvUrunler.SelectedRows.Count > 0)
            {
                string secilenUrun = dgvUrunler.SelectedRows[0].Cells["Ürün Adı"].Value.ToString();
                MessageBox.Show(secilenUrun + " ürünü silinecek.");
                // Yunus buraya, seçilen ürünü veritabanından silen kodu yazacak.
            }
            else
            {
                MessageBox.Show("Lütfen silmek için tablodan bir ürün seçin.");
            }
        }

        // --- SENİN VERDİĞİN KODDAN GELEN, ŞİMDİLİK BOŞ OLAN METOTLAR ---
        // Bu metotların içi boş kalsa bile var olmaları, tasarımcı hatasını engeller.
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Bu olay şimdilik kullanılmıyor.
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            // Bu butona henüz bir görev atanmadı.
        }
    }
}