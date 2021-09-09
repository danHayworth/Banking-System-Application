using BankAccounts.Controllers;
using BankAccounts.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;


namespace BankAccounts.Views
{
    public partial class frmAddNewAccount : Form
    {
        /// <summary>
        /// A form to add a new account for customers
        /// </summary>
        public static string customer = "";
        public static int custId;
        AccountController accCont = new AccountController();
        public frmAddNewAccount()
        {
            InitializeComponent();
            txtCustomerName.Text = customer;
            accCont.GetAccounts();           
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Close();
            frmDashboard y = new frmDashboard();
            y.Show();
        }

        private void btnAddAccount_Click(object sender, EventArgs e)
        {
            Account x;
            if(cmbAccountType.SelectedIndex == 0)
            {
                x = new EverydayAccount(Convert.ToDouble(txtBalance.Text), custId);
            }
            else if(cmbAccountType.SelectedIndex == 1)
            {
                x = new InvestmentAccount(Convert.ToDouble(txtBalance.Text), Convert.ToDouble(txtInterest.Text), custId);
            }
            else
            {
                x = new OmniAccount(Convert.ToDouble(txtBalance.Text), Convert.ToDouble(txtInterest.Text), Convert.ToDouble(txtOverdraft.Text), custId);
            }
            accCont.AddAccount(x.GetCustomer(), cmbAccountType.SelectedIndex+1, x.GetBalance(), x.GetInterest(), x.GetOverdraft());
            this.Close();
            frmDashboard y = new frmDashboard();
            y.Show();

        }
    }
}
