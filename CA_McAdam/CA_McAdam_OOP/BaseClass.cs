using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_McAdam_OOP
{
    internal abstract class BaseClass //diğer classlara öncülük edecek olan nesnemiz
    {
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool IsActive { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal KdvIncluding
        {
            get
            {
                return UnitPrice * 1.18m;
            }
            set
            {
                UnitPrice = value;
            }
        }
        public int Count { get; set; }




    }
}
