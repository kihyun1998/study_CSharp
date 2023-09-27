using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Windows.Forms;

namespace ForStartingApp
{
    
    class UseUserState
    {
        public static string _Path = @"C:\TEMP\UserState.xml";

        // Modify와 같은 역할도 한다.
        public static void Save(UserStateXML userStateXML)
        {
            XmlDocument xdoc = new XmlDocument();

            XmlNode root = xdoc.CreateElement("USER");
            xdoc.AppendChild(root);

            XmlNode xName = xdoc.CreateElement("NAME");
            xName.InnerText = userStateXML._UserName;
            root.AppendChild(xName);

            XmlNode xIP = xdoc.CreateElement("IP");
            xIP.InnerText = userStateXML._IPAddress;
            root.AppendChild(xIP);

            xdoc.Save(_Path);
        }

        public static void Load()
        {
            XmlDocument xdoc = new XmlDocument();

            xdoc.Load(_Path);

            XmlNodeList nodes = xdoc.SelectNodes("/USER");

            foreach (XmlNode data in nodes)
            {
                Form1.form1.tBoxUserName.Text = data.SelectSingleNode("NAME").InnerText;
                Form1.form1.tBoxIp.Text = data.SelectSingleNode("IP").InnerText;
            }
        }

        public static bool IsRegist()
        {
            XmlDocument xdoc = new XmlDocument();

            xdoc.Load(_Path);

            XmlNodeList nodes = xdoc.SelectNodes("/USER");

            bool regi = true;

            foreach (XmlNode data in nodes)
            {
                if (string.Equals(data.SelectSingleNode("NAME").InnerText, "") || string.Equals(data.SelectSingleNode("IP").InnerText, ""))
                {
                    regi = false;
                }
            }

            return regi;
        }

    }
}
