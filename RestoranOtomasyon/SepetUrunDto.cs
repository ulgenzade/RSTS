using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestoranOtomasyon
{
    public class SepetUrunDto
    {
        public int UrunID { get; set; }
        public int Adet { get; set; }
        public decimal BirimFiyat { get; set; }
        // Ekstra bilgi gerekirse (isim gibi) buraya eklenebilir ama şimdilik bunlar yeterli.
    }
}
