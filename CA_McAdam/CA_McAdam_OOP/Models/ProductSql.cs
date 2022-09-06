using System;
using System.Collections.Generic;

#nullable disable

namespace CA_McAdam_OOP.Models
{
    public partial class ProductSql
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        public DateTime CreatedDate { get; set; }
        public int Count { get; set; }
    }
}
