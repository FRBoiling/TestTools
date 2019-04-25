using System.Xml;

namespace ConfigFileEncryptTool
{
    public interface ICryptography
    {
        string Encrypt(string pxFileName);
        string Decrypt(string cxFileName);

        string Encrypt(XmlDocument pxDoc);
        string Decrypt(XmlDocument cxDoc);

        string GetKey();

        string GenerateKey();
        string GetCacheKey();
        void Init(bool needNewKey = true);
    }
}