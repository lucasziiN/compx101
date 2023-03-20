using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void buttonDrawTriangle_Click(object sender, EventArgs e)
        {
            //creates graphics and pen1
            Graphics paper = pictureBox1.CreateGraphics();
            Pen pen1 = new Pen(Color.AliceBlue, 5);

            // Setting new points
            Point corner1 = new Point(150, 50);
            Point corner2 = new Point(150, 150);
            Point corner3 = new Point(50, 150);
            
            // Draw the triangle using points created
            paper.DrawLine(pen1, corner1,corner2);
            paper.DrawLine(pen1, corner2, corner3);
            paper.DrawLine(pen1, corner1, corner3);

        }

        private void buttonDrawSquare_Click(object sender, EventArgs e)
        {
            // Create graphics and a Pen object
            Graphics paper = pictureBox1.CreateGraphics();
            Pen pen1 = new Pen(Color.Red, 5);

            // Setting the x, y, and size variables
            int x = 50;
            int y = 80;
            int size = 60;

            // Draw the rectangle using the variables
            paper.DrawRectangle(pen1, x,y,size,size); 
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void buttonErase_Click(object sender, EventArgs e)
        {
            pictureBox1.Refresh();
        }
    }
}
