using BLL.Factory;
using DataAccess.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Service
{
    public class CustomerFactoryService
    {
        private List<Customer> _customers;
        public CustomerFactoryService(List<Customer>customers)
        {
            _customers = customers;
        }

        public double GetDiscount(int customerId)
        {
            CustomerFactory customerFactory = new CustomerFactory();
            double discount = 0;

            foreach (Customer customer in _customers)
            {
                if (customer.Id == customerId)
                {
                    GetCustomerType userType = customerFactory.FactoryMethod(customer.CustomerType);
                    discount = userType.CustomerDiscount();
                    break;
                }
            }
            return discount;
        }




    }
}
