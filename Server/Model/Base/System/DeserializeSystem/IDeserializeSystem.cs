using System;
using System.Collections.Generic;
using System.Text;

namespace Model.System
{
    /// <summary>
    /// 反序列化后执行的System
    /// 要小心使用这个System，因为对象假如要保存到数据库，到dbserver也会进行反序列化，那么也会执行该System
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IDeserializeSystem
    {
        Type Type();
        void Run(object o);
    }
}
