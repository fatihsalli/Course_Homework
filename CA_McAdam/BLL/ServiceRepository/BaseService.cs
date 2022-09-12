using DataAccess.Context;
using DataAccess.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.ServiceRepository
{
    public class BaseService<T> : IService<T> where T : BaseClass
    {
        McAdamDbContext db = new McAdamDbContext();

        public string Create(T entity)
        {
            db.Set<T>().Add(entity);
            db.SaveChanges();
            return $"{entity.Id} nolu veri girişi yapılmıştır.";
        }

        public string Delete(int id)
        {
            db.Set<T>().Remove(GetById(id));
            db.SaveChanges();
            return $"{id} nolu veri silinmiştir.";
        }

        public T GetById(int id)
        {
            T entity = db.Set<T>().Find(id);
            return entity;
        }

        public List<T> GetList()
        {
            return db.Set<T>().ToList();
        }

        public string Update(T entity)
        {
            db.Entry(entity).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            db.SaveChanges();
            return $"{entity.Id} nolu veri güncellenmiştir.";
        }
    }
}
