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
    public partial class Withdraw : Form
    {
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Blood;Integrated Security=True");
        public Withdraw()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (BG.Text != "" && UN.Text != "" && HMB.Text != "")
            {
                if (BG.Text == "O+")
                {
                    SqlDataAdapter sda = new SqlDataAdapter("Select * From OP Where User_Name='" + UN.Text + "' ", con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    if (dt.Rows.Count == 1)
                    {
                        con.Open();

                        SqlCommand cmd = new SqlCommand(@"UPDATE OP
                        set Total_Withdraw = Total_Withdraw + '" + HMB.Text + "' WHERE User_Name = '" + UN.Text + "'", con);
                        cmd.ExecuteNonQuery();

                        SqlCommand cmd1 = new SqlCommand(@"UPDATE UserList
                        set Total_Withdraw = Total_Withdraw + '" + HMB.Text + "' WHERE User_Name = '" + UN.Text + "'", con);
                        cmd1.ExecuteNonQuery();

                        SqlCommand cmd2 = new SqlCommand(@"UPDATE BloodAvlList
                        set Total_Withdraw = Total_Withdraw + '" + HMB.Text + "' WHERE Blood_Group = 'O+'", con);
                        cmd2.ExecuteNonQuery();

                        SqlCommand cmd3 = new SqlCommand(@"UPDATE BloodAvlList
                        set Available_No = Total_Fund - Total_Withdraw WHERE Blood_Group = 'O+'", con);
                        cmd3.ExecuteNonQuery();

                        con.Close();

                        MessageBox.Show("Successfully Withdrawn....!!!");
                    }
                    else
                    {
                        MessageBox.Show("Invalid User Name !!!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                else if (BG.Text == "O-")
                {
                    SqlDataAdapter sda = new SqlDataAdapter("Select * From OM Where User_Name='" + UN.Text + "' ", con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    if (dt.Rows.Count == 1)
                    {
                        con.Open();

                        SqlCommand cmd = new SqlCommand(@"UPDATE OM
                        set Total_Withdraw = Total_Withdraw + '" + HMB.Text + "' WHERE User_Name = '" + UN.Text + "'", con);
                        cmd.ExecuteNonQuery();

                        SqlCommand cmd1 = new SqlCommand(@"UPDATE UserList
                        set Total_Withdraw = Total_Withdraw + '" + HMB.Text + "' WHERE User_Name = '" + UN.Text + "'", con);
                        cmd1.ExecuteNonQuery();

                        SqlCommand cmd2 = new SqlCommand(@"UPDATE BloodAvlList
                        set Total_Withdraw = Total_Withdraw + '" + HMB.Text + "' WHERE Blood_Group = 'O-'", con);
                        cmd2.ExecuteNonQuery();

                        SqlCommand cmd3 = new SqlCommand(@"UPDATE BloodAvlList
                        set Available_No = Total_Fund - Total_Withdraw WHERE Blood_Group = 'O-'", con);
                        cmd3.ExecuteNonQuery();

                        con.Close();

                        MessageBox.Show("Successfully Withdrawn....!!!");
                    }
                    else
                    {
                        MessageBox.Show("Invalid User Name !!!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                else if (BG.Text == "B+")
                {
                    SqlDataAdapter sda = new SqlDataAdapter("Select * From BP Where User_Name='" + UN.Text + "' ", con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    if (dt.Rows.Count == 1)
                    {
                        con.Open();

                        SqlCommand cmd = new SqlCommand(@"UPDATE BP
                        set Total_Withdraw = Total_Withdraw + '" + HMB.Text + "' WHERE User_Name = '" + UN.Text + "'", con);
                        cmd.ExecuteNonQuery();

                        SqlCommand cmd1 = new SqlCommand(@"UPDATE UserList
                        set Total_Withdraw = Total_Withdraw + '" + HMB.Text + "' WHERE User_Name = '" + UN.Text + "'", con);
                        cmd1.ExecuteNonQuery();

                        SqlCommand cmd2 = new SqlCommand(@"UPDATE BloodAvlList
                        set Total_Withdraw = Total_Withdraw + '" + HMB.Text + "' WHERE Blood_Group = 'B+'", con);
                        cmd2.ExecuteNonQuery();

                        SqlCommand cmd3 = new SqlCommand(@"UPDATE BloodAvlList
                        set Available_No = Total_Fund - Total_Withdraw WHERE Blood_Group = 'B+'", con);
                        cmd3.ExecuteNonQuery();

                        con.Close();

                        MessageBox.Show("Successfully Withdrawn....!!!");
                    }
                    else
                    {
                        MessageBox.Show("Invalid User Name !!!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                else if (BG.Text == "B-")
                {
                    SqlDataAdapter sda = new SqlDataAdapter("Select * From BM Where User_Name='" + UN.Text + "' ", con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    if (dt.Rows.Count == 1)
                    {
                        con.Open();

                        SqlCommand cmd = new SqlCommand(@"UPDATE BM
                        set Total_Withdraw = Total_Withdraw + '" + HMB.Text + "' WHERE User_Name = '" + UN.Text + "'", con);
                        cmd.ExecuteNonQuery();

                        SqlCommand cmd1 = new SqlCommand(@"UPDATE UserList
                        set Total_Withdraw = Total_Withdraw + '" + HMB.Text + "' WHERE User_Name = '" + UN.Text + "'", con);
                        cmd1.ExecuteNonQuery();

                        SqlCommand cmd2 = new SqlCommand(@"UPDATE BloodAvlList
                        set Total_Withdraw = Total_Withdraw + '" + HMB.Text + "' WHERE Blood_Group = 'B-'", con);
                        cmd2.ExecuteNonQuery();

                        SqlCommand cmd3 = new SqlCommand(@"UPDATE BloodAvlList
                        set Available_No = Total_Fund - Total_Withdraw WHERE Blood_Group = 'B-'", con);
                        cmd3.ExecuteNonQuery();

                        con.Close();

                        MessageBox.Show("Successfully Withdrawn....!!!");
                    }
                    else
                    {
                        MessageBox.Show("Invalid User Name !!!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                else if (BG.Text == "AB+")
                {
                    SqlDataAdapter sda = new SqlDataAdapter("Select * From ABP Where User_Name='" + UN.Text + "' ", con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    if (dt.Rows.Count == 1)
                    {
                        con.Open();

                        SqlCommand cmd = new SqlCommand(@"UPDATE ABP
                        set Total_Withdraw = Total_Withdraw + '" + HMB.Text + "' WHERE User_Name = '" + UN.Text + "'", con);
                        cmd.ExecuteNonQuery();

                        SqlCommand cmd1 = new SqlCommand(@"UPDATE UserList
                        set Total_Withdraw = Total_Withdraw + '" + HMB.Text + "' WHERE User_Name = '" + UN.Text + "'", con);
                        cmd1.ExecuteNonQuery();

                        SqlCommand cmd2 = new SqlCommand(@"UPDATE BloodAvlList
                        set Total_Withdraw = Total_Withdraw + '" + HMB.Text + "' WHERE Blood_Group = 'AB+'", con);
                        cmd2.ExecuteNonQuery();

                        SqlCommand cmd3 = new SqlCommand(@"UPDATE BloodAvlList
                        set Available_No = Total_Fund - Total_Withdraw WHERE Blood_Group = 'AB+'", con);
                        cmd3.ExecuteNonQuery();

                        con.Close();

                        MessageBox.Show("Successfully Withdrawn....!!!");
                    }
                    else
                    {
                        MessageBox.Show("Invalid User Name !!!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                else if (BG.Text == "AB-")
                {
                    SqlDataAdapter sda = new SqlDataAdapter("Select * From ABM Where User_Name='" + UN.Text + "' ", con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    if (dt.Rows.Count == 1)
                    {
                        con.Open();

                        SqlCommand cmd = new SqlCommand(@"UPDATE ABM
                        set Total_Withdraw = Total_Withdraw + '" + HMB.Text + "' WHERE User_Name = '" + UN.Text + "'", con);
                        cmd.ExecuteNonQuery();

                        SqlCommand cmd1 = new SqlCommand(@"UPDATE UserList
                        set Total_Withdraw = Total_Withdraw + '" + HMB.Text + "' WHERE User_Name = '" + UN.Text + "'", con);
                        cmd1.ExecuteNonQuery();

                        SqlCommand cmd2 = new SqlCommand(@"UPDATE BloodAvlList
                        set Total_Withdraw = Total_Withdraw + '" + HMB.Text + "' WHERE Blood_Group = 'AB-'", con);
                        cmd2.ExecuteNonQuery();

                        SqlCommand cmd3 = new SqlCommand(@"UPDATE BloodAvlList
                        set Available_No = Total_Fund - Total_Withdraw WHERE Blood_Group = 'AB-'", con);
                        cmd3.ExecuteNonQuery();

                        con.Close();

                        MessageBox.Show("Successfully Withdrawn....!!!");
                    }
                    else
                    {
                        MessageBox.Show("Invalid User Name !!!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                else if (BG.Text == "A+")
                {
                    SqlDataAdapter sda = new SqlDataAdapter("Select * From AP Where User_Name='" + UN.Text + "' ", con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    if (dt.Rows.Count == 1)
                    {
                        con.Open();

                        SqlCommand cmd = new SqlCommand(@"UPDATE AP
                        set Total_Withdraw = Total_Withdraw + '" + HMB.Text + "' WHERE User_Name = '" + UN.Text + "'", con);
                        cmd.ExecuteNonQuery();

                        SqlCommand cmd1 = new SqlCommand(@"UPDATE UserList
                        set Total_Withdraw = Total_Withdraw + '" + HMB.Text + "' WHERE User_Name = '" + UN.Text + "'", con);
                        cmd1.ExecuteNonQuery();

                        SqlCommand cmd2 = new SqlCommand(@"UPDATE BloodAvlList
                        set Total_Withdraw = Total_Withdraw + '" + HMB.Text + "' WHERE Blood_Group = 'A+'", con);
                        cmd2.ExecuteNonQuery();

                        SqlCommand cmd3 = new SqlCommand(@"UPDATE BloodAvlList
                        set Available_No = Total_Fund - Total_Withdraw WHERE Blood_Group = 'A+'", con);
                        cmd3.ExecuteNonQuery();

                        con.Close();

                        MessageBox.Show("Successfully Withdrawn....!!!");
                    }
                    else
                    {
                        MessageBox.Show("Invalid User Name !!!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                else if (BG.Text == "A-")
                {
                    SqlDataAdapter sda = new SqlDataAdapter("Select * From AM Where User_Name='" + UN.Text + "' ", con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    if (dt.Rows.Count == 1)
                    {
                        con.Open();

                        SqlCommand cmd = new SqlCommand(@"UPDATE AM
                        set Total_Withdraw = Total_Withdraw + '" + HMB.Text + "' WHERE User_Name = '" + UN.Text + "'", con);
                        cmd.ExecuteNonQuery();

                        SqlCommand cmd1 = new SqlCommand(@"UPDATE UserList
                        set Total_Withdraw = Total_Withdraw + '" + HMB.Text + "' WHERE User_Name = '" + UN.Text + "'", con);
                        cmd1.ExecuteNonQuery();

                        SqlCommand cmd2 = new SqlCommand(@"UPDATE BloodAvlList
                        set Total_Withdraw = Total_Withdraw + '" + HMB.Text + "' WHERE Blood_Group = 'A-'", con);
                        cmd2.ExecuteNonQuery();

                        SqlCommand cmd3 = new SqlCommand(@"UPDATE BloodAvlList
                        set Available_No = Total_Fund - Total_Withdraw WHERE Blood_Group = 'A-'", con);
                        cmd3.ExecuteNonQuery();

                        con.Close();

                        MessageBox.Show("Successfully Withdrawn....!!!");
                    }
                    else
                    {
                        MessageBox.Show("Invalid User Name !!!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                else
                {
                    MessageBox.Show("Invalid Blood Group !!!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

            else
            {
                MessageBox.Show("Fill The All Field !!!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Admin_Home obj = new Admin_Home();
            obj.Show();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
