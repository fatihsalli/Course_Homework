using DataAccess.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.ServiceRepository
{
    public interface IService<T> where T:BaseClass
    {
        List<T> GetList();
        string Create(T entity);
        T GetById(int id);
        string Delete(int id);
        string Update(T entity);


    }
}
