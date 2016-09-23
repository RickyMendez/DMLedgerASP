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
    public class CrediCardsController : ApiController
    {

        private ApplicationDbContext _context;

        public CrediCardsController()
        {
            _context = new ApplicationDbContext();
        }
        // GET api/creditcards
        // GET api/creditcard/{id}
        // POST api/creditcards
        // PUT api/creditcards/{id}
        // DELETE api/creditcards/{id}
    }
}
