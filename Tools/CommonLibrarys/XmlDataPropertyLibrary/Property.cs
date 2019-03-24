using System;

namespace DataProperty
{
    /// <summary>
    /// 类型
    /// </summary>
    public enum ValueType
    {
        /// <summary>
        /// INT
        /// </summary>
        INT,
        /// <summary>
        /// FLOAT
        /// </summary>
        FLOAT,
        /// <summary>
        /// STRING
        /// </summary>
        STRING
    }
    /// <summary>
    /// 属性
    /// </summary>
    public class Property : ICloneable
    {
        private ValueType type;
        private string key;
        private object value;
        /// <summary>
        /// 类型
        /// </summary>
        public ValueType Type { get { return type; } set { type = value; } }
        /// <summary>
        /// KEY
        /// </summary>
        public string Key { get { return key; } set { key = value; } }
        /// <summary>
        /// 值
        /// </summary>
        public object Value { get { return value; } }
        /// <summary>
        /// 构造函数
        /// </summary>
        public Property(ValueType type, string key, object value)
        {
            Set(type, key, value);
        }
        /// <summary>
        /// 拷贝
        /// </summary>
        /// <returns></returns>
        public object Clone()
        {
            var clone = new Property(type, key, value);
            clone.type = type;
            clone.key = key;
            clone.value = value;

            return clone;
        }
        /// <summary>
        /// 解析
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        public void ParseSet(string key, string value)
        {

        }
        /// <summary>
        /// 赋值
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        public void Set(string key, int value)
        {
            Set(ValueType.INT, key, value);
        }
        /// <summary>
        /// 赋值
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        public void Set(string key, float value)
        {
            Set(ValueType.FLOAT, key, value);
        }
        /// <summary>
        /// 赋值
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        public void Set(string key, string value)
        {
            Set(ValueType.STRING, key, value);
        }
        /// <summary>
        /// 赋值
        /// </summary>
        /// <param name="type"></param>
        /// <param name="key"></param>
        /// <param name="value"></param>
        public void Set(ValueType type, string key, object value)
        {
            this.type = type;
            this.key = key;
            this.value = value;
        }
        /// <summary>
        /// 赋值
        /// </summary>
        /// <param name="type"></param>
        /// <param name="value"></param>
        public void Set(ValueType type, object value)
        {
            this.type = type;
            this.value = value;
        }
        /// <summary>
        /// 取INT值
        /// </summary>
        /// <returns></returns>
        public int GetInt()
        {
            if (type == ValueType.STRING)
            {
                int ret = 0;
                int.TryParse(value.ToString().Trim(), out ret);
                return ret;
            }
            else
            if (type == ValueType.FLOAT)
            {
                return (int)(float)value;
            }
            
            return (int)value;
        }
        /// <summary>
        /// 取STRING
        /// </summary>
        /// <returns></returns>
        public string GetString()
        {
            return value.ToString().Trim();
        }
        /// <summary>
        /// 取FLOAT
        /// </summary>
        /// <returns></returns>
        public float GetFloat()
        {
            if (type == ValueType.STRING)
            {
                float ret = 0.0f;
                float.TryParse(value.ToString().Trim(), out ret);
                return ret;
            }
            else if (type == ValueType.INT)
            {
                return (float)(int)value;
            }

            return (float)value;
        }
    }
}
