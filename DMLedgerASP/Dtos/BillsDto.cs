using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace DMLedgerASP.Dtos
{
    public class BillsDto
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public double Balance { get; set; }

        public string DueDate { get; set; }
    }
}