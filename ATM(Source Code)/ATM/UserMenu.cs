using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM
{
    public partial class UserMenu : Form
    {
        public UserMenu()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Transfer_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserTransfer t = new UserTransfer();
            t.ShowDialog();
        }

        private void Withdrawal_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserWithdrawal w = new UserWithdrawal();
            w.ShowDialog();
        }

        private void Deposit_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserDeposit d = new UserDeposit();
            d.ShowDialog();
        }

        private void ChangePin_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserChangePIN cp = new UserChangePIN();
            cp.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserLogin ul = new UserLogin();
            ul.ShowDialog();
        }

        private void Balance_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserBalance b = new UserBalance();
            b.ShowDialog();
        }

        private void Title_Click(object sender, EventArgs e)
        {

        }
    }
}
