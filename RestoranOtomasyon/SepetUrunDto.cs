using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestoranOtomasyon
{
    // Bu sınıf, arayüzdeki sepet listesinden backend'e
    // tek bir ürün satırını taşımak için kullanılır.
    public class SepetUrunDto
    {
        public int UrunID { get; set; }
        public int Adet { get; set; }
        public decimal BirimFiyat { get; set; } // O anki fiyatı saklamak önemli
    }
}
