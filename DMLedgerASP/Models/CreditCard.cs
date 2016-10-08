using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace DMLedgerASP.Models
{
    public class CreditCard
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public double Limit { get; set; }

        public double Balance { get; set; }

        public string DueDate { get; set; }

        public byte NewItemTypeId { get; set; }
    }
}