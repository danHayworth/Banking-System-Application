﻿using BankAccounts.Models;
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
        public static List<Account> accounts = new List<Account>();
        public static List<Transactions> statement = new List<Transactions>();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmDashboard x = new frmDashboard();
            x.Show();
            txtUsername.Clear();
            txtPassword.Clear();
        }

        private void imgClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
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

        private void aFooter_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://developit.co.nz");
        }
    }
}
