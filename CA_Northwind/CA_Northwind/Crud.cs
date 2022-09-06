using CA_Northwind.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace CA_Northwind
{
    internal class Crud
    {
        NorthwindContext db = new NorthwindContext();

        public string Create()
        {
            Product p = new Product();
            Console.WriteLine("Ürün adını giriniz.");
            p.ProductName = Console.ReadLine();
            Console.WriteLine("Ürün fiyatını giriniz.");
            p.UnitPrice = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Stok miktarını giriniz.");
            p.UnitsInStock = short.Parse(Console.ReadLine());

            db.Products.Add(p);
            db.SaveChanges();

            return $"{p.ProductName} ürünü ilave edildi.";
        }

        public void List()
        {
            foreach (Product p in db.Products.ToList())
            {
                Console.WriteLine($"Id:{p.ProductId} Ürün:{p.ProductName} Fiyat:{p.UnitPrice} Stok:{p.UnitsInStock}");
            };
        }

        public Product GetById(int id)
        {
            Product product = null;
            foreach (Product p in db.Products.ToList())
            {
                if (p.ProductId == id)
                {
                    product = p;
                }
            }
            return product;
        }

        public string Update(Product update)
        {
            Console.WriteLine("Ürün adını giriniz.");
            update.ProductName = Console.ReadLine();
            Console.WriteLine("Ürün fiyatını giriniz.");
            update.UnitPrice = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Stok miktarını giriniz.");
            update.UnitsInStock = short.Parse(Console.ReadLine());
            db.SaveChanges();
            return $"{update.ProductId} nolu ürün güncellendi.";
        }

        public string Delete(Product delete)
        {
            db.Products.Remove(delete);
            db.SaveChanges();
            return $"{delete.ProductId} nolu ürün silindi.";
        }





    }
}
