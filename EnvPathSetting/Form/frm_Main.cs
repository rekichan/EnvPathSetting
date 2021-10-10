using System;
using System.Collections.Generic;
using System.Windows.Forms;
using EnvPathSetting.Class;
using System.Runtime.InteropServices;

namespace EnvPathSetting
{
    public partial class frm_Main : Form
    {
        #region Constructor
        public frm_Main()
        {
            InitializeComponent();
        }
        #endregion
        
        #region API
        [DllImport("user32.dll", EntryPoint = "GetScrollPos")]
        public static extern int GetScrollPos(IntPtr hwnd, int nBar);
        #endregion

        #region FormEvent
        private void frm_Main_Load(object sender, EventArgs e)
        {
            cls_Common.hwndFrmMain = this.Handle;
            RefreshSysEnvPath();
            RefreshUserEnvPath();
            label4.Text = Environment.UserName + "用户环境变量值";
        }
        #endregion

        #region Event
        private void btn_AddUserEnvPath_Click(object sender, EventArgs e)
        {
            cls_Common.isSystemEnvPath = false;
            cls_Common.isModify = false;
            cls_Common.isEdit = false;
            frm_AddEnvPath addEnvPath = new frm_AddEnvPath();
            addEnvPath.ShowDialog();
        }

        private void btn_AddSysEnvPath_Click(object sender, EventArgs e)
        {
            cls_Common.isSystemEnvPath = true;
            cls_Common.isModify = false;
            cls_Common.isEdit = false;
            frm_AddEnvPath addEnvPath = new frm_AddEnvPath();
            addEnvPath.ShowDialog();
        }

        private void btn_DelUserEnvPath_Click(object sender, EventArgs e)
        {
            if (dgv_UserEnvPath.SelectedCells.Count > 0)
            {
                if (MessageBox.Show("确认删除环境变量?", "Q", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    return;

                string currentName = dgv_UserEnvPath.Rows[dgv_UserEnvPath.CurrentCell.RowIndex].Cells[0].Value.ToString();
                cls_EnvUtils.DeleteUserEnvironmentByName(currentName);
                dgv_UserEnvPath.Rows.Remove(dgv_UserEnvPath.Rows[dgv_UserEnvPath.CurrentCell.RowIndex]);
            }
        }

        private void btn_DelSysEnvPath_Click(object sender, EventArgs e)
        {
            if (dgv_SysEnvPath.SelectedCells.Count > 0)
            {
                if (MessageBox.Show("确认删除环境变量?", "Q", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    return;
                string currentName = dgv_SysEnvPath.Rows[dgv_SysEnvPath.CurrentCell.RowIndex].Cells[0].Value.ToString();
                cls_EnvUtils.DeleteSysEnvironmentByName(currentName);
                dgv_SysEnvPath.Rows.Remove(dgv_SysEnvPath.Rows[dgv_SysEnvPath.CurrentCell.RowIndex]);
            }
        }

        private void btn_MdfUserEnvPath_Click(object sender, EventArgs e)
        {
            if (dgv_UserEnvPath.SelectedCells.Count > 0)
            {
                string currentName = dgv_UserEnvPath.Rows[dgv_UserEnvPath.CurrentCell.RowIndex].Cells[0].Value.ToString();
                cls_Common.currentName = currentName;
                cls_Common.isSystemEnvPath = false;
                frm_MdfEnvPath mdfEnvPath = new frm_MdfEnvPath();
                mdfEnvPath.ShowDialog();
            }
        }

        private void btn_MdfSysEnvPath_Click(object sender, EventArgs e)
        {
            if (dgv_SysEnvPath.SelectedCells.Count > 0)
            {
                string currentName = dgv_SysEnvPath.Rows[dgv_SysEnvPath.CurrentCell.RowIndex].Cells[0].Value.ToString();
                cls_Common.currentName = currentName;
                cls_Common.isSystemEnvPath = true;
                frm_MdfEnvPath mdfEnvPath = new frm_MdfEnvPath();
                mdfEnvPath.ShowDialog();
            }
        }

        private void tsmi_Explain_Click(object sender, EventArgs e)
        {
            frm_Explain explain = new frm_Explain();
            explain.ShowDialog();
        }

        private void lst_ShowEnvPathName_SelectedIndexChanged(object sender, EventArgs e)
        {
            //tsmi_Unmake.Enabled = false;
        }
        #endregion

        #region Function
        public void RefreshSysEnvPath()
        {
            dgv_SysEnvPath.Rows.Clear();
            string[] allName = cls_EnvUtils.GetAllSysEnvironmentName();
            for (int i = 0; i < allName.Length; i++)
            {
                DataGridViewRow row = new DataGridViewRow();
                DataGridViewTextBoxCell nameCell = new DataGridViewTextBoxCell();
                nameCell.Value = allName[i];
                DataGridViewTextBoxCell valueCell = new DataGridViewTextBoxCell();
                valueCell.Value = cls_EnvUtils.GetSysEnvironmentByName(allName[i]);
                row.Cells.Add(nameCell);
                row.Cells.Add(valueCell);
                dgv_SysEnvPath.Rows.Add(row);
            }
        }

        public void RefreshUserEnvPath()
        {
            dgv_UserEnvPath.Rows.Clear();
            string[] allName = cls_EnvUtils.GellAllUserEnvironmentName();
            for (int i = 0; i < allName.Length; i++)
            {
                DataGridViewRow row = new DataGridViewRow();
                DataGridViewTextBoxCell nameCell = new DataGridViewTextBoxCell();
                nameCell.Value = allName[i];
                DataGridViewTextBoxCell valueCell = new DataGridViewTextBoxCell();
                valueCell.Value = cls_EnvUtils.GetUserEnvironmentByName(allName[i]);
                row.Cells.Add(nameCell);
                row.Cells.Add(valueCell);
                dgv_UserEnvPath.Rows.Add(row);
            }
        }
        #endregion

        #region Message
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg){
                case cls_Common.ADD_USER_ENV_PATH:
                    string userField = Marshal.PtrToStringAnsi(m.WParam);
                    string[] userFields = userField.Split('^');
                    DataGridViewRow userRow = new DataGridViewRow();
                    DataGridViewTextBoxCell userNameCell = new DataGridViewTextBoxCell();
                    userNameCell.Value = userFields[0];
                    DataGridViewTextBoxCell userValueCell = new DataGridViewTextBoxCell();
                    userValueCell.Value = userFields[1];
                    userRow.Cells.Add(userNameCell);
                    userRow.Cells.Add(userValueCell);
                    dgv_UserEnvPath.Rows.Add(userRow);
                    break;

                case cls_Common.ADD_SYS_ENV_PATH:
                    string sysField = Marshal.PtrToStringAnsi(m.WParam);
                    string[] sysFields = sysField.Split('^');
                    DataGridViewRow sysRow = new DataGridViewRow();
                    DataGridViewTextBoxCell sysNameCell = new DataGridViewTextBoxCell();
                    sysNameCell.Value = sysFields[0];
                    DataGridViewTextBoxCell sysValueCell = new DataGridViewTextBoxCell();
                    sysValueCell.Value = sysFields[1];
                    sysRow.Cells.Add(sysNameCell);
                    sysRow.Cells.Add(sysValueCell);
                    dgv_SysEnvPath.Rows.Add(sysRow);
                    break;

                case cls_Common.REFRESH_MAIN_DGV_INFO:
                    RefreshSysEnvPath();
                    RefreshUserEnvPath();
                    break;

                default:
                    base.WndProc(ref m);
                    break;
            }
        }
        #endregion

    }
}