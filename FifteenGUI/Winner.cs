using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FifteenGUI
{
    public partial class Winner : Form
    {
        public Winner()
        {
            InitializeComponent();
        }

        private void again_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void It_s_All_Click(object sender, EventArgs e)
        {
            Close();
            Application.Exit();
        }
    }
}
