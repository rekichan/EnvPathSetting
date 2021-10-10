
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Main));
            this.ms_Menu = new System.Windows.Forms.MenuStrip();
            this.tsmi_Explain = new System.Windows.Forms.ToolStripMenuItem();
            this.label4 = new System.Windows.Forms.Label();
            this.dgv_UserEnvPath = new System.Windows.Forms.DataGridView();
            this.col_UserEnvPathName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_UserEnvPathValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_AddUserEnvPath = new System.Windows.Forms.Button();
            this.dgv_SysEnvPath = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_MdfUserEnvPath = new System.Windows.Forms.Button();
            this.btn_DelUserEnvPath = new System.Windows.Forms.Button();
            this.btn_DelSysEnvPath = new System.Windows.Forms.Button();
            this.btn_MdfSysEnvPath = new System.Windows.Forms.Button();
            this.btn_AddSysEnvPath = new System.Windows.Forms.Button();
            this.ms_Menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_UserEnvPath)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SysEnvPath)).BeginInit();
            this.SuspendLayout();
            // 
            // ms_Menu
            // 
            this.ms_Menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ms_Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_Explain});
            this.ms_Menu.Location = new System.Drawing.Point(0, 0);
            this.ms_Menu.Name = "ms_Menu";
            this.ms_Menu.Size = new System.Drawing.Size(782, 28);
            this.ms_Menu.TabIndex = 15;
            this.ms_Menu.Text = "menuStrip1";
            // 
            // tsmi_Explain
            // 
            this.tsmi_Explain.BackColor = System.Drawing.Color.Khaki;
            this.tsmi_Explain.Name = "tsmi_Explain";
            this.tsmi_Explain.Size = new System.Drawing.Size(83, 24);
            this.tsmi_Explain.Text = "软件说明";
            this.tsmi_Explain.Click += new System.EventHandler(this.tsmi_Explain_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "用户环境变量值";
            // 
            // dgv_UserEnvPath
            // 
            this.dgv_UserEnvPath.AllowUserToAddRows = false;
            this.dgv_UserEnvPath.AllowUserToDeleteRows = false;
            this.dgv_UserEnvPath.AllowUserToResizeColumns = false;
            this.dgv_UserEnvPath.AllowUserToResizeRows = false;
            this.dgv_UserEnvPath.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_UserEnvPath.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_UserEnvPathName,
            this.col_UserEnvPathValue});
            this.dgv_UserEnvPath.Location = new System.Drawing.Point(12, 53);
            this.dgv_UserEnvPath.MultiSelect = false;
            this.dgv_UserEnvPath.Name = "dgv_UserEnvPath";
            this.dgv_UserEnvPath.ReadOnly = true;
            this.dgv_UserEnvPath.RowHeadersVisible = false;
            this.dgv_UserEnvPath.RowHeadersWidth = 51;
            this.dgv_UserEnvPath.RowTemplate.Height = 27;
            this.dgv_UserEnvPath.Size = new System.Drawing.Size(660, 273);
            this.dgv_UserEnvPath.TabIndex = 17;
            // 
            // col_UserEnvPathName
            // 
            this.col_UserEnvPathName.HeaderText = "变量";
            this.col_UserEnvPathName.MinimumWidth = 6;
            this.col_UserEnvPathName.Name = "col_UserEnvPathName";
            this.col_UserEnvPathName.ReadOnly = true;
            this.col_UserEnvPathName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.col_UserEnvPathName.Width = 230;
            // 
            // col_UserEnvPathValue
            // 
            this.col_UserEnvPathValue.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_UserEnvPathValue.HeaderText = "值";
            this.col_UserEnvPathValue.MinimumWidth = 6;
            this.col_UserEnvPathValue.Name = "col_UserEnvPathValue";
            this.col_UserEnvPathValue.ReadOnly = true;
            this.col_UserEnvPathValue.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // btn_AddUserEnvPath
            // 
            this.btn_AddUserEnvPath.Location = new System.Drawing.Point(680, 53);
            this.btn_AddUserEnvPath.Name = "btn_AddUserEnvPath";
            this.btn_AddUserEnvPath.Size = new System.Drawing.Size(90, 45);
            this.btn_AddUserEnvPath.TabIndex = 18;
            this.btn_AddUserEnvPath.Text = "新建";
            this.btn_AddUserEnvPath.UseVisualStyleBackColor = true;
            this.btn_AddUserEnvPath.Click += new System.EventHandler(this.btn_AddUserEnvPath_Click);
            // 
            // dgv_SysEnvPath
            // 
            this.dgv_SysEnvPath.AllowUserToAddRows = false;
            this.dgv_SysEnvPath.AllowUserToDeleteRows = false;
            this.dgv_SysEnvPath.AllowUserToResizeColumns = false;
            this.dgv_SysEnvPath.AllowUserToResizeRows = false;
            this.dgv_SysEnvPath.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_SysEnvPath.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.dgv_SysEnvPath.Location = new System.Drawing.Point(12, 365);
            this.dgv_SysEnvPath.MultiSelect = false;
            this.dgv_SysEnvPath.Name = "dgv_SysEnvPath";
            this.dgv_SysEnvPath.ReadOnly = true;
            this.dgv_SysEnvPath.RowHeadersVisible = false;
            this.dgv_SysEnvPath.RowHeadersWidth = 51;
            this.dgv_SysEnvPath.RowTemplate.Height = 27;
            this.dgv_SysEnvPath.Size = new System.Drawing.Size(660, 273);
            this.dgv_SysEnvPath.TabIndex = 19;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "变量";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn1.Width = 230;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.HeaderText = "值";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 342);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 20);
            this.label5.TabIndex = 20;
            this.label5.Text = "系统环境变量值";
            // 
            // btn_MdfUserEnvPath
            // 
            this.btn_MdfUserEnvPath.Location = new System.Drawing.Point(680, 136);
            this.btn_MdfUserEnvPath.Name = "btn_MdfUserEnvPath";
            this.btn_MdfUserEnvPath.Size = new System.Drawing.Size(90, 45);
            this.btn_MdfUserEnvPath.TabIndex = 21;
            this.btn_MdfUserEnvPath.Text = "编辑";
            this.btn_MdfUserEnvPath.UseVisualStyleBackColor = true;
            this.btn_MdfUserEnvPath.Click += new System.EventHandler(this.btn_MdfUserEnvPath_Click);
            // 
            // btn_DelUserEnvPath
            // 
            this.btn_DelUserEnvPath.Location = new System.Drawing.Point(680, 219);
            this.btn_DelUserEnvPath.Name = "btn_DelUserEnvPath";
            this.btn_DelUserEnvPath.Size = new System.Drawing.Size(90, 45);
            this.btn_DelUserEnvPath.TabIndex = 22;
            this.btn_DelUserEnvPath.Text = "删除";
            this.btn_DelUserEnvPath.UseVisualStyleBackColor = true;
            this.btn_DelUserEnvPath.Click += new System.EventHandler(this.btn_DelUserEnvPath_Click);
            // 
            // btn_DelSysEnvPath
            // 
            this.btn_DelSysEnvPath.Location = new System.Drawing.Point(680, 531);
            this.btn_DelSysEnvPath.Name = "btn_DelSysEnvPath";
            this.btn_DelSysEnvPath.Size = new System.Drawing.Size(90, 45);
            this.btn_DelSysEnvPath.TabIndex = 25;
            this.btn_DelSysEnvPath.Text = "删除";
            this.btn_DelSysEnvPath.UseVisualStyleBackColor = true;
            this.btn_DelSysEnvPath.Click += new System.EventHandler(this.btn_DelSysEnvPath_Click);
            // 
            // btn_MdfSysEnvPath
            // 
            this.btn_MdfSysEnvPath.Location = new System.Drawing.Point(680, 448);
            this.btn_MdfSysEnvPath.Name = "btn_MdfSysEnvPath";
            this.btn_MdfSysEnvPath.Size = new System.Drawing.Size(90, 45);
            this.btn_MdfSysEnvPath.TabIndex = 24;
            this.btn_MdfSysEnvPath.Text = "编辑";
            this.btn_MdfSysEnvPath.UseVisualStyleBackColor = true;
            this.btn_MdfSysEnvPath.Click += new System.EventHandler(this.btn_MdfSysEnvPath_Click);
            // 
            // btn_AddSysEnvPath
            // 
            this.btn_AddSysEnvPath.Location = new System.Drawing.Point(680, 365);
            this.btn_AddSysEnvPath.Name = "btn_AddSysEnvPath";
            this.btn_AddSysEnvPath.Size = new System.Drawing.Size(90, 45);
            this.btn_AddSysEnvPath.TabIndex = 23;
            this.btn_AddSysEnvPath.Text = "新建";
            this.btn_AddSysEnvPath.UseVisualStyleBackColor = true;
            this.btn_AddSysEnvPath.Click += new System.EventHandler(this.btn_AddSysEnvPath_Click);
            // 
            // frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 655);
            this.Controls.Add(this.btn_DelSysEnvPath);
            this.Controls.Add(this.btn_MdfSysEnvPath);
            this.Controls.Add(this.btn_AddSysEnvPath);
            this.Controls.Add(this.btn_DelUserEnvPath);
            this.Controls.Add(this.btn_MdfUserEnvPath);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgv_SysEnvPath);
            this.Controls.Add(this.btn_AddUserEnvPath);
            this.Controls.Add(this.dgv_UserEnvPath);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ms_Menu);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 700);
            this.MinimumSize = new System.Drawing.Size(800, 700);
            this.Name = "frm_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Win7环境变量设置";
            this.Load += new System.EventHandler(this.frm_Main_Load);
            this.ms_Menu.ResumeLayout(false);
            this.ms_Menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_UserEnvPath)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SysEnvPath)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip ms_Menu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStripMenuItem tsmi_Explain;
        private System.Windows.Forms.DataGridView dgv_UserEnvPath;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_UserEnvPathName;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_UserEnvPathValue;
        private System.Windows.Forms.Button btn_AddUserEnvPath;
        private System.Windows.Forms.DataGridView dgv_SysEnvPath;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_MdfUserEnvPath;
        private System.Windows.Forms.Button btn_DelUserEnvPath;
        private System.Windows.Forms.Button btn_DelSysEnvPath;
        private System.Windows.Forms.Button btn_MdfSysEnvPath;
        private System.Windows.Forms.Button btn_AddSysEnvPath;
    }
}

