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
    public partial class Band_User : Form
    {
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Blood;Integrated Security=True");
        public Band_User()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlDataAdapter sda = new SqlDataAdapter("Select * From UserList Where User_Name='" + Username.Text + "' ", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count == 1)
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(@"DELETE FROM UserList
                WHERE User_Name='" + Username.Text + "'", con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Successfully Baned....!!!");
            }
            else
            {
                MessageBox.Show("Invalid User Name", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
                
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Admin_Home obj = new Admin_Home();
            obj.Show();
            this.Close();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
