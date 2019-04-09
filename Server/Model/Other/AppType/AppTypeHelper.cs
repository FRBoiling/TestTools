using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public static class AppTypeHelper
    {
        public static List<AppType> GetServerTypes()
        {
            List<AppType> appTypes = new List<AppType> { AppType.Manager, AppType.Realm, AppType.Gate };
            return appTypes;
        }

        public static bool Is(this AppType a, AppType b)
        {
            if ((a & b) != 0)
            {
                return true;
            }
            return false;
        }
    }
}
