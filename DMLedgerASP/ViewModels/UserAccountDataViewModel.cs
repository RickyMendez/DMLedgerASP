using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DMLedgerASP.Models;

namespace DMLedgerASP.ViewModels
{
    public class UserAccountDataViewModel
    {
        public List<BankAccount> BankAccounts { get; set; }
        public List<CreditCard> CreditCards { get; set; }
    }
}