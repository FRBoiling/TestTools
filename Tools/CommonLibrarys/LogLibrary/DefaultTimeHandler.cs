using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger
{
    class DefaultTimeHandler : ILogTimeHandler
    {
        public DateTime Now()
        {
            return DateTime.Now;
        }
    }
}
