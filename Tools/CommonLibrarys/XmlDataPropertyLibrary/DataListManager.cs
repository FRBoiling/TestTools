using System.Collections.Generic;

namespace DataProperty
{
    /// <summary>
    /// 整合xml
    /// </summary>
    public class DataListManager
    {
        /// <summary>
        /// Singleton
        /// </summary> 
        public static DataListManager inst = new DataListManager();

        private Parser parser;
        private Dictionary<string, DataList> dataLists;
        public Dictionary<string, DataList> DataLists
        { get { return dataLists; } }

        private DataListManager()
        {
            parser = new Parser();
            dataLists = new Dictionary<string, DataList>();
        }
        /// <summary>
        /// 初始化List
        /// </summary>
        public static void InitManager()
        {
            inst = new DataListManager();
        }
        /// <summary>
        /// 解析
        /// </summary>
        /// <param name="filename"></param>
        /// <param name="text"></param>
        /// <returns></returns>
        public bool Parse(string filename, string text = null)
        {
            var dataList = parser.Parse(filename, text);
            if (dataList == null)
            {
                return false;
            }
            else if (dataLists.ContainsKey(dataList.ID))
            {
                return true;
            }
            else
            {
                dataLists.Add(dataList.ID, dataList);
                return true;
            }
            //dataLists[dataList.ID] = dataList;
            //return true;
        }
        /// <summary>
        /// 获取LIST
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public DataList GetDataList(string id)
        {
            DataList dataList;
            dataLists.TryGetValue(id, out dataList);
            return dataList;
        }
        /// <summary>
        /// 获取DATA
        /// </summary>
        /// <param name="idspaceID"></param>
        /// <param name="classID"></param>
        /// <returns></returns>
        public Data GetData(string idspaceID, int classID)
        {
            Data data = null;

            var dataList = GetDataList(idspaceID);
            if (dataList != null)
            {
                data = dataList.Get(classID);
            }

            return data;
        }
        /// <summary>
        /// 获取DATA
        /// </summary>
        /// <param name="idspaceID"></param>
        /// <param name="className"></param>
        /// <returns></returns>
        public Data GetData(string idspaceID, string className)
        {
            Data data = null;

            var dataList = GetDataList(idspaceID);
            if (dataList != null)
            {
                data = dataList.Get(className);
            }

            return data;
        }
        /// <summary>
        /// 获取类型
        /// </summary>
        /// <param name="value"></param>
        /// <param name="output"></param>
        /// <returns></returns>
		public ValueType GetValueType(string value, out object output)
		{
			return parser.ParseValue(value, out output);
		}


        ///映射表
        DataList propertise;
        /// <summary>
        /// 性能
        /// </summary>
        public DataList Propertise
        {
            get
            {
                if (propertise == null)
                {
                    propertise = inst.GetDataList("NatureORM");
                };
                return propertise;
            }
        }

        public int QueryPropIdByName(string name)
        {
            var data = Propertise.Get(name);
            if (data != null)
            {
                return data.ID;
            }
            else
            {
                return 0;
            }   
        }

        public string QureyPropNameById(int id)
        {
            var data = Propertise.Get(id);
            if (data != null)
            {
                return data.Name;
            }
            else
            {
                return "Not Fount Property!";
            }  
        }

        public string QureyPropCNNameById(int id)
        {
            var data = Propertise.Get(id);
            if (data != null)
            {
                return data.GetString("NameCN");
            }
            else
            {
                return "未开启";
            }  
        }

        ///映射表
        DataList limit;

        public DataList Limit
        {
            get
            {
                if (limit == null)
                {
                    limit = inst.GetDataList("Limit");
                };
                return limit;
            }
        }

    }
}
