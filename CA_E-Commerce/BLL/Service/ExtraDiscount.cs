using DataAccess.Entity;
using DataAccess.Singleton;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Service
{
    public class ExtraDiscount
    {
        //public static int extraDiscountId { get; set; } = 0;
        //public static double extraDiscount { get; set; } = 0;

        //public int GetDiscountId()
        //{
        //    Console.WriteLine("Ekstra indirim için mağaza Id giriniz.");
        //    extraDiscountId = int.Parse(Console.ReadLine());
        //    return extraDiscountId;
        //}

        //public double GetDiscountNumber()
        //{
        //    Console.WriteLine("Ekstra indirim için indirim oranı giriniz.");
        //    extraDiscount = double.Parse(Console.ReadLine());
        //    return extraDiscount;
        //}

        //public static double GetDiscount(OrderDetail orderDetail)
        //{
        //    var list = from d1 in ProjectDbSingleton.Context.Suppliers
        //               join d2 in ProjectDbSingleton.Context.Products on d1.Id equals d2.SupplierId
        //               where d1.Id == extraDiscountId
        //               where d2.Id == orderDetail.ProductId
        //               select new
        //               {
        //                   d1.Id,
        //               };

        //    foreach (var item in list)
        //    {
        //        for (int i = 1; i < ProjectDbSingleton.Context.Suppliers.Max(x => x.Id); i++)
        //        {
        //            if (Convert.ToInt32(item) == i)
        //            {
        //                return (1 - extraDiscount);
        //                list = null;
        //            }
        //        }
        //    }
        //    return 1;
        //}





    }
}
