using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DMLedgerASP.Models;
using DMLedgerASP.Dtos;
using AutoMapper;

namespace DMLedgerASP.Controllers.Api
{
    public class NewItemTypesController : ApiController
    {
        private ApplicationDbContext _context;

        public NewItemTypesController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: api/newitemtypes
        public IEnumerable<NewItemTypesDto> GetNewItemTypes()
        {
            return _context.NewItemTypes.ToList().Select(Mapper.Map<NewItemType, NewItemTypesDto>);
        }
    }
}
