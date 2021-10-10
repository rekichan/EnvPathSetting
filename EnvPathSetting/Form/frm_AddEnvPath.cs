using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using EnvPathSetting.Class;

namespace EnvPathSetting
{
    public partial class frm_AddEnvPath : Form
    {

        #region Constructor
        public frm_AddEnvPath()
        {
            InitializeComponent();
        }
        #endregion

        #region API
        [DllImport("user32.dll ", CharSet = CharSet.Unicode)]
        public static extern IntPtr PostMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);
        [DllImport("user32.dll ", CharSet = CharSet.Unicode)]
        public static extern IntPtr PostMessage(IntPtr hwnd, int wMsg, IntPtr wParam, int lParam);
        #endregion

        #region FormEvent
        private void frm_AddEnvPath_Load(object sender, EventArgs e)
        {
            if (cls_Common.isModify)
            {
                txt_Name.Text = cls_Common.currentName;
                txt_Name.Enabled = false;
            }
            else if (cls_Common.isEdit)
            {
                txt_Name.Text = cls_Common.currentName;
                txt_Value.Text = cls_Common.currentValue;
                txt_Name.Enabled = false;
                btn_AddEnvPath.Text = "修改";
            }
        }
        #endregion

        #region Event
        private void btn_BrowseDict_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            DialogResult dr = fbd.ShowDialog();
            if (dr == DialogResult.OK)
            {
                txt_Value.Text = fbd.SelectedPath;
            }
            fbd.Dispose();
        }

        private void btn_BrowseFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                txt_Value.Text = ofd.FileName;
            }
            ofd.Dispose();
        }

        private void btn_AddEnvPath_Click(object sender, EventArgs e)
        {
            string name = txt_Name.Text;
            string value = txt_Value.Text;

            if(value.Contains("%"))
            {
                MessageBox.Show("暂不支持新增/修改带有%的环境变量!", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if(string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(value))
            {
                MessageBox.Show("变量名或变量值为空!", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cls_Common.isModify)
            {
                PostMess(cls_Common.hwndFrmMdfEnvPath, cls_Common.ADD_LIST_ENV_PATH_VALUE, value);
            }
            else if(cls_Common.isEdit)
            {
                PostMess(cls_Common.hwndFrmMdfEnvPath, cls_Common.MODIFY_LIST_ENV_PATH_VALUE, value);
                this.Close();
            }
            else
            {
                string msg = name + "^" + value;
                if (cls_Common.isSystemEnvPath)
                {
                    cls_EnvUtils.SetSysEnvironment(txt_Name.Text, txt_Value.Text);
                    PostMess(cls_Common.hwndFrmMain, cls_Common.ADD_SYS_ENV_PATH, msg);
                }
                else
                {
                    cls_EnvUtils.SetUserEnvironment(txt_Name.Text, txt_Value.Text);
                    PostMess(cls_Common.hwndFrmMain, cls_Common.ADD_USER_ENV_PATH, msg);
                }
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region Function
        public void PostMess(IntPtr hwmd, int msg)
        {
            PostMessage(hwmd, msg, 0, 0);
        }

        public void PostMess(IntPtr hwmd,int msg,string wparam)
        {
            IntPtr ansi = System.Runtime.InteropServices.Marshal.StringToHGlobalAnsi(wparam);
            PostMessage(hwmd, msg, ansi, 0);
        }
        #endregion

    }
}
