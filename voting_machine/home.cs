using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace voting_machine
{
    public partial class home : Form
    {
        string address = "Data Source=DESKTOP-BTIF83O\\SQLEXPRESS;Initial Catalog=voting;Integrated Security=True";

        public home()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void voting_meter_ValueChanged(object sender, EventArgs e)
        {
            
        }
       

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (voting_meter.Value < 100)
            {

                voting_meter.Value += 1;
                label3.Text = voting_meter.Value.ToString();
            }
            else
            {
                timer1.Stop();
            }
        }

        private void home_Load(object sender, EventArgs e)
        {

        }
    }
}
