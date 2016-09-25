﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DMLedgerASP.Models;

namespace DMLedgerASP.ViewModels
{
    public class UserAccountDataViewModel
    {
        public IEnumerable<NewItemType> NewItemTypes { get; set; }
        public UserData UserData { get; set; }
    }
}