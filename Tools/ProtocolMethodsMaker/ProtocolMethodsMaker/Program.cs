using ProtocolObjectParserLib;
using System;
using UtilityLibrary;

namespace ProtocolMethodsMaker
{
    class Program
    {
        static void Main(string[] args)
        {
            LogManager.inst.Init();
            PathExt.InitPath();

            AssemblyParser.AssemblyParse(PathExt.codePath);
            Console.ReadKey();
        }
       
    }
}
