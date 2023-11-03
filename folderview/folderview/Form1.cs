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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] msg = tBoxPath.Text.Split(' ');
            for(var i = 0; i < msg.Length; i++)
            {
                MessageBox.Show(msg[i].ToString());
            }
        }
    }
}
