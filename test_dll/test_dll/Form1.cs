using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices; // DLLImport를 위한

namespace test_dll
{
    public partial class Form1 : Form
    {

        // %SystemRoot% 에 dll파일 있어야함
        // 보통 C:\Windows에 두면 된다.
        [DllImport("helloTest.dll")]
        public static extern IntPtr HelloTest(byte[] name) ;


        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = tBoxURL.Text;
            var pStr = HelloTest(Encoding.Default.GetBytes(name));
            string str = Marshal.PtrToStringAnsi(pStr);
            tBoxCookie.Text = str;

        }
    }
}
