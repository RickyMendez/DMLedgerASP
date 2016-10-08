using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DMLedgerASP.Models;

namespace DMLedgerASP.Dtos
{
    public class UsersDataDto
    {
        public IEnumerable<BankAccountsDto> BankAccounts { get; set; }

        public IEnumerable<BillsDto> Bills { get; set; }

        public IEnumerable<CreditCardsDto> CreditCards { get; set; }
    }
}