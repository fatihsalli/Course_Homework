using BLL.ServiceRepository.Concrete;
using DataAccess.Entity;
using DataAccess.Enum;
using DataAccess.Singleton;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace BLL.Service
{
    public class MessageService
    {
        public UserType Greeting()
        {
            Console.WriteLine("*******************************");
            Console.WriteLine("E-ticaret sitesine hoşgeldiniz!");
            Console.WriteLine("Müşteri girişi için [1]");
            Console.WriteLine("Yönetici girişi için [2]");
            Console.WriteLine("*******************************");
            int selected = int.Parse(Console.ReadLine());
            if (selected == 1)
            {
                return UserType.Customer;
            }
            else
            {
                return UserType.Admin;
            }
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
            string selected = Console.ReadLine();
            return selected;
        }

        public void ProductList(string selected)
        {
            Console.WriteLine("Seçtiğiniz Kategoride Ürün listesi aşağıdadır.");

            var list = from d1 in ProjectDbSingleton.Context.Products
                       join d2 in ProjectDbSingleton.Context.Categories on d1.CategoryId equals d2.Id
                       where d2.CategoryName == selected
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

        public void GetCustomerInfo(Customer customer)
        {
            Console.WriteLine("************************");
            Console.WriteLine($"{customer.Firstname} {customer.Lastname} hoşgeldiniz.");
            Console.WriteLine($"Müşteri seviyeniz: {customer.CustomerType}");
            Console.WriteLine("************************");
        }

        public AdminProcess AdminGreeting()
        {
            Console.WriteLine("*******************************");
            Console.WriteLine("Yönetici paneline hoşgeldiniz!");
            Console.WriteLine("Ürün CRUD işlemleri için [1]");
            Console.WriteLine("Kategori CRUD işlemleri için [2]");
            Console.WriteLine("Satış raporları için [3]");
            Console.WriteLine("*******************************");
            int selected = int.Parse(Console.ReadLine());
            if (selected == 1)
            {
                return AdminProcess.ProductCRUD;
            }
            else if (selected == 2)
            {
                return AdminProcess.CategoryCRUD;
            }
            else
            {
                return AdminProcess.OrderReport;
            }
        }

        public CRUD AdminCRUD()
        {
            Console.WriteLine("*******************************");
            Console.WriteLine("Yönetici paneline hoşgeldiniz!");
            Console.WriteLine("Ekleme işlemleri için [1]");
            Console.WriteLine("Güncelleme işlemleri için [2]");
            Console.WriteLine("Silme işlemleri için [3]");
            Console.WriteLine("Listeleme işlemleri için [4]");
            int selected = int.Parse(Console.ReadLine());
            if (selected == 1)
            {
                return CRUD.Create;
            }
            else if (selected == 2)
            {
                return CRUD.Update;
            }
            else if(selected == 3)
            {
                return CRUD.Delete;
            }
            else
            {
                return CRUD.List;
            }
        }


    }
}
