using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_Abstraction
{
    public class Ayakkabi:Urun
    {
        public Ayakkabi()
        {
            Marka = "Adidas";
        }
        public string Marka { get; set; }
        public override decimal Kampanya()
        {
            return Fiyat*0.85m;
        }


    }
}
