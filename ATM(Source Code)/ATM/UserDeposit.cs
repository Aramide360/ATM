using DocumentFormat.OpenXml.Office.Word;
using DocumentFormat.OpenXml.Wordprocessing;
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
    public partial class UserDeposit : Form
    {
        public UserDeposit()
        {
            InitializeComponent();
        }

        string account;
        int oldbalance;
        int newbalance;
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
             
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (Cr.Text == "" || Convert.ToInt32(Cr.Text) <= 0)
            {
                MessageBox.Show("Enter The Amount To Deposit");
            }
            else
            {
                account = UserLogin.accountNo;
                try
                {
                    getbalance();
                    newbalance = oldbalance + Convert.ToInt32(Cr.Text);
                    SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\User\OneDrive\Documents\ATM\ATM(Source Code)\ATM\Database\ATMDb.mdf"";Integrated Security=True");

                    con.Open();
                    string query = "UPDATE Account SET Balance ='"+ newbalance +"' WHERE Account_No ='"+ account +"' ";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();

                    auto();
                    addtransaction();
                    MessageBox.Show("Successfully Deposited", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Cr.Clear();

                    con.Close();
                    this.Hide();
                    UserLogin ul = new UserLogin();
                    ul.ShowDialog();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);    
                }
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
                type = "Deposit";
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

        private void bal_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserLogin ul = new UserLogin();
            ul.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }
    }
}

