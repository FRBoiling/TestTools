using System;
using System.Collections.Generic;
using System.Text;

namespace Logger
{
    public interface ILoggerTimestamp
    {
        DateTime Now();
        string NowString();
    }
}
