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
    public partial class Candidates : UserControl
    {
        public Candidates()
        {
            InitializeComponent();
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
    }
}
