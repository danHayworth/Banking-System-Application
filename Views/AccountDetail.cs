using BankAccounts.Controllers;
using BankAccounts.Models;
using System;
using System.Windows.Forms;

namespace BankAccounts
{
    public partial class AccountDetail : Form
    {
        // set up variables for account details
        public static string accountName;
        public static string interest;
        public string overdraft;
        public string balance;
        public string accNumber;
        readonly AccountController AccController = new AccountController();
        public AccountDetail()
        {
            InitializeComponent();
            timer2.Start();
            AccController.AddAccounts();
            
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
            // add the account name
            lblDetail.Text += accountName;
            if (accountName != "")
            {
                // fetch all details about each type of account and add the values to the variables
                foreach (Account a in AccController.accounts)
                {
                    if (a is EverydayAccount && accountName == "Everyday Account:")
                    {
                        SetAccDetails(a);
                    }
                    else if (a is InvestmentAccount && accountName == "Investment Account:")
                    {
                        SetAccDetails(a);
                    }
                    else if (a is OmniAccount && accountName == "Omni Account:")
                    {
                        SetAccDetails(a);
                    }
                }
            }
            // add the details of the account 
            txtAccBal.Text = "B "+balance;
            txtAccNum.Text = "06-0998-00"+accNumber;
            txtAccInter.Text = interest+ " %";
            txtInterest.Text = interest;
            txtAccOver.Text = "B "+overdraft;
            addTransactions();
        }
        void SetAccDetails(Account x)
        {
            interest = x.GetInterest().ToString();
            overdraft = x.GetOverdraft().ToString();
            accNumber = x.GetId().ToString();
            balance = x.GetBalance().ToString();
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
            if(accountName != "")
            {
                //  deposit button event for making deposits 
                foreach (Account a in AccController.accounts)
                {
                    if(a is EverydayAccount && accountName == "Everyday Account:")
                    {
                        SetDeposit(a);
                    }
                    else if (a is InvestmentAccount && accountName == "Investment Account:")
                    {
                        SetDeposit(a);
                    }
                    else if (a is OmniAccount && accountName == "Omni Account:")
                    {
                        SetDeposit(a);
                    }
                }
            }
        }
        private void SetDeposit(Account x)
        {
            x.Deposit(Double.Parse(txtDeposit.Text));
            dataStatement.Rows.Clear();
            addTransactions();
            txtDeposit.Text = "0.00";
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            if (accountName != "")
            {
                // withdraw button event
                foreach (Account a in AccController.accounts)
                {
                    if (a is EverydayAccount && accountName == "Everyday Account:")
                    {
                        SetWithdraw(a);
                    }
                    else if (a is InvestmentAccount && accountName == "Investment Account:")
                    {
                        SetWithdraw(a);
                    }
                    else if (a is OmniAccount && accountName == "Omni Account:")
                    {
                        SetWithdraw(a);
                    }
                }
            }
        }
        private void SetWithdraw(Account x)
        {
            x.Withdraw(Double.Parse(txtWithdraw.Text));
            dataStatement.Rows.Clear();
            addTransactions();
            txtWithdraw.Text = "0.00";
        }

        private void btnAddinterest_Click(object sender, EventArgs e)
        {
            if (accountName != "")
            {
                // add interest button event
                foreach (Account a in AccController.accounts)
                {
                    if (a is EverydayAccount && accountName == "Everyday Account:")
                    {
                        MessageBox.Show("This account does not have interest.");
                    }
                    else if (a is InvestmentAccount && accountName == "Investment Account:")
                    {
                        SetInterest(a);
                    }
                    else if (a is OmniAccount && accountName == "Omni Account:")
                    {
                        if(a.GetBalance() >= 1000) 
                        {
                            SetInterest(a);
                        }
                        else
                        {
                            MessageBox.Show("Interest can be added only if balance is over 'B 1000'");
                        }
                    }
                }
            }
        }
        private void SetInterest(Account x)
        {
            x.CalculateInterest(Double.Parse(txtInterest.Text));
            MessageBox.Show("Acrued interest has been added. \nYour new balance is " + x.GetBalance());
            dataStatement.Rows.Clear();
            addTransactions();
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
