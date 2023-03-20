using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MouseMoveGraphics
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBoxDisplay_MouseMove(object sender, MouseEventArgs e)
        {
            //creates graphics and creates pen1
            Graphics paper = pictureBoxDisplay.CreateGraphics();
            Pen pen1 = new Pen(Color.Red, 2);
            //paper.DrawLine(pen1, 0, 0 , e.X, e.Y);
            //uses pen1 to draw a straight line from the middle of the screen to where your mouse is located
            paper.DrawLine(pen1, Width / 2, Height / 2, e.X, e.Y);
        }
    }
}
