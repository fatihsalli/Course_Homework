using DataAccess.Context;
using DataAccess.Entity;
using DataAccess.Singleton;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Service
{
    public class ReportService
    {
        private static decimal TotalIncome=0;
        public string GetOrderReport()
        {
            foreach (OrderDetail od in ProjectDbSingleton.Context.OrderDetails.ToList())
            {
                TotalIncome += od.UnitPrice * od.Count;
            }
            return $"Toplam ciro: {TotalIncome} TL";
        }
    }
}
