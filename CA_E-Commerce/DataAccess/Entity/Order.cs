using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entity
{
    public class Order:BaseClass
    {
        /*[ForeignKey(nameof(Customer))]*/ //Data Annotations Yöntemi
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public List<OrderDetail> OrderDetails { get; set; }

    }
}
