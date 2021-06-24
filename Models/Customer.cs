using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccounts.Models
{
    /* Student Id: 92060016
    * Name: Dan Hayworth
    * Date: 17-06-2021
    */
    public class Customer
    {
        private int Id;
        private string Name;
        private string Username;
        private string Password;
        private string Contact;
        private int Staff;

        public Customer(System.Int64 Id, string Name, string Contact, string Username, string Password, System.Int64 Staff )
        {
            this.Id = (int)Id;
            this.Name = Name;
            this.Contact = Contact;
            this.Username = Username;
            this.Password = Password;
            this.Staff = (int)Staff;
        }

        public int getId() => Id;
        public string getName() => Name;
        public string getContact() => Contact;
        public string getUsername() => Username;
        public string getPassword() => Password;
        public int getStaff() => Staff;

    }
}
