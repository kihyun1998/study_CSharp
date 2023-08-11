using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace FileSaveLoad
{
    public partial class Form1 : Form
    {
        string checkPath = Path.GetFullPath(@"..\save");
        string _filePath = Path.GetFullPath(@"..\save\test.txt");

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // 폴더 유무 체크 및 폴더 생성
            DirectoryInfo di = new DirectoryInfo(checkPath);
            if (!di.Exists)
            {
                di.Create();
            }

            List<string> writeList = new List<string>();
            writeList.Add(cBoxMethod.Text);
            writeList.Add(tBoxUrl.Text);
            writeList.Add(tBoxCookie.Text);
            writeList.Add(tBoxMsg.Text);

            string[] writeArr = writeList.ToArray();

            System.IO.File.WriteAllLines(_filePath, writeArr);
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            try
            {
                string[] txts = System.IO.File.ReadAllLines(_filePath);
                
                foreach (var txt in txts)
                {
                    tBoxLoad.Text += txt+"\r\n";
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] method = { "GET", "POST", "PUT", "DELETE" };
            cBoxMethod.Items.AddRange(method);
            cBoxMethod.SelectedIndex = 0;
        }
    }
}
