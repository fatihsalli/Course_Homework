using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entity
{
    public class Student:BaseClass
    {
        public string FirstName { get; set; }
        public string Lastname { get; set; }
        public int TopicId { get; set; }
        public Topic Topic { get; set; }
        public bool IsLecture { get; set; }
        public DateTime LectureDate { get; set; }

    }
}
