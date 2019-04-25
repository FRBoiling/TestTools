using System;
using System.Xml;
using System.IO;

namespace DataProperty
{
    internal class Parser
    {
        private string filename;

        internal DataList Parse(string filename, string text = null)
        {
            this.filename = filename;

            // XML
            var doc = new XmlDocument();
            try
            {
                if (string.IsNullOrEmpty(text))
                    doc.Load(filename);
                else doc.LoadXml(text);
            }
            catch (Exception e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(e);
                return null;
            }

            // Begin parsing
            var dataList = ParseIdspace(doc);

            if (ParseHeader(dataList, doc) == false)
            {
                return null;
            }
            if (ParseData(dataList, doc) == false)
            {
                return null;
            }

            return dataList;
        }

        internal ValueType ParseValue(string input, out object outValue)
        {
            ValueType ret;

            int outInt;
            float outFloat;

            if (int.TryParse(input, out outInt) == true)
            {
                ret = ValueType.INT;
                outValue = outInt;
            }
            else if (float.TryParse(input, out outFloat) == true)
            {
                ret = ValueType.FLOAT;
                outValue = outFloat;
            }
            else
            {
                ret = ValueType.STRING;
                outValue = input;
            }

            return ret;
        }
        private void ParseAttributes(Data data, XmlAttributeCollection attributes)
        {
            foreach (XmlAttribute attr in attributes)
            {
                object outValue;
                var type = ParseValue(attr.Value, out outValue);

                var property = new Property(type, attr.Name, outValue);

                data.SetProperty(property);
            }
        }
        private DataList ParseIdspace(XmlDocument doc)
        {
            var dataListID = doc.DocumentElement.GetAttribute("id");
            var dataList = DataListManager.inst.GetDataList(dataListID);
            if (dataList == null)
            {
                dataList = new DataList();
                dataList.Init(dataListID);
            }

            return dataList;
        }
        private bool ParseHeader(DataList dataList, XmlDocument doc)
        {
            // Header
            var headers = doc.GetElementsByTagName("header");
            if (headers.Count == 0)
            {
                // 无可能
            }
            else if (headers.Count == 1)
            {
                var header = dataList.Header;
                var headerTag = headers.Item(0);

                ParseAttributes(header, headerTag.Attributes);
            }
            else // 两个以上的反面
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("File " + filename + " has more than one header tag");
                return false;
            }

            return true;
        }
        private bool ParseData(DataList dataList, XmlDocument doc)
        {
            var xmlData = doc.GetElementsByTagName("class");

            int index = 0;
            foreach (XmlNode xmlDatum in xmlData)
            {
                index++;

                var data = new Data();

                // id should be unique
                int id = index;
                
                var idAttribute = xmlDatum.Attributes["id"];
                if (idAttribute != null)
                {
                    string idString = idAttribute.Value;
                    id = int.Parse(idString);
                    xmlDatum.Attributes.Remove(idAttribute);
                }

                data.SetID(id);

				// Name should be unique too, only if it exists
				var nameAttribute = xmlDatum.Attributes["name"];
				if(nameAttribute != null && nameAttribute.Value.Length != 0)
				{
					var name = nameAttribute.Value;
					data.SetName(name);
					xmlDatum.Attributes.Remove(xmlDatum.Attributes["name"]);
				}

                var groupAttribute = xmlDatum.Attributes["group"];
                if (groupAttribute != null && groupAttribute.Value.Length != 0)
                {
                    var group = groupAttribute.Value;
                    data.SetGroup(group);
                    xmlDatum.Attributes.Remove(xmlDatum.Attributes["group"]);
                }

                ParseAttributes(data, xmlDatum.Attributes);

                dataList.AddData(data);
            }

            return true;
        }
    }
}