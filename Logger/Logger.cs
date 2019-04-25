namespace Logger
{
	public static class Log
	{
		static private ILogger logger = new DeafaultLogger();

        static public void Write(object obj)
		{
			logger.Write(obj);
		}
		static public void Write(string format, params object[] args)
		{
			logger.Write(format, args);
		}
		static public void WriteLine(object obj)
		{
			logger.WriteLine(obj);
		}
		static public void WriteLine(string format, params object[] args)
		{
			logger.WriteLine(format, args);
		}

        static public void Debug(object obj)
        {
            logger.Debug(obj);
        }
        static public void Debug(string format, params object[] args)
        {
            logger.Debug(format, args);
        }
        static public void DebugLine(object obj)
        {
            logger.DebugLine(obj);
        }
        static public void DebugLine(string format, params object[] args)
        {
            logger.DebugLine(format, args);
        }

        static public void Warn(object obj)
		{
			logger.Warn(obj);
		}
		static public void Warn(string format, params object[] args)
		{
			logger.Warn(format, args);
		}
		static public void WarnLine(object obj)
		{
			logger.WarnLine(obj);
		}
		static public void WarnLine(string format, params object[] args)
		{
			logger.WarnLine(format, args);
		}

        static public void Alert(object obj)
        {
            logger.Alert(obj);
        }
        static public void Alert(string format, params object[] args)
        {
            logger.Alert(format, args);
        }
        static public void ExcepLine(object obj)
        {
            logger.AlertLine(obj);
        }
        static public void ExcepLine(string format, params object[] args)
        {
            logger.AlertLine(format, args);
        }

		static public void Error(object obj)
		{
			logger.Error(obj);
		}
		static public void Error(string format, params object[] args)
		{
			logger.Error(format, args);
		}
		static public void ErrorLine(object obj)
		{
			logger.ErrorLine(obj);
		}
		static public void ErrorLine(string format, params object[] args)
		{
			logger.ErrorLine(format, args);
		}

        static public void Info(string format, params object[] args)
        {
            logger.Info(format, args);
        }

		static public void Close()
		{
			logger.Close();
		}

		static public void SetGlobalLogger(ILogger logger)
		{
            if (logger == null)
            {
                Log.logger = new DeafaultLogger();
            }
            else
            {
                Log.logger = logger;
            }
        }
	}
}