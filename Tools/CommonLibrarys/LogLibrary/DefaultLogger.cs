using System;

namespace Logger
{
    public class DefaultLogger : AbstractLogger
    {

        public DefaultLogger(ILogTimeHandler handler, string logo) : base(handler, logo)
        {
            
        }

        public override void Close()
        {
        }

        public override void Error(object obj)
        {
            string info = logString.Format(obj, LogType.Error);
            WriteLog(info, LogType.Write,LogColor.Error);
        }


        public override void Info(object obj)
        {
            string info = logString.Format(obj,LogType.Info);
            WriteLog(info, LogType.Write, LogColor.Info);
        }

        public override void Warn(object obj)
        {
            string info = logString.Format(obj, LogType.Warn);
            WriteLog(info, LogType.Write, LogColor.Warn);
        }

        public override void Trace(object obj)
        {
            string info = logString.Format(obj, LogType.Trace);
            WriteLog(info, LogType.Write, LogColor.Trace);
        }

        public override void Write(object obj)
        {
            string info = logString.Format(obj, LogType.Write);
            WriteLog(info, LogType.Write, ConsoleColor.White);
        }

        public override void WriteLog(object obj, LogType type, object color)
        {
            Console.ForegroundColor = (ConsoleColor)color;
            Console.WriteLine(obj);
            Console.ResetColor();
        }
    }

}
