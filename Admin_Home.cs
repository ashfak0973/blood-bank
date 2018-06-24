using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BD
{
    public partial class Admin_Home : Form
    {
        public Admin_Home()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Donor_List obj = new Donor_List();
            obj.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            User_List obj = new User_List();
            obj.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Band_User obj = new Band_User();
            obj.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AvlList obj = new AvlList();
            obj.Show();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form1 obj = new Form1();
            obj.Show();
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Donate obj = new Donate();
            obj.Show();
            this.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Withdraw obj = new Withdraw();
            obj.Show();
            this.Close();
        }
    }
}
