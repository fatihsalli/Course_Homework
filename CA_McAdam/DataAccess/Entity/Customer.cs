using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entity
{
    public class Customer:BaseClass
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<OrderDetail> OrderDetails { get; set; }

    }
}
