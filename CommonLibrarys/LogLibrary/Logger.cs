using System;
using System.Collections.Generic;
using System.IO;

namespace LogLibrary
{
    public partial class TestLogger : AbstractLog
    {
        private bool doConsolePrint = false;
        private bool doFilePrint = false;

        private string logFileName = "";
        private int writeLength = 0;
        private int flushLength = 0;
        private readonly int fileSize = 8388608; // 每个log文件大小为8M
        private string prefix;
        public string Logo = "";
        private string baseDir = "C:";
        private StreamWriter tw;

        public void Init(string prefix, bool consolePrint, bool filePrint)
        {
            doConsolePrint = consolePrint;
            doFilePrint = filePrint;
            this.prefix = prefix;

            if (doFilePrint)
            {
                //We create a new log file every time we run the app.
                logFileName = GetSaveFileName(prefix);

                //create a writer and open the file
                tw = new StreamWriter(logFileName);
                tw.AutoFlush = false;
            }
        }

        public TestLogger(string logFilePath)
        {
            this.baseDir = logFilePath;
        }

        private string GetSaveFileName(string prefix)
        {
            string path = baseDir + DateTime.Now.ToString("yyyy_MM_dd") + "/";
            try
            {
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }
            }
            catch
            {
                Log.Warn("Could not create save directory for log. See Logger.cs.");
            }

            //string assemblyFullName = Assembly.GetExecutingAssembly().FullName;
            //Int32 index = assemblyFullName.IndexOf(',');
            string dt = "" + DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss");

            //Save directory is created in ConfigFileHandler
            return path + prefix + "-" + dt + ".txt"; ;
        }

        private void CheckFileSize(int length)
        {
            if (doFilePrint)
            {
                writeLength += length;
                flushLength += length;
                if (flushLength >= 1024)
                {
                    tw.Flush();
                    flushLength = 0;
                }
                if (writeLength > fileSize)
                {
                    tw.Close();
                    logFileName = GetSaveFileName(prefix);

                    // 创建新的log file
                    tw = new StreamWriter(logFileName);
                    tw.AutoFlush = false;
                    tw.AutoFlush = true; // TODO 验证性能是否可以接受
                    writeLength = 0;
                }
            }
        }

