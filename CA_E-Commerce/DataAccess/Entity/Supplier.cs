using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entity
{
    public class Supplier:BaseClass
    {
        public string CompanyName { get; set; }
        public List<Product> Products { get; set; }
        public List<Order> Orders { get; set; }

    }
}
