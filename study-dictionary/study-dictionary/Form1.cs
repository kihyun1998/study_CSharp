using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Xml;

namespace study_dictionary
{
    public partial class Form1 : Form
    {
        Dictionary<string, string> dicStrStr = new Dictionary<string, string>();
        int _i = 0;

        public Form1()
        {
            InitializeComponent();
        }

        // 값 추가
        private void button1_Click(object sender, EventArgs e)
        {
            _i += 1;
            dicStrStr.Add(string.Format("{0}",_i), string.Format("Value_{0}",_i));
        }

        // 하나씩 Show
        private void button2_Click(object sender, EventArgs e)
        {
            foreach(KeyValuePair<string,string> item in dicStrStr)
            {
                MessageBox.Show(string.Format("[{0} , {1}]",item.Key, item.Value));
            }
        }

        // 한번에 Show
        private void button3_Click(object sender, EventArgs e)
        {
            string rst = string.Empty;
            foreach (KeyValuePair<string, string> item in dicStrStr)
            {
                rst = string.Format("{0}\n[{1} , {2}]", rst,item.Key, item.Value);
            }
            MessageBox.Show(rst);
        }

        // 키에 따른 값 수정
        private void button4_Click(object sender, EventArgs e)
        {
            string dicKey = tBoxModify.Text;
            if (!dicKey.Equals("") && dicStrStr.Count != 0 && dicStrStr.ContainsKey(dicKey))
            {
                dicStrStr[dicKey] = string.Format("ChangeVal_{0}",dicKey);
            }
        }

        // 키에 따른 값 가져오기
        private void button5_Click(object sender, EventArgs e)
        {
            string dicKey = tBoxGet.Text;
            if (!dicKey.Equals("") && dicStrStr.Count != 0 && dicStrStr.ContainsKey(dicKey))
            {
                MessageBox.Show(string.Format("Value is {0}",dicStrStr[dicKey]));
            }
            else
            {
                MessageBox.Show("NOOOOO");
            }
        }


        // 과거 키를 현재 키로 수정
        private void button6_Click(object sender, EventArgs e)
        {
            string oldKey = tBoxOld.Text;
            string newKey = tBoxNew.Text;
            if (!oldKey.Equals("") && !newKey.Equals("") && dicStrStr.Count != 0 && dicStrStr.ContainsKey(oldKey))
            {
                if (dicStrStr.ContainsKey(newKey))
                {
                    MessageBox.Show("STOP");
                }
                else
                {
                    string tValue = dicStrStr[oldKey];
                    dicStrStr.Remove(oldKey);
                    dicStrStr[newKey] = tValue;
                }
            }
        }

        // 전부 초기화
        private void button7_Click(object sender, EventArgs e)
        {
            dicStrStr.Clear();
        }
    }
}
