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
    }
}
