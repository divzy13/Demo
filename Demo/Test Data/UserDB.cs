using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Test_Data
{
    class UserDB
    {
        public static UserField user;

        public static UserField Retrieve()
        {
            var user = new UserField
            {
                Username = DataBase.GetInfo(10);
            }

            return user;
        }

    }
}
