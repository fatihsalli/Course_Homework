using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entity
{
    public class Topic:BaseClass
    {
        public string TopicName { get; set; }
        public Student Student { get; set; }
    }
}
