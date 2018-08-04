namespace ProtoSendTool
{
    public interface IClient
    {
        void Exit();
        void Init(string v1, int v2);
        bool IsConnected();
        void Login_Request_MSG_CG_USER_LOGIN();
        object RouteGet(string key);
        object RouteInit(string key);
        void RouteSend(string key, object msg);
        void Update();
    }
}