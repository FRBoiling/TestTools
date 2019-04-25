using ConfigFileCryptographyTool;
using System;
using System.Security.Cryptography;
using System.Xml;

namespace ConfigFileEncryptTool
{
    class XmlCryptography
    {
        XmlDocument cipherXmlDoc_;

        XmlDocument plainXmlDoc_;

        public XmlDocument EncryptXml(string pxFileName)
        {
            var doc = new XmlDocument();
            doc.Load(pxFileName);

            string cipherXml = CryptographyManager.Instance.EncryptXml(doc);

            return doc;
        }

        public XmlDocument DecryptXml(string cxFileName)
        {
            var doc = new XmlDocument();
            doc.Load(cxFileName);

            string plainSrcXml = CryptographyManager.Instance.DecryptXml(doc);
            plainXmlDoc_ = doc;

            return doc;
        }

        public void WriteCipherXml(string pxFileName, string cxFileName)
        {
            EncryptXml(pxFileName).Save(cxFileName);
        }

        public void ReadCipherXml(string cxFileName)
        {
            string plainSrcXml = DecryptXml(cxFileName).InnerXml;
        }
    }
}
