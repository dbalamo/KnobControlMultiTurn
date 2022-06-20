using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KnobControlTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            knobControl1.Value = 14110;
            knobControl1.Focus();
        }

        private void knobControl1_ValueChanged(object Sender)
        {
            textBox1.Text = Convert.ToString(knobControl1.Value);
        }

        private void btpStepOne_Click(object sender, EventArgs e)
        {
            knobControl1.Step = 1;
        }

        private void btnStepTen_Click(object sender, EventArgs e)
        {
            knobControl1.Step = 10;
        }

        private void btnStepHundred_Click(object sender, EventArgs e)
        {
            knobControl1.Step = 100;
        }
    }
}
