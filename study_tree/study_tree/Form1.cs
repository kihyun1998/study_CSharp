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

namespace study_tree
{
    public partial class Form1 : Form
    {

        string _rootPath = Path.GetFullPath(@"..\save");

        public Form1()
        {
            InitializeComponent();
            ListDirectory(treeView1, _rootPath);
        }


        private void ListDirectory(TreeView treeView, string path)
        {
            DirectoryInfo isExists = new DirectoryInfo(_rootPath);
            if (!isExists.Exists)
            {
                isExists.Create();
            }
            treeView.Nodes.Clear();
            var rootDirectoryInfo = new DirectoryInfo(path);
            treeView.Nodes.Add(CreateDirectoryNode(rootDirectoryInfo));
        }

        private static TreeNode CreateDirectoryNode(DirectoryInfo directoryInfo)
        {
            var directoryNode = new TreeNode(directoryInfo.Name);
            
            foreach (var directory in directoryInfo.GetDirectories())
            {
                directoryNode.Nodes.Add(CreateDirectoryNode(directory));
            }    
            foreach (var file in directoryInfo.GetFiles())
            {
                directoryNode.Nodes.Add(new TreeNode(file.Name));
            }
                
            return directoryNode;
        }

        private void DisplayFileContent(string filePath)
        {
            try
            {
                tBoxRst.Text = File.ReadAllText(filePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void treeView1_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            string selectPath = string.Format("..\\{0}", e.Node.FullPath);
            string p1 = Path.GetFullPath(@selectPath);
            MessageBox.Show(p1);

            try
            {
                string txt = System.IO.File.ReadAllText(p1);
                MessageBox.Show(txt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}