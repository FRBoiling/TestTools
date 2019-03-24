using System;
using System.Text;

namespace Logger
{
    public abstract class AbstractLogger : ILogger
    {
        public LogString logString = new LogString();

        public AbstractLogger(ILogTimeHandler handler = null,string logo = null)
        {
            logString.SetLogo(logo);
            logString.SetTimeHandler(handler);
        }

        private string GetString(string format, params object[] args)
        {
            var sb = new StringBuilder();
            sb.AppendFormat(format, args);

            return sb.ToString();
        }

        public void Write(string format, params object[] args)
        {
            Write((object)GetString(format, args));
        }

        public void Warn(string format, params object[] args)
        {
            Warn((object)GetString(format, args));
        }

        public void Error(string format, params object[] args)
        {
            Error((object)GetString(format, args));
        }

        public void Trace(string format, params object[] args)
        {
            Trace((object)GetString(format, args));
        }

        public void Info(string format, params object[] args)
        {
            Info((object)GetString(format, args));
        }

        public abstract void Write(object obj);
        public abstract void Warn(object obj);
        public abstract void Error(object obj);
        public abstract void Info(object obj);
        public abstract void Trace(object obj);

        public abstract void WriteLog(object obj,LogType type, object color);

        public abstract void Close();
  

    }
}
