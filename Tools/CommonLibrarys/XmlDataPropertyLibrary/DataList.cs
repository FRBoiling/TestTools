using System;
using System.Collections.Generic;
using System.Linq;

namespace DataProperty
{
    /// <summary>
    /// 多组数据
    /// </summary>
	public class DataList : IEnumerable<KeyValuePair<int, Data>>
	{
        /// <summary>
        /// 回调
        /// </summary>
        /// <param name="data"></param>
		public delegate void OnDataCallback(Data data);

		private string id;
		private Data header;

		private Dictionary<int, Data> dataListByID;
        public Dictionary<int, Data> AllData
        { get { return dataListByID; } }

		private Dictionary<string, Data> dataListByName;
        private Dictionary<string, List<Data>> dataListByGroup;
        /// <summary>
        /// XML名
        /// </summary>
		public string ID { get { return id; } }
		/// <summary>
        /// Header
		/// </summary>
        public Data Header { get { return header; } }

		internal DataList()
		{
			dataListByID = new Dictionary<int, Data>();
			dataListByName = new Dictionary<string, Data>();
            dataListByGroup = new Dictionary<string, List<Data>>();
			header = new Data();
			header.SetOwner(this);
		}
        /// <summary>
        /// 初始化
        /// </summary>
        /// <param name="id"></param>
		public void Init(string id)
		{
			this.id = id;
		}
        /// <summary>
        /// 添加新DATA
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
		public bool AddData(Data data)
		{
			if(dataListByID.ContainsKey(data.ID))
			{
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("idspace '{0}' has duplicated id '{1}'", ID, data.ID);
				return false;
			}
			else if(data.Name != null && dataListByName.ContainsKey(data.Name))
			{
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("idspace '{0}' has duplicated name '{1}'", ID, data.Name);
				return false;
			}

			data.SetOwner(this);
			dataListByID.Add(data.ID, data);
			if (data.Name != null)
			{
				dataListByName.Add(data.Name, data);
			}

            if (data.Group != null)
            {
                List<Data> groupList = null;
                if (dataListByGroup.ContainsKey(data.Group) == true)
                {
                    groupList = dataListByGroup[data.Group];
                }
                else
                {
                    groupList = new List<Data>();
                    dataListByGroup.Add(data.Group, groupList);
                }

                groupList.Add(data);
            }

			return true;
		}

		public Data Get(int id)
		{
			Data data = null;
			dataListByID.TryGetValue(id, out data);

			return data;
		}

		public Data Get(string name)
		{
			Data data = null;
			dataListByName.TryGetValue(name, out data);

			return data;
		}
        
        public List<Data> GetByGroup(string group)
        {
            List<Data> dataList = null;
            dataListByGroup.TryGetValue(group, out dataList);

            return dataList;
        }

        public int Count
        {
            get
            {
                return dataListByID.Count;
            }
        }

        public Data GetByIndex(int index)
        {
            if (index >= 0 && index < Count)
            {
                return dataListByID.Values.ElementAt(index);
            }
            return null;
        }

		public void ForeachData(OnDataCallback callback)
		{
			foreach(var pair in dataListByID)
			{
				callback(pair.Value);
			}
		}

		public IEnumerator<KeyValuePair<int, Data>> GetEnumerator()
		{
			return dataListByID.GetEnumerator();
		}
		System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			return dataListByID.GetEnumerator();
		}
	}
}
