using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BD
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Blood;Integrated Security=True");

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (AdminnametextBox.Text == "Admin" && AdminpasstextBox.Text == "1233")
            {
                Admin_Home obj = new Admin_Home();
                obj.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Id or Psss", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlDataAdapter sda = new SqlDataAdapter("Select * From UserList Where User_Name='" + UsernametextBox.Text + "'and Password='" + UserpasstextBox.Text + "' ", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count == 1)
            {
                User_Home obj = new User_Home();
                obj.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Id or Psss", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Selecting_Blood_Group obj = new Selecting_Blood_Group();
            obj.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
