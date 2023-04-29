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
    public partial class UserBalance : Form
    {
        public UserBalance()
        {
            InitializeComponent();
        }

        string account;
        private void bal_Click(object sender, EventArgs e)
        {

        }
        private void getbalance()
        {
            account = UserLogin.accountNo;
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\User\OneDrive\Documents\ATM\ATM(Source Code)\ATM\Database\ATMDb.mdf"";Integrated Security=True");

            con.Open();
            string query = "Select Balance From Account Where Account_No = '" + account + "' ";
            SqlCommand cm = new SqlCommand(query, con);
            bal.Text = Convert.ToString(cm.ExecuteScalar());
        }

        private void getname()
        {
            account = UserLogin.accountNo;
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\User\OneDrive\Documents\ATM\ATM(Source Code)\ATM\Database\ATMDb.mdf"";Integrated Security=True");

            con.Open();
            string query = "Select Name From Account Where Account_No = '" + account + "' ";
            SqlCommand cm = new SqlCommand(query, con);
            name.Text = Convert.ToString(cm.ExecuteScalar());
            con.Close();
        }

        private void Balance_Load(object sender, EventArgs e)
        {
            accountno.Text = UserLogin.accountNo;
            getname();
            getbalance();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserLogin mm = new UserLogin();
            mm.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bal_Click_1(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
