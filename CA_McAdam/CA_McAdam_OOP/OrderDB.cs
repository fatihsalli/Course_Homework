using CA_McAdam_OOP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_McAdam_OOP
{
    internal class OrderDB
    {
        public static List<Product> productOrders = new List<Product>();
        public static List<ExtraProduct> extraOrders = new List<ExtraProduct>();

        McAdam_DBContext db = new McAdam_DBContext();

        public string SqlImport()
        {
            foreach (Product p in productOrders)
            {
                ProductSql pSql = new ProductSql();
                pSql.Id = p.Id;
                pSql.ProductName = p.ProductName;
                pSql.UnitPrice = p.KdvIncluding;
                pSql.CreatedDate = p.CreatedDate;
                pSql.Count = p.Count;
                db.ProductSqls.Add(pSql);
                db.SaveChanges();
            }
            foreach (ExtraProduct ep in extraOrders)
            {
                ExtraProductSql epSql = new ExtraProductSql();
                epSql.Id = ep.Id;
                epSql.ExtraProductName = ep.ExtraProductName;
                epSql.UnitPrice = ep.KdvIncluding;
                epSql.CreatedDate = ep.CreatedDate;
                epSql.Count = ep.Count;
                db.ExtraProductSqls.Add(epSql);
                db.SaveChanges();
            }

            return "SQL veritabanına aktarıldı!";
        }




    }
}
