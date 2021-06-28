using BankAccounts.Data;
using System;
using System.Windows.Forms;

namespace BankAccounts.Views
{
    public partial class frmMain : Form
    {
 
        public frmMain()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEveryday_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmManager x = new frmManager();
            x.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin x = new frmLogin();
            x.Show();
        }

        private void aFooter_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://developit.co.nz");
        }
    }
}
