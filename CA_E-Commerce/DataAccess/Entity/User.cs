using DataAccess.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entity
{
    public class User:BaseClass
    {
        public string  Firstname { get; set; }
        public string Lastname { get; set; }
        public UserType UserType { get; set; }

    }
}
