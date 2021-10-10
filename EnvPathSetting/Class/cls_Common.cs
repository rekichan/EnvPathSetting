using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnvPathSetting.Class
{
    class cls_Common
    {
        public static IntPtr hwndFrmMain;
        public static IntPtr hwndFrmMdfEnvPath;
        public static bool isSystemEnvPath;
        public static bool isModify;
        public static bool isEdit;
        public static string currentName;
        public static string currentValue;

        public const int USER = 0x400;
        public const int ADD_USER_ENV_PATH = USER + 1;
        public const int ADD_SYS_ENV_PATH = ADD_USER_ENV_PATH + 1;
        public const int ADD_LIST_ENV_PATH_VALUE = ADD_SYS_ENV_PATH + 1;
        public const int MODIFY_LIST_ENV_PATH_VALUE = ADD_LIST_ENV_PATH_VALUE + 1;
        public const int REFRESH_MAIN_DGV_INFO = MODIFY_LIST_ENV_PATH_VALUE + 1;
    }
}
