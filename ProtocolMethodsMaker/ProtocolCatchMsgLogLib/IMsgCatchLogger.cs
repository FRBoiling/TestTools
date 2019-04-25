namespace ProtocolCatchMsgLogLib
{
    public interface IMsgCatchLogger
    {
        void Write(object obj);
		void Write(string format, params object[] args);

        void Open();

        void Close();
    }
}