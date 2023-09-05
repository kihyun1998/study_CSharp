﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace API_Tester.Custom
{
    public partial class CustomMessageBox : Form
    {
        public CustomMessageBox()
        {
            InitializeComponent();
        }

        public Image MessageIcon
        {
            get { return pBox.Image; }
            set { pBox.Image = value; }
        }

        public string Message
        {
            get { return lblMessage.Text; }
            set { lblMessage.Text = value;  }
        }
    }
}
