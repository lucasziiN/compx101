using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nilesh_s_Business
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {

        //exits application
            Application.Exit
                ();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {

            textBoxDrivewayLength.Clear();
            textBoxDrivewayWidth.Clear();
            textBoxConcreteRequired.Clear();   
            textBoxBagsRequired.Clear();
            textBoxCementRequired.Clear();
            textBoxTotalCost.Clear();
        }

        private void buttonConcrete_Click(object sender, EventArgs e)
        {
            
            double drivewayLength = 0;
            double drivewayWidth = 0;
            double concreteRequired = 0;
            double cementRequired = 0;
            int bagsRequired = 0;
            decimal totalCost = 0;

            try
            {
                // getting driveway length and width, respectively
                drivewayLength = double.Parse(textBoxDrivewayLength.Text);
                drivewayWidth = double.Parse(textBoxDrivewayWidth.Text);


                // the depth of every driveway.
                const double driveway_depth = 0.5;

                // amount of concrete created from 1 kg of cement
                const double concrete_per_kg = 1.5;

                // weight of a bag of cement
                const double bag_weight = 2.0;

                // cost of a bag of cement
                const decimal bag_cost = 15.5m;

                // calculate volume of driveway
                concreteRequired = drivewayLength * drivewayWidth * driveway_depth;
                cementRequired = concreteRequired / concrete_per_kg;
                bagsRequired = (int)cementRequired / (int)bag_weight;
                totalCost = bagsRequired * (int)bag_cost;

                // display output values
                textBoxConcreteRequired.Text = concreteRequired.ToString("0");
                textBoxCementRequired.Text = cementRequired.ToString("0");
                textBoxBagsRequired.Text = bagsRequired.ToString("0");
                textBoxTotalCost.Text = totalCost.ToString("C");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error");
            }
        }

    private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void concreteRequired_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void cementRequired_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
