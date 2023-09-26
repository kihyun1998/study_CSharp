using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace UseDLLTest
{
    public partial class Form1 : Form
    {
        [DllImport("toByte.dll")]
        public static extern IntPtr ConvertToGoBytes(byte[] data);

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            IntPtr pRst;

            byte[] bytes = Encoding.UTF8.GetBytes(tBoxStr.Text);

            pRst = ConvertToGoBytes(bytes);

            string rstText = MarshalUtf8ToUnicode(pRst);
            MessageBox.Show(rstText);
        }

        private void tBoxStr_TextChanged(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(tBoxStr.Text);
            tBoxByte.Text = String.Join(" ", bytes);
        }
        static unsafe string MarshalUtf8ToUnicode(IntPtr pStringUtf82)
        {
            var pStringUtf8 = (byte*)pStringUtf82;
            var len = 0;
            while (pStringUtf8[len] != 0)
                len++;
            return Encoding.UTF8.GetString(pStringUtf8, len);
        }
    }
}
