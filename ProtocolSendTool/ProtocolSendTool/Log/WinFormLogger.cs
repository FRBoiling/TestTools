using Logger;
using System;
using System.Drawing;

namespace ProtocolSendTool
{
    public partial class WinFormLogger : AbstractLogger
    {
        private bool doFormPrint = false;
        private bool doFilePrint = false;

        private string logFileName = "";
        private int writeLength = 0;
        private int flushLength = 0;
        private readonly int fileSize = 8388608; // 每个log文件大小为8M
        private string prefix;
        public string Logo = "";
        private string baseDir = "C:";
        public void Init(string prefix, bool formPrint, bool filePrint)
        {
            doFormPrint = formPrint;
            doFilePrint = filePrint;
            this.prefix = prefix;
            //We create a new log file every time we run the app.
            logFileName = GetSaveFileName(prefix);

            // create a writer and open the file
            //tw = new StreamWriter(logFileName);
            //tw.AutoFlush = false; 
        }

        MainForm winFrom;

        public WinFormLogger(string logFilePath,MainForm main)
        {
            this.baseDir = logFilePath;
            winFrom = main;
        }

        private string GetSaveFileName(string prefix)
        {
            string path = baseDir + DateTime.Now.ToString("yyyy_MM_dd") + "/";
            try
            {
                //if (Directory.Exists(path) == false)
                //{
                //    Directory.CreateDirectory(path);
                //}
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
            writeLength += length;
            flushLength += length;
            if (flushLength >= 1024)
            {
                //tw.Flush();
                flushLength = 0;
            }
            if (writeLength > fileSize)
            {
                //tw.Close();
                logFileName = GetSaveFileName(prefix);

                //// 创建新的log file
                //tw = new StreamWriter(logFileName);
                //tw.AutoFlush = false;
                //tw.AutoFlush = true; // TODO 验证性能是否可以接受
                writeLength = 0;
            }
        }

        public override void Write(object obj)
        {
            try
            {
                string info = string.Format("{0}{1}{2}{3}",DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff") , Logo , "[INFO] " , obj ); 
                //tw.WriteLine(info);
                CheckFileSize(info.Length);
                if (doFormPrint)
                {
                    winFrom.WinFromLog(info,Color.Red);
                }
            }
            catch (Exception e)
            {
                winFrom.WinFromLog(e.ToString());
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
                //tw.WriteLine(info);
                CheckFileSize(info.Length);
                if (doFormPrint )
                {
                    winFrom.WinFromLog(info);
                }
            }
            catch (Exception e)
            {
                winFrom.WinFromLog(e.ToString());
            }
#endif
        }

        public override void Info(object obj)
        {
            try
            {
                string info = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff") + Logo + "[INFO] " + obj;
                CheckFileSize(info.Length);
                if (doFormPrint)
                {
                    winFrom.WinFromLog(info);
                }
            }
            catch (Exception e)
            {
                winFrom.WinFromLog(e.ToString());
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
                if (doFormPrint)
                {
                    winFrom.WinFromLog(info);
                }
            }
            catch (Exception e)
            {
                winFrom.WinFromLog(e.ToString());
            }
        }
        public override void ErrorLine(object obj)
        {
            Error(obj);
        }

        public override void Close()
        {
            WriteLine("This session was logged to " + logFileName);
            //tw.Close();
            //tw = null;
        }

        public override void Debug(object obj)
        {
            try
            {
                string info = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff") + Logo + "[DEBUG] " + obj;
                CheckFileSize(info.Length);
                if (doFormPrint)
                {
                    winFrom.WinFromLog(info);
                }
            }
            catch (Exception e)
            {
                winFrom.WinFromLog(e.ToString());
            }
        }

        public override void DebugLine(object obj)
        {
            throw new NotImplementedException();
        }

        public override void Alert(object obj)
        {
            throw new NotImplementedException();
        }

        public override void AlertLine(object obj)
        {
            throw new NotImplementedException();
        }
    }
}
