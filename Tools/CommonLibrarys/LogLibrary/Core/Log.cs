using System;

namespace Logger
{
	public static class Log
	{
		static private ILogger logger;

		static public void Write(object obj)
		{
			logger.Write(obj);
		}
		static public void Write(string format, params object[] args)
		{
			logger.Write(format, args);
		}
	

        static public void Warn(object obj)
		{
			logger.Warn(obj);
		}
		static public void Warn(string format, params object[] args)
		{
			logger.Warn(format, args);
		}


		static public void Error(object obj)
		{
			logger.Error(obj);
		}
		static public void Error(string format, params object[] args)
		{
			logger.Error(format, args);
		}

        static public void Info(object obj)
        {
			logger.Info(obj);
        }

        static public void Info(string format, params object[] args)
        {
            logger.Info(format, args);
        }

        static public void Trace(object obj)
        {
            logger.Trace(obj);
        }

        static public void Trace(string format, params object[] args)
        {
            logger.Trace(format, args);
        }

        static public void Close()
		{
			logger.Close();
		}

		static public void SetGlobalLogger(ILogger logger)
		{
			Log.logger = logger;
		}

    }
}