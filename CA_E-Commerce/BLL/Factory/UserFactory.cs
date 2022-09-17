using DataAccess.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Factory
{
    public class UserFactory
    {
        public GetUserType FactoryMethod(UserType userType)
        {
            GetUserType user = null;

            switch (userType)
            {
                case UserType.standart:
                    user = new StandartUser();
                    break;
                case UserType.premium:
                    user = new PremiumUser();
                    break;
                case UserType.diamond:
                    user = new DiamondUser();
                    break;
            }
            return user;
        }



    }
}
