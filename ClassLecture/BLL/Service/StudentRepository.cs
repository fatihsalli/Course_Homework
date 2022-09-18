using DataAccess.SingletonDb;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Service
{
    public class StudentRepository
    {
        public void GetListMixed()
        {
            var list = from d1 in ProjectDbSingleton.Context.Students
                       join d2 in ProjectDbSingleton.Context.Topics on d1.TopicId equals d2.Id
                       select new
                       {
                           d1.FirstName,
                           d1.Lastname,
                           d2.Id,
                           d2.TopicName
                       };

            foreach (var item in list)
            {
                Console.WriteLine($"{item.FirstName} {item.Lastname} Konu Id:{item.Id} Konu:{item.TopicName}");
                Console.WriteLine("*************************************");
            }
        }


    }
}
