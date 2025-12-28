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
    public partial class treeDuzenle : Form
    {
        private VeritabaniIslemleri db = new VeritabaniIslemleri();
        private int _kullaniciID;

        public treeDuzenle(int kullaniciID)
        {
            InitializeComponent();
            _kullaniciID = kullaniciID;
        }

        private void treeDuzenle_Load(object sender, EventArgs e)
        {
            try
            {
               treeRoller.Items.AddRange(new object[] { "Yetkili", "Garson" });
            }
            catch { }

            if (_kullaniciID != -1)
            {
                DataTable dt = db.TekKullaniciGetir(_kullaniciID);
                if (dt.Rows.Count > 0)
                {
                    DataRow row = dt.Rows[0];
                    treeAdSoyad.Text = row["AdSoyad"].ToString();
                    treeKullaniciAdi.Text = row["KullaniciAdi"].ToString();

                    string gelenRol = row["Rol"].ToString();
                    if (gelenRol == "Admin")
                        treeRoller.SelectedItem = "Yetkili";
                    else
                        treeRoller.SelectedItem = gelenRol;

                    treeSifre.Text = "";
                }
            }
        }

        private void treeKaydet_Click_1(object sender, EventArgs e)
        {
            
            string secilenRol = treeRoller.Text;

            if (secilenRol == "Yetkili")
            {
              secilenRol = "Admin";
            }
           
            bool sonuc = false;
            if (_kullaniciID == -1)
            {
              sonuc = db.KullaniciEkle(treeAdSoyad.Text, treeKullaniciAdi.Text, treeSifre.Text, secilenRol);
            }
            else
            {
               sonuc = db.KullaniciGuncelle(_kullaniciID, treeAdSoyad.Text, treeKullaniciAdi.Text, treeSifre.Text, secilenRol);
            }

            if (sonuc) { this.DialogResult = DialogResult.OK; this.Close(); }
            else MessageBox.Show("Hata.");
        }

        private void treeIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
