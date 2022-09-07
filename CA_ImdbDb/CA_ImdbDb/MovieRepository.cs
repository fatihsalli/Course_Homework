using CA_ImdbDb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_ImdbDb
{
    public class MovieRepository:Container
    {
        public void List()
        {
            foreach (Movie m in db.Movies.ToList())
            {
                Console.WriteLine($"Id:{m.Id} Film adı:{m.Title} Yıl:{m.Year} Puan:{m.Rating}");
            }
        }

        public string GetBySelectedYear()
        {
            Console.WriteLine("Hangi yıldan sonraki filmelerin listelenmesini istiyorsanız yılı giriniz.");
            int year=int.Parse(Console.ReadLine());

            var result = db.Movies.Where(x=> x.Year > year).ToList(); //Linq to Entity yöntemi

            foreach (Movie m in result)
            {
                Console.WriteLine($"Id:{m.Id} Film adı:{m.Title} Yıl:{m.Year} Puan:{m.Rating}");
            }
            return $"{result.Count} adet film listelenmiştir.";
        }

        public string GetByRating()
        {
            Console.WriteLine("Hangi puandan fazla filmelerin listelenmesini istiyorsanız puanı giriniz.");
            double rate = double.Parse(Console.ReadLine());

            var result = db.Movies.Where(x => x.Rating > rate).ToList(); //Linq to Entity yöntemi

            foreach (Movie m in result)
            {
                Console.WriteLine($"Id:{m.Id} Film adı:{m.Title} Yıl:{m.Year} Puan:{m.Rating}");
            }
            return $"{result.Count} adet film listelenmiştir.";
        }

        public string GetByDescription()
        {
            Console.WriteLine("Film açıklamaları arasında aradığınız değeri giriniz.");
            string selected = Console.ReadLine();

            var result = db.Movies.Where(x => x.Description.Contains(selected)).ToList(); //Linq to Entity yöntemi

            foreach (Movie m in result)
            {
                Console.WriteLine($"Id:{m.Id} Film adı:{m.Title} Yıl:{m.Year} Puan:{m.Rating} Açıklama: {m.Description}");
            }
            return $"{result.Count} adet film listelenmiştir.";
        }

        public string GetByGenre()
        {
            
            return $"";
        }








    }
}
