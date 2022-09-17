using BLL.ServiceRepository.Abstract;
using DataAccess.Context;
using DataAccess.Entity;
using DataAccess.Singleton;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.ServiceRepository.Concrete
{
    public class BaseService<T> : IService<T> where T : BaseClass
    {
        public string Create(T model)
        {
            ProjectDbSingleton.Context.Set<T>().Add(model);
            ProjectDbSingleton.Context.SaveChanges();
            return $"{model.Id} nolu veri girişi yapıldı.";
        }

        public string Delete(int id)
        {
            var deleted = GetById(id);
            ProjectDbSingleton.Context.Set<T>().Remove(deleted);
            ProjectDbSingleton.Context.SaveChanges();
            return $"{id} nolu veri silindi.";
        }

        public List<T> GetAll()
        {
            return ProjectDbSingleton.Context.Set<T>().ToList();
        }

        public T GetById(int id)
        {
            var model = ProjectDbSingleton.Context.Set<T>().Find(id);
            return model;
        }

        public string Update(T model)
        {
            ProjectDbSingleton.Context.Entry(model).State=Microsoft.EntityFrameworkCore.EntityState.Modified;
            ProjectDbSingleton.Context.SaveChanges();
            return $"{model.Id} nolu veri güncellendi.";
        }
    }
}
