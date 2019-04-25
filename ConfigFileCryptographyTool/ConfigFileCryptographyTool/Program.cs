using ConfigFileEncryptTool;
using System.Xml;

namespace ConfigFileCryptographyTool
{
    class Program
    {
        static void Main(string[] args)
        {
            CryptographyManager.Instance.Init();

            const string pxFileName = @"D:\clusterFrame\Bin\Data\XML\Server\DB\DBConfig.xml";
            const string cxFileName = @"D:\clusterFrame\Bin\Data\XML\Server\DB\DBConfig1.xml";

            XmlCryptography operation = new XmlCryptography();
            operation.WriteCipherXml(pxFileName,cxFileName);
            operation.ReadCipherXml(cxFileName);
        }
    }
}
