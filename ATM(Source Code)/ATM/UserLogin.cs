using DocumentFormat.OpenXml.Office.Word;
using System.Data;
using System.Data.SqlClient;

namespace ATM
{
    public partial class UserLogin : Form
    {
        public UserLogin()
        {
            InitializeComponent();
        }

        public static String accountNo;
        public static String pin;
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Title_Click(object sender, EventArgs e)
        {

        }

        private void phoneNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (accountNoTb.Text == "")
            {
                MessageBox.Show("Enter Your Account Number");
            }
            else if(pinTb.Text == "")
            {
                MessageBox.Show("Enter Your Pin");
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
                        UserMenu menu = new UserMenu();
                        menu.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Wrong Account Number Or PIN");
                    }
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void adminLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminLogin al = new AdminLogin();
            al.ShowDialog();
        }

        private void pinTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}