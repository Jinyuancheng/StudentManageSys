namespace StudentManageSys
{
    partial class fmMain
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
            this.ip = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pass = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.mysql_ip = new System.Windows.Forms.TextBox();
            this.mysql_user = new System.Windows.Forms.TextBox();
            this.mysql_pass = new System.Windows.Forms.TextBox();
            this.mysql_name = new System.Windows.Forms.TextBox();
            this.btn_quit = new System.Windows.Forms.Button();
            this.btn_login = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ip
            // 
            this.ip.AutoSize = true;
            this.ip.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ip.Location = new System.Drawing.Point(175, 42);
            this.ip.Name = "ip";
            this.ip.Size = new System.Drawing.Size(53, 16);
            this.ip.TabIndex = 0;
            this.ip.Text = "Ip  :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(175, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "User:";
            // 
            // pass
            // 
            this.pass.AutoSize = true;
            this.pass.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.pass.Location = new System.Drawing.Point(175, 130);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(53, 16);
            this.pass.TabIndex = 0;
            this.pass.Text = "Pass:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(175, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Name:";
            // 
            // mysql_ip
            // 
            this.mysql_ip.Font = new System.Drawing.Font("楷体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.mysql_ip.Location = new System.Drawing.Point(247, 39);
            this.mysql_ip.Name = "mysql_ip";
            this.mysql_ip.Size = new System.Drawing.Size(137, 23);
            this.mysql_ip.TabIndex = 0;
            this.mysql_ip.Text = "localhost";
            // 
            // mysql_user
            // 
            this.mysql_user.Font = new System.Drawing.Font("楷体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.mysql_user.Location = new System.Drawing.Point(247, 83);
            this.mysql_user.Name = "mysql_user";
            this.mysql_user.Size = new System.Drawing.Size(137, 23);
            this.mysql_user.TabIndex = 1;
            this.mysql_user.Text = "root";
            // 
            // mysql_pass
            // 
            this.mysql_pass.Font = new System.Drawing.Font("楷体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.mysql_pass.Location = new System.Drawing.Point(247, 128);
            this.mysql_pass.Name = "mysql_pass";
            this.mysql_pass.Size = new System.Drawing.Size(137, 23);
            this.mysql_pass.TabIndex = 2;
            this.mysql_pass.Text = "ascent";
            // 
            // mysql_name
            // 
            this.mysql_name.Font = new System.Drawing.Font("楷体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.mysql_name.Location = new System.Drawing.Point(247, 170);
            this.mysql_name.Name = "mysql_name";
            this.mysql_name.Size = new System.Drawing.Size(137, 23);
            this.mysql_name.TabIndex = 3;
            this.mysql_name.Text = "student";
            // 
            // btn_quit
            // 
            this.btn_quit.Location = new System.Drawing.Point(178, 225);
            this.btn_quit.Name = "btn_quit";
            this.btn_quit.Size = new System.Drawing.Size(75, 23);
            this.btn_quit.TabIndex = 5;
            this.btn_quit.Text = "返回";
            this.btn_quit.UseVisualStyleBackColor = true;
            this.btn_quit.Click += new System.EventHandler(this.btn_quit_Click);
            // 
            // btn_login
            // 
            this.btn_login.Location = new System.Drawing.Point(309, 225);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(75, 23);
            this.btn_login.TabIndex = 4;
            this.btn_login.Text = "登录";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // fmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 334);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.btn_quit);
            this.Controls.Add(this.mysql_name);
            this.Controls.Add(this.mysql_pass);
            this.Controls.Add(this.mysql_user);
            this.Controls.Add(this.mysql_ip);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pass);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ip);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "登录MySQL";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ip;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label pass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox mysql_ip;
        private System.Windows.Forms.TextBox mysql_user;
        private System.Windows.Forms.TextBox mysql_pass;
        private System.Windows.Forms.TextBox mysql_name;
        private System.Windows.Forms.Button btn_quit;
        private System.Windows.Forms.Button btn_login;
    }
}

