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
    public partial class UserChangePIN : Form
    {
        public UserChangePIN()
        {
            InitializeComponent();
        }
        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Title_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void confirmPin_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string account = UserLogin.accountNo;
            string pin = UserLogin.pin;
            try
            {

                if (oldPin.Text == "" || confirmPin.Text == "" || newPin.Text == "")
                {
                    MessageBox.Show("Please , Enter Valied Pin", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (oldPin.Text != pin)
                {
                    MessageBox.Show("Incorrect PIN", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else if (newPin.Text != confirmPin.Text)
                {
                    MessageBox.Show("PIN Doesn't Matched", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\User\OneDrive\Documents\ATM\ATM(Source Code)\ATM\Database\ATMDb.mdf"";Integrated Security=True");

                    con.Open();
                    String str = "Update Account Set Pin = '" + confirmPin.Text + "' Where Account_No = '" + account + "'";
                    SqlCommand cmd = new SqlCommand(str, con);
                    cmd.ExecuteNonQuery();
                    SqlDataReader dr = cmd.ExecuteReader();

                    if (dr.Read())
                    {

                        MessageBox.Show("Your PIN Has Been Changed Successfully", "Sucesss", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        confirmPin.Clear();
                        newPin.Clear();
                        oldPin.Clear();
                        this.Hide();
                        UserLogin ul = new UserLogin(); 
                        ul.ShowDialog();    
                    }
                    else
                    {
                        MessageBox.Show("Your PIN Change Failed", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }

                    con.Close();

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserLogin mm = new UserLogin();
            mm.ShowDialog();
        }

        private void oldPin_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
