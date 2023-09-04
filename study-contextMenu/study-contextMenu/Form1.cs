using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace study_contextMenu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Point pBtn = button1.PointToScreen(Point.Empty);
            pBtn.X += button1.Width;
            //cMenu.Show(pBtn);

            ContextMenuStrip cm = new System.Windows.Forms.ContextMenuStrip();

            ToolStripMenuItem i1 = new ToolStripMenuItem("A");

            i1.Click += A;
            cm.Items.Add(i1);

            cm.Show(pBtn);

        }
        
        private void A(object sender,EventArgs e)
        {
            MessageBox.Show("A");
        }
    }
}
