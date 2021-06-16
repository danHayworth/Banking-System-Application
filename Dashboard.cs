using BankAccounts.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BankAccounts
{
    public partial class frmDashboard : Form
    {
        public static List<Account> accounts = new List<Account>();
        public frmDashboard()
        {
            InitializeComponent();
            //start timer
            timer1.Start();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            Account everyday = new EverydayAccount(1, 200.00);
            Account investment = new InvestmentAccount(2, 300.00, 3.5);
            Account omni = new OmniAccount(3, 150, 2.50, 500);

            if (accounts.Count.Equals(0))
            {
                accounts.Add(everyday);
                accounts.Add(investment);
                accounts.Add(omni);
            }
            addAccountsBalances();
        }

        private void addAccountsBalances()
        {
            foreach (Account a in accounts)
            {
                if(a is EverydayAccount)
                {
                    lblEvery.Text = "$" + a.getBalance().ToString();
                }
                else if(a is InvestmentAccount)
                {
                    lblInvestment.Text = "$" + a.getBalance().ToString();
                }
                else if (a is OmniAccount)
                {
                    lblOmni.Text = "$" + a.getBalance().ToString();
                }
            }
        }

        // creating an event for clock 
        private void timer_tick(object sender, EventArgs e)
        {
            lblClock.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
            frmLogin x = new frmLogin();
            x.Show();
        }

        private void btnEveryday_Click(object sender, EventArgs e)
        {
            newDetailForm();
        }


        private void btnInvestment_Click(object sender, EventArgs e)
        {
            newDetailForm();
        }

        private void btnOmni_Click(object sender, EventArgs e)
        {
            newDetailForm();
        }

        private void newDetailForm()
        {
            this.Close();
            AccountDetail y = new AccountDetail();
            y.Show();
        }
    }
}
