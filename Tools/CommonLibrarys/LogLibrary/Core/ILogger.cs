namespace Logger
{
    public interface ILogger
    {
		void Write(object obj);
		void Write(string format, params object[] args);

		void Warn(object obj);
		void Warn(string format, params object[] args);

		void Error(object obj);
		void Error(string format, params object[] args);

        void Info(object obj);
        void Info(string format, params object[] args);

        void Trace(object obj);
        void Trace(string format, params object[] args);
        
		void Close();
    }
}