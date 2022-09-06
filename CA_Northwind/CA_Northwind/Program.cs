using CA_Northwind.Models;
using System;
using System.Linq;

namespace CA_Northwind
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Crud crud = new Crud();
            Console.WriteLine("***Northwind Dükkanına Hoşgeldiniz****");
            int sayac = 0;

            while (sayac<1)
            {
                try
                {
                    Console.WriteLine("****************************");
                    Console.WriteLine($"Yeni ürün oluşturmak için [1]\nÜrünleri listelemek için [2]\nÜrün güncellemek için [3]\nÜrün silmek için [4]\nÇıkış için [5]");
                    int selected = int.Parse(Console.ReadLine());

                    switch (selected)
                    {
                        case 1:
                            Console.WriteLine(crud.Create());
                            break;
                        case 2:
                            crud.List();
                            break;
                        case 3:
                            Console.WriteLine("Güncellemek istediğiniz Ürün Id'yi giriniz.");
                            int selectedUpdate = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine(crud.Update(crud.GetById(selectedUpdate)));
                            break;
                        case 4:
                            Console.WriteLine("Silmek istediğiniz Ürün Id'yi giriniz.");
                            int selectedDelete = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine(crud.Delete(crud.GetById(selectedDelete)));
                            break;
                        case 5:
                            sayac++;
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

        }
    }
}
