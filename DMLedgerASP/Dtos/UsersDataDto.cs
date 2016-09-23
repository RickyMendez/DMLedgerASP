using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DMLedgerASP.Models;

namespace DMLedgerASP.Dtos
{
    public class UsersDataDto
    {
        public BankAccountsDto bankAccounts { get; set; }

        public BillsDto bills { get; set; }

        public CreditCardsDto creditCards { get; set; }
    }
}