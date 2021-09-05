using BankAccounts.Controllers;
using BankAccounts.Models;
using System;
using System.Windows.Forms;

namespace BankAccounts.Views
{
    public partial class frmAddNewAccount : Form
    {
        public static string customer = "";
        public static int custId;
        AccountController accCont = new AccountController();
        public frmAddNewAccount()
        {
            InitializeComponent();
            txtCustomerName.Text = customer;

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

            accCont.AddAccount(x.GetId(),x.GetCustomer(), cmbAccountType.SelectedIndex, x.GetBalance(), x.GetInterest(), x.GetOverdraft());
            MessageBox.Show(accCont.GetAccounts().ToString());
        }
    }
}
