﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.IO;

namespace EncryptTool.Common
{
    /// <summary>
    /// 写日志操作类
    /// </summary>
    public class LogHelper
    {
        //静态对象
        private static readonly object synObject=new object();

        /// <summary>
        /// 写日志
        /// </summary>
        /// <param name="msg"></param>
        public static void Log(string msg, string fileName = "Log.txt")
        {
            if (!ConfigHelper.WriteLog)
                return;

            msg = "[" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "] " + msg;
            try
            {
                Monitor.Enter(synObject);
                StreamWriter sw = System.IO.File.AppendText(AppDomain.CurrentDomain.BaseDirectory + "\\" + fileName);
                sw.WriteLine(msg);
                sw.Close();
                Monitor.Exit(synObject);
            }
            catch
            { }
        }
    }
}
