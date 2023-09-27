using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;

namespace ForStartingApp
{
    class UsePassword
    {
        public static string _PrivPath = @"C:\priv\private_key.pem";
        public static string _PubPath = @"C:\pub\public_key.pem";
        public static string _Path = @"C:\TEMP\Password.txt";
        public static string _ENCPath = @"C:\TEMP\ENC_Password.txt";

        // Modify와 같은 역할도 한다.
        public static void Save(PassworldTXT passworldTXT)
        {
            

            File.WriteAllText(_Path, passworldTXT._Passworld, Encoding.Default);

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
            //process.StandardInput.WriteLine(string.Format("cd {0} && openssl genrsa -out {1} 1024 && openssl rsa -in {2} -out {3} -outform PEM -pubout && openssl pkeyutl -encrypt -inkey {4} -pubin -in {5} -out {6} && del {7}",
            //        _StorePath, _PrivPath, _PrivPath, _PubPath, _PubPath, _Path, _ENCPath, _Path));
            process.StandardInput.WriteLine(string.Format("openssl genrsa -out {0} 1024 && openssl rsa -in {1} -out {2} -outform PEM -pubout && openssl pkeyutl -encrypt -inkey {3} -pubin -in {4} -out {5} && del {6}",
            _PrivPath, _PrivPath, _PubPath, _PubPath, _Path, _ENCPath, _Path));
            process.StandardInput.Close();

            process.WaitForExit();
            process.Close();
        }
    }
}
