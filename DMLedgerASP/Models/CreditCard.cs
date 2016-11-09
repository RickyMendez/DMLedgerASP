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

        public float Limit { get; set; }

        public float Balance { get; set; }

        public float Payment { get; set; }

        public string DueDate { get; set; }
    }
}