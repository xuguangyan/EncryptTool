using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace EncryptTool
{
    /// <summary>
    ///  关于哈希函数：
    ///     哈希函数将任意长度的二进制字符串映射为固定长度的小型二进制字符串。
    /// 加密哈希函数有这样一个属性：在计算上不大可能找到散列为相同的值的两个
    /// 不同的输入；也就是说，两组数据的哈希值仅在对应的数据也匹配时才会匹配。
    /// 数据的少量更改会在哈希值中产生不可预知的大量更改。
    /// 
    /// MD5 算法的哈希值大小为 128 位。
    /// SHA1 算法的哈希值大小为 160 位。
    /// </summary>
    public class OtherCrypt
    {
         /// <summary>
         /// MD5加密
         /// </summary>
        public static string GetMd5(string plainStr)
        {
            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] bytes_md5_in = Encoding.UTF8.GetBytes(plainStr);
            byte[] bytes_md5_out = md5.ComputeHash(bytes_md5_in);
            StringBuilder sb = new StringBuilder();
            foreach (byte b in bytes_md5_out)
            {
                sb.Append(b.ToString("x2").ToUpper());
            }
            return sb.ToString();
        }
 
         /// <summary>
         /// SHA1加密
         /// </summary>
        public static string Get_SHA1(string plainStr)
         {
             SHA1 sha1 = new SHA1CryptoServiceProvider();
             byte[] bytes_sha1_in = UTF8Encoding.Default.GetBytes(plainStr);
             byte[] bytes_sha1_out = sha1.ComputeHash(bytes_sha1_in);
             string str_sha1_out = BitConverter.ToString(bytes_sha1_out);
             str_sha1_out = str_sha1_out.Replace("-", "");
             return str_sha1_out;
         }
    }
}
