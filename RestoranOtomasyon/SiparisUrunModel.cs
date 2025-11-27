using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestoranOtomasyon
{
    public class SiparisUrunModel
    {
        // Hata veren eksik kısım burasıydı:
        public int UrunID { get; set; }

        public string UrunAdi { get; set; }
        public int Adet { get; set; }
        public decimal BirimFiyat { get; set; }

        // Hata veren "Atama yapılamaz" kısmı için buraya 'set' ekledik:
        public decimal AraToplam { get; set; }
    }
}