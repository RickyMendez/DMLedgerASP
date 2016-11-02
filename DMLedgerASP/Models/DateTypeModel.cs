using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DMLedgerASP.Models
{
    public class DateTypeModel
    {
        public byte Id { get; set; }


        public IEnumerable<DateTypeList> DateType { get; set; }
        
    }


}