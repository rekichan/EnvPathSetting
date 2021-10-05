
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
            this.btn_GetEnvPath = new System.Windows.Forms.Button();
            this.lst_EnvPath = new System.Windows.Forms.ListBox();
            this.btn_SetSpecPath = new System.Windows.Forms.Button();
            this.btn_UpdateEnvPath = new System.Windows.Forms.Button();
            this.txt_GetSpecPath = new System.Windows.Forms.TextBox();
            this.txt_Path = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chk_DirectUpdate = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btn_GetEnvPath
            // 
            this.btn_GetEnvPath.Font = new System.Drawing.Font("微软雅黑", 6.6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_GetEnvPath.Location = new System.Drawing.Point(12, 359);
            this.btn_GetEnvPath.Name = "btn_GetEnvPath";
            this.btn_GetEnvPath.Size = new System.Drawing.Size(90, 45);
            this.btn_GetEnvPath.TabIndex = 0;
            this.btn_GetEnvPath.Text = "获取指定PATH";
            this.btn_GetEnvPath.UseVisualStyleBackColor = true;
            this.btn_GetEnvPath.Click += new System.EventHandler(this.btn_GetSpecEnvPath_Click);
            // 
            // lst_EnvPath
            // 
            this.lst_EnvPath.FormattingEnabled = true;
            this.lst_EnvPath.ItemHeight = 20;
            this.lst_EnvPath.Location = new System.Drawing.Point(12, 12);
            this.lst_EnvPath.Name = "lst_EnvPath";
            this.lst_EnvPath.Size = new System.Drawing.Size(758, 304);
            this.lst_EnvPath.TabIndex = 1;
            // 
            // btn_SetSpecPath
            // 
            this.btn_SetSpecPath.Font = new System.Drawing.Font("微软雅黑", 6.6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_SetSpecPath.Location = new System.Drawing.Point(12, 422);
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
            this.btn_UpdateEnvPath.Location = new System.Drawing.Point(12, 486);
            this.btn_UpdateEnvPath.Name = "btn_UpdateEnvPath";
            this.btn_UpdateEnvPath.Size = new System.Drawing.Size(90, 45);
            this.btn_UpdateEnvPath.TabIndex = 3;
            this.btn_UpdateEnvPath.Text = "插入SYSPATH";
            this.btn_UpdateEnvPath.UseVisualStyleBackColor = true;
            this.btn_UpdateEnvPath.Click += new System.EventHandler(this.btn_UpdateEnvPath_Click);
            // 
            // txt_GetSpecPath
            // 
            this.txt_GetSpecPath.Location = new System.Drawing.Point(121, 359);
            this.txt_GetSpecPath.Multiline = true;
            this.txt_GetSpecPath.Name = "txt_GetSpecPath";
            this.txt_GetSpecPath.Size = new System.Drawing.Size(177, 130);
            this.txt_GetSpecPath.TabIndex = 4;
            // 
            // txt_Path
            // 
            this.txt_Path.Location = new System.Drawing.Point(314, 359);
            this.txt_Path.Multiline = true;
            this.txt_Path.Name = "txt_Path";
            this.txt_Path.Size = new System.Drawing.Size(456, 172);
            this.txt_Path.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(117, 336);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "环境变量名";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(310, 336);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "环境变量值";
            // 
            // chk_DirectUpdate
            // 
            this.chk_DirectUpdate.AutoSize = true;
            this.chk_DirectUpdate.Location = new System.Drawing.Point(121, 507);
            this.chk_DirectUpdate.Name = "chk_DirectUpdate";
            this.chk_DirectUpdate.Size = new System.Drawing.Size(136, 24);
            this.chk_DirectUpdate.TabIndex = 8;
            this.chk_DirectUpdate.Text = "直接插入变量值";
            this.chk_DirectUpdate.UseVisualStyleBackColor = true;
            // 
            // frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 555);
            this.Controls.Add(this.chk_DirectUpdate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Path);
            this.Controls.Add(this.txt_GetSpecPath);
            this.Controls.Add(this.btn_UpdateEnvPath);
            this.Controls.Add(this.btn_SetSpecPath);
            this.Controls.Add(this.lst_EnvPath);
            this.Controls.Add(this.btn_GetEnvPath);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "frm_Main";
            this.Text = "环境变量设置";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_GetEnvPath;
        private System.Windows.Forms.ListBox lst_EnvPath;
        private System.Windows.Forms.Button btn_SetSpecPath;
        private System.Windows.Forms.Button btn_UpdateEnvPath;
        private System.Windows.Forms.TextBox txt_GetSpecPath;
        private System.Windows.Forms.TextBox txt_Path;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chk_DirectUpdate;
    }
}

