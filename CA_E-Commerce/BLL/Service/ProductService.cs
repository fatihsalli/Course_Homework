using DataAccess.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Service
{
    public class ProductService
    {
        public Product CreateProduct(Product product)
        {
            Console.WriteLine("Ürün adı giriniz:");
            product.ProductName = Console.ReadLine();
            Console.WriteLine("Ürün fiyatı giriniz:");
            product.UnitPrice = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Kategori Id giriniz:");
            product.CategoryId = int.Parse(Console.ReadLine());
            Console.WriteLine("Kategori Id giriniz:");
            product.SupplierId = int.Parse(Console.ReadLine());
            return product;
        }

        public Product UpdateProduct(Product product)
        {
            Console.WriteLine("Ürün adı giriniz:");
            product.ProductName = Console.ReadLine();
            Console.WriteLine("Ürün fiyatı giriniz:");
            product.UnitPrice = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Kategori Id giriniz:");
            product.CategoryId = int.Parse(Console.ReadLine());
            Console.WriteLine("Tedarikçi Id giriniz:");
            product.SupplierId = int.Parse(Console.ReadLine());
            return product;
        }


    }
}
