using System;
using System.Collections.Generic;
using System.Text;

namespace Logger
{
    public class DeafaultLogger : AbstractLogger
    {
        public string Logo = "";

        public DeafaultLogger()
        {
            Logo = " >>";
        }

        public override void Alert(object obj)
        {
            AlertLine(obj);
        }

        public override void AlertLine(object obj)
        {
            string nowStr = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff");
            string info = string.Format("{0}{1}[ALERT] {2}", nowStr, Logo, obj);
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(info);
            Console.ResetColor();
        }

        public override void Close()
        {
            Console.WriteLine("deafault log close");
        }

        public override void Debug(object obj)
        {
            DebugLine(obj);
        }

        public override void DebugLine(object obj)
        {
#if DEBUG
            string nowStr = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff");
            string info = string.Format("{0}{1}[DEBUG] {2}", nowStr, Logo, obj);
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine(info);
            Console.ResetColor();
#endif
        }

        public override void Error(object obj)
        {
            ErrorLine(obj);
        }

        public override void ErrorLine(object obj)
        {
            string nowStr = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff");
            string info = string.Format("{0}{1}[ERROR] {2}", nowStr, Logo, obj);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(info);
            Console.ResetColor();
        }

        public override void Info(object obj)
        {
            string nowStr = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff");
            string info = string.Format("{0}{1}[INFO] {2}", nowStr, Logo, obj);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(info);
            Console.ResetColor();
        }

        public override void Warn(object obj)
        {
            WarnLine(obj);
        }

        public override void WarnLine(object obj)
        {
            string nowStr = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff");
            string info = string.Format("{0}{1}[WARN] {2}", nowStr, Logo, obj);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(info);
            Console.ResetColor();
        }

        public override void Write(object obj)
        {
            WriteLine(obj);
        }

        public override void WriteLine(object obj)
        {
            string nowStr = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff");
            string info = string.Format("{0}{1}[WRITE] {2}", nowStr, Logo, obj);
            Console.ResetColor();
            Console.WriteLine(info);
        }

    }
}
