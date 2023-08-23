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
                _school.SCHOOL_NAME = tBox1.Text;
                _school.SCHOOL_ADDRESS = tBox2.Text;
                _school.SCHOOL_STUDENT_COUNT = tBox3.Text;

                DataTable t1 = new DataTable("School");
                t1.Columns.Add(_school.SCHOOL_NAME);
                t1.Columns.Add(_school.SCHOOL_ADDRESS);
                t1.Columns.Add(_school.SCHOOL_STUDENT_COUNT);


                DataSet ds = new DataSet("Test");
                ds.Tables.Add(t1);


                Make_XMLString(t1);
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("실패 {0}", ex.ToString()));
            }
        }

        private string Make_XMLString(DataTable dtSchool)
        {
            XmlDocument Doc = Make_XMLDoc(dtSchool);
            string cPath = Environment.CurrentDirectory + "\\test";


            string xmlFileNmae = "\\School.xml";
            DirectoryInfo di = new DirectoryInfo(cPath);

            if (!di.Exists)
            {
                di.Create();
            }
            Doc.Save(cPath + xmlFileNmae);

            return xmlFileNmae;
        }

        private XmlDocument Make_XMLDoc(DataTable dtSchool)
        {
            XmlDocument Doc = new XmlDocument();
            XmlElement inventory = Doc.CreateElement("SCHOOL");
            XmlElement School_Info_Data = School_Info(Doc, dtSchool);


            inventory.AppendChild(School_Info_Data);
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




        private void btnLoad_Click(object sender, EventArgs e)
        {
            XmlDocument xdoc = new XmlDocument();
            string cPath = Environment.CurrentDirectory + "\\test\\School.xml";
            xdoc.Load(cPath);

            XmlNodeList nodes = xdoc.SelectNodes("/SCHOOL/School-Info");

            foreach (XmlNode type in nodes)
            {

                tBoxRst1.AppendText(type.SelectSingleNode("SCHOOL_NAME").InnerText);

            }
        }
    }
}
