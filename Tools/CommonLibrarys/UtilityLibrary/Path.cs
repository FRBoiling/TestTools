using Logger;
using System;
using System.IO;
using System.Windows.Forms;

namespace UtilityLibrary
{
    public class PathExt
    {
        static public string binPath = string.Empty;
        static public string dataPath = string.Empty;
        static public string codePath = string.Empty;
        static public string rootPath = string.Empty;
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
                    Log.WriteLine("Path is error! Please check the input path!");
                    //Console.ReadKey();
                }
            }
            else
            {
                rootPath = pathString;
            }
            PathExt.SetPath(rootPath);
            //Log.WriteLine("Init Path success!");
        }

        static public void SetPath(string inputPath)
        {
            binPath = inputPath;
            dataPath = PathCombine(binPath, "Data");
            codePath = PathCombine(binPath, "Code");

            DirectoryInfo path = new DirectoryInfo(binPath);
            rootPath = path.Parent.FullName;
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

        //static public string FullPathFromRoot(string subDir)
        //{
        //    return PathCombine(basePath, subDir);
        //}
        //static public string FullPathFromClientData(string subDir)
        //{
        //    return PathCombine(clientDataPath, subDir);
        //}
        //static public string FullPathFromSharedData(string subDir)
        //{
        //    return PathCombine(sharedDataPath, subDir);
        //}
        static public string FullPathFromServerData(string subDir)
        {
            return PathCombine(dataPath, subDir);
        }
        //static public string FullPathFromTool(string subDir)
        //{
        //    return PathCombine(toolPath, subDir);
        //}
        //static public string FullPathFromServer(string subDir)
        //{
        //    return PathCombine(serverPath, subDir);
        //}
    }
}

