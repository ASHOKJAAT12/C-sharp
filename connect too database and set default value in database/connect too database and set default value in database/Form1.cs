using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace connect_too_database_and_set_default_value_in_database
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
 
        private void button1_Click(object sender, EventArgs e)
        {
            //DESKTOP - GUSLB1E;
            SqlConnection con = new SqlConnection(@"data source=DESKTOP-GUSLB1E;initial catalog=juice; integrated security=true;");
            con.Open();
            string str = "insert into student(id,name,age,subject) values (02,'shyam',20,'math');";
            SqlCommand cmd = new SqlCommand(str, con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("juice bej deya gaya.");
        }
    }
}
