using System;
using System.Collections.Generic;
using System.Reflection;

namespace UtilityLibrary
{
    /// <summary>
    /// 反射结果类
    /// </summary>
    public class AssemblyResult
    {
       public Assembly Assembly;
        /// <summary>
        /// 程序集名称
        /// </summary>
        public List<string> AssemblyNameList { get; set; }
        /// <summary>
        /// 类名列表
        /// </summary>
        public Dictionary<string,string> ClassList { get; set; }

        /// <summary>
        /// 类
        /// </summary>
        public Dictionary<string, Type> ClassTypeList { get; set; }

    }
}
