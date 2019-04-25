using Logger;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Reflection;
using UtilityLibrary;

namespace ProtocolObjectParserLib
{
    public class AssemblyParser
    {
        public static bool AssemblyParse(string codepPath)
        {
            string code = ParseCode.AssemblyParseDll(ConstData.ServerMsgDll);
            string soure = codepPath + ConstData.GenrateCodePathName;
            string str1 = soure + ConstData.GenrateCodeFileName;

            string[] files = new string[] { str1 };

            CompilerResults result = ParseCode.DebugRun(files, ConstData.ProtocolObjectDll);
            if (result.Errors.HasErrors)
            {

                foreach (CompilerError err in result.Errors)
                {
                    Log.ErrorLine(err.ErrorText);
                    return false;
                }
            }
            else
            {
                Assembly objAssembly = result.CompiledAssembly;
                object objectClient = objAssembly.CreateInstance(ConstData.BaseTypeName);
                if (objectClient != null)
                {
                    //client = new Client(objectClient);
                    Log.WriteLine("Compile {0} success ", ConstData.ProtocolObjectDll);
                }
                else
                {
                    Log.ErrorLine("Compile {0} fail ", ConstData.ProtocolObjectDll);
                }
            }
            return true;
        }

        public static void GetAsseblyResult(out AssemblyHandler handler, out AssemblyResult result)
        {
            //AssemblyHandler handler = new AssemblyHandler();
            handler = new AssemblyHandler();
            //AssemblyResult result = handler.GetClassName(ClientMsgDll);
            result = handler.GetClassName(ConstData.ServerMsgDll);
            result.AssemblyNameList = new List<string>();
            result.AssemblyNameList.Add(ConstData.ServerMsgDll);
        }

    }
}
