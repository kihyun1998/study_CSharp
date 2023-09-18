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
using System.Windows.Forms;

namespace ForStartingApp
{
    public partial class Form1 : Form
    {
        string _user = string.Empty;
        string _password = string.Empty;
        string _IP = string.Empty;

        string _puttyCommand = "C:\\Users\\User\\Desktop\\app && putty.exe -ssh ";
        string _filezillaCommand = "C:\\Program Files\\FileZilla FTP Client && filezilla.exe sftp://";
        string _mobaXtermCommand = "C:\\Program Files (x86)\\Mobatek\\MobaXterm && MobaXterm.exe -newtab \"sshpass -p ";

        public Form1()
        {
            InitializeComponent();
        }

        private void btnPutty_Click(object sender, EventArgs e)
        {
            _user = tBoxId.Text;
            _password = tBoxPw.Text;
            _IP = tBoxIp.Text;

            ProcessStartInfo cmd = new ProcessStartInfo();
            Process process = new Process();
            cmd.FileName = @"cmd";
            cmd.WindowStyle = ProcessWindowStyle.Hidden;
            cmd.CreateNoWindow = true; // 새 창 띄우지 않음
            cmd.UseShellExecute = false; // 운영체제 쉘 사용안함

            /*
            StandardOutput : 애플리케이션의 텍스트 출력 스트림
            StandardInput : 애플리케이션의 입력 스트림
            StandardError : 애플리케이션의 오류 출력 스트림
            */

            cmd.RedirectStandardInput = true; // 입력을 StandardInput 스트림에서 읽음
            cmd.RedirectStandardError = true; // 오류 출력을 StandardError 스트림에서 사용

            process.EnableRaisingEvents = false; // 프로세스 종료 시 Exited 이벤트 발생 안함
            process.StartInfo = cmd;
            process.Start();
            process.StandardInput.Write(string.Format("cd {0}{1}@{2} 22 -pw {3}\r\n",_puttyCommand,_user,_IP,_password));
            process.StandardInput.Close();

            process.WaitForExit();
            process.Close();
        }

        private void btnFilezilla_Click(object sender, EventArgs e)
        {
            _user = tBoxId.Text;
            _password = tBoxPw.Text;
            _IP = tBoxIp.Text;

            ProcessStartInfo cmd = new ProcessStartInfo();
            Process process = new Process();
            cmd.FileName = @"cmd";
            cmd.WindowStyle = ProcessWindowStyle.Hidden;
            cmd.CreateNoWindow = true; // 새 창 띄우지 않음
            cmd.UseShellExecute = false; // 운영체제 쉘 사용안함

            cmd.RedirectStandardInput = true; // 입력을 StandardInput 스트림에서 읽음
            cmd.RedirectStandardError = true; // 오류 출력을 StandardError 스트림에서 사용

            process.EnableRaisingEvents = false; // 프로세스 종료 시 Exited 이벤트 발생 안함
            process.StartInfo = cmd;
            process.Start();
            process.StandardInput.Write(string.Format("cd {0}{1}:{2}@{3}\r\n", _filezillaCommand, _user, _password, _IP));
            process.StandardInput.Close();

            process.WaitForExit();
            process.Close();
        }

        private void btnMobaXterm_Click(object sender, EventArgs e)
        {
            _user = tBoxId.Text;
            _password = tBoxPw.Text;
            _IP = tBoxIp.Text;

            ProcessStartInfo cmd = new ProcessStartInfo();
            Process process = new Process();
            cmd.FileName = @"cmd";
            cmd.WindowStyle = ProcessWindowStyle.Hidden;
            cmd.CreateNoWindow = true; // 새 창 띄우지 않음
            cmd.UseShellExecute = false; // 운영체제 쉘 사용안함

            cmd.RedirectStandardInput = true; // 입력을 StandardInput 스트림에서 읽음
            cmd.RedirectStandardError = true; // 오류 출력을 StandardError 스트림에서 사용

            process.EnableRaisingEvents = false; // 프로세스 종료 시 Exited 이벤트 발생 안함
            process.StartInfo = cmd;
            process.Start();
            process.StandardInput.Write(string.Format("cd {0}{1} ssh -o StrictHostKeyChecking=no {2}@{3}\"\r\n", _mobaXtermCommand,_password,_user,_IP));
            process.StandardInput.Close();

            process.WaitForExit();
            process.Close();
        }

        private void btnPuttyPath_Click_Click(object sender, EventArgs e)
        {
            string path = getFilePath();
            tBoxPuttyPath.Text = path;
        }

        private void btnZillaPath_Click(object sender, EventArgs e)
        {
            string path = getFilePath();
            tBoxZillaPath.Text = path;
        }

        private void btnMobaxPath_Click(object sender, EventArgs e)
        {
            string path = getFilePath();
            tBoxMobaxPath.Text = path;
        }
        private string getFilePath()
        {
            string filePath = string.Empty;

            using (OpenFileDialog fd = new OpenFileDialog())
            {
                fd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                fd.Filter = "실행 파일 (*.exe)|*.exe|모든 파일(*.*)|*.*";
                fd.FilterIndex = 1;

                if (fd.ShowDialog() == DialogResult.OK)
                {
                    filePath = fd.FileName;
                }
            }

            return filePath;
        }
    }
}
