using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CA_ProductCRUD
{
    public class Product:BaseClass<Product>
    {
        public int Sayac { get; set; } = 1;
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        public int UnitsInStock { get; set; }

        /// <summary>
        /// Ürün eklemek için kullanılır. Kendi içinde classları instance yapıp değerlerin girişini sağlar aynı zamanda listeye gönderir.Değer kullanıcıdan da alınabilir.
        /// </summary>
        /// <returns></returns>
        public override string Create()
        {
            Product product1 = new Product()
            {
                Id = Sayac++,
                ProductName = "Elma",
                UnitPrice = 15,
                UnitsInStock = 25,
                IsActive = true,
            };
            Product product2 = new Product()
            {
                Id = Sayac++,
                ProductName = "Armut",
                UnitPrice = 22,
                UnitsInStock = 10,
                IsActive = true,
            };
            Container.productList.Add(product1);
            Container.productList.Add(product2);
            return "Ürün girişi yapıldı!";

        }

        /// <summary>
        /// Silmek için kullanılır. Silinecek id nin parantez içine yazılması gerekir.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public override string Delete(int id)
        {
            Product deleted = GetById(id);
            Container.productList.Remove(deleted);
            return $"{id} Nolu Ürün silindi!";
        }

        /// <summary>
        /// Id'ye göre listedeki classı bulup onun üzerinden update veya delete işlemlerini yapabilmemizi sağlar.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public override Product GetById(int id)
        {
            Product getProduct =null;
            foreach (Product p in Container.productList)
            {
                if(p.Id == id)
                {
                    getProduct = p;
                    break;
                }
            }
            return getProduct;
        }

        /// <summary>
        /// Listeleme için kullanılır.
        /// </summary>
        public override void GetList()
        {
            foreach (Product p in Container.productList)
            {
                Console.WriteLine(p);
            }            
        }

        /// <summary>
        /// Ürünleri güncellemek için kullanılır. GetById methodundan aldığı classı revize eder.
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public override string Update(Product model)
        {
            Product updated=GetById(model.Id);
            model.ProductName = "Kivi";
            return $"{model.Id} Nolu Ürün güncellendi!";
        }

        public override string ToString()
        {
            return $"Ürün Id: {Id} Ürün adı: {ProductName} Ürün Fiyatı: {UnitPrice} Stok: {UnitsInStock} Oluşturma tarihi: {CreatedDate} Aktif: {IsActive}";
        }



    }
}
