using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM
{
    public partial class AdminLogin : Form
    {
        public AdminLogin()
        {
            InitializeComponent();
        }

        public static String accountNo;
        public static String pin;
        private void label4_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserLogin ul = new UserLogin();
            ul.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (accountNoTb.Text == "")
            {
                MessageBox.Show("Enter Your Account Number", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (pinTb.Text == "")
            {
                MessageBox.Show("Enter Your Pin", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\User\OneDrive\Documents\ATM\ATM(Source Code)\ATM\Database\ATMDb.mdf"";Integrated Security=True");
                    con.Open();
                    SqlCommand cmd;
                    cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "Select * From Account Where Account_No = '" + accountNoTb.Text + "' and Pin = '" + pinTb.Text + "'";
                    cmd.ExecuteNonQuery();

                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        accountNo = accountNoTb.Text;
                        pin = pinTb.Text;
                        this.Hide();
                        AdminMenu menu = new AdminMenu();
                        menu.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Wrong Account Number Or PIN", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Register r = new Register();
            r.ShowDialog(); 
        }
    }
}
