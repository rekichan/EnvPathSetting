using System;
using System.Collections.Generic;
using System.Windows.Forms;
using EnvPathSetting.Class;
using System.Runtime.InteropServices;

namespace EnvPathSetting
{
    public partial class frm_Main : Form
    {

        #region property
        cls_ListBoxEditor editor;
        List<string> reserve;
        #endregion

        #region constructor
        public frm_Main()
        {
            InitializeComponent();
            editor = new cls_ListBoxEditor(lst_ShowEnvPathValue, Environment.NewLine);
            reserve = new List<string>();
        }
        #endregion

        #region API
        [DllImport("user32.dll", EntryPoint = "GetScrollPos")]
        public static extern int GetScrollPos(IntPtr hwnd, int nBar);
        #endregion

        #region FormEvent
        private void frm_Main_Load(object sender, EventArgs e)
        {
            RefreshEnvPathName();
        }
        #endregion

        #region Event
        private void tsmi_Explain_Click(object sender, EventArgs e)
        {
            frm_Explain explain = new frm_Explain();
            explain.Show();
        }

        private void lst_ShowEnvPathName_KeyDown(object sender, KeyEventArgs e)
        {
            if (lst_ShowEnvPathName.SelectedIndex < 0)
                return;

            string spec = lst_ShowEnvPathName.GetItemText(lst_ShowEnvPathName.SelectedItem);
            string name = cls_EnvUtils.GetSysEnvironmentByName(spec);

            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("不存在该环境变量名!", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            lst_ShowEnvPathValue.Items.Clear();
            string[] path = name.Split(';');
            lst_ShowEnvPathValue.Items.AddRange(path);
        }

        private void tsmi_Save_Click(object sender, EventArgs e)
        {
            string save = "";
            for (int i = 0; i < lst_ShowEnvPathValue.Items.Count; i++)
            {
                string buf = lst_ShowEnvPathValue.Items[i].ToString();
                if (!string.IsNullOrWhiteSpace(buf))
                    save = save + lst_ShowEnvPathValue.Items[i].ToString() + ";";
            }

            if (string.IsNullOrWhiteSpace(save))
                return;

            if (lst_ShowEnvPathName.SelectedIndex < 0)
            {
                MessageBox.Show("未选择相应的环境变量名!", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("确认保存新的环境变量?", "Q", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string name = lst_ShowEnvPathName.Items[lst_ShowEnvPathName.SelectedIndex].ToString();
                cls_EnvUtils.UpdateSysEnvironment(name, save);
                tsmi_Unmake.Enabled = false;

                MessageBox.Show("设置成功!", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            lst_ShowEnvPathName.Enabled = true;
        }

        private void tsmi_Unmake_Click(object sender, EventArgs e)
        {
            lst_ShowEnvPathValue.Items.Clear();
            lst_ShowEnvPathValue.Items.AddRange(reserve.ToArray());
            lst_ShowEnvPathName.Enabled = true;
        }

        private void lst_ShowEnvPathValue_DoubleClick(object sender, EventArgs e)
        {
            reserve.Clear();
            for (int i = 0; i < lst_ShowEnvPathValue.Items.Count; i++)
            {
                reserve.Add(lst_ShowEnvPathValue.Items[i].ToString());
            }
            lst_ShowEnvPathName.Enabled = false;
            tsmi_Unmake.Enabled = true;
        }

        private void lst_ShowEnvPathName_SelectedIndexChanged(object sender, EventArgs e)
        {
            tsmi_Unmake.Enabled = false;
        }

        private void btn_SetSpecPath_Click(object sender, EventArgs e)
        {
            string spec = txt_SetSpecPathName.Text.ToUpper();
            if (string.IsNullOrWhiteSpace(spec))
            {
                MessageBox.Show("请输入环境变量名!", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string value = txt_SetSpecPathValue.Text;
            if (string.IsNullOrWhiteSpace(value))
            {
                MessageBox.Show("请输入环境变量值!", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!System.IO.Directory.Exists(value))
            {
                MessageBox.Show("输入的环境变量值路径不存在!", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            cls_EnvUtils.SetSysEnvironment(spec, value);

            MessageBox.Show("设置成功!", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);

            RefreshEnvPathName();

        }

        private void btn_UpdateEnvPath_Click(object sender, EventArgs e)
        {
            if (chk_DirectUpdate.Checked)
            {
                cls_EnvUtils.UpdateSysEnvironment(txt_SetSpecPathValue.Text, false);
            }
            else
            {
                string spec = txt_SetSpecPathName.Text.ToUpper();
                if (string.IsNullOrWhiteSpace(spec))
                {
                    MessageBox.Show("请输入环境变量名!", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string name = cls_EnvUtils.GetSysEnvironmentByName(spec);

                if (string.IsNullOrEmpty(name))
                {
                    MessageBox.Show("不存在该环境变量名!", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DialogResult dr = MessageBox.Show("是否添加bin目录?", "Q", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                    cls_EnvUtils.UpdateSysEnvironment(name, true);
                else if (dr == DialogResult.No)
                    cls_EnvUtils.UpdateSysEnvironment(name, false);
                else
                    return;

                MessageBox.Show("设置成功!", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void lst_EnvPathName_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button==MouseButtons.Right)
            {
                int pos = GetScrollPos(lst_ShowEnvPathName.Handle, 1);
                int height = 0;
                for (int i = 0; i < lst_ShowEnvPathName.Items.Count; i++)
                {
                    height += lst_ShowEnvPathName.GetItemHeight(i);
                    if (e.Y <= height)
                    {
                        lst_ShowEnvPathName.SelectedIndex = i + pos;
                        return;
                    }
                }
            }
        }

        private void lst_EnvPathName_MouseUp(object sender, MouseEventArgs e)
        {
            if (lst_ShowEnvPathName.SelectedIndex < 0)
                return;

            string spec = lst_ShowEnvPathName.GetItemText(lst_ShowEnvPathName.SelectedItem);
            string name = cls_EnvUtils.GetSysEnvironmentByName(spec);

            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("不存在该环境变量名!", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            lst_ShowEnvPathValue.Items.Clear();
            string[] path = name.Split(';');
            lst_ShowEnvPathValue.Items.AddRange(path);
        }

        private void tsmi_DeleteEnvPath_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确认删除环境变量?", "Q", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;
            string name = lst_ShowEnvPathName.GetItemText(lst_ShowEnvPathName.SelectedItem);
            cls_EnvUtils.DeleteSysEnvironmentByName(name);

            RefreshEnvPathName();
        }
        #endregion

        #region Function
        public void RefreshEnvPathName()
        {
            System.Threading.Thread.Sleep(5);
            lst_ShowEnvPathName.Items.Clear();
            string[] allName = cls_EnvUtils.GetAllSysEnvironmentName();
            lst_ShowEnvPathName.Items.AddRange(allName);
        }
        #endregion

    }
}