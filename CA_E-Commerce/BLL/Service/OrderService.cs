using BLL.ServiceRepository.Concrete;
using DataAccess.Entity;
using DataAccess.Singleton;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Service
{
    public class OrderService
    {
        BaseService<Product> _baseService = new BaseService<Product>();
        CustomerFactoryService customerFactoryService = new CustomerFactoryService(ProjectDbSingleton.Context.Customers.ToList());


        public Order GetOrder(int customerId)
        {
            Order order = new Order()
            {
                CustomerId = customerId
            };
            return order;
        }

        public OrderDetail GetOrderDetail(int productId, int count,int customerId)
        {
            OrderDetail orderDetail = new OrderDetail()
            {
                OrderId = ProjectDbSingleton.Context.Orders.Max(x => x.Id),
                ProductId=productId,
                Count=count,
                UnitPrice=_baseService.GetById(productId).UnitPrice*(decimal)customerFactoryService.GetDiscount(customerId),
            };
            return orderDetail;
        }






    }
}
