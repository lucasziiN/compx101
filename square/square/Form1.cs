using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace square
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Clicking this button will execute the commands listed below
        private void buttonDrawLine_Click(object sender, EventArgs e)
        {
            //Create the graphics and pen objects
            Graphics paper = pictureBoxDisplay.CreateGraphics();
            Pen pen1 = new Pen(Color.Blue, 5);

            //Draw a line using the coordinates given
            paper.DrawLine(pen1, 10, 10, 100, 100);
        }

        private void pictureBoxDisplay_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        //Clicking this button will exit the application
        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit(); 

        }

        private void drawSquare_Click(object sender, EventArgs e)
        {
            Graphics paper = pictureBoxDisplay.CreateGraphics();
            Pen pen1 = new Pen(Color.Blue, 5);
            Pen pen2 = new Pen(Color.Red, 5);
            Pen pen3 = new Pen(Color.Green, 5);
            Pen pen4 = new Pen(Color.Black, 5);

            //Draws 4 lines using the coordinates given. These 4 lines form a square
            paper.DrawLine(pen1, 50, 50, 150, 50);
            paper.DrawLine(pen2, 150, 50, 150, 150);
            paper.DrawLine(pen3, 150, 150, 50, 150);
            paper.DrawLine(pen4, 50, 150, 50, 50);
        }
    }
}
