using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using System.IO;

namespace EncryptTool
{
    /// <summary>
    /// AES（Advanced Encryption Standard）算法简介：
    /// 高级加密标准（Advanced Encryption Standard，缩写：AES），在密码学中又称Rijndael加密法。
    /// DES数据加密标准算法由于密钥长度较小(56位),已经不适应当今分布式开放网络对数据加密安全性的要求，
    /// 因此1997年NIST公开征集新的数据加密标准,即AES。
    /// 经过三轮的筛选,比利时Joan Daeman和Vincent Rijmen提交的Rijndael算法被提议为AES的最终算法。
    /// 此算法将成为美国新的数据加密标准而被广泛应用在各个领域中。
    /// 尽管人们对AES还有不同的看法,但总体来说,AES作为新一代的数据加密标准汇聚了强安全性、高性能、高效率、易用和灵活等优点。
    /// AES设计有三个密钥长度:128,192,256位，相对而言，AES的128密钥比DES的56密钥强1021倍。
    /// </summary>
    public class AESCrypt
    {
        /// <summary>
        /// 加密IV向量
        /// </summary>
        private static byte[] IV = { 0x12, 0x34, 0x56, 0x78, 0x90, 0xAB, 0xCD, 0xEF, 0x12, 0x34, 0x56, 0x78, 0x90, 0xAB, 0xCD, 0xEF };

        /// <summary>
        /// AES加密
        /// </summary>
        /// <param name="Key">密钥</param>
        /// <param name="plainStr">明文字符串</param>
        /// <param name="ivStr">加密向量</param>
        /// <param name="cMode">加密模式</param>
        /// <param name="pMode">填充模式</param>
        /// <returns>密文</returns>
        public static String Encrypt(String Key, String plainStr, String ivStr = "", CipherMode cMode = CipherMode.ECB, PaddingMode pMode = PaddingMode.PKCS7)
        {
            var aes = new RijndaelManaged();
            //秘钥的大小，以位为单位
            aes.KeySize = 256;
            //支持的块大小
            aes.BlockSize = 128;
            //填充模式
            aes.Padding = pMode;
            aes.Mode = cMode;
            //aes.Key = Convert.FromBase64String(Key);
            aes.Key = Encoding.Default.GetBytes(OtherCrypt.GetMd5(Key));//采用MD5加密一次，密钥可变长度
            aes.IV = IV;
            if (ivStr.Length > 0)
            {
                if (ivStr.StartsWith("0x"))
                {
                    aes.IV = HexToByte(ivStr.Substring(2));
                }
                else
                {
                    //aes.IV = Encoding.Default.GetBytes(OtherCrypt.GetMd5(ivStr).Substring(0, 16));
                    aes.IV = Encoding.Default.GetBytes(ivStr);
                }
            }
            var encrypt = aes.CreateEncryptor(aes.Key, aes.IV);
            byte[] xBuff = new byte[0];

            using (var ms = new MemoryStream())
            {
                using (var cs = new CryptoStream(ms, encrypt, CryptoStreamMode.Write))
                {
                    byte[] xXml = Encoding.UTF8.GetBytes(plainStr);
                    cs.Write(xXml, 0, xXml.Length);
                }
                xBuff = ms.ToArray();
            }
            return Convert.ToBase64String(xBuff);
        }

        /// <summary>
        /// AES解密
        /// </summary>
        /// <param name="Key">密钥</param>
        /// <param name="encryptStr">密文字符串</param>
        /// <param name="ivStr">加密向量</param>
        /// <param name="cMode">加密模式</param>
        /// <param name="pMode">填充模式</param>
        /// <returns>明文</returns>
        public static String Decrypt(String Key, String encryptStr, String ivStr = "", CipherMode cMode = CipherMode.ECB, PaddingMode pMode = PaddingMode.PKCS7)
        {
            RijndaelManaged aes = new RijndaelManaged();
            aes.KeySize = 256;
            aes.BlockSize = 128;
            //填充模式
            aes.Padding = pMode;
            aes.Mode = cMode;
            //aes.Key = Convert.FromBase64String(Key);
            aes.Key = Encoding.Default.GetBytes(OtherCrypt.GetMd5(Key));//采用MD5加密一次，密钥可变长度
            aes.IV = IV;
            if (ivStr.Length > 0)
            {
                if (ivStr.StartsWith("0x"))
                {
                    aes.IV = HexToByte(ivStr.Substring(2));
                }
                else
                {
                    //aes.IV = Encoding.Default.GetBytes(OtherCrypt.GetMd5(ivStr).Substring(0, 16));
                    aes.IV = Encoding.Default.GetBytes(ivStr);
                }
            }
            var decrypt = aes.CreateDecryptor(aes.Key, aes.IV);
            byte[] xBuff = new byte[0];
            using (var ms = new MemoryStream())
            {
                using (var cs = new CryptoStream(ms, decrypt, CryptoStreamMode.Write))
                {
                    byte[] xXml = Convert.FromBase64String(encryptStr);
                    byte[] msg = new byte[xXml.Length + 32 - xXml.Length % 32];
                    Array.Copy(xXml, msg, xXml.Length);
                    cs.Write(xXml, 0, xXml.Length);
                }
                xBuff = decode2(ms.ToArray());
            }
            return Encoding.UTF8.GetString(xBuff);
        }

        private static byte[] decode2(byte[] decrypted)
        {
            int pad = (int)decrypted[decrypted.Length - 1];
            if (pad < 1 || pad > 32)
            {
                pad = 0;
            }
            byte[] res = new byte[decrypted.Length - pad];
            Array.Copy(decrypted, 0, res, 0, decrypted.Length - pad);
            return res;
        }

        /// <summary>
        /// Hex字串转字节
        /// </summary>
        /// <param name="hexString"></param>
        /// <returns></returns>
        public static byte[] HexToByte(string hexString)
        {
            if (string.IsNullOrEmpty(hexString))
            {
                hexString = "00";
            }
            byte[] returnBytes = new byte[hexString.Length / 2];
            for (int i = 0; i < returnBytes.Length; i++)
                returnBytes[i] = Convert.ToByte(hexString.Substring(i * 2, 2), 16);
            return returnBytes;
        }

        /// <summary>
        /// 将指定字节数组中的一个字节序列解码为一个Hex码字符串
        /// </summary>
        /// <param name="bytes">字节</param>
        /// <returns></returns>
        public static string ToHexString(byte[] bytes)
        {
            StringBuilder strB = new StringBuilder();
            if (bytes != null)
            {
                int len = bytes.Length;
                for (int i = 0; i < len; ++i)
                    strB.Append(bytes[i].ToString("X2"));
            }
            return strB.ToString();
        }
    }
}
