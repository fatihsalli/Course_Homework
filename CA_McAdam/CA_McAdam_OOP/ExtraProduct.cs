using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_McAdam_OOP
{
    internal class ExtraProduct:BaseClass,ICrud<ExtraProduct>
    {
        public string ExtraProductName { get; set; } //Ekstra

        public ExtraProduct()
        {
            CreatedDate = DateTime.Now;
        }

        public string Create(ExtraProduct model)
        {
            Console.WriteLine("Ekstra yiyecek veya içecek ister misiniz? Evet-[1] Hayır-[2]");
            int selected = int.Parse(Console.ReadLine());

            if (selected==1)
            {
                Console.WriteLine("Lütfen ekstra ürün adını giriniz.");
                model.ExtraProductName = Console.ReadLine();
                model.Id = OrderDB.extraOrders.Count + 1;
                Console.WriteLine("Lütfen ekstra ürün fiyatını giriniz.");
                model.UnitPrice = int.Parse(Console.ReadLine());
                Console.WriteLine("Lütfen ekstra ürün adetini giriniz.");
                model.Count = int.Parse(Console.ReadLine());
                OrderDB.extraOrders.Add(model);
                return $"{model.ExtraProductName} ürünü için ek sipariş oluşturuldu.";
            }
            else
            {
                return $"Ek ürün olmadan sipariş tamamlanmıştır.";
            }
        }

        public string Delete(ExtraProduct model)
        {
            OrderDB.extraOrders.Remove(model);
            return $"{model.Id} nolu ekstra ürün silinmiştir.";
        }

        public ExtraProduct GetById(int id)
        {
            ExtraProduct exProduct = null;
            foreach (ExtraProduct e in OrderDB.extraOrders)
            {
                if (e.Id == id)
                {
                    exProduct = e;
                }
            }
            return exProduct;
        }

        public void List()
        {
            foreach (ExtraProduct order in OrderDB.extraOrders)
            {
                Console.WriteLine($"Id:{order.Id} Menü:{order.ExtraProductName} Kdv Dahil:{order.KdvIncluding*order.Count} Sipariş tarihi:{order.CreatedDate}");
            };
        }

        public string Update(ExtraProduct model)
        {
            Console.WriteLine("Lütfen ekstra ürün adını giriniz.");
            model.ExtraProductName = Console.ReadLine();
            Console.WriteLine("Lütfen ekstra ürün fiyatını giriniz.");
            model.UnitPrice = int.Parse(Console.ReadLine());
            Console.WriteLine("Lütfen ekstra ürün adetini giriniz.");
            model.Count = int.Parse(Console.ReadLine());
            model.CreatedDate = DateTime.Now;

            return $"{model.Id} nolu ekstra ürün güncellendi.";
        }
    }
}
