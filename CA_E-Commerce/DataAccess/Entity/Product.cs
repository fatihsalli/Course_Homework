using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entity
{
    public class Product:BaseClass
    {
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }

        //FK (Foreign Key)
        public int CategoryId { get; set; }
        public int SupplierId { get; set; }
        public Category Category { get; set; }
        public Supplier Supplier { get; set; }
        public List<Order> Orders { get; set; }

    }
}
