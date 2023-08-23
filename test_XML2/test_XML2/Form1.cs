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

namespace test_XML2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            XmlDocument xdoc = new XmlDocument();

            XmlNode root = xdoc.CreateElement("ROOT");
            xdoc.AppendChild(root);

            XmlNode xmlData = xdoc.CreateElement("DATA");
            

            XmlNode xmlMethod = xdoc.CreateElement("Method");
            xmlMethod.InnerText = textBox1.Text;
            xmlData.AppendChild(xmlMethod);

            XmlNode xmlURL= xdoc.CreateElement("URL");
            xmlURL.InnerText = textBox2.Text;
            xmlData.AppendChild(xmlURL);

            XmlNode xmlCookie = xdoc.CreateElement("Cookie");
            xmlCookie.InnerText = textBox3.Text;
            xmlData.AppendChild(xmlCookie);

            XmlNode xmlMsg = xdoc.CreateElement("Msg");
            xmlMsg.InnerText = textBox4.Text;
            xmlData.AppendChild(xmlMsg);



            root.AppendChild(xmlData);

            string sPath = Environment.CurrentDirectory + "\\test.xml";

            xdoc.Save(sPath);

        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            XmlDocument xdoc = new XmlDocument();
            string sPath = Environment.CurrentDirectory + "\\test.xml";

            xdoc.Load(sPath);

            XmlNodeList nodes = xdoc.SelectNodes("/ROOT/DATA");

            foreach (XmlNode data in nodes)
            {
                string sMethod = data.SelectSingleNode("Method").InnerText;
                string sURL = data.SelectSingleNode("URL").InnerText;
                string sCookie = data.SelectSingleNode("Cookie").InnerText;
                string sMsg = data.SelectSingleNode("Msg").InnerText;

                textBox5.Text = sMethod;
                textBox6.Text = sURL;
                textBox7.Text = sCookie;
                textBox8.Text = sMsg;
            }

            
        }
    }
}
