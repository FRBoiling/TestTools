using Logger;
using Microsoft.CSharp;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.IO;
using UtilityLibrary;

namespace ProtocolObjectParserLib
{
    public class ParseCode
    {

        /// <summary>
        /// 根据反射读取协议dll,并生成协议解析源码
        /// </summary>
        /// <param name="assemblyName"></param>
        public static string AssemblyParseDll(string assemblyName)
        {
            AssemblyHandler handler = new AssemblyHandler();
            AssemblyResult result = handler.GetClassName(assemblyName);
            result.AssemblyNameList = new List<string>();
            result.AssemblyNameList.Add(assemblyName);

            string strGenerateCode = GenerateCodeModel.GenerateCode(result.ClassList);
            //string codeFileName = "Client_Code.cs";
            string codeFileName = ConstData.GenrateCodeFileName;

            try
            {
                string codeFileFullName = PathExt.codePath + ConstData.GenrateCodePathName + codeFileName;
                FileInfo fCodeFileName = new FileInfo(codeFileFullName);
                StreamWriter wResponseRecv = fCodeFileName.CreateText();
                wResponseRecv.WriteLine(strGenerateCode);
                wResponseRecv.Close();

                //codeFileFullName = PathExt.rootPath + ConstData.GenrateCodePathName + codeFileName;
                //fCodeFileName = new FileInfo(codeFileFullName);
                //wResponseRecv = fCodeFileName.CreateText();
                //wResponseRecv.WriteLine(strGenerateCode);
                //wResponseRecv.Close();
            }
            catch (System.Exception e)
            {
                Log.Error("e {0}",e.Message);
            }

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
            //paras.ReferencedAssemblies.Add(@"protobuf-net.dll");
            paras.ReferencedAssemblies.Add(@"Google.Protobuf.dll");
            paras.ReferencedAssemblies.Add(ConstData.ClientMsgDll);
            paras.ReferencedAssemblies.Add(@"ProtocolObjectParserLib.dll");
            paras.ReferencedAssemblies.Add(@"MessagePacker.dll");

            paras.GenerateExecutable = false;
            paras.OutputAssembly = newPath;

            CompilerResults result = complier.CompileAssemblyFromFile(paras,filesNames);
            return result;
        }
    }
}
