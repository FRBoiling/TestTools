using System;
using System.IO;
using System.Windows.Forms;

namespace LibUtil
{
    public class PathExt
    {
        static private string basePath = string.Empty;
        static private string dataPath = string.Empty;
        static private string clientDataPath = string.Empty;
        static private string sharedDataPath = string.Empty;
        //static private string serverDataPath = string.Empty;
        static private string toolPath = string.Empty;
        static private string serverPath = string.Empty;

        static public string workPath = string.Empty;

        public static void InitPath(string pathString = "")
        {
            //path不为空 则curPath = path
            string rootPath = string.Empty;
            if (string.IsNullOrEmpty(pathString))
            {
                DirectoryInfo path = new DirectoryInfo(Application.StartupPath);
                if (path.Parent.Exists)
                {
                    rootPath = path.Parent.FullName;
                }
                else
                {
                    Console.WriteLine("Path is error! Please check the input path!");
                    //Console.ReadKey();
                }
            }
            else
            {
                rootPath = pathString;
            }
            PathExt.SetPath(rootPath);
            Console.WriteLine("Init Path success!");
        }


        public static void SetTestPath(string pathString = "")
        {
            DirectoryInfo path = new DirectoryInfo(basePath);
            string testPath = path.Parent.FullName;
            workPath = testPath;
        }

        public static void SetTestPath1(string pathString = "")
        {
            DirectoryInfo path = new DirectoryInfo(basePath);
            string testPath = path.Parent.FullName;
            workPath = testPath;
        }

        static public void SetPath(string inputPath)
        {
            basePath = inputPath;
            dataPath = PathCombine(inputPath, "Data");
            //sharedDataPath = PathCombine(dataPath, "Shared");
            //clientDataPath = PathCombine(inputPath, "Client");
            //toolPath = PathCombine(inputPath, "Tool");
            //serverPath = PathCombine(inputPath, "Server");
            //serverDataPath = dataPath;
        }

        private static string PathCombine(string inputPath, string folder)
        {
            string newPath = Path.Combine(inputPath, folder);
            if (!Directory.Exists(newPath))
            {
                Directory.CreateDirectory(newPath);
            }
            return newPath;
        }

        static public string FullPathFromRoot(string subDir)
        {
            return PathCombine(basePath, subDir);
        }
        static public string FullPathFromClientData(string subDir)
        {
            return PathCombine(clientDataPath, subDir);
        }
        static public string FullPathFromSharedData(string subDir)
        {
            return PathCombine(sharedDataPath, subDir);
        }
        static public string FullPathFromServerData(string subDir)
        {
            return PathCombine(dataPath, subDir);
        }
        static public string FullPathFromTool(string subDir)
        {
            return PathCombine(toolPath, subDir);
        }
        static public string FullPathFromServer(string subDir)
        {
            return PathCombine(serverPath, subDir);
        }
    }
}

