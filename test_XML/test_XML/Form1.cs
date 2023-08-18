using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Reflection;
using System.IO;

namespace test_XML
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                School _school = new School();
                _school.SCHOOL_NAME = "학교이름";
                _school.SCHOOL_ADDRESS = "학교주소";
                _school.SCHOOL_STUDENT_COUNT = "학생수";

                Student _student = new Student();
                _student.STUDENT_NAME = "학생이름";
                _student.STUDENT_GRADE = "학생학년";

                DataTable t1 = new DataTable("School");
                t1.Columns.Add(_school.SCHOOL_NAME);
                t1.Columns.Add(_school.SCHOOL_ADDRESS);
                t1.Columns.Add(_school.SCHOOL_STUDENT_COUNT);

                DataTable t2 = new DataTable("Student");
                t2.Columns.Add(_student.STUDENT_NAME);
                t2.Columns.Add(_student.STUDENT_GRADE);

                DataSet ds = new DataSet("Test");
                ds.Tables.Add(t1);
                ds.Tables.Add(t2);

                Make_XMLString(t1, t2);
            }catch(Exception ex)
            {
                MessageBox.Show(string.Format("실패 {0}", ex.ToString()));
            }
        }

        private string Make_XMLString(DataTable dtSchool, DataTable dtStudent)
        {
            XmlDocument Doc = Make_XMLDoc(dtSchool, dtStudent);
            string cPath = Environment.CurrentDirectory + "\\test";


            int retryCnt = 5;
            string xmlFileNmae = "School.xml";
            DirectoryInfo di = new DirectoryInfo(cPath);

            if (!di.Exists)
            {
                di.Create();
            }
            Doc.Save(cPath + xmlFileNmae);

            return xmlFileNmae;
        }

        private XmlDocument Make_XMLDoc(DataTable dtSchool, DataTable dtStudent)
        {
            XmlDocument Doc = new XmlDocument();
            XmlElement inventory = Doc.CreateElement("SCHOOL");
            XmlElement School_Info_Data = School_Info(Doc, dtSchool);

            XmlElement Student_Info_Data = Student_Info(Doc, dtStudent);

            inventory.AppendChild(School_Info_Data);
            inventory.AppendChild(Student_Info_Data);
            Doc.AppendChild(inventory);

            return Doc;
        }

        private XmlElement School_Info(XmlDocument doc, DataTable dtSchool)
        {
            XmlElement elmSchoolInfo = doc.CreateElement("School-Info");
           
            School _school = new School();
            List<PropertyInfo> pList = new List<PropertyInfo>();

            pList.AddRange(_school.GetType().GetProperties());

            for(int i=0; i<pList.Count(); i++)
            {
                XmlElement elmTmp = doc.CreateElement(pList[i].Name);
                string[] colNames = dtSchool.Columns.Cast<DataColumn>()
                    .Select(x => x.ColumnName)
                    .ToArray();

                elmTmp.InnerText = colNames[i].ToString();
                elmSchoolInfo.AppendChild(elmTmp);
            }
            return elmSchoolInfo;
        }

        private XmlElement Student_Info(XmlDocument doc, DataTable dtStudent)
        {
            XmlElement elmStudentInfo = doc.CreateElement("Student-Info");
            Student _student = new Student();

            List<PropertyInfo> pList = new List<PropertyInfo>();
            pList.AddRange(_student.GetType().GetProperties());

            XmlElement elmStudent = doc.CreateElement("Student");
            for(int i= 0; i < pList.Count(); i++)
            {
                XmlElement emlTmp = doc.CreateElement(pList[i].Name);

                string[] colNames = dtStudent.Columns.Cast<DataColumn>()
                    .Select(x => x.ColumnName)
                    .ToArray();

                emlTmp.InnerText = colNames[i].ToString();
                elmStudent.AppendChild(emlTmp);
            }
            elmStudentInfo.AppendChild(elmStudent);

            return elmStudentInfo;
        }
    }
}
