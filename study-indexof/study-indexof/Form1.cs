﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace study_indexof
{
    public partial class Form1 : Form
    {
        string _txt = "Hello, World s!!! Hey @@@ What is \n This is Just Text Line";

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_txt.Substring(_txt.IndexOf(',')));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_txt.Substring(_txt.IndexOf("!!!")+4));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_txt.Substring(_txt.IndexOf("\n")+1));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_txt.Substring(_txt.IndexOf(',')).Trim());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_txt.Substring(_txt.IndexOf("!!!") + 3).Trim());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_txt.Substring(_txt.IndexOf("\n")).Trim());
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_txt.Substring(0,_txt.IndexOf(',')));
        }

        private void button8_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_txt.Substring(0,_txt.IndexOf("!!!")));
        }

        private void button9_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_txt.Substring(0, _txt.IndexOf("\n")));
        }
    }
}
