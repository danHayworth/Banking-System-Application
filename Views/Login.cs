using BankAccounts.Controllers;
using BankAccounts.Models;
using BankAccounts.Views;
using Microsoft.VisualBasic;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace BankAccounts
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {          
            var user = txtUsername.Text;
            var pass = txtPassword.Text;
            var isLogged = "";
            foreach(Customer a in CustomerController.people)
            {
                if (a.GetUsername() == user && a.GetPassword() == pass)
                {
                    CustomerController.isClient.Add(a);
                    CustomerController.userLogged = user;
                    isLogged = a.GetName();
                    frmDashboard.customerSelected = a.GetId();
                }
            }
            if (CustomerController.isClient.Exists(x => x.GetUsername() == user) && ValidateForm())
            {
                if (user == "admin")
                {
                    //on login hide this form and open a new dashboard form
                    this.Hide();
                    CustomerController.userLoggedIn = isLogged;
                    frmManager y = new frmManager();
                    y.Show();
                }
                else
                {
                    //on login hide this form and open a new dashboard form
                    this.Hide();
                    CustomerController.userLoggedIn = isLogged;
                    frmDashboard y = new frmDashboard();
                    y.Show();
                    //clear the fields
                    txtUsername.Clear();
                    txtPassword.Clear();
                }            
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
            this.Close();
            frmMain x = new frmMain();
            x.Show();
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

        /////// ****    Validation    ****    \\\\\\\\

        private bool ValidateUsername()
        {
            bool iStats = true;
            //if null provide error
            if (txtUsername.Text == "")
            {
                errorLogin.SetError(txtUsername, "Username cannot be blank");
                iStats = false;
            }
            else
            {
                errorLogin.SetError(txtUsername, "");
            }
            return iStats;
        }

        private bool ValidatePassword()
        {
            bool iStats = true;
            //if null provide error
            if (txtPassword.Text == "")
            {
                errorLogin.SetError(txtPassword, "Password cannot be blank");
                iStats = false;
            }
            else
            {
                errorLogin.SetError(txtPassword, "");
            }
            return iStats;
        }

        private void txtUsername_Validating(object sender, CancelEventArgs e)
        {
            ValidateUsername();
        }

        private void txtPassword_Validating(object sender, CancelEventArgs e)
        {
            ValidatePassword();
        }

        private bool ValidateForm()
        {
            bool valid = false;
            if (ValidateUsername() &&  ValidatePassword())
            {
                valid = true;
            }
            else
            {
                valid = false;
            }
            return valid;
        }
    }
}
