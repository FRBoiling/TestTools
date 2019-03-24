using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PressureTestToolLib
{
    public class Parameter
    {
        string key = string.Empty;
        List<string> paramList = new List<string>();

        public string Key
        {
            get
            {
                return key;
            }
        }

        public List<string> ParamList
        {
            get
            {
                return paramList;
            }
        }

        public void Format(string strCommand) {

            int index = strCommand.IndexOf(" ");
            if (index > 0)
            {
                key = strCommand.Substring(0, index).ToLower();
                string tempCommand = strCommand.Substring(index);
                paramList= tempCommand.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).ToList();
            }
            else
            {
                key = strCommand;
            }
           
        }
    }
}
