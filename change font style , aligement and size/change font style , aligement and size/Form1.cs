using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace change_font_style___aligement_and_size
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Font = new Font(textBox1.Font,FontStyle.Bold);
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Font = new Font(textBox1.Font, FontStyle.Underline);
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Font = new Font(textBox1.Font.FontFamily,10);
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Font = new Font(textBox1.Font.FontFamily, 20);
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.TextAlign = HorizontalAlignment.Right; 
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.TextAlign= HorizontalAlignment.Left;
        }
    }
}
