using System;
using System.Collections.Generic;
using TcpLib;
using UtilityLibrary;

namespace PressureTestToolMaster
{
    public partial class SessionMng:Singleton<SessionMng>
    {
        public List<Session> _connectedSession = new List<Session>();

        private object _allSessionLock = new object();

        public Dictionary<string, Session> _sessions = new Dictionary<string, Session>();

        private List<Session> _removeSessions = new List<Session>();
    
        public void Bind(ushort port,int backLog)
        {
            TcpMgr.inst.Bind(port, backLog);
        }

        public void Listen(ushort  port)
        {
            TcpMgr.inst.Listen(port, InitListen);
        }

        private void InitListen(ushort port)
        {
            Protocol.Server.Register.ServerRegisterIdGenerater.GenerateId();

            Session session = new Session(this, port);
            session.Net.Listen(port);
        }

        public void Process()
        {
            lock (_allSessionLock)
            {
                foreach (var session in _connectedSession)
                {
                    try
                    {
                        session.Update();
                    }
                    catch (Exception e)
                    {
                        throw;
                    }
                }
            }

            if (_removeSessions.Count >0)
            {
                foreach (var session in _removeSessions)
                {
                    _connectedSession.Remove(session);
                }
                _removeSessions.Clear();
            }
        }

        public void AddAccpetSession(Session session)
        {
            if (session == null)
            {
                Console.WriteLine("AddAccpetSession error ,session is null");
                return;
            }
            else
            {
                lock (_allSessionLock)
                {
                    _connectedSession.Add(session);
                }
            }
        }

        public void RemoveSession(Session session)
        {
            if (session == null)
            {
                Console.WriteLine("RemoveSession error ,session is null");
                return;
            }
            else
            {
                lock (_allSessionLock)
                {
                    if (_connectedSession.Contains(session))
                    {
                        _connectedSession.Remove(session);
                        _sessions.Remove(session.Key);
                    }
                }
            }
        }

        public bool AddSession(Session session)
        {
            if (session == null)
            {
                Console.WriteLine("AddSession error ,session is null");
                return false;
            }
            else
            {
                if (_sessions.ContainsKey(session.Key))
                {
                    _removeSessions.Add(session);
                    Console.WriteLine("AddSession repeated add : {0}",session.Key);
                    return false;
                }
                else
                {
                    Console.WriteLine("AddSession add session {0}",session.Key);
                    _sessions.Add(session.Key, session);
                    return true;
                }
            }
        }

    }
}
