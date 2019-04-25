using Logger;
using PressureTestToolLib;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using UtilityLibrary;

namespace PressureTestToolLib
{
    public class ClientManager : Singleton<ClientManager>
    {
        public string Perfix = "FR<{0}>";
        ConcurrentDictionary<int, Client> _listClients;
        public int Id;

        string ServerIp = "127.0.0.1";
        int ServerPort = 8880;

        public void Init(int id)
        {
            Id = id;
            Perfix = string.Format(Perfix, id);
            _listClients = new ConcurrentDictionary<int, Client>();
            Log.WriteLine("Init ClientMng success!");
        }

        public void OpenClient(int clientId)
        {
            string name = string.Format("{0}{1}", Perfix, clientId);
            Client client;
            if (_listClients.TryGetValue(clientId, out client))
            {
                Log.WarnLine("Client {0} already connected", client.GetAccountName());
            }
            else
            {
                client = new Client();
                client.ClientNum = clientId;
                client.SetAccountName(name);
                //new Thread(ThreadFunc).Start(client);
                //new Task(() =>
                //{
                //    ThreadFunc(client);
                //}).Start();
                ThreadPool.QueueUserWorkItem(new WaitCallback(ThreadFunc), client);
            }
        }



        public void ThreadFunc(object client)
        {
            Client c = (Client)client;
            c.Init(ServerIp, ServerPort);
            c.BindResponse();
            if (c.Net != null)
            {
                c.Connect2Server();
            }
            else
            {
                Log.ErrorLine("Net is null");
            }
            _listClients.TryAdd(c.ClientNum, c);
        }

        int CurrClientId = 0;
        internal void ChoseClient(int uid)
        {
            if (uid >0)
            {
                CurrClientId = uid;
                Log.WriteLine("Chose the player {0}",CurrClientId);
            }
            else
            {
                CurrClientId = 0;
                Log.WriteLine("Chose all players");
            }
        }

        public void AddClient(int count=1)
        {
            int lstCount;
            if (_listClients != null)
            {
                lstCount = _listClients.Count;
            }
            else
            {
                return;
            }
            for (int i = 1; i <= count; i++)
            {
                int clientId = lstCount + i;
                OpenClient(clientId);
            }
        }

        public void GetCount()
        {
            Log.Info("now client count = {0}", _listClients.Count);
        }

        public bool RemoveClient(int id)
        {
            Client client;
            return _listClients.TryRemove(id, out client);
        }

        public void ClearClient()
        {
            foreach (var client in _listClients)
            {
                client.Value.Exit();
            }
            _listClients.Clear();
        }

        public void Update()
        {
            if (CurrClientId == 0)
            {
                foreach (var client in _listClients)
                {
                    try
                    {
                        client.Value.Update();
                        client.Value.DoRequest();
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("{0}", e);
                    }
                }
            }
            else
            {
                Client currClient;
                if (_listClients.TryGetValue(CurrClientId, out currClient))
                {
                    currClient.Update();
                }
                else
                {
                    Log.WarnLine("update cannot find client {0}", CurrClientId);
                }
            }
           
        }


        public void AddRequest(LogicType type, List<string> paramList)
        {
            if (CurrClientId == 0)
            {
                foreach (var client in _listClients)
                {
                    try
                    {
                        client.Value.AddResqueueter(type, paramList);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("{0}", e);
                    }
                }
            }
            else
            {
                Client currClient;
                if (_listClients.TryGetValue(CurrClientId, out currClient))
                {
                    currClient.AddResqueueter(type, paramList);
                }
                else
                {
                    Log.WarnLine("AddResqueueter cannot find client {0}", CurrClientId);
                }
            }
        }

        public void SetLoopMillionSec(int sec = 20)
        {
            foreach (var item in _listClients)
            {
                item.Value.SetLoopExecIntervalSec(sec);
            }
        }


    }
}
