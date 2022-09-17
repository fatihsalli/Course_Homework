using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entity
{
    public class Order:BaseClass
    {
        public int CustomerId { get; set; }
        public int SupplierId { get; set; }
        public Customer Customer { get; set; }
        public Supplier Supplier { get; set; }
        public Product Product { get; set; }

    }
}
