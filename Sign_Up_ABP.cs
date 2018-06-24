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
    public partial class Sign_Up_ABP : Form
    {
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Blood;Integrated Security=True");
        public Sign_Up_ABP()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Total_Fund.Text != "" && Total_Fund.Text != "0" && Username.Text != "" && UName.Text != "" && Phone.Text != "" && Password.Text != "")
            {
                SqlDataAdapter sda = new SqlDataAdapter("Select * From UserList Where User_Name='" + Username.Text + "' ", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count == 1)
                {
                    MessageBox.Show("This User Name Already Exist !!! ", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {

                    con.Open();
                    SqlCommand cmd = new SqlCommand(@"INSERT INTO UserList
                (User_Name, Name, Password, Total_Fund, Total_Withdraw, Blood_Group, Phone)
                VALUES ('" + Username.Text + "','" + UName.Text + "','" + Password.Text + "','" + Total_Fund.Text + "','0','AB+','" + Phone.Text + "')", con);
                    cmd.ExecuteNonQuery();

                    SqlCommand cmd1 = new SqlCommand(@"INSERT INTO ABP
                (User_Name, Name, Total_Fund, Total_Withdraw, Phone)
                VALUES ('" + Username.Text + "','" + UName.Text + "','" + Total_Fund.Text + "','0','" + Phone.Text + "')", con);
                    cmd1.ExecuteNonQuery();
                    SqlCommand cmd2 = new SqlCommand(@"UPDATE BloodAvlList
                set Total_Fund = Total_Fund + '" + Total_Fund.Text + "' WHERE Blood_Group = 'AB+'", con);
                    cmd2.ExecuteNonQuery();
                    SqlCommand cmd3 = new SqlCommand(@"UPDATE BloodAvlList
                set Available_No = Total_Fund - Total_Withdraw WHERE Blood_Group = 'AB+'", con);
                    cmd3.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Successfully Saved...!!!");
                }
            }
            else
            {
                MessageBox.Show("Fill The All Field or make sure that, You Donate At Least One Bag Please", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Selecting_Blood_Group obj = new Selecting_Blood_Group();
            obj.Show();
            this.Close();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
