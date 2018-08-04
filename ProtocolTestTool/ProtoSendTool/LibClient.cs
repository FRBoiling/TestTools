using ProtoSendLib;

namespace ProtoSendTool
{
    public class LibClient : IClient
    {
        Client client;
        public LibClient()
        {
            client = new Client();
        }

        public void Init(string v1, int v2)
        {
            client.Init(v1, v2);
        }

        public void Exit()
        {
            client.Exit();
        }

        public bool IsConnected()
        {
            return client.IsConnected();
        }

        public void Update()
        {
            client.Update();
        }

        public object RouteInit(string key)
        {
            return client.RouteInit(key);
        }

        public object RouteGet(string key)
        {
            return client.RouteGet(key);
        }

        public void RouteSend(string key, object msg)
        {
            client.RouteSend(key,msg);
        }

        public void Login_Request_MSG_CG_USER_LOGIN()
        {
            client.Login_Request_MSG_CG_USER_LOGIN();
        }

    }
}
