using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;
using System.Xml;
using System.Windows.Forms;

namespace ForStartingApp
{
    public partial class Form1 : Form
    {
        string _user = string.Empty;
        string _password = string.Empty;
        string _IP = string.Empty;
        string _path = string.Empty;
        string _name = string.Empty;
   
        
        

        public static Form1 form1;
        public Form1()
        {
            InitializeComponent();
            form1 = this;
            if (File.Exists(HandleXML._xmlPath))
            {
                HandleXML.Load();
            }
            else
            {
                SavePathXML spx = new SavePathXML();
                HandleXML.Save(spx);
            }
            
        }

        private void btnPutty_Click(object sender, EventArgs e)
        {
            string type = "PUTTY";

            _user = tBoxId.Text;
            _password = tBoxPw.Text;
            _IP = tBoxIp.Text;
            _path = HandleXML.GetPath(type);
            _name = HandleXML.GetName(type);


            if (_path == string.Empty)
            {
                MessageBox.Show("Error : 실행 파일 경로 설정이 되지 않았습니다.");
            }
            else
            {

                ProcessStartInfo cmd = new ProcessStartInfo();
                Process process = new Process();
                cmd.FileName = @"cmd";
                cmd.WindowStyle = ProcessWindowStyle.Hidden;
                cmd.CreateNoWindow = true;
                cmd.UseShellExecute = false;

                cmd.RedirectStandardInput = true;
                cmd.RedirectStandardError = true;

                process.EnableRaisingEvents = false;
                process.StartInfo = cmd;
                process.Start();
                process.StandardInput.Write(string.Format("cd {0} && {1} -ssh {2}@{3} 22 -pw {4}\r\n", _path, _name, _user, _IP, _password));
                process.StandardInput.Close();

                process.WaitForExit();
                process.Close();
            }
        }

        private void btnFilezilla_Click(object sender, EventArgs e)
        {
            string type = "FILEZILLA";

            _user = tBoxId.Text;
            _password = tBoxPw.Text;
            _IP = tBoxIp.Text;
            _path = HandleXML.GetPath(type);
            _name = HandleXML.GetName(type);

            if (_path == string.Empty)
            {
                MessageBox.Show("Error : 실행 파일 경로 설정이 되지 않았습니다.");
            }
            else
            {
                ProcessStartInfo cmd = new ProcessStartInfo();
                Process process = new Process();
                cmd.FileName = @"cmd";
                cmd.WindowStyle = ProcessWindowStyle.Hidden;
                cmd.CreateNoWindow = true; 
                cmd.UseShellExecute = false;

                cmd.RedirectStandardInput = true;
                cmd.RedirectStandardError = true;

                process.EnableRaisingEvents = false;
                process.StartInfo = cmd;
                process.Start();
                process.StandardInput.Write(string.Format("cd {0} && {1} sftp://{2}:{3}@{4}\r\n", _path,_name, _user, _password, _IP));
                process.StandardInput.Close();

                process.WaitForExit();
                process.Close();
            }
        }

        private void btnMobaXterm_Click(object sender, EventArgs e)
        {
            string type = "MOBAXTERM";

            _user = tBoxId.Text;
            _password = tBoxPw.Text;
            _IP = tBoxIp.Text;
            _path = HandleXML.GetPath(type);
            _name = HandleXML.GetName(type);

            if (_path == string.Empty)
            {
                MessageBox.Show("Error : 실행 파일 경로 설정이 되지 않았습니다.");
            }
            else
            {
                ProcessStartInfo cmd = new ProcessStartInfo();
                Process process = new Process();
                cmd.FileName = @"cmd";
                cmd.WindowStyle = ProcessWindowStyle.Hidden;
                cmd.CreateNoWindow = true;
                cmd.UseShellExecute = false;

                cmd.RedirectStandardInput = true;
                cmd.RedirectStandardError = true;

                process.EnableRaisingEvents = false;
                process.StartInfo = cmd;
                process.Start();
                //string _mobaXtermCommand = "C:\\Program Files (x86)\\Mobatek\\MobaXterm && MobaXterm.exe -newtab \"sshpass -p ";
                process.StandardInput.Write(string.Format("cd {0} && {1} -newtab \" sshpass -p {2} ssh -o StrictHostKeyChecking=no {3}@{4}\" \r\n", _path, _name, _password, _user, _IP));
                process.StandardInput.Close();

                process.WaitForExit();
                process.Close();
            }
        }

        private void btnPuttyPath_Click_Click(object sender, EventArgs e)
        {
            string type = "PUTTY";
            List<string> paths = getFilePaths();
            SavePathXML spx = new SavePathXML();
            spx._FullPath = paths[0];
            spx._FileName = paths[1];
            spx._ExePath = paths[2];

            HandleXML.Modify(spx, type);

            tBoxPuttyPath.Text = paths[0];
        }

        private void btnFileZillaPath_Click(object sender, EventArgs e)
        {
            string type = "FILEZILLA";
            List<string> paths = getFilePaths();
            SavePathXML spx = new SavePathXML();
            spx._FullPath = paths[0];
            spx._FileName = paths[1];
            spx._ExePath = paths[2];

            HandleXML.Modify(spx, type);

            tBoxFileZillaPath.Text = paths[0];
        }

        private void btnMobaXtermPath_Click(object sender, EventArgs e)
        {
            string type = "MOBAXTERM";
            List<string> paths = getFilePaths();
            SavePathXML spx = new SavePathXML();
            spx._FullPath = paths[0];
            spx._FileName = paths[1];
            spx._ExePath = paths[2];

            HandleXML.Modify(spx, type);

            tBoxMobaXtermPath.Text = paths[0];
        }





        /////////////////
        /// paths[0] = 전체 경로
        /// paths[1] = 파일 이름
        /// paths[2] = 실행 경로
        private List<string> getFilePaths()
        {
            List<string> paths = new List<string> { }; 

            string fullPath = string.Empty;
            string fileName = string.Empty;
            string exePath = string.Empty;

            using (OpenFileDialog fd = new OpenFileDialog())
            {
                fd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                fd.Filter = "실행 파일 (*.exe)|*.exe|모든 파일(*.*)|*.*";
                fd.FilterIndex = 1;

                if (fd.ShowDialog() == DialogResult.OK)
                {
                    fullPath = fd.FileName;
                    fileName = fd.SafeFileName;
                    exePath = fullPath.Substring(0, (fullPath.Length - fileName.Length));
                }
                paths.Add(fullPath);
                paths.Add(fileName);
                paths.Add(exePath);
            }

            return paths;
        }
    }
}
