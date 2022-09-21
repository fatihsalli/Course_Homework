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
        private static int extraDiscountId { get; set; } = 0;
        private static double extraDiscount { get; set; } = 0;

        public int GetDiscountId()
        {
            Console.WriteLine("Ekstra indirim için mağaza Id giriniz.");
            extraDiscountId = int.Parse(Console.ReadLine());
            return extraDiscountId;
        }

        public double GetDiscountNumber()
        {
            Console.WriteLine("Ekstra indirim için indirim oranı giriniz.");
            extraDiscount = double.Parse(Console.ReadLine());
            return extraDiscount;
        }

        public List<int> GetExtraDiscount()
        {
            List<int> discountProduct = new List<int>();
            var list = from d1 in ProjectDbSingleton.Context.Suppliers
                       join d2 in ProjectDbSingleton.Context.Products on d1.Id equals d2.SupplierId
                       where d1.Id == extraDiscountId
                       select new
                       {
                           d2.Id,
                       };
            foreach (var item in list)
            {
                int deger = (int)item.Id;
                discountProduct.Add(deger);
            }
            return discountProduct;           
        }

        public OrderDetail GetExtraDiscountCheck(OrderDetail orderDetail,List<int> list)
        {
            int searchId=(int)orderDetail.ProductId;
            foreach (int item in list)
            {
                if (searchId==item)
                {
                    orderDetail.UnitPrice=orderDetail.UnitPrice*(decimal)((100-extraDiscount)/100);
                }
            }
            return orderDetail;
        }


    }
}
