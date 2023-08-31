using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PointToScreen
{
    public partial class Form1 : Form
    {
        private Boolean mouseDown = false;
        private Point startPos;
        private Point endPos;

        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            startPos = ((Control)sender).PointToScreen(new Point(e.X, e.Y));
        }

        private void btn1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void btn1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown == false) return;
            endPos = ((Control)sender).PointToScreen(new Point (e.X, e.Y));
            Point temp = new Point( (btn1.Location.X + (endPos.X - startPos.X)), (btn1.Location.Y + (endPos.Y - startPos.Y)) );
            startPos = endPos;
            btn1.Location = temp;
        }
    }
}
