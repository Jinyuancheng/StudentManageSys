using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManageSys.Public
{
    /// <summary>
    /// 学生信息
    /// </summary>
    public class CStudentInfo
    {
        public int      m_iId;      //数据库中对应的id
        public string   m_sName;    //名字
        public int      m_iAge;     //年龄
        public int      m_iSex;     //性别 1 男 2 女
        public double   m_dbMath;    //数学成绩
        public double   m_dbChinese; //语文成绩
        public double   m_dbEnglish; //英语成绩
    }

}
