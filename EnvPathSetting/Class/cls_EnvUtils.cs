using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;
using System.Runtime.InteropServices;

namespace EnvPathSetting.Class
{
    class cls_EnvUtils
    {
        //[DllImport("Kernel32.DLL ", SetLastError = true)]
        //public static extern bool SetEnvironmentVariable(string lpName, string lpValue);

        /// <summary>
        /// 获取指定的环境变量值
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
        /// 获取系统环境变量
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
        /// 设置指定的环境变量
        /// </summary>
        /// <param name="name">环境变量名</param>
        /// <param name="value">环境变量值</param>
        public static void SetSysEnvironment(string name,string value)
        {
            OpenSysEnvironment().SetValue(name, value);
        }

        /// <summary>
        /// 更新PATH环境变量
        /// </summary>
        /// <param name="name">环境变量名</param>
        public static void UpdateSysEnvironment(string name,bool bin)
        {
            string path = GetSysEnvironmentByName("PATH");

            if(path.Substring(path.Length-1,1)!=";")
            {
                SetSysEnvironment("PATH", path + ";");
                path = GetSysEnvironmentByName("PATH");
            }

            string[] list = path.Split(';');
            bool isPathExist = false;

            foreach(string item in list)
            {
                if (item == name)
                    isPathExist = true;
            }

            if (!isPathExist)
            {
                if (bin)
                    name = name + @"\bin;";
                else
                    name = name + @"\;";
                SetSysEnvironment("PATH",  path+ name);
            }
        }
    }
}
