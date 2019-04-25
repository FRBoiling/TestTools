using Logger;
using Logger;
using ProtocolCatchMsgLogLib;
using UtilityLibrary;

namespace PressureTestToolLib
{
    public class LogManager : Singleton<LogManager>
    {
        public void Init(int id)
        {
            string statLogPrefix = "pressure";

            var logger = new PressureTestLogger("PressureLog");
            logger.Init(statLogPrefix, true, true);
            Log.SetGlobalLogger(logger);

            var parserLogger = new MsgCatchLogger("Message");
            parserLogger.Init(statLogPrefix, false, false);
            MsgCatchLog.SetGlobalLogger(parserLogger);

            var streamLogger = new StreamCatchLogger("Stream");
            streamLogger.Init(statLogPrefix, false, true);
            StreamCatchLog.SetGlobalLogger(streamLogger);

            Log.WriteLine("Init Log success!");
        }
    }
}
