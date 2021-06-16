using BankAccounts.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankAccounts
{
    public partial class AccountDetail : Form
    {
        public static string accountName;
        public static string interest;
        public AccountDetail()
        {
            InitializeComponent();
            timer2.Start();  
        }

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
            lblDetail.Text += accountName;
            if (accountName != "")
            {
                foreach (Account a in frmLogin.accounts)
                {
                    if (a is EverydayAccount && accountName == "Everyday Account:")
                    {
                        interest = a.GetInterest().ToString();
                    }
                    else if (a is InvestmentAccount && accountName == "Investment Account:")
                    {
                        interest = a.GetInterest().ToString();
                    }
                    else if (a is OmniAccount && accountName == "Omni Account:")
                    {
                        interest = a.GetInterest().ToString();
                    }
                }
            }
            txtInterest.Text = interest;
            addTransactions();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Close();
            frmLogin.statement.Clear();
            frmDashboard x = new frmDashboard();
            x.Show();
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            if(accountName != "")
            {
                foreach (Account a in frmLogin.accounts)
                {
                    if(a is EverydayAccount && accountName == "Everyday Account:")
                    {
                        a.Deposit(Double.Parse(txtDeposit.Text));
                        dataStatement.Rows.Clear();
                        addTransactions();
                        txtDeposit.Text = "0";
                    }
                    else if (a is InvestmentAccount && accountName == "Investment Account:")
                    {
                        a.Deposit(Double.Parse(txtDeposit.Text));
                        dataStatement.Rows.Clear();
                        addTransactions();
                        txtDeposit.Text = "0";
                    }
                    else if (a is OmniAccount && accountName == "Omni Account:")
                    {
                        a.Deposit(Double.Parse(txtDeposit.Text));
                        dataStatement.Rows.Clear();
                        addTransactions();
                        txtDeposit.Text = "0";
                    }
                }
            }
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            if (accountName != "")
            {
                foreach (Account a in frmLogin.accounts)
                {
                    if (a is EverydayAccount && accountName == "Everyday Account:")
                    {
                        a.Withdraw(Double.Parse(txtWithdraw.Text));
                        dataStatement.Rows.Clear();
                        addTransactions();
                        txtWithdraw.Text = "0";
                    }
                    else if (a is InvestmentAccount && accountName == "Investment Account:")
                    {
                        a.Withdraw(Double.Parse(txtWithdraw.Text));
                        dataStatement.Rows.Clear();
                        addTransactions();
                        txtWithdraw.Text = "0";
                    }
                    else if (a is OmniAccount && accountName == "Omni Account:")
                    {
                        a.Withdraw(Double.Parse(txtWithdraw.Text));
                        dataStatement.Rows.Clear();
                        addTransactions();
                        txtWithdraw.Text = "0";
                    }
                }
            }
        }

        private void btnAddinterest_Click(object sender, EventArgs e)
        {
            if (accountName != "")
            {
                foreach (Account a in frmLogin.accounts)
                {
                    if (a is EverydayAccount && accountName == "Everyday Account:")
                    {
                        MessageBox.Show("This account does not have interest.");
                        a.CalculateInterest(Double.Parse(txtInterest.Text));
                    }
                    else if (a is InvestmentAccount && accountName == "Investment Account:")
                    {
                        a.CalculateInterest(Double.Parse(txtInterest.Text));
                        MessageBox.Show("Acrued interest has been added. \nYour new balance is " + a.getBalance());
                        dataStatement.Rows.Clear();
                        addTransactions();

                    }
                    else if (a is OmniAccount && accountName == "Omni Account:")
                    {
                        if(a.getBalance() >= 1000) 
                        {
                            a.CalculateInterest(Double.Parse(txtInterest.Text));
                            MessageBox.Show("Acrued interest has been added. \nYour new balance is " + a.getBalance());
                            dataStatement.Rows.Clear();
                            addTransactions();
                        }
                        else
                        {
                            MessageBox.Show("Interest can be added only if minimum balance of 'B 1000'");
                        }

                    }
                }
            }
        }

        private void addTransactions()
        {
            //setting a loop for every transactions in list of transactions
            foreach (Transactions b in frmLogin.statement)
            {             
                dataStatement.Rows.Add(b.Id().ToString(), b.Date().ToString(), b.Type(), b.Amount().ToString(), b.Balance().ToString());
                
            }
        }
    }
}
