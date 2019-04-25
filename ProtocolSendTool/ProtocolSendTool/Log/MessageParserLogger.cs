using Logger;
using ProtocolCatchMsgLogLib;
using System;
using System.Drawing;

namespace ProtocolSendTool
{
    public class MessageParserLogger: AbstractCatchLogger
    {
        public MessageParserLogger(string v)
        {
            this.v = v;
        }

        private MainForm mainFrom;
        public MessageParserLogger(string v, MainForm mainFrom) : this(v)
        {
            this.mainFrom = mainFrom;
        }

        private string v;
        private bool doFormPrint = false;
        private bool doFilePrint = false;

        public string Logo = "";
        private string prefix;

        LogFileHandler handler = null;

        public void Init(string prefix, bool formPrint, bool filePrint)
        {
            doFormPrint = formPrint;
            doFilePrint = filePrint;
            this.prefix = prefix;
            if (filePrint)
            {
                handler = new LogFileHandler();
                handler.InitNewLogFile("ProtoSendTool", prefix);
            }
        }
      
        public override void Write(object obj)
        {
            DateTime now = DateTime.Now;
            try
            {
                string info = string.Format("{0}{1}{2}{3}", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff"), Logo, "[INFO] ", obj);

                if (doFormPrint)
                {
                    mainFrom.WinFromLog(info, Color.Red);
                }
                if (doFilePrint)
                {
                    handler.WriteLine(info);
                    handler.CheckFileSize(info.Length, now);
                }
            }
            catch (Exception e)
            {
                Log.Error(e.ToString());
            }
        }


        public override void Close()
        {
            if (doFilePrint)
            {
                handler.Close();
            }
        }
     
    }
}
