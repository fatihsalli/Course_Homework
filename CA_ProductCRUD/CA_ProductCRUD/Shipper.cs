using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_ProductCRUD
{
    public class Shipper:BaseClass<Shipper>
    {
        public int Sayac { get; set; } = 1;
        public string CompanyName { get; set; }

        public override string Create()
        {
            Shipper shipper1 = new Shipper()
            {
                Id = Sayac++,
                CompanyName = "Laz Kardeşler Taşımacılık",
                IsActive = true,
            };
            Shipper shipper2 = new Shipper()
            {
                Id = Sayac++,
                CompanyName = "Ortadoğu Taşımacılık",
                IsActive = true,
            };
            Container.shipperList.Add(shipper1);
            Container.shipperList.Add(shipper2);
            return "Nakliye firması girişi yapıldı!";

        }

        public override string Delete(int id)
        {
            Shipper deleted = GetById(id);
            Container.shipperList.Remove(deleted);
            return $"{id} Nolu Nakliye Firması silindi!";
        }

        public override Shipper GetById(int id)
        {
            Shipper getShipper = null;
            foreach (Shipper s in Container.shipperList)
            {
                if (s.Id == id)
                {
                    getShipper = s;
                    break;
                }
            }
            return getShipper;
        }

        public override void GetList()
        {
            foreach (Shipper s in Container.shipperList)
            {
                Console.WriteLine(s);
            }
        }

        public override string Update(Shipper model)
        {
            Shipper updated = GetById(model.Id);
            model.CompanyName = "İkiz Kardeşler Taşımacılık";
            return $"{model.Id} Nolu Nakliye Firması güncellendi!";
        }
        public override string ToString()
        {
            return $"Nakliye Firması Id: {Id} Nakliye Firması: {CompanyName} Oluşturma tarihi: {CreatedDate} Aktif: {IsActive}";
        }



    }
}
