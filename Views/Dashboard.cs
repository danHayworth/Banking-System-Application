using BankAccounts.Controllers;
using BankAccounts.Models;
using BankAccounts.Models.Accounts;
using BankAccounts.Views;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BankAccounts
{
    public partial class frmDashboard : Form
    {
        AccountController controller = new AccountController();
        public static int customerSelected;
        List<int> holdingAcc = new List<int>();
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
            if(CustomerController.userLogged == "admin")
            {
                btnAddAccounts.Visible = true;
            }
            else
            {
                btnCheck.Visible = true;
            }
            controller.GetAccounts();
            loadAccounts();
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

        private void btnAddAccounts_Click(object sender, EventArgs e)
        {
            this.Close();
            frmAddNewAccount x = new frmAddNewAccount();
            x.Show();
        }

        private void loadAccounts()
        {
            foreach(AccessClass c in controller.GetAccounts())
            {
                if(c.Customer == customerSelected)
                {
                    cmbAcc1.Items.Add(c.AccountType.ToString() + " " + c.Balance.ToString());
                    cmbAcc2.Items.Add(c.AccountType.ToString() + " " + c.Balance.ToString()) ;
                    holdingAcc.Add(c.Id); 
                    dataAccounts.Rows.Add(c.Id.ToString(), controller.getAccName(c.AccountType), c.Balance.ToString(), c.Interest.ToString(), c.Overdraft.ToString());
                }
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Close();
            dataAccounts.Rows.Clear();
            frmManager a = new frmManager();
            a.Show();
        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {

        }
    }
}
