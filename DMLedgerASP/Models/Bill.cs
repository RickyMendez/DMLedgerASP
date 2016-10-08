﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DMLedgerASP.Models
{
    public class Bill
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public double Balance { get; set; }

        public string DueDate { get; set; }
        
        public byte NewItemTypeId { get; set; }
    }
}