using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace perform_cut_copy_past_undo_redo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            richTextBox1.Copy();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            richTextBox1.Redo();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }
    }
}
