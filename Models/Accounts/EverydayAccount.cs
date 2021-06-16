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
                MessageBox.Show("Not sufficient funds for this withdrawal. Your balance is "+ getBalance());
            }
            else
            {
                _aBalance -= withdraw;
                MessageBox.Show("Transfer complete. Your new balance is "+ getBalance());
                if(withdraw > 0)
                {
                    var withd = new Transactions(DateTime.Now, "Withdrawal", withdraw, getBalance());
                    frmLogin.statement.Add(withd);
                }
                
            }   
            
        }
    }
}
