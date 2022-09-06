using System;

namespace CA_McAdam_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product();
            ExtraProduct extraProduct = new ExtraProduct();
            Report report = new Report();
            int sayac = 0;
            Console.WriteLine("***Mac Adam'a Hoşgeldiniz****");

            while (sayac<1)
            {
                try
                {
                    Console.WriteLine($"Yeni sipariş oluşturmak için [1]\nSipariş listelemek için [2]\nSipariş güncellemek için [3]\nSipariş silmek için [4]\nRaporlama için [5]\nSql veritabanına aktarmak için [6]\nÇıkış için [7]");
                    int selected = int.Parse(Console.ReadLine());

                    switch (selected)
                    {
                        case 1:
                            Product newProduct = new Product();
                            ExtraProduct newExtraProduct = new ExtraProduct();
                            product.Create(newProduct);
                            extraProduct.Create(newExtraProduct);
                            break;
                        case 2:
                            product.List();
                            extraProduct.List();
                            break;
                        case 3:
                            Console.WriteLine("Siparişi güncellemek istediğiniz Id'yi seçiniz.");
                            int selectedUpdate = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine(product.Update(product.GetById(selectedUpdate)));
                            Console.WriteLine("Ekstra ürünü de güncellemek ister misiniz? Evet-[1] Hayır-[2]");
                            int selectedUpdateEx = Convert.ToInt32(Console.ReadLine());
                            if (selectedUpdateEx==1)
                            {
                                Console.WriteLine(extraProduct.Update(extraProduct.GetById(selectedUpdateEx)));
                            }
                            else
                            {
                                continue;
                            }
                            break;
                        case 4:
                            Console.WriteLine("Siparişi silmek istediğiniz Id'yi seçiniz.");
                            int selectedDelete = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine(product.Delete(product.GetById(selectedDelete)));
                            Console.WriteLine(extraProduct.Delete(extraProduct.GetById(selectedDelete)));

                            break;
                        case 5:
                            Console.WriteLine(report.TotalIncome());
                            Console.WriteLine(report.CountOrder());
                            Console.WriteLine(report.CountExtraOrder());
                            Console.WriteLine(report.ExtraOrderIncome());
                            break;
                        case 6:
                            OrderDB orderDB = new OrderDB();
                            Console.WriteLine(orderDB.SqlImport());
                            break;
                        case 7:
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
