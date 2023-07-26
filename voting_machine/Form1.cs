using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace voting_machine
{
    public partial class Form1 : Form
    {
        string address = "Data Source=DESKTOP-BTIF83O\\SQLEXPRESS;Initial Catalog=voting;Integrated Security=True";
        public Form1()
        {
            InitializeComponent();
            loadform(new home());
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void loadform(object form)
        {
            if(this.mainbox.Controls.Count > 0)
                this.mainbox.Controls.RemoveAt(0);
                Form form1 = form as Form;
                form1.TopLevel = false;
                form1.Dock = DockStyle.Fill;
                this.mainbox.Controls.Add(form1);
                this.mainbox.Tag = form1;
                form1.Show();
            
        }

        private void mainbox_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            loadform(new home());
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            loadform(new candidate());
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void mainbox_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }
}
