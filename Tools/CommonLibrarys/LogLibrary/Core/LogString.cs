using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger
{
    public class LogString
    {
        ILogTimeHandler timeHandler;
        LogType type = LogType.Write;
        string logo = ">>";
        const string TIME_FORMAT_STRING = "yyyy-MM-dd HH:mm:ss.fff";

        internal void SetTimeHandler(ILogTimeHandler timeHandler)
        {
            if (timeHandler == null)
            {
                this.timeHandler = new DefaultTimeHandler();
            }
            else
            {
                this.timeHandler = timeHandler;
            }
        }

        DateTime now = DateTime.Now;
        internal void SetLogo(string logo)
        {
            if (logo == null)
            {
                return;
            }
            this.logo = logo;
        }

        internal string Format(object obj, LogType type)
        {
            string nowStr = timeHandler.Now().ToString(TIME_FORMAT_STRING);
            string info = string.Format("{0}{1}{2} {3}", nowStr, logo, type, obj);
            return info;
        }
    }
}
