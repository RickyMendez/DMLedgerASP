using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DMLedgerASP.Dtos;
using DMLedgerASP.Models;
using AutoMapper;
using System.Web.Mvc;

namespace DMLedgerASP.Controllers.Api
{
    public class BankAccountsController : ApiController
    {
        private ApplicationDbContext _context;

        public BankAccountsController()
        {
            _context = new ApplicationDbContext();
        }

        // GET api/bankaccounts
        public IEnumerable<BankAccountsDto> GetBankAccounts()
        {
            return _context.BankAccounts.ToList().Select(Mapper.Map<BankAccount, BankAccountsDto>);
        }

        // GET api/bankaccounts/{id}
        public IHttpActionResult GetBankAccount(int id)
        {
            var bankAccount = _context.BankAccounts.SingleOrDefault(c => c.Id == id);
            if (bankAccount == null)
            {
                return BadRequest();
            }
            return Ok(Mapper.Map<BankAccount, BankAccountsDto>(bankAccount));
        }
        // POST api/bankaccounts
        [System.Web.Http.HttpPost]
        public BankAccountsDto CreateBankAccount(BankAccountsDto bankAccountDto)
        {
            if (!ModelState.IsValid)
                throw new HttpResponseException(HttpStatusCode.BadRequest);

            var bankAccount = Mapper.Map<BankAccountsDto, BankAccount>(bankAccountDto);
            _context.BankAccounts.Add(bankAccount);
            _context.SaveChanges();
            bankAccountDto.Id = bankAccount.Id;
            return bankAccountDto;
        }

        // PUT api/bankaccounts/{id}
        [System.Web.Http.HttpPut]
        public void UpdateBankAccount(int id, BankAccountsDto bankAccountDto)
        {
            if (!ModelState.IsValid)
                throw new HttpResponseException(HttpStatusCode.BadRequest);

            var bankAccountInDb = _context.BankAccounts.SingleOrDefault(c => c.Id == id);

            if (bankAccountInDb == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            Mapper.Map(bankAccountDto, bankAccountInDb);

            _context.SaveChanges();
        }
        // DELETE api/bankaccounts/{id}
        [System.Web.Http.HttpDelete]
        public void DeleteBankAccount(int id)
        {
            var bankAccountInDb = _context.BankAccounts.SingleOrDefault(c => c.Id == id);

            if (bankAccountInDb == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            _context.BankAccounts.Remove(bankAccountInDb);
            _context.SaveChanges();
        }
    }
}
