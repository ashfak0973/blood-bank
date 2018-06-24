using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BD
{
    public partial class Selecting_Blood_Group : Form
    {
        public Selecting_Blood_Group()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Sign_Up obj = new Sign_Up();
            obj.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Sign_Up_ON obj = new Sign_Up_ON();
            obj.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Sign_Up_BP obj = new Sign_Up_BP();
            obj.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Sign_Up_BN obj = new Sign_Up_BN();
            obj.Show();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Sign_Up_ABP obj = new Sign_Up_ABP();
            obj.Show();
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Sign_Up_ABN obj = new Sign_Up_ABN();
            obj.Show();
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Sign_Up_AP obj = new Sign_Up_AP();
            obj.Show();
            this.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Sign_Up_AN obj = new Sign_Up_AN();
            obj.Show();
            this.Close();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Form1 obj = new Form1();
            obj.Show();
            this.Close();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
