using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DMLedgerASP.Dtos;
using DMLedgerASP.Models;

namespace DMLedgerASP.Controllers.Api
{
    public class UsersController : ApiController
    {
        private ApplicationDbContext _context;

        public UsersController()
        {
            _context = new ApplicationDbContext();
        }

        // GET api/users
        // GET api/users/{id}
        // POST api/users
        // PUT api/users/{id}
        // DELETE api/user/{id}
    }
}
