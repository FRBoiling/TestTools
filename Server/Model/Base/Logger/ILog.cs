using System;
using System.Collections.Generic;
using System.Text;

namespace Model.Logger
{
        public interface ILog
        {
            void Trace(string message);
            void Warn(string message);
            void Info(string message);
            void Debug(string message);
            void Error(string message);
            void Fatal(string message);
            void Trace(string message, params object[] args);
            void Warn(string message, params object[] args);
            void Info(string message, params object[] args);
            void Debug(string message, params object[] args);
            void Error(string message, params object[] args);
            void Fatal(string message, params object[] args);
        }
}
