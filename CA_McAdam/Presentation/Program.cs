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
            BaseService<OrderDetail> baseServiceOd = new();
            BaseService<Product> baseServicePr = new();
            BaseService<Customer> baseServiceCu = new();


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
                                    
                                    baseServiceCu.Create(customer);

                                    foreach (Product item in baseServicePr.GetList())
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
                                    
                                    Console.WriteLine(baseServiceOd.Create(orderDetail));

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
                                        Console.WriteLine(baseServiceOd.Create(orderDetailExtra));
                                    }
                                    else
                                    {
                                        continue;
                                    }
                                    break;
                                case 2:
                                    foreach (OrderDetail item in baseServiceOd.GetList())
                                    {
                                        Console.WriteLine($"Sipariş Id:{item.Id} Ürün Id:{item.ProductId} Miktar:{item.Quantity}");
                                    }



                                    break;
                                case 3:

                                    break;
                                case 4:

                                    break;
                                default:
                                    sayac++;
                                    break;
                            }





                            break;
                        case 2:

                            break;
                        case 3:

                            break;



                        default:

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
