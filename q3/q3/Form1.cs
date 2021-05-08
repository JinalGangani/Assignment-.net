using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace q3
{
    public partial class Form1 : Form
    {
        string temp = String.Empty;
        public Form1()
        {
            InitializeComponent();
        }
       
        private void btnsubmit_Click(object sender, EventArgs e)
        {
            if(radioButton1.Checked==true)
            {
                listBox1.Items.Add(textBox1.Text);
            }
            else
            {
                listBox1.Items.Remove(textBox1.Text);
            }
            
        }
    }
}
