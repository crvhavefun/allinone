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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Btn_UMP_Click(object sender, EventArgs e)
        {
            UMP ump = new UMP();
            ump.StartPosition = StartPosition;
            ump.setMenu(this);
            ump.Show();
            Visible = false;
        }
    }
}
