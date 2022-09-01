using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_Abstraction_OOP
{
    public class Instrument:Musician
    {
        public string Mark { get; set; }
        public string Model { get; set; }
        public string Name { get; set; }

        public static string Play(string _ınstrument)
        {
            return $"{_ınstrument} ÇALINIYOR!";
        }



    }
}
