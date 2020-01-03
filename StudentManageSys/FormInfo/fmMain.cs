using StudentManageSys.FormInfo;
using StudentManageSys.MySql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManageSys
{
    public partial class fmMain : Form
    {

        private CMySql m_oMysql;    //操作MySQL对象
        private string m_sIp;       //登录mysql Ip
        private string m_sUser;     //登录mysql 用户名
        private string m_sPass;     //登录mysql 密码
        private string m_sName;     //使用数据库名称
        private fmStudent m_fdStudent; //操作学生信息窗体

        /// <summary>
        /// 构造函数
        /// </summary>
        public fmMain()
        {
            //初始化窗体
            InitializeComponent();
            this.Init();
        }
        /// <summary>
        /// 初始化成员变量等
        /// </summary>
        private void Init()
        {
            m_sIp = "";
            m_sName = "";
            m_sUser = "";
            m_sPass = "";
            m_oMysql = new CMySql();
        }
        /// <summary>
        /// 返回按钮点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_quit_Click(object sender, EventArgs e)
        {
            //关闭当前窗口
            this.Close();
        }
        /// <summary>
        /// 登录按钮点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_login_Click(object sender, EventArgs e)
        {
            if (this.ip.Text == "" || this.ip.Text == null)
            {
                MessageBox.Show("请输入mysql服务的ip地址", "提示",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return;
            }
            else if (this.mysql_user.Text == "" || this.mysql_user.Text == null)
            {
                MessageBox.Show("请输入mysql服务的登录用户名", "提示",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return;
            }
            else if (this.pass.Text == "" || this.pass.Text == null)
            {
                MessageBox.Show("请输入mysql服务的登录密码", "提示",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return;
            }
            else if (this.mysql_name.Text == "" || this.mysql_name.Text == null)
            {
                MessageBox.Show("请输入mysql服务的数据库名称", "提示",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return;
            }
            else
            {
                m_sIp = this.mysql_ip.Text;
                m_sUser = this.mysql_user.Text;
                m_sPass = this.mysql_pass.Text;
                m_sName = this.mysql_name.Text;
                //建立链接
                if (m_oMysql.MysqlConnect(m_sIp, m_sUser, m_sPass, m_sName))
                {
                    //显示页面
                    m_fdStudent = new fmStudent(m_oMysql);
                    m_fdStudent.Show();
                    //关闭当前窗户
                    this.Visible = false;
                }
                else
                {
                    MessageBox.Show("数据库登录失败", "提示",
                        MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    return;
                }
            }
        }
    }
}
