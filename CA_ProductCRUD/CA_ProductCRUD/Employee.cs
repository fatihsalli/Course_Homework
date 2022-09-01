using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_ProductCRUD
{
    public class Employee:BaseClass<Employee>
    {
        public int Sayac { get; set; } = 1;
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public override string Create()
        {
            Employee employee1 = new Employee()
            {
                Id = Sayac++,
                FirstName = "Fatih",
                LastName = "Şallı",
                IsActive = true,
            };
            Employee employee2 = new Employee()
            {
                Id = Sayac++,
                FirstName = "Kazım",
                LastName = "Yerebakan",
                IsActive = true,
            };
            Container.employeeList.Add(employee1);
            Container.employeeList.Add(employee2);
            return "Personel girişi yapıldı!";

        }

        public override string Delete(int id)
        {
            Employee deleted = GetById(id);
            Container.employeeList.Remove(deleted);
            return $"{id} Nolu Personel silindi!";
        }

        public override Employee GetById(int id)
        {
            Employee getEmployee = null;
            foreach (Employee em in Container.employeeList)
            {
                if (em.Id == id)
                {
                    getEmployee = em;
                    break;
                }
            }
            return getEmployee;
        }

        public override void GetList()
        {
            foreach (Employee em in Container.employeeList)
            {
                Console.WriteLine(em);
            }
        }

        public override string Update(Employee model)
        {
            Employee updated = GetById(model.Id);
            model.FirstName = "Bülent";
            return $"{model.Id} Nolu Personel güncellendi!";
        }
        public override string ToString()
        {
            return $"Personel Id: {Id} Adı-Soyadı: {FirstName} {LastName} Oluşturma tarihi: {CreatedDate} Aktif: {IsActive}";
        }

    }
}
