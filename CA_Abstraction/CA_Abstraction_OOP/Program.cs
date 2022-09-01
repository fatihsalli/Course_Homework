using System;
using System.Collections.Generic;

namespace CA_Abstraction_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Müzik grubu kuralım

            //Eren-Bağlama
            //Emir-Elektro Gitar
            //Berkay-Bateri
            //Emre-Bas gitar
            //İbrahim - Ney
            //Meriç - Tulum
            //Özgür - Piyano

            //Nesne müzisyen ve müzik aleti

            List<Instrument> instruments = new List<Instrument>();

            Instrument instrument1=new Instrument();
            instrument1.Mark = "A Markası";
            instrument1.Model = "A Modeli";
            instrument1.Name = "Bağlama";

            instruments.Add(instrument1);

            Instrument instrument2 = new Instrument();
            instrument2.Name = "Elektro Gitar";
            instruments.Add(instrument2);

            Instrument instrument3 = new Instrument();
            instrument3.Name = "Bateri";
            instruments.Add(instrument3);

            Instrument instrument4 = new Instrument();
            instrument4.Name = "Bas Gitar";
            instruments.Add(instrument4);

            Instrument instrument5 = new Instrument();
            instrument5.Name = "Ney";
            instruments.Add(instrument5);

            Instrument instrument6 = new Instrument();
            instrument6.Name = "Tulum";
            instruments.Add(instrument6);

            Instrument instrument7 = new Instrument();
            instrument7.Name = "Piyano";
            instruments.Add(instrument7);

            Console.WriteLine("*****************");
            foreach (Instrument item in instruments)
            {
                Console.WriteLine(item.Name);
            }
            Console.WriteLine("*****************");

            List<Musician> musicians = new List<Musician>();

            Musician musician1 = new Musician();
            musician1.Instrument=instrument1;
            musician1.Firstname = "Eren";
            musicians.Add(musician1);

            Musician musician2 = new Musician();
            musician2.Instrument = instrument2;
            musician2.Firstname = "Emir";
            musicians.Add(musician2);

            Musician musician3 = new Musician();
            musician3.Instrument = instrument3;
            musician3.Firstname = "Berkay";
            musicians.Add(musician3);

            Musician musician4 = new Musician();
            musician4.Instrument = instrument4;
            musician4.Firstname = "Emre";
            musicians.Add(musician4);

            Musician musician5 = new Musician();
            musician5.Instrument = instrument5;
            musician5.Firstname = "İbrahim";
            musicians.Add(musician5);

            Musician musician6 = new Musician();
            musician6.Instrument = instrument6;
            musician6.Firstname = "Meriç";
            musicians.Add(musician6);

            Musician musician7 = new Musician();
            musician7.Instrument = instrument7;
            musician7.Firstname = "Özgür";
            musicians.Add(musician7);

            Console.WriteLine("*****************");
            foreach (Musician item in musicians)
            {
                Console.WriteLine(item.Firstname+" "+item.Instrument.Name);
            }
            Console.WriteLine("*****************");

            Console.WriteLine("Çalmak istediğiniz enstrümanı yazınız.");
            string gelen=Console.ReadLine().ToUpper();
            Console.WriteLine(Instrument.Play(gelen));


        }
    }
}
