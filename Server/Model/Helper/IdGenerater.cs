using System;
using System.Collections.Generic;
using System.Text;

namespace Model.Helper
{
    class IdGenerater
    {
        private static long appId;
        public static long AppId
        {
            set
            {
                appId = value;
                instanceId = appId << 48;
            }
        }

        private static long instanceId;
        private static ushort value;

        public static long GenerateId()
        {
            long time = TimeHelper.NowSeconds();

            return (appId << 48) + (time << 16) + ++value;
        }

        public static int GetAppId(long v)
        {
            return (int)(v >> 48);
        }

        public static long GenerateInstanceId()
        {
            return ++instanceId;
        }

    }
}
