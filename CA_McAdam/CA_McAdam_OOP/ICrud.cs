using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_McAdam_OOP
{
    internal interface ICrud<T>
    {
        //Create
        string Create(T model);

        //List
        void List();

        //GetById
        T GetById(int id);

        //Update
        string Update(T model);

        //Delete
        string Delete(T model);

    }
}
