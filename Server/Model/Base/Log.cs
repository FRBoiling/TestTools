using Model.Logger;
using System;
using System.Collections.Generic;
using System.Text;

namespace Model.Base
{
    public static class Log
    {
        private static readonly ILog globalLog = new NLogAdapter();

        public static void Trace(string message)
        {
            globalLog.Trace(message);
        }

        public static void Warn(string message)
        {
            globalLog.Warn(message);
        }

        public static void Info(string message)
        {
            globalLog.Info(message);
        }

        public static void Debug(string message)
        {
            globalLog.Debug(message);
        }

        public static void Error(Exception e)
        {
            globalLog.Error(e.ToString());
        }

        public static void Error(string message)
        {
            globalLog.Error(message);
        }

        public static void Fatal(Exception e)
        {
            globalLog.Fatal(e.ToString());
        }

        public static void Fatal(string message)
        {
            globalLog.Fatal(message);
        }

        public static void Msg(object message)
        {
            //TODO: protobuf 协议解析成str
            globalLog.Debug(message.ToString());
        }
    }
}
