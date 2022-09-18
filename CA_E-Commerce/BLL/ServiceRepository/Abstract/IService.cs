using DataAccess.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.ServiceRepository.Abstract
{
    public interface IService<T> where T:BaseClass
    {
        //List
        List<T> GetAll();

        //Create
        string Create(T model);

        //Update
        string Update(T model);

        //Delete
        string Delete(int id);

        //GetById
        T GetById(int id);






    }
}
