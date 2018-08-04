using LibLog;
using LibUtil;
using ProtoParserLib;
using System;
using System.CodeDom.Compiler;
using System.Reflection;

namespace ProtoParser
{
    class Program
    {
        static void Main(string[] args)
        {
            LogManager.inst.Init();
            PathExt.InitPath();
            PathExt.SetTestPath1();

            string assemblyName = @"Message.ClientProtocol.dll";

            string code = ParseCode.AssemblyParseDll(assemblyName);

            string soure = @"..\..\ProtocolTestTool\ProtoSendLib\";
            string str1 = soure + @"Client.cs";
            string str2 = soure + @"Client_Code.cs";
            string str3 = soure + @"Client_Login_Requset.cs";
            string str4 = soure + @"Client_Login_Response.cs";
            string str5 = soure + @"HostInfo.cs";

            string[] files = new string[] { str1, str2, str3, str4, str5 };

            CompilerResults result = ParseCode.DebugRun(files, "ProtoSendLib.dll");
            if (result.Errors.HasErrors)
            {
   
                foreach (CompilerError err in result.Errors)
                {
                    Log.ErrorLine(err.ErrorText);
                }
            }
            else
            {
                Log.WriteLine("编译成功");
                Assembly objAssembly = result.CompiledAssembly;
                object objectClient = objAssembly.CreateInstance("ProtoSendLib.Client");
                //client = new Client(objectClient);
            }
            Console.ReadKey();
        }


    }
}
