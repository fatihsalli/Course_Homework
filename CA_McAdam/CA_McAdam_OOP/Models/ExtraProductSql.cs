using System;
using System.Collections.Generic;

#nullable disable

namespace CA_McAdam_OOP.Models
{
    public partial class ExtraProductSql
    {
        public int Id { get; set; }
        public string ExtraProductName { get; set; }
        public decimal UnitPrice { get; set; }
        public DateTime CreatedDate { get; set; }
        public int Count { get; set; }
    }
}
