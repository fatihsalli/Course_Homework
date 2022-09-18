using BLL.Service;
using BLL.ServiceRepository.Concrete;
using DataAccess.Context;
using DataAccess.Entity;
using DataAccess.Enum;
using DataAccess.Singleton;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Presentation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BaseService<Product> product = new();

            CustomerFactoryService customerFactoryService = new CustomerFactoryService(ProjectDbSingleton.Context.Customers.ToList());

            Console.WriteLine("******************************");
            Console.WriteLine("E-ticaret sitesine hoşgeldiniz");
            Console.WriteLine("******************************");

            Console.WriteLine("Hadi alışverişe başlayalım! Ürün listesi aşağıdadır.");

            //foreach (Product item in product.GetAll())
            //{
            //    Console.WriteLine($"Id:{item.Id} Ürün adı:{item.ProductName} Fiyatı:{item.UnitPrice}");
            //    Console.WriteLine("**********************");
            //}

            //Console.WriteLine("Sepete eklemek istediğiniz ürün Id'sini giriniz.");
            //int selected=int.Parse(Console.ReadLine());
            //Product product1 = product.GetById(10);

            //Console.WriteLine("Başka ürün eklemek ister misiniz? Evet[e] Hayır[h]");

            //int selected2 = int.Parse(Console.ReadLine());




            Product product1 = product.GetById(22);

            Order order = new Order()
            {
                CustomerId=6,
                
            
            };
            ProjectDbSingleton.Context.Orders.Add(order);
            ProjectDbSingleton.Context.SaveChanges();


            OrderDetail orderDetail1 = new OrderDetail()
            {
                ProductId=product1.Id,
                OrderId=ProjectDbSingleton.Context.Orders.Max(x=> x.Id),
                UnitPrice=product1.UnitPrice*(decimal)(customerFactoryService.GetDiscount(order.CustomerId)),
                Count=1
            };


            
            ProjectDbSingleton.Context.OrderDetails.Add(orderDetail1);
            ProjectDbSingleton.Context.SaveChanges();



        }
    }
}
