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
    public partial class Reports : Form
    {
        public Reports()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Account_Reports_Load(object sender, EventArgs e)
        {
         
        }

        private void account_load()
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\User\OneDrive\Documents\ATM\ATM(Source Code)\ATM\Database\ATMDb.mdf"";Integrated Security=True");
            string query = "SELECT * FROM Account";
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            var dt = new DataTable();
            da.Fill(dt);
            dataGridView.DataSource = dt;
        }

        private void withdrawal_load()
        {
            string type = "Withdrawal";
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\User\OneDrive\Documents\ATM\ATM(Source Code)\ATM\Database\ATMDb.mdf"";Integrated Security=True");
            string query = "SELECT * FROM Transactions Where Transaction_Type ='" + type + "' Date ='" + date.Text + "' ";
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            var dt = new DataTable();
            da.Fill(dt);
            dataGridView.DataSource = dt;
        }

        private void deposit_load()
        {
            string type = "Deposit";
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\User\OneDrive\Documents\ATM\ATM(Source Code)\ATM\Database\ATMDb.mdf"";Integrated Security=True");
            string query = "SELECT * FROM Transactions Where Transaction_Type ='"+ type +"' Date ='"+ date.Text +"' ";
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            var dt = new DataTable();
            da.Fill(dt);
            dataGridView.DataSource = dt;
        }

        private void transfer_load()
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\User\OneDrive\Documents\ATM\ATM(Source Code)\ATM\Database\ATMDb.mdf"";Integrated Security=True");
            string query = "SELECT * FROM Tranfer Where Date = '"+ date.Text +"'";
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            var dt = new DataTable();
            da.Fill(dt);
            dataGridView.DataSource = dt;
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void accountrep_Click(object sender, EventArgs e)
        {
            account_load();
        }

        private void withdrawalrep_Click(object sender, EventArgs e)
        {
            withdrawal_load();
        }

        private void depositrep_Click(object sender, EventArgs e)
        {
            deposit_load();
        }

        private void transferrep_Click(object sender, EventArgs e)
        {
            transfer_load();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminLogin al = new AdminLogin();
            al.ShowDialog();
        }
    }
}
