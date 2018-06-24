using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BD
{
    public partial class User_Home : Form
    {
        public User_Home()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Donate obj = new Donate();
            obj.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Withdraw obj = new Withdraw();
            obj.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            U_Donar_List obj = new U_Donar_List();
            obj.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Change_Password obj = new Change_Password();
            obj.Show();
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form1 obj = new Form1();
            obj.Show();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            U_AvlList obj = new U_AvlList();
            obj.Show();
            this.Close();
        }
    }
}
