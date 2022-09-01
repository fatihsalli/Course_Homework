using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_ProductCRUD
{
    public class Supplier:BaseClass<Supplier>
    {
        public int Sayac { get; set; } = 1;
        public string CompanyName { get; set; }
        public string Country { get; set; }

        public override string Create()
        {
            Supplier supplier1 = new Supplier()
            {
                Id = Sayac++,
                CompanyName = "Kardeşler Tarım",
                Country = "Turkey",
                IsActive = true,
            };
            Supplier supplier2 = new Supplier()
            {
                Id = Sayac++,
                CompanyName = "Uzak Doğu Tarım",
                Country = "Çin",
                IsActive = true,
            };
            Container.supplierList.Add(supplier1);
            Container.supplierList.Add(supplier2);
            return "Tedarikçi firma girişi yapıldı!";

        }

        public override string Delete(int id)
        {
            Supplier deleted = GetById(id);
            Container.supplierList.Remove(deleted);
            return $"{id} Nolu Tedarikçi Firma silindi!";
        }

        public override Supplier GetById(int id)
        {
            Supplier getSupplier = null;
            foreach (Supplier s in Container.supplierList)
            {
                if (s.Id == id)
                {
                    getSupplier = s;
                    break;
                }
            }
            return getSupplier;
        }

        public override void GetList()
        {
            foreach (Supplier s in Container.supplierList)
            {
                Console.WriteLine(s);
            }
        }

        public override string Update(Supplier model)
        {
            Supplier updated = GetById(model.Id);
            model.CompanyName = "Anadolu Tarım Kooperatifi";
            return $"{model.Id} Nolu Tedarikçi Firma güncellendi!";
        }
        public override string ToString()
        {
            return $"Tedarikçi Firma Id: {Id} Tedarikçi Firma: {CompanyName} Ülke: {Country} Oluşturma tarihi: {CreatedDate} Aktif: {IsActive}";
        }


    }
}
