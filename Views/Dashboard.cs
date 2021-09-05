using BankAccounts.Controllers;
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
            //start a timer that will display actual time
            timer1.Start();

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            // on load add label with accounts balance
            lblCustomerLogged.Text += CustomerController.userLoggedIn;
        }
       



        // creating an event for clock 
        private void timer_tick(object sender, EventArgs e)
        {
            lblClock.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        //add event for closing the application on x
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // add a logout event and display login form
        private void lblLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
            //clear the transactions and prepare the funds for next customer
 
            frmLogin x = new frmLogin();
            x.Show();
        }

        // add event to open the detailed form with everyday account details
        private void btnEveryday_Click(object sender, EventArgs e)
        {
            
            AccountDetail.accountName = "Everyday Account:";
            newDetailForm();
        }

        // add event that will open the investment account detail

        private void btnInvestment_Click(object sender, EventArgs e)
        {
          
            AccountDetail.accountName = "Investment Account:";
            newDetailForm();
        }

        // omni detailed form
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

        private void aFooter_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://developit.co.nz");
        }

    }
}
