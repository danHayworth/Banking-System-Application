using BankAccounts.Controllers;
using BankAccounts.Models;
using BankAccounts.Models.Accounts;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BankAccounts
{
    public partial class AccountDetail : Form
    {
        public static int accountId;
       
        AccountController accAction = new AccountController();
        CustomerController custom = new CustomerController();
        public AccountDetail()
        {
            InitializeComponent();
            timer2.Start();        
        }

        // event for closing 
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        // creating an event for clock 
        private void timer_tick2(object sender, EventArgs e)
        {
            lblClock.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void AccountDetail_Load(object sender, EventArgs e)
        {
            LoadAccount();
            addTransactions();
        }

        // go back method 
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Close();
            TransactionController.statement.Clear();
            frmDashboard x = new frmDashboard();
            x.Show();
        }


        private void btnDeposit_Click(object sender, EventArgs e)
        {
            accAction.Deposit(accountId, Convert.ToDouble(txtDeposit.Text.ToString()));
            LoadAccount();
            txtDeposit.Text = "0.00";
        }


        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            AccessClass y = accAction.GetAccountById(accountId);
            accAction.Withdraw(y.Id, y.AccountType, Convert.ToDouble(txtWithdraw.Text.ToString()), custom.GetStaff(y.Customer), y.Overdraft);
            LoadAccount();
            txtWithdraw.Text = "0.00";
        }


        private void btnAddinterest_Click(object sender, EventArgs e)
        {
            AccessClass z = accAction.GetAccountById(accountId);
            accAction.Deposit(z.Id, Convert.ToDouble((accAction.getAccBalance(z.Id) * z.Interest) / 100));
            LoadAccount();
        }

        private void LoadAccount()
        {
            AccessClass x = accAction.GetAccountById(accountId);
            // add the account name
            lblDetail.Text = "BitBank "+ accAction.getAccName(x.AccountType);
            // add the details of the account 
            txtAccBal.Text = "B " + x.Balance.ToString();
            txtAccNum.Text = x.Id.ToString();
            txtAccInter.Text = x.Interest.ToString() + " %";
            txtInterest.Text = x.Interest.ToString();
            txtAccOver.Text = "B " + x.Overdraft.ToString();
        }

        private void addTransactions()
        {
            //setting a loop for every transactions in list of transactions
            foreach (Transactions b in TransactionController.statement)
            {             
                dataStatement.Rows.Add(b.Id().ToString(), b.Date().ToString(), b.Type(), b.Amount().ToString(), b.Balance().ToString());
                txtAccBal.Text ="B "+ b.Balance().ToString();
            }
        }

        private void txtDeposit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && (e.KeyChar != 8 && e.KeyChar != 46))
            {
                e.Handled = true;
            }
        }

        private void txtDeposit_MouseClick(object sender, MouseEventArgs e)
        {
            txtDeposit.Text = "";
        }

        private void txtWithdraw_MouseClick(object sender, MouseEventArgs e)
        {
            txtWithdraw.Text = "";
        }

        private void lblLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
            frmLogin x = new frmLogin();
            x.Show();
        }
    }
}
