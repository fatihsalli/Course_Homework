using BLL.Service;
using BLL.ServiceRepository.Concrete;
using DataAccess.Entity;
using DataAccess.Enum;
using System;
using System.Collections.Generic;

namespace Presentation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BaseService<Product> product = new();

            Console.WriteLine("******************************");
            Console.WriteLine("E-ticaret sitesine hoşgeldiniz");
            Console.WriteLine("******************************");

            Console.WriteLine("Hadi alışverişe başlayalım! Ürün listesi aşağıdadır.");

            foreach (Product item in product.GetAll())
            {
                Console.WriteLine($"Id:{item.Id} Ürün adı:{item.ProductName}");
            }



        }
    }
}
