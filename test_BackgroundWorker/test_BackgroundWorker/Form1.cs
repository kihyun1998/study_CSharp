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
        Thread _thread = null;

        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            _thread = new Thread(new ThreadStart(Run));
            _thread.Start();
        }

        private async void Run()
        {
            string url = "https://www.naver.com";

            HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);
            req.Method = "GET";

            try
            {
                using (WebResponse response = req.GetResponse())
                {
                    StreamReader reader = new StreamReader(response.GetResponseStream());
                    string result = reader.ReadToEnd();

                    Invoke(new Action(() =>
                    {
                        textBox1.Text = result;
                    }));
                }
            }
            catch (WebException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
