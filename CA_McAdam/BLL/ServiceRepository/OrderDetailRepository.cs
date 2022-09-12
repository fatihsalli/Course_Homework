using DataAccess.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.ServiceRepository
{
    public class OrderDetailRepository : BaseService<OrderDetail>
    {

        public string TotalIncome()
        {
            var income = from d1 in db.OrderDetails
                         join d2 in db.Products on d1.ProductId equals d2.Id
                         select new
                         {
                             d1.Id,
                             d2.ProductName,
                             d1.Quantity,
                             d2.UnitPrice
                         };

            decimal totalIncome = 0;
            foreach (var item in income)
            {
                totalIncome += item.UnitPrice * item.Quantity;
            }
            return $"Toplam Ciro: {totalIncome} TL (KDV Dahil)";
        }

        public string CountOrder()
        {
            return $"Toplam sipariş adeti: {db.OrderDetails.Count()}";
        }

        public string ExtraOrderIncome()
        {
            var income = from d1 in db.OrderDetails
                         join d2 in db.Products on d1.ProductId equals d2.Id
                         join d3 in db.Categories on d2.CategoryId equals d3.Id
                         where d3.Id != 1
                         select new
                         {
                             d1.Id,
                             d2.ProductName,
                             d1.Quantity,
                             d2.UnitPrice,
                             d3.CategoryName
                         };
            decimal totalIncome = 0;
            foreach (var item in income)
            {
                totalIncome += item.UnitPrice * item.Quantity;
            }
            return $"Menü Dışı Toplam Ciro: {totalIncome} TL (KDV Dahil)";

        }
    }
}
