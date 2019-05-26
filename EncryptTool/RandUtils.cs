using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using System.IO;

namespace EncryptTool
{
    /// <summary>
    /// 随机数工具类
    /// </summary>
    public class RandUtils
    {
        /// <summary>
        /// 数字表
        /// </summary>
        private static string numList = "0123456789";
        /// <summary>
        /// 大写字母表
        /// </summary>
        private static string upperLetter = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        /// <summary>
        /// 小写字母表
        /// </summary>
        private static string lowerLetter = "abcdefghijklnmopqrstuvwxyz";
        /// <summary>
        /// 下划线
        /// </summary>
        private static string underLine = "_";
        /// <summary>
        /// 特殊字符表
        /// </summary>
        private static string specialChar = "_$%&*-@";

        /// <summary>
        /// 获取随机密码（包含数字、字母、特殊符）
        /// </summary>
        /// <param name="len">要取字串的长度</param>
        /// <returns></returns>
        public static string getRandPassword(int len)
        {
            string rndCode = "";
            string charset = upperLetter + numList + specialChar + lowerLetter;

            rndCode = getRandCodeByCharset(len, charset);
            return rndCode;
        }

        /// <summary>
        /// 获取随机强密码（必须包含数字、字母、特殊符，长度6位以上）
        /// </summary>
        /// <param name="len">要取字串的长度</param>
        /// <returns></returns>
        public static string getRandHardPassword(int len)
        {
            string rndCode = "";
            if (len < 6)
            {
                return rndCode;
            }

            string[] charset = new string[] { upperLetter + lowerLetter , numList , specialChar };
            string charsetAll = upperLetter + numList + specialChar + lowerLetter;

            Random random = new Random();
            int order = random.Next(0, 3);
            for (int i = 0; i < 3; i++)
            {
                order = order % 3;
                rndCode += getRandCodeByCharset(1, charset[order++]);
            }
            rndCode += getRandCodeByCharset(len - 3, charsetAll);
            return rndCode;
        }

        /// <summary>
        /// 获取随机Base64编码字符串
        /// </summary>
        /// <param name="len">要取字串的长度</param>
        /// <returns></returns>
        public static string getRandBase64Code(int len)
        {
            string rndCode = "";
            rndCode = Convert.ToBase64String(Encoding.ASCII.GetBytes(getRandASCIICode(len)));
            return rndCode;
        }

        /// <summary>
        /// 获取随机变量（由字母、数字、下划线组成，首字符不为数字）
        /// </summary>
        /// <param name="len">要取字串的长度</param>
        /// <returns></returns>
        public static string getRandVarCode(int len)
        {
            string rndCode = "";
            string charset1 = upperLetter + underLine + lowerLetter;
            string charset2 = upperLetter + numList + underLine + lowerLetter;

            rndCode = getRandCodeByCharset(1, charset1) + getRandCodeByCharset(len - 1, charset2);
            return rndCode;
        }

        /// <summary>
        /// 获取随机字母
        /// </summary>
        /// <param name="len">要取字串的长度</param>
        /// <returns></returns>
        public static string getRandLetter(int len)
        {
            string rndCode = "";
            string charset = upperLetter + lowerLetter;

            rndCode = getRandCodeByCharset(len, charset);
            return rndCode;
        }

        /// <summary>
        /// 获取随机大写字母
        /// </summary>
        /// <param name="len">要取字串的长度</param>
        /// <returns></returns>
        public static string getRandUpperLetter(int len)
        {
            return randCodeByRange(len, 65, 91);
        }

        /// <summary>
        /// 获取随机小写字母
        /// </summary>
        /// <param name="len">要取字串的长度</param>
        /// <returns></returns>
        public static string getRandLowerLetter(int len)
        {
            return randCodeByRange(len, 97, 123);
        }

        /// <summary>
        /// 获取随机数字
        /// </summary>
        /// <param name="len">要取字串的长度</param>
        /// <returns></returns>
        public static string getRandNumCode(int len)
        {
            return randCodeByRange(len, 48, 58);
        }

        /// <summary>
        /// 获取随机ASCII码字符
        /// </summary>
        /// <param name="len">要取字串的长度</param>
        /// <returns></returns>
        public static string getRandASCIICode(int len)
        {
            //ASCII码表中95个可显字符
            return randCodeByRange(len, 32, 127);
        }

        /// <summary>
        /// 按范围取随机数
        /// </summary>
        /// <param name="len">要取字串的长度</param>
        /// <param name="minValue">最小ASCII码值（含边界值）</param>
        /// <param name="maxValue">最大ASCII码值（不含边界值）</param>
        /// <returns></returns>
        private static string randCodeByRange(int len, int minValue, int maxValue)
        {
            string rndCode = "";
            if (len <= 0 || minValue > maxValue)
            {
                return rndCode;
            }

            char[] arrCode = new char[len];
            Random random = new Random();
            for (int i = 0; i < len; i++)
            {
                int index = random.Next(minValue, maxValue);
                arrCode[i] = Convert.ToChar(index);
            }
            rndCode = new string(arrCode);
            return rndCode;
        }

        /// <summary>
        /// 按字符集取随机数
        /// </summary>
        /// <param name="len">要取字串的长度</param>
        /// <param name="charset">字符集</param>
        /// <returns></returns>
        private static string getRandCodeByCharset(int len, string charset)
        {
            string rndCode = "";
            if (len <= 0)
            {
                return rndCode;
            }

            char[] arrSet = charset.ToArray();
            char[] arrCode = new char[len];

            Random random = new Random();
            for (int i = 0; i < len; i++)
            {
                int index = random.Next(0, arrSet.Length);
                arrCode[i] = arrSet[index];
            }
            rndCode = new string(arrCode);
            return rndCode;
        }
    }
}
