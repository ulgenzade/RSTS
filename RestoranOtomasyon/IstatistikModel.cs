using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestoranOtomasyon
{
    public class IstatistikModel
    {
        public decimal GunlukCiro { get; set; }
        public int GunlukSatisAdeti { get; set; }

        public decimal AylikCiro { get; set; }
        public int AylikSatisAdeti { get; set; }

        public decimal YillikCiro { get; set; }
        public int YillikSatisAdeti { get; set; }

        public decimal ToplamCiro { get; set; }
        public int ToplamSatisAdeti { get; set; }
    }
}
