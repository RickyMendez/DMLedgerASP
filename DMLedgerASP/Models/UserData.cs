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
        public BankAccount bankAccounts { get; set; }

        public Bill bills { get; set; }

        public CreditCard creditCards { get; set; }

        public NewItemType NewItemType { get; set; }

        [Display (Name = "New Item")]
        public byte NewItemTypeId { get; set; }
    }
}