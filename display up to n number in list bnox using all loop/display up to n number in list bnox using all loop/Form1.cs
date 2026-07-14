using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace display_up_to_n_number_in_list_bnox_using_all_loop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(textBox1.Text);
            for ( int i = 1; i <= n; i++ )
            {
                listBox1.Items.Add(i.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(textBox1.Text);
            int i = 1;
            while(i <= n)
            {
                listBox1.Items.Add(i);
                i++;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(textBox1.Text);
            int i = 1;
            do
            {
                listBox1.Items.Add(i);
                i++;
            }while ( i <= n);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Text = string.Empty;
            textBox1.Text = string.Empty;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
