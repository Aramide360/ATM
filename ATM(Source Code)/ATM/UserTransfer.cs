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
    public partial class UserTransfer : Form
    {
        public UserTransfer()
        {
            InitializeComponent();
        }

        int creditorbalance;
        int debitorbalance;
        int new_creditorbalance;
        int new_debitorbalance;
        string debitorname;
        string creditorname;
        int TID;

        Random random = new Random();
        private void auto()
        {
            for (int i = 0; i < 1; i++)
            {
                TID = random.Next(10000, 99999);
            }
        }
        
        private void Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserLogin ul = new UserLogin();
            ul.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            getdebitorbalance();
            getcreditorbalance();
            getdebitorname();
            getcreditorname();
            if (DAN.Text == "" || CAN.Text == "")
            {
                MessageBox.Show("Input Debitor's Account or Creditor's Account", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (Convert.ToInt32(DAN.Text) > debitorbalance)
            {
                MessageBox.Show("Invalid Balance", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Debit();
                Credit();
                addtransaction();
                this.Hide();
                UserLogin ul = new UserLogin();
                ul.ShowDialog();
            }
        }

        private void getcreditorbalance()
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\User\OneDrive\Documents\ATM\ATM(Source Code)\ATM\Database\ATMDb.mdf"";Integrated Security=True");

            con.Open();
            string query = "Select Balance From Account Where Account_No = '" + CAN.Text + "' ";
            SqlCommand cm = new SqlCommand(query, con);
            creditorbalance = Convert.ToInt32(cm.ExecuteScalar());
            con.Close();
        }

        private void getdebitorbalance()
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\User\OneDrive\Documents\ATM\ATM(Source Code)\ATM\Database\ATMDb.mdf"";Integrated Security=True");

            con.Open();
            string query = "Select Balance From Account Where Account_No = '" + DAN.Text + "' ";
            SqlCommand cm = new SqlCommand(query, con);
            debitorbalance = Convert.ToInt32(cm.ExecuteScalar());
            con.Close();
        }

        private void getdebitorname()
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\User\OneDrive\Documents\ATM\ATM(Source Code)\ATM\Database\ATMDb.mdf"";Integrated Security=True");

            con.Open();
            string query = "Select Name From Account Where Account_No = '" + DAN.Text + "' ";
            SqlCommand cm = new SqlCommand(query, con);
            debitorname = Convert.ToString(cm.ExecuteScalar());
            con.Close();
        }

        private void getcreditorname()
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\User\OneDrive\Documents\ATM\ATM(Source Code)\ATM\Database\ATMDb.mdf"";Integrated Security=True");

            con.Open();
            string query = "Select Name From Account Where Account_No = '" + CAN.Text + "' ";
            SqlCommand cm = new SqlCommand(query, con);
            creditorname = Convert.ToString(cm.ExecuteScalar());
            con.Close();
        }

        private void Credit()
        {
            try
            {
                getcreditorbalance();
                new_creditorbalance = creditorbalance + Convert.ToInt32(Amount.Text);
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\User\OneDrive\Documents\ATM\ATM(Source Code)\ATM\Database\ATMDb.mdf"";Integrated Security=True");

                con.Open();
                string query = "UPDATE Account SET Balance ='" + new_creditorbalance + "' WHERE Account_No ='" + CAN.Text + "' ";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                addtransaction();
                MessageBox.Show("Successfully Credited", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Amount.Clear();

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Debit()
        {
            try
            {
                getdebitorbalance();
                new_debitorbalance = debitorbalance - Convert.ToInt32(Amount.Text);
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\User\OneDrive\Documents\ATM\ATM(Source Code)\ATM\Database\ATMDb.mdf"";Integrated Security=True");

                con.Open();
                string query = "UPDATE Account SET Balance ='" + new_debitorbalance + "' WHERE Account_No ='" + DAN.Text + "' ";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                addtransaction();
                MessageBox.Show("Successfully Debited", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Amount.Clear();

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void addtransaction()
        {
            auto();
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\User\OneDrive\Documents\ATM\ATM(Source Code)\ATM\Database\ATMDb.mdf"";Integrated Security=True");

            string date = DateTime.Now.ToString();
            try
            {
                con.Open();
                string query = "Insert Into Transfer Values('" + TID + "','" + debitorname + "','" + DAN.Text + "','" + new_debitorbalance + "','" + creditorname + "','" + CAN.Text + "','" + new_creditorbalance + "','" + Amount.Text + "','" + date + "')";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void UserTransfer_Load(object sender, EventArgs e)
        {

        }
    }
}
