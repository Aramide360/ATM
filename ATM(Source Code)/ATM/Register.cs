using System.Data.SqlClient;

namespace ATM
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        Random random = new Random();

        private void auto_accountno()
        {
            for (int i = 0; i < 1; i++)
            {
                accountNoTb.Text = "" + random.Next(10000000, 99999999);
            }
        }
        private void auto_pin()
        {
            for (int i = 0; i < 1; i++)
            {
                pinTb.Text = "" + random.Next(1000, 9999);
            }
        }
        private void Admin_Load(object sender, EventArgs e)
        {
            accountNoTb.Enabled = false;
            auto_accountno();
            pinTb.Enabled = false;
            auto_pin();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\User\OneDrive\Documents\ATM\ATM(Source Code)\ATM\Database\ATMDb.mdf"";Integrated Security=True");

                if (accountNoTb.Text == "" || pinTb.Text == "" || nameTb.Text == "" || genderTb.Text == "" || dobTb.Text == "" || educationTb.Text == "" || occupationTb.Text == "" || emailTb.Text == "" || phoneNoTb.Text == "" || addressTb.Text == "")
                {
                    MessageBox.Show("Missing Information");
                }
                else
                {
                    con.Open();
                    string query = "INSERT INTO Account Values('" + accountNoTb.Text + "','" + pinTb.Text + "','" + nameTb.Text + "','" + genderTb.Text + "','" + dobTb.Text + "','" + educationTb.Text + "','" + occupationTb.Text + "','" + emailTb.Text + "','" + phoneNoTb.Text + "','" + addressTb.Text + "' )";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Account Created Successfully");
                }
                con.Close();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void accountNoTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminLogin al = new AdminLogin();
            al.ShowDialog();
        }
    }
}
