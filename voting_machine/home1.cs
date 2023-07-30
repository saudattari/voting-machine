using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace voting_machine
{
    public partial class home1 : UserControl
    {
        string address = "Data Source=DESKTOP-BTIF83O\\SQLEXPRESS;Initial Catalog=voting;Integrated Security=True";
        public home1()
        {
            InitializeComponent();
            
            countdata();



        }

        private void label3_Click(object sender, EventArgs e)
        {
            countdata();
        }
        private void countdata()
        {
            SqlConnection con = new SqlConnection(address);
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "SELECT COUNT(Candidate_Name) FROM Add_Candidate";
            string c = cmd.ExecuteScalar().ToString();
            label3.Text = c;
            voting_meter.Value = Convert.ToInt32(c);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
