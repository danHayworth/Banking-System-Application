using System;
using System.Windows.Forms;

namespace BankAccounts.Views
{
    public partial class frmMain : Form
    {
        frmLogin x = new frmLogin();
        CustomerController cust = new CustomerController();
        public frmMain()
        {
            InitializeComponent();
            CustomerController.people = cust.GetCustomers();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEveryday_Click(object sender, EventArgs e)
        {
            this.Hide();
            x.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            x.Show();
        }

        private void aFooter_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://developit.co.nz");
        }
    }
}
