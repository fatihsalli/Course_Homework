using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace CA_McAdam_OOP
{
    internal class Product:BaseClass,ICrud<Product>
    {
        public Product()
        {
            CreatedDate=DateTime.Now;
        }

        
        public string ProductName { get; set; } //Menü


        public string Create(Product model)
        {
            Console.WriteLine("Lütfen menü adını giriniz.");
            model.ProductName = Console.ReadLine();
            model.Id = OrderDB.productOrders.Count+1;
            Console.WriteLine("Lütfen menü fiyatını giriniz.");
            model.UnitPrice = int.Parse(Console.ReadLine());
            Console.WriteLine("Lütfen adet giriniz.");
            model.Count = int.Parse(Console.ReadLine());
            Console.WriteLine($"Menü boyutunu seçiniz. {Size.Small}-(1)  {Size.Medium}-(2)  {Size.Large}-(3)");
            int secim = Convert.ToInt32(Console.ReadLine());

            switch (secim)
            {
                case 1:
                    break;
                case 2:
                    model.UnitPrice = model.UnitPrice + 5;
                    break;
                case 3:
                    model.UnitPrice = model.UnitPrice + 10;
                    break;
                default:
                    Console.WriteLine("Hatalı bir değer girdiniz.");
                    break;
            }

            OrderDB.productOrders.Add(model);
            return $"{model.ProductName} Menü siparişi oluşturuldu.";
        }

        public void List()
        {
            foreach (Product order in OrderDB.productOrders)
            {
                Console.WriteLine($"Id:{order.Id} Menü:{order.ProductName} Kdv Dahil:{order.KdvIncluding*order.Count} Sipariş tarihi:{order.CreatedDate}");
            };
        }

        public Product GetById(int id)
        {
            Product product=null;
            foreach (Product p in OrderDB.productOrders)
            {
                if (p.Id==id)
                {
                    product = p;
                }
            }
            return product;
        }

        public string Update(Product model)
        {
            Console.WriteLine("Lütfen menü adını giriniz.");
            model.ProductName = Console.ReadLine();
            Console.WriteLine("Lütfen menü fiyatını giriniz.");
            model.UnitPrice = int.Parse(Console.ReadLine());
            Console.WriteLine("Lütfen adet giriniz.");
            model.Count = int.Parse(Console.ReadLine());
            Console.WriteLine($"Menü boyutunu seçiniz. {Size.Small}-(1)  {Size.Medium}-(2)  {Size.Large}-(3)");
            int secim = Convert.ToInt32(Console.ReadLine());
            model.CreatedDate=DateTime.Now;

            switch (secim)
            {
                case 1:
                    break;
                case 2:
                    model.UnitPrice = model.UnitPrice + 5;
                    break;
                case 3:
                    model.UnitPrice = model.UnitPrice + 10;
                    break;
                default:
                    Console.WriteLine("Hatalı bir değer girdiniz.");
                    break;
            }
            return $"{model.Id} nolu ürün güncellendi.";
        }

        public string Delete(Product model)
        {
            OrderDB.productOrders.Remove(model);
            return $"{model.Id} nolu ürün silinmiştir.";
        }
    }
}
