using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace study_folder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            string folderName = ".apitest";
            string folderPath = string.Format("{0}\\..\\{1}",Environment.GetFolderPath(Environment.SpecialFolder.Desktop),folderName);
            DirectoryInfo di = new DirectoryInfo(folderPath);
            if (!di.Exists)
            {
                di.Create();
            }
        }
    }
}
