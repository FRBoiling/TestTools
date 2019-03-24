using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client();
            Protocol.Server.Register.ServerRegisterIdGenerater.GenerateId();
            client.Init("127.0.0.1", 8880);
            client.BindResponse();
            client.Connect2Server();

            while (true)
            {
                client.Update();
            }
        }
    }
}