        public override void Write(object obj)
        {
            try
            {
                string info = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff") + Logo + "[INFO] " + obj;
                //tw.WriteLine(info);
                //CheckFileSize(info.Length);
                if (doConsolePrint == true)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(info);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        public override void WriteLine(object obj)
        {
            Write(obj);
        }

        public override void Warn(object obj)
        {
#if DEBUG
            try
            {
                string info = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff") + Logo + "[WARN] " + obj;
                if (doFilePrint)
                {
                    tw.WriteLine(info);
                }
                CheckFileSize(info.Length);
                if (doConsolePrint == true)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(info);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
#endif
        }

        public override void Info(object obj)
        {
            try
            {
                string info = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff") + Logo + "[INFO] " + obj;
                CheckFileSize(info.Length);
                if (doConsolePrint == true)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(info);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        public override void WarnLine(object obj)
        {
            Warn(obj);
        }

        public override void Error(object obj)
        {
            try
            {
                string info = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff") + Logo + "[ERROR] " + obj;
                //tw.WriteLine(info);
                CheckFileSize(info.Length);
                if (doConsolePrint == true)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(info);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
        public override void ErrorLine(object obj)
        {
            Error(obj);
        }

        public override void Close()
        {
            WriteLine("This session was logged to " + logFileName);
            if (doFilePrint)
            {
                tw.Close();
            }
            tw = null;
        }

        public override void SetColor(object color)
        {
            Console.ForegroundColor = (ConsoleColor)color;
        }
    }

    public enum StatLogType
    {
        COST = 1,                    // 消费
        LOGIN = 2,                  // 登陆 
        UPGRADE = 3,             // 升级
        REGISTER = 4,              // 注册
        RECHARGE = 5,            // 充值
        ONLINE = 6,                 // 在线
        LOGOUT = 7,                 // 登出
        AU = 8,                          // 账号认证
        CONSUME = 9,            // 消耗
        LISTENCHAT = 10,                  // 言论
        EQUIP = 11,                  // 装备
    }

    public class StatLogger
    {
        private readonly int fileSize = 8388608; // 每个log文件大小为8M
        //private StreamWriter tw;
        private int refreshTime = 5; // 每5分钟更新一次
        public DateTime NextNewLogFileTime;
        public DateTime LastCheckTime;
        private string fileName;
        private int writeLength;
        private string prefix;
        private string serverKey;
        private StatLogType type;
        public string Dir = "c:/StatLog/";

        private bool IsSpecStatLogType(StatLogType type)
        {
            switch (type)
            {
                case StatLogType.COST:
                case StatLogType.LOGIN:
                case StatLogType.UPGRADE:
                case StatLogType.REGISTER:
                case StatLogType.RECHARGE:
                case StatLogType.ONLINE:
                case StatLogType.LOGOUT:
                case StatLogType.AU:
                    return false;
                default:
                    return true;
            }
        }

        public StatLogger(string server_key, string prefix, int refresh_time, StatLogType type)
        {
            this.serverKey = server_key;
            this.refreshTime = refresh_time;
            // prefix = serverName_param
            // e.g. ZoneServer_1_1 ManagerServcer_1 BarrackServer_2
            this.prefix = prefix;
            this.type = type;
            if (IsSpecStatLogType(type))
            {
                Dir = "c:/SpecStatLog/";
            }
            else
            {
                Dir = "c:/StatLog/";
            }
            CreateNewLogFile();
        }

        public void SetLogDir(string path)
        {
            Dir = path;
        }

        public void CheckNewLogFile(DateTime now)
        {
            // 保证多个进程都是同一时间创建该类型文件
            if ((now > NextNewLogFileTime && now.Minute % refreshTime == 0) || (now.Date != LastCheckTime.Date))
            {
                Close();
                CreateNewLogFile();
            }
            LastCheckTime = now;
        }

        private void CreateNewLogFile()
        {
            //if (Directory.Exists(Dir) == false)
            //{
            //    Directory.CreateDirectory(Dir);
            //}
            //LastCheckTime = DateTime.Now;
            //NextNewLogFileTime = DateTime.Now.AddMinutes(refreshTime);
            //fileName = Dir + serverKey + prefix + "_" + type.ToString() + "_" + DateTime.Now.ToString("yyyy-MM-dd-HH-mm") + ".log.now";
            //tw = new StreamWriter(fileName);
            //tw.AutoFlush = true;
            writeLength = 0;
        }

        public void Write(string log, StatLogType type)
        {
            try
            {
                log += '|' + serverKey + '_' + type.ToString();
                //tw.WriteLine(log);
            }
            catch (Exception e)
            {
                Log.Warn(e.ToString());
            }
            /*
            writeLength += log.Length;
            if (writeLength >= fileSize)
            {
                tw.Close();
                CreateNewLogFile();
            }
            */
        }

        public void Close()
        {
            // 日志输出完毕，删除 .now 后缀
            //tw.Close();
            string closeFileName = fileName.Replace(".now", "");
            try
            {
                System.IO.File.Move(fileName, closeFileName);
            }
            catch (Exception e)
            {
                Log.Warn(e.ToString());
            }
        }
    }

    public class StatLoggerManager
    {
        public Dictionary<StatLogType, StatLogger> LoggerList = new Dictionary<StatLogType, StatLogger>();
        private string serverKey;
        private string prefix;
        public StatLoggerManager(string server_key, string prefix)
        {
            this.serverKey = server_key;
            this.prefix = prefix;
        }

        public void CreateLogger(StatLogType type)
        {
            int periodTime = 5;
            switch (type)
            {
                case StatLogType.COST:
                case StatLogType.LOGIN:
                case StatLogType.UPGRADE:
                case StatLogType.REGISTER:
                case StatLogType.RECHARGE:
                case StatLogType.ONLINE:
                case StatLogType.LOGOUT:
                case StatLogType.AU:
                case StatLogType.CONSUME:
                    periodTime = 5;
                    break;
                case StatLogType.LISTENCHAT:
                case StatLogType.EQUIP:
                    periodTime = 10;
                    break;
            }
            StatLogger logger = new StatLogger(serverKey, prefix, periodTime, type);
            if (LoggerList.ContainsKey(type))
            {
                LoggerList[type] = logger;
            }
            else
            {
                LoggerList.Add(type, logger);
            }
        }

        public void CheckNewLogFile(DateTime now)
        {
            foreach (var item in LoggerList)
            {
                try
                {
                    item.Value.CheckNewLogFile(now);
                }
                catch (Exception e)
                {
                    Log.Warn(e.ToString());
                }
            }
        }

        public void Write(string log, StatLogType type)
        {
            StatLogger logger = null;
            if (LoggerList.TryGetValue(type, out logger))
            {
                logger.Write(log, type);
            }
        }

        public void Close()
        {
            foreach (var item in LoggerList)
            {
                item.Value.Close();
            }
        }
    }

}
