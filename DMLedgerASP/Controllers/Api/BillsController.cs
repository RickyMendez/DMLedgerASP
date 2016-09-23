using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DMLedgerASP.Models;
using AutoMapper;

namespace DMLedgerASP.Controllers.Api
{
    public class BillsController : ApiController
    {

        private ApplicationDbContext _context;

        public BillsController()
        {
            _context = new ApplicationDbContext();
        }
        // GET api/bills
        // GET api/bills/{id}
        // POST api/bills
        // PUT api/bills/{id}
        // DELETE api/bills/{id}
    }
}
