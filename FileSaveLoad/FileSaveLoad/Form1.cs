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
            string txt = tBoxSave.Text;
            System.IO.File.WriteAllText(_filePath, txt);
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            try
            {
                string[] txt = System.IO.File.ReadAllLines(_filePath);
                tBoxLoad.Text = txt[0];
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
