using Logger;
using ProtocolCatchMsgLogLib;
using UtilityLibrary;

namespace ProtocolMethodsMaker
{
    public class LogManager : Singleton<LogManager>
    {
        public void Init()
        {
            var logger = new DeafaultLogger();
            logger.Logo = "<>";
            Log.SetGlobalLogger(logger);

            //var logger1 = new DealfaultCatchMsgLogger();
            //logger.Logo = "<>";
            //Log.SetGlobalLogger(logger);
            //Log.WriteLine("Init Log success!");
        }
    }
}
