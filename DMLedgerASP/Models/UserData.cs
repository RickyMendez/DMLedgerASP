using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DMLedgerASP.Models;
using System.ComponentModel.DataAnnotations;

namespace DMLedgerASP.Models
{
    public class UserData
    {
        public int Id { get; set; }

        public IEnumerable<BankAccount> BankAccounts { get; set; }


        public IEnumerable<Bill> Bills { get; set; }


        public IEnumerable<CreditCard> CreditCards { get; set; }


        public DateTypeList NewItemType { get; set; }
        
    }
}