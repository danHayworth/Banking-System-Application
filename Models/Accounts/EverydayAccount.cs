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
        public EverydayAccount(double aBalance, int customer) : base(aBalance, customer)
        {
        }
    }
}
