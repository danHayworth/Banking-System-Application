using BankAccounts.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BankAccounts
{
    public partial class frmDashboard : Form
    {
        
        public frmDashboard()
        {
            InitializeComponent();
            //start timer
            timer1.Start();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            addAccountsBalances();
        }
        private void addAccountsBalances()
        {
            foreach (Account a in frmLogin.accounts)
            {
                if (a is EverydayAccount)
                {
                    lblEvery.Text = a.getBalance().ToString();
                }
                else if (a is InvestmentAccount)
                {
                    lblInvestment.Text = a.getBalance().ToString();
                }
                else if (a is OmniAccount)
                {
                    lblOmni.Text = a.getBalance().ToString();
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
            
            AccountDetail.accountName = "Everyday Account:";
            newDetailForm();
        }


        private void btnInvestment_Click(object sender, EventArgs e)
        {
          
            AccountDetail.accountName = "Investment Account:";
            newDetailForm();
        }

        private void btnOmni_Click(object sender, EventArgs e)
        {
         
            AccountDetail.accountName = "Omni Account:";
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
