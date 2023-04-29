using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.Data.SqlClient;

namespace ATM
{
    public partial class UserWithdrawal : Form
    {
        public UserWithdrawal()
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
            getbalance();
            if(Dr.Text == "" || Convert.ToInt32(Dr.Text) <= 0)
            {
                MessageBox.Show("You can only Withdraw upto " + (25000 - withdrawtotal), "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(Convert.ToInt32(Dr.Text) < oldbalance)
            {
                MessageBox.Show("Invalid Balance", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                withdraw();
            }
           
        }

        private void withdraw()
        {
            try
            {
                getbalance();
                newbalance = oldbalance - Convert.ToInt32(Dr.Text);
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\User\OneDrive\Documents\ATM\ATM(Source Code)\ATM\Database\ATMDb.mdf"";Integrated Security=True");

                con.Open();
                string query = "UPDATE Account SET Balance ='" + newbalance + "' WHERE Account_No ='" + account + "' ";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();

                auto();
                addtransaction();
                MessageBox.Show("Successful Withdrawal", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Dr.Clear();

                con.Close();
                this.Hide();
                UserLogin ul = new UserLogin();
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




        private void addtransaction()
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\User\OneDrive\Documents\ATM\ATM(Source Code)\ATM\Database\ATMDb.mdf"";Integrated Security=True");

            date = DateTime.Now.ToString();
            try
            {
                type = "Withdrawal";
                con.Open();
                string query = "Insert Into Transactions Values('" + TID + "','" + account + "','" + type + "','" + Dr.Text + "','" + newbalance + "','" + date + "')";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void UserWithdrawal_Load(object sender, EventArgs e)
        {
 
        }

        private void Dr_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserLogin ul = new UserLogin();
            ul.ShowDialog();    
        }
    }
}
