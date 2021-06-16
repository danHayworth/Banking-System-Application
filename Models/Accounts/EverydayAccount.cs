using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankAccounts.Models
{
    public class EverydayAccount : Account
    {
        public EverydayAccount(int aId, double aBalance) : base(aId, aBalance)
        {
        }

        public override void Withdraw(double withdraw)
        {
            if(_aBalance < withdraw)
            {
                MessageBox.Show("Not sufficient funds for this withdrawal.");
            }
            else
            {
                _aBalance -= withdraw;
                MessageBox.Show("Transfer complete.");
            }   
            
        }
    }
}
