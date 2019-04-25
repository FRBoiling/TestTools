using System.Xml;

namespace ConfigFileCryptographyTool
{
    interface IXmlCryptography
    {
        XmlDocument EncryptXml(string pxFileName);
        XmlDocument DecryptXml(string cxFileName);

        void WriteCipherXml(string pxFileName,string cxFileName);

        void ReadCipherXml(string cxFileName);
    }
}
