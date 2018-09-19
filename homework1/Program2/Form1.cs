using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            string s = firstInt.Text;
            int m = Int32.Parse(s);
            string l = secondInt.Text;
            int n = Int32.Parse(l);
            int i = m * n;
            label2.Text = "乘积为" + i;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

       
    }
}
