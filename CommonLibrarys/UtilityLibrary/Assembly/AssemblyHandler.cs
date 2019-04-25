using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;

namespace UtilityLibrary
{
    /// <summary>
    /// 反射处理类
    /// </summary>
    public class AssemblyHandler
    {
        string path = AppDomain.CurrentDomain.SetupInformation.ApplicationBase + @"..\..\..\ThirdLib";
        //D:\NewProject\ProjectX\Bin\Server\Message.ClientProtocol.dll
        /// <summary>
        /// 获取程序集名称列表
        /// </summary>
        /// <returns></returns>
        public AssemblyResult GetAssemblyName()
        {
            AssemblyResult result = new AssemblyResult();
            string[] dicFileName = Directory.GetFileSystemEntries(path);
            if (dicFileName!=null)
            {
                List<string> assemblyList = new List<string>();
                foreach (var item in dicFileName)
                {
                    assemblyList.Add(item.Substring(item.LastIndexOf('/') + 1));
                }
                result.AssemblyNameList = assemblyList;
            }
            return result;
        }
  
        /// <summary>
        /// 获取程序集中的类名称
        /// </summary>
        /// <param name="assemblyName">程序集</param>
        /// <returns></returns>
        public AssemblyResult GetClassName(string assemblyName)
        {
            AssemblyResult result = new AssemblyResult();
            if (!String.IsNullOrEmpty(assemblyName))
            {
                Assembly assembly = Assembly.LoadFrom(assemblyName);
                result.Assembly = assembly;

                Type[] ts = assembly.GetTypes();
                Dictionary<string ,string> classList = new Dictionary<string,string>();
                Dictionary<string , Type> classTypeList = new Dictionary<string, Type>();
                foreach (var item in ts)
                {
                    if (item.FullName.Contains("Message"))
                    {
                        if (item.Name.Contains("Api")||item.FullName.Contains("+"))
                        {

                        }
                        else
                        {
                            classList.Add(item.Name, item.FullName);
                        }
                    }
                    else
                    {
                        string temp;
                        if (classList.TryGetValue(item.Name,out temp))
                        {
                            
                        }
                        else
                        {
                            classList.Add(item.Name, item.FullName);
                            classTypeList.Add(item.Name, item);
                        }
                    }
                }
                result.ClassTypeList = classTypeList;
                result.ClassList = classList;
            }
            return result;
        }

        /// <summary>
        /// 获取类的属性、方法
        /// </summary>
        /// <param name="assemblyName"></param>
        /// <param name="className"></param>
        /// <returns></returns>
        public AssemblyClassInfo GetClassInfo(string assemblyName,string className)
        {
            AssemblyClassInfo result = new AssemblyClassInfo();
            result.ClassFullName = className;
            if (!String.IsNullOrEmpty(assemblyName) && !String.IsNullOrEmpty(className))
            {
                Assembly assembly = Assembly.LoadFrom(assemblyName);
                Type type = assembly.GetType(className, true, true);
                if (type!=null)
                {
                    result.ClassFullName = type.FullName;
                    result.ClassName = type.Name;
                    List<PropertyInfo> propertieList = new List<PropertyInfo>();
                    //PropertyInfo[] propertyinfo = type.GetProperties(BindingFlags.Instance | BindingFlags.Public);
                    PropertyInfo[] propertyinfo = type.GetProperties(BindingFlags.Public);
                    foreach (var item in propertyinfo)
                    {
                        propertieList.Add(item);
                    }
                    result.Properties = propertieList;

                    //类的方法
                    List<MethodInfo> methods = new List<MethodInfo>();
                    MethodInfo[] methodInfos = type.GetMethods(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public);
                    foreach (var item in methodInfos)
                    {
                        methods.Add(item);
                        ////方法参数
                        //foreach (ParameterInfo p in item.GetParameters())
                        //{
                        //}
                        ////方法返回值
                        //string returnParameter = item.ReturnParameter.ToString();
                    }
                    result.Methods = methods;
                }
            }
            return result;
        }



    }
}
