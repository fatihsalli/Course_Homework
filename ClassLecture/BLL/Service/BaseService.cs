using DataAccess.Container;
using DataAccess.Context;
using DataAccess.Entity;
using DataAccess.SingletonDb;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Service
{
    public class BaseService<T> where T: BaseClass
    {
        public string DataTransmission(List<T> list)
        {          
            foreach (T entity in list)
            {
                ProjectDbSingleton.Context.Set<T>().Add(entity);
                ProjectDbSingleton.Context.SaveChanges();
            }

            return $"{typeof(T)} tipindeki veriler eklenmiştir.";
        }

        public List<T> GetAll()
        {
            return ProjectDbSingleton.Context.Set<T>().ToList();
        }

        


    }
}
