using System;

namespace LogLibrary
{
	public static class Log
	{
		static private ILog log;

		static public void Write(object obj)
		{
			log.Write(obj);
		}
		static public void Write(string format, params object[] args)
		{
			log.Write(format, args);
		}
		static public void WriteLine(object obj)
		{
			log.WriteLine(obj);
		}
		static public void WriteLine(string format, params object[] args)
		{
			log.WriteLine(format, args);
		}

        static public void Warn(object obj)
		{
			log.Warn(obj);
		}
		static public void Warn(string format, params object[] args)
		{
			log.Warn(format, args);
		}
		static public void WarnLine(object obj)
		{
			log.WarnLine(obj);
		}
		static public void WarnLine(string format, params object[] args)
		{
			log.WarnLine(format, args);
		}

		static public void Error(object obj)
		{
			log.Error(obj);
		}
		static public void Error(string format, params object[] args)
		{
			log.Error(format, args);
		}
		static public void ErrorLine(object obj)
		{
			log.ErrorLine(obj);
		}
		static public void ErrorLine(string format, params object[] args)
		{
			log.ErrorLine(format, args);
		}

        static public void Info(string format, params object[] args)
        {
            log.Info(format, args);
        }

		static public void Close()
		{
			log.Close();
		}

		static public void SetGlobalLogger(ILog logger)
		{
			Log.log = logger;
		}

        public static void SetColor(object color)
        {
            log.SetWinColor(color);
        }
    }
}