using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entity
{
    public class BaseClass
    {
        public BaseClass()
        {
            CreatedDate = DateTime.Now;
            IsActive = true;
        }

        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool IsActive { get; set; }

    }
}
