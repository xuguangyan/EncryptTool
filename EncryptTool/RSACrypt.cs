﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;

namespace EncryptTool
{
    /// <summary>
    /// RSA算法简介：
    /// RSA公钥加密算法是1977年由罗纳德·李维斯特（Ron Rivest）、阿迪·萨莫尔（Adi Shamir）和伦纳德·阿德曼（Leonard Adleman）一起提出的。
    /// 当时他们三人都在麻省理工学院工作。RSA就是他们三人姓氏开头字母拼在一起组成的。
    /// RSA是目前最有影响力的公钥加密算法，它能够抵抗到目前为止已知的绝大多数密码攻击，已被ISO推荐为公钥数据加密标准。
    /// </summary>
    public class RSACrypt
    {
         /// <summary> 
         /// 生成公钥,私钥对
         /// </summary> 
         public static string[] GenerateKeys()
         {
             string[] sKeys = new String[2];
             RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
             sKeys[0] = rsa.ToXmlString(true);//私钥
             sKeys[1] = rsa.ToXmlString(false);//公钥
             return sKeys;
         }

        /// <summary>
        /// 通过私钥获取签名
        /// </summary>
        /// <param name="name">名字</param>
        /// <param name="sPrivateKey">私钥</param>
        /// <returns>签名</returns>
        public static string GetSign(string name, string sPrivateKey)
        {
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
            rsa.FromXmlString(sPrivateKey);
            byte[] ouput = rsa.SignData(Convert.FromBase64String(name), "SHA1");

            return Convert.ToBase64String(ouput);
        }

        /// <summary>
        /// 通过公钥验证签名
        /// </summary>
        /// <param name="name">名字</param>
        /// <param name="signature">签名</param>
        /// <param name="sPublicKey">公钥</param>
        /// <returns></returns>
        public static bool VerifySign(string name, string signature, string sPublicKey)
        {
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
            rsa.FromXmlString(sPublicKey);
            bool bVerify = rsa.VerifyData(Convert.FromBase64String(name), "SHA1", Convert.FromBase64String(signature));

            return bVerify;
        }
 
         /// <summary> 
         /// RSA 加密
         /// </summary> 
         /// <param name="sSource" >明文</param> 
         /// <param name="sPublicKey" >公钥</param> 
         public static string EncryptString(string sSource, string sPublicKey)
         {
             RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
             string plaintext = sSource;
             rsa.FromXmlString(sPublicKey);
             byte[] cipherbytes;
             byte[] byteEn = rsa.Encrypt(Encoding.UTF8.GetBytes("a"), false);
             cipherbytes = rsa.Encrypt(Encoding.UTF8.GetBytes(plaintext), false);
 
             StringBuilder sbString = new StringBuilder();
             for (int i = 0; i < cipherbytes.Length; i++)
             {
                 sbString.Append(cipherbytes[i] + ",");
             }
             return sbString.ToString();
         }
 
         /// <summary> 
         /// RSA 解密
         /// </summary> 
         /// <param name="sSource">密文</param> 
         /// <param name="sPrivateKey">私钥</param> 
         public static string DecryptString(string sSource, string sPrivateKey)
         {
             RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
             rsa.FromXmlString(sPrivateKey);
             byte[] byteEn = rsa.Encrypt(Encoding.UTF8.GetBytes("a"), false);
             string[] sBytes = sSource.Split(',');

             for (int j = 0; j < sBytes.Length; j++)
             {
                 if (sBytes[j] != "")
                 {
                     byteEn[j] = Byte.Parse(sBytes[j]);
                 }
             }
             byte[] plaintbytes = rsa.Decrypt(byteEn, false);
             return Encoding.UTF8.GetString(plaintbytes);
         }
    }
}
