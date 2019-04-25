using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtocolCatchMsgLogLib
{
    public class MsgCatchLog
    {
        static private IMsgCatchLogger logger = new DealfaultCatchLogger();

        public static void SetGlobalLogger(IMsgCatchLogger concretelogger)
        {
            logger = concretelogger;
        }

        static public void Write(string format, params object[] args)
        {
                logger.Write(format, args);
        }

        public static void Close()
        {
            logger.Close();
        }
        public static void Open()
        {
            logger.Open();
        }
    }
}
