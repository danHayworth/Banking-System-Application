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
        /// <summary>
        /// A form that will be accessed only by admin
        /// and will be able to Add, Delete, Edit Customer and 
        /// add new accounts to customers
        /// </summary>
        AccountController controller = new AccountController();
        CustomerController contr = new CustomerController();
        public static int customerSelected;
        /// <summary>
        /// setting a list that will hold the index of database for accounts
        /// </summary>
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
        /// <summary>
        /// creating a method that can be called anytime to avoid 
        /// repetitive code
        /// This will clear the list, clear the table, reset the selected values
        /// and then will insert the updated values
        /// </summary>
        private void loadAccounts()
        {
            holdingAcc.Clear();
            dataAccounts.Rows.Clear();
            cmbAcc1.ResetText();
            cmbAcc2.ResetText();
            cmbAcc1.Items.Clear();
            cmbAcc2.Items.Clear();
            txtTransfer.Text = "";
            foreach (AccessClass c in controller.GetAccounts())
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
            
            if(cmbAcc1.SelectedIndex != cmbAcc2.SelectedIndex && txtTransfer.Text != "")
            {
                double bal = Convert.ToDouble(txtTransfer.Text);
                firstAcc = holdingAcc[cmbAcc1.SelectedIndex];
                secondAcc = holdingAcc[cmbAcc2.SelectedIndex];
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
                MessageBox.Show("Transfer complete!");
                
                loadAccounts();
            }
            else
            {
                MessageBox.Show("Same account selected twice for transfer, and or no value for transfer. Please check yout selection!");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            string funds = dataAccounts.SelectedRows[0].Cells["Balance"].Value.ToString();
            if(funds != "0")
            {
                MessageBox.Show("Please transfer the funds before closing the account");
            }
            else
            {
                int id = Convert.ToInt32(dataAccounts.SelectedRows[0].Cells["Id"].Value.ToString());
                controller.DeleteAccount(id);
                MessageBox.Show("Account deleted");
                loadAccounts();
            }

        }

        private void dataAccounts_SelectionChanged(object sender, EventArgs e)
        {
            btnClose.Enabled = true;
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            AccountDetail.accountId = Convert.ToInt32(dataAccounts.SelectedRows[0].Cells["Id"].Value.ToString());
            AccountDetail x = new AccountDetail();
            x.Show();
            this.Close();
        }
    }
}
