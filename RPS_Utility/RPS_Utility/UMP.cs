using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RPS_Utility
{
    public partial class UMP : Form
    {
        private Menu m;
        public UMP()
        {
            InitializeComponent();
        }

        public void setMenu(Menu m)
        {
            this.m = m;
        }

        private void UMP_UnLoad(object sender, FormClosedEventArgs e)
        {
            m.Visible = true;
        }

        private void UMP_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'reportPlatformDBDataSet1.rps_userinfo' table. You can move, or remove it, as needed.
            this.rps_userinfoTableAdapter.Fill(this.reportPlatformDBDataSet1.rps_userinfo);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
