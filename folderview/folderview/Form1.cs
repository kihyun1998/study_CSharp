using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace folderview
{
    public partial class Form1 : Form
    {   
        public Form1()
        {
            InitializeComponent();
            treeView1.Nodes.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string nodeName = tBoxNodeName.Text;
        
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            // 노드 이름
            string nodeName = tBoxNodeName.Text;
            
            // 경로 문자열
            string inputPath = tBoxPath.Text;

            // 폴더뷰 생성
            CreateNodes(treeView1.Nodes,inputPath,nodeName);
        }

        private void CreateNodes(TreeNodeCollection parent, String inputPath, string nodeName)
        {
            // [경로 얻기] 문자열 공백 기준으로 나누기
            string[] paths = inputPath.Split(' ');
            TreeNode child = null;

            // 경로 생성
            foreach (string path in paths)
            {
                child = IsContain(parent,path);
                parent = child.Nodes;
            }
            // 마지막에 노드 추가
            parent.Add(nodeName, nodeName);
        }
        private TreeNode IsContain(TreeNodeCollection nodes, string path)
        {
            // 해당 키를 가진 노드가 있는지 검사
            if(nodes.ContainsKey(path))
            {
                MessageBox.Show(String.Format("Yes : {0}, level : {1} nodes[0]: {2}", nodes[nodes.IndexOfKey(path)].Text, nodes[nodes.IndexOfKey(path)].Level,nodes[0]));
                // 노드가 있다면 해당 키의 노드의 인덱스의 노드를 반환
                // 간단하게 표현하면 중복되는 노드 그대로 반환
                return nodes[nodes.IndexOfKey(path)];
            }
            else
            {
                MessageBox.Show(String.Format("No"));
                foreach(TreeNode tNode in nodes)
                {
                    MessageBox.Show(tNode.Text);
                }
            }

            // TreeNodeCollection에 key, name으로 노드 추가
            return nodes.Add(path,path);
        }
    }
}
