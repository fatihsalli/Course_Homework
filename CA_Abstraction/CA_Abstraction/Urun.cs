using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CA_Abstraction
{
    public class Urun
    {
        public int Id { get; set; }
        public string UrunAd { get; set; }
        public decimal Fiyat { get; set; }
        public virtual decimal Kampanya()
        {
            return Fiyat;
        }
        public static string Ozellikler = "Yaz kış uygun fiyatlı ürünler!";


    }
}
