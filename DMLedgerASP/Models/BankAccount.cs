using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace DMLedgerASP.Models
{
    public class BankAccount
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [DataType(DataType.Currency)]
        [DisplayFormat(DataFormatString ="{0:C}")]
        public double Balance { get; set; }
    }
}