using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataProperty
{
    /// <summary>
    /// 扩展
    /// </summary>
	public static class Extension
	{
        /// <summary>
        /// 创建
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
		public static DataObject CreateObject(this Data data)
		{
			var obj = new DataObject();
			obj.Init(data);

			return obj;
		}
	}
}
