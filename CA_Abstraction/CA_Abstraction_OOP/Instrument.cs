using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_Abstraction_OOP
{
    public class Instrument:Musician
    {

        public string InstrumentName { get; set; }

        public static string Play(string _ınstrument)
        {
            return $"{_ınstrument} ÇALINIYOR!";
        }



    }
}
