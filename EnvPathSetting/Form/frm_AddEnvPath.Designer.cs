
namespace EnvPathSetting
{
    partial class frm_AddEnvPath
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_AddEnvPath));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.txt_Value = new System.Windows.Forms.TextBox();
            this.btn_BrowseDict = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_AddEnvPath = new System.Windows.Forms.Button();
            this.btn_BrowseFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "变量名";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "变量值";
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(106, 30);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(380, 27);
            this.txt_Name.TabIndex = 2;
            // 
            // txt_Value
            // 
            this.txt_Value.Location = new System.Drawing.Point(106, 80);
            this.txt_Value.Name = "txt_Value";
            this.txt_Value.Size = new System.Drawing.Size(380, 27);
            this.txt_Value.TabIndex = 3;
            // 
            // btn_BrowseDict
            // 
            this.btn_BrowseDict.Location = new System.Drawing.Point(41, 133);
            this.btn_BrowseDict.Name = "btn_BrowseDict";
            this.btn_BrowseDict.Size = new System.Drawing.Size(90, 45);
            this.btn_BrowseDict.TabIndex = 4;
            this.btn_BrowseDict.Text = "选择目录";
            this.btn_BrowseDict.UseVisualStyleBackColor = true;
            this.btn_BrowseDict.Click += new System.EventHandler(this.btn_BrowseDict_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(401, 133);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(90, 45);
            this.btn_Cancel.TabIndex = 5;
            this.btn_Cancel.Text = "取消";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_AddEnvPath
            // 
            this.btn_AddEnvPath.Location = new System.Drawing.Point(281, 133);
            this.btn_AddEnvPath.Name = "btn_AddEnvPath";
            this.btn_AddEnvPath.Size = new System.Drawing.Size(90, 45);
            this.btn_AddEnvPath.TabIndex = 6;
            this.btn_AddEnvPath.Text = "新增";
            this.btn_AddEnvPath.UseVisualStyleBackColor = true;
            this.btn_AddEnvPath.Click += new System.EventHandler(this.btn_AddEnvPath_Click);
            // 
            // btn_BrowseFile
            // 
            this.btn_BrowseFile.Location = new System.Drawing.Point(161, 133);
            this.btn_BrowseFile.Name = "btn_BrowseFile";
            this.btn_BrowseFile.Size = new System.Drawing.Size(90, 45);
            this.btn_BrowseFile.TabIndex = 7;
            this.btn_BrowseFile.Text = "选择文件";
            this.btn_BrowseFile.UseVisualStyleBackColor = true;
            this.btn_BrowseFile.Click += new System.EventHandler(this.btn_BrowseFile_Click);
            // 
            // frm_AddEnvPath
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 185);
            this.Controls.Add(this.btn_BrowseFile);
            this.Controls.Add(this.btn_AddEnvPath);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_BrowseDict);
            this.Controls.Add(this.txt_Value);
            this.Controls.Add(this.txt_Name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_AddEnvPath";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "新建环境变量";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frm_AddEnvPath_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.TextBox txt_Value;
        private System.Windows.Forms.Button btn_BrowseDict;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_AddEnvPath;
        private System.Windows.Forms.Button btn_BrowseFile;
    }
}