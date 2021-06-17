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
        public string overdraft;
        public string balance;
        public string accNumber;
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
                        overdraft = a.GetOverdraft().ToString();
                        accNumber = a.getId().ToString();
                        balance = a.getBalance().ToString();
                    }
                    else if (a is InvestmentAccount && accountName == "Investment Account:")
                    {
                        interest = a.GetInterest().ToString();
                        overdraft = a.GetOverdraft().ToString();
                        accNumber = a.getId().ToString();
                        balance = a.getBalance().ToString();
                    }
                    else if (a is OmniAccount && accountName == "Omni Account:")
                    {
                        interest = a.GetInterest().ToString();
                        overdraft = a.GetOverdraft().ToString();
                        accNumber = a.getId().ToString();
                        balance = a.getBalance().ToString();
                    }
                }
            }
            txtAccBal.Text = "B "+balance;
            txtAccNum.Text = "06-0998-00"+accNumber;
            txtAccInter.Text = interest+ " %";
            txtInterest.Text = interest;
            txtAccOver.Text = "B "+overdraft;
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
                        txtDeposit.Text = "0.00";
                    }
                    else if (a is InvestmentAccount && accountName == "Investment Account:")
                    {
                        a.Deposit(Double.Parse(txtDeposit.Text));
                        dataStatement.Rows.Clear();
                        addTransactions();
                        txtDeposit.Text = "0.00";
                    }
                    else if (a is OmniAccount && accountName == "Omni Account:")
                    {
                        a.Deposit(Double.Parse(txtDeposit.Text));
                        dataStatement.Rows.Clear();
                        addTransactions();
                        txtDeposit.Text = "0.00";
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
                        txtWithdraw.Text = "0.00";
                    }
                    else if (a is InvestmentAccount && accountName == "Investment Account:")
                    {
                        a.Withdraw(Double.Parse(txtWithdraw.Text));
                        dataStatement.Rows.Clear();
                        addTransactions();
                        txtWithdraw.Text = "0.00";
                    }
                    else if (a is OmniAccount && accountName == "Omni Account:")
                    {
                        a.Withdraw(Double.Parse(txtWithdraw.Text));
                        dataStatement.Rows.Clear();
                        addTransactions();
                        txtWithdraw.Text = "0.00";
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
                            MessageBox.Show("Interest can be added only if minimum balance is 'B 1000'");
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
