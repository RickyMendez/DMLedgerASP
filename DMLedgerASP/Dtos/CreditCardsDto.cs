using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace DMLedgerASP.Dtos
{
    public class CreditCardsDto
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