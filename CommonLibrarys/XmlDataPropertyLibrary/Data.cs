using System.Collections.Generic;
using System;

namespace DataProperty
{
    /// <summary>
    /// 单个数据
    /// </summary>
    public class Data
    {
        /// <summary>
        /// 属性回调
        /// </summary>
        /// <param name="property"></param>
		public delegate void PropertyCallback(Property property);

		private DataList dataList;
		private int id;
		private string name;
        private string group;
		private readonly Dictionary<string, Property> properties;
        /// <summary>
        /// 唯一ID
        /// </summary>
		public int ID { get { return id; } }
        /// <summary>
        /// 唯一NAME
        /// </summary>
		public string Name { get { return name; } }
        /// <summary>
        /// 组
        /// </summary>
        public string Group { get { return group; } }
        /// <summary>
        /// 构造函数
        /// </summary>
        public Data()
		{
			properties = new Dictionary<string, Property>();             
		}

		internal void SetOwner(DataList owner)
		{
			dataList = owner;
		}

		internal void SetID(int id)
		{
			this.id = id;
		}

		internal void SetName(string name)
		{
			this.name = name;
		}

        internal void SetGroup(string group)
        {
            this.group = group;
        }

		internal bool SetProperty(Property value)
		{
			if(properties.ContainsKey(value.Key))
			{
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("idspace '{0}' - class '{1}' has more than one property named '{2}.'", dataList.ID, ID, value.Key);
				return false;
			}

			properties.Add(value.Key, value);
			return true;
		}
        /// <summary>
        /// 取值
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
		public Property Get(string key)
		{
			Property ret;
			properties.TryGetValue(key, out ret);

			return ret;
		}
        /// <summary>
        /// 取INT值
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
		public int GetInt(string key)
		{
            Property prob = Get(key);
            if (prob == null) return 0;
			else return Get(key).GetInt();
		}

        public bool GetBoolean(string key)
        {
            Property prob = Get(key);
            if (prob == null)
            {
                return false;
            }
            else if (Get(key).GetInt() > 0)
            {
                return true;
            }
            return false;
        }
        /// <summary>
        /// 取float值
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
		public float GetFloat(string key)
		{
            Property prob = Get(key);
            if (prob == null) return 0f;
            else return Get(key).GetFloat();
		}
        /// <summary>
        /// 取string值
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
		public string GetString(string key)
		{
            Property prob = Get(key);
            if (prob == null) return "";            
			return prob.GetString();
		}

		/// <summary>
        ///  IEnumerable<T> implementation
		/// </summary>
		/// <returns></returns>
		public IEnumerator<KeyValuePair<string, Property>> GetEnumerator()
		{
			return properties.GetEnumerator();
		}
        /// <summary>
        /// Foreach
        /// </summary>
        /// <param name="callback"></param>
		public void Foreach(System.Action<Property> callback)
		{
			foreach(var pair in properties)
			{
				callback(pair.Value);
			}
		}
    }
}