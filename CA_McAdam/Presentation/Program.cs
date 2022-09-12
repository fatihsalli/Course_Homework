using BLL.ServiceRepository;
using DataAccess.Entity;
using System;

namespace Presentation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayac = 0;
            Console.WriteLine("***Mac Adam'a Hoşgeldiniz****");
            BaseService<OrderDetail> serviceOrder = new();
            BaseService<Product> serviceProduct = new();
            BaseService<Customer> serviceCustomer = new();
            OrderDetailRepository odRepository = new();

            while (sayac < 1)
            {
                try
                {
                    Console.WriteLine($"Sipariş ekranı için [1]\nYönetici ekranı için [2]\nÇıkış için [3]");
                    int selected = int.Parse(Console.ReadLine());

                    switch (selected)
                    {
                        case 1:
                            Console.WriteLine($"Yeni sipariş oluşturmak için [1]\nSipariş listelemek için [2]\nSipariş güncellemek için [3]\nSipariş silmek için [4]\nÇıkış için [5]");
                            int selectedOrder = int.Parse(Console.ReadLine());

                            switch (selectedOrder)
                            {
                                case 1:
                                    Customer customer = new Customer();
                                    OrderDetail orderDetail = new OrderDetail();

                                    Console.WriteLine("Müşteri adı giriniz.");
                                    customer.FirstName = Console.ReadLine();
                                    Console.WriteLine("Müşteri soyadı giriniz.");
                                    customer.LastName = Console.ReadLine();

                                    serviceCustomer.Create(customer);

                                    foreach (Product item in serviceProduct.GetList())
                                    {
                                        Console.WriteLine($"Id: {item.Id} Ürün adı: {item.ProductName} Ürün Fiyatı: {item.UnitPrice} Kategori: {item.CategoryId}");
                                    }

                                    Console.WriteLine("Ürün Id giriniz.");
                                    orderDetail.ProductId = int.Parse(Console.ReadLine());
                                    Console.WriteLine("Adet giriniz.");
                                    orderDetail.Quantity = int.Parse(Console.ReadLine());
                                    Console.WriteLine("Çalışan Id giriniz.");
                                    orderDetail.EmployeeId = int.Parse(Console.ReadLine());
                                    orderDetail.CustomerId = customer.Id;
                                    
                                    Console.WriteLine(serviceOrder.Create(orderDetail));

                                    Console.WriteLine("Ekstra ürün girmek ister misiniz? Evet-[e] Hayır-[h]");
                                    string answer = Console.ReadLine();

                                    if (answer=="e")
                                    {
                                        OrderDetail orderDetailExtra = new OrderDetail();
                                        Console.WriteLine("Ürün Id giriniz.");
                                        orderDetailExtra.ProductId = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Adet giriniz.");
                                        orderDetailExtra.Quantity = int.Parse(Console.ReadLine());
                                        orderDetailExtra.CustomerId = customer.Id;
                                        orderDetailExtra.EmployeeId = orderDetail.EmployeeId;
                                        Console.WriteLine(serviceOrder.Create(orderDetailExtra));
                                    }
                                    else
                                    {
                                        continue;
                                    }
                                    break;
                                case 2:
                                    foreach (OrderDetail item in serviceOrder.GetList())
                                    {
                                        Console.WriteLine($"Sipariş Id:{item.Id} Ürün Id:{item.ProductId} Miktar:{item.Quantity}");
                                    }
                                    break;
                                case 3:
                                    Console.WriteLine("Güncellemek istediğiniz sipariş Id giriniz.");
                                    int answerUpdated = int.Parse(Console.ReadLine());
                                    OrderDetail odUpdated= serviceOrder.GetById(answerUpdated);
                                    Console.WriteLine("Ürün Id giriniz.");
                                    odUpdated.ProductId= int.Parse(Console.ReadLine());
                                    Console.WriteLine("Müşteri Id giriniz.");
                                    odUpdated.CustomerId = int.Parse(Console.ReadLine());
                                    Console.WriteLine("Personel Id giriniz.");
                                    odUpdated.EmployeeId = int.Parse(Console.ReadLine());
                                    Console.WriteLine("Miktar giriniz.");
                                    odUpdated.Quantity = int.Parse(Console.ReadLine());
                                    Console.WriteLine(serviceOrder.Update(odUpdated));
                                    break;
                                case 4:
                                    Console.WriteLine("Silmek istediğiniz sipariş Id giriniz.");
                                    int answerDeleted = int.Parse(Console.ReadLine());
                                    Console.WriteLine(serviceOrder.Delete(answerDeleted));
                                    break;
                                case 5:
                                    sayac++;
                                    break;
                            }
                            break;
                        case 2:
                            Console.WriteLine($"Toplam ciro için [1]\nSipariş adeti için [2]\nMenü dışındaki sipariş toplamı için [3]\nÇıkış için [4]");
                            int selected2 = int.Parse(Console.ReadLine());
                            switch (selected2)
                            {
                                case 1:
                                    Console.WriteLine(odRepository.TotalIncome());
                                    break;
                                case 2:
                                    Console.WriteLine(odRepository.CountOrder());
                                    break;
                                case 3:
                                    Console.WriteLine(odRepository.ExtraOrderIncome());
                                    break;
                                case 4:
                                    break;
                            }                     
                            break;
                        case 3:
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
