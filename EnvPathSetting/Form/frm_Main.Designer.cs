
namespace EnvPathSetting
{
    partial class frm_Main
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Main));
            this.lst_ShowEnvPathValue = new System.Windows.Forms.ListBox();
            this.btn_SetSpecPath = new System.Windows.Forms.Button();
            this.btn_UpdateEnvPath = new System.Windows.Forms.Button();
            this.txt_SetSpecPathName = new System.Windows.Forms.TextBox();
            this.txt_SetSpecPathValue = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chk_DirectUpdate = new System.Windows.Forms.CheckBox();
            this.lst_ShowEnvPathName = new System.Windows.Forms.ListBox();
            this.cms_EnvPathName = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmi_DeleteEnvPath = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            this.ms_Menu = new System.Windows.Forms.MenuStrip();
            this.tsmi_Save = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_Unmake = new System.Windows.Forms.ToolStripMenuItem();
            this.label4 = new System.Windows.Forms.Label();
            this.tsmi_Explain = new System.Windows.Forms.ToolStripMenuItem();
            this.cms_EnvPathName.SuspendLayout();
            this.ms_Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // lst_ShowEnvPathValue
            // 
            this.lst_ShowEnvPathValue.FormattingEnabled = true;
            this.lst_ShowEnvPathValue.ItemHeight = 20;
            this.lst_ShowEnvPathValue.Location = new System.Drawing.Point(12, 32);
            this.lst_ShowEnvPathValue.Name = "lst_ShowEnvPathValue";
            this.lst_ShowEnvPathValue.Size = new System.Drawing.Size(758, 284);
            this.lst_ShowEnvPathValue.TabIndex = 1;
            this.lst_ShowEnvPathValue.DoubleClick += new System.EventHandler(this.lst_ShowEnvPathValue_DoubleClick);
            // 
            // btn_SetSpecPath
            // 
            this.btn_SetSpecPath.Font = new System.Drawing.Font("微软雅黑", 6.6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_SetSpecPath.Location = new System.Drawing.Point(303, 429);
            this.btn_SetSpecPath.Name = "btn_SetSpecPath";
            this.btn_SetSpecPath.Size = new System.Drawing.Size(90, 45);
            this.btn_SetSpecPath.TabIndex = 2;
            this.btn_SetSpecPath.Text = "设置指定PATH";
            this.btn_SetSpecPath.UseVisualStyleBackColor = true;
            this.btn_SetSpecPath.Click += new System.EventHandler(this.btn_SetSpecPath_Click);
            // 
            // btn_UpdateEnvPath
            // 
            this.btn_UpdateEnvPath.Font = new System.Drawing.Font("微软雅黑", 6.6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_UpdateEnvPath.Location = new System.Drawing.Point(303, 486);
            this.btn_UpdateEnvPath.Name = "btn_UpdateEnvPath";
            this.btn_UpdateEnvPath.Size = new System.Drawing.Size(90, 45);
            this.btn_UpdateEnvPath.TabIndex = 3;
            this.btn_UpdateEnvPath.Text = "插入SYSPATH";
            this.btn_UpdateEnvPath.UseVisualStyleBackColor = true;
            this.btn_UpdateEnvPath.Click += new System.EventHandler(this.btn_UpdateEnvPath_Click);
            // 
            // txt_SetSpecPathName
            // 
            this.txt_SetSpecPathName.Location = new System.Drawing.Point(303, 347);
            this.txt_SetSpecPathName.Multiline = true;
            this.txt_SetSpecPathName.Name = "txt_SetSpecPathName";
            this.txt_SetSpecPathName.Size = new System.Drawing.Size(176, 73);
            this.txt_SetSpecPathName.TabIndex = 4;
            // 
            // txt_SetSpecPathValue
            // 
            this.txt_SetSpecPathValue.Location = new System.Drawing.Point(485, 347);
            this.txt_SetSpecPathValue.Multiline = true;
            this.txt_SetSpecPathValue.Name = "txt_SetSpecPathValue";
            this.txt_SetSpecPathValue.Size = new System.Drawing.Size(285, 184);
            this.txt_SetSpecPathValue.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(299, 324);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "新增环境变量名";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(484, 324);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "新增环境变量值";
            // 
            // chk_DirectUpdate
            // 
            this.chk_DirectUpdate.AutoSize = true;
            this.chk_DirectUpdate.BackColor = System.Drawing.SystemColors.Control;
            this.chk_DirectUpdate.Checked = true;
            this.chk_DirectUpdate.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_DirectUpdate.Location = new System.Drawing.Point(679, 320);
            this.chk_DirectUpdate.Name = "chk_DirectUpdate";
            this.chk_DirectUpdate.Size = new System.Drawing.Size(91, 24);
            this.chk_DirectUpdate.TabIndex = 8;
            this.chk_DirectUpdate.Text = "直接插入";
            this.chk_DirectUpdate.UseVisualStyleBackColor = false;
            // 
            // lst_ShowEnvPathName
            // 
            this.lst_ShowEnvPathName.ContextMenuStrip = this.cms_EnvPathName;
            this.lst_ShowEnvPathName.FormattingEnabled = true;
            this.lst_ShowEnvPathName.ItemHeight = 20;
            this.lst_ShowEnvPathName.Location = new System.Drawing.Point(12, 347);
            this.lst_ShowEnvPathName.Name = "lst_ShowEnvPathName";
            this.lst_ShowEnvPathName.Size = new System.Drawing.Size(285, 184);
            this.lst_ShowEnvPathName.TabIndex = 9;
            this.lst_ShowEnvPathName.SelectedIndexChanged += new System.EventHandler(this.lst_ShowEnvPathName_SelectedIndexChanged);
            this.lst_ShowEnvPathName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lst_ShowEnvPathName_KeyDown);
            this.lst_ShowEnvPathName.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lst_EnvPathName_MouseDown);
            this.lst_ShowEnvPathName.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lst_EnvPathName_MouseUp);
            // 
            // cms_EnvPathName
            // 
            this.cms_EnvPathName.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cms_EnvPathName.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_DeleteEnvPath});
            this.cms_EnvPathName.Name = "cms_EnvPathName";
            this.cms_EnvPathName.Size = new System.Drawing.Size(169, 28);
            // 
            // tsmi_DeleteEnvPath
            // 
            this.tsmi_DeleteEnvPath.Name = "tsmi_DeleteEnvPath";
            this.tsmi_DeleteEnvPath.Size = new System.Drawing.Size(168, 24);
            this.tsmi_DeleteEnvPath.Text = "删除环境变量";
            this.tsmi_DeleteEnvPath.Click += new System.EventHandler(this.tsmi_DeleteEnvPath_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 324);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "系统环境变量名";
            // 
            // ms_Menu
            // 
            this.ms_Menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ms_Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_Save,
            this.tsmi_Unmake,
            this.tsmi_Explain});
            this.ms_Menu.Location = new System.Drawing.Point(0, 0);
            this.ms_Menu.Name = "ms_Menu";
            this.ms_Menu.Size = new System.Drawing.Size(782, 28);
            this.ms_Menu.TabIndex = 15;
            this.ms_Menu.Text = "menuStrip1";
            // 
            // tsmi_Save
            // 
            this.tsmi_Save.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsmi_Save.Enabled = false;
            this.tsmi_Save.Name = "tsmi_Save";
            this.tsmi_Save.Size = new System.Drawing.Size(53, 24);
            this.tsmi_Save.Text = "保存";
            this.tsmi_Save.Click += new System.EventHandler(this.tsmi_Save_Click);
            // 
            // tsmi_Unmake
            // 
            this.tsmi_Unmake.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsmi_Unmake.Enabled = false;
            this.tsmi_Unmake.Name = "tsmi_Unmake";
            this.tsmi_Unmake.Size = new System.Drawing.Size(53, 24);
            this.tsmi_Unmake.Text = "撤销";
            this.tsmi_Unmake.Click += new System.EventHandler(this.tsmi_Unmake_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "系统环境变量值";
            // 
            // tsmi_Explain
            // 
            this.tsmi_Explain.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsmi_Explain.Name = "tsmi_Explain";
            this.tsmi_Explain.Size = new System.Drawing.Size(83, 24);
            this.tsmi_Explain.Text = "软件说明";
            this.tsmi_Explain.Click += new System.EventHandler(this.tsmi_Explain_Click);
            // 
            // frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 555);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ms_Menu);
            this.Controls.Add(this.chk_DirectUpdate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lst_ShowEnvPathName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_SetSpecPathValue);
            this.Controls.Add(this.txt_SetSpecPathName);
            this.Controls.Add(this.btn_UpdateEnvPath);
            this.Controls.Add(this.btn_SetSpecPath);
            this.Controls.Add(this.lst_ShowEnvPathValue);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "frm_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Win7环境变量设置 - by GazeonChan";
            this.Load += new System.EventHandler(this.frm_Main_Load);
            this.cms_EnvPathName.ResumeLayout(false);
            this.ms_Menu.ResumeLayout(false);
            this.ms_Menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox lst_ShowEnvPathValue;
        private System.Windows.Forms.Button btn_SetSpecPath;
        private System.Windows.Forms.Button btn_UpdateEnvPath;
        private System.Windows.Forms.TextBox txt_SetSpecPathName;
        private System.Windows.Forms.TextBox txt_SetSpecPathValue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chk_DirectUpdate;
        private System.Windows.Forms.ListBox lst_ShowEnvPathName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ContextMenuStrip cms_EnvPathName;
        private System.Windows.Forms.ToolStripMenuItem tsmi_DeleteEnvPath;
        private System.Windows.Forms.MenuStrip ms_Menu;
        private System.Windows.Forms.ToolStripMenuItem tsmi_Save;
        private System.Windows.Forms.ToolStripMenuItem tsmi_Unmake;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStripMenuItem tsmi_Explain;
    }
}

