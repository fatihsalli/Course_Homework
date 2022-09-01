using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_ProductCRUD
{
    public class Category:BaseClass<Category>
    {
        public int Sayac { get; set; } = 1;
        public string CategoryName { get; set; }
        public string Description { get; set; }

        public override string Create()
        {
            Category category1 = new Category()
            {
                Id=Sayac++,
                CategoryName="Meyve",
                Description="elma,armut vb.",
                IsActive = true
            };
            Category category2 = new Category()
            {
                Id = Sayac++,
                CategoryName = "Sebze",
                Description = "patlıcan,kabak vb.",
                IsActive = true
            };
            Container.categoryList.Add(category1);
            Container.categoryList.Add(category2);
            return "Kategori girişi yapıldı!";

        }

        public override string Delete(int id)
        {
            Category deleted = GetById(id);
            Container.categoryList.Remove(deleted);
            return $"{id} Nolu Kategori silindi!";
        }

        public override Category GetById(int id)
        {
            Category getCategory = null;
            foreach (Category c in Container.categoryList)
            {
                if (c.Id == id)
                {
                    getCategory = c;
                    break;
                }
            }
            return getCategory;
        }

        public override void GetList()
        {
            foreach (Category c in Container.categoryList)
            {
                Console.WriteLine(c);
            }
        }

        public override string Update(Category model)
        {
            Category updated = GetById(model.Id);
            model.CategoryName = "Taze Meyve";
            return $"{model.Id} Nolu Kategori güncellendi!";
        }
        public override string ToString()
        {
            return $"Kategori Id: {Id} Kategori adı: {CategoryName} Tanım: {Description} Oluşturma tarihi: {CreatedDate} Aktif: {IsActive}";
        }
    }
}
