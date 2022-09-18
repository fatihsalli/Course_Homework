using BLL.ServiceRepository.Concrete;
using DataAccess.Entity;
using DataAccess.Singleton;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Service
{
    public class MessageService
    {
        public void Greeting()
        {
            Console.WriteLine("*******************************");
            Console.WriteLine("E-ticaret sitesine hoşgeldiniz!");
            Console.WriteLine("*******************************");
        }

        public string CategoryList(List<Category> categories)
        {
            Console.WriteLine("Hadi alışverişe başlayalım! Kategori Listesi aşağıdadır.");
            Console.WriteLine("*******************************");
            foreach (Category c in categories)
            {
                Console.WriteLine($"{c.CategoryName}");
                Console.WriteLine("*******************************");
            }

            Console.WriteLine("Hangi kategoride ürün arıyorsunuz lütfen yazınız.");
            string selected=Console.ReadLine();
            return selected;
        }

        public void ProductList(string selected)
        {
            Console.WriteLine("Seçtiğiniz Kategoride Ürün listesi aşağıdadır.");

            var list = from d1 in ProjectDbSingleton.Context.Products
                       join d2 in ProjectDbSingleton.Context.Categories on d1.CategoryId equals d2.Id
                       where d2.CategoryName==selected
                       select new
                       {
                           d1.Id,
                           d1.ProductName,
                           d1.UnitPrice,
                           d2.CategoryName
                       };

            foreach (var item in list)
            {
                Console.WriteLine($"Id:{item.Id} Ürün:{item.ProductName} Fiyat:{item.UnitPrice} TL Kategori: {item.CategoryName}");
                Console.WriteLine("*******************************");
            }
        }

        public int GetOrderProductId()
        {
            Console.WriteLine("*******************************************");
            Console.WriteLine("Sepete eklemek istediğiniz ürün id seçiniz.");
            Console.WriteLine("*******************************************");
            int selected = int.Parse(Console.ReadLine());
            return selected;
        }

        public int GetOrderCount()
        {
            Console.WriteLine("******************************");
            Console.WriteLine("Bu üründen kaç adet istersiniz?");
            Console.WriteLine("******************************");
            int selected = int.Parse(Console.ReadLine());
            return selected;
        }

        public string GetOrderProductIdContinue()
        {
            Console.WriteLine("********************************************");
            Console.WriteLine("Sepete yeni ürün eklemek ister misiniz? Evet-[e] Hayır-[h]");
            Console.WriteLine("********************************************");
            string selected = Console.ReadLine();
            return selected;
        }

        public int GetCustomerId()
        {
            Console.WriteLine("************************");
            Console.WriteLine("Müşteri Id'nizi giriniz.");
            Console.WriteLine("************************");
            int selected = int.Parse(Console.ReadLine());
            return selected;
        }



    }
}
