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
    public class BillsController : ApiController
    {

        private ApplicationDbContext _context;

        public BillsController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET api/bills
        public IEnumerable<BillsDto> GetBills()
        {
            return _context.Bills.ToList().Select(Mapper.Map<Bill, BillsDto>);
        }

        // GET api/bills/{id}
        public IHttpActionResult GetBills(int id)
        {
            var bill = _context.Bills.SingleOrDefault(c => c.Id == id);
            if (bill == null)
            {
                return BadRequest();
            }
            return Ok(Mapper.Map<Bill, BillsDto>(bill));
        }
        // POST api/bills
        [HttpPost]
        public IHttpActionResult CreateBill([FromBody]BillsDto billDto)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var bill = Mapper.Map<BillsDto, Bill>(billDto);
            _context.Bills.Add(bill);
            _context.SaveChanges();
            billDto.Id = bill.Id;

            return Created(new Uri(Request.RequestUri + "/" + bill.Id), billDto);
        }

        // PUT api/bills/{id}
        [HttpPut]
        public void UpdateBill(int id, [FromBody] BillsDto billDto)
        {
            if (!ModelState.IsValid)
                throw new HttpResponseException(HttpStatusCode.BadRequest);

            var billInDb = _context.Bills.SingleOrDefault(c => c.Id == id);

            if (billInDb == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            Mapper.Map(billDto, billInDb);

            _context.SaveChanges();
        }

        // DELETE api/bills/{id}
        [HttpDelete]
        public void DeleteBill(int id)
        {
            var billInDb = _context.Bills.SingleOrDefault(c => c.Id == id);

            if (billInDb == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            _context.Bills.Remove(billInDb);
            _context.SaveChanges();
        }
    }
}
