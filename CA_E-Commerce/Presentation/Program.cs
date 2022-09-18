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
            MessageService message=new MessageService();
            BaseService<Product> baseProduct = new BaseService<Product>();
            BaseService<Order> baseOrder = new BaseService<Order>();
            BaseService<OrderDetail> baseOrderDetail = new BaseService<OrderDetail>();
            BaseService<Category> baseCategory = new BaseService<Category>();
            OrderService orderService = new OrderService();

            message.Greeting();
            string selected=message.CategoryList(baseCategory.GetAll());
            message.ProductList(selected);
            int customerId = message.GetCustomerId();
            Order order = orderService.GetOrder(customerId);
            baseOrder.Create(order);

            while (true)
            {
                OrderDetail orderDetail = orderService.GetOrderDetail(message.GetOrderProductId(),message.GetOrderCount(),customerId);
                baseOrderDetail.Create(orderDetail);

                if (message.GetOrderProductIdContinue() == "e")
                {
                    continue;
                }
                else
                {
                    break;
                }
            }




        }
    }
}
