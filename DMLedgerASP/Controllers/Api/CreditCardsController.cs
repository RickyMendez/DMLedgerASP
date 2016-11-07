using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DMLedgerASP.Dtos;
using DMLedgerASP.Models;
using AutoMapper;

namespace DMLedgerASP.Controllers.Api
{
    public class CreditCardsController : ApiController
    {

        private ApplicationDbContext _context;

        public CreditCardsController()
        {
            _context = new ApplicationDbContext();
        }
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET api/creditcards
        public IEnumerable<CreditCardsDto> GetCreditCards()
        {
            return _context.CreditCards.ToList().Select(Mapper.Map<CreditCard, CreditCardsDto>);
        }

        // GET api/creditcards/{id}
        public IHttpActionResult GetCreditCard(int id)
        {
            var creditCard = _context.CreditCards.SingleOrDefault(c => c.Id == id);
            if (creditCard == null)
            {
                return BadRequest();
            }
            return Ok(Mapper.Map<CreditCard, CreditCardsDto>(creditCard));
        }
        // POST api/creditcards
        [HttpPost]
        public IHttpActionResult CreateCreditCard([FromBody]CreditCardsDto creditCardDto)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var creditCard = Mapper.Map<CreditCardsDto, CreditCard>(creditCardDto);
            _context.CreditCards.Add(creditCard);
            _context.SaveChanges();
            creditCardDto.Id = creditCard.Id;

            return Created(new Uri(Request.RequestUri + "/" + creditCard.Id), creditCardDto);
        }

        // PUT api/creditcards/{id}
        [HttpPut]
        public void UpdateCreditCard(int id, [FromBody] CreditCardsDto creditCardDto)
        {
            if (!ModelState.IsValid)
                throw new HttpResponseException(HttpStatusCode.BadRequest);

            var creditCardInDb = _context.CreditCards.SingleOrDefault(c => c.Id == id);

            if (creditCardInDb == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            Mapper.Map(creditCardDto, creditCardInDb);

            _context.SaveChanges();
        }
        // DELETE api/creditcards/{id}
        [HttpDelete]
        public void DeleteCreditCard(int id)
        {
            var creditCardInDb = _context.CreditCards.SingleOrDefault(c => c.Id == id);

            if (creditCardInDb == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            _context.CreditCards.Remove(creditCardInDb);
            _context.SaveChanges();
        }
    }
}
