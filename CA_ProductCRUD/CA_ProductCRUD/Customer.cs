using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_ProductCRUD
{
    public class Customer:BaseClass<Customer>
    {
        public int Sayac { get; set; } = 1;
        public string CompanyName { get; set; }
        public string Country { get; set; }

        public override string Create()
        {
            Customer customer1 = new Customer()
            {
                Id = Sayac++,
                CompanyName = "Migros",
                Country="Turkey",
                IsActive = true,
            };
            Customer customer2 = new Customer()
            {
                Id = Sayac++,
                CompanyName = "Tesco",
                Country = "UK",
                IsActive = true,
            };
            Container.customerList.Add(customer1);
            Container.customerList.Add(customer2);
            return "Müşteri girişi yapıldı!";

        }

        public override string Delete(int id)
        {
            Customer deleted = GetById(id);
            Container.customerList.Remove(deleted);
            return $"{id} Nolu Ürün silindi!";
        }

        public override Customer GetById(int id)
        {
            Customer getCustomer = null;
            foreach (Customer cu in Container.customerList)
            {
                if (cu.Id == id)
                {
                    getCustomer = cu;
                    break;
                }
            }
            return getCustomer;
        }

        public override void GetList()
        {
            foreach (Customer c in Container.customerList)
            {
                Console.WriteLine(c);
            }
        }

        public override string Update(Customer model)
        {
            Customer updated = GetById(model.Id);
            model.CompanyName = "Bim";
            return $"{model.Id} Nolu Müşteri güncellendi!";
        }
        public override string ToString()
        {
            return $"Müşteri Id: {Id} Şirket: {CompanyName} Ülke: {Country} Oluşturma tarihi: {CreatedDate} Aktif: {IsActive}";
        }
    }
}
