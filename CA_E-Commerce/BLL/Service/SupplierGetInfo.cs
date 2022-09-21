using DataAccess.Singleton;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Service
{
    public class SupplierGetInfo
    {
        public void SupplierInfo()
        {
            Console.WriteLine("Ürün listesini istediğiniz mağaza bilgisini giriniz.");
            string selected=Console.ReadLine();

            for (int i = 1; i < ProjectDbSingleton.Context.Categories.Max(x=> x.Id); i++)
            {
                var list = from d1 in ProjectDbSingleton.Context.Suppliers
                           join d2 in ProjectDbSingleton.Context.Products on d1.Id equals d2.SupplierId
                           join d3 in ProjectDbSingleton.Context.Categories on d2.CategoryId equals d3.Id
                           where d3.Id == i
                           where d1.CompanyName==selected
                           select new
                           {
                               d1.CompanyName,
                               d2.ProductName,
                               d3.CategoryName
                           };

                foreach (var item in list)
                {
                    Console.WriteLine($"Şirket Adı:{item.CompanyName} Ürün:{item.ProductName} Kategori:{item.CategoryName}");
                }

                


            }
        }
    }
}
