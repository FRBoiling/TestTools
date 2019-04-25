using ConfigFileCryptographyTool;
using System.Xml;

namespace ConfigFileEncryptTool
{
    public sealed class CryptographyManager
    {
        private CryptographyManager(){}

        private static readonly CryptographyManager instance_ = new CryptographyManager();

        public static CryptographyManager Instance
        {
            get { return CryptographyManager.instance_; }
        }

        //ICryptography cryptography_ =null;
        RijndaelManagedCryptography cryptography_ = null;

        public bool needNewKey_ = true;

        public void Init()
        {
            //FIXME: needNewKey_通过传参数或者读配置文件来初始化，这里先直接赋值
            needNewKey_ = true;
            cryptography_ =new RijndaelManagedCryptography();
            cryptography_.Init(needNewKey_);
        }

        public string GetKey()
        {
            return cryptography_.GetKey();
        }

        public string GenerateKey()
        {
            return cryptography_.GenerateKey();
        }

        public string GetCacheKey()
        {
            return cryptography_.GetCacheKey();
        }

        public string EncryptXml(string pxFileName)
        {
            return cryptography_.Encrypt(pxFileName);
        }

        public string DecryptXml(string cxFileName)
        {
            return cryptography_.Decrypt(cxFileName);
        }

        public string EncryptXml(XmlDocument pxDoc)
        {
            return cryptography_.Encrypt(pxDoc);
        }

        public string DecryptXml(XmlDocument cxDoc)
        {
            return cryptography_.Decrypt(cxDoc);
        }
    }
}
