using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger
{
    public class LogColor
    {
        public static object Write = ConsoleColor.Gray;
        public static object Error = ConsoleColor.Red;
        public static object Warn = ConsoleColor.Yellow;
        public static object Info = ConsoleColor.Green;
        public static object Debug = ConsoleColor.Magenta;
        public static object Trace = ConsoleColor.DarkMagenta;
    }
}
