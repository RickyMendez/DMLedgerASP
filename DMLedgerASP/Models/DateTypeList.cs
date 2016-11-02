using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DMLedgerASP.Models
{
    public class DateTypeList
    {
        public byte Id { get; set; }

        public MonthlyModel MonthlyModel { get; set; }

        public YearlyModel YearlyModel { get; set; }
    }
}