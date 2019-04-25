using Logger;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtocolCatchMsgLogLib
{
    public class StreamCatchLogger: AbstractCatchLogger
    {
        LogFileHandler handler = null;
        public string Logo = "";
        private string prefix;
        private string serverKey="Stream";
        ILoggerTimestamp loggerTimestamp;

        public StreamCatchLogger(ILoggerTimestamp loggerTimestamp)
        {
            this.loggerTimestamp = loggerTimestamp;
        }

        private bool doConsolePrint = false;
        private bool doFilePrint = false;

        public void Init(string prefix, bool doConsolePrint, bool doFilePrint)
        {
            this.doConsolePrint = doConsolePrint;
            this.doFilePrint = doFilePrint;
            this.prefix = prefix;
            if (doFilePrint)
            {
                handler = new LogFileHandler();
                handler.InitNewLogFile(serverKey, prefix);
            }
        }
        private void WriteLog(object obj, ConsoleColor color, LogType type)
        {
            DateTime now = DateTime.Now;
            try
            {
                string info = string.Format("{0}{1} {2} {3}", loggerTimestamp.NowString(), Logo, type, obj);

                if (doConsolePrint)
                {
                    Console.ForegroundColor = color;
                    Console.WriteLine(info);
                    Console.ResetColor();
                }
                if (doFilePrint)
                {
                    handler.WriteLine(info);
                    handler.CheckFileSize(info.Length, now);
                }
            }
            catch (Exception e)
            {
                Log.Error(e.ToString());
            }
        }
        public override void Write(object obj)
        {
            WriteLog(obj,ConsoleColor.Gray,LogType.Write);
        }

        public override void Close()
        {
            if (doFilePrint)
            {
                handler.Close();
            }
        }
    }
}
