using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Windows.Forms;

namespace ForStartingApp
{
    class HandleXML
    {
        public static string _xmlPath = @"C:\TEMP\Path.xml";

        public static void Modify(SavePathXML savePathXML, string type)
        {
            XmlDocument xdoc = new XmlDocument();
            xdoc.Load(_xmlPath);

            if (type == "PUTTY")
            {
                XmlNodeList nodes = xdoc.SelectNodes(string.Format("/PATH/{0}", type));
                foreach (XmlNode datas in nodes)
                {
                    datas.SelectSingleNode("FullPath").InnerText = savePathXML._FullPath;
                    datas.SelectSingleNode("FileName").InnerText = savePathXML._FileName;
                    datas.SelectSingleNode("ExePath").InnerText = savePathXML._ExePath;
                }
            }
            else if (type == "FILEZILLA")
            {
                XmlNodeList nodes = xdoc.SelectNodes(string.Format("/PATH/{0}", type));
                foreach (XmlNode datas in nodes)
                {
                    datas.SelectSingleNode("FullPath").InnerText = savePathXML._FullPath;
                    datas.SelectSingleNode("FileName").InnerText = savePathXML._FileName;
                    datas.SelectSingleNode("ExePath").InnerText = savePathXML._ExePath;
                }
            }
            else if (type == "MOBAXTERM")
            {
                XmlNodeList nodes = xdoc.SelectNodes(string.Format("/PATH/{0}", type));
                foreach (XmlNode datas in nodes)
                {
                    datas.SelectSingleNode("FullPath").InnerText = savePathXML._FullPath;
                    datas.SelectSingleNode("FileName").InnerText = savePathXML._FileName;
                    datas.SelectSingleNode("ExePath").InnerText = savePathXML._ExePath;
                }
            }
            else
            {
                MessageBox.Show("알수없는 에러 in Func XMLModify");
            }
            xdoc.Save(_xmlPath);

        }


        public static void Save(SavePathXML savePathXML)
        {
            XmlDocument xdoc = new XmlDocument();

            XmlNode root = xdoc.CreateElement("PATH");
            xdoc.AppendChild(root);


            XmlNode xPutty = xdoc.CreateElement("PUTTY");

            XmlNode xPutty_FullPath = xdoc.CreateElement("FullPath");
            xPutty_FullPath.InnerText = savePathXML._FullPath;
            xPutty.AppendChild(xPutty_FullPath);

            XmlNode xPutty_FileName = xdoc.CreateElement("FileName");
            xPutty_FileName.InnerText = savePathXML._FileName;
            xPutty.AppendChild(xPutty_FileName);

            XmlNode xPutty_ExePath = xdoc.CreateElement("ExePath");
            xPutty_ExePath.InnerText = savePathXML._ExePath;
            xPutty.AppendChild(xPutty_ExePath);


            XmlNode xFileZilla = xdoc.CreateElement("FILEZILLA");

            XmlNode xFileZilla_FullPath = xdoc.CreateElement("FullPath");
            xFileZilla_FullPath.InnerText = savePathXML._FullPath;
            xFileZilla.AppendChild(xFileZilla_FullPath);

            XmlNode xFileZilla_FileName = xdoc.CreateElement("FileName");
            xFileZilla_FileName.InnerText = savePathXML._FileName;
            xFileZilla.AppendChild(xFileZilla_FileName);

            XmlNode xFileZilla_ExePath = xdoc.CreateElement("ExePath");
            xFileZilla_ExePath.InnerText = savePathXML._ExePath;
            xFileZilla.AppendChild(xFileZilla_ExePath);


            XmlNode xMobaXterm = xdoc.CreateElement("MOBAXTERM");

            XmlNode xMobaXterm_FullPath = xdoc.CreateElement("FullPath");
            xMobaXterm_FullPath.InnerText = savePathXML._FullPath;
            xMobaXterm.AppendChild(xMobaXterm_FullPath);

            XmlNode xMobaXterm_FileName = xdoc.CreateElement("FileName");
            xMobaXterm_FileName.InnerText = savePathXML._FileName;
            xMobaXterm.AppendChild(xMobaXterm_FileName);

            XmlNode xMobaXterm_ExePath = xdoc.CreateElement("ExePath");
            xMobaXterm_ExePath.InnerText = savePathXML._ExePath;
            xMobaXterm.AppendChild(xMobaXterm_ExePath);


            root.AppendChild(xPutty);
            root.AppendChild(xFileZilla);
            root.AppendChild(xMobaXterm);
            xdoc.Save(_xmlPath);
        }

        public static void Load()
        {
            XmlDocument xdoc = new XmlDocument();

            xdoc.Load(_xmlPath);

            XmlNodeList nPuttys = xdoc.SelectNodes("/PATH/PUTTY");

            foreach (XmlNode data in nPuttys)
            {
                Form1.form1.tBoxPuttyPath.Text = data.SelectSingleNode("FullPath").InnerText;
            }

            XmlNodeList nFileZillas = xdoc.SelectNodes("/PATH/FILEZILLA");

            foreach (XmlNode data in nFileZillas)
            {

                Form1.form1.tBoxFileZillaPath.Text = data.SelectSingleNode("FullPath").InnerText;
            }

            XmlNodeList nMobaXterms = xdoc.SelectNodes("/PATH/MOBAXTERM");

            foreach (XmlNode data in nMobaXterms)
            {
                Form1.form1.tBoxMobaXtermPath.Text = data.SelectSingleNode("FullPath").InnerText;
            }
        }

        public static string GetPath(string type)
        {
            XmlDocument xdoc = new XmlDocument();
            xdoc.Load(_xmlPath);

            if (type == "PUTTY")
            {
                XmlNodeList nodes = xdoc.SelectNodes(string.Format("/PATH/{0}", type));
                foreach (XmlNode datas in nodes)
                {
                    return datas.SelectSingleNode("ExePath").InnerText;
                }
            }
            else if (type == "FILEZILLA")
            {
                XmlNodeList nodes = xdoc.SelectNodes(string.Format("/PATH/{0}", type));
                foreach (XmlNode datas in nodes)
                {
                    return datas.SelectSingleNode("ExePath").InnerText;
                }
            }
            else if (type == "MOBAXTERM")
            {
                XmlNodeList nodes = xdoc.SelectNodes(string.Format("/PATH/{0}", type));
                foreach (XmlNode datas in nodes)
                {
                    return datas.SelectSingleNode("ExePath").InnerText;
                }
            }
            else
            {
                MessageBox.Show("알수없는 에러 in Func GetPath");
            }
            return "";
        }

        public static string GetName(string type)
        {
            XmlDocument xdoc = new XmlDocument();
            xdoc.Load(_xmlPath);

            if (type == "PUTTY")
            {
                XmlNodeList nodes = xdoc.SelectNodes(string.Format("/PATH/{0}", type));
                foreach (XmlNode datas in nodes)
                {
                    return datas.SelectSingleNode("FileName").InnerText;
                }
            }
            else if (type == "FILEZILLA")
            {
                XmlNodeList nodes = xdoc.SelectNodes(string.Format("/PATH/{0}", type));
                foreach (XmlNode datas in nodes)
                {
                    return datas.SelectSingleNode("FileName").InnerText;
                }
            }
            else if (type == "MOBAXTERM")
            {
                XmlNodeList nodes = xdoc.SelectNodes(string.Format("/PATH/{0}", type));
                foreach (XmlNode datas in nodes)
                {
                    return datas.SelectSingleNode("FileName").InnerText;
                }
            }
            else
            {
                MessageBox.Show("알수없는 에러 in Func GetName");
            }
            return "";
        }
    }
}
