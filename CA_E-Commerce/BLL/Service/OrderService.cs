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
        public static decimal totalPrice=0;
        public Order GetOrder(int customerId)
        {
            Order order = new Order()
            {
                CustomerId = customerId
            };
            return order;
        }

        public OrderDetail GetOrderDetail(Product product, int count,int customerId,double discount)
        {
            OrderDetail orderDetail = new OrderDetail()
            {
                OrderId = ProjectDbSingleton.Context.Orders.Max(x => x.Id),
                ProductId=product.Id,
                Count=count,
                UnitPrice=product.UnitPrice*(decimal)discount
            };
            return orderDetail;
        }

        public decimal OrderSummary(OrderDetail orderDetail)
        {
            totalPrice += orderDetail.UnitPrice * orderDetail.Count;
            return totalPrice;
        }




    }
}
