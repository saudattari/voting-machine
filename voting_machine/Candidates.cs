using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace voting_machine
{
    public partial class Candidates : UserControl
    {
        public static Candidates Instanace;
        
        string address = "Data Source=DESKTOP-BTIF83O\\SQLEXPRESS;Initial Catalog=voting;Integrated Security=True";
        int del_Id;
        public Candidates()
        {
            InitializeComponent();
            Instanace = this;
            show_candidate();

        }

        private void guna2GradientCircleButton1_Click(object sender, EventArgs e)
        {
            
        }
        private void loadform2(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            mainbox.Controls.Clear();
            mainbox.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2GradientCircleButton1_Click_1(object sender, EventArgs e)
        {
            guna2DataGridView1.Visible = false;
            add_candidate ac = new add_candidate();
            loadform2(ac);
        }

        private void guna2DataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            add_candidate ad = new add_candidate();

            loadform2(ad);
            add_candidate.Instance.t1.Text = guna2DataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            add_candidate.Instance.t2.Text = guna2DataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            add_candidate.Instance.t3.Text = guna2DataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            add_candidate.Instance.t4.Text = guna2DataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            add_candidate.Instance.t6.Text = guna2DataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            //string y= guna2DataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            //DateTime dt = Convert.ToDateTime(y);
            //add_candidate.Instance.t5.Value = dt;
        }
        private void show_candidate()
        {
            SqlConnection con = new SqlConnection(address);
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT *FROM Add_Candidate", con);
            da.Fill(dt);
            guna2DataGridView1.DataSource = dt;
            con.Close();

        }

        private void guna2GradientCircleButton3_Click(object sender, EventArgs e)
        {
            guna2TextBox2.Visible = true;
        }

        private void guna2TextBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                del_Id = Convert.ToInt32(guna2TextBox2.Text);
                SqlConnection con = new SqlConnection(address);
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "DELETE FROM Total_Votes WHERE Candidate_ID='" + del_Id + "'";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "DELETE FROM Add_Candidate WHERE Candidate_ID='" + del_Id + "'";
                    cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        private void guna2GradientCircleButton2_Click(object sender, EventArgs e)
        {
           

        }
        
    }
}
