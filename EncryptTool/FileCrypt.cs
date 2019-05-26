using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Security.Cryptography;

namespace EncryptTool
{
    /// <summary>
    /// 通过RSA算法进行文件内容加密
    /// </summary>
    public class FileCrypt
    {
        public static bool Encrypt(string srcFile, string dectFile, string sPublicKey)
        {
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
            rsa.FromXmlString(sPublicKey);

            FileStream fsRead = new FileStream(srcFile, FileMode.Open);
            FileStream fsOut = new FileStream(dectFile, FileMode.Create);
            byte[] buffer = new byte[100];
            byte[] outBuf = new byte[1024];

            int readCount = fsRead.Read(buffer, 0, buffer.Length);
            while (readCount > 0)
            {
                outBuf = rsa.Encrypt(buffer, false);
                fsOut.Write(outBuf, 0, outBuf.Length);
                readCount = fsRead.Read(buffer, 0, buffer.Length);
            }

            fsRead.Close();
            fsOut.Close();

            return true;
        }

        public static bool Decrypt(string srcFile, string dectFile, string sPrivateKey)
        {
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
            rsa.FromXmlString(sPrivateKey);

            FileStream fsRead = new FileStream(srcFile, FileMode.Open);
            FileStream fsOut = new FileStream(dectFile, FileMode.Create);
            byte[] buffer = new byte[1024];
            byte[] outBuf = new byte[1024];

            int readCount = fsRead.Read(buffer, 0, buffer.Length);
            while (readCount > 0)
            {
                outBuf = rsa.Decrypt(buffer, false);
                fsOut.Write(outBuf, 0, outBuf.Length);
                readCount = fsRead.Read(buffer, 0, buffer.Length);
            }

            fsRead.Close();
            fsOut.Close();
            return true;
        }

        //加密其它非文本文件，当然可以包括文本文件
        public static void EncryptOther(string file1, string file2, string sPublicKey)
        {
            RSACryptoServiceProvider crypt = new RSACryptoServiceProvider();
            crypt.FromXmlString(sPublicKey);

            FileStream picfs = new FileStream(@file1, FileMode.Open);
            FileStream fs = new FileStream(@file2, FileMode.OpenOrCreate);
            byte[] bytes = new byte[picfs.Length];
            picfs.Read(bytes, 0, (int)picfs.Length);
            picfs.Close();
            int blockSize = 0;
            if (crypt.KeySize == 1024)
                blockSize = 16;
            else blockSize = 8;
            byte[] rawblock, encryblock;
            for (int i = 0; i < bytes.Length; i += blockSize)
            {
                if ((bytes.Length - i) > blockSize)
                    rawblock = new byte[blockSize];
                else rawblock = new byte[bytes.Length - i];
                Buffer.BlockCopy(bytes, i, rawblock, 0, rawblock.Length);
                encryblock = crypt.Encrypt(rawblock, false);
                fs.Write(encryblock, 0, encryblock.Length);
            }
            fs.Flush();
            fs.Close();
        }
        //解密其它非文本文件，当然可以包括文本文件
        public static void DecryptOther(string fileone, string filetwo, string sPrivateKey)
        {
            RSACryptoServiceProvider crypt = new RSACryptoServiceProvider();
            crypt.FromXmlString(sPrivateKey);

            FileStream fs = new FileStream(@fileone, FileMode.Open);
            FileStream writopic = new FileStream(@filetwo, FileMode.Create);
            byte[] bytes = new byte[fs.Length];
            fs.Read(bytes, 0, (int)fs.Length);
            fs.Close();
            MemoryStream ms = new MemoryStream();
            int keySize = crypt.KeySize / 8;
            byte[] rawblock, decryptblock;
            for (int i = 0; i < bytes.Length; i += keySize)
            {
                if ((bytes.Length - i) > keySize)
                {
                    rawblock = new byte[keySize];
                }
                else
                { rawblock = new byte[bytes.Length - i]; }

                Buffer.BlockCopy(bytes, i, rawblock, 0, rawblock.Length);
                decryptblock = crypt.Decrypt(rawblock, false);
                ms.Write(decryptblock, 0, decryptblock.Length);
            }
            ms.Position = 0;
            byte[] decode = new byte[ms.Length];
            ms.Read(decode, 0, (int)ms.Length);
            ms.Close();
            writopic.Write(decode, 0, decode.Length);
            writopic.Close();

        }


    }
}
