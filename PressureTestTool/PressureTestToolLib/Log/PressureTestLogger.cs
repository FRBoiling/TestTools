using Logger;
using ProtocolCatchMsgLogLib;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PressureTestToolLib
{
    class PressureTestLogger: AbstractLogger
    {
        LogFileHandler handler = null;
        public string Logo = "";
        private string prefix;
        private string key;
        public PressureTestLogger(string key)
        {
            this.key = key;
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
                handler.InitNewLogFile(key, prefix);
            }
        }

        private void WriteLog(object obj, ConsoleColor color, LogType type)
        {
            DateTime now = DateTime.Now;
            try
            {
                string info = string.Format("{0}{1} {2} {3}", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff"), Logo, type, obj);

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

        public override void WriteLine(object obj)
        {
            Write(obj);
        }

        public override void Debug(object obj)
        {
#if DEBUG
            WriteLog(obj, ConsoleColor.Magenta, LogType.Debug);
#endif
        }

        public override void DebugLine(object obj)
        {
            Debug(obj);
        }

        public override void Warn(object obj)
        {
            WriteLog(obj, ConsoleColor.Yellow, LogType.Warn);
        }

        public override void WarnLine(object obj)
        {
            Warn(obj);
        }

        public override void Error(object obj)
        {
            WriteLog(obj, ConsoleColor.Red, LogType.Error);
        }

        public override void ErrorLine(object obj)
        {
            Error(obj);
        }

        public override void Info(object obj)
        {
            WriteLog(obj, ConsoleColor.Green, LogType.Info);
        }

        public override void Alert(object obj)
        {
            WriteLog(obj, ConsoleColor.DarkYellow, LogType.Alert);
        }

        public override void AlertLine(object obj)
        {
            Alert(obj);
        }
    }
}
