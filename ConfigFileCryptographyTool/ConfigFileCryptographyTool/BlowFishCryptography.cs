using ConfigFileEncryptTool;
using CryptoUtility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Xml;

namespace ConfigFileCryptographyTool
{
    class BlowFishCryptography : ICryptography
    {
        private BlowFish blowfish_;
        private string blowFishKey_;

        XmlDocument cipherXmlDoc_ ;

        XmlDocument plainXmlDoc_ ;

        public string Decrypt(string cxFileName)
        {
            var doc = cipherXmlDoc_;
            doc.Load(cxFileName);

            string cipherXml = doc.InnerXml;

            string plainXml = blowfish_.Decrypt_CBC(cipherXml);

            return plainXml;
        }

        public string Encrypt(string pxFileName)
        {
            var doc = plainXmlDoc_;
            doc.Load(pxFileName);

            string plainSrcXml = doc.InnerXml;

            string cipherXml = blowfish_.Encrypt_CBC(plainSrcXml);
            return cipherXml;
        }

        public string GenerateKey()
        {
            byte[] cipherKey = new byte[8];
            RNGCryptoServiceProvider keyProvider = new RNGCryptoServiceProvider();
            keyProvider.GetBytes(cipherKey);
            //string blowFishKey = BitConverter.ToString(cipherKey).Replace("-", "");
            //return BitConverter.ToString(cipherKey).Replace("-", "");
            return BitConverter.ToString(cipherKey);
        }

        public string GetCacheKey()
        {
            string blowFishKey = null;
            //TODO:Boil 获取之前缓存的key
            return blowFishKey;
        }

        public void Init(bool isNewKey = true)
        {
            cipherXmlDoc_ = new XmlDocument();
            plainXmlDoc_ = new XmlDocument();

            if (isNewKey)
            {
                blowFishKey_ = GenerateKey();
            }
            else
            {
                blowFishKey_ = GetCacheKey();
            }
            blowfish_ = new BlowFish(blowFishKey_);
        }

        public string GetKey()
        {
            return blowFishKey_;
        }

        public string Encrypt (XmlDocument pxDoc )
        {
            string plainSrcXml = pxDoc.InnerXml;

            string cipherXml = blowfish_.Encrypt_CBC(plainSrcXml);
            return cipherXml;
        }
        public string Decrypt(XmlDocument cxDoc)
        {
            string cipherXml = cxDoc.InnerXml;

            string plainXml = blowfish_.Decrypt_CBC(cipherXml);
            return plainXml;
        }


    }
}
