using LibLog;
using LibUtil;

namespace ProtoParser
{
    public class LogManager : Singleton<LogManager>
    {
        public void Init()
        {
            string prefix = "test";
            var logger = new Logger("c:/ProtoParserLog/");
            logger.Init(prefix, true, true);
            logger.Logo = "<>";
            Log.SetGlobalLogger(logger);
            Log.WriteLine("Init Log success!");
        }
    }
}
