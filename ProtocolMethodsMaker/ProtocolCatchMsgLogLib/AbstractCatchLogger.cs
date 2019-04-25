using Logger;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtocolCatchMsgLogLib
{
    public abstract class AbstractCatchLogger:IMsgCatchLogger
    {
        public bool IsOpen = false;

        protected string GetString(string format, params object[] args)
        {
            var sb = new StringBuilder();
            sb.AppendFormat(format, args);

            return sb.ToString();
        }
        public abstract void Write(object obj);

        public void Write(string format, object[] args)
        {
            if (IsOpen)
            {
                Write(GetString(format, args));
            }
        }

        public virtual void Close() {
            IsOpen = false;
        }

        public virtual void Open() {
            IsOpen = true;
        }
    }
}
