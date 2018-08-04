using LibUtil;
using Microsoft.CSharp;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.IO;

namespace ProtoParserLib
{
    public class ParseCode
    {
        /// <summary>
        /// 登录流程的协议不进行动态生成
        /// </summary>
        /// <param name="strName"></param>
        /// <returns></returns>
        public static bool CheckLoginMsg(string strName)
        {
            switch (strName)
            {
                //request
                //case "MSG_CG_HEARTBEAT":
                    //return false;
                //case "MSG_CG_MAP_LOADING_DONE":
                //    return false;
                //case "MSG_CG_GET_BLOWFISHKEY":
                //    return false;
                //case "MSG_CG_USER_LOGIN":
                //    return false;
                //case "MSG_CG_TO_ZONE":
                //    return false;


                //response
                //case "MSG_GC_HEARTBEAT":
                //    return false;
                //case "MSG_GC_TIME_SYNC":
                //    return false;
                //case "MSG_GC_BLOWFISHKEY":
                //    return false;
                //case "MSG_GC_USER_LOGIN":
                //    return false;
                //case "MSG_GC_ENTER_WORLD":
                //    return false;
                //case "MSG_GC_ENTER_ZONE":
                //    return false;
                //case "MSG_GC_MAP_LOADING_DONE":
                //    return false;
                default:
                    break;
            }
            return true;
        }

        /// <summary>
        /// 根据反射读取协议dll生成协议解析源码
        /// </summary>
        /// <param name="assemblyName"></param>
        public static string AssemblyParseDll(string assemblyName)
        {
            AssemblyHandler handler = new AssemblyHandler();
            AssemblyResult result = handler.GetClassName(assemblyName);
            result.AssemblyNameList = new List<string>();
            result.AssemblyNameList.Add(assemblyName);

            string strGenerateCode = GenerateCodeModel.GenerateCode(result.ClassList);
            string codeFileName = "Client_Code.cs";
            string codeFileFullName = PathExt.workPath + @"\ProtocolTestTool\ProtoSendLib\" + codeFileName;
            FileInfo fCodeFileName = new FileInfo(codeFileFullName);
            StreamWriter wResponseRecv = fCodeFileName.CreateText();
            wResponseRecv.WriteLine(strGenerateCode);
            wResponseRecv.Close();

            return strGenerateCode;
        }

        /// <summary>
        /// 动态编译并执行代码
        /// </summary>
        /// <param name="filesNames">代码</param>
        /// <param name="newPath">输出dll路径</param>
        /// <returns>返回输出内容</returns>
        public static CompilerResults DebugRun(string [] filesNames, string newPath)
        {
            CSharpCodeProvider complier = new CSharpCodeProvider();

            CompilerParameters paras = new CompilerParameters();

            paras.ReferencedAssemblies.Add(@"System.dll");
            paras.ReferencedAssemblies.Add(@"System.IO.dll");
            paras.ReferencedAssemblies.Add(@"System.Xml.dll");
            paras.ReferencedAssemblies.Add(@"Message.ClientProtocol.dll");
            paras.ReferencedAssemblies.Add(@"ProtoParserLib.dll");
            paras.ReferencedAssemblies.Add(@"LibLog.dll");
            paras.ReferencedAssemblies.Add(@"ProtocolCodec.dll");
            paras.ReferencedAssemblies.Add(@"protobuf-net.dll");
            paras.ReferencedAssemblies.Add(@"TcpLib.dll");
            paras.ReferencedAssemblies.Add(@"PlayerInfoLib.dll");

            paras.GenerateInMemory = false;
            paras.GenerateExecutable = false;
            paras.OutputAssembly = newPath;

            CompilerResults result = complier.CompileAssemblyFromFile(paras,filesNames);

         
            return result;
        }
    }
}
