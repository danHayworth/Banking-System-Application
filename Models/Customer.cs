using System.Collections.Generic;

namespace BankAccounts.Models
{
    /* Student Id: 92060016
    * Name: Dan Hayworth
    * Date: 17-06-2021
    */

    public class Customer
    {
        private int Id { get; set; }
        private string Name { get; set; }
        private string Username { get; set; }
        private string Password { get; set; }
        private string Contact { get; set; }
        private int Staff { get; set; }

        public Customer()
        {
        }

        public Customer(string Name, string Contact, string Username, string Password, int Staff)
        {
            this.Name = Name;
            this.Contact = Contact;
            this.Username = Username;
            this.Password = Password;
            this.Staff = Staff;
        }

        public int GetId() => Id;
        public string GetName() => Name;
        public string GetContact() => Contact;
        public string GetUsername() => Username;
        public string GetPassword() => Password;
        public int GetStaff() => Staff;

        

    }
}
