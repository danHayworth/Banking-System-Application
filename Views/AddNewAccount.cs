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
                if(txtBalance.Text != "")
                {
                    x = new EverydayAccount(Convert.ToDouble(txtBalance.Text), custId);
                    Validate(x);
                }
                else
                {
                    MessageBox.Show("Please add an amount for opening the account!");
                    x = null;
                }
                
            }
            else if(cmbAccountType.SelectedIndex == 1)
            {
                if (txtBalance.Text != "")
                {
                    x = new InvestmentAccount(Convert.ToDouble(txtBalance.Text), Convert.ToDouble(txtInterest.Text), custId);
                    Validate(x);
                }
                else
                {
                    MessageBox.Show("Please add an amount for opening the account!");
                    x = null;
                }

            }
            else if(cmbAccountType.SelectedIndex == 2)
            {
                if(txtBalance.Text != "" && txtOverdraft.Text != "")
                {
                    x = new OmniAccount(Convert.ToDouble(txtBalance.Text), Convert.ToDouble(txtInterest.Text), Convert.ToDouble(txtOverdraft.Text), custId);
                    Validate(x);
                }
                else
                {
                    MessageBox.Show("Amount for opening balance and amount for overdraft are required!");
                    x = null;
                }
                
            }
            else
            {
                MessageBox.Show("Please select an account!");
            }
            

        }
        private void Validate( Account x)
        {
            accCont.AddAccount(x.GetCustomer(), cmbAccountType.SelectedIndex + 1, x.GetBalance(), x.GetInterest(), x.GetOverdraft());
            this.Close();
            frmDashboard y = new frmDashboard();
            y.Show();
        }

        private void txtBalance_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && (e.KeyChar != 8 && e.KeyChar != 46))
            {
                e.Handled = true;
            }
        }

        private void txtOverdraft_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && (e.KeyChar != 8 && e.KeyChar != 46))
            {
                e.Handled = true;
            }
        }

        private void cmbAccountType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbAccountType.SelectedIndex == 0)
            {
                txtInterest.Visible = false;
                txtOverdraft.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
                label5.Visible = false;
            }
            else if(cmbAccountType.SelectedIndex == 1)
            {
                label2.Visible = true;
                txtInterest.Visible = true;
                txtOverdraft.Visible = false;
                label3.Visible = false;
                label5.Visible = true;
            }
            else
            {
                label3.Visible = true;
                label2.Visible = true;
                label5.Visible = true;
                txtInterest.Visible = true;
                txtOverdraft.Visible = true;
            }
        }
    }
}
