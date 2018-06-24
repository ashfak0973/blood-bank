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
    public partial class Change_Password : Form
    {
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Blood;Integrated Security=True");
        public Change_Password()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (UN.Text != "" && CP.Text != "" && NP.Text != "")
            {
                SqlDataAdapter sda = new SqlDataAdapter("Select * From UserList Where User_Name='" + UN.Text + "'and Password='" + CP.Text + "' ", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count == 1)
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand(@"UPDATE UserList
                        set Password = '" + NP.Text + "' WHERE User_Name = '" + UN.Text + "'", con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Saved your Pass Succesfully !!!");

                }
                else
                {
                    MessageBox.Show("Invalid User Name or Psssword.... :(", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            else
            {
                MessageBox.Show("Fill The All Field !!!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            User_Home obj = new User_Home();
            obj.Show();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
