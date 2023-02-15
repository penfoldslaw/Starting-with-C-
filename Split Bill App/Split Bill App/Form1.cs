using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Split_Bill_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            labelCost.Text = string.Empty;
            textBoxTotalbill.Text = string.Empty;
            textBoxNumber.Text = string.Empty;
            // another way of clearing text in a textbox
            //textBoxNumber.Clear();
            textBoxTotalbill.Focus();
        }

        private void labelCost_Click(object sender, EventArgs e)
        {

        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            //input 
            //declare variables
            decimal inTotal = 0m;
            int inNumber = 0;
            decimal outCost = 0m;

            //get inputs from the textboxes 
            inTotal = decimal.Parse(textBoxTotalbill.Text);
            inNumber = int.Parse(textBoxNumber.Text);

            //process
            outCost = inTotal/ inNumber;

            //output 
            labelCost.Text = outCost.ToString("c4");
        }

        private void textBoxTotalbill_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
