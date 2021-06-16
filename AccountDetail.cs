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
    public partial class AccountDetail : Form
    {
        public static string accountName;
        public AccountDetail()
        {
            InitializeComponent();
            timer2.Start();
    
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        // creating an event for clock 
        private void timer_tick2(object sender, EventArgs e)
        {
            lblClock.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void AccountDetail_Load(object sender, EventArgs e)
        {
            lblDetail.Text += accountName;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Close();
            frmDashboard x = new frmDashboard();
            x.Show();
        }
    }
}
