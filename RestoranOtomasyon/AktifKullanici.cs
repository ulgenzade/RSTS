using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestoranOtomasyon
{
    public static class AktifKullanici
    {
        public static int KullaniciID { get; private set; }
        public static string AdSoyad { get; private set; }
        public static string Rol { get; private set; }

        public static void BilgileriAta(DataRow kullanici)
        {
            if (kullanici != null)
            {
                KullaniciID = (int)kullanici["KullaniciID"];
                AdSoyad = kullanici["AdSoyad"].ToString();
                Rol = kullanici["Rol"].ToString();
            }
        }
    }
}
