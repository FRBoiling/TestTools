using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using UtilityLibrary;

namespace PressureTestToolLib
{

    public class ConsoleInputHandler : Singleton<ConsoleInputHandler>
    {
        bool run = true;

        CommandChain commandChain =new CommandChain();
        public void Init()
        {
            commandChain.AddCommand(new Command_AddClient());
            commandChain.AddCommand(new Command_ChoseOneClient());
            commandChain.AddCommand(new Command_Login());
            commandChain.AddCommand(new Command_Move());
            commandChain.AddCommand(new Command_GetCount());
            commandChain.AddCommand(new Command_Exit());
        }

        public void Run()
        {
            while (run)
            {
                try
                {
                    string cmd = Console.ReadLine().ToLower().Trim();
                    Read(cmd);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
            }
        }

        public void Read(string cmd)
        {
            Parameter parameter = new Parameter();
            parameter.Format(cmd);
            commandChain.Excute(parameter);
        }

    }
}
