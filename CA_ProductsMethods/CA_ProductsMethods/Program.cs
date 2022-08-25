using System;
using System.Collections;
using System.Data;
using System.Linq.Expressions;
using System.Reflection.Metadata.Ecma335;

namespace CA_ProductsMethods
{
    internal class Program
    {
        static ArrayList productList = new ArrayList();

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine($"Ürünler uygulamasına hoşgeldiniz.\n********************************\nÜrün eklemek için 'e' harfine\nGüncelleme yapmak için 'g' harfine\nÜrün silmek için 's' harfine\nUygulamadan çıkış için 'c' harfine basınız.");
                string secim = Console.ReadLine().ToLower();
                if (secim == "e")
                {
                    Kaydetme();
                    Listeleme();
                }
                else if (secim == "g")
                {
                    Güncelleme();
                }
                else if (secim == "s")
                {
                    Silme();
                }
                else
                {
                    break;
                }
            }

            Console.Read();

        }

        static void Kaydetme()
        {
            Products products = new Products();

            Console.WriteLine("Ürün adını giriniz.");
            products.productName = Console.ReadLine();

            Console.WriteLine("Stoktaki miktarı giriniz.");
            products.unitsInStock = int.Parse(Console.ReadLine());

            Console.WriteLine("Ürün fiyatını giriniz.");
            products.unitPrice = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Kategori adını giriniz.");
            products.categoryName = Console.ReadLine();

            Console.WriteLine("Tedarikçi adını giriniz.");
            products.supplierName = Console.ReadLine();

            productList.Add(products);
        }

        static void Listeleme()
        {
            int id = 1;

            foreach(object item in productList)
            {
                if(item is Products)
                {
                    Products gelenProduct = (Products)item;

                    string sonuc = $"Id: {id}***Ürün Adı: {gelenProduct.productName}***Stok: {gelenProduct.unitsInStock}***Fiyat: {gelenProduct.unitPrice}***Kategori Adı: {gelenProduct.categoryName}***Tedarikçi Firma: {gelenProduct.supplierName}";

                    Console.WriteLine(sonuc);
                    id++;
                }
            }
        }

        static void Güncelleme()
        {

            int sayac = 1;

            foreach (object item in productList)
            {
                Products gelenProduct = (Products)item;
               
                Console.WriteLine($"{sayac} nolu ürünü güncellemek için e/h seçiniz.");
                string secim = Console.ReadLine().ToLower();

                if (secim == "e")
                {
                    Console.WriteLine("Ürün adını giriniz.");
                    gelenProduct.productName = Console.ReadLine();

                    Console.WriteLine("Stoktaki miktarı giriniz.");
                    gelenProduct.unitsInStock = int.Parse(Console.ReadLine());

                    Console.WriteLine("Ürün fiyatını giriniz.");
                    gelenProduct.unitPrice = decimal.Parse(Console.ReadLine());

                    Console.WriteLine("Kategori adını giriniz.");
                    gelenProduct.categoryName = Console.ReadLine();

                    Console.WriteLine("Tedarikçi adını giriniz.");
                    gelenProduct.supplierName = Console.ReadLine();
                }
                else
                {
                    sayac++;
                    continue;
                }

                sayac++;
            }
        }

        static void Silme()
        {
            productList.Clear();
        }



    }
}
