using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccounts.Models
{
    class Customer
    {
        [Key]
        private int _cId;
        private string _cName;
        private string _cContact;
        private bool _isStaff;

        public Customer(int cId, string cName, string cContact, bool isStaff )
        {
            _cId = cId;
            _cName = cName;
            _cContact = cContact;
            _isStaff = isStaff;
        }

        public int getId()
        {
            return _cId;
        }
        public string getName()
        {
            return _cName;
        }
        public string getContact()
        {
            return _cContact;
        }
        public bool getStaff()
        {
            return _isStaff;
        }
    }
}
