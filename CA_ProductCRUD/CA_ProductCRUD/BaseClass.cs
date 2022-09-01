using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_ProductCRUD
{
    public abstract class BaseClass<T> //Abstraction Tekniği OOP
    {
        //Properties
        public BaseClass() //Constructor Methot
        {
            CreatedDate = DateTime.Now;    
        }        
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool IsActive { get; set; }

        //Methods

        public abstract string Create();
        public abstract string Update(T model);
        public abstract string Delete(int id);
        public abstract T GetById(int id);
        public abstract void GetList();










    }
}
