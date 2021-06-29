using BankAccounts.Controllers;
using System;
using System.Windows.Forms;

namespace BankAccounts.Models
{
    /* Student Id: 92060016
    * Name: Dan Hayworth
    * Date: 17-06-2021
    */
    //inherit account for everyday
    public class EverydayAccount : Account
    {
        public EverydayAccount(double aBalance) : base(aBalance)
        {
        }
        //overriding withdrawal
        public override void Withdraw(double withdraw)
        {
            if(_aBalance < withdraw)
            {
                //if not enough funds send notification and display balance
                MessageBox.Show("Not sufficient funds for this withdrawal. Your balance is "+ GetBalance());
            }
            else
            {
                _aBalance -= withdraw;
                
                if(withdraw > 0)
                {
                    //if there are funds, withdraw, send notification and record transaction
                    MessageBox.Show("Transfer complete. Your new balance is " + GetBalance());
                    var withd = new Transactions(DateTime.Now, "Withdrawal", withdraw, GetBalance());
                    TransactionController.statement.Add(withd);
                }
                
            }   
            
        }
    }
}
