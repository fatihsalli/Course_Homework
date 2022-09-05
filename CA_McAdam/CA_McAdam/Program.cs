using System;
using System.Net.Http;
using System.Xml.Linq;

namespace CA_McAdam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             //Menüler
                 --Whooper        50 TL
                 --Bigmac         55 TL
                 --McChicken      35 TL
                 --McJunior       30 TL

             //Uygulama çalıştırıldığında ekrana aşağıdaki metni gösterin.

             --McAdam'a hoşgeldin. Lütfen aşağıdan bir menü seçin:
             1-Whooper 50 TL
             2-....


             Bir Menü seçin:
             2
             Adet girin:
             2
             Sipariş oluşturulması için bilgilerinizi girin
             Ad:
             Soyad:
             Adres:
             Siparişiniz oluşturuldu. Toplam fiyat 110 TL gibi.

             */

            //string[] menuler = { "", "Whooper", "BigMac", "McChicken", "McJunior", "McTurko" };
            //int[] fiyatlar = { 0, 50, 55, 35, 30, 40 };

            //Console.WriteLine("McAdam'a Hoşgeldiniz!");

            //for (int i = 1; i < menuler.Length; i++)
            //{
            //    Console.WriteLine($"{i}-{menuler[i]} {fiyatlar[i]} TL");
            //}

            //try
            //{
            //    Console.WriteLine("Lütfen menü seçiniz.");
            //    int sayi = int.Parse(Console.ReadLine());

            //    for (int j = 0; j <= sayi; j++)
            //    {
            //        if (j == sayi && j>0)
            //        {
            //            Console.WriteLine($"Seçtiğiniz Menü: {menuler[j]} {fiyatlar[j]} TL");
            //            Console.WriteLine("Kaç adet istediğinizi giriniz.");
            //            int adet = int.Parse(Console.ReadLine());

            //            Console.WriteLine("Sipariş oluşturulması için aşağıdaki bilgilerinizi giriniz.");
            //            Console.WriteLine("Adınızı giriniz.");
            //            string ad = Console.ReadLine();
            //            Console.WriteLine("Soyadınızı giriniz.");
            //            string soyad = Console.ReadLine();
            //            Console.WriteLine("Adresinizi giriniz.");
            //            string adres = Console.ReadLine();

            //            Console.WriteLine("Siparişiniz oluşturuldu.");
            //            Console.WriteLine($"{menuler[j]} {fiyatlar[j]} TL Sipariş Adeti:{adet}");
            //            Console.WriteLine("Toplam Sipariş Tutarı:" + adet * fiyatlar[j] + "TL");
            //        }
            //        else if(sayi>=menuler.Length || sayi==0)
            //        {
            //            Console.WriteLine("Geçersiz bir değer girdiniz!");
            //            break;
            //        }
            //    }
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("Geçersiz bir değer girdiniz!");
            //}

            //string[] menuler = { "Whooper", "BigMac", "MacChicken", "McJunior" };
            //decimal[] fiyatlar = { 50, 55, 35, 30 };
            //int secilen = 0;

            //while(true)
            //{
            //    Console.WriteLine("***Mac Adam'a Hoşgeldiniz***");
            //    Console.WriteLine("****************************");
            //    for (int i = 0; i < menuler.Length; i++)
            //    {
            //        Console.WriteLine($"{i + 1}-{menuler[i]} Fiyatlar: {fiyatlar[i]} TL");
            //    }
            //    Console.WriteLine("****************************");

            //    try
            //    {
            //        Console.WriteLine("Lütfen menü seçin.(Numara Giriniz.)");
            //        secilen = int.Parse(Console.ReadLine());

            //        if(secilen>menuler.Length)
            //        {
            //            Console.WriteLine("****************************");
            //            Console.WriteLine($"Lütfen 1 ile {menuler.Length} aralığında bir değer giriniz.");
            //            Console.WriteLine("****************************");
            //        }
            //        else if(secilen<1)
            //        {
            //            Console.WriteLine("****************************");
            //            Console.WriteLine($"Lütfen 1 ile {menuler.Length} aralığında bir değer giriniz.");
            //            Console.WriteLine("****************************");
            //        }
            //        else
            //        {
            //            decimal siparisFiyat = fiyatlar[secilen - 1];

            //            Console.WriteLine("****************************");
            //            Console.WriteLine("Adet giriniz.");
            //            int adet = int.Parse(Console.ReadLine());

            //            siparisFiyat *= adet;

            //            Console.WriteLine("****************************");
            //            Console.WriteLine($"Toplam Sipariş Tutarı: {siparisFiyat} TL");
            //            Console.WriteLine("****************************");

            //            Console.WriteLine("Adınızı giriniz.");
            //            string ad = Console.ReadLine();
            //            Console.WriteLine("Soyadınızı giriniz.");
            //            string soyad = Console.ReadLine();
            //            Console.WriteLine("Adresinizi giriniz.");
            //            string adres = Console.ReadLine();

            //            Console.WriteLine($"Sipariş özeti: {ad} {soyad} {adet} adet {menuler[secilen - 1]} menü.\nToplam sipariş tutarı: {siparisFiyat} TL");
            //            break;
            //        }
            //    }
            //    catch (Exception ex)
            //    {
            //        Console.WriteLine("Error: " + ex.Message);
            //        continue;
            //    }
            //}

            //Console.Read();

            string[] menuler = { "Whooper", "BigMac", "MacChicken", "McJunior" };
            decimal[] fiyatlar = { 50, 55, 35, 30 };

            Menuler(); //Geriye değer döndürmeyen ve paramatre almayan




        }


        static void Menuler()
        {
            Console.WriteLine("***Mac Adam'a Hoşgeldiniz***");
            Console.WriteLine("****************************");
            for (int i = 0; i < menuler.Length; i++)
            {
                Console.WriteLine($"{i + 1}-{menuler[i]} Fiyatlar: {fiyatlar[i]} TL");
            }
            Console.WriteLine("****************************");
        }



















    }
}
