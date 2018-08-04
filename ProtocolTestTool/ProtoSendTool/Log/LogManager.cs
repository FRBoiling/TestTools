
using LibLog;
using LibUtil;

namespace ProtoSendTool
{
    public class LogManager : Singleton<LogManager>
    {
        public void Init(MainForm mainFrom)
        {
            string prefix = "test";
            var logger = new LoggerWinForm("c:/ProtoTestLog/", mainFrom);
            logger.Init(prefix, true, true);
            logger.Logo = "<>";
            Log.SetGlobalLogger(logger);
            Log.WriteLine("Init Log success!");
        }
    }
}
