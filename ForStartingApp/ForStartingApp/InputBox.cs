using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ForStartingApp
{
    public partial class InputBox : Form
    {
        public InputBox()
        {
            InitializeComponent();
        }
        public string Password { get; set; }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Password = tBoxPass.Text.Trim();
            if (string.IsNullOrEmpty(Password))
            {
                MessageBox.Show("비밀번호를 입력해주세요.");
            }
            else
            {
                this.Close();
            }
            
        }
    }
}
