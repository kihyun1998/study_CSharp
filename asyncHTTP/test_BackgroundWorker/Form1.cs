using System;
using System.IO;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace test_BackgroundWorker
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            string url = "https://www.naver.com";
            string resText = await RequestAsnc(url);
            textBox1.Text = resText;
        }

        private async Task<string> RequestAsnc(string url)
        {
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);
            req.Method = "GET";

            using (WebResponse res = await req.GetResponseAsync())
            {
                using (StreamReader reader = new StreamReader(res.GetResponseStream()))
                {
                    string resText = await reader.ReadToEndAsync();
                    return resText;
                }
            }
        }
    }
}
