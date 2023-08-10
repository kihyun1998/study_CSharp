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
            LoadFolders(_rootPath);
        }

        private void LoadFolders(string rootPath)
        {

            DirectoryInfo di = new DirectoryInfo(_rootPath);
            if (!di.Exists)
            {
                di.Create();
            }

            try
            {
                DirectoryInfo rd = new DirectoryInfo(rootPath);
                TreeNode rNode = new TreeNode("My Drive");
                AddSubdirectories(rNode, rd);
                folderTreeView.Nodes.Add(rNode);
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Error: {0}", ex.Message.ToString()));
            }
        }

        private void AddSubdirectories(TreeNode parent, DirectoryInfo di)
        {
            DirectoryInfo[] subDirectories = null;
            try
            {
                subDirectories = di.GetDirectories();
            }
            catch (UnauthorizedAccessException)
            {
                parent.Nodes.Add(new TreeNode("[Access Denied]"));
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Error: {0}", ex.Message.ToString()));
                return;
            }

            TreeNode subdirectoryNode;
            foreach (DirectoryInfo subdir in subDirectories)
            {
                subdirectoryNode = parent.Nodes.Add(subdir.Name);
                AddSubdirectories(subdirectoryNode, subdir);
            }
        }
    }
}