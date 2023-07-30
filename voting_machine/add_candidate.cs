using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace voting_machine
{
    public partial class add_candidate : UserControl
    {
        public static add_candidate Instance;
        string address = "Data Source=DESKTOP-BTIF83O\\SQLEXPRESS;Initial Catalog=voting;Integrated Security=True";
        private byte[] imageBytes;
        public Guna2TextBox t1;
        public Guna2TextBox t2;
        public Guna2TextBox t3;
        public Guna2TextBox t4;
        public Guna2TextBox t6;
        public Guna2DateTimePicker t5;

        public add_candidate()
        {
            InitializeComponent();
            Instance = this;
            t1 = name;
            t2 = position;
            t3 = polling;
            t4 = party;
            t5 = date;
            t6 = id;
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

        private void button1_Click_1(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files (*.jpg; *.jpeg; *.png; *.gif; *.bmp)|*.jpg; *.jpeg; *.png; *.gif; *.bmp|All Files (*.*)|*.*";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Convert the selected image to a byte array
                    imageBytes = File.ReadAllBytes(openFileDialog.FileName);

                    // Display the image in the PictureBox
                    using (MemoryStream ms = new MemoryStream(imageBytes))
                    {
                        pictureBox1.Image = Image.FromStream(ms);
                    }
                }
            }
            
        }
        //private void addtodb()
        //{
        //    if (imageBytes == null)
        //    {
        //        MessageBox.Show("Please upload an image first.");
        //        return;
        //    }
        //    try
        //    {

        //        using (SqlConnection connection = new SqlConnection(address))
        //        {
        //            connection.Open();
        //            string query = "INSERT INTO Add_Candidate (Candidate_Photo) VALUES (@ImageData)";
        //            using (SqlCommand cmd = new SqlCommand(query, connection))
        //            {
        //                // Assuming you want to save the file name as well
        //                //cmd.Parameters.AddWithValue("@ImageName", Path.GetFileName(txtFileName.Text));
        //                cmd.Parameters.AddWithValue("@ImageData", imageBytes);

        //                cmd.ExecuteNonQuery();
        //                MessageBox.Show("Image saved to database successfully.");
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Error: " + ex.Message);
        //    }
        //}

        private void guna2Button2_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(address);
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "UPDATE Add_Candidate SET Candidate_Name='" + name.Text + "' , Position='" + position.Text + "', Polling_Station='" + polling.Text + "',Party_Name='" + party.Text+ "', Election_Date='" + date.Value + "' WHERE Candidate_Id='"+Convert.ToInt32(id.Text) +"' ";
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string x = date.Value.ToString();
            
            SqlConnection connection = new SqlConnection(address);
            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "INSERT INTO Add_Candidate(Candidate_Name, Position, Polling_Station, Party_Name, Election_Date, Candidate_Photo) VALUES ('" + name.Text + "', '" + position.Text + "', '" + polling.Text + "', '" + party.Text + "', '" + x + "', '"+imageBytes+"'  )";
            //SqlParameter imageParam = new SqlParameter("@Candidate_Photo", SqlDbType.VarBinary);
            //imageParam.Value = imageBytes;
            
            cmd.ExecuteNonQuery();
            connection.Close();
        }

        private void name_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            
        }
    }
    
}
