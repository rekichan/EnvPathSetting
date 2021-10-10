using System;
using System.Windows.Forms;
using EnvPathSetting.Class;
using System.Runtime.InteropServices;

namespace EnvPathSetting
{
    public partial class frm_MdfEnvPath : Form
    {

        #region Constructor
        public frm_MdfEnvPath()
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
        private void frm_MdfEnvPath_Load(object sender, EventArgs e)
        {
            cls_Common.hwndFrmMdfEnvPath = this.Handle;
            string value;
            string[] values;
            if (cls_Common.isSystemEnvPath)
                value = cls_EnvUtils.GetSysEnvironmentByName(cls_Common.currentName);
            else
                value = cls_EnvUtils.GetUserEnvironmentByName(cls_Common.currentName);
            values = value.Split(';');
            lst_EnvPath.Items.AddRange(values);
        }
        #endregion

        #region Event
        private void btn_Browse_Click(object sender, EventArgs e)
        {
            if (lst_EnvPath.SelectedIndex > -1)
            {
                string dict = lst_EnvPath.Items[lst_EnvPath.SelectedIndex].ToString();
                if (dict.Contains("%"))
                {
                    MessageBox.Show("暂不支持打开含%的环境变量!", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (System.IO.File.Exists(dict))
                {
                    string dictName = System.IO.Path.GetFullPath(dict);
                    System.Diagnostics.Process.Start(dict);
                }
                else if (System.IO.Directory.Exists(dict))
                {
                    System.Diagnostics.Process.Start(dict);
                }
                else
                {
                    MessageBox.Show("选中的文件或文件夹不存在!", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (lst_EnvPath.SelectedIndex > -1)
            {
                lst_EnvPath.Items.RemoveAt(lst_EnvPath.SelectedIndex);
            }
            else
                MessageBox.Show("未选择相应的环境变量名!", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btn_MoveUp_Click(object sender, EventArgs e)
        {
            if (lst_EnvPath.SelectedIndex > -1)
            {
                if (lst_EnvPath.SelectedIndex == 0)
                {
                    MessageBox.Show("选中项已在最前!", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                string buf = lst_EnvPath.Items[lst_EnvPath.SelectedIndex].ToString();
                lst_EnvPath.Items[lst_EnvPath.SelectedIndex] = lst_EnvPath.Items[lst_EnvPath.SelectedIndex - 1].ToString();
                lst_EnvPath.Items[lst_EnvPath.SelectedIndex - 1] = buf;
                lst_EnvPath.SelectedIndex = lst_EnvPath.SelectedIndex - 1;
            }
            else
                MessageBox.Show("未选择相应的环境变量名!", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btn_MoveDown_Click(object sender, EventArgs e)
        {
            if (lst_EnvPath.SelectedIndex > -1)
            {
                if (lst_EnvPath.SelectedIndex == lst_EnvPath.Items.Count - 1)
                {
                    MessageBox.Show("选中项已在最后!", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                string buf = lst_EnvPath.Items[lst_EnvPath.SelectedIndex].ToString();
                lst_EnvPath.Items[lst_EnvPath.SelectedIndex] = lst_EnvPath.Items[lst_EnvPath.SelectedIndex + 1].ToString();
                lst_EnvPath.Items[lst_EnvPath.SelectedIndex + 1] = buf;
                lst_EnvPath.SelectedIndex = lst_EnvPath.SelectedIndex + 1;
            }
            else
                MessageBox.Show("未选择相应的环境变量名!", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btn_Confirm_Click(object sender, EventArgs e)
        {
            string save = "";
            for (int i = 0; i < lst_EnvPath.Items.Count; i++)
            {
                string buf = lst_EnvPath.Items[i].ToString();
                if (!string.IsNullOrWhiteSpace(buf))
                    save = save + lst_EnvPath.Items[i].ToString() + ";";
            }

            if (MessageBox.Show("确认保存新的环境变量?", "Q", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (cls_Common.isSystemEnvPath)
                    cls_EnvUtils.SetSysEnvironment(cls_Common.currentName, save);
                else
                    cls_EnvUtils.SetUserEnvironment(cls_Common.currentName, save);

                PostMess(cls_Common.hwndFrmMain, cls_Common.REFRESH_MAIN_DGV_INFO);
                MessageBox.Show("设置成功!", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            cls_Common.isModify = true;
            cls_Common.isEdit = false;
            frm_AddEnvPath addEnvPath = new frm_AddEnvPath();
            addEnvPath.ShowDialog();
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            if (lst_EnvPath.SelectedIndex > -1)
            {
                cls_Common.isEdit = true;
                cls_Common.isModify = false;
                cls_Common.currentValue = lst_EnvPath.Items[lst_EnvPath.SelectedIndex].ToString();
                frm_AddEnvPath addEnvPath = new frm_AddEnvPath();
                addEnvPath.ShowDialog();
            }
            else
                MessageBox.Show("未选择相应的环境变量名!", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
        #endregion

        #region Message
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case cls_Common.ADD_LIST_ENV_PATH_VALUE:
                    lst_EnvPath.Items.Add(System.Runtime.InteropServices.Marshal.PtrToStringAnsi(m.WParam));
                    break;

                case cls_Common.MODIFY_LIST_ENV_PATH_VALUE:
                    lst_EnvPath.Items[lst_EnvPath.SelectedIndex] = System.Runtime.InteropServices.Marshal.PtrToStringAnsi(m.WParam);
                    break;

                default:
                    base.WndProc(ref m);
                    break;
            }
        }
        #endregion

    }
}
