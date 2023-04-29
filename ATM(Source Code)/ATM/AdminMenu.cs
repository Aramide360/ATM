using ATM.Admin;
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
    public partial class AdminMenu : Form
    {
        public AdminMenu()
        {
            InitializeComponent();
        }

        private void register_Click(object sender, EventArgs e)
        {
            this.Close();
            Register r = new Register();
            r.ShowDialog();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Balance_Click(object sender, EventArgs e)
        {
            this.Close();
            AdminBalance ab = new AdminBalance();
            ab.ShowDialog();
        }

        private void ChangePin_Click(object sender, EventArgs e)
        {
            this.Close();
            AdminChangePin ul = new AdminChangePin();
            ul.ShowDialog();
        }

        private void Withdrawal_Click(object sender, EventArgs e)
        {
            this.Close();
            AdminWithdrawal aw = new AdminWithdrawal(); 
            aw.ShowDialog();
        }

        private void Deposit_Click(object sender, EventArgs e)
        {
            this.Close();
            AdminDeposit ad = new AdminDeposit();
            ad.ShowDialog();
        }

        private void Transfer_Click(object sender, EventArgs e)
        {
            this.Close();
            AdminTransfer ad = new AdminTransfer();
            ad.ShowDialog();
        }

        private void logout_Click(object sender, EventArgs e)
        {
            this.Close();
            AdminLogin al = new AdminLogin();
            al.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Register r = new Register();
            r.ShowDialog();
        }
    }
}
