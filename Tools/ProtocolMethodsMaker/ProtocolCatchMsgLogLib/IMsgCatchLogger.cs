namespace ProtocolCatchMsgLogLib
{
    public interface IMsgCatchLogger
    {
        void Write(object obj);
        void Write(string format, object[] args);
        void Close();
    }
}