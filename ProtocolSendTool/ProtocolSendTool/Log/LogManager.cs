using Logger;
using ProtocolCatchMsgLogLib;
using UtilityLibrary;

namespace ProtocolSendTool
{
    public class LogManager : Singleton<LogManager>
    {
        public void Init(MainForm mainFrom)
        {
            string prefix = "protocolsend";
            var logger = new WinFormLogger("c:/ProtoTestLog/", mainFrom);
            logger.Init(prefix, true, true);
            logger.Logo = "<>";
            Log.SetGlobalLogger(logger);

            var parserLogger = new MessageParserLogger("c:/MessageLog/",mainFrom);
            parserLogger.Init("message", true, true);
            parserLogger.Open();
            MsgCatchLog.SetGlobalLogger(parserLogger);

            var streamLogger = new MessageParserLogger("c:/MessageLog/", mainFrom);
            streamLogger.Init("stream", false, true);
            parserLogger.Open();
            StreamCatchLog.SetGlobalLogger(streamLogger);

            Log.WriteLine("Init Log success!");
        }

        public void Close()
        {
            Log.Close();
            MsgCatchLog.Close();
            StreamCatchLog.Close();
        }
    }
}
