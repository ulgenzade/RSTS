using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestoranOtomasyon
{
    public class SiparisUrunModel
    {
        public string UrunAdi { get; set; }
        public int Adet { get; set; }
        public decimal BirimFiyat { get; set; }

        public decimal AraToplam
        {
            get { return Adet * BirimFiyat; }
        }
    }
}
