using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankAccounts.Views
{
    public partial class frmAddEdit : Form
    {
        /// <summary>
        /// A form to add a new customer
        /// </summary>
        CustomerController cust = new CustomerController();
        frmManager a = new frmManager();
        public static string title;
        public static int editing;
        public static string name;
        public static string contact;
        public static string user;
        public static string pass;
        public static int staff;
        public frmAddEdit()
        {
            InitializeComponent();
            SetUp();
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            a.Show();
            this.Close();
        }
        /// <summary>
        /// A method to pull and set the details of the customer
        /// from the database if the user chose to edit details
        /// </summary>
        private void SetUp()
        {
            lblTitle.Text = title + lblTitle.Text;
            if (title == "Edit")
            {
                txtName.Text = name;
                txtContact.Text = contact;
                txtPass.Text = "";
                txtUser.Text = user;
                cmbStaff.SelectedIndex = staff;
                btnAdd.Text = "Save";
            }
            else
            {
                btnAdd.Text = "Add";
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            name = txtName.Text;
            contact = txtContact.Text;
            user = txtUser.Text;
            pass = txtPass.Text;
            staff = cmbStaff.SelectedIndex;

            DisplayData();              
            txtPass.Clear();
            txtName.Clear();
            txtContact.Clear();
            txtUser.Clear();
            cmbStaff.ResetText();
        }
        /// <summary>
        /// A method to change the text value of the button Save or Add
        /// </summary>
        public void DisplayData()
        {
            if (btnAdd.Text == "Add")
            {
                cust.SaveCustomer(name, contact, user, pass, staff);
                var result = MessageBox.Show("Customer added. Would you like to add another one?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No)
                {
                    a.AddClients();
                    this.Close();
                    a.Show();
                }
            }
            else
            {
                cust.UpdateCustomer(editing, name, contact, user, pass, staff);
                MessageBox.Show("Customer updated.", "Confirmation");
                a.AddClients();
                this.Close();
                a.Show();
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Close();
            frmManager x = new frmManager();
            x.Show();
        }
    }
}
