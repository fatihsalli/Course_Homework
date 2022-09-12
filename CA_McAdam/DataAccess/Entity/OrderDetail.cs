using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entity
{
    public class OrderDetail:BaseClass
    {
        public int ProductId { get; set; }
        public int CustomerId { get; set; }
        public int EmployeeId { get; set; }

        public int Quantity { get; set; }

        public Product Product { get; set; }
        public Customer Customer { get; set; }
        public Employee Employee { get; set; }


    }
}
