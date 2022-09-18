using DataAccess.Container;
using DataAccess.Context;
using DataAccess.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Service
{
    public class AttachService
    {
        public int[] RandomNumber()
        {
            int[] dizi = new int[18];
            Random random = new Random();

            for (int i = 0; i < dizi.Length; i++)
            {                
                dizi[i] = random.Next(1, 21);

                for (int j = 0; j < i; j++)
                {
                    if (dizi[i] == dizi[j])
                    {
                        i--;
                        break;
                    }
                }
            }
            return dizi;
        }

        public List<Student> AttachTopic(List<Student> students)
        {
            int i = 0;
            foreach (Student item in students)
            {
                item.TopicId = RandomNumber()[i];
            }
            return students;
        }

        




    }
}
