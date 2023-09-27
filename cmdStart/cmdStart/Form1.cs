using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace cmdStart
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
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
            
            cmd.RedirectStandardOutput = true; // 출력을 StandardOutput 스트림에 사용
            cmd.RedirectStandardInput = true; // 입력을 StandardInput 스트림에서 읽음
            cmd.RedirectStandardError = true; // 오류 출력을 StandardError 스트림에서 사용

            process.EnableRaisingEvents = false; // 프로세스 종료 시 Exited 이벤트 발생 안함
            process.StartInfo = cmd;
            process.Start();
            //process.StandardInput.Write(this.tBoxCommand.Text + Environment.NewLine); //Environment.NewLine = 줄바꿈 > \r\n으로 대체 가능
            //process.StandardInput.Write("cd C:\\TEMP\r\n");
            //process.StandardInput.Write("genrsa -out private_key.pem 1024\r\n");
            //process.StandardInput.Write("openssl rsa -in private_key.pem -out public_key.pem - outform PEM - pubout\r\n");
            //process.StandardInput.Write("openssl pkeyutl -encrypt - inkey public_key.pem - pubin -in ./ test.txt -out testE.txt\r\n");
            //process.StandardInput.Write("dir\r\n");
            using(StreamWriter sw = process.StandardInput)
            {
                if (sw.BaseStream.CanWrite)
                {
                    sw.WriteLine("cd C:\\TEMP");
                    sw.WriteLine("openssl genrsa -out private_key.pem 1024");
                    sw.WriteLine("openssl rsa -in private_key.pem -out public_key.pem -outform PEM -pubout");
                    sw.WriteLine("openssl pkeyutl -encrypt -inkey public_key.pem -pubin -in test.txt -out testE.txt");
                    sw.WriteLine("dir");
                }
            }

            process.StandardInput.Close();

            string result = process.StandardOutput.ReadToEnd();
            StringBuilder sb = new StringBuilder();
            sb.Append("[Result Info]" + DateTime.Now + "\r\n");
            sb.Append(result);
            sb.Append("\r\n");

            tBoxRst.Text = sb.ToString();
            process.WaitForExit();
            process.Close();

            
        }

    }
}
