using BLL.Service;
using BLL.ServiceRepository.Concrete;
using DataAccess.Context;
using DataAccess.Entity;
using DataAccess.Enum;
using DataAccess.Singleton;
using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace Presentation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Instance
            CustomerFactoryService customerFactoryService = new CustomerFactoryService(ProjectDbSingleton.Context.Customers.ToList());
            MessageService message=new MessageService();
            BaseService<Product> baseProduct = new BaseService<Product>();
            BaseService<Customer> baseCustomer = new BaseService<Customer>();
            BaseService<Order> baseOrder = new BaseService<Order>();
            BaseService<OrderDetail> baseOrderDetail = new BaseService<OrderDetail>();
            BaseService<Category> baseCategory = new BaseService<Category>();
            BaseService<Supplier> baseSupplier = new BaseService<Supplier>();
            OrderService orderService = new OrderService();
            ReportService reportService= new ReportService();
            ProductService productService= new ProductService();
            SupplierGetInfo supplierGetInfo= new SupplierGetInfo();


            switch (message.Greeting()) //Müşteri ve admin ayrımı için
            {
                case UserType.Customer: //Müşteri alışveriş seçeneği
                    int customerId = message.GetCustomerId();
                    message.GetCustomerInfo(baseCustomer.GetById(customerId));
                    string selected = message.CategoryList(baseCategory.GetAll());
                    message.ProductList(selected);
                    Order order = orderService.GetOrder(customerId);
                    baseOrder.Create(order);
                    while (true)
                    {
                        OrderDetail orderDetail = orderService.GetOrderDetail(baseProduct.GetById(message.GetOrderProductId()), message.GetOrderCount(), customerId, customerFactoryService.GetDiscount(customerId));
                        baseOrderDetail.Create(orderDetail);
                        orderService.OrderSummary(orderDetail);
                        if (message.GetOrderProductIdContinue() == "e")
                        {
                            continue;
                        }
                        else
                        {
                            break;
                        }
                    }
                    Console.WriteLine($"Toplam sipariş tutarınız: {OrderService.totalPrice} TL");
                    break;
                case UserType.Admin: //Admin seçenekleri
                    switch (message.AdminGreeting())
                    {
                        case AdminProcess.ProductCRUD:
                            switch (message.AdminCRUD())
                            {
                                case CRUD.Create:
                                    Console.WriteLine(baseProduct.Create(productService.CreateProduct(new Product())));                          
                                    break;
                                case CRUD.Update:
                                    Console.WriteLine("Güncellemek istediğiniz id giriniz:");
                                    int valueUpdate=int.Parse(Console.ReadLine());
                                    Console.WriteLine(baseProduct.Update(productService.UpdateProduct(baseProduct.GetById(valueUpdate))));
                                    break;
                                case CRUD.Delete:
                                    Console.WriteLine("Güncellemek istediğiniz id giriniz:");
                                    int valueDelete = int.Parse(Console.ReadLine());
                                    Console.WriteLine(baseProduct.Delete(valueDelete));
                                    break;
                                case CRUD.List:
                                    foreach (Product item in baseProduct.GetAll())
                                    {
                                        Console.WriteLine($"{item.Id} {item.ProductName} {item.UnitPrice} {item.CategoryId} {item.SupplierId}");
                                    }
                                    break;
                            }
                            break;
                        case AdminProcess.SupplierInfo:
                            foreach (Supplier item in baseSupplier.GetAll())
                            {
                                Console.WriteLine($"Şirket adı:{item.CompanyName}");
                            }
                            supplierGetInfo.SupplierInfo();
                            break;
                        case AdminProcess.OrderReport:
                            Console.WriteLine(reportService.GetOrderReport());
                            break;
                    }
                    break;
            }
        }
    }
}
