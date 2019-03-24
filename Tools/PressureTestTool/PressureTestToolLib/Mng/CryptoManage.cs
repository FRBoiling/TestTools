using Logger;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UtilityLibrary;

namespace PressureTestToolLib
{
    public class CryptoManage : Singleton<CryptoManage>
    {
        static string _key;
        public static string Key
        {
            get
            {
                return _key;
            }

            set
            {
                _key = value;
            }
        }


        public void Init()
        {
            try
            {
                string path = PathExt.dataPath + @"\PublicKey.key";
                FileStream fsRead = new FileStream(path, FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fsRead);
                _key = sr.ReadLine();

                sr.Close();
                fsRead.Close();
                Log.Info("PublicKey set success");
            }
            catch (Exception e)
            {
                Log.Error("PublicKey set fail:{0}", e.ToString());
            }
        }
    }
}
