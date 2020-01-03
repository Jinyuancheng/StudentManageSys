using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient; //使用mysql库
using StudentManageSys.Public;

namespace StudentManageSys.MySql
{
    public class CMySql
    {

        private MySqlConnection m_oMySqlConn; //mysql数据库链接对象
        private MySqlDataReader m_oSelectResult = null; //查询结果读取器

        /// <summary>
        /// 构造函数
        /// </summary>
        public CMySql()
        {
            
        }
        /// <summary>
        /// 建立数据库链接
        /// </summary>
        /// <param name="_sServer">mysql服务器的ip地址</param>
        /// <param name="_sUser">mysql服务器的登录用户名</param>
        /// <param name="_sPass">mysql服务器的登录密码</param>
        /// <param name="_sDatabaseName">使用的mysql服务器中的哪个数据库名称</param>
        /// <returns>成功返回true 失败返回false</returns>
        public bool MysqlConnect(string _sServer, string _sUser,
            string _sPass, string _sDatabaseName)
        {
            bool bIsSucc = false;
            try
            {
                //登录mysql服务器使用的信息
                string sLoginInfo = "server=" + _sServer + ";User Id=" + _sUser +
                    ";password=" + _sPass + ";Database=" + _sDatabaseName;
                //初始化mysql服务器的链接
                m_oMySqlConn = new MySqlConnection(sLoginInfo);
                //开启mysql链接
                m_oMySqlConn.Open();
                bIsSucc = true;
            }
            catch (Exception ex)
            {
                bIsSucc = false;
            }
            return bIsSucc;
        }
        /// <summary>
        /// mysql插入操作
        /// </summary>
        /// <param name="_sSql">sql语句</param>
        /// <returns>true插入成功 false 插入失败</returns>
        public bool MysqlInsert(string _sSql)
        {
            bool bIsSucc = false;
            MySqlCommand oMycmd = new MySqlCommand(_sSql, m_oMySqlConn);
            if (oMycmd.ExecuteNonQuery() <= 0)
            {
                MessageBox.Show("Opt Mysql Error!", "提示",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
            else
            {
                bIsSucc = true;
            }
            return bIsSucc;
        }
        /// <summary>
        /// mysql查询
        /// </summary>
        /// <param name="_sSql">sql语句</param>
        public List<CStudentInfo> MysqlSelect(string _sSql)
        {
            List<CStudentInfo> lstStudentInfo = new List<CStudentInfo>();
            MySqlCommand oMycmd = new MySqlCommand(_sSql, m_oMySqlConn);
            m_oSelectResult = oMycmd.ExecuteReader();
            while(m_oSelectResult.Read())
            {
                CStudentInfo oStu = new CStudentInfo();
                oStu.m_iId = Convert.ToInt32(m_oSelectResult[0].ToString());
                oStu.m_sName = m_oSelectResult[1].ToString();
                oStu.m_iAge = Convert.ToInt32(m_oSelectResult[2].ToString());
                oStu.m_iSex = Convert.ToInt32(m_oSelectResult[3].ToString());
                oStu.m_dbMath = Convert.ToDouble(m_oSelectResult[4].ToString());
                oStu.m_dbChinese = Convert.ToDouble(m_oSelectResult[5].ToString());
                oStu.m_dbEnglish = Convert.ToDouble(m_oSelectResult[6].ToString());
                lstStudentInfo.Add(oStu);
            }
            m_oSelectResult.Close();
            return lstStudentInfo;
        }
        /// <summary>
        /// 释放内存
        /// </summary>
        public void MysqlDestory()
        {
            m_oMySqlConn.Close();
        }
    }
}
