using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtocolCatchMsgLogLib
{
    public class DealfaultCatchLogger : AbstractCatchLogger
    {
        public string Logo = "";
        public DealfaultCatchLogger()
        {
            Logo = " >>";
        }

        public override void Write(object obj)
        {
            string nowStr = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff");
            string info = string.Format("{0}{1}[message] {2}", nowStr, Logo, obj);
            Console.WriteLine(info);
        }

    }
}
