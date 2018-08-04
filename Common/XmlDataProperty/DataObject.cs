using System.Collections.Generic;
using System.Linq;

namespace DataProperty
{
    /// <summary>
    /// 单个数据
    /// </summary>
	public class DataObject
	{
        /// <summary>
        /// 属性回调
        /// </summary>
        /// <param name="property"></param>
		public delegate void PropertyCallback(Property property);

		private Dictionary<string, Property> properties;
        /// <summary>
        /// 属性结合
        /// </summary>
        public Dictionary<string, Property> Properties
        { get { return properties; } }

		private int id;
		private string name;
        /// <summary>
        /// 唯一ID
        /// </summary>
		public int ID { get { return id; } }
        /// <summary>
        /// 唯一NAME
        /// </summary>
		public string Name { get { return name; } }
        /// <summary>
        /// 构造函数
        /// </summary>
		public DataObject()
		{
			properties = new Dictionary<string, Property>();
		}
        /// <summary>
        /// 初始化
        /// </summary>
        /// <param name="data"></param>
		public void Init(Data data)
		{
			id = data.ID;
			name = data.Name;

			foreach(var pair in data)
			{
				var property = pair.Value;
				properties.Add(property.Key, property.Clone() as Property);
			}
		}
        /// <summary>
        /// 获取属性数量
        /// </summary>
        /// <returns></returns>
        public int GetPropertyCount()
        {
            return properties.Count;
        }
        /// <summary>
        /// 获取KEY
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public string GetKeyByIndex(int index)
        {
            return properties.Keys.ElementAt(index);
        }
        /// <summary>
        /// 取属性
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
		public Property Get(string key)
		{
			Property prop = null;
			properties.TryGetValue(key, out prop);

			return prop;
		}
        /// <summary>
        /// 取INT
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
		public int GetInt(string key)
		{
			return Get(key).GetInt();
		}
        /// <summary>
        /// 取float
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
		public float GetFloat(string key)
		{
			return Get(key).GetFloat();
		}
        /// <summary>
        /// 取string
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
		public string GetString(string key)
		{
            Property prop = Get(key);
            if (prop == null)
            {
                return string.Empty;
            }
            else
            {
                return prop.GetString();
            }
		}
        /// <summary>
        /// 索引值
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        /// <returns></returns>
		public bool TryGetValue(string key, out int value)
		{
			value = 0;
			var prop = Get(key);
			if (prop == null)
			{
				return false;
			}
			if (prop.Type != ValueType.INT)
			{
				return false;
			}

			value = prop.GetInt();

			return true;
		}
        /// <summary>
        /// 索引值
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        /// <returns></returns>
		public bool TryGetValue(string key, out float value)
		{
			value = 0.0f;
			var prop = Get(key);
			if (prop == null)
			{
				return false;
			}
			if (prop.Type != ValueType.FLOAT)
			{
				return false;
			}

			value = prop.GetFloat();

			return true;
		}
        /// <summary>
        /// 索引值
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        /// <returns></returns>
		public bool TryGetValue(string key, out string value)
		{
			value = null;
			var prop = Get(key);
			if (prop == null)
			{
				return false;
			}
			if (prop.Type != ValueType.STRING)
			{
				return false;
			}

			value = prop.GetString();

			return true;
		}
        /// <summary>
        /// 赋值
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>     
		public void Set(string key, int value)
		{
			var type = ValueType.INT;
			Set(type, key, value);
		}
        /// <summary>
        /// 赋值
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
		public void Set(string key, float value)
		{
			var type = ValueType.FLOAT;
			Set(type, key, value);
		}
        /// <summary>
        /// 赋值
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
		public void Set(string key, string value)
		{
			var type = ValueType.STRING;
			Set(type, key, value);
		}
        /// <summary>
        /// 赋值
        /// </summary>
        /// <param name="type"></param>
        /// <param name="key"></param>
        /// <param name="value"></param>
		public void Set(ValueType type, string key, object value)
		{
            if (properties.ContainsKey(key))
            {
                var prop = properties[key];
                prop.Set(type, value);
            }
            else
            {
                Property prop = new Property(type, key, value);
                properties.Add(key, prop);
            }
		}
        /// <summary>
        /// 赋值
        /// </summary>
        /// <param name="prop"></param>
        public void Set(Property prop)
        {
            if (properties.ContainsKey(prop.Key))
            {
                var ref_prop = properties[prop.Key];
                ref_prop.Set(prop.Type, prop.Value);
            }
            else
            {
                properties.Add(prop.Key, prop);
            }
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
			foreach (var pair in properties)
			{
				callback(pair.Value);
			}
		}
	}
}