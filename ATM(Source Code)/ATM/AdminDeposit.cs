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

namespace ATM.Admin
{
    public partial class AdminDeposit : Form
    {
        public AdminDeposit()
        {
            InitializeComponent();
        }

        string account;
        int oldbalance;
        int newbalance;
        int withdrawtotal;
        int d;
        string date;
        string type;
        string TID;

        Random random = new Random();
        private void auto()
        {
            for (int i = 0; i < 1; i++)
            {
                TID = "" + random.Next(10000, 99999);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            account = AdminLogin.accountNo;
            type = "Deposit";
            getwt();
            getd();
            getbalance();
            if (withdrawtotal + Convert.ToInt32(Cr.Text) > 25000)
            {
                MessageBox.Show("You can only Withdraw upto " + (25000 - withdrawtotal));
            }
            else
            {
                if (Cr.Text == "")
                {
                    MessageBox.Show("Enter The Amount To Deposit", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (Convert.ToInt32(Cr.Text) <= 0)
                {
                    MessageBox.Show("No Negative Values Or Zeros Allowed", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (withdrawtotal >= 25000 || date == DateTime.Now.ToString())
                {
                    MessageBox.Show("Exceeded your limit for the day ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (d >= 5)
                {
                    MessageBox.Show("Exceeded your limit for the day ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (Convert.ToInt32(Cr.Text) > oldbalance)
                {
                    MessageBox.Show("Insufficient Balance", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    deposit();
                }
            }
        }

        private void deposit()
        {
            try
            {
                getbalance();
                newbalance = oldbalance + Convert.ToInt32(Cr.Text);
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\User\OneDrive\Documents\ATM\ATM(Source Code)\ATM\Database\ATMDb.mdf"";Integrated Security=True");

                con.Open();
                string query = "UPDATE Account SET Balance ='" + newbalance + "' WHERE Account_No ='" + account + "' ";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();

                auto();
                addtransaction();
                MessageBox.Show("Successfully Deposited", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Cr.Clear();

                con.Close();
                this.Hide();
                AdminLogin ul = new AdminLogin();
                ul.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void getbalance()
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\User\OneDrive\Documents\ATM\ATM(Source Code)\ATM\Database\ATMDb.mdf"";Integrated Security=True");

            con.Open();
            string query = "Select Balance From Account Where Account_No = '" + account + "' ";
            SqlCommand cm = new SqlCommand(query, con);
            oldbalance = Convert.ToInt32(cm.ExecuteScalar());
            con.Close();
        }


        private void getwt()
        {
            account = AdminLogin.accountNo;
            type = "Deposit";
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\User\OneDrive\Documents\ATM\ATM(Source Code)\ATM\Database\ATMDb.mdf"";Integrated Security=True");

            con.Open();
            string query = "Select SUM(Amount) From Transactions Where Account = '" + account + "' and Transaction_Type = '" + type + "' ";
            SqlCommand cm = new SqlCommand(query, con);
            withdrawtotal = Convert.ToInt32(cm.ExecuteScalar());
            con.Close();
        }

        private void getd()
        {
            account = AdminLogin.accountNo;
            type = "Deposit";
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\User\OneDrive\Documents\ATM\ATM(Source Code)\ATM\Database\ATMDb.mdf"";Integrated Security=True");

            con.Open();
            string query = "Select Count(Date) From Transactions Where Account='" + account + "' and Transaction_Type='" + type + "' ";
            SqlCommand cm = new SqlCommand(query, con);
            d = Convert.ToInt32(cm.ExecuteScalar());
            con.Close();
        }

        private void addtransaction()
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\User\OneDrive\Documents\ATM\ATM(Source Code)\ATM\Database\ATMDb.mdf"";Integrated Security=True");

            date = DateTime.Now.ToString();
            try
            {
                type = "Withdrawal";
                con.Open();
                string query = "Insert Into Transactions Values('" + TID + "','" + account + "','" + type + "','" + Cr.Text + "','" + newbalance + "','" + date + "')";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
