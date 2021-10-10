
namespace EnvPathSetting
{
    partial class frm_MdfEnvPath
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_MdfEnvPath));
            this.lst_EnvPath = new System.Windows.Forms.ListBox();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Edit = new System.Windows.Forms.Button();
            this.btn_Browse = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_MoveUp = new System.Windows.Forms.Button();
            this.btn_MoveDown = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_Confirm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lst_EnvPath
            // 
            this.lst_EnvPath.FormattingEnabled = true;
            this.lst_EnvPath.ItemHeight = 20;
            this.lst_EnvPath.Location = new System.Drawing.Point(12, 15);
            this.lst_EnvPath.Name = "lst_EnvPath";
            this.lst_EnvPath.Size = new System.Drawing.Size(395, 524);
            this.lst_EnvPath.TabIndex = 0;
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(434, 15);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(80, 40);
            this.btn_Add.TabIndex = 1;
            this.btn_Add.Text = "新建";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Edit
            // 
            this.btn_Edit.Location = new System.Drawing.Point(434, 84);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(80, 40);
            this.btn_Edit.TabIndex = 2;
            this.btn_Edit.Text = "编辑";
            this.btn_Edit.UseVisualStyleBackColor = true;
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // btn_Browse
            // 
            this.btn_Browse.Location = new System.Drawing.Point(434, 153);
            this.btn_Browse.Name = "btn_Browse";
            this.btn_Browse.Size = new System.Drawing.Size(80, 40);
            this.btn_Browse.TabIndex = 3;
            this.btn_Browse.Text = "浏览";
            this.btn_Browse.UseVisualStyleBackColor = true;
            this.btn_Browse.Click += new System.EventHandler(this.btn_Browse_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(434, 222);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(80, 40);
            this.btn_Delete.TabIndex = 4;
            this.btn_Delete.Text = "删除";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_MoveUp
            // 
            this.btn_MoveUp.Location = new System.Drawing.Point(434, 291);
            this.btn_MoveUp.Name = "btn_MoveUp";
            this.btn_MoveUp.Size = new System.Drawing.Size(80, 40);
            this.btn_MoveUp.TabIndex = 5;
            this.btn_MoveUp.Text = "上移";
            this.btn_MoveUp.UseVisualStyleBackColor = true;
            this.btn_MoveUp.Click += new System.EventHandler(this.btn_MoveUp_Click);
            // 
            // btn_MoveDown
            // 
            this.btn_MoveDown.Location = new System.Drawing.Point(434, 360);
            this.btn_MoveDown.Name = "btn_MoveDown";
            this.btn_MoveDown.Size = new System.Drawing.Size(80, 40);
            this.btn_MoveDown.TabIndex = 6;
            this.btn_MoveDown.Text = "下移";
            this.btn_MoveDown.UseVisualStyleBackColor = true;
            this.btn_MoveDown.Click += new System.EventHandler(this.btn_MoveDown_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(434, 498);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(80, 40);
            this.btn_Cancel.TabIndex = 8;
            this.btn_Cancel.Text = "取消";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_Confirm
            // 
            this.btn_Confirm.Location = new System.Drawing.Point(434, 429);
            this.btn_Confirm.Name = "btn_Confirm";
            this.btn_Confirm.Size = new System.Drawing.Size(80, 40);
            this.btn_Confirm.TabIndex = 7;
            this.btn_Confirm.Text = "确定";
            this.btn_Confirm.UseVisualStyleBackColor = true;
            this.btn_Confirm.Click += new System.EventHandler(this.btn_Confirm_Click);
            // 
            // frm_MdfEnvPath
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 555);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Confirm);
            this.Controls.Add(this.btn_MoveDown);
            this.Controls.Add(this.btn_MoveUp);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Browse);
            this.Controls.Add(this.btn_Edit);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.lst_EnvPath);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(550, 600);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(550, 600);
            this.Name = "frm_MdfEnvPath";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "编辑环境变量";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frm_MdfEnvPath_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lst_EnvPath;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Edit;
        private System.Windows.Forms.Button btn_Browse;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_MoveUp;
        private System.Windows.Forms.Button btn_MoveDown;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_Confirm;
    }
}