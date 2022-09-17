using DataAccess.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Factory
{
    public class CustomerFactory
    {
        public GetCustomerType FactoryMethod(CustomerType customerType)
        {
            GetCustomerType customer = null;

            switch (customerType)
            {
                case CustomerType.standart:
                    customer = new StandartCustomer();
                    break;
                case CustomerType.premium:
                    customer = new PremiumCustomer();
                    break;
                case CustomerType.diamond:
                    customer = new DiamondCustomer();
                    break;
            }
            return customer;
        }



    }
}
