using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EnvPathSetting.Class;

namespace EnvPathSetting
{
    public partial class frm_Main : Form
    {
        public frm_Main()
        {
            InitializeComponent();
        }

        private void btn_GetSpecEnvPath_Click(object sender, EventArgs e)
        {
            string spec = txt_GetSpecPath.Text;
            if (string.IsNullOrWhiteSpace(spec))
            {
                MessageBox.Show("请输入环境变量名!", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string name = cls_EnvUtils.GetSysEnvironmentByName(spec);

            if(string.IsNullOrEmpty(name))
            {
                MessageBox.Show("不存在该环境变量名!", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            lst_EnvPath.Items.Clear();
            string[] path = name.Split(';');
            lst_EnvPath.Items.AddRange(path);
        }

        private void btn_SetSpecPath_Click(object sender, EventArgs e)
        {
            string spec = txt_GetSpecPath.Text.ToUpper();
            if (string.IsNullOrWhiteSpace(spec))
            {
                MessageBox.Show("请输入环境变量名!", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string value = txt_Path.Text;
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
        }

        private void btn_UpdateEnvPath_Click(object sender, EventArgs e)
        {
            if (chk_DirectUpdate.Checked)
            {
                cls_EnvUtils.UpdateSysEnvironment(txt_Path.Text, false);
            }
            else
            {
                string spec = txt_GetSpecPath.Text.ToUpper();
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

                if (MessageBox.Show("是否添加bin目录?", "!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    cls_EnvUtils.UpdateSysEnvironment(name, true);
                else
                    cls_EnvUtils.UpdateSysEnvironment(name, false);
            }
        }
    }
}
