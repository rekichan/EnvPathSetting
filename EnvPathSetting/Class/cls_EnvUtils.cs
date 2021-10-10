using System;
using Microsoft.Win32;

namespace EnvPathSetting.Class
{
    class cls_EnvUtils
    {
        /// <summary>
        /// 获取所有系统的环境变量名
        /// </summary>
        /// <returns></returns>
        public static string[] GetAllSysEnvironmentName()
        {
            return OpenSysEnvironment().GetValueNames();
        }

        /// <summary>
        /// 获取所有当前用户的环境变量名
        /// </summary>
        /// <returns></returns>
        public static string[] GellAllUserEnvironmentName()
        {
            return OpenUserEnvironment().GetValueNames();
        }

        /// <summary>
        /// 获取系统的环境变量
        /// </summary>
        /// <returns></returns>
        private static RegistryKey OpenSysEnvironment()
        {
            RegistryKey regLocalMachine = Registry.LocalMachine;
            RegistryKey regSYSTEM = regLocalMachine.OpenSubKey("SYSTEM", true);
            RegistryKey regControlSet001 = regSYSTEM.OpenSubKey("ControlSet001", true);
            RegistryKey regControl = regControlSet001.OpenSubKey("Control", true);
            RegistryKey regManager = regControl.OpenSubKey("Session Manager", true);
            RegistryKey regEnvironment = regManager.OpenSubKey("Environment", true);
            return regEnvironment;
        }

        /// <summary>
        /// 获取当前用户的环境变量
        /// </summary>
        /// <returns></returns>
        private static RegistryKey OpenUserEnvironment()
        {
            RegistryKey regCurrentUser = Registry.CurrentUser;
            RegistryKey regEnvironment = regCurrentUser.OpenSubKey("Environment", true);
            return regEnvironment;
        }

        /// <summary>
        /// 获取指定的系统环境变量值
        /// </summary>
        /// <param name="name">环境变量名</param>
        /// <returns></returns>
        public static string GetSysEnvironmentByName(string name)
        {
            string result;
            try
            {
                result = OpenSysEnvironment().GetValue(name).ToString();
            }
            catch (Exception)
            {
                return string.Empty;
            }

            return result;
        }

        /// <summary>
        /// 获取指定的当前用户环境变量值
        /// </summary>
        /// <param name="name">环境变量名</param>
        /// <returns></returns>
        public static string GetUserEnvironmentByName(string name)
        {
            string result;
            try
            {
                result = OpenUserEnvironment().GetValue(name).ToString();
            }
            catch (Exception)
            {
                return string.Empty;
            }

            return result;
        }

        /// <summary>
        /// 删除系统环境变量
        /// </summary>
        /// <param name="name">环境变量名</param>
        /// <returns></returns>
        public static bool DeleteSysEnvironmentByName(string name)
        {
            try
            {
                OpenSysEnvironment().DeleteValue(name);
            }
            catch(Exception)
            {
                return false;
            }

            return true;
        }

        /// <summary>
        /// 删除当前用户环境变量
        /// </summary>
        /// <param name="name">环境变量名</param>
        /// <returns></returns>
        public static bool DeleteUserEnvironmentByName(string name)
        {
            try
            {
                OpenUserEnvironment().DeleteValue(name);
            }
            catch (Exception)
            {
                return false;
            }

            return true;
        }

        /// <summary>
        /// 设置系统环境变量
        /// </summary>
        /// <param name="name">环境变量名</param>
        /// <param name="value">环境变量值</param>
        public static void SetSysEnvironment(string name,string value)
        {
            OpenSysEnvironment().SetValue(name, value);
        }

        /// <summary>
        /// 设置当前用户环境变量
        /// </summary>
        /// <param name="name">环境变量名</param>
        /// <param name="value">环境变量值</param>
        public static void SetUserEnvironment(string name,string value)
        {
            OpenUserEnvironment().SetValue(name, value);
        }


    }
}
