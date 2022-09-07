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
            List<int> dizi = new List<int>();
            List<int> dizi2 = new List<int>();
            Movie m = null;

            Console.WriteLine("Hangi tür film istiyorsanız yazınız.");
            string selected = Console.ReadLine();

            var result = db.Genres.Where(x => x.Name.Contains(selected)).ToList();

            foreach (Genre g in result)
            {
                dizi.Add(g.Id);
            }

            foreach (var item in db.MovieGenres.ToList())
            {
                if (item.GenreId == dizi[0])
                {
                    dizi2.Add(item.MovieId);
                }
            }

            foreach (int i in dizi2)
            {
                m=db.Movies.FirstOrDefault(x => x.Id == i);
                Console.WriteLine($"Id:{m.Id} Film adı:{m.Title} Yıl:{m.Year} Puan:{m.Rating}");
            }
            return $"{dizi2.Count} adet film listelenmiştir.";
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

        public string GetByGenreM()
        {
            List<int> dizi = new List<int>();
            List<int> dizi2 = new List<int>();
            List<int> dizi3 = new List<int>();
            List<Movie> movies = new List<Movie>();
            Movie m = null;

            Console.WriteLine("Hangi tür filmler istiyorsanız sırasıyla yazınız.");
            string selected = Console.ReadLine();
            string selected2 = Console.ReadLine();

            Genre result = db.Genres.FirstOrDefault(x => x.Name.Contains(selected));
            Genre result2 = db.Genres.FirstOrDefault(x => x.Name.Contains(selected2));

            dizi.Add(result.Id);
            dizi.Add(result2.Id);

            foreach (var item in db.MovieGenres.ToList())
            {
                if (item.GenreId == dizi[0])
                {
                    dizi2.Add(item.MovieId);
                }
                else if (item.GenreId == dizi[1])
                {
                    dizi3.Add(item.MovieId);
                }
            }

            foreach (int i in dizi2)
            {
                if (dizi3.Contains(i))
                {
                    m = db.Movies.FirstOrDefault(x => x.Id == i);
                    Console.WriteLine($"Id:{m.Id} Film adı:{m.Title} Yıl:{m.Year} Puan:{m.Rating}");
                    movies.Add(m);
                }
                
            }
            return $"{movies.Count} adet film listelenmiştir.";
        }


    }
}
