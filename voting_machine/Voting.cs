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
//using System.Web.UI.WebControls;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace voting_machine
{
    public partial class Voting : UserControl
    {
        string address = "Data Source=DESKTOP-BTIF83O\\SQLEXPRESS;Initial Catalog=voting;Integrated Security=True";
        private List<string> userlist = new List<string>();
        string x;
        int vote;
        public Voting()
        {
            InitializeComponent();
            vote = 1;
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
        private void CreateButtonsForUsers()
        {
            int n = 70;
            foreach (string user in userlist)
            {
                n = n + 80;
                CreateButton(user, n);
            }
        }
        private void OnButtonClick(object sender, EventArgs e)
        {
           
            if (sender is Guna2Button onclick)
            {
                onclick.HoverState.FillColor = Color.Red;
                x = onclick.Text;
                onclick.FillColor.ToKnownColor();
             
            }
            
            count_vote(x);
        }
        private void count_vote(string x)
        {
            SqlConnection con = new SqlConnection(address);
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "SELECT Candidate_ID FROM Add_Candidate WHERE Candidate_Name='"+x+"'";
            string c_id = cmd.ExecuteScalar().ToString();
            cmd.CommandText = "SELECT Votes FROM Total_Votes";
            string T_votes = cmd.ExecuteScalar().ToString();
            int votes = Convert.ToInt32(T_votes);
            vote += votes;
            int c_ID = Convert.ToInt32(c_id);
            cmd.CommandText = "INSERT INTO Total_Votes(Candidate_ID,Votes) VALUES('"+c_ID+"' , '" + vote + "')";
            cmd.ExecuteNonQuery();
            con.Close();
        }
        private void CreateButton(string userName , int n)
        {
            Guna2Button newButton = new Guna2Button();
            newButton.Text = userName;
            newButton.Width = 280;
            newButton.Height = 60;
            newButton.Name = "btn1";
            newButton.Cursor = Cursors.Hand;
            newButton.Location = new Point(500, n);
            newButton.Visible = true;
            newButton.AutoRoundedCorners = true;
            newButton.Click += OnButtonClick;
            this.Controls.Add(newButton);
            // You can add more properties and event handlers as needed

        }
        private void showdata()
        {
            SqlConnection con = new SqlConnection(address);
            con.Open();

            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "SELECT Candidate_Name FROM Add_Candidate";

            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    string c_name = reader["Candidate_Name"].ToString();
                    userlist.Add(c_name);
                }
            }

            con.Close();
        }
        

        private void vote_btn_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void Voting_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            showdata();
            CreateButtonsForUsers();
            guna2Button1.Enabled = false;





        }
    }
}
