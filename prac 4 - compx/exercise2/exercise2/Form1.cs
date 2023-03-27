using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exercise2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            pictureBox1.Refresh();
        }

        private void buttonDraw_Click(object sender, EventArgs e)
        {
            //create graphics object
            Graphics paper = pictureBox1.CreateGraphics();

            //create solid brushes
            SolidBrush br1 = new SolidBrush(Color.Blue);
            SolidBrush br2 = new SolidBrush(Color.White);
            SolidBrush br3 = new SolidBrush(Color.Red);

            //declare variables
            int x = 0;
            int y = 0;
            int barWidth = pictureBox1.Width/3;

            //draw blue section
            paper.FillRectangle(br1, x, y, barWidth, pictureBox1.Height);

            //shift x variable to the right by barWidth
            x += barWidth;

            //draw white section
            paper.FillRectangle(br2, x, y, barWidth, pictureBox1.Height);

            //shift x variable to the right by barWidth
            x += barWidth;

            //draw red section
            paper.FillRectangle(br3, barWidth*2, y, barWidth, pictureBox1.Height);

        }
    }
}
