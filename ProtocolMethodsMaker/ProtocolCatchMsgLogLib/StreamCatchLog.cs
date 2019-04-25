using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtocolCatchMsgLogLib
{
    public class StreamCatchLog
    {
        static private IMsgCatchLogger logger = new DealfaultCatchLogger();

        public static void SetGlobalLogger(IMsgCatchLogger concretelogger)
        {
            logger = concretelogger;
        }
        static public void Write(string format, params object[] args)
        {
            logger.Write(format, args);
        }

        /// <summary>
        /// 读取文件日志数据
        /// </summary>
        static public Queue<string[]> Read(string fileDir)
        {
            FileInfo[] files = GetLogFilesByOrder(fileDir);
            return ReadLogFile(files);
        }

        public static void Close()
        {
            logger.Close();
        }
        public static void Open()
        {
            logger.Open();
        }

        /// <summary>
        /// 获取dir目录下所有的日志文件
        /// </summary>
        /// <param name="Dir">日志文件路径</param>
        /// <returns></returns>
        private static FileInfo[] GetLogFilesByOrder(string Dir)
        {
            DirectoryInfo dirInfo = new DirectoryInfo(Dir);
            FileInfo[] sortFiles = dirInfo.GetFiles();
            Array.Sort(sortFiles, new DateSorter());
            return sortFiles;
        }

        public const string DATETIME_TO_STRING = "yyyy-MM-dd HH:mm:ss";
        public const string DATETIME_TO_STRING_1 = "yyyy-MM-dd HH:mm";

        public static void SaveMsgInfo(DateTime now, int uid, string msgName, MemoryStream stream)
        {
            string log = string.Format("{0}|{1}|{2}|{3}", now.ToString(DATETIME_TO_STRING), uid, msgName, Convert.ToBase64String(stream.ToArray()));
            Write(log);
        }

        /// <summary>
        /// 读取所有日志文件数据，存到Queue
        /// </summary>
        /// <param name="files">获取到的日志文件集合</param>
        /// <returns></returns>
        private static Queue<string[]> ReadLogFile(FileInfo[] files)
        {
            string logFileName;
            string[] dataArr;
            Queue<string[]> protocolData = new Queue<string[]>();
            for (int i = 0; i < files.Length; i++)
            {
                logFileName = files[i].FullName;
                IEnumerable<string> lines = File.ReadAllLines(logFileName);
                foreach (var line in lines)
                {
                    StringBuilder sb = new StringBuilder();
                    sb.Length = 0;
                    dataArr = line.Split('|');
                    protocolData.Enqueue(dataArr);
                }
            }
            return protocolData;
        }

        /// <summary>
        /// 自定义比较器：定义获取日志文件排序规则
        /// </summary>
        public class DateSorter : IComparer
        {
            #region IComparer Members
            public int Compare(object x, object y)
            {
                if (x == null && y == null)
                {
                    return 0;
                }
                if (x == null)
                {
                    return -1;
                }
                if (y == null)
                {
                    return 1;
                }
                FileInfo xInfo = (FileInfo)x;
                FileInfo yInfo = (FileInfo)y;
                //依名称排序
                //递增
                return xInfo.FullName.CompareTo(yInfo.FullName);
            }
            #endregion
        }

    
    }
}
