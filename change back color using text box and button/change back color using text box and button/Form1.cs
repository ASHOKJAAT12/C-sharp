using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace change_back_color_using_text_box_and_button
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.Red;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.Blue;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.Green;
        }
    }
}
