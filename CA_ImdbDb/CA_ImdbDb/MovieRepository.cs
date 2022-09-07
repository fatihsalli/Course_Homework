﻿using CA_ImdbDb.Models;
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

        public string RandomMovie()
        {
            List<int> dizi = new List<int>();
            Random random = new Random();

            foreach (Movie m in db.Movies.ToList())
            {
                dizi.Add(m.Id);
            }
            int randomNumber = dizi[random.Next(0, dizi.Count)];

            var result = db.Movies.FirstOrDefault(x => x.Id==randomNumber);

            return $"Id:{result.Id} Film adı:{result.Title} Yıl:{result.Year} Puan:{result.Rating}";
        }

        public string RandomGetByRating()
        {
            List<int> dizi=new List<int>();
            Random random = new Random();

            Console.WriteLine("Puan aralığına göre rastgele film için puan aralıklarını sırasıyla entera basarak giriniz.");
            double selected1 = double.Parse(Console.ReadLine());
            double selected2 = double.Parse(Console.ReadLine());

            var result = db.Movies.Where(x => x.Rating > selected1 && x.Rating < selected2).ToList();

            foreach (Movie movie in result)
            {
                dizi.Add(movie.Id);
            }

            int randomNumber = dizi[random.Next(0,dizi.Count)];

            var result2 = db.Movies.FirstOrDefault(x => x.Id == randomNumber);

            return $"Id:{result2.Id} Film adı:{result2.Title} Yıl:{result2.Year} Puan:{result2.Rating}";
        }




    }
}