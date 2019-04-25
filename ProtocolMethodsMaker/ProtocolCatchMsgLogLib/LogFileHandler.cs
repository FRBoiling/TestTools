using Logger;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtocolCatchMsgLogLib
{
    public class LogFileHandler
    {
        private StreamWriter tw = null;
        private int refreshTime = 5; // 每5分钟更新一次
        public DateTime NextNewLogFileTime;
        public DateTime LastCheckTime;
        private string fileName;
        public string Dir = "c:/Log/ProtocolCatchLog/";

        public void InitNewLogFile(string key, string prefix)
        {
            this.prefix = prefix;
            this.key = key;
            Dir += key;
            Dir = Dir + "/" + prefix;
            if (!Directory.Exists(Dir))
            {
                Directory.CreateDirectory(Dir);
            }
            LastCheckTime = DateTime.Now;
            NextNewLogFileTime = DateTime.Now.AddMinutes(refreshTime);
            fileName = Dir  + "/" + prefix + "_" + DateTime.Now.ToString("yyyy-MM-dd-HH-mm") + ".txt.now";

            // 第一次写入 则先创建文件
            tw = new StreamWriter(fileName);
            tw.AutoFlush = true;
        }

        private string GetSaveFileName(string prefix)
        {
            string path = Dir + DateTime.Now.ToString("yyyy_MM_dd") + "/";
            try
            {
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }
            }
            catch
            {
                Log.Warn("Could not create save directory for Parserlog. See Logger.cs.");
            }

            string dt = "" + DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss");

            //Save directory is created in ConfigFileHandler
            return path + prefix + "-" + dt + ".txt"; ;
        }

        private int writeLength = 0;
        private int flushLength = 0;
        private readonly int fileSize = 1048576; // 每个log文件大小为1M
        private DateTime lastLogTime = DateTime.MaxValue;
        private string key;
        private string prefix;

        public void CheckFileSize(int length, DateTime now)
        {
            bool needCreate = false;
            writeLength += length;
            flushLength += length;
            if (flushLength >= 1024)
            {
                tw.Flush();
                flushLength = 0;
            }
            if (writeLength > fileSize)
            {
                needCreate = true;
            }
            if (lastLogTime != DateTime.MaxValue && lastLogTime.Date != now.Date)
            {
                needCreate = true;
            }
            lastLogTime = now;
            if (needCreate)
            {
                tw.Close();
                // 日志输出完毕，删除 .now 后缀
                string closeFileName = fileName.Replace(".now", "");
                try
                {
                    System.IO.File.Move(fileName, closeFileName);
                }
                catch (Exception e)
                {
                    Log.Warn(e.ToString());
                }
                fileName = GetSaveFileName(prefix);
                // 创建新的log file
                tw = new StreamWriter(fileName);
                tw.AutoFlush = false;
                writeLength = 0;
                flushLength = 0;
            }
        }

        public void Close()
        {
            if (tw == null)
            {
                return;
            }
            // 日志输出完毕，删除 .now 后缀
            tw.Close();
            string closeFileName = fileName.Replace(".now", "");
            try
            {
                System.IO.File.Move(fileName, closeFileName);
            }
            catch (Exception e)
            {
                Log.Warn(e.ToString());
            }
            finally
            {
                tw = null;
            }
        }

        public void WriteLine(object obj)
        {
            tw.WriteLine(obj);
        }
    }
}
