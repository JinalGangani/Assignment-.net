using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace q4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            if(radioButtonLCM.Checked)
            {

            }
        }

        private void radioButtonLCM_CheckedChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                labelMessage.Text = "Enter Number";
            }
            else
            {
                int num1 = Int32.Parse(textBox1.Text);
                int num2 = Int32.Parse(textBox2.Text);
                int j, hcf = 0;
                j = (num1 > num2) ? num1 : num2;
                for (int i = 1; i <= j; i++)
                {
                    if (num1 % i == 0 && num2 % i == 0)
                    {
                        hcf = i;
                    }
                }
                labelMessage.Text = "HCF Of " + num1.ToString() + " And " + num2.ToString() + " Is: " + hcf.ToString();
            }

        }

        private void radioButtonHCF_CheckedChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox1.Text == "")
            {
                labelMessage.Text = "Enter Number";
            }
            else
            {
                int num1 = Int32.Parse(textBox1.Text);
                int num2 = Int32.Parse(textBox2.Text);
                int max, lcm;
                max = (num1 > num2) ? num1 : num2;
                for (int i = max; ; i += max)
                {
                    if (i % num1 == 0 && i % num2 == 0)
                    {
                        lcm = i;
                        break;
                    }
                }
                labelMessage.Text = "LCM Of " + num1.ToString() + " And " + num2.ToString() + " Is: " + lcm.ToString();
            }

        }
    }
}
