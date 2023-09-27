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
using System.Threading;

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
            
            if (File.Exists(UseApplication._Path))
            {
                UseApplication.Load();
            }
            else
            {
                ApplicationXML appX = new ApplicationXML();
                UseApplication.Save(appX);
            }

            if (File.Exists(UseUserState._Path))
            {
                if (UseUserState.IsRegist())
                {
                    UseUserState.Load();
                    pBoxGreen.Visible = true;
                    pBoxRed.Visible = false;
                }
                else
                {
                    pBoxGreen.Visible = false;
                    pBoxRed.Visible = true;
                }
            }
            else
            {
                pBoxGreen.Visible = false;
                pBoxRed.Visible = true;
            }
            
        }

        private void btnPutty_Click(object sender, EventArgs e)
        {
            string type = "PUTTY";

            _user = tBoxUserName.Text;

            _IP = tBoxIp.Text;
            _path = UseApplication.GetPath(type);
            _name = UseApplication.GetName(type);


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
                //process.StandardInput.Write(string.Format("cd {0} && {1} -ssh {2}@{3} 22 -pw {4}\r\n", _path, _name, _user, _IP, _password));

                //process.StandardInput.WriteLine(string.Format("openssl pkeyutl -decrypt -inkey {0} -in {1} -out {2} && cd {3} && {4} -ssh {5}@{6} 22 -pwfile {7} && del {8}",
                //    UsePassword._PrivPath, UsePassword._ENCPath, UsePassword._Path, _path, _name, _user, _IP,UsePassword._Path, UsePassword._Path));
                process.StandardInput.WriteLine(string.Format("openssl pkeyutl -decrypt -inkey {0} -in {1} -out {2}",
                        UsePassword._PrivPath, UsePassword._ENCPath, UsePassword._Path));
                process.StandardInput.WriteLine(string.Format("cd {0} && {1} -ssh {2}@{3} 22 -pwfile {4}", _path, _name, _user, _IP, UsePassword._Path));
                Thread.Sleep(1000);
                process.StandardInput.WriteLine(string.Format("del {0}", UsePassword._Path));
                process.StandardInput.Close();

                process.WaitForExit();
                process.Close();
            }
        }

        private void btnFilezilla_Click(object sender, EventArgs e)
        {
            string type = "FILEZILLA";

            _user = tBoxUserName.Text;
            _password = "";
            _IP = tBoxIp.Text;
            _path = UseApplication.GetPath(type);
            _name = UseApplication.GetName(type);

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

            _user = tBoxUserName.Text;
            _password = "";
            _IP = tBoxIp.Text;
            _path = UseApplication.GetPath(type);
            _name = UseApplication.GetName(type);

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
            ApplicationXML spx = new ApplicationXML();
            spx._FullPath = paths[0];
            spx._FileName = paths[1];
            spx._ExePath = paths[2];

            UseApplication.Modify(spx, type);

            tBoxPuttyPath.Text = paths[0];
        }

        private void btnFileZillaPath_Click(object sender, EventArgs e)
        {
            string type = "FILEZILLA";
            List<string> paths = getFilePaths();
            ApplicationXML spx = new ApplicationXML();
            spx._FullPath = paths[0];
            spx._FileName = paths[1];
            spx._ExePath = paths[2];

            UseApplication.Modify(spx, type);

            tBoxFileZillaPath.Text = paths[0];
        }

        private void btnMobaXtermPath_Click(object sender, EventArgs e)
        {
            string type = "MOBAXTERM";
            List<string> paths = getFilePaths();
            ApplicationXML appX = new ApplicationXML();
            appX._FullPath = paths[0];
            appX._FileName = paths[1];
            appX._ExePath = paths[2];

            UseApplication.Modify(appX, type);

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

        private void btnRegist_Click(object sender, EventArgs e)
        {
            UserStateXML usX = new UserStateXML();
            usX._UserName = tBoxUserName.Text;
            usX._IPAddress = tBoxIp.Text;

            


            UseUserState.Save(usX);
            if (UseUserState.IsRegist())
            {
                UseUserState.Load();
                pBoxGreen.Visible = true;
                pBoxRed.Visible = false;
                MessageBox.Show("등록되었습니다 !");
            }
            else
            {
                pBoxGreen.Visible = false;
                pBoxRed.Visible = true;
                MessageBox.Show("접속 아이디 또는 아이피를 입력해주세요.");
            }
        }

        private void btnPassRegi_Click(object sender, EventArgs e)
        {
            InputBox inputBox = new InputBox();
            inputBox.ShowDialog();

            
            PassworldTXT passT = new PassworldTXT();
            passT._Passworld = inputBox.Password;

            UsePassword.Save(passT);
        }
    }
}
