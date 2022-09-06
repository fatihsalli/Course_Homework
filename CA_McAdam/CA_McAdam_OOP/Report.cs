using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_McAdam_OOP
{
    internal class Report
    {
        public string TotalIncome() 
        {
            decimal total = 0;
            foreach (Product p in OrderDB.productOrders)
            {
                total += p.KdvIncluding * p.Count;
            }
            foreach (ExtraProduct e in OrderDB.extraOrders)
            {
                total += e.KdvIncluding * e.Count;
            }
            return $"Toplam Ciro: {total} TL (KDV Dahil)";
        }

        public string CountOrder()
        {
            int count = 0;
            foreach (Product p in OrderDB.productOrders)
            {
                count++;
            }            
            return $"Toplam sipariş adeti: {count}";
        }

        public string CountExtraOrder()
        {
            int count = 0;
            foreach (ExtraProduct e in OrderDB.extraOrders)
            {
                count++;
            }
            return $"Toplam ekstra sipariş adeti: {count}";
        }

        public string ExtraOrderIncome()
        {
            decimal total = 0;
            foreach (ExtraProduct e in OrderDB.extraOrders)
            {
                total += e.KdvIncluding * e.Count;
            }
            return $"Toplam Ekstra Ürün Satışı: {total} TL (KDV Dahil)";
        }




    }
}
