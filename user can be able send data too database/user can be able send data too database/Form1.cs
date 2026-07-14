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
namespace user_can_be_able_send_data_too_database
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"data source=DESKTOP-GUSLB1E; initial catalog=juice; integrated security=true;");
            con.Open();
            string str = "insert into student1 ( name , class , rollno , subject ) values ( ' " + tname.Text + " ', ' " + tclass.Text + " '," + trollno.Text + ",' " + tsubject.Text + " ')";
            SqlCommand cmd = new SqlCommand(str, con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("juice bej deya gaya hh.");
        }
    }
}
