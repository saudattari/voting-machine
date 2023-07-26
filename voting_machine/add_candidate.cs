using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace voting_machine
{
    public partial class add_candidate : UserControl
    {
        string address = "Data Source=DESKTOP-BTIF83O\\SQLEXPRESS;Initial Catalog=voting;Integrated Security=True";

        public add_candidate()
        {
            InitializeComponent();
            guna2DateTimePicker1.MinDate = DateTime.Today;
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void guna2DateTimePicker1_ValueChanged_1(object sender, EventArgs e)
        {

        }
    }
}
