using BLL.Service;
using BLL.ServiceRepository.Concrete;
using DataAccess.Context;
using DataAccess.Entity;
using DataAccess.Enum;
using DataAccess.Singleton;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Presentation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerFactoryService customerFactoryService = new CustomerFactoryService(ProjectDbSingleton.Context.Customers.ToList());
            MessageService message=new MessageService();
            BaseService<Product> baseProduct = new BaseService<Product>();
            BaseService<Customer> baseCustomer = new BaseService<Customer>();
            BaseService<Order> baseOrder = new BaseService<Order>();
            BaseService<OrderDetail> baseOrderDetail = new BaseService<OrderDetail>();
            BaseService<Category> baseCategory = new BaseService<Category>();
            OrderService orderService = new OrderService();
            

            message.Greeting();
            int customerId = message.GetCustomerId();
            message.GetCustomerInfo(baseCustomer.GetById(customerId));
            string selected=message.CategoryList(baseCategory.GetAll());
            message.ProductList(selected);            
            Order order = orderService.GetOrder(customerId);
            baseOrder.Create(order);

            while (true)
            {
                OrderDetail orderDetail = orderService.GetOrderDetail(baseProduct.GetById(message.GetOrderProductId()),message.GetOrderCount(),customerId,customerFactoryService.GetDiscount(customerId));
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

            Console.WriteLine($"Toplam sipariş tutarınız: {OrderService.totalPrice}");






        }
    }
}
