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

namespace CustomTreeView
{
    public partial class Form1 : Form
    {
        string _rootPath = Path.GetFullPath(@"..\Repository");

        public Form1()
        {
            InitializeComponent();

            ListDirectory(treeView1, _rootPath);

            treeView1.DrawNode += new DrawTreeNodeEventHandler(treeView1_DrawNode);
            treeView1.NodeMouseClick += new TreeNodeMouseClickEventHandler(treeView1_NodeMouseClick);
            treeView1.MouseDown += new MouseEventHandler(treeView1_MouseDown);
        }

        private StringFormat stringFormat = new StringFormat();
        private Rectangle buttonRect = new Rectangle(10, 10, 20, 20);
        private enum PushButtonState
        {
            Normal,
            Pressed
        }

        private TreeNode GetNodeAt(Point location)
        {
            TreeNode tnode = treeView1.GetNodeAt(location);
            if (tnode == null) return null;

            Rectangle btnRectAbsolute = new Rectangle(tnode.Bounds.Location + new Size(buttonRect.Location), buttonRect.Size);
            if (btnRectAbsolute.Contains(location))
            {
                return tnode;
            }

            return null;
        }


        private void treeView1_DrawNode(object sender, DrawTreeNodeEventArgs e)
        {
            e.Graphics.DrawString(e.Node.Text, this.Font, new SolidBrush(this.ForeColor), e.Bounds, stringFormat);
            ButtonRenderer.DrawButton(e.Graphics, new Rectangle(e.Node.Bounds.Location + new Size(buttonRect.Location), buttonRect.Size), "btn", this.Font, true, (System.Windows.Forms.VisualStyles.PushButtonState)((e.Node.Tag != null) ? (PushButtonState)e.Node.Tag : PushButtonState.Normal));
        }

        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node.Tag != null && (PushButtonState)e.Node.Tag == PushButtonState.Pressed)
            {
                e.Node.Tag = PushButtonState.Normal;
                MessageBox.Show(e.Node.Text + " clicked");
                // force redraw
                e.Node.Text = e.Node.Text;
            }
        }

        private void treeView1_MouseDown(object sender, MouseEventArgs e)
        {
            TreeNode tnode = GetNodeAt(e.Location);
            if (tnode == null) return;

            Rectangle btnRectAbsolute = new Rectangle(tnode.Bounds.Location + new Size(buttonRect.Location), buttonRect.Size);
            if (btnRectAbsolute.Contains(e.Location))
            {
                tnode.Tag = PushButtonState.Pressed;
                tnode.Text = tnode.Text;
            }
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
            // 파일도 tree view에 등록
            //foreach (var file in directoryInfo.GetFiles())
            //{
            //    directoryNode.Nodes.Add(new TreeNode(file.Name));
            //}

            return directoryNode;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var sNode = treeView1.SelectedNode;
            string folderName = "test";

            if (folderName != "")
            {
                if (sNode != null)
                {
                    string selectPath = string.Format("..\\{0}\\{1}", sNode.FullPath, folderName);

                    DirectoryInfo createDir = new DirectoryInfo(selectPath);
                    if (!createDir.Exists)
                    {
                        createDir.Create();
                        sNode.Nodes.Add(new TreeNode(folderName));
                        MessageBox.Show(string.Format("{0}이(가) 추가됐습니다 !", folderName));
                    }
                    else
                    {
                        MessageBox.Show("중복된 폴더 명입니다!");
                    }
                }
            }
            else
            {
                MessageBox.Show("이름은 한 글자 이상 입력해주세요!");
            }
        }
    }
}
