using Logger;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PressureTestToolLib
{
    class CommandChain
    {
        Dictionary<string, AbstractCommand> chain = new Dictionary<string, AbstractCommand>();
        public void AddCommand(AbstractCommand command)
        {
            string key = command.GetKey();
            if (chain.ContainsKey(key))
            {
                return;
            }
            else
            {
                chain.Add(key, command);
            }
        }
        public void DelCommand(string key)
        {
            if (chain.ContainsKey(key))
            {
                chain.Remove(key);
            }
            else
            {
                Log.Error("del fail : got an wrong command key {0}", key);
            }
        }

        private AbstractCommand GetCommand(string key)
        {
            AbstractCommand command = null;
            chain.TryGetValue(key, out command);
            return command;
        }

        internal void Excute(Parameter parameter)
        {
            AbstractCommand command = GetCommand(parameter.Key);
            if (command == null)
            {
                string strParam = "";
                if (parameter.Key == "help")
                {
                    if (parameter.ParamList.Count > 0)
                    {
                        strParam = parameter.ParamList[0];
                    }
                }
                GetHelp(strParam);
                return;
            }
            command.Excute(parameter);
        }

        private void GetHelp(string param = "")
        {
            if (param == "")
            {
                foreach (var item in chain)
                {
                    Console.WriteLine(item.Value.GetHelp());
                }
            }
            else
            {
                AbstractCommand command = null;
                if (chain.TryGetValue(param, out command))
                {
                    Console.WriteLine(command.GetHelp());
                }
            }
        }
    }
}
