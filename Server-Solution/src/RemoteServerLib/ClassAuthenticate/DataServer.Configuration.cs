using System;
using System.Collections.Generic;
using System.Text;

namespace RemoteServerLib
{
    [Serializable()]
    internal class DataServer
    {
        public static Boolean IsLocalHost
        {
            get { return true; }
        }

        public static String PrimaryIp
        {
            get { return @"192.168.3.44"; }
        }

        public static String FailOverIp
        {
            get { return PrimaryIp; }
        }

        public static String InitialCatalog
        {
            get { return @"db_lmsdev_03092010"; }
        }

        public static String UserId
        {
            get { return @"Lm$D3vL06inG3t$uMC@$h"; }
        }

        public static String Password
        {
            get { return @"85@z_uW*xM+2$c1zTK"; }
        }
    }
}
