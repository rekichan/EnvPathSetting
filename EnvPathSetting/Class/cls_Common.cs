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

        public const int USER = 0x400;
        public const int RELEASE_SAVE_AND_UNMAKE = USER + 1;
    }
}
