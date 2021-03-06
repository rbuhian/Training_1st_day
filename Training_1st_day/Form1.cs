﻿using System;
using System.Windows.Forms;

/*This is my first application*/
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
            }
            else
            {
                MessageBox.Show("Failed");
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

        private void button1_Click(object sender, EventArgs e)
        {
            Form frm2 = new Form2();
            frm2.Show();
        }
    }
}
