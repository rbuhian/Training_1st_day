using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Training_1st_day
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmdShow_Click(object sender, EventArgs e)
        {
            string name = "Tritontek";
            if (MessageBox.Show(name, "test", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
            {
                MessageBox.Show("Success");
            };
        }

        private void cmdShow_MouseHover(object sender, EventArgs e)
        {
            MessageBox.Show("Mouse Hover");
        }

        private void tsmExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
