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
    public partial class 
        Form1 : Form
    {
        Random rand = new Random();
        public Form1()
        {
            InitializeComponent();
            
        }

        private void pictureBoxDisplay_MouseMove(object sender, MouseEventArgs e)
        {
            //creates graphics and creates pen1
            Graphics paper = pictureBoxDisplay.CreateGraphics();
            Pen pen1 = new Pen(colorDialog1.Color, 2);
            SolidBrush br = new SolidBrush(Color.Orange);
            
            //paper.DrawLine(pen1, 0, 0 , e.X, e.Y);

            //uses pen1 to draw a straight line from the middle of the screen to where your mouse is located when left click is pressed
            if (e.Button == MouseButtons.Left)
            {
               //paper.DrawLine(pen1, rand.Next(pictureBoxDisplay.Width+1), rand.Next(pictureBoxDisplay.Height+1), e.X, e.Y);
               //paper.DrawLine(pen1, Width / 2, Height / 2, e.X, e.Y);
               paper.FillEllipse(br, e.X, e.Y, trackBar1.Value, trackBar1.Value);
               paper.DrawEllipse(pen1, e.X, e.Y, trackBar1.Value, trackBar1.Value);
            }
        }

        private void pictureBoxDisplay_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
        }

    }
}
