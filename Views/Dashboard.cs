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
        CustomerController contr = new CustomerController();
        public static int customerSelected;
        List<int> holdingAcc = new List<int>();
        int firstAcc;
        int secondAcc;
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
                    cmbAcc1.Items.Add(controller.getAccName(c.AccountType) + " " + c.Balance.ToString());
                    cmbAcc2.Items.Add(controller.getAccName(c.AccountType) + " " + c.Balance.ToString()) ;
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
            double bal = Convert.ToDouble(txtTransfer.Text);
            firstAcc = holdingAcc[cmbAcc1.SelectedIndex];
            secondAcc = holdingAcc[cmbAcc2.SelectedIndex];
            MessageBox.Show(firstAcc.ToString() + " " + secondAcc.ToString());
            if(cmbAcc1.SelectedIndex != cmbAcc2.SelectedIndex)
            {
                foreach (AccessClass x in AccountController.accounts)
                {
                    
                    if (x.Id == firstAcc)
                    {
                        controller.Withdraw(x.Id, x.AccountType, bal, contr.GetStaff(x.Customer), x.Overdraft);
                        break;
                    }
                }
                foreach (AccessClass x in AccountController.accounts)
                {
                    if (x.Id == secondAcc)
                    {
                        controller.Deposit(x.Id, bal);
                        break;
                    }
                }

                cmbAcc1.ResetText();
                cmbAcc2.ResetText();
                cmbAcc1.Items.Clear();
                cmbAcc2.Items.Clear();
                holdingAcc.Clear();
                txtTransfer.Text = "";
                dataAccounts.Rows.Clear();
                loadAccounts();

            }
            else
            {
                MessageBox.Show("Same account selected twice for transfer. Please check yout selection!");
            }
        }
    }
}
