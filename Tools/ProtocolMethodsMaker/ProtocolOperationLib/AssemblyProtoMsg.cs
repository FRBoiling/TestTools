using System.Collections.Generic;
using System.Reflection;
using System.IO;
using ProtocolObjectParserLib;
using System;
using ProtocolObjectLib;

namespace ProtocolOperationLib
{
    public class AssemblyProtoMsg : AbstractProtoMsg
    {
        //Dictionary<string, AssemblyClassInfo> list = new Dictionary<string, AssemblyClassInfo>();
        Dictionary<string, MethodInfo> methods = new Dictionary<string, MethodInfo>();
        object api;
        public AssemblyProtoMsg()
        {
            string assemblyName = ConstData.ProtocolObjectDll;

            Assembly assembly = Parser.LoadCSharpAssembly(assemblyName);
            api = Parser.ActionAssembly(assembly, ConstData.BaseTypeName);
            methods.Clear();
            //MethodInfo meth = api.GetType().GetMethod("Init");
            //methods.Add("Init", meth);
            MethodInfo meth;
            meth = api.GetType().GetMethod("RouteInit");
            methods.Add("RouteInit", meth);
            meth = api.GetType().GetMethod("RouteGet");
            methods.Add("RouteGet", meth);
            meth = api.GetType().GetMethod("RouteSend");
            methods.Add("RouteSend", meth);
            meth = api.GetType().GetMethod("RouteDeserialize");
            methods.Add("RouteDeserialize", meth);
            meth = api.GetType().GetMethod("BindParser");
            methods.Add("BindParser", meth);
            meth = api.GetType().GetMethod("BindMsgId");
            methods.Add("BindMsgId", meth);
        }

        public override object RouteGet(string key)
        {
            MethodInfo meth = methods["RouteGet"];
            //MethodInfo meth = client.GetType().GetMethod("RouteGet");
            object[] parameters = new object[] { key };
            return meth.Invoke(api, parameters);
        }

        public override object RouteInit(string key)
        {
            MethodInfo meth = methods["RouteInit"];
            //MethodInfo meth = client.GetType().GetMethod("RouteInit");
            object[] parameters = new object[] { key };
            return meth.Invoke(api, parameters);
        }

        public override void BindParser()
        {
            MethodInfo meth = methods["BindParser"];
            meth.Invoke(api, null);
        }

        public override object RouteDeserialize(string key, MemoryStream stream)
        {
            MethodInfo meth = methods["RouteDeserialize"];
            //MethodInfo meth = client.GetType().GetMethod("RouteSend");
            object[] parameters = new object[] { key, stream };
            return meth.Invoke(api, parameters);
        }

        public override void BindMsgId()
        {
            MethodInfo meth = methods["BindMsgId"];
            meth.Invoke(api, null);
        }

        public override void RouteSend(SendMethodInterface handler, string key, object msg)
        {
            MethodInfo meth = methods["RouteSend"];
            //MethodInfo meth = client.GetType().GetMethod("RouteSend");
            object[] parameters = new object[] { handler, key, msg };
            meth.Invoke(api, parameters);
        }
    }
}
