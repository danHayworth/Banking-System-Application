using BankAccounts.Data;
using BankAccounts.Models;
using System;
using System.Windows.Forms;

namespace BankAccounts.Views
{
    public partial class frmManager : Form
    {
        public int customer;
        CustomerController cust = new CustomerController();
        frmMain f = new frmMain();
        public frmManager()
        {
            InitializeComponent();
            timer5.Start();
            AddClients();
            lblManagerLogged.Text += CustomerController.userLoggedIn;
        }

        // creating an event for clock 
        private void timer_tick(object sender, EventArgs e)
        {
            lblClock.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        public void AddClients()
        {
            CustomerController.people = cust.GetCustomers();
            dataClients.Rows.Clear();
            string returnBool;
            //setting a loop for every transactions in list of transactions
            foreach (Customer b in CustomerController.people)
            {
                if(b.GetStaff() == 1) { returnBool = "Yes"; } else { returnBool = "No"; }
                dataClients.Rows.Add(b.GetId().ToString(), b.GetName().ToString(), b.GetContact().ToString(), b.GetUsername(), returnBool);
            }
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
            f.Show();
        }

        private void lblLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
            f.Show();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.Close();
            frmAddEdit.title = "Add";
            frmAddEdit a = new frmAddEdit();
            a.Show();      
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            this.Close();
            frmAddEdit.title = "Edit";
            frmAddEdit.editing = customer;
            frmAddEdit b = new frmAddEdit();
            b.Show();           
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(customer >= 0)
            { 
                cust.DeleteCustomer(customer);
                MessageBox.Show("Customer deleted.");
                AddClients();
            }           
        }

        private void dataClients_SelectionChanged(object sender, EventArgs e)
        {
            if (dataClients.SelectedCells.Count > 0)
            {
                int selectedrowindex = dataClients.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataClients.Rows[selectedrowindex];
                string idValue = Convert.ToString(selectedRow.Cells["ID"].Value);
                frmAddEdit.name = Convert.ToString(selectedRow.Cells["CName"].Value);
                frmAddEdit.contact = Convert.ToString(selectedRow.Cells["Contact"].Value);
                frmAddEdit.user = Convert.ToString(selectedRow.Cells["Username"].Value);
                string staff = Convert.ToString(selectedRow.Cells["Staff"].Value);
                if(staff == "Yes")
                {
                    frmAddEdit.staff = 1;
                }
                else
                {
                    frmAddEdit.staff = 0;
                }
                if (idValue != "")
                {
                    customer = Int32.Parse(idValue);
                }               
            }
        }
    }
}

