using StudentManageSys.MySql;
using StudentManageSys.Public;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManageSys.FormInfo
{
    public partial class fmStudent : Form
    {

        private CMySql m_oMysql;   //用来操作数据库对象
        private CStudentInfo m_oStudent; //学生信息
        private List<CStudentInfo> m_lstStuInfo; //用来显示从数据库中查询的信息

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="_sMysql">操作mysql的对象</param>
        public fmStudent(CMySql _sMysql)
        {
            if (_sMysql != null)
            {
                m_oMysql = _sMysql;
            }
            m_oMysql = _sMysql;
            InitializeComponent();
            //显示学生信息
            ShowStudentInfo();
        }
        /// <summary>
        /// 初始化
        /// </summary>
        private void Init()
        {
            m_oStudent = new CStudentInfo();
            m_lstStuInfo = new List<CStudentInfo>();
        }
        /// <summary>
        /// 清空编辑信息
        /// </summary>
        private void ClearEditInfo()
        {
            this.add_name.Text = "";
            this.add_age.Text = "";
            this.add_math.Text = "";
            this.add_chinese.Text = "";
            this.add_english.Text = "";
            this.modify_math.Text = "";
            this.modify_chinese.Text = "";
            this.modify_english.Text = "";
        }

        #region [过程] Mysql各种操作函数    
        /// <summary>
        /// 查询所有学生信息
        /// </summary>
        /// <returns></returns>
        private void SelectAllInfo()
        {
            string sSql = "select * from student";
            m_lstStuInfo = m_oMysql.MysqlSelect(sSql);
        }
        /// <summary>
        /// 插入信息
        /// </summary>
        /// <param name="_oStudentInfo">要插入的学生信息</param>
        /// <returns></returns>
        private bool InsertInfo(CStudentInfo _oStudentInfo)
        {
            bool bIsSucc = false;
            if (_oStudentInfo != null)
            {
                //拼接插入sql语句
                string sSql = "insert into student (name,age,sex,math,chinese,english) values (" +
                    "\"" + _oStudentInfo.m_sName + "\"" + "," +
                    _oStudentInfo.m_iAge + "," +
                    _oStudentInfo.m_iSex + "," +
                    _oStudentInfo.m_dbMath + "," +
                    _oStudentInfo.m_dbChinese + "," +
                    _oStudentInfo.m_dbEnglish +
                    ")";
                if (m_oMysql.MysqlInsert(sSql))
                {
                    bIsSucc = true;
                }
            }
            return bIsSucc;
        }
        /// <summary>
        /// 修改信息
        /// </summary>
        /// <param name="_oStudentInfo">摇修改的学生信息</param>
        /// <returns></returns>
        private bool ModifyInfo(CStudentInfo _oStudentInfo, int _iStuId)
        {
            bool bIsSucc = false;
            if (_oStudentInfo != null)
            {
                //拼接插入sql语句
                string sSql = "update student set math=" + _oStudentInfo.m_dbMath + ","
                    + "chinese=" + _oStudentInfo.m_dbChinese + ","
                    + "english=" + _oStudentInfo.m_dbEnglish
                    + " where id=" + _iStuId;
                if (m_oMysql.MysqlInsert(sSql))
                {
                    bIsSucc = true;
                }
            }
            return bIsSucc;
        }
        /// <summary>
        /// 判断学生id是否存在
        /// </summary>
        /// <param name="_iStuId">学生id</param>
        /// <returns>存在返回 true 数据存储到m_oStudent中</returns>
        private bool JuageStuIdExit(int _iStuId)
        {
            bool bIsSucc = false;
            List<CStudentInfo> lstStudentInfo = new List<CStudentInfo>();
            lstStudentInfo = m_oMysql.MysqlSelect("select * from student where id=" + _iStuId);
            if (lstStudentInfo.Count > 0)
            {
                m_oStudent = lstStudentInfo[0];
                bIsSucc = true;
            }
            return bIsSucc;
        }
        /// <summary>
        /// 根据id删除用户
        /// </summary>
        /// <param name="_iStuId">学生id</param>
        /// <returns></returns>
        private bool DelStuInfo(int _iStuId)
        {
            bool bIsSucc = false;
            //拼接插入sql语句
            string sSql = "delete from student where id = " + _iStuId;
            if (m_oMysql.MysqlInsert(sSql))
            {
                bIsSucc = true;
            }
            return bIsSucc;
        }
        #endregion

        #region [过程] 显示操作
        /// <summary>
        /// 显示学生信息
        /// </summary>
        private void ShowStudentInfo()
        {
            //调用查询数据库中所有用户信息的函数
            SelectAllInfo();
            //清空listview控件 （显示学生信息）
            this.lv_stuInfo.Clear();
            //显示新的数据
            if (m_lstStuInfo.Count > 0)
            {
                //添加标题,显示并设置居中
                this.lv_stuInfo.Columns.Add("Id");
                this.lv_stuInfo.Columns.Add("姓名", 100, HorizontalAlignment.Center);
                this.lv_stuInfo.Columns.Add("年龄", 100, HorizontalAlignment.Center);
                this.lv_stuInfo.Columns.Add("性别", 100, HorizontalAlignment.Center);
                this.lv_stuInfo.Columns.Add("数学成绩", 100, HorizontalAlignment.Center);
                this.lv_stuInfo.Columns.Add("语文成绩", 100, HorizontalAlignment.Center);
                this.lv_stuInfo.Columns.Add("英语成绩", 100, HorizontalAlignment.Center);
                //添加数据
                for (int i = 0; i < m_lstStuInfo.Count; i++)
                {
                    ListViewItem oLv = new ListViewItem();
                    oLv.SubItems.Clear();
                    oLv.SubItems[0].Text = m_lstStuInfo[i].m_iId.ToString();
                    //添加数据
                    oLv.SubItems.Add(m_lstStuInfo[i].m_sName.ToString());
                    oLv.SubItems.Add(m_lstStuInfo[i].m_iAge.ToString());
                    if (m_lstStuInfo[i].m_iSex == 1)
                    {
                        oLv.SubItems.Add("男");
                    }
                    else if (m_lstStuInfo[i].m_iSex == 2)
                    {
                        oLv.SubItems.Add("女");
                    }
                    oLv.SubItems.Add(m_lstStuInfo[i].m_dbMath.ToString());
                    oLv.SubItems.Add(m_lstStuInfo[i].m_dbChinese.ToString());
                    oLv.SubItems.Add(m_lstStuInfo[i].m_dbEnglish.ToString());
                    this.lv_stuInfo.Items.Add(oLv);
                }
            }
        }
        #endregion

        /// <summary>
        /// 添加用户按钮点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_add_Click(object sender, EventArgs e)
        {
            //用来插入的学生对象
            CStudentInfo oStudentInfo = new CStudentInfo();

            if (this.add_name.Text == null || this.add_name.Text == "")
            {
                MessageBox.Show("请输入必须字段姓名", "提示",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return;
            }
            //名称
            oStudentInfo.m_sName = this.add_name.Text;
            //年龄
            if (this.add_age.Text == null || this.add_age.Text == "")
            {
            }
            else
            {
                oStudentInfo.m_iAge = Convert.ToInt32(this.add_age.Text);
            }
            //数学成绩
            if (this.add_math.Text == null || this.add_math.Text == "")
            {
            }
            else
            {
                oStudentInfo.m_dbMath = Convert.ToDouble(this.add_math.Text);
            }
            //语文成绩
            if (this.add_chinese.Text == null || this.add_chinese.Text == "")
            {
            }
            else
            {
                oStudentInfo.m_dbEnglish = Convert.ToDouble(this.add_chinese.Text);
            }
            //英语成绩
            if (this.add_english.Text == null || this.add_english.Text == "")
            {
            }
            else
            {
                oStudentInfo.m_dbEnglish = Convert.ToDouble(this.add_english.Text);
            }
            //性别
            if (this.cb_nan.Checked)
            {
                oStudentInfo.m_iSex = 1;
            }
            else if (this.cb_nv.Checked)
            {
                oStudentInfo.m_iSex = 2;
            }
            //插入操作
            if (this.InsertInfo(oStudentInfo))
            {
                MessageBox.Show("插入学生 : " + oStudentInfo.m_sName + " 成功", "提示",
                    MessageBoxButtons.OKCancel);
                //清空输入框信息
                this.ClearEditInfo();
                //更新listview控件,显示用户数据
                this.ShowStudentInfo();
            }
            else
            {
                MessageBox.Show("插入学生 : " + oStudentInfo.m_sName + " 失败", "提示",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return;
            }
        }
        /// <summary>
        /// 修改按钮点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_modify_Click(object sender, EventArgs e)
        {
            //判断文本框是否修改
            if ((this.modify_math.Text == null || this.modify_math.Text == "") &&
                (this.modify_chinese.Text == null || this.modify_chinese.Text == "") &&
                (this.modify_english.Text == null || this.modify_english.Text == ""))
            {
                MessageBox.Show("清输入要修改的成绩", "提示",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return;
            }
            else
            {
                //判断用户选择了哪行
                if (lv_stuInfo.SelectedIndices != null && lv_stuInfo.SelectedIndices.Count > 0)
                {
                    //获取用户选中的学生id
                    ListView.SelectedIndexCollection oIndex = lv_stuInfo.SelectedIndices;
                    string iStuId = lv_stuInfo.Items[oIndex[0]].Text;
                    //判断该id是否存在
                    if (this.JuageStuIdExit(Convert.ToInt32(iStuId)))
                    {
                        if (this.modify_math.Text == null || this.modify_math.Text == "")
                        {
                        }
                        else
                        {
                            m_oStudent.m_dbMath = Convert.ToDouble(this.modify_math.Text);
                        }
                        if (this.modify_chinese.Text == null || this.modify_chinese.Text == "")
                        {
                        }
                        else
                        {
                            m_oStudent.m_dbChinese = Convert.ToDouble(this.modify_chinese.Text);
                        }
                        if (this.modify_english.Text == null || this.modify_english.Text == "")
                        {
                        }
                        else
                        {
                            m_oStudent.m_dbEnglish = Convert.ToDouble(this.modify_english.Text);
                        }
                        //进行修改信息
                        if (this.ModifyInfo(m_oStudent, Convert.ToInt32(iStuId)))
                        {
                            MessageBox.Show("用户修改成功", "提示");
                            //清屏
                            this.ClearEditInfo();
                            //更新显示
                            this.ShowStudentInfo();
                        }
                        else
                        {
                            MessageBox.Show("用户修改失败", "提示",
                                MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                            //清屏
                            this.ClearEditInfo();
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("学生id不存在", "提示",
                            MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                        //清屏
                        this.ClearEditInfo();
                        return;
                    }
                }
            }
        }
        /// <summary>
        /// 删除用户信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_delete_Click(object sender, EventArgs e)
        {
            //判断用户选择了哪行
            if (lv_stuInfo.SelectedIndices != null && lv_stuInfo.SelectedIndices.Count > 0)
            {
                //获取用户选中的学生id
                ListView.SelectedIndexCollection oIndex = lv_stuInfo.SelectedIndices;
                string iStuId = lv_stuInfo.Items[oIndex[0]].Text;
                //判断用户是否存在
                if (this.JuageStuIdExit(Convert.ToInt32(iStuId)))
                {
                    //删除学生
                    if (this.DelStuInfo(Convert.ToInt32(iStuId)))
                    {
                        MessageBox.Show("学生" + m_oStudent.m_sName + "删除成功", "提示");
                    }
                    else
                    {
                        MessageBox.Show("学生" + m_oStudent.m_sName + "删除失败", "提示",
                           MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    }
                    //更新显示
                    this.ShowStudentInfo();
                }
                else
                {
                    MessageBox.Show("学生id不存在", "提示",
                           MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    return;
                }
            }
        }

        #region 用来设置 用户只能勾选一个男或者女
        private void cb_nan_CheckedChanged(object sender, EventArgs e)
        {
            if (this.cb_nan.Checked)
            {
                this.cb_nv.Checked = false;
            }
        }

        private void cb_nv_CheckedChanged(object sender, EventArgs e)
        {
            if (this.cb_nv.Checked)
            {
                this.cb_nan.Checked = false;
            }
        }
        #endregion
    }
}
