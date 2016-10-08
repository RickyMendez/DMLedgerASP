using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Data.Entity;
using DMLedgerASP.Dtos;
using DMLedgerASP.Models;
//using System.Web.Mvc;
using AutoMapper;

namespace DMLedgerASP.Controllers.Api
{
    public class UsersController : ApiController
    {
        private ApplicationDbContext _context;

        public UsersController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET api/users
        public IHttpActionResult GetUserData()
        {
            var bankAccountsInDb = _context.BankAccounts.ToList().Select(Mapper.Map<BankAccount, BankAccountsDto>);
            var billsInDb = _context.Bills.ToList().Select(Mapper.Map<Bill, BillsDto>);
            var creditCardsInDb = _context.CreditCards.ToList().Select(Mapper.Map<CreditCard, CreditCardsDto>);

            var results = new UsersDataDto
            {
                BankAccounts = bankAccountsInDb,
                Bills = billsInDb,
                CreditCards = creditCardsInDb
            };
            
            return Ok(results);
        }
        // GET api/users/{id}
        // POST api/users
        // PUT api/users/{id}
        // DELETE api/user/{id}
        [HttpDelete]
        public void Delete(int typeId, int id)
        {
            var bankAccountInDb = _context.BankAccounts.SingleOrDefault(c => c.Id == id);
            switch (typeId)
            {
                case 0:
                    if (bankAccountInDb == null)
                        throw new HttpResponseException(HttpStatusCode.NotFound);
                    _context.BankAccounts.Remove(bankAccountInDb);
                    break;
                default:
                    break;
            }

        }
    }
}
