using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entity
{
    public class Product:BaseClass
    {
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }

        /*[ForeignKey(nameof(Category))]*/ //Data Annotations Yöntemi
        public int CategoryId { get; set; }

        /*[ForeignKey(nameof(Supplier))]*/ //Data Annotations Yöntemi
        public int SupplierId { get; set; }

        public Category Category { get; set; }
        public Supplier Supplier { get; set; }
        public List<OrderDetail> OrderDetails { get; set; }

    }
}
