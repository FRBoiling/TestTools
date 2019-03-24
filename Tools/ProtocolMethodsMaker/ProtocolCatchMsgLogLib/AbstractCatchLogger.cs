﻿using Logger;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtocolCatchMsgLogLib
{
    public abstract class AbstractCatchLogger:IMsgCatchLogger
    {
        protected string GetString(string format, params object[] args)
        {
            var sb = new StringBuilder();
            sb.AppendFormat(format, args);

            return sb.ToString();
        }
        public abstract void Write(object obj);

        public void Write(string format, object[] args)
        {
			Write(GetString(format, args));
        }

        public abstract void Close();

    }
}
