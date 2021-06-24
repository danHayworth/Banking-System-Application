using BankAccounts.Data;
using BankAccounts.Models;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankAccounts
{
    public partial class frmLogin : Form
    {
        // set up 2 list one for accounts and one for transactions since we will keep this form as the main one
        public static List<Account> accounts = new List<Account>();
        public static List<Transactions> statement = new List<Transactions>();
        protected static List<Customer> people = new List<Customer>();
        protected static List<Customer> isClient = new List<Customer>();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var user = txtUsername.Text;
            var pass = txtPassword.Text;
            var isLogged = "";
            foreach(Customer c in people)
            {
                if (c.getUsername() == user && c.getPassword() == pass)
                {
                    isClient.Add(c);
                    isLogged = c.getName();
                }
            }
            if(isClient.Exists(x => x.getUsername().Contains(user)))
            {
                //on login hide this form and open a new dashboard form
                this.Hide();
                frmDashboard.user = isLogged;
                frmDashboard y = new frmDashboard();
                y.Show();
                //clear the fields
                txtUsername.Clear();
                txtPassword.Clear();
                
            } else
            {
                MessageBox.Show("Wrong credentials, please check your details");
                txtUsername.Clear();
                txtPassword.Clear();
            }
            

        }

        // close application on click x
        private void imgClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // on load add the new accounts to the list
        private void frmLogin_Load(object sender, EventArgs e)
        {
            people = SqliteConnection.GetCustomers();
            Account everyday = new EverydayAccount(200.00);
            Account investment = new InvestmentAccount(1000.00, 10);
            Account omni = new OmniAccount(1500, 10, 500);

            if (accounts.Count.Equals(0))
            {
                accounts.Add(everyday);
                accounts.Add(investment);
                accounts.Add(omni);
            }
        }

        // display a pop up asking for email on both forgot password and forgot username
        private void linkLblForgot_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string email = Interaction.InputBox("Enter your email address", "Account email", " ");
            MessageBox.Show("An email with a link to reset your password has been sent to " + email, "Confirmation");
        }

        private void linkLblUser_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string email = Interaction.InputBox("Enter your email address", "Account email", " ");
            MessageBox.Show("An email with your username has been sent to " + email, "Confirmation");
        }

        //copyright
        private void aFooter_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://developit.co.nz");
        }
    }
}
