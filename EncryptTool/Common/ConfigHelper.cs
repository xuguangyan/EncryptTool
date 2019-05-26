using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Xml;
using System.Windows.Forms;

namespace EncryptTool.Common
{
    /// <summary>
    /// 配置辅助类
    /// </summary>
    public class ConfigHelper
    {
        #region 初始化与刷新接口

        /// <summary>
        /// 静态构造函数
        /// </summary>
        static ConfigHelper()
        {
            Refresh();
        }

        /// <summary>
        /// 刷新配置
        /// </summary>
        public static void Refresh()
        {
            WriteLog = GetValue("WriteLog", false);
        }

        #endregion

        #region 读写配置文件

        //依据连接串名字connectionName返回数据连接字符串  
        public static string GetConnectionStringsConfig(string connectionName)
        {
            //指定config文件读取
            string file = System.Windows.Forms.Application.ExecutablePath;
            System.Configuration.Configuration config = ConfigurationManager.OpenExeConfiguration(file);
            string connectionString =
                config.ConnectionStrings.ConnectionStrings[connectionName].ConnectionString.ToString();
            return connectionString;
        }

        ///<summary> 
        ///更新连接字符串  
        ///</summary> 
        ///<param name="newName">连接字符串名称</param> 
        ///<param name="newConString">连接字符串内容</param> 
        ///<param name="newProviderName">数据提供程序名称</param> 
        public static void UpdateConnectionStringsConfig(string newName, string newConString, string newProviderName)
        {
            //指定config文件读取
            string file = System.Windows.Forms.Application.ExecutablePath;
            Configuration config = ConfigurationManager.OpenExeConfiguration(file);

            bool exist = false; //记录该连接串是否已经存在  
            //如果要更改的连接串已经存在  
            if (config.ConnectionStrings.ConnectionStrings[newName] != null)
            {
                exist = true;
            }
            // 如果连接串已存在，首先删除它  
            if (exist)
            {
                config.ConnectionStrings.ConnectionStrings.Remove(newName);
            }
            //新建一个连接字符串实例  
            ConnectionStringSettings mySettings =
                new ConnectionStringSettings(newName, newConString, newProviderName);
            // 将新的连接串添加到配置文件中.  
            config.ConnectionStrings.ConnectionStrings.Add(mySettings);
            // 保存对配置文件所作的更改  
            config.Save(ConfigurationSaveMode.Modified);
            // 强制重新载入配置文件的ConnectionStrings配置节  
            ConfigurationManager.RefreshSection("ConnectionStrings");
        }

        ///<summary>  
        ///在appSettings配置节增加一对键值对  
        ///</summary>  
        ///<param name="newKey"></param>  
        ///<param name="newValue"></param>  
        public static void SetValue(string newKey, string newValue)
        {
            string file = System.Windows.Forms.Application.ExecutablePath;
            Configuration config = ConfigurationManager.OpenExeConfiguration(file);
            bool exist = false;
            foreach (string key in config.AppSettings.Settings.AllKeys)
            {
                if (key == newKey)
                {
                    exist = true;
                }
            }
            if (exist)
            {
                config.AppSettings.Settings.Remove(newKey);
            }
            config.AppSettings.Settings.Add(newKey, newValue);
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");
        }

        ///返回appSettings配置节的value项(string型)
        ///</summary> 
        ///<param name="AppKey"></param> 
        ///<param name="defValue">value</param>
        ///<returns></returns> 
        public static string GetValue(string AppKey, string defValue)
        {
            string file = System.Windows.Forms.Application.ExecutablePath;
            Configuration config = ConfigurationManager.OpenExeConfiguration(file);
            foreach (string key in config.AppSettings.Settings.AllKeys)
            {
                if (key == AppKey)
                {
                    return config.AppSettings.Settings[AppKey].Value;
                }
            }
            return defValue;
        }

        ///返回appSettings配置节的value项(int型)
        ///</summary> 
        ///<param name="AppKey"></param> 
        ///<param name="defValue">value</param>
        ///<returns></returns> 
        public static int GetValue(string AppKey, int defValue)
        {
            string file = System.Windows.Forms.Application.ExecutablePath;
            Configuration config = ConfigurationManager.OpenExeConfiguration(file);
            foreach (string key in config.AppSettings.Settings.AllKeys)
            {
                if (key == AppKey)
                {
                    string value = config.AppSettings.Settings[AppKey].Value;
                    try { return Convert.ToInt32(value); }
                    catch { return defValue; }
                }
            }
            return defValue;
        }


        ///返回appSettings配置节的value项(int型)
        ///</summary> 
        ///<param name="AppKey"></param> 
        ///<param name="defValue">value</param>
        ///<returns></returns> 
        public static bool GetValue(string AppKey, bool defValue)
        {
            string file = System.Windows.Forms.Application.ExecutablePath;
            Configuration config = ConfigurationManager.OpenExeConfiguration(file);
            foreach (string key in config.AppSettings.Settings.AllKeys)
            {
                if (key == AppKey)
                {
                    string value = config.AppSettings.Settings[AppKey].Value;
                    try { return Convert.ToBoolean(value); }
                    catch { return defValue; }
                }
            }
            return defValue;
        }

        #endregion

        #region 来自App.config的配置信息

        /// <summary>
        /// 是否写日志(默认false)
        /// </summary>
        public static bool WriteLog;

        #endregion
    }
}
