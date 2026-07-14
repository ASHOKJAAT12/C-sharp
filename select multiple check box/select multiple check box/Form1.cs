using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace select_multiple_check_box
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str = "";

            if (checkBox1.Checked == true)
            {
                str = str + " " + checkBox1.Text;
            }
            if (checkBox2.Checked == true)
            {
                str = str + " " + checkBox2.Text;
            }

            if (checkBox3.Checked == true)
            {
                str = str + " " + checkBox3.Text;
            }

            if (checkBox4.Checked == true)
            {
                str = str + " " + checkBox4.Text;
            }

            if (checkBox5.Checked == true)
            {
                str = str + " " + checkBox5.Text;
            }

            if (checkBox6.Checked == true)
            {
                str = str + " " + checkBox6.Text;
            }

            textBox1.Text = str;
        }
    }
}
