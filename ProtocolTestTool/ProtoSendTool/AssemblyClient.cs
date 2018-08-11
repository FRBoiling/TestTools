using System;
using System.Collections.Generic;
using System.Reflection;

namespace ProtoSendTool
{
    public class AssemblyClient : IClient
    {
        //Dictionary<string, AssemblyClassInfo> list = new Dictionary<string, AssemblyClassInfo>();
        Dictionary<string, MethodInfo> methods = new Dictionary<string, MethodInfo>();
        object client;
        public AssemblyClient()
        {
            string assemblyName = @"ProtoSendLib.dll";

            Assembly assembly = Parser.LoadCSharpAssembly(assemblyName);
            client = Parser.ActionAssembly(assembly, "ProtoSendLib.Client");
            methods.Clear();
            MethodInfo meth = client.GetType().GetMethod("Init");
            methods.Add("Init", meth);
            meth = client.GetType().GetMethod("Exit");
            methods.Add("Exit", meth);
            meth = client.GetType().GetMethod("IsConnected");
            methods.Add("IsConnected", meth);
            meth = client.GetType().GetMethod("Update");
            methods.Add("Update", meth);
            meth = client.GetType().GetMethod("RouteInit");
            methods.Add("RouteInit", meth);
            meth = client.GetType().GetMethod("RouteGet");
            methods.Add("RouteGet", meth);
            meth = client.GetType().GetMethod("RouteSend");
            methods.Add("RouteSend", meth);
            meth = client.GetType().GetMethod("Login_Request_MSG_CG_USER_LOGIN");
            methods.Add("Login_Request_MSG_CG_USER_LOGIN", meth);
        }

        public void Init(string v1, int v2)
        {
            MethodInfo meth = methods["Init"];
            object[] parameters = new object[] { v1, v2 };
            meth.Invoke(client, parameters);
        }

        public void Exit()
        {
            MethodInfo meth = methods["Exit"];
            //MethodInfo meth = client.GetType().GetMethod("Exit");
            meth.Invoke(client, null);
        }

        public bool IsConnected()
        {
            MethodInfo meth = methods["IsConnected"];
            //MethodInfo meth = client.GetType().GetMethod("IsConnected");
            return Convert.ToBoolean( meth.Invoke(client, null));
        }

        public void Update()
        {
            MethodInfo meth = methods["Update"];
            //MethodInfo meth = client.GetType().GetMethod("Update");
            meth.Invoke(client, null);
        }

        public object RouteInit(string key)
        {
            MethodInfo meth = methods["RouteInit"];
            //MethodInfo meth = client.GetType().GetMethod("RouteInit");
            object[] parameters = new object[] { key };
            return meth.Invoke(client, parameters);
        }

        public object RouteGet(string key)
        {
            MethodInfo meth = methods["RouteGet"];
            //MethodInfo meth = client.GetType().GetMethod("RouteGet");
            object[] parameters = new object[] { key };
            return meth.Invoke(client, parameters);
        }

        public void RouteSend(string key, object msg)
        {
            MethodInfo meth = methods["RouteSend"];
            //MethodInfo meth = client.GetType().GetMethod("RouteSend");
            object[] parameters = new object[] { key, msg };
            meth.Invoke(client, parameters);
        }

        public void Login_Request_MSG_CG_USER_LOGIN()
        {
            MethodInfo meth = methods["Login_Request_MSG_CG_USER_LOGIN"];
            //MethodInfo meth = client.GetType().GetMethod("Request_MSG_CG_USER_LOGIN");
            meth.Invoke(client, null);
        }


        public void ReconnectLogin_Request_MSG_CG_RECONNECT_LOGIN()
        {
            MethodInfo meth = methods["ReconnectLogin_Request_MSG_CG_RECONNECT_LOGIN"];
            //MethodInfo meth = client.GetType().GetMethod("ReconnectLogin_Request_MSG_CG_RECONNECT_LOGIN");
            meth.Invoke(client, null);
        }

    }
}
