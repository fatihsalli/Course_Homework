using DataAccess.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entity
{
    public class Customer:BaseClass
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public CustomerType CustomerType { get; set; }
        public List<Order> Orders { get; set; }

    }
}
